namespace FrontEnd.Data
{
    public class WeatherForecast
    {
        public DateOnly Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public double TemperatureK => TemperatureC + 273.15; // Add Kelvin conversion

        public string? Summary { get; set; }
    }
}