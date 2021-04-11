using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleWebApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var hostBuilder = CreateHostBuilder(args);
            var host = hostBuilder.Build();
            host.Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args)
        {
            var defaultBuilder = Host.CreateDefaultBuilder(args);

            var hostBuilder = defaultBuilder.ConfigureWebHostDefaults(webBuilder =>
            {
                webBuilder.UseStartup<Startup>();
            });
            return hostBuilder;
        }
    }
}
