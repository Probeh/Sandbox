using Library.Extensions;
using Library.Models.Commerce;
using Library.Models.Pokemon;
using Library.Utilities;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using Monster.Data;

namespace Monster
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var host = CreateHostBuilder(args).Build();
            DataSeeder.SeedPokemon<ApplicationDbContext>(host);
            DataSeeder.SeedDataModel<ApplicationDbContext, Product>(host);
            DataSeeder.SeedDataModel<ApplicationDbContext, Category>(host);
            DataSeeder.SeedDataModel<ApplicationDbContext, Order>(host);
            host.Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
