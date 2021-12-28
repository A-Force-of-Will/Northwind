using System;
using Northwind.Web.Models;

namespace Northwind.Web.Services
{
	public interface IWeatherForecastService 
	{
		WeatherForecast ForecastFor(DateTime dateTime);

		string SummaryFor(int temperature);

		WeatherForecast ForecastWithSetTemperature(int temperature);
	}


	public class WeatherForecastService : IWeatherForecastService
	{
		private static readonly string[] Summaries = new[]
		{
				"Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
		};

		public WeatherForecast ForecastFor(DateTime dateTime)
		{
            if (DateTime.Now.AddDays(-1) >= dateTime)
            {
				throw new ArgumentException("Cannot Get the forecast for yesterday!");
            }
            else
            {
				var rng = new Random();
				var temperatureC = rng.Next(-20, 55);
				return new WeatherForecast
				{
						Date = dateTime,
						TemperatureC = temperatureC,
						Summary = SummaryFor(temperatureC)
				};
            }
		}

		public WeatherForecast ForecastWithSetTemperature(int temperature)
        {
			//set temperature to given temperature
			int temperatureC = (temperature-32) * 5/9;
			return new WeatherForecast
			{
				Date = DateTime.Now,
				TemperatureC = temperatureC,
				Summary = SummaryFor(temperature)
			};
		}

		public string SummaryFor(int temperature)
		{
			float total = temperature;
			float step = 13.5f;

			int index = 0;
            while (total >= step)
            {
				total -= step;
				index++;
            }

			return Summaries[index - 1];
		}
	}

}