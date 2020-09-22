using FakeItEasy;
using FluentAssertions;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Portfolio.Common.Api.Tests.Mocks;
using System;
using System.Linq;
using Xunit;

namespace Portfolio.Common.Api.Tests.BaseRepositories
{
    public class RepositoryTests : IClassFixture<AnyDbContextFixture>
    {
        private readonly ILogger _logger;
        private readonly AnyDbContextFixture _dbContextFixture;
        private readonly AnyRepository _repository;

        public RepositoryTests(AnyDbContextFixture dbContextFixture)
        {
            _logger = A.Fake<ILogger>();
            _dbContextFixture = dbContextFixture;
            _repository = new AnyRepository(dbContextFixture.DbContext, _logger);
        }

        [Fact]
        public async void Create_AnyEntity_EntityCreated()
        {
            var expected = new AnyEntity
            {
                AnyString = "AnyString"
            };

            await _repository.Create(expected);
            await _repository.SaveChanges();

            var actual = _repository.GetAll();

            actual.Single().AnyString.Should().Be(expected.AnyString);
        }

        [Fact]
        public async void Create_ExistingEntity_ThrowsArgumentException()
        {
            var entity = new AnyEntity
            {
                Id = 1,
                AnyString = "AnyString"
            };
            _dbContextFixture.Mock(entity);
            
            await _repository.Create(entity);

            await _repository.Invoking(r => r.SaveChanges()).Should().ThrowAsync<ArgumentException>();
        }

        [Fact]
        public async void Create_AnyEntityWithAutoSave_EntityCreated()
        {
            var expected = new AnyEntity
            {
                AnyString = "AnyString"
            };
            _repository.AutoSave = true;

            await _repository.Create(expected);

            var actual = _repository.GetAll();

            actual.Single().AnyString.Should().Be(expected.AnyString);
        }

        [Fact]
        public async void Create_ExistingEntityWithAutoSave_ThrowsArgumentException()
        {
            var entity = new AnyEntity
            {
                Id = 1,
                AnyString = "AnyString"
            };
            _dbContextFixture.Mock(entity);
            _repository.AutoSave = true;

            await _repository.Invoking(r => r.Create(entity)).Should().ThrowAsync<ArgumentException>();
        }
    }
}
