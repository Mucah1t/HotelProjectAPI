using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using System;
using System.Net.Http;
using RapidApiConsume.Models;
using Newtonsoft.Json;

namespace RapidApiConsume.Controllers
{
    public class ExchangeController : Controller
    {
        public async Task<IActionResult> Index()
        {
          List<ExchangeViewModel> exchangeViewModels = new List<ExchangeViewModel>();
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://booking-com.p.rapidapi.com/v1/metadata/exchange-rates?currency=TRY&locale=en-gb"),
                Headers =
    {
        { "X-RapidAPI-Key", "de92f704a2mshbb4a9670abd28eep17130ejsn763089a8f18d" },
        { "X-RapidAPI-Host", "booking-com.p.rapidapi.com" },
    },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                var values=JsonConvert.DeserializeObject<ExchangeViewModel>(body);
               return View(values.exchange_rates.ToList());
            }
        }
    }
}
