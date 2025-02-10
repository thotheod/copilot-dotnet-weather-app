namespace FrontEnd.Data
{
    public class WeatherForecastClient
    {
        private HttpClient _httpClient; // HttpClient instance
        private ILogger<WeatherForecastClient> _logger; // Logger instance

        public WeatherForecastClient(HttpClient httpClient, ILogger<WeatherForecastClient> logger)
        {
            _httpClient = httpClient; // Assign HttpClient
            _logger = logger; // Assign Logger
        }

        public async Task<WeatherForecast[]> GetForecastAsync(DateTime? startDate)
        {
            // Fetch weather forecasts
            var forecasts = await _httpClient.GetFromJsonAsync<WeatherForecast[]>($"WeatherForecast?startDate={startDate}");
            if (forecasts == null) // Check if forecasts is null
            {
                _logger.LogError("Received null response from WeatherForecast API"); // Log error
                throw new InvalidOperationException("Received null response from WeatherForecast API"); // Throw exception
            }
            return forecasts; // Return forecasts
        }

        // Redundant method that does nothing
        public void DoNothing()
        {
            // This method does nothing
        }

        // Another redundant method
        public void AnotherMethod()
        {
            // This method also does nothing
        }
    }
}