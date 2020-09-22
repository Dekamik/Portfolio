using Microsoft.Extensions.Logging;
using Portfolio.Common.Api.BaseRepositories;

namespace Portfolio.Common.Api.Tests.Mocks
{
    public class AnyReadOnlyRepository : ReadOnlyRepository<AnyEntity, AnyDbContext>
    {
        public AnyReadOnlyRepository(AnyDbContext dbContext, ILogger logger) : base(dbContext, logger)
        {
        }
    }
}
