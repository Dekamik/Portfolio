using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace Portfolio.Core
{
    public class PortfolioDbContextFactory : IDesignTimeDbContextFactory<PortfolioDbContext>
    {
        public PortfolioDbContext CreateDbContext(string[] args)
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var optionsBuilder = new DbContextOptionsBuilder<PortfolioDbContext>();

            optionsBuilder.UseNpgsql(configuration.GetConnectionString("Portfolio"));

            return new PortfolioDbContext(optionsBuilder.Options);
        }
    }
}
