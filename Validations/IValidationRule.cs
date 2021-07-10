namespace PulseXLibraries.Validations
{
    public interface IValidationRule<T>
    {
        /// <summary>
        /// Gets or sets error message to be shown
        /// </summary>
        string ValidationMessage { get; set; }

        /// <summary>
        /// Gets or sets owner
        /// </summary>
        ValidatableObject<T> Owner { get; set; }

        /// <summary>
        /// Custom validation method
        /// </summary>
        /// <param name="value">Value to be validated</param>
        /// <returns>Value indicating if received parameter is valid or not</returns>
        bool Validate(T value);
    }
}
