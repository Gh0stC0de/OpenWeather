using System.Text.Json.Serialization;

namespace OpenWeather.Models
{
    /// <summary>
    ///     National weather alerts data from major national weather warning systems.
    /// </summary>
    public class Alert
    {
        [JsonConstructor]
        public Alert(string senderName, string @event, long start, long end,
            string description, string[] tags)
        {
            SenderName = senderName;
            Event = @event;
            Start = start;
            End = end;
            Description = description;
            Tags = tags;
        }

        /// <summary>
        ///     Name of the alert source.
        /// </summary>
        [JsonPropertyName("sender_name")]
        public string SenderName { get; set; }

        /// <summary>
        ///     Alert event name.
        /// </summary>
        [JsonPropertyName("event")]
        public string Event { get; set; }

        /// <summary>
        ///     Date and time of the start of the alert, Unix, UTC.
        /// </summary>
        [JsonPropertyName("start")]
        public long Start { get; set; }

        /// <summary>
        ///     Date and time of the end of the alert, Unix, UTC.
        /// </summary>
        [JsonPropertyName("end")]
        public long End { get; set; }

        /// <summary>
        ///     Description of the alert.
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        ///     Type of severe weather.
        /// </summary>
        [JsonPropertyName("tags")]
        public string[] Tags { get; set; }
    }
}