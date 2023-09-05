using HotelProject.BusinessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingController : ControllerBase
    {
        private readonly IBookingService _bookingService;

        public BookingController(IBookingService bookingService)
        {
            _bookingService = bookingService;
        }

        [HttpGet]
        public IActionResult BookingList()
        {
            var values = _bookingService.TGetList();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult AddBooking(Booking booking)
        {
            _bookingService.TInsert(booking);
            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteBooking(int id)
        {
            var vDelete = _bookingService.TGetByID(id);
            _bookingService.TDelete(vDelete);
            return Ok();
        }
        [HttpPut("UpdateBooking")]
        public IActionResult UpdateBooking(Booking booking)
        {
            _bookingService.TUpdate(booking);
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult GetBooking(int id)
        {
            var vGet = _bookingService.TGetByID(id);
            return Ok(vGet);
        }
        [HttpPut("blaBla")]
        public IActionResult blaBla(Booking booking)
        {
            _bookingService.TBookingStatusChangeApproved(booking);
            return Ok();
        }
        [HttpPut("blaBlaa")]
        public IActionResult blaBlaa(int id)
        {
            _bookingService.TBookingStatusChangeApproved2(id);
            return Ok();
        }
        [HttpGet("Last2Bookings")]
        public IActionResult Last2Bookings()
        {
            var vGet = _bookingService.TLast2Bookings();
            return Ok(vGet);
        }
    }
}

