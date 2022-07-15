using AlwaysTravel.ApplicationCore.Interfaces.IService;
using AlwaysTravel.DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AlwaysTravel.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TravelController : ControllerBase
    {
        private readonly ITravelService _travelService;
        private readonly IPackageService _packageService;
        private readonly ITravelHasStageService _travelHasStageService;
        private readonly IStageService _stageService;

        public TravelController(ITravelService travelService, IPackageService packageService, ITravelHasStageService travelHasStageService, IStageService stageService)
        {
            _travelService = travelService;
            _packageService = packageService;
            _travelHasStageService = travelHasStageService;
            _stageService = stageService;
        }

        [HttpGet]
        [Route("GetAllTravels")]
        public IActionResult GetAllTravels()
        {
            IEnumerable<Travel>? data = _travelService.GetAll();
            return Ok(data);
        }

        [HttpGet]
        [Route("GetTravelData/{id}")]
        public IActionResult GetTravelData(int id)
        {
            List<StageData>? travelData = _travelService.GetAllTravelInformation(id);
            return Ok(travelData);
        }

    }
}
