namespace PulseXLibraries.Validations
{
    public class EmailValidationRule<T> : RegExValidationRule<T>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EmailValidationRule{T}"/> class.
        /// </summary>
        public EmailValidationRule()
            : base(@"^(?("")(""[^""]+?""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9]{2,17}))$")
        {
            ValidationMessage = string.Empty;
        }
    }
}
