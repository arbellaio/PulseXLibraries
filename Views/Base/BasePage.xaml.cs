using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PulseXLibraries.ViewModels.Base;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PulseXLibraries.Views.Base
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BasePage : ContentPage
    {
        public BasePage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            if (this.BindingContext is BaseViewModel viewModel)
            {
                Device.BeginInvokeOnMainThread(async () =>
                {
                    await viewModel.OnAppearing();
                });
            }
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();

            if (this.BindingContext is BaseViewModel viewModel)
            {
                Device.BeginInvokeOnMainThread(async () =>
                {
                    await viewModel.OnDisappearing();
                });
            }
        }
    }
}