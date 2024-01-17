using Core.Interfaces;
using Core.Services;
using Infrastructure.Data;

namespace SocialPulse_CleanArchitecture.Configuration
{
    public static class ConfigureCoreServices
    {
        public static IServiceCollection AddCoreServices(this IServiceCollection services)
        {
            services.AddScoped(typeof(IReadRepository<>), typeof(EfRepository<>));
            services.AddScoped(typeof(IRepository<>), typeof(EfRepository<>));
            services.AddScoped<IPostService, PostService>();

            return services;
        }
    }
}
