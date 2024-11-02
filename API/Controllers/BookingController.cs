using BookingService.Manager.Interface;
using Core.Entities.InputModels;
using Core.Entities.Models;
using Interface.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BookingService.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/[controller]")]
    public class BookingController : ControllerBase
    {
        private readonly ILogger<BookingController> _logger;
        private readonly IBookingScheduleManager _bookingScheduleManager;

        public BookingController(ILogger<BookingController> logger, IBookingScheduleManager bookingScheduleManager)
        {
            _logger = logger;
            _bookingScheduleManager = bookingScheduleManager;
        }
        [HttpPost("PurchaseClass", Name = "PurchaseClass")]
        public IActionResult PurchaseClass(PurchaseInput info)
        {
            try
            {
                UserInfo user = new UserInfo();
                CodeMessage code = new CodeMessage();
                code.code = "201";
                code.message = "Okay";
                return Ok(code);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("GetScheduleList", Name = "GetScheduleList")]
        public async Task<IActionResult> GetScheduleList()
        {
            try
            {
                CodeMessageWithData<List<ScheduleInfo>> code = new CodeMessageWithData<List<ScheduleInfo>>();
                var data = await _bookingScheduleManager.GetScheduleInfosAsync();
                code.code = "201";
                code.message = "Okay";
                code.data = data;
                return Ok(code);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("BookClass", Name = "BookClass")]
        public async Task<IActionResult> BookClass(BookingInput info)
        {
            try
            {
                CodeMessage code = new CodeMessage();
                code = await _bookingScheduleManager.BookingClassAsync(info);
                return Ok(code);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("CancelClass", Name = "CancelClass")]
        public async Task<IActionResult> CancelClass(CancelInput info)
        {
            try
            {
                CodeMessage code = new CodeMessage();
                code = await _bookingScheduleManager.CancelBookingAsync(info);
                return Ok(code);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

    }
}
