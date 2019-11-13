using System;
using WeatherApp;
using WeatherAppLibrary;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace WeatherApp
{
    class Program
    {
        static async Task Main(string[] args)
        {
            WeatherInformation weatherInformation = await WeatherGenerator.GetWeatherAppAsync();

            Console.WriteLine(weatherInformation.Temperature);
            Console.WriteLine(weatherInformation.Humidity);
            Console.WriteLine(weatherInformation.Weather);
          
        }
    }
}
