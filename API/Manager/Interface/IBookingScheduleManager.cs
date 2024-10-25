using Core.Entities.InputModels;
using Core.Entities.Models;

namespace BookingService.Manager.Interface
{
    public interface IBookingScheduleManager
    {
        Task<List<ScheduleInfo>> GetScheduleInfosAsync();
        Task<CodeMessage> BookingClassAsync(BookingInput input);
        Task<CodeMessage> CancelBookingAsync(CancelInput input);
    }
}
