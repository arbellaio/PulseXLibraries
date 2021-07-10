using System;
using System.Collections.Generic;
using System.Text;


namespace PulseXLibraries.Validations
{
    public class StringLengthValidationRule : IValidationRule<string>
    {
        public string ValidationMessage { get; set ; }

        public ValidatableObject<string> Owner { get ; set ; }

        public int? MinLength { get; set; }

        public int? MaxLength { get; set; }

        public bool Validate(string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                return true;
            }

            if (MinLength.HasValue && value.Length < MinLength.Value)
            {
                return false;
            }

            if (MaxLength.HasValue && value.Length > MaxLength.Value)
            {
                return false;
            }

            return true;
        }
    }
}
