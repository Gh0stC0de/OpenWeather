using System.Text.Json.Serialization;

namespace OpenWeather.Models
{
    /// <summary>
    ///     OpenWaether temperature.
    /// </summary>
    public class Temperature
    {
        [JsonConstructor]
        public Temperature(float day, float night, float morning, float evening, float minimum, float maximum)
        {
            Day = day;
            Night = night;
            Morning = morning;
            Evening = evening;
            Minimum = minimum;
            Maximum = maximum;
        }

        /// <summary>
        ///     The daytime temperature.
        /// </summary>
        [JsonPropertyName("day")]
        public float Day { get; set; }

        /// <summary>
        ///     The nighttime temperature.
        /// </summary>
        [JsonPropertyName("night")]
        public float Night { get; set; }

        /// <summary>
        ///     The morning temperature.
        /// </summary>
        [JsonPropertyName("morn")]
        public float Morning { get; set; }

        /// <summary>
        ///     The evening temperature.
        /// </summary>
        [JsonPropertyName("eve")]
        public float Evening { get; set; }

        /// <summary>
        ///     The minimum daily temperature.
        /// </summary>
        [JsonPropertyName("min")]
        public float Minimum { get; set; }

        /// <summary>
        ///     The maximum dailty temperature.
        /// </summary>
        [JsonPropertyName("max")]
        public float Maximum { get; set; }
    }
}