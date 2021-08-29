using Xamarin.Forms;

namespace PulseXLibraries.Helpers.ImageEdit
{
    public class ImageEditor : Image
    {
        public static readonly BindableProperty LineColorProperty =
            BindableProperty.Create((ImageEditor w) => w.LineColor, Color.Default);

        public static readonly BindableProperty LineWidthProperty =
            BindableProperty.Create((ImageEditor w) => w.LineWidth, 1);

        public static readonly BindableProperty ImageProperty =
            BindableProperty.Create((ImageEditor w) => w.ImagePath, "");

        public static readonly BindableProperty ClearImagePathProperty =
            BindableProperty.Create((ImageEditor w) => w.ClearPath, false);

        public static readonly BindableProperty SavedImagePathProperty =
            BindableProperty.Create((ImageEditor w) => w.SavedImagePath, "");

        public static readonly BindableProperty SavedImage64byteProperty =
            BindableProperty.Create((ImageEditor w) => w.SavedImage64byte, "");

        public Color LineColor
        {
            get { return (Color)GetValue(LineColorProperty); }
            set { SetValue(LineColorProperty, value); }
        }


        public int LineWidth
        {
            get { return (int)GetValue(LineWidthProperty); }
            set { SetValue(LineWidthProperty, value); }
        }

        public string ImagePath
        {
            get { return (string)GetValue(ImageProperty); }
            set { SetValue(ImageProperty, value); }
        }

        public bool ClearPath
        {
            get { return (bool)GetValue(ClearImagePathProperty); }
            set { SetValue(ClearImagePathProperty, value); }
        }

        public string SavedImagePath
        {
            get { return (string)GetValue(SavedImagePathProperty); }
            set { SetValue(SavedImagePathProperty, value); }
        }

        public string SavedImage64byte
        {
            get { return (string)GetValue(SavedImage64byteProperty); }
            set { SetValue(SavedImage64byteProperty, value); }
        }
    }
}