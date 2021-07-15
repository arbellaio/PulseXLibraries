using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PulseXLibraries.Views.BaseMaster
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BaseMasterPage : FlyoutPage
    {
        
        public BaseMasterPage()
        {
            InitializeComponent();
        }


        public void ImageButton_OnClicked(object sender, EventArgs e)
        {
            this.IsPresented = !this.IsPresented;
        }
    }

   
}