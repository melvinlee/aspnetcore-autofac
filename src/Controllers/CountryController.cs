using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace AspnetcoreAutofac.Controllers
{
    [Route("api/[controller]")]
    public class CountryController : Controller
    {
        private readonly IRepository<Country> countryRepository;

        public CountryController(IRepository<Country> CountryRepository)
        {
            countryRepository = CountryRepository;
        }

        // GET api/values
        [HttpGet]
        public IEnumerable<Country> Get()
        {
            return countryRepository.GetAll();
        }
    }
}
