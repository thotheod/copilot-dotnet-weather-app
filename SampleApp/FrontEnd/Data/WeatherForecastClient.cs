namespace FrontEnd.Data
{
    public class WeatherForecastClient
    {
        private HttpClient _httpClient;
        private ILogger<WeatherForecastClient> _logger;

        public WeatherForecastClient(HttpClient httpClient, ILogger<WeatherForecastClient> logger)
        {
            _httpClient = httpClient;
            _logger = logger;
        }

        public Task<WeatherForecast[]> GetForecastAsync(DateTime? startDate)
        {
            _logger.LogInformation("Starting GetForecastAsync method.");
            var forecasts = _httpClient.GetFromJsonAsync<WeatherForecast[]>($"WeatherForecast?startDate={startDate}").Result;
            if (forecasts == null)
            {
                _logger.LogWarning("Received null response from WeatherForecast API.");
                if (forecasts == null)
                {
                    _logger.LogError("Forecasts is still null.");
                    return Task.FromResult(new WeatherForecast[0]);
                }
            }
            _logger.LogInformation("Returning forecasts.");
            return Task.FromResult(forecasts);
        }
    }
}