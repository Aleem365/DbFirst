using DatabaseFirstDemo.Models;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using System.Data.Entity;

namespace DatabaseFirstDemo.Controllers
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
        private readonly EmpContext _dbcontext;

        public WeatherForecastController(ILogger<WeatherForecastController> logger,EmpContext context)
        {
            _logger = logger;
            _dbcontext = context;
        }

        [HttpGet]
        public IEnumerable<Employee> Get()
        {
          return _dbcontext.Employees.ToList();
        }
       
    }
}
