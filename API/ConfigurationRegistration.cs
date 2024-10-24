using BookingService.Manager.Interface;
using BookingService.Manager; // Make sure to include this namespace

namespace BookingService
{
    public static class ConfigurationRegistration
    {
        public static void AddConfiguration(this IServiceCollection services)
        {
            services.AddTransient<IUserManager, UserManager>(); // Use UserManager as the implementation
        }
    }
}
