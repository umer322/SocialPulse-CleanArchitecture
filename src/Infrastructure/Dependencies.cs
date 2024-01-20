using Infrastructure.Data;
using Infrastructure.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure
{
    public static class Dependencies
    {
        public static void ConfigureServices(IConfiguration configuration, IServiceCollection services)
        {
            services.AddDbContext<AppDbContext>(o =>
            {
                var connectionString = configuration.GetConnectionString("DataDb");
                o.UseSqlServer(connectionString);
            });

            services.AddDbContext<AppIdentityDbContext>(o =>
            {
                var connectionString = configuration.GetConnectionString("IdentityDb");
                o.UseSqlServer(connectionString);
            });
        }
    }
}
