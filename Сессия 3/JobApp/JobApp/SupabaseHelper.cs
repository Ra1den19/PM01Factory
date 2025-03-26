using Supabase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobApp
{
    public static class SupabaseHelper
    {
        public static readonly string SupabaseUrl = "https://ezinxnacbigjfvsqhkqk.supabase.co";
        public static readonly string SupabaseKey = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJpc3MiOiJzdXBhYmFzZSIsInJlZiI6ImV6aW54bmFjYmlnamZ2c3Foa3FrIiwicm9sZSI6ImFub24iLCJpYXQiOjE3NDIwNDEyNjQsImV4cCI6MjA1NzYxNzI2NH0.x6tZQ4a1I6lYi00mVzAykydq5NdaoKzwp8Dm9jr5GZ8";

        private static Supabase.Client _client;

        public static async Task<Supabase.Client> GetClient()
        {
            if (_client == null)
            {
                var options = new SupabaseOptions { AutoConnectRealtime = true };
                _client = new Supabase.Client(SupabaseUrl, SupabaseKey, options);
                await _client.InitializeAsync();
            }
            return _client;
        }
    }
}
