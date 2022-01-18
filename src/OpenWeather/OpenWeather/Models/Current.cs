using System.Text.Json.Serialization;

namespace OpenWeather.Models
{
    /// <summary>
    ///     The current weather data.
    /// </summary>
    public class Current : WeatherBase
    {
        [JsonConstructor]
        public Current(long sunrise, long sunset, float temperature, float feelsLike,
            int visibility, Rain? rain = null, Snow? snow = null)
        {
            Sunrise = sunrise;
            Sunset = sunset;
            Temperature = temperature;
            FeelsLike = feelsLike;
            Visibility = visibility;
            Rain = rain;
            Snow = snow;
        }

        /// <summary>
        ///     The sunrise timestamp in UNIX seconds.
        /// </summary>
        [JsonPropertyName("sunrise")]
        public long Sunrise { get; set; }

        /// <summary>
        ///     The sunset timestamp in UNIX seconds.
        /// </summary>
        [JsonPropertyName("sunset")]
        public long Sunset { get; set; }

        /// <summary>
        ///     The temperature in the queried units (kelvin, Celsius, Fahrenheit).
        /// </summary>
        [JsonPropertyName("temp")]
        public float Temperature { get; set; }

        /// <summary>
        ///     Temperature.
        ///     This temperature parameter accounts for the human perception of weather.
        ///     Units – default: kelvin, metric: Celsius, imperial: Fahrenheit.
        /// </summary>
        [JsonPropertyName("feels_like")]
        public float FeelsLike { get; set; }

        /// <summary>
        ///     Average visibility in metres.
        /// </summary>
        [JsonPropertyName("visibility")]
        public int Visibility { get; set; }

        /// <summary>
        ///     The rain data.
        /// </summary>
        [JsonPropertyName("rain")]
        public Rain? Rain { get; set; }

        /// <summary>
        ///     The snow data.
        /// </summary>
        [JsonPropertyName("snow")]
        public Snow? Snow { get; set; }
    }
}