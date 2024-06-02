using AutoMapper;
using BCVP.net8.IService;
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
        private readonly IBaseService<Role, RoleVo> _baseService;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, IMapper mapper, IBaseService<Role, RoleVo> baseService)
        {
            _logger = logger;
            _mapper = mapper;
            _baseService = baseService;
        }

 

        [HttpGet(Name = "getRole")]
        public async Task<object> GetRole()
        {
            var baseList = await _baseService.Query();
            return baseList;
        }
    }
}
