using HotelProject.WebUI.DTOs.BookingDTO;
using HotelProject.WebUI.DTOs.ContactDTO;
using HotelProject.WebUI.DTOs.MessageCategoryDTO;
using HotelProject.WebUI.DTOs.RoomDTO;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.WebUI.Controllers
{
    [AllowAnonymous]
    public class ContactController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;
        public ContactController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public async Task<IActionResult> Index()
        {
            var client = _httpClientFactory.CreateClient(); //client created
            var responseMessage = await client.GetAsync("http://localhost:5069/api/MessageCategory"); //requested to related address
         
                var jsonData = await responseMessage.Content.ReadAsStringAsync(); //we assign data to jsondata
                var values = JsonConvert.DeserializeObject<List<ResultMessageCategoryDto>>(jsonData); //We deserialized the incoming data which is in json type
            List<SelectListItem> values2=(from x in values
                                          select new SelectListItem
                                          {
                                              Text=x.MessageCategoryName,
                                              Value=x.MessageCategoryID.ToString()

                                          }).ToList();
            ViewBag.v = values2;

            return View();
           
         
         
        }
        [HttpGet]
        public PartialViewResult sendMessage()
        {
            return PartialView();
        }
        [HttpPost]
        public async Task<IActionResult> sendMessage(CreateContactDto createContactDto)
        {
            createContactDto.Date = DateTime.Parse(DateTime.Now.ToShortDateString());

            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(createContactDto);
            StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
            await client.PostAsync("http://localhost:5069/api/Contact", stringContent);

            return RedirectToAction("Index", "Default");
        }
    }
}
