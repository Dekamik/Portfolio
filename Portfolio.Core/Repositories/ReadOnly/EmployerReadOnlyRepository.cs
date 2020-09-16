using Microsoft.Extensions.Logging;
using Portfolio.Core.Entities;
using Portfolio.Core.Repositories.Base;

namespace Portfolio.Core.Repositories.ReadOnly
{
    public class EmployerReadOnlyRepository : ReadOnlyRepository<Employer, PortfolioDbContext>
    {
        public EmployerReadOnlyRepository(PortfolioDbContext dbContext, ILogger<EmployerReadOnlyRepository> logger) : base(dbContext, logger)
        {
        }
    }
}
