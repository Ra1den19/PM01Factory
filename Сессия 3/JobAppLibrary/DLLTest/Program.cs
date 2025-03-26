using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JobAppLibrary;

namespace DLLTest
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var service = new SupabaseStatisticsService();
            await service.DisplayStatistics();

            var stats = await service.GetStatistics();
        }
    }
}
