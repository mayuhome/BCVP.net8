using BCVP.net8.Model;
using BCVP.net8.Service;
using Microsoft.AspNetCore.Mvc;

namespace BCVP.net8.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

 

        [HttpGet(Name = "getRole")]
        public async Task<object> GetRole()
        {
            var baseService = new BaseService<RoleVo>();
            var baseList = await baseService.Query();
            return baseList;
        }
    }
}
