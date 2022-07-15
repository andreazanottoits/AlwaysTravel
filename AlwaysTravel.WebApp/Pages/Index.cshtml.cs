using AlwaysTravel.ApplicationCore.Interfaces.IService;
using AlwaysTravel.DTO;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AlwaysTravel.WebApp.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly ITravelService _travelService;
        public IEnumerable<Travel> Travels { get; set; }
        public IndexModel(ILogger<IndexModel> logger, ITravelService travelService)
        {
            _logger = logger;
            _travelService = travelService;
        }

        /*
        public async Task OnGet()
        {
            using var client = new HttpClient();
            try
            {
                HttpResponseMessage? response = await client.GetAsync("https://localhost:7146/api/Travel/GetAllTravels");
                if (response.IsSuccessStatusCode)
                {
                    string content = await response.Content.ReadAsStringAsync();
                    var options = new JsonSerializerOptions();
                    options.PropertyNameCaseInsensitive = true;
                    Travels = JsonSerializer.Deserialize<List<Travel>>(content, options);

                }
            }
            catch (Exception)
            {

            }
        }
        */

        public void OnGet()
        {
            Travels = _travelService.GetAll();
        }
    }
}