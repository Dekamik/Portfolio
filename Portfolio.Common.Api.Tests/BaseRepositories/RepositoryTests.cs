using FakeItEasy;
using FluentAssertions;
using Microsoft.Extensions.Logging;
using Portfolio.Common.Api.Tests.Mocks;
using System;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace Portfolio.Common.Api.Tests.BaseRepositories
{
    public class RepositoryTests
    {
        private readonly ILogger _logger;

        public RepositoryTests()
        {
            _logger = A.Fake<ILogger>();
        }

        [Fact]
        public async Task Create_AnyEntity_EntityCreated()
        {
            using var dbContext = new AnyDbContextProvider(nameof(Create_AnyEntity_EntityCreated));
            var repository = new AnyRepository(dbContext.DbContext, _logger);
            var expected = new AnyEntity
            {
                AnyString = "AnyString"
            };

            await repository.Create(expected);
            await repository.SaveChanges();

            var actual = repository.GetAll();

            actual.Single().AnyString.Should().Be(expected.AnyString);
        }

        [Fact]
        public async Task Create_ExistingEntity_ThrowsArgumentException()
        {
            using var dbContext = new AnyDbContextProvider(nameof(Create_ExistingEntity_ThrowsArgumentException));
            var repository = new AnyRepository(dbContext.DbContext, _logger);
            var entity = new AnyEntity
            {
                Id = 1,
                AnyString = "AnyString"
            };
            dbContext.Mock(entity);
            
            await repository.Create(entity);

            await repository.Invoking(r => r.SaveChanges()).Should().ThrowAsync<ArgumentException>();
        }

        [Fact]
        public async Task Create_AnyEntityWithAutoSave_EntityCreated()
        {
            using var dbContext = new AnyDbContextProvider(nameof(Create_AnyEntityWithAutoSave_EntityCreated));
            var repository = new AnyRepository(dbContext.DbContext, _logger);
            var expected = new AnyEntity
            {
                AnyString = "AnyString"
            };
            repository.AutoSave = true;

            await repository.Create(expected);

            var actual = repository.GetAll();

            actual.Single().AnyString.Should().Be(expected.AnyString);
        }

        [Fact]
        public async Task Create_ExistingEntityWithAutoSave_ThrowsArgumentException()
        {
            using var dbContext = new AnyDbContextProvider(nameof(Create_ExistingEntityWithAutoSave_ThrowsArgumentException));
            var repository = new AnyRepository(dbContext.DbContext, _logger);
            var entity = new AnyEntity
            {
                Id = 1,
                AnyString = "AnyString"
            };
            dbContext.Mock(entity);
            repository.AutoSave = true;

            await repository.Invoking(r => r.Create(entity)).Should().ThrowAsync<ArgumentException>();
        }
    }
}
