using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace SupabaseLoadTest
{
    class Program
    {
        // Supabase credentials
        public static readonly string SupabaseUrl = "https://ezinxnacbigjfvsqhkqk.supabase.co";
        public static readonly string SupabaseKey = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJpc3MiOiJzdXBhYmFzZSIsInJlZiI6ImV6aW54bmFjYmlnamZ2c3Foa3FrIiwicm9sZSI6ImFub24iLCJpYXQiOjE3NDIwNDEyNjQsImV4cCI6MjA1NzYxNzI2NH0.x6tZQ4a1I6lYi00mVzAykydq5NdaoKzwp8Dm9jr5GZ8";

        private static readonly HttpClient _httpClient = new HttpClient();

        static async Task Main(string[] args)
        {
            Console.WriteLine("Supabase API Load Testing Tool");
            Console.WriteLine("===============================");

            // Set up HttpClient
            _httpClient.BaseAddress = new Uri(SupabaseUrl);
            _httpClient.DefaultRequestHeaders.Add("apikey", SupabaseKey);
            _httpClient.DefaultRequestHeaders.Add("Authorization", $"Bearer {SupabaseKey}");

            // Test parameters
            Console.Write("Enter number of requests to send: ");
            int requestCount = int.Parse(Console.ReadLine() ?? "100");

            Console.Write("Enter concurrency level (number of parallel requests): ");
            int concurrencyLevel = int.Parse(Console.ReadLine() ?? "10");

            Console.WriteLine("\nStarting load test...\n");

            // Run the load test
            await RunLoadTest(requestCount, concurrencyLevel);

            Console.WriteLine("\nLoad test completed. Press any key to exit...");
            Console.ReadKey();
        }

        static async Task RunLoadTest(int totalRequests, int concurrencyLevel)
        {
            var tasks = new List<Task>();
            var stopwatch = Stopwatch.StartNew();

            for (int i = 0; i < totalRequests; i++)
            {
                if (tasks.Count >= concurrencyLevel)
                {
                    var completedTask = await Task.WhenAny(tasks);
                    tasks.Remove(completedTask);
                }

                tasks.Add(SendRequestWithLogging(i));
            }

            await Task.WhenAll(tasks);
            stopwatch.Stop();
            Console.WriteLine($"\nTotal test time: {stopwatch.Elapsed.TotalSeconds:F2} seconds");
        }

        static async Task SendRequestWithLogging(int requestId)
        {
            var stopwatch = Stopwatch.StartNew();
            try
            {
                // Теперь используем только ваш endpoint с таблицей
                string endpoint = "rest/v1/Test";

                // Генерируем тестовые данные для вашей таблицы
                var testData = new
                {
                    name = $"Test Item {Guid.NewGuid().ToString().Substring(0, 8)}",
                    created_at = DateTime.UtcNow.ToString("o")
                };

                var content = new StringContent(JsonConvert.SerializeObject(testData), Encoding.UTF8, "application/json");

                // Отправляем POST запрос для создания записи
                var response = await _httpClient.PostAsync(endpoint, content);

                // Или GET запрос для чтения данных (раскомментируйте, если нужно)
                // var response = await _httpClient.GetAsync(endpoint + "?select=*");

                var elapsedMs = stopwatch.ElapsedMilliseconds;
                var responseBody = await response.Content.ReadAsStringAsync();

                Console.WriteLine($"Request #{requestId + 1}: {endpoint} - " +
                                $"Status: {response.StatusCode} - " +
                                $"Time: {elapsedMs}ms - " +
                                $"Response: {(responseBody.Length > 50 ? responseBody.Substring(0, 50) + "..." : responseBody)}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Request #{requestId + 1}: Failed - {ex.Message}");
            }
        }
    }
}