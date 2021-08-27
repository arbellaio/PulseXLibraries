using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AppCenter.Analytics;
using PulseXLibraries.Controls.SketchControl;
using PulseXLibraries.Views.Base;
using PulseXLibraries.Views.BasePopup;
using Rg.Plugins.Popup.Pages;
using Rg.Plugins.Popup.Services;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PulseXLibraries.Controls.Signature
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SignaturePadView : ContentView
    {
        
        public Action<byte[]> SignatureDone;
        public SignaturePadView()
        {
            InitializeComponent();
            SketchPad.ImageCaptured += SignaturePad_ImageCaptured;
        }

        void ClearPad(object sender, System.EventArgs e)
        {
            SketchPad.Clear();
        }

        async void SignaturePad_ImageCaptured(byte[] ImgBytes)
        {
            try
            {
                SketchPad.CaptureImage();
                SignatureDone?.Invoke(ImgBytes);
                await PopupNavigation.Instance.PopAsync();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            
        }
    }
}