using System;
using System.Collections.Generic;
using System.Text;

namespace PulseXLibraries.Validations
{
    public class CompareToValidationRule<T> : IValidationRule<T>
    {
        private readonly Comparer<T> _comparer;

        public CompareToValidationRule()
        {
            _comparer = Comparer<T>.Default;

            if (_comparer == null)
            {
                throw new InvalidOperationException($"There is no default comparer for type: {typeof(T).Name}");
            }
        }

        public string ValidationMessage { get; set; }

        public T ValueToCompare { get; set; }

        public Operation Operation { get; set; }

        public ValidatableObject<T> Owner { get; set; }

        public bool Validate(T value)
        {
            if (value == null || ValueToCompare == null)
            {
                return true;
            }

            switch (Operation)
            {
                case Operation.LessThan:
                    return Compare(value, ValueToCompare) < 0;
                case Operation.LessOrEqualThan:
                    return Compare(value, ValueToCompare) <= 0;
                case Operation.EqualThan:
                    return Compare(value, ValueToCompare) == 0;
                case Operation.MoreOrEqualThan:
                    return Compare(value, ValueToCompare) >= 0;
                case Operation.MoreThan:
                    return Compare(value, ValueToCompare) > 0;
                default:
                    return false;
            }
        }

        private int Compare(T first, T second)
        {
            return _comparer.Compare(first, second);
        }
    }

    public enum Operation
    {
        LessThan,
        LessOrEqualThan,
        EqualThan,
        MoreOrEqualThan,
        MoreThan
    }
}
