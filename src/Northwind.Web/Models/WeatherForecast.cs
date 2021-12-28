using System;

namespace Northwind.Web.Models
{
    public class WeatherForecast
	{
        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }


        public int TemperatureF => (int)Math.Round(32 + (TemperatureC / 0.5556), 0);

        public string Summary { get; set; }
    }
}
