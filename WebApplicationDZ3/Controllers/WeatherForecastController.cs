using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using Microsoft.Extensions.Options;
using System;
using System.Linq;
using System.Text.Json;
using Microsoft.AspNetCore.Http;
using static WebApplicationDZ3.CustomConfig;

namespace WebApplicationDZ3.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        

        private readonly ILogger<WeatherForecastController> _logger;
        private readonly  IConfiguration config;
        private readonly IOptions<CustomConfig> myConfig;
        private CustomConfig custom;
       
        


        public WeatherForecastController(ILogger<WeatherForecastController> logger , IOptions<CustomConfig> myConfig , IConfiguration config , CustomConfig custom)
        {
            
            _logger = logger;
            this.config = config;
            this.myConfig = myConfig;
            this.custom = custom;
            
        }

        
        [HttpGet]
        public  string Get()
        {

            return $"First from config :{custom.FirstAction().ToString()}";
           
        }




    }
}
