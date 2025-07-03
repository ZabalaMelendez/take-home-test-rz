using Microsoft.Extensions.DependencyInjection;

namespace Fundo.Application;

public static class ApplicationExtensions
{
    
    
    
    /// <summary>
    /// Adds the Fundo application services to the specified service collection.
    /// </summary>
    /// <param name="services">Services container to use </param>
    /// <returns></returns>
    /// <exception cref="ArgumentNullException"></exception>
    public static IServiceCollection AddFundoApplicationServices(this IServiceCollection services)
    {
        if (services == null)
            throw new ArgumentNullException(nameof(services), "Service collection cannot be null.");

        return services;
    }
    
}