using System.Collections.Generic;
using System.Linq;


using PulseXLibraries.Helpers.Bindable;

namespace PulseXLibraries.Validations
{
    /// <summary>
    /// Class to be used when UI entry should be validated
    /// </summary>
    public class ValidatableObject<T> : BindableBase
    {
        protected readonly List<IValidationRule<T>> _validations;
        private List<string> _errors;
        private T _value;
        private bool _isValid;
        private bool _isDirty;

        /// <summary>
        /// Initializes a new instance of the <see cref="ValidatableObject{T}"/> class.
        ///
        /// </summary>
        public ValidatableObject()
        {
            _isValid = true;
            _errors = new List<string>();
            _validations = new List<IValidationRule<T>>();
        }

        public List<IValidationRule<T>> Validations => _validations;

        /// <summary>
        /// Add rule method
        /// </summary>
        /// <param name="rule">Validation rule</param>
        public void AddRule(IValidationRule<T> rule)
        {
            rule.Owner = this;
            _validations.Add(rule);
        }

        /// <summary>
        /// Remove rule method
        /// </summary>
        /// <param name="rule">Validation rule</param>
        public void RemoveRule(IValidationRule<T> rule)
        {
            _validations.Remove(rule);
        }

        /// <summary>
        /// Gets or sets list of errors for object 
        /// </summary>
        public List<string> Errors
        {
            get
            {
                return _errors;
            }

            set
            {
                SetProperty(ref _errors, value);
            }
        }

        /// <summary>
        /// Gets or sets object value
        /// </summary>
        public virtual T Value
        {
            get
            {
                return _value;
            }

            set
            {
                if (SetProperty(ref _value, value))
                {
                    Validate();
                }
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether object value is valid or not
        /// </summary>
        public bool IsValid
        {
            get
            {
                return _isValid;
            }

            set
            {
                SetProperty(ref _isValid, value);
            }
        }

        /// <summary>
        /// Is dirty property
        /// </summary>
        public bool IsDirty
        {
            get
            {
                return _isDirty;
            }

            set
            {
                if (SetProperty(ref _isDirty, value))
                {
                    Validate();
                }
            }
        }

        /// <summary>
        /// Validate method
        /// </summary>
        /// <returns>Is input valid or not</returns>
        public virtual bool Validate()
        {
            Errors.Clear();
            var errors = _validations.Where(x => !x.Validate(Value)).Select(x => x?.ValidationMessage);

            Errors = errors?.ToList();
            IsValid = !Errors.Any();
            if (!IsValid)
            {
                IsDirty = true;
            }

            return IsValid;
        }
    }
}
