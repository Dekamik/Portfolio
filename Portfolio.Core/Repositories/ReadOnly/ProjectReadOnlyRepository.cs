using Microsoft.Extensions.Logging;
using Portfolio.Common.Api.BaseRepositories;
using Portfolio.Core.Entities;

namespace Portfolio.Core.Repositories.ReadOnly
{
    public class ProjectReadOnlyRepository : ReadOnlyRepository<Project, PortfolioDbContext>, IProjectReadOnlyRepository
    {
        public ProjectReadOnlyRepository(PortfolioDbContext dbContext, ILogger<ProjectReadOnlyRepository> logger) : base(dbContext, logger)
        {
        }
    }
}
