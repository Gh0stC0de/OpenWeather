namespace OpenWeather
{
    /// <summary>
    ///     Represents the weather settings.
    /// </summary>
    public interface IWeatherSettings
    {
        /// <summary>
        ///     The open weather api key.
        /// </summary>
        public string OpenWeatherApiKey { get; }

        /// <summary>
        ///     The units of measurement.
        ///     Standard will be applied by default.
        /// </summary>
        public Measurement Measurement { get; }

        /// <summary>
        ///     The language code for the weather data.
        /// </summary>
        public string LanguageCode { get; }
    }
}