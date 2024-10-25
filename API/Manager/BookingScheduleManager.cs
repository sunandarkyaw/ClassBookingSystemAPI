using BookingService.Manager.Interface;
using Core.Entities.Models;
using Interface.Interfaces;

namespace BookingService.Manager
{
    public class BookingScheduleManager : IBookingScheduleManager
    {
        private readonly IUnitWork _unitWork;

        public BookingScheduleManager(IUnitWork unitWork)
        {
            _unitWork = unitWork;
        }

        public async Task<List<ScheduleInfo>> GetScheduleInfosAsync()
        {
            try
            {
                List<ScheduleInfo> data = await _unitWork._iBookingRepository.GetScheduleList();
                return data;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
