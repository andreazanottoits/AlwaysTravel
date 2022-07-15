using AlwaysTravel.ApplicationCore.Interfaces.IService;
using AlwaysTravel.DTO;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Text.Json;

namespace AlwaysTravel.WebApp.Pages
{
    public class TravelDetailModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly ITravelService _travelService;
        public IEnumerable<StageData> StagesData { get; set; }

        public TravelDetailModel(ILogger<IndexModel> logger, ITravelService travelService)
        {
            _logger = logger;
            _travelService = travelService;
        }

        /*
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
        */

        public void OnGet(int id)
        {
            StagesData = _travelService.GetAllTravelInformation(id);
        }
    }
}
