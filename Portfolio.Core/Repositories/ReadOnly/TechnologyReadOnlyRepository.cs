using Portfolio.Core.Base;
using Portfolio.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Portfolio.Core.Repositories.ReadOnly
{
    public class TechnologyReadOnlyRepository : ReadOnlyRepository<Technology, PortfolioDbContext>
    {
        public TechnologyReadOnlyRepository(PortfolioDbContext dbContext) : base(dbContext)
        {
        }
    }
}
