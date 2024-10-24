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
        private readonly IBookingRepository _bookingRepository;

        public BookingController(ILogger<BookingController> logger, IBookingRepository bookingRepository)
        {
            _logger = logger;
            _bookingRepository = bookingRepository;
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
        public IActionResult GetScheduleList(LoginInfo info)
        {
            try
            {
                UserInfo user = new UserInfo();
                CodeMessageWithData<UserInfo> code = new CodeMessageWithData<UserInfo>();
                var data = _bookingRepository.GetScheduleList();
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
