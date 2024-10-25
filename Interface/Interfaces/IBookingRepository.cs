using Core.Entities.InputModels;
using Core.Entities.Models;

namespace Interface.Interfaces
{
    public interface IBookingRepository
    {
        Task<List<ScheduleInfo>> GetScheduleList();
        Task<CodeMessage> BookingClass(BookingInput info);
    }
}
