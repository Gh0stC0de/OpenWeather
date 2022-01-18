using System.Text.Json.Serialization;

namespace OpenWeather.Models
{
    /// <summary>
    ///     The daily forecast weather data.
    /// </summary>
    public class Daily : WeatherBase
    {
        [JsonConstructor]
        public Daily(long sunrise, long sunset, long moonrise, long moonset,
            float moonPhase, float probability, Temperature temperature, FeelsLike feelsLike,
            float? rainPrecipitation = null, float? snow = null)
        {
            Sunrise = sunrise;
            Sunset = sunset;
            Moonrise = moonrise;
            Moonset = moonset;
            MoonPhase = moonPhase;
            Probability = probability;
            Temperature = temperature;
            FeelsLike = feelsLike;
            RainPrecipitation = rainPrecipitation;
            Snow = snow;
        }

        /// <summary>
        ///     The sunrise timestamp in UNIX seconds (UTC).
        /// </summary>
        [JsonPropertyName("sunrise")]
        public long Sunrise { get; set; }

        /// <summary>
        ///     The sunset timestamp in UNIX seconds (UTC).
        /// </summary>
        [JsonPropertyName("sunset")]
        public long Sunset { get; set; }

        /// <summary>
        ///     The moonrise timestamp in UNIX seconds (UTC).
        /// </summary>
        [JsonPropertyName("moonrise")]
        public long Moonrise { get; set; }

        /// <summary>
        ///     The moonset timestamp in UNIX seconds (UTC).
        /// </summary>
        [JsonPropertyName("moonset")]
        public long Moonset { get; set; }

        /// <summary>
        ///     The moon phase.
        ///     0 and 1 are 'new moon', 0.25 is 'first quarter moon', 0.5 is 'full moon'
        ///     and 0.75 is 'last quarter moon'.
        ///     The periods in between are called 'waxing crescent', 'waxing gibous',
        ///     'waning gibous', and 'waning crescent', respectively.
        /// </summary>
        [JsonPropertyName("moon_phase")]
        public float MoonPhase { get; set; }

        /// <summary>
        ///     Probability of precipitation.
        /// </summary>
        [JsonPropertyName("pop")]
        public float Probability { get; set; }

        /// <summary>
        ///     The temperature in the queried units (kelvin, Celsius, Fahrenheit).
        /// </summary>
        [JsonPropertyName("temp")]
        public Temperature Temperature { get; set; }

        /// <summary>
        ///     This accounts for the human perception of weather.
        ///     Units – default: kelvin, metric: Celsius, imperial: Fahrenheit.
        /// </summary>
        [JsonPropertyName("feels_like")]
        public FeelsLike FeelsLike { get; set; }

        /// <summary>
        ///     (where available) The precipitation volume in mm.
        /// </summary>
        [JsonPropertyName("rain")]
        public float? RainPrecipitation { get; set; }

        /// <summary>
        ///     (where available) The snow volume in mm.
        /// </summary>
        [JsonPropertyName("snow")]
        public float? Snow { get; set; }
    }
}