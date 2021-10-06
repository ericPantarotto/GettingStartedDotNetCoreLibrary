﻿using System;
using BillTimeLibrary.RepoDB;
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
        static void Main(string[] args)
        {
            
            // var configuration = new ConfigurationBuilder()
            //     .AddJsonFile("appsettings.json", false, true)
            //     .Build();

            using IHost host = CreateHostBuilder(args).Build();
            using var scope = host.Services.CreateScope();

            var services = scope.ServiceProvider;

            try
            {
                services.GetRequiredService<App>().Run();
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
                        .AddTransient<IOrderData, OrderData>()
                        .AddTransient<IFoodData, FoodData>();
                })
                ;

    }
}