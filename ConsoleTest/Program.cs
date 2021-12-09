using System;
using System.Threading.Tasks;
using BillTimeLibrary.RepoDB;
using BlazorServerDALibrary.Data;
using BlazorServerDALibrary.DataAccess;
using BlazorServerDALibrary.Repositories;
using ConsoleUI;
using DataLibraryRepo;
using DataLibraryRepo.Data;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace ConsoleTest
{
    class Program
    {
        static async Task Main(string[] args)
        {
            
            // var configuration = new ConfigurationBuilder()
            //     .AddJsonFile("appsettings.json", false, true)
            //     .Build();

            using IHost host = CreateHostBuilder(args).Build();
            using var scope = host.Services.CreateScope();

            var services = scope.ServiceProvider;

            try
            {
                //services.GetRequiredService<App>().Run();
                await services.GetRequiredService<AppBS>().Run();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error has occurred: { ex.Message }");
                Console.ReadLine();
            }

        }

        static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureAppConfiguration(builder =>{
                    builder.AddJsonFile("appsettings.json", false, true);
                })
                .ConfigureServices((_, services) =>
                {
                    services
                        .AddTransient<App>()
                        .AddTransient<AppBS>()
                        .AddTransient<IOrderData, OrderData>()
                        .AddTransient<IFoodData, FoodData>()
                        .AddTransient<IPersonDataService, PersonSQLDataService>()
                        .AddSingleton<IPersonRepository, PersonRepository>()
                        .AddSingleton<IPersonDataAccess, PersonDataAccess>();

                })
                ;

    }
}
