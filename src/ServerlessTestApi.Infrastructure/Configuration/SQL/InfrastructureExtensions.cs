using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Options;
using System.Data;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ServerlessTestApi.Infrastructure.Settings;

namespace ServerlessTestApi.Infrastructure.Configuration.SQL
{
    public static class InfrastructureExtensions
    {
        public static IServiceCollection AddDatabase(this IServiceCollection services, IConfiguration configuration)
        {
            services.Configure<ServiceSettings>(configuration.GetSection("ServiceSettings"));

            services.AddScoped<IDbConnection>(sp =>
            {
                var settings = sp.GetRequiredService<IOptions<ServiceSettings>>().Value;
                return new SqlConnection(settings.ConnectionString);
            });

            return services;
        }
    }
}
