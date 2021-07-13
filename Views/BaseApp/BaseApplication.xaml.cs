using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: ExportFont("FontAwesome5Brands.otf", Alias = "FontAwesomeBrands")]
[assembly: ExportFont("FontAwesome5Light.otf", Alias = "FontAwesomeLight")]
[assembly: ExportFont("FontAwesome5Regular.otf", Alias = "FontAwesomeRegular")]
[assembly: ExportFont("FontAwesome5Solid.otf", Alias = "FontAwesomeSolid")]
[assembly: ExportFont("Roboto-Regular.ttf", Alias = "RobotoRegular")]
[assembly: ExportFont("Roboto-Medium.ttf", Alias = "RobotoMedium")]
[assembly: ExportFont("Roboto-Light.ttf", Alias = "RobotoLight")]
[assembly: ExportFont("Roboto-Bold.ttf", Alias = "RobotoBold")]
[assembly: ExportFont("Roboto-Black.ttf", Alias = "RobotoBlack")]
namespace PulseXLibraries.Views.BaseApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BaseApplication : Application
    {
        public BaseApplication()
        {
            InitializeComponent();
        }
    }
}