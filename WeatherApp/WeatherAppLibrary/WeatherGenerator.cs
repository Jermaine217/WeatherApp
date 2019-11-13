using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using WeatherAppLibrary;
using System.Collections.Generic;

namespace WeatherAppLibrary
{
    public class WeatherGenerator
    {
        private static string returnString;

        public static object JsonConvery { get; private set; }


        public static async Task<WeatherInformation> GetWeatherAppAsync()
        {
            HttpClient httpClient = new HttpClient();

            String dj = await httpClient.GetStringAsync("http://api.openweathermap.org/data/2.5/weather?q=Cape%20Town&appid=43ce5763f10225f770cd79087d175677");

            WeatherData weatherGenerator = JsonConvert.DeserializeObject<WeatherData>(dj);

            var weatherInfo = new WeatherInformation();
            weatherInfo.Temperature = weatherGenerator.main.temp;
            weatherInfo.Humidity = weatherGenerator.main.humidity;

            foreach (var weather in weatherGenerator.weather)
                weatherInfo.Weather = weather.description;

          


            return weatherInfo;



        }

        

    }
}


