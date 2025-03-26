using Supabase.Postgrest.Models;
using Supabase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Supabase.Postgrest;

namespace JobAppLibrary
{
    public class SupabaseStatisticsService
    {
        public static readonly string SupabaseUrl = "https://ezinxnacbigjfvsqhkqk.supabase.co";
        public static readonly string SupabaseKey = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJpc3MiOiJzdXBhYmFzZSIsInJlZiI6ImV6aW54bmFjYmlnamZ2c3Foa3FrIiwicm9sZSI6ImFub24iLCJpYXQiOjE3NDIwNDEyNjQsImV4cCI6MjA1NzYxNzI2NH0.x6tZQ4a1I6lYi00mVzAykydq5NdaoKzwp8Dm9jr5GZ8";

        private Supabase.Client _supabase;

        public async Task Initialize()
        {
            var options = new SupabaseOptions
            {
                AutoConnectRealtime = true
            };

            _supabase = new Supabase.Client(SupabaseUrl, SupabaseKey, options);
            await _supabase.InitializeAsync();
        }

        public async Task DisplayStatistics()
        {
            try
            {
                await Initialize();

                var tasks = new Task[]
                {
                GetCount<Vacancy>("Вакансии"),
                GetCount<Resume>("Резюме"),
                GetCount<User>("Пользователи"),
                GetCount<Invitation>("Приглашения"),
                GetCount<Response>("Отклики")
                };

                await Task.WhenAll(tasks);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
        }

        private async Task GetCount<T>(string entityName) where T : BaseModel, new()
        {
            var count = await _supabase
                .From<T>()
                .Count(Constants.CountType.Exact);

            Console.WriteLine($"{entityName}: {count}");
        }

        public async Task<Statistics> GetStatistics()
        {
            await Initialize();

            return new Statistics
            {
                VacanciesCount = await GetCount<Vacancy>(),
                ResumesCount = await GetCount<Resume>(),
                UsersCount = await GetCount<User>(),
                InvitationsCount = await GetCount<Invitation>(),
                ResponsesCount = await GetCount<Response>()
            };
        }

        private async Task<int> GetCount<T>() where T : BaseModel, new()
        {
            return await _supabase
                .From<T>()
                .Count(Constants.CountType.Exact);
        }
    }

    public class Statistics
    {
        public int VacanciesCount { get; set; }
        public int ResumesCount { get; set; }
        public int UsersCount { get; set; }
        public int InvitationsCount { get; set; }
        public int ResponsesCount { get; set; }
    }
}
