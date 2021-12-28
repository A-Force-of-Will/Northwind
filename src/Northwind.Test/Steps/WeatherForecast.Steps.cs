using System;

using Xunit;
using Xunit.Gherkin.Quick;


using Northwind.Web.Services;
using Northwind.Web.Models;

namespace Northwind.Test.Features
{
	[FeatureFile("./Features/WeatherForecast.feature")]
	public sealed class WeatherForecastFeature : Feature
	{
		private IWeatherForecastService _weather = null;
		private WeatherForecast _forecast = null;
		private Exception _serviceException = null;

		[Given(@"the weather forecast")]
		public void The_weather_forecast()
		{
			_weather = new WeatherForecastService();
		}

		[When(@"I get the forecast for tomorrow")]
		public void I_get_the_forecast_for_tomorrow()
		{
			_forecast = _weather.ForecastFor(DateTime.Now.AddDays(1));
		}

		[Then(@"the forecast temperature F should be greater than (\d+)")]
		public void The_forecast_temperature_F_should_be_greater_than(int temperature)
		{
			Assert.True(_forecast.TemperatureF > temperature);
		}

		[When(@"I get the forecast for yesterday")]
		public void I_get_the_forecast_for_yesterday()
		{
            try
            {
				_forecast = _weather.ForecastFor(DateTime.Now.AddDays(-1));
            }
            catch (ArgumentException exception)
            {
				_serviceException = exception;
            }
		}

		[Then(@"the service should throw an argument exception")]
		public void The_service_should_throw_an_argument_exception()
		{
			Assert.IsType<ArgumentException>(_serviceException);
		}

		[When(@"the temperature F is (\d+)")]
		public void The_temperature_F_is(int temperature)
        {
			_forecast = _weather.ForecastWithSetTemperature(temperature);
			Assert.Equal(temperature, _forecast.TemperatureF);
        }

		[Then(@"the forecast summary should be (Freezing|Bracing|Chilly|Cool|Mild|Warm|Balmy|Hot|Sweltering|Scorching)")]
		public void Then_the_forecast_summary_should_be(string summary)
        {
			Assert.True(String.Equals(_forecast.Summary, summary));
		}
	}
}