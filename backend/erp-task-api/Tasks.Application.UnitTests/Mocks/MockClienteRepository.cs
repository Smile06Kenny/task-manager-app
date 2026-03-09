using AutoFixture;
using Tasks.Domain.Operaciones;
using Tasks.Infrastructure.Persistence;

namespace Tasks.Application.UnitTests.Mocks
{
    public class MockClienteRepository
    {
        public static void AddDataClienteRepository(MainDbContext devsuDbContextFake)
        {
            var fixture = new Fixture();
            fixture.Behaviors.Add(new OmitOnRecursionBehavior());

            var clientes = fixture.CreateMany<Cliente>().ToList();

            clientes.Add(fixture.Build<Cliente>()
               .With(tr => tr.Contrasena, "12345")
               .With(tr => tr.Estado, true)
               .Without(tr => tr.Persona)
               .Create()
           );

            devsuDbContextFake.Clientes!.AddRange(clientes);
            devsuDbContextFake.SaveChanges();

        }

        public static void UpdateDataClienteRepository(MainDbContext devsuDbContextFake)
        {
            var fixture = new Fixture();
            fixture.Behaviors.Add(new OmitOnRecursionBehavior());

            var clientes = fixture.CreateMany<Cliente>().ToList();

            clientes.Add(fixture.Build<Cliente>()
               .With(tr => tr.ClienteId, 1)
               .With(tr => tr.Contrasena, "12345")
               .With(tr => tr.Estado, true)
               .Without(tr => tr.Persona)
               .Create()
           );

            devsuDbContextFake.Clientes!.AddRange(clientes);
            devsuDbContextFake.SaveChanges();

        }
        public static void DeleteDataClienteRepository(MainDbContext devsuDbContextFake)
        {
            var fixture = new Fixture();
            fixture.Behaviors.Add(new OmitOnRecursionBehavior());

            var clientes = fixture.CreateMany<Cliente>().ToList();

            clientes.Add(fixture.Build<Cliente>()
               .With(tr => tr.ClienteId, 1)
               //.Without(tr => tr.Persona)
               .Create()
           );

            devsuDbContextFake.Clientes!.AddRange(clientes);
            devsuDbContextFake.SaveChanges();

        }
    }
}

