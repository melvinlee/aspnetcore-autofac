using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace AspnetcoreAutofac.Controllers
{
    [Route("api/[controller]")]
    public class WeatherController : Controller
    {
        private readonly WeatherApi weatherApi;
        private readonly CountryRepository repository;

        public WeatherController(WeatherApi weatherApi, CountryRepository repository)
        {
            this.weatherApi = weatherApi;
            this.repository = repository;
        }

        [HttpGet]
        public string Get()
        {
            weatherApi.GetWeather();

            return "OK";
        }

        [HttpGet("[action]")]
        public IEnumerable<Country> Country()
        {
            return repository.GetAll();
        }
    }
}