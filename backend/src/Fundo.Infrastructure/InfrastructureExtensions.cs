using Microsoft.Extensions.DependencyInjection;

namespace Fundo.Infrastructure;

public static class InfrastructureExtensions
{
    
    /// <summary>
    /// Adds the infrastructure services to the specified service collection.
    /// </summary>
    /// <param name="services">The service collection to add the services to.</param>
    /// <returns>The updated service collection.</returns>
    /// <exception cref="ArgumentNullException"></exception>
    public static IServiceCollection AddInfrastructureServices(this IServiceCollection services)
    {
        if (services == null)
            throw new ArgumentNullException(nameof(services), "Service collection cannot be null.");

        
        return services;
    }
}