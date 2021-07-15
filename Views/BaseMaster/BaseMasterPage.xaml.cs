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
        
        /// <summary>
        /// Attached property for <seealso cref="MasterImage" />
        /// </summary>
        public static readonly BindableProperty MasterImageProperty =
            BindableProperty.Create(nameof(MasterImage), typeof(ImageSource), typeof(BaseMasterPage), default(ImageSource), BindingMode.TwoWay);

        
        /// <summary>
        /// Gets or sets BackgroundImageProperty
        /// </summary>
        public ImageSource MasterImage
        {
            get
            {
                return (ImageSource)GetValue(MasterImageProperty);
            }

            set
            {
                SetValue(MasterImageProperty, value);
            }
        }


        public BaseMasterPage()
        {
            InitializeComponent();
        }


        private void ImageButton_OnClicked(object sender, EventArgs e)
        {
            this.IsPresented = !this.IsPresented;
        }
    }

   
}