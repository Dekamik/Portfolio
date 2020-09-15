using Portfolio.Core.Base;
using Portfolio.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Portfolio.Core.Repositories.ReadOnly
{
    public class EmployerReadOnlyRepository : ReadOnlyRepository<Employer, PortfolioDbContext>
    {
        public EmployerReadOnlyRepository(PortfolioDbContext dbContext) : base(dbContext)
        {
        }
    }
}
