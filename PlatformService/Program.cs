using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace PlatformService
{
    // public class Program
    // {
    //     public static void Main(string[] args)
    //     {
    //         CreateHostBuilder(args).Build().Run();
    //     }

    //     public static IHostBuilder CreateHostBuilder(string[] args) =>
    //         Host.CreateDefaultBuilder(args)
    //             .ConfigureWebHostDefaults(webBuilder =>
    //             {
    //                 webBuilder.UseStartup<Startup>();
    //             });
    // }

    public class Program
{
    public static void Main(string[] args)
    {
        try
        {
            CreateHostBuilder(args).Build().Run();
        }
        catch (Exception ex)
        {
            // Log the exception
            Console.WriteLine($"Unhandled exception: {ex.Message}");
            throw;
        }
        finally
        {
            // Ensure any cleanup code runs
            Console.WriteLine("Application is shutting down...");
        }
    }

    public static IHostBuilder CreateHostBuilder(string[] args) =>
        Host.CreateDefaultBuilder(args)
            .ConfigureWebHostDefaults(webBuilder =>
            {
                webBuilder.UseStartup<Startup>()
                          .UseUrls("http://*:80");
            });
}
}