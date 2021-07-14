using Xamarin.Forms;

namespace PulseXLibraries.Models.NavigationDrawerModel
{
    public class NavigationDrawerItemModel
    {
        public string ItemName { get; set; }
        public string ItemFontFamily { get; set; }
        public Color ItemTextColor { get; set; }
        public double ItemFontSize { get; set; }
        public FontImageSource FontImageSource { get; set; }
    }
}