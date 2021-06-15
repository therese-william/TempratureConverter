using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TempratureConverter.BL;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TempratureConverter.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TempratureController : ControllerBase
    {
        private ITempratureService _tempratureService;

        public TempratureController(ITempratureService tempratureService)
        {
            _tempratureService = tempratureService;
        }

        [HttpGet("GetTempratureByCelsius")]
        public Temprature GetTempratureByCelsius(int celsius)
        {
            return _tempratureService.GetTempratureByCelsius(celsius);
        }

        [HttpGet("GetTempratureByFahrenheit")]
        public Temprature GetTempratureByFahrenheit(int fahrenheit)
        {
            return _tempratureService.GetTempratureByFahrenheit(fahrenheit);
        }

        [HttpGet("GetTempratureByKelvin")]
        public Temprature GetTempratureByKelvin(int kelvin)
        {
            return _tempratureService.GetTempratureByKelvin(kelvin);
        }
    }
}
