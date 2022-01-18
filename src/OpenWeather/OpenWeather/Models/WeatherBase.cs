using System.Text.Json.Serialization;

namespace OpenWeather.Models
{
    /// <summary>
    ///     Weather data base class.
    /// </summary>
    public class WeatherBase
    {
        protected WeatherBase()
        {
            DateTime = default;
            Pressure = default;
            Humidity = default;
            DewPoint = default;
            Clouds = default;
            UvIndex = default;
            WindSpeed = default;
            WindGust = default;
            WindDirection = default;
            Weather = Array.Empty<Weather>();
        }

        [JsonConstructor]
        public WeatherBase(long dateTime, float pressure, float humidity, float dewPoint,
            int clouds, float uvIndex, float windSpeed, float windGust, int windDirection,
            Weather[] weather)
        {
            DateTime = dateTime;
            Pressure = pressure;
            Humidity = humidity;
            DewPoint = dewPoint;
            Clouds = clouds;
            UvIndex = uvIndex;
            WindSpeed = windSpeed;
            WindGust = windGust;
            WindDirection = windDirection;
            Weather = weather;
        }

        /// <summary>
        ///     The date and time of the weather data in UNIX seconds (UTC).
        /// </summary>
        [JsonPropertyName("dt")]
        public long DateTime { get; set; }

        /// <summary>
        ///     Atmospheric pressure on the sea level in hPa.
        /// </summary>
        [JsonPropertyName("pressure")]
        public float Pressure { get; set; }

        /// <summary>
        ///     Humidity in %.
        /// </summary>
        [JsonPropertyName("humidity")]
        public float Humidity { get; set; }

        /// <summary>
        ///      Atmospheric temperature (varying according to pressure and humidity)
        ///      below which water droplets begin to condense and dew can form.
        ///      Units – default: kelvin, metric: Celsius, imperial: Fahrenheit.
        /// </summary>
        [JsonPropertyName("dew_point")]
        public float DewPoint { get; set; }

        /// <summary>
        ///     The cloudiness in %.
        /// </summary>
        [JsonPropertyName("clouds")]
        public int Clouds { get; set; }
        public float UvIndex { get; }

        /// <summary>
        ///     The UV index.
        /// </summary>
        [JsonPropertyName("uvi")]
        public float UVIndex { get; set; }

        /// <summary>
        ///     Wind speed. Wind speed.
        ///     Units – default: metre/sec, metric: metre/sec, imperial: miles/hour.
        /// </summary>
        [JsonPropertyName("wind_speed")]
        public float WindSpeed { get; set; }

        /// <summary>
        ///     (where available) Wind gust.
        ///     Units – default: metre/sec, metric: metre/sec, imperial: miles/hour.
        /// </summary>
        [JsonPropertyName("wind_gust")]
        public float WindGust { get; set; }

        /// <summary>
        ///     Wind direction in degrees (meteorological).
        /// </summary>
        [JsonPropertyName("wind_deg")]
        public int WindDirection { get; set; }

        /// <summary>
        ///     The weather data.
        /// </summary>
        [JsonPropertyName("weather")]
        public Weather[] Weather { get; set; }
    }
}