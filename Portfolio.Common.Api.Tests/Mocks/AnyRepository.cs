using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Portfolio.Common.Api.BaseRepositories;

namespace Portfolio.Common.Api.Tests.Mocks
{
    public class AnyRepository : Repository<AnyEntity, DbContext>
    {
        public AnyRepository(DbContext dbContext, ILogger logger) : base(dbContext, logger)
        {
        }
    }
}
