using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using NET.OpenIdDict.Infrastructure.EntityFramework;

namespace NET.OpenIdDict.Infrastructure
{
    public static class InfraServiceExtentions
    {
        public static void AddInfraEntityFramework(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<OpenIddictContext>(options =>
            {
                // Configure Entity Framework Core to use Microsoft SQL Server.
                options.UseSqlServer(configuration.GetConnectionString("SqlConnection"));

                // Register the entity sets needed by OpenIddict.
                // Note: use the generic overload if you need to replace the default OpenIddict entities.
                options.UseOpenIddict();
            });
        }
    }
}
