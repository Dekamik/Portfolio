using Microsoft.EntityFrameworkCore;
using Portfolio.Common.Core.Entities;
using Portfolio.Core.SeedData;

namespace Portfolio.Core
{
    public class PortfolioDbContext : DbContext
    {
        public PortfolioDbContext(DbContextOptions<PortfolioDbContext> dbContextOptions) : base(dbContextOptions)
        {
        }

        public DbSet<Employer> Employers { get; set; }

        public DbSet<Project> Projects { get; set; }

        public DbSet<ProjectSkill> ProjectSkills { get; set; }

        public DbSet<Skill> Skills { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new EmployerData());
        }
    }
}
