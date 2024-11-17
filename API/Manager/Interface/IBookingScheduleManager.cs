using Core.Entities.InputModels;
using Core.Entities.Models;

namespace BookingService.Manager.Interface
{
    public interface IBookingScheduleManager
    {
        Task<List<ScheduleInfo>> GetScheduleInfosAsync(ScheduleListInput listInput);
        Task<List<PackageInfo>> GetPackageInfosAsync();
        Task<CodeMessage> BookingClassAsync(BookingInput input);
        Task<CodeMessage> CancelBookingAsync(CancelInput input);
    }
}
