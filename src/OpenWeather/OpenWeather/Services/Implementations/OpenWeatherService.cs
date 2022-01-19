using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text.Json;
using OpenWeather.Responses;
using OpenWeather.Services.Abstractions;
using OpenWeather.Exceptions;

namespace OpenWeather.Services.Implementations
{
    /// <summary>
    ///     Represents an open weather weather service
    /// </summary>
    public class OpenWeatherService : IWeatherService
    {
        private readonly IWeatherSettings _settings;
        private readonly HttpClient _httpClient;

        public OpenWeatherService(IWeatherSettings settings)
        {
            _settings = settings;
            _httpClient = CreateHttpClient();
        }

        /// <inheritdoc/>
        public async Task<OneCallResponse> GetOneCallResponse(double latitude, double longitude)
        {
            string requestUri = $"onecall?lat={latitude}&lon={longitude}&{GetParametersFromSettings()}";           

            OneCallResponse? oneCallResponse;
            try
            {
                oneCallResponse = await _httpClient.GetFromJsonAsync<OneCallResponse>(requestUri);
            }
            catch (HttpRequestException ex)
            {
                throw new ServiceException("An error occured while executing the service request.", ex);
            }
            catch (NotSupportedException nse)
            {
                throw new ServiceException("The content type is not supported.", nse);
            }
            catch (JsonException je)
            {
                throw new ServiceException("The JSON response is invalid.", je);
            }

            if (oneCallResponse == null)
            {
                throw new Exception("The service result could not be deserialized.");
            }

            return oneCallResponse;
        }

        /// <summary>
        ///     Gets the API parameters as query string from the <see cref="IWeatherSettings"/>.
        /// </summary>
        /// <returns>The API parameters as query string.</returns>
        private string GetParametersFromSettings()
        {
            string parameters = $"lang={_settings.LanguageCode}&appid={_settings.OpenWeatherApiKey}";

            if (_settings.Measurement != Measurement.Standard)
            {
                string units = _settings.Measurement.ToInternal();
                parameters += $"&units={units}";
            }

            return parameters;
        }

        /// <summary>
        ///     Creates a http client for OpenWeather API requests.
        /// </summary>
        /// <returns>A http client for OpenWeather API requests.</returns>
        private static HttpClient CreateHttpClient()
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri("https://api.openweathermap.org/data/2.5/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));

            return client;
        }
    }
}