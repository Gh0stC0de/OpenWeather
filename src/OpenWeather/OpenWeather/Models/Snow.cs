using System.Text.Json.Serialization;

namespace OpenWeather.Models
{
    /// <summary>
    ///     Snow data.
    /// </summary>
    public class Snow
    {
        [JsonConstructor]
        public Snow(float lastHour)
        {
            LastHour = lastHour;
        }

        /// <summary>
        ///     (where available) Snow volume for last hour in mm.
        /// </summary>
        [JsonPropertyName("snow")]
        public float LastHour { get; set; }
    }
}