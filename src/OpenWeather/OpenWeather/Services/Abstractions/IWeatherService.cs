using OpenWeather.Responses;

namespace OpenWeather.Services.Abstractions
{
    /// <summary>
    ///     Represents a weather service.
    /// </summary>
    public interface IWeatherService
    {
        /// <summary>
        ///     Gets the current weather, minute forecast for 1 hour, hourly forecast for 48 hours,
        ///     daily forecast for 7 days and government weather alerts.
        /// </summary>
        /// <param name="latitude">The latitude of the weather data location.</param>
        /// <param name="longitude">The longitude of the weather data location.</param>
        /// <returns>
        ///     The current weather, minute forecast for 1 hour, hourly forecast for 48 hours,
        ///     daily forecast for 7 days and government weather alerts.
        /// </returns>
        /// <exception cref="Exceptions.ServiceException">An error occured during the API call.</exception>
        Task<OneCallResponse> GetOneCallResponse(double latitude, double longitude);
    }
}
