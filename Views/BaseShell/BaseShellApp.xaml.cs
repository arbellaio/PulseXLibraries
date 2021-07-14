using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PulseXLibraries.Views.BaseShell
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BaseShellApp : Shell
    {
        /// <summary>
        /// Attached property for <seealso cref="ShellHeaderText" />
        /// </summary>
        public static readonly BindableProperty ShellHeaderTextProperty =
            BindableProperty.Create(nameof(ShellHeaderText), typeof(string), typeof(BaseShellApp), default(string), BindingMode.TwoWay);
        public string ShellHeaderText
        {
            get => (string)GetValue(ShellHeaderTextProperty);
            set => SetValue(ShellHeaderTextProperty, value);
        }
        public BaseShellApp()
        {
            InitializeComponent();
        }
    }
}