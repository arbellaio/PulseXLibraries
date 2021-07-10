namespace PulseXLibraries.Validations
{
    /// <summary>
    /// Rule for validating required fields
    /// </summary>
    /// <typeparam name="T">Type of object value</typeparam>
    public class RequiredValidationRule<T> : IValidationRule<T>
    {
        /// <summary>
        /// Gets or sets validation message
        /// </summary>
        public string ValidationMessage { get; set; }

        /// <summary>
        /// Gets or sets Owner of Validation Rule
        /// </summary>
        public ValidatableObject<T> Owner { get; set; }

        /// <summary>
        /// Validates the received value
        /// </summary>
        /// <param name="value">Value to be validated</param>
        /// <returns>True if value is populated, otherwise false</returns>
        public bool Validate(T value)
        {
            return !string.IsNullOrWhiteSpace(value?.ToString());
        }
    }
}
