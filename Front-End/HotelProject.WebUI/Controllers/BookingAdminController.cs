using HotelProject.WebUI.DTOs.BookingDTO;
using HotelProject.WebUI.DTOs.ServiceDTO;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;

namespace HotelProject.WebUI.Controllers
{
    public class BookingAdminController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public BookingAdminController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> Index()
        {
            var client = _httpClientFactory.CreateClient(); //client created
            var responseMessage = await client.GetAsync("http://localhost:5069/api/Booking"); //requested to related address
            if (responseMessage.IsSuccessStatusCode) //If a "successful code" is returned from the related address
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync(); //we assign data to jsondata
                var values = JsonConvert.DeserializeObject<List<ResultBookingDto>>(jsonData); //We deserialized the incoming data which is in json type
                return View(values);
            }
            return View();
        }
        public async Task<IActionResult> ApprovedReservation(ApprovedReservationDto approvedReservationDto)
        {
            approvedReservationDto.Status = "Confirmed";
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(approvedReservationDto);
            StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");

            var responseMessage = await client.PutAsync("http://localhost:5069/api/Booking/blaBlaa", stringContent);
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}
