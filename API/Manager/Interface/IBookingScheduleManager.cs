using Core.Entities.Models;

namespace BookingService.Manager.Interface
{
    public interface IBookingScheduleManager
    {
        Task<List<ScheduleInfo>> GetScheduleInfosAsync();
    }
}
