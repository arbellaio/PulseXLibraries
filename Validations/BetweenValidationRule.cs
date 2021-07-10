using System;
using System.Collections.Generic;
using System.Text;

namespace PulseXLibraries.Validations
{
    public class BetweenValidationRule<T> : IValidationRule<T>
    {
        private readonly Comparer<T> _comparer;

        public BetweenValidationRule()
        {
            _comparer = Comparer<T>.Default;

            if (_comparer == null)
            {
                throw new InvalidOperationException($"There is no default comparer for type: {typeof(T).Name}");
            }
        }

        public string ValidationMessage { get; set; }

        public T Min { get; set; }

        public T Max { get; set; }

        public ValidatableObject<T> Owner { get; set; }

        public bool Validate(T value)
        {
            if (value == null || Min == null || Max == null)
            {
                return true;
            }

            // if min <= value <= max return true
            return Compare(value, Min) >= 0 && Compare(value, Max) <= 0;
        }

        private int Compare(T first, T second)
        {
            return _comparer.Compare(first, second);
        }
    }
}
