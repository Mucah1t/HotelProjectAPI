using HotelProject.WebUI.DTOs.FollowersDTO;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace HotelProject.WebUI.ViewComponents.Dashboard
{
    public class _DashboardSubscribeCountPartial:ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
           
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://instagram-profile1.p.rapidapi.com/getprofileinfo/gulsumistik"),
                Headers =
    {
        { "X-RapidAPI-Key", "de92f704a2mshbb4a9670abd28eep17130ejsn763089a8f18d" },
        { "X-RapidAPI-Host", "instagram-profile1.p.rapidapi.com" },
    },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
               ResultInstagramFollowersDto resultInstagrams = JsonConvert.DeserializeObject<ResultInstagramFollowersDto>(body);
                ViewBag.v1 = resultInstagrams.followers;
                ViewBag.v2 = resultInstagrams.following;
           
            }


            var client2 = new HttpClient();
            var request2 = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://twitter32.p.rapidapi.com/getProfile?username=gulsumistik"),
                Headers =
    {
        { "X-RapidAPI-Key", "de92f704a2mshbb4a9670abd28eep17130ejsn763089a8f18d" },
        { "X-RapidAPI-Host", "twitter32.p.rapidapi.com" },
    },
            };
            using (var response2 = await client2.SendAsync(request2))
            {
                response2.EnsureSuccessStatusCode();
                var body2 = await response2.Content.ReadAsStringAsync();
                ResultTwitterFollowersDto resultTwitterFollowersDto = JsonConvert.DeserializeObject<ResultTwitterFollowersDto>(body2);
                ViewBag.v3 = resultTwitterFollowersDto.data.user_info.followers_count;
                ViewBag.v4 = resultTwitterFollowersDto.data.user_info.friends_count;
            }
            return View();
        }
    }
}
