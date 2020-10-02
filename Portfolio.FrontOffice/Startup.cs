using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Portfolio.BusinessLogic.Employers;
using Portfolio.BusinessLogic.Projects;
using Portfolio.Core;
using Portfolio.Core.Repositories.ReadOnly;

namespace Portfolio.FrontOffice
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddRazorPages();
            services.AddServerSideBlazor();

            services.AddLogging(config =>
            {
                config.ClearProviders();

                config.AddConfiguration(Configuration.GetSection("Logging"));
                config.AddDebug();
                config.AddEventSourceLogger();

                if (Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") == Environments.Development)
                {
                    config.AddConsole();
                }
            });

            string connectionString;
            if (Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") == Environments.Production)
            {
                string dbServer = Environment.GetEnvironmentVariable("DB_SERVER");
                string dbPort = Environment.GetEnvironmentVariable("DB_PORT") ?? "5432";
                string dbName = Environment.GetEnvironmentVariable("DB_NAME");
                string dbUser = Environment.GetEnvironmentVariable("DB_USER");
                string dbPass = Environment.GetEnvironmentVariable("DB_PASS");
                string dbSslMode = Environment.GetEnvironmentVariable("DB_SSLMODE") ?? "Require";
                bool trustServerCertificate = Environment.GetEnvironmentVariable("DB_TRUST_SERVER_CERTIFICATE") == "true";

                connectionString = $"Server={dbServer};" +
                    $"Port={dbPort};" +
                    $"Database={dbName};" +
                    $"Username={dbUser};" +
                    $"Password={dbPass};" +
                    $"SslMode={dbSslMode};" +
                    $"Trust Server Certificate={trustServerCertificate};";
            }
            else
            {
                connectionString = Configuration.GetConnectionString("Portfolio");
            }

            services.AddDbContext<PortfolioDbContext>(options => 
                options.UseNpgsql(connectionString, options => 
                    options.MigrationsAssembly("Portfolio.Core")));

            services.AddScoped<IProjectReadOnlyRepository, ProjectReadOnlyRepository>();
            services.AddScoped<IEmployerReadOnlyRepository, EmployerReadOnlyRepository>();

            services.AddScoped<IProjectService, ProjectService>();
            services.AddScoped<IEmployerService, EmployerService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapBlazorHub();
                endpoints.MapFallbackToPage("/_Host");
            });
        }
    }
}
