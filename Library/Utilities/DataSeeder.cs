using Library.Models.Commerce;
using Library.Models;
using Library.Models.Identity;
using Library.Models.Pokemon;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Utilities
{
    public static partial class DataSeeder
    {
        public static void SeedDataModel<TContext, TDataSet>(IHost host) where TContext : DbContext where TDataSet : BaseModel<TDataSet>, new()
        {
            using (var scope = host.Services.CreateScope())
            {
                var services = scope.ServiceProvider;
                try
                {
                    var context = services.GetRequiredService<TContext>();
                    context.Database.Migrate();
                    if (!context.Set<TDataSet>().Any())
                    {
                        for (int i = 0; i < 25; i++)
                        {
                            Task.Run(() => context.Set<TDataSet>().Add(new TDataSet())).Wait();
                        }
                        context.SaveChanges();
                    }
                }
                catch (Exception ex) { throw ex; }
            }
        }
        public static void SeedPokemon<TContext>(IHost host) where TContext : DbContext
        {
            using (var scope = host.Services.CreateScope())
            {
                var services = scope.ServiceProvider;
                try
                {
                    var context = services.GetRequiredService<TContext>();
                    context.Database.Migrate();
                    if (!context.Set<Pokemon>().Any())
                    {
                        string json = System.IO.File.ReadAllText("Data/PokemonData.json");
                        List<Pokemon> pokemon = JsonConvert.DeserializeObject<List<Pokemon>>(json);

                        for (int i = 0; i < pokemon.Count; i++)
                        {
                            Task.Run(() => context.Set<Pokemon>().Add(new Pokemon(i + 1, pokemon[i].Title, pokemon[i].Url))).Wait();
                        }
                        context.SaveChanges();
                    }
                }
                catch (Exception ex) { throw ex; }
            }
        }
        public static void SeedUsers<TContext>(IHost host) where TContext : DbContext
        {
            using (var scope = host.Services.CreateScope())
            {
                var services = scope.ServiceProvider;
                try
                {
                    var context = services.GetRequiredService<TContext>();
                    var userManager = services.GetRequiredService<UserManager<User>>();
                    context.Database.Migrate();
                    if (!userManager.Users.Any())
                    {
                        string userData = System.IO.File.ReadAllText("Data/UserData.json");
                        List<User> users = JsonConvert.DeserializeObject<List<User>>(userData);

                        foreach (User user in users)
                        {
                            userManager.CreateAsync(user, "Aa123123!").Wait();
                        }
                    }
                }
                catch (Exception ex) { throw ex; }
            }
        }
    }
}
