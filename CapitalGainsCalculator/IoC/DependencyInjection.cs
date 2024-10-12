using Application.Services;
using Domain.Services;
using Infrastructure.Parsers;
using Infrastructure.Services;
using Microsoft.Extensions.DependencyInjection;

namespace IoC
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddProjectDependencies(this IServiceCollection services)
        {
            // Adiciona os serviços da camada de aplicação
            services.AddScoped<IOperationHandler, OperationHandler>();

            // Adiciona os serviços da camada de domínio
            services.AddScoped<ITaxCalculator, TaxCalculator>();

            // Adiciona os serviços da camada de infraestrutura
            services.AddScoped<IJsonParser, JsonParser>();

            return services;
        }
    }
}
