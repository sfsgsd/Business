using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Persistence;

public static class DependencyInjection
{
    public static IServiceCollection AddPersistence(this IServiceCollection services) {
        return services.AddPersistenceServices(); 
    }

    public static IServiceCollection AddPersistenceServices(this IServiceCollection services)
    {
        services.AddDbContext<BusinessContext>(options =>
            options.UseSqlServer(Configuration.GetConnection)
        );

        return services;
    }
}

