using CleanArch.Application;
using CleanArch.Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace CleanArch.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MasterController : ControllerBase
    {
        public readonly IMasterFieldService _masterService;
        private readonly IConfiguration _configuration;
        IOptions<MyOptions> _options;
        public MasterController(IMasterFieldService masterService,IConfiguration configuration, IOptions<MyOptions> options)
        {
            _masterService = masterService;
            _configuration = configuration;
            _options = options;
        }
    
        [HttpGet]
        [Route("bu")]
        public ActionResult<List<MasterDetailsModel>> BuDetails()
        {
            // Access app settings values
            var settingValue = _configuration["MyKey"];
            var value = _options.Value.Default;

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
