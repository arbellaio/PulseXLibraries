using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PulseXLibraries.Helpers.Navigation;
using PulseXLibraries.Helpers.SafeArea;
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
[assembly: ExportFont("Sen-Bold.ttf", Alias = "SenBold")]
[assembly: ExportFont("Sen-ExtraBold.ttf", Alias = "SenExtraBold")]
[assembly: ExportFont("Sen-Regular.ttf", Alias = "SenRegular")]
[assembly: ExportFont("Oxygen-Regular.ttf", Alias = "OxygenRegular")]
[assembly: ExportFont("Oxygen-Bold.ttf", Alias = "OxygenBold")]
[assembly: ExportFont("Oxygen-Light.ttf", Alias = "OxygenLight")]
[assembly: ExportFont("Montserrat-Bold.ttf", Alias = "MontserratBold")]
[assembly: ExportFont("Montserrat-SemiBold.ttf", Alias = "MontserratSemiBold")]
[assembly: ExportFont("Montserrat-Regular.ttf", Alias = "MontserratRegular")]
[assembly: ExportFont("Montserrat-Light.ttf", Alias = "MontserratLight")]
[assembly: ExportFont("PoppinsRegular.ttf", Alias = "PoppinsRegular")]
[assembly: ExportFont("PoppinsBold.ttf", Alias = "PoppinsBold")]
namespace PulseXLibraries.Views.BaseApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BaseApplication : Application
    {
        public static INavigationService Navigation { get; private set; }
        public static Thickness SafeArea { get; set; }
        public BaseApplication()
        {
            InitializeComponent();
        }

        public void Initialize()
        {
            try
            {
                
                Navigation = new NavigationService();
                
                ISafeAreaHelper safeAreaService = DependencyService.Get<ISafeAreaHelper>();
                SafeArea = safeAreaService.GetSafeArea();
            }
            catch (Exception ex)
            {
               SafeArea = new Thickness(0, 0, 0, 0.5);
            }
        }
    }
}