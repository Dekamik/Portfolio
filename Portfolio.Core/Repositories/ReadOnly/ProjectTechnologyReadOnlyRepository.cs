using Portfolio.Core.Base;
using Portfolio.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Portfolio.Core.Repositories.ReadOnly
{
    public class ProjectTechnologyReadOnlyRepository : ReadOnlyRepository<ProjectTechnology, PortfolioDbContext>
    {
        public ProjectTechnologyReadOnlyRepository(PortfolioDbContext dbContext) : base(dbContext)
        {
        }
    }
}
