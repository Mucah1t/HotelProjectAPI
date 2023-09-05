using HotelProject.WebUI.DTOs.GuestDTO;
using HotelProject.WebUI.DTOs.StaffDTO;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace HotelProject.WebUI.ViewComponents.Dashboard
{
    public class _DashboardLast4StaffList : ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _DashboardLast4StaffList(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient(); //client created
            var responseMessage = await client.GetAsync("http://localhost:5069/api/Staff/Last4Staff"); //requested to related address
            if (responseMessage.IsSuccessStatusCode) //If a "successful code" is returned from the related address
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync(); //we assign data to jsondata
                var values = JsonConvert.DeserializeObject<List<ResultLast4StaffDto>>(jsonData); //We deserialized the incoming data which is in json type
                return View(values);
            }
            return View();
        }

    }
}
