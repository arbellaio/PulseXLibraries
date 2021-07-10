using System.Threading.Tasks;
using Xamarin.Forms;

namespace PulseXLibraries.Helpers.Alert
{
    public class AlertHelper
    {
        public static async Task<bool> ShowAlertResponse(string title, string message, string cancel = "Cancel", string ok = "Ok")
        {
            var isCancelled = await Application.Current.MainPage.DisplayAlert(title, message, ok, cancel);
            return isCancelled;
        }

        public static async Task ShowAlert(string title, string message, string ok = "Ok")
        {
            await Application.Current.MainPage.DisplayAlert(title, message, ok);
        }
    }
}