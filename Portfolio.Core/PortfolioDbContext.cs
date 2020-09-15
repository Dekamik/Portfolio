using Microsoft.EntityFrameworkCore;
using Portfolio.Core.Entities;

namespace Portfolio.Core
{
    public class PortfolioDbContext : DbContext
    {
        public PortfolioDbContext(DbContextOptions<PortfolioDbContext> dbContextOptions) : base(dbContextOptions)
        {
        }

        public DbSet<Employer> Employers { get; set; }

        public DbSet<Project> Projects { get; set; }

        public DbSet<ProjectTechnology> ProjectTechnologies { get; set; }

        public DbSet<Technology> Technologies { get; set; }
    }
}
