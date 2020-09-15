using Microsoft.EntityFrameworkCore;
using Portfolio.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

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
