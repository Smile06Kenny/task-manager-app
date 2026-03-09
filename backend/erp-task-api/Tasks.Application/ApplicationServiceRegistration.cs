
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace Tasks.Application
{
    public static class ApplicationServiceRegistration
    {

        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());

            // Configurar MediatR con la nueva API

            return services;
        }

    }
}

