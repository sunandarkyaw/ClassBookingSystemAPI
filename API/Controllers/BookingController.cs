using BookingService.Manager.Interface;
using Core.Entities.InputModels;
using Core.Entities.Models;
using Interface.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BookingService.Controllers
{
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
        public async Task<IActionResult> GetScheduleList(LoginInfo info)
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
        public IActionResult BookClass(BookingInput info)
        {
            try
            {
                UserInfo user = new UserInfo();
                CodeMessageWithData<UserInfo> code = new CodeMessageWithData<UserInfo>();
                code.code = "201";
                code.message = "Okay";
                code.data = user;
                return Ok(code);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("CancelClass", Name = "CancelClass")]
        public IActionResult CancelClass(CancelInput info)
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

    }
}
