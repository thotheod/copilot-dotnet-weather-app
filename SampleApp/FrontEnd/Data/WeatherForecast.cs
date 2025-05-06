namespace FrontEnd.Data
{
    public class WeatherForecast
    {
        public DateOnly Date { get; set; }

        public int tempCelsius { get; set; }

        public int TemperatureF => 32 + (int)(tempCelsius / 0.5556);
        public double TemperatureK => tempCelsius + 273.15;

        public string? Summary { get; set; }

        public string? SummaryIcon { get; set; }
    }
}