using AutoMapper;
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
        private readonly IMapper _mapper;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, IMapper mapper)
        {
            _logger = logger;
            _mapper = mapper;
        }

 

        [HttpGet(Name = "getRole")]
        public async Task<object> GetRole()
        {
            var baseService = new BaseService<Role, RoleVo>(_mapper);
            var baseList = await baseService.Query();
            return baseList;
        }
    }
}
