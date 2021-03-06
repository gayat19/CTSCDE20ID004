using EFCodeFirstMVCProject.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace EFCodeFirstMVCProject
{
    public class Program
    {
        public static void Main(string[] args)
        {
            
            var host = CreateHostBuilder(args).Build();
            SeedTheDatabase(host);
            host.Run();
        }

        private static void SeedTheDatabase(IHost host)
        {
            try
            {
                var dataScope = host.Services.CreateScope();
                var myServices = dataScope.ServiceProvider;
                var myContext = myServices.GetRequiredService<CompanyContext>();
                DbInitializer.Initialize(myContext);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
            .ConfigureLogging(logging=>
            {
                logging.ClearProviders();
                logging.AddConsole();
                logging.AddDebug();
                logging.AddEventLog();
            })
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
