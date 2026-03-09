using Tasks.Infrastructure.Persistence;
using Tasks.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Moq;

namespace Tasks.Application.UnitTests.Mock
{
    public static class MockUnitOfWork
    {
        public static Mock<UnitOfWork> GetUnitOfWork()
        {
            Guid dbContextId = Guid.NewGuid();
            var options = new DbContextOptionsBuilder<MainDbContext>()
                .UseInMemoryDatabase(databaseName: $"DevsuDbContext-{dbContextId}")
                .Options;

            var devsuDbContextFake = new MainDbContext(options);
            devsuDbContextFake.Database.EnsureDeleted();
            var mockUnitOfWork = new Mock<UnitOfWork>(devsuDbContextFake);
                    

            return mockUnitOfWork;
        }

    }
}

