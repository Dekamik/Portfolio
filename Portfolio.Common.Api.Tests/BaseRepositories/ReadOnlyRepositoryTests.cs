using FakeItEasy;
using FluentAssertions;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Portfolio.Common.Api.Tests.Mocks;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace Portfolio.Common.Api.Tests.BaseRepositories
{
    public class ReadOnlyRepositoryTests
    {
        private readonly ILogger _logger;

        public ReadOnlyRepositoryTests()
        {
            _logger = A.Fake<ILogger>();
        }

        [Fact]
        public void GetAll_Default_ReturnsAll()
        {
            using var dbContext = new AnyDbContextProvider(nameof(GetAll_Default_ReturnsAll));
            var repository = new AnyReadOnlyRepository(dbContext.DbContext, _logger);
            var expected = new List<AnyEntity>
            {
                new AnyEntity
                {
                    Id = 1,
                    AnyString = "Any"
                },
                new AnyEntity 
                {
                    Id = 2,
                    AnyString = "Any"
                }
            };
            dbContext.Mock(expected.ToArray());

            var actual = repository.GetAll();

            actual.Should().BeEquivalentTo(expected);
        }

        [Fact]
        public void Get_ExistingId_ReturnsEntityWithId()
        {
            using var dbContext = new AnyDbContextProvider(nameof(Get_ExistingId_ReturnsEntityWithId));
            var repository = new AnyReadOnlyRepository(dbContext.DbContext, _logger);
            var expected = new List<AnyEntity>
            {
                new AnyEntity
                {
                    Id = 1,
                    AnyString = "Any"
                },
                new AnyEntity {
                    Id = 2,
                    AnyString = "Any"
                }
            };
            dbContext.Mock(expected.ToArray());

            var actual = repository.Get(1);

            actual.Single().Should().BeEquivalentTo(expected.First());
        }


        [Fact]
        public void Get_NonExistingId_ReturnsEmptyQueryable()
        {
            using var dbContext = new AnyDbContextProvider(nameof(Get_NonExistingId_ReturnsEmptyQueryable));
            var repository = new AnyReadOnlyRepository(dbContext.DbContext, _logger);
            var expected = new List<AnyEntity>
            {
                new AnyEntity
                {
                    Id = 1,
                    AnyString = "Any"
                },
                new AnyEntity {
                    Id = 2,
                    AnyString = "Any"
                }
            };
            dbContext.Mock(expected.ToArray());

            var actual = repository.Get(3);

            actual.Should().BeEmpty();
        }
    }
}
