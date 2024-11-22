
using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Net.Http.Json;
namespace apiW
{
    internal class Program
    {
        static async Task Main()
        {
            // Replace "YOUR_API_KEY" with your actual OpenWeatherMap API key
            string apiKey = "958a0cca7d6e90effe76435c6f3c35d7";

            // Replace "London" with the desired city name
            string cityName = "London";

            // Construct the API URL using the base URL, API key, and city name
            string apiUrl = $"http://api.openweathermap.org/data/2.5/weather?q={cityName}&appid={apiKey}";

            try
            {
                using (HttpClient client = new HttpClient())
                {
                    HttpResponseMessage response = await client.GetAsync(apiUrl);

                    if (response.IsSuccessStatusCode)
                    {
                        WeatherData weatherData = await response.Content.ReadFromJsonAsync<WeatherData>();

                        if (weatherData != null)
                        {
                            string cityNameResult = weatherData.Name;
                            float temperatureKelvin = weatherData.Main.Temp;
                            float temperatureCelsius = temperatureKelvin - 273.15f;

                            Console.WriteLine($"City: {cityNameResult}");
                            Console.WriteLine($"Temperature: {temperatureCelsius}°C");
                        }
                        else
                        {
                            Console.WriteLine("Error: Unable to deserialize the JSON response.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Error: " + response.StatusCode);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }

            Console.ReadLine();
        }
    }
}