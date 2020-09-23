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
            using var dbContextProvider = new AnyDbContextProvider(nameof(Create_AnyEntity_EntityCreated));
            var repository = new AnyRepository(dbContextProvider.DbContext, _logger);
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
        public async Task Create_AnyEntityWithAutoSave_EntityCreated()
        {
            using var dbContextProvider = new AnyDbContextProvider(nameof(Create_AnyEntityWithAutoSave_EntityCreated));
            var repository = new AnyRepository(dbContextProvider.DbContext, _logger);
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
        public async Task Create_ExistingEntity_ThrowsArgumentException()
        {
            using var dbContextProvider = new AnyDbContextProvider(nameof(Create_ExistingEntity_ThrowsArgumentException));
            var repository = new AnyRepository(dbContextProvider.DbContext, _logger);
            var entity = new AnyEntity
            {
                Id = 1,
                AnyString = "AnyString"
            };
            dbContextProvider.Mock(entity);
            
            await repository.Create(entity);

            await repository.Invoking(r => r.SaveChanges()).Should().ThrowAsync<ArgumentException>();
        }

        [Fact]
        public async Task Create_MultipleEntities_CreatesEntities()
        {
            using var dbContextProvider = new AnyDbContextProvider(nameof(Create_MultipleEntities_CreatesEntities));
            var repository = new AnyRepository(dbContextProvider.DbContext, _logger);
            var expected = new[]
            {
                new AnyEntity
                {
                    AnyString = "FirstEntity"
                },
                new AnyEntity
                {
                    AnyString = "SecondEntity"
                }
            };

            await repository.Create(expected);
            await repository.SaveChanges();
            var actual = repository.GetAll();

            actual.First().AnyString.Should().Be(expected.First().AnyString);
            actual.Last().AnyString.Should().BeEquivalentTo(expected.Last().AnyString);
        }

        [Fact]
        public async Task Update_ExistingEntity_EntityUpdated()
        {
            using var dbContextProvider = new AnyDbContextProvider(nameof(Update_ExistingEntity_EntityUpdated));
            var repository = new AnyRepository(dbContextProvider.DbContext, _logger);
            dbContextProvider.Mock(new AnyEntity
            {
                Id = 1,
                AnyString = "AnyString"
            });
            var expected = new AnyEntity
            {
                Id = 1,
                AnyString = "AnyNewString"
            };
            
            await repository.Update(expected);
            var actual = repository.Get(1);
            await repository.SaveChanges();

            actual.Single().Should().BeEquivalentTo(expected);
        }

        [Fact]
        public async Task Update_ExistingEntityWithAutoSave_EntityUpdated()
        {
            using var dbContextProvider = new AnyDbContextProvider(nameof(Update_ExistingEntityWithAutoSave_EntityUpdated));
            var repository = new AnyRepository(dbContextProvider.DbContext, _logger)
            {
                AutoSave = true
            };
            dbContextProvider.Mock(new AnyEntity
            {
                Id = 1,
                AnyString = "AnyString"
            });
            var expected = new AnyEntity
            {
                Id = 1,
                AnyString = "AnyNewString"
            };

            await repository.Update(expected);
            var actual = repository.Get(1);

            actual.Single().Should().BeEquivalentTo(expected);
        }

        [Fact]
        public async Task Update_MultipleEntities_EntitiesUpdated()
        {
            using var dbContextProvider = new AnyDbContextProvider(nameof(Update_MultipleEntities_EntitiesUpdated));
            var repository = new AnyRepository(dbContextProvider.DbContext, _logger);
            dbContextProvider.Mock(new AnyEntity
            {
                Id = 1,
                AnyString = "AnyString"
            },
            new AnyEntity
            {
                Id = 2,
                AnyString = "AnyString"
            });
            var expected = new[] {
                new AnyEntity
                {
                    Id = 1,
                    AnyString = "AnyNewString"
                },
                new AnyEntity
                {
                    Id = 2,
                    AnyString = "AnyNewString"
                }
            };
            
            await repository.Update(expected);
            var actual = repository.Get(1, 2);
            await repository.SaveChanges();

            actual.Should().BeEquivalentTo(expected);
        }

        [Fact]
        public async Task Delete_ExistingEntity_EntityDeleted()
        {
            using var dbContextProvider = new AnyDbContextProvider(nameof(Delete_ExistingEntity_EntityDeleted));
            var repository = new AnyRepository(dbContextProvider.DbContext, _logger);
            var entities = new[] {
                new AnyEntity
                {
                    Id = 1,
                    AnyString = "AnyString"
                },
                new AnyEntity
                {
                    Id = 2,
                    AnyString = "AnyString"
                }
            };
            dbContextProvider.Mock(entities);

            await repository.Delete(1);
            await repository.SaveChanges();
            var actual = repository.GetAll();

            actual.Single().Should().BeEquivalentTo(entities.Last());
        }

        [Fact]
        public async Task Delete_ExistingEntityWithAutoSave_EntityDeleted()
        {
            using var dbContextProvider = new AnyDbContextProvider(nameof(Delete_ExistingEntity_EntityDeleted));
            var repository = new AnyRepository(dbContextProvider.DbContext, _logger)
            {
                AutoSave = true
            };
            var entities = new[] {
                new AnyEntity
                {
                    Id = 1,
                    AnyString = "AnyString"
                },
                new AnyEntity
                {
                    Id = 2,
                    AnyString = "AnyString"
                }
            };
            dbContextProvider.Mock(entities);

            await repository.Delete(1);
            var actual = repository.GetAll();

            actual.Single().Should().BeEquivalentTo(entities.Last());
        }

        [Fact]
        public async Task Delete_MultipleEntities_EntitiesDeleted()
        {
            using var dbContextProvider = new AnyDbContextProvider(nameof(Delete_MultipleEntities_EntitiesDeleted));
            var repository = new AnyRepository(dbContextProvider.DbContext, _logger);
            var entities = new[] {
                new AnyEntity
                {
                    Id = 1,
                    AnyString = "AnyString"
                },
                new AnyEntity
                {
                    Id = 2,
                    AnyString = "AnyString"
                },
                new AnyEntity
                {
                    Id = 3,
                    AnyString = "AnyString"
                }
            };
            dbContextProvider.Mock(entities);

            await repository.Delete(1, 2);
            await repository.SaveChanges();
            var actual = repository.GetAll();

            actual.Single().Should().BeEquivalentTo(entities.Last());
        }
    }
}
