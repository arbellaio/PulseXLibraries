using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PulseXLibraries.Controls.NavigationDrawer
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NavigationShellDrawerContent : ContentView
    {
        
        /// <summary>
        /// Attached property for <seealso cref="ItemsSource" />
        /// </summary>
        public static readonly BindableProperty ItemsSourceProperty =
            BindableProperty.Create(nameof(ItemsSource), typeof(IEnumerable), typeof(NavigationShellDrawerContent), default(IEnumerable));

        /// <summary>
        /// Gets or sets ItemsSource
        /// </summary>
        public IEnumerable ItemsSource
        {
            get
            {
                return (IEnumerable)GetValue(ItemsSourceProperty);
            }
            set
            {
                SetValue(ItemsSourceProperty, value);
            }
        }
        
        
        public NavigationShellDrawerContent()
        {
            InitializeComponent();
        }
    }
}