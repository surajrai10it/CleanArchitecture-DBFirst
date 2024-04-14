using CleanArch.Application;
using CleanArch.Domain;
using Microsoft.AspNetCore.Mvc;

namespace CleanArch.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MasterController : ControllerBase
    {
        public readonly IMasterFieldService _masterService;
        public MasterController(IMasterFieldService masterService)
        {
            _masterService = masterService;
        }
    
        [HttpGet]
        [Route("bu")]
        public ActionResult<List<MasterDetailsModel>> BuDetails()
        {
           var bu = _masterService.GetBu();
            return Ok(bu);
        }
        [HttpGet]
        [Route("designation")]
        public ActionResult<List<MasterDetailsModel>> DesignationDetails()
        {
            var designation = _masterService.GetDesignation();
            return Ok(designation);
        }
    }
}
