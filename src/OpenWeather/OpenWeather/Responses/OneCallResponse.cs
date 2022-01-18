using OpenWeather.Models;
using System.Text.Json.Serialization;

namespace OpenWeather.Responses
{
    /// <summary>
    ///     A one call response.
    /// </summary>
    public class OneCallResponse
    {
        [JsonConstructor]
        public OneCallResponse(double latitude, double longitude, string timezone,
            double timezoneOffset, Current currentWeather, Minutely[] minutely,
            Hourly[] hourly, Daily[] dailyWeather, Alert[]? alerts = null)
        {
            Latitude = latitude;
            Longitude = longitude;
            Timezone = timezone;
            TimezoneOffset = timezoneOffset;
            CurrentWeather = currentWeather;
            Minutely = minutely;
            Hourly = hourly;
            DailyWeather = dailyWeather;
            Alerts = alerts ?? Array.Empty<Alert>();
        }

        /// <summary>
        ///     The latitude of the weather data location.
        /// </summary>
        [JsonPropertyName("lat")]
        public double Latitude { get; set; }

        /// <summary>
        ///     The longitude of the weather data location.
        /// </summary>
        [JsonPropertyName("lon")]
        public double Longitude { get; set; }

        /// <summary>
        ///     The timezone of the weather data location.
        /// </summary>
        [JsonPropertyName("timezone")]
        public string Timezone { get; set; }

        /// <summary>
        ///     The time zone offset of the weather data location.
        /// </summary>
        [JsonPropertyName("timezone_offset")]
        public double TimezoneOffset { get; set; }

        /// <summary>
        ///     The current weather.
        /// </summary>
        [JsonPropertyName("current")]
        public Current CurrentWeather { get; set; }

        /// <summary>
        ///     The minute forecast weather data.
        /// </summary>
        [JsonPropertyName("minutely")]
        public Minutely[] Minutely { get; set; }

        /// <summary>
        ///     The hourly forecast weather data.
        /// </summary>
        [JsonPropertyName("hourly")]
        public Hourly[] Hourly { get; set; }

        /// <summary>
        ///     The daily weather of today and the next 7 days.
        /// </summary>
        [JsonPropertyName("daily")]
        public Daily[] DailyWeather { get; set; }

        /// <summary>
        ///     National weather alerts.
        /// </summary>
        [JsonPropertyName("alerts")]
        public Alert[] Alerts { get; set; }
    }
}