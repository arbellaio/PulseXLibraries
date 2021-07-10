using System;

namespace PulseXLibraries.Extension.Decimal
{
    public static class DecimalExtensions
    {   
        public static decimal? TwoDecimal(this decimal value)
        {
            var d = Math.Round((decimal)value, 2);
            var a = d.ToString("0.00");
            var c = Convert.ToDecimal(a);
            return c;
        }

        public static decimal? TwoDecimal(this decimal? value)
        {
            if(value == null)
            {
                return null;
            }

            var d = Math.Round((decimal)value, 2);
            var a = d.ToString("0.00");
            var c = Convert.ToDecimal(a);
            return c;
        }
    }
}