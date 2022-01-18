namespace OpenWeather
{
    /// <summary>
    ///     Extension methods for <see cref="Measurement"/>.
    /// </summary>
    public static class MeasurementExtensions
    {
        /// <summary>
        ///     Gets the internal value of a <see cref="Measurement"/>.
        /// </summary>
        /// <param name="measurement">The measurement.</param>
        /// <returns>The internal value.</returns>
        /// <exception cref="ArgumentOutOfRangeException">The internal value of the measuremt is not defined.</exception>
        public static string ToInternal(this Measurement measurement)
        {
            string internalValue = measurement switch
            {
                Measurement.Standard => "standard",
                Measurement.Metric => "metric",
                Measurement.Imperial => "imperial",
                _ => throw new ArgumentOutOfRangeException(nameof(measurement)),
            };
            return internalValue;
        }
    }
}