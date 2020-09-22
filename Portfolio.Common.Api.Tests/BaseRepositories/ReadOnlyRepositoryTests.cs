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
                .UseInMemoryDatabase(nameof(ReadOnlyRepositoryTests))
                .Options;
            _dbContext = new AnyDbContext(options);
            _logger = A.Fake<ILogger>();
            _repository = new AnyReadOnlyRepository(_dbContext, _logger);
        }

        public void Dispose()
        {
            _dbContext.DisposeAllMocks();
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
                new AnyEntity 
                {
                    Id = 2,
                    AnyString = "Any"
                }
            };
            _dbContext.MockWith(expected);

            var actual = _repository.GetAll();

            actual.Should().BeEquivalentTo(expected);
        }

        [Fact]
        public void Get_ExistingId_ReturnsEntityWithId()
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
            _dbContext.MockWith(expected);

            var actual = _repository.Get(1);

            actual.Single().Should().BeEquivalentTo(expected.First());
        }


        [Fact]
        public void Get_NonExistingId_ReturnsEmptyQueryable()
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
            _dbContext.MockWith(expected);

            var actual = _repository.Get(3);

            actual.Should().BeEmpty();
        }
    }
}
