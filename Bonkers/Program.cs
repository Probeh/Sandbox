using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bonkers.Data;
using Library.Models.Identity;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Library.Utilities;
using Library.Models.Commerce;

namespace Bonkers
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var host = CreateHostBuilder(args).Build();
            DataSeeder.SeedUsers<DataContext>(host);
            DataSeeder.SeedPokemon<DataContext>(host);
            DataSeeder.SeedDataModel<DataContext, Product>(host);
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
