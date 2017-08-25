using System;

namespace AspnetcoreAutofac
{
    public class WeatherApi : IDisposable
    {
        public WeatherApi() => Console.WriteLine("WeatherApi construct");

        public void GetWeather() => Console.WriteLine("Retrieving weather...");

        public void Dispose() => Console.WriteLine("WeatherApi disposed");
    }
}
