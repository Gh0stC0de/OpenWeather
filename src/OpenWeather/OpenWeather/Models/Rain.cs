using System.Text.Json.Serialization;

namespace OpenWeather.Models
{
    /// <summary>
    ///     Rain data.
    /// </summary>
    public class Rain
    {
        [JsonConstructor]
        public Rain(float lastHour)
        {
            LastHour = lastHour;
        }

        /// <summary>
        ///     (where available) Rain volume for last hour in mm.
        /// </summary>
        [JsonPropertyName("1h")]
        public float LastHour { get; set; }
    }
}