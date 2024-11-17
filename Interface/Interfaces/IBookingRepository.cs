using Core.Entities.InputModels;
using Core.Entities.Models;

namespace Interface.Interfaces
{
    public interface IBookingRepository
    {
        Task<List<ScheduleInfo>> GetALLScheduleList(ScheduleListInput listInput);
        Task<List<PackageInfo>> GetALLPackageList();
        Task<CodeMessage> BookingClass(BookingInput info);
        Task<CodeMessage> CancelBooking(CancelInput info);
    }
}
