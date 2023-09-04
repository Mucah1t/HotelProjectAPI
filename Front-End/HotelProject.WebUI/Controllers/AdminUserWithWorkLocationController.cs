using HotelProject.WebUI.DTOs.AppUserDTO;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace HotelProject.WebUI.Controllers
{
    public class AdminUserWithWorkLocationController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public AdminUserWithWorkLocationController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public async Task<IActionResult> UserList()
        {
            var client = _httpClientFactory.CreateClient(); //client created
            var responseMessage = await client.GetAsync("http://localhost:5069/api/AppUserWorkLocation"); //requested to related address
            if (responseMessage.IsSuccessStatusCode) //If a "successful code" is returned from the related address
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync(); //we assign data to jsondata
                var values = JsonConvert.DeserializeObject<List<ResultAppUserListDto>>(jsonData); //We deserialized the incoming data which is in json type
                return View(values);
            }
            return View();
        }
    }
}
