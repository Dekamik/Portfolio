using Microsoft.EntityFrameworkCore;
using System;

namespace Portfolio.Common.Api.Tests.Mocks
{
    public class AnyDbContextProvider : IDisposable
    {
        public AnyDbContext DbContext { get; set; } 

        public AnyDbContextProvider(string DbName)
        {
            var options = new DbContextOptionsBuilder<AnyDbContext>()
                .UseInMemoryDatabase(DbName)
                .Options;
            DbContext = new AnyDbContext(options);
        }

        public void Dispose()
        {
            foreach (var entity in DbContext.AnyEntities)
            {
                DbContext.AnyEntities.Remove(entity);
            }
            DbContext.SaveChanges();
        }

        public void Mock(params AnyEntity[] entities)
        {
            DbContext.AnyEntities.AddRange(entities);
            DbContext.SaveChanges();
        }
    }
}
