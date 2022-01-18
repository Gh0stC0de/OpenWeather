using System.Text.Json.Serialization;

namespace OpenWeather.Models
{
    /// <summary>
    ///     Minute forecast weather data.
    /// </summary>
    public class Minutely
    {
        [JsonConstructor]
        public Minutely(long dateTime, float precipitation)
        {
            DateTime = dateTime;
            Precipitation = precipitation;
        }

        /// <summary>
        ///     The date and time of the weather data in UNIX seconds (UTC).
        /// </summary>
        [JsonPropertyName("dt")]
        public long DateTime { get; set; }

        /// <summary>
        ///     Precipitation volume in mm.
        /// </summary>
        [JsonPropertyName("precipitation")]
        public float Precipitation { get; set; }
    }
}