using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace PulseXLibraries.Validations
{
    public class CollectionCountValidationRule<T> : IValidationRule<IEnumerable<T>>
    {
        public string ValidationMessage { get; set; }

        public ValidatableObject<IEnumerable<T>> Owner { get; set; }

        public int? MinCount { get; set; }

        public int? MaxCount { get; set; }

        public bool Validate(IEnumerable<T> value)
        {
            if (value == null)
            {
                return true;
            }

            var count = value.Count();

            if (MinCount.HasValue && count < MinCount.Value)
            {
                return false;
            }

            if (MaxCount.HasValue && count > MaxCount.Value)
            {
                return false;
            }

            return true;
        }
    }
}
