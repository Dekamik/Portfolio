using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Portfolio.Common.Api.Tests.Mocks
{
    public class AnyDbContextFixture : IDisposable
    {
        public AnyDbContext DbContext { get; set; } 

        public AnyDbContextFixture()
        {
            var options = new DbContextOptionsBuilder<AnyDbContext>()
                .UseInMemoryDatabase("AnyDb")
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
