namespace SocialPulse_CleanArchitecture.Configuration
{
    public static class ConfigureCookieSettings
    {
        public const int CookieValidationPeriod = 5;
        public const string IdentifierCookieName = "SocialPulse";
        public static IServiceCollection AddCookieSettings(this IServiceCollection services)
        {


            services.AddCookiePolicy(options =>
            {
                options.OnDeleteCookie = (option) =>
                {
                    Console.WriteLine("cookie deleted");
                };
            });
            services.ConfigureApplicationCookie(options =>
            {
                options.LogoutPath = "/Account/Logout";
                options.LoginPath = "/Account/Login";
                options.ExpireTimeSpan = TimeSpan.FromMinutes(CookieValidationPeriod);
                options.Cookie = new CookieBuilder { Name = IdentifierCookieName, IsEssential = true };
            });
            return services;
        }
    }
}
