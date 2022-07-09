using AlwaysTravel.DTO;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Text.Json;

namespace AlwaysTravel.WebApp.Pages
{
    public class TravelDetailModel : PageModel
    {
        public List<StageData> StagesData { get; set; }
        public async Task OnGet(int id)
        {
            using var client = new HttpClient();
            try
            {
                HttpResponseMessage? response = await client.GetAsync("https://localhost:7146/api/Travel/GetTravelData/" + id);
                if (response.IsSuccessStatusCode)
                {
                    string content = await response.Content.ReadAsStringAsync();
                    var options = new JsonSerializerOptions();
                    options.PropertyNameCaseInsensitive = true;
                    StagesData = JsonSerializer.Deserialize<List<StageData>>(content, options);

                }
            }
            catch (Exception)
            {

            }
        }
    }
}
