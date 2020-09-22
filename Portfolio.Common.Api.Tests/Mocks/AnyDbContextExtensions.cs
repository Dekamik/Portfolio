using System;
using System.Collections.Generic;
using System.Text;

namespace Portfolio.Common.Api.Tests.Mocks
{
    public static class AnyDbContextExtensions
    {
        public static void MockWith(this AnyDbContext dbContext, IEnumerable<AnyEntity> entities)
        {
            dbContext.AnyEntities.AddRange(entities);
            dbContext.SaveChanges();
        }

        public static void DisposeAllMocks(this AnyDbContext dbContext)
        {
            foreach (var entity in dbContext.AnyEntities)
            {
                dbContext.AnyEntities.Remove(entity);
            }
            dbContext.SaveChanges();
        }
    }
}
