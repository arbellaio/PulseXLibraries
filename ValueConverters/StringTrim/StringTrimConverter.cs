using System;
using System.Globalization;
using Xamarin.Forms;

namespace PulseXLibraries.ValueConverters.StringTrim
{
    public class StringTrimConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value != null)
            {
                var valueString = (string) value;
                if (!string.IsNullOrEmpty(valueString))
                {
                    return valueString.Trim();
                }
            }

            return null;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}