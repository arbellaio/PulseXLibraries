using System.Text.RegularExpressions;

namespace PulseXLibraries.Validations
{
    public class RegExValidationRule<T> : IValidationRule<T>
    {
        private readonly string _regularExpresion = string.Empty;

        /// <summary>
        /// Initializes a new instance of the <see cref="RegExValidationRule{T}"/> class.
        ///
        /// </summary>
        /// <param name="regularExpression">RegularExpression value</param>
        public RegExValidationRule(string regularExpression)
        {
            _regularExpresion = regularExpression;
        }

        /// <summary>
        /// Gets or sets ValidationMessage
        /// </summary>
        public string ValidationMessage { get; set; }

        /// <summary>
        /// Gets or sets Owner
        /// </summary>
        public ValidatableObject<T> Owner { get; set; }

        public bool Validate(T value)
        {
            if (string.IsNullOrEmpty(value?.ToString()))
            {
                return true;
            }

            return Regex.IsMatch(value as string, _regularExpresion, RegexOptions.IgnoreCase);
        }
    }
}
