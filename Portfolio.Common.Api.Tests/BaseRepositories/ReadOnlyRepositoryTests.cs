using FakeItEasy;
using FluentAssertions;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Portfolio.Common.Api.Tests.Mocks;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace Portfolio.Common.Api.Tests.BaseRepositories
{
    public class ReadOnlyRepositoryTests : IDisposable
    {
        private readonly ILogger _logger;
        private readonly AnyDbContext _dbContext;
        private readonly AnyReadOnlyRepository _repository;

        public ReadOnlyRepositoryTests()
        {
            var options = new DbContextOptionsBuilder<AnyDbContext>()
                .UseInMemoryDatabase("AnyDb")
                .Options;
            _dbContext = new AnyDbContext(options);
            _logger = A.Fake<ILogger>();
            _repository = new AnyReadOnlyRepository(_dbContext, _logger);
        }

        public void Dispose()
        {
            foreach (var entity in _dbContext.AnyEntities)
            {
                _dbContext.AnyEntities.Remove(entity);
            }
            _dbContext.SaveChanges();
        }

        [Fact]
        public void GetAll_Default_ReturnsAll()
        {
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
            MockDbContextWith(expected);

            var actual = _repository.GetAll();

            actual.Should().BeEquivalentTo(expected);
        }

        [Fact]
        public void Get_AnyId_ReturnsEntityWithId()
        {
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
            MockDbContextWith(expected);

            var actual = _repository.Get(1);

            actual.Single().Should().BeEquivalentTo(expected.First());
        }

        private void MockDbContextWith(IEnumerable<AnyEntity> entities)
        {
            _dbContext.AnyEntities.AddRange(entities);
            _dbContext.SaveChanges();
        }
    }
}
