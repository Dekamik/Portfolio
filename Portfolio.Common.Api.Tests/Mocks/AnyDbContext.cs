using Microsoft.EntityFrameworkCore;

namespace Portfolio.Common.Api.Tests.Mocks
{
    public class AnyDbContext : DbContext
    {
        public AnyDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<AnyEntity> AnyEntities { get; set; }
    }
}
