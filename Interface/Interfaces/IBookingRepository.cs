using Core.Entities.Models;

namespace Interface.Interfaces
{
    public interface IBookingRepository
    {
        Task<List<ScheduleInfo>> GetScheduleList();
    }
}
