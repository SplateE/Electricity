using Electricity.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace Electricity.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ElectricityController : ControllerBase
    {
        
        private readonly ILogger<ElectricityController> _logger;
        private readonly ILastToMonthData _lastToMonthData;
        public ElectricityController(ILogger<ElectricityController> logger,ILastToMonthData lastToMonthData)
        {
            _lastToMonthData= lastToMonthData;
            _logger = logger;
        }

        [HttpGet(Name = "GetLastTwoMonths")]
        public async Task<IActionResult> GetLastTwoMonths()
        {
            try
            {
                var Result = await _lastToMonthData.GetLastTwoMonthData();
                return Ok(Result);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message,ex);
                return StatusCode(500, ex.Message);
            }
        }
    }
}