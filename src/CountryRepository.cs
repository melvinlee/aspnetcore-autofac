using System;
using System.Collections.Generic;

namespace AspnetcoreAutofac
{
    public class CountryRepository : IRepository<Country>
    {
        public CountryRepository() => Console.WriteLine("CountryRepository countruct");

        public IEnumerable<Country> GetAll()
        {
            var countries = new List<Country>
            {
                new Country
                {
                    Name = "Singapore",
                    Capitol = "Singapore"
                },

                new Country
                {
                    Name = "Malaysia",
                    Capitol = "Kuala Lumpur"
                }
            };

            return countries;
        }

        public void Dispose() => Console.WriteLine("CountryRepository disposed");

    }
}
