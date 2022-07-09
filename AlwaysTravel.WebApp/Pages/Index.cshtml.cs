using AlwaysTravel.DTO;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Text.Json;

namespace AlwaysTravel.WebApp.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        public List<Travel> Travels { get; set; }
        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

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
    }
}