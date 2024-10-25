using Interface.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using Repository.Repository;
using Interface.Interfaces;

namespace Repository
{
    public static class ServiceRegistration
    {
        public static void AddInfrastructure(this IServiceCollection services)
        {
            services.AddTransient<IUnitWork, UnitWork>();
            services.AddTransient<IBookingRepository, BookingRepository>();
        }
    }
}
