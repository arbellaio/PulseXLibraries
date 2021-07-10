using System;
using System.Globalization;
using Xamarin.Forms;

namespace PulseXLibraries.ValueConverters.ImageSourceNotNull
{
    public class ImageSourceNotNullBoolConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if ((ImageSource)value == null)
                return false;

            return true;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
