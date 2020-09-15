using Portfolio.Core.Base;
using Portfolio.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Portfolio.Core.Repositories.ReadOnly
{
    public class ProjectReadOnlyRepository : ReadOnlyRepository<Project, PortfolioDbContext>
    {
        public ProjectReadOnlyRepository(PortfolioDbContext dbContext) : base(dbContext)
        {
        }
    }
}
