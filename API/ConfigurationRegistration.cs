using BookingService.Manager.Interface;

namespace BookingService
{
    public static class ConfigurationRegistration
    {
        public static void AddConfiguration(this IServiceCollection services)
        {
            services.AddTransient<IUserManager, IUserManager>();
        }
    }
}
