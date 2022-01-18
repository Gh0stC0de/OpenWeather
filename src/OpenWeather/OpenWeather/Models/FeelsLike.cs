using System.Text.Json.Serialization;

namespace OpenWeather.Models
{
    /// <summary>
    ///     This accounts for the human perception of weather.
    ///     Units – default: kelvin, metric: Celsius, imperial: Fahrenheit.
    /// </summary>
    public class FeelsLike
    {
        [JsonConstructor]
        public FeelsLike(float morning, float day, float evening, float night)
        {
            Morning = morning;
            Day = day;
            Evening = evening;
            Night = night;
        }

        /// <summary>
        ///     The morning temperature.
        /// </summary>
        [JsonPropertyName("morn")]
        public float Morning { get; set; }

        /// <summary>
        ///     The day temperature.
        /// </summary>
        [JsonPropertyName("day")]
        public float Day { get; set; }

        /// <summary>
        ///     The evening temperature.
        /// </summary>
        [JsonPropertyName("eve")]
        public float Evening { get; set; }

        /// <summary>
        ///     The night temperature.
        /// </summary>
        [JsonPropertyName("night")]
        public float Night { get; set; }
    }
}