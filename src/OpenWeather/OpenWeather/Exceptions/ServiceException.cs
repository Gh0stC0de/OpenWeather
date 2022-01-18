namespace OpenWeather.Exceptions
{
    /// <summary>
    ///     Represents errors that occur during OpenWeather API calls.
    /// </summary>
    public class ServiceException : Exception
    {
        public ServiceException()
        {
        }

        public ServiceException(string? message, Exception? innerException) 
            : base(message, innerException)
        {
        }
    }
}
