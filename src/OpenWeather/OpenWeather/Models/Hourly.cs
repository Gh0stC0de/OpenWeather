using System.Text.Json.Serialization;

namespace OpenWeather.Models
{
    /// <summary>
    ///     Hourly forecast weather data.
    /// </summary>
    public class Hourly : WeatherBase
    {
        [JsonConstructor]
        public Hourly(float temperature, float feelsLike, int visibility,
            float probability, Rain? rain = null, Snow? snow = null)
        {
            Temperature = temperature;
            FeelsLike = feelsLike;
            Visibility = visibility;
            Probability = probability;
            Rain = rain;
            Snow = snow;
        }

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
        ///     Probability of precipitation.
        /// </summary>
        [JsonPropertyName("pop")]
        public float Probability { get; set; }

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