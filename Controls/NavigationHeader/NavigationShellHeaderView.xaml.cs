using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PulseXLibraries.Controls.NavigationHeader
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NavigationShellHeaderView : ContentView
    {
        
        /// <summary>
        /// Attached property for <seealso cref="BackgroundImage" />
        /// </summary>
        public static readonly BindableProperty BackgroundImageProperty =
            BindableProperty.Create(nameof(BackgroundImage), typeof(ImageSource), typeof(NavigationShellHeaderView), default(ImageSource), BindingMode.TwoWay);

        
        /// <summary>
        /// Gets or sets BackgroundImageProperty
        /// </summary>
        public ImageSource BackgroundImage
        {
            get
            {
                return (ImageSource)GetValue(BackgroundImageProperty);
            }

            set
            {
                SetValue(BackgroundImageProperty, value);
            }
        }
        
        /// <summary>
        /// Attached property for <seealso cref="HeaderText" />
        /// </summary>
        public static readonly BindableProperty HeaderTextProperty =
            BindableProperty.Create(nameof(HeaderText), typeof(string), typeof(NavigationShellHeaderView), default(string), BindingMode.TwoWay);
        
        public string HeaderText
        {
            get
            {
                return (string)GetValue(HeaderTextProperty);
            }

            set
            {
                SetValue(HeaderTextProperty, value);
            }
        }
        
        /// <summary>
        /// Attached property for <seealso cref="DescriptionText" />
        /// </summary>
        public static readonly BindableProperty DescriptionTextProperty =
            BindableProperty.Create(nameof(DescriptionText), typeof(string), typeof(NavigationShellHeaderView), default(string), BindingMode.TwoWay);

        public string DescriptionText
        {
            get
            {
                return (string)GetValue(DescriptionTextProperty);
            }

            set
            {
                SetValue(DescriptionTextProperty, value);
            }
        }

        public NavigationShellHeaderView()
        {
            InitializeComponent();
        }
    }
}