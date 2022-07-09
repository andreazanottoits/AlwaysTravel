using AlwaysTravel.ApplicationCore.Interfaces.IService;
using AlwaysTravel.DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AlwaysTravel.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PackageController : ControllerBase
    {
        private readonly IPackageService _packageService;

        public PackageController(IPackageService packageService)
        {
            _packageService = packageService;
        }

        [HttpGet]
        [Route("GetAllPackagesByStageId/{stageId}")]
        public IActionResult GetAllData(int stageId)
        {
            IEnumerable<Package>? data = _packageService.GetAllPackagesByStageId(stageId);
            return Ok(data);
        }
    }
}
