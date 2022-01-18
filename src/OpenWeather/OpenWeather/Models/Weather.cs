using System.Text.Json.Serialization;

namespace OpenWeather.Models
{
    /// <summary>
    ///     Weather data.
    /// </summary>
    public class Weather
    {
        [JsonConstructor]
        public Weather(int id, string main, string description, string icon)
        {
            Id = id;
            Main = main;
            Description = description;
            Icon = icon;
        }

        /// <summary>
        ///     The Weather condition id.
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; set; }

        /// <summary>
        ///     The group of weather parameters.
        /// </summary>
        [JsonPropertyName("main")]
        public string Main { get; set; }

        /// <summary>
        ///     The weather condition within the group.
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        ///     The weather icon id.
        /// </summary>
        [JsonPropertyName("icon")]
        public string Icon { get; set; }
    }
}