using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using MyWebSite.Data;
using System;
using System.Threading.Tasks;

namespace MyWebSite
{
    public class Program
    {
        public async static Task Main(string[] args)
        {
            //CreateHostBuilder(args).Build().Run();

            var host = CreateHostBuilder(args).Build();

            using var scope = host.Services.CreateScope();
            var services = scope.ServiceProvider;

            try
            {
              var dbContext = services.GetRequiredService<ApplicationDbContext>();
              if (dbContext.Database.IsSqlServer())
              {
                dbContext.Database.Migrate();
              }
            }
            catch (Exception ex)
            {
              var logger = scope.ServiceProvider.GetRequiredService<ILogger<Program>>();

              logger.LogError(ex, "An error occurred while migrating or seeding the database.");

              throw;
            }

            await host.RunAsync();
      }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    try
                    {
                        var port = Environment.GetEnvironmentVariable("PORT");
                        if (port != null)
                        {
                            webBuilder.UseStartup<Startup>()
                            .UseUrls("http://*:" + port);
                        }
                        else
                        {
                            webBuilder.UseStartup<Startup>();
                        }
                    }
                    catch(Exception)
                    {
                        webBuilder.UseStartup<Startup>();
                    }
                });
    }
}
