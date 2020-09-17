using Microsoft.Extensions.Logging;
using Portfolio.Common.Api.BaseRepositories;
using Portfolio.Core.Entities;

namespace Portfolio.Core.Repositories.ReadOnly
{
    public class EmployerReadOnlyRepository : ReadOnlyRepository<Employer, PortfolioDbContext>, IEmployerReadOnlyRepository
    {
        public EmployerReadOnlyRepository(PortfolioDbContext dbContext, ILogger<EmployerReadOnlyRepository> logger) : base(dbContext, logger)
        {
        }
    }
}
