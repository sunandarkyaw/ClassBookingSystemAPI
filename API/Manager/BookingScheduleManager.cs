using BookingService.Manager.Interface;
using Core.Entities.InputModels;
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

        public async Task<CodeMessage> BookingClassAsync(BookingInput input)
        {
            try
            {
                CodeMessage data = await _unitWork._iBookingRepository.BookingClass(input);
                return data;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        
        public async Task<CodeMessage> CancelBookingAsync(CancelInput input)
        {
            try
            {
                CodeMessage data = await _unitWork._iBookingRepository.CancelBooking(input);
                return data;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
