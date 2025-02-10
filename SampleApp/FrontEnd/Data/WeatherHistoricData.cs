namespace FrontEnd.Data
{
    public class WeatherHistoricData
    {
        public DateOnly Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public string? Summary { get; set; }

        public double Precipitation { get; set; } // in millimeters

        public double WindSpeed { get; set; } // in km/h

        public int Humidity { get; set; } // in percentage

        public int Pressure { get; set; } // in hPa 

        public int Visibility { get; set; } // in km

        public int UVIndex { get; set; }

        public int AirQualityIndex { get; set; }

        public int PollenCount { get; set; }

        public int MoldCount { get; set; }

        //default constructor
        public WeatherHistoricData()
        {
            Date = new DateOnly();
            TemperatureC = 0;
            Summary = "";
            Precipitation = 0;
            WindSpeed = 0;
            Humidity = 0;
            Pressure = 0;
            Visibility = 0;
            UVIndex = 0;
            AirQualityIndex = 0;
            PollenCount = 0;
            MoldCount = 0;
        }

        //parameterized constructor
        public WeatherHistoricData(DateOnly date, int temperatureC, string summary, double precipitation, double windSpeed, int humidity, int pressure, int visibility, int uvIndex, int airQualityIndex, int pollenCount, int moldCount)
        {
            Date = date;
            TemperatureC = temperatureC;
            Summary = summary;
            Precipitation = precipitation;
            WindSpeed = windSpeed;
            Humidity = humidity;
            Pressure = pressure;
            Visibility = visibility;
            UVIndex = uvIndex;
            AirQualityIndex = airQualityIndex;
            PollenCount = pollenCount;
            MoldCount = moldCount;
        }

        //OVERRIDE EQUALS METHOD
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }
            WeatherHistoricData weatherHistoricData = (WeatherHistoricData)obj;
            return (Date == weatherHistoricData.Date) && (TemperatureC == weatherHistoricData.TemperatureC) && (Summary == weatherHistoricData.Summary) && (Precipitation == weatherHistoricData.Precipitation) && (WindSpeed == weatherHistoricData.WindSpeed) && (Humidity == weatherHistoricData.Humidity) && (Pressure == weatherHistoricData.Pressure) && (Visibility == weatherHistoricData.Visibility) && (UVIndex == weatherHistoricData.UVIndex) && (AirQualityIndex == weatherHistoricData.AirQualityIndex) && (PollenCount == weatherHistoricData.PollenCount) && (MoldCount == weatherHistoricData.MoldCount);
        }
    }
}