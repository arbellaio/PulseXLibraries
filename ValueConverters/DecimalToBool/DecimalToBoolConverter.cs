using System;
using System.Globalization;
using Xamarin.Forms;

namespace PulseXLibraries.ValueConverters.DecimalToBool
{
    public class DecimalToBoolConverter : IValueConverter  
    {  
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)  
        {  
            return (decimal)value != 0;  
        }  
  
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)  
        {  
            return (bool)value ? 1 : 0;  
        }  
  
    }  
}