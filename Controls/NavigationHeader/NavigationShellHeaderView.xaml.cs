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
        /// Attached property for <seealso cref="UserImage" />
        /// </summary>
        public static readonly BindableProperty UserImageProperty =
            BindableProperty.Create(nameof(UserImage), typeof(ImageSource), typeof(NavigationShellHeaderView), default(ImageSource), BindingMode.TwoWay);

        
        /// <summary>
        /// Gets or sets BackgroundImageProperty
        /// </summary>
        public ImageSource UserImage
        {
            get
            {
                return (ImageSource)GetValue(UserImageProperty);
            }

            set
            {
                SetValue(UserImageProperty, value);
            }
        }
        
        
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
        /// Attached property for <seealso cref="HeaderTextColor" />
        /// </summary>
        public static readonly BindableProperty HeaderTextColorProperty =
            BindableProperty.Create(nameof(HeaderTextColor), typeof(Color), typeof(NavigationShellHeaderView), default(Color), BindingMode.TwoWay);
        
        public Color HeaderTextColor
        {
            get
            {
                return (Color)GetValue(HeaderTextColorProperty);
            }

            set
            {
                SetValue(HeaderTextColorProperty, value);
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
        
        /// <summary>
        /// Attached property for <seealso cref="HeaderTextVertical" />
        /// </summary>
        public static readonly BindableProperty HeaderTextVerticalProperty =
            BindableProperty.Create(nameof(HeaderTextVertical), typeof(TextAlignment), typeof(NavigationShellHeaderView), default(TextAlignment), BindingMode.TwoWay);

        public TextAlignment HeaderTextVertical
        {
            get
            {
                return (TextAlignment)GetValue(HeaderTextVerticalProperty);
            }

            set
            {
                SetValue(HeaderTextVerticalProperty, value);
            }
        }

        
        /// <summary>
        /// Attached property for <seealso cref="HeaderTextHorizontal" />
        /// </summary>
        public static readonly BindableProperty HeaderTextHorizontalProperty =
            BindableProperty.Create(nameof(HeaderTextHorizontal), typeof(TextAlignment), typeof(NavigationShellHeaderView), default(TextAlignment), BindingMode.TwoWay);

        public TextAlignment HeaderTextHorizontal
        {
            get
            {
                return (TextAlignment)GetValue(HeaderTextVerticalProperty);
            }

            set
            {
                SetValue(HeaderTextVerticalProperty, value);
            }
        }
        
        
        /// <summary>
        /// Attached property for <seealso cref="DescriptionTextColor" />
        /// </summary>
        public static readonly BindableProperty HeaderTextSizeProperty =
            BindableProperty.Create(nameof(HeaderTextSize), typeof(double), typeof(NavigationShellHeaderView), 12.0, BindingMode.TwoWay);
        
        public double HeaderTextSize
        {
            get
            {
                return (double)GetValue(HeaderTextSizeProperty);
            }

            set
            {
                SetValue(HeaderTextSizeProperty, value);
            }
        }
        
        /// <summary>
        /// Attached property for <seealso cref="HeaderTextFont" />
        /// </summary>
        public static readonly BindableProperty HeaderTextFontProperty =
            BindableProperty.Create(nameof(HeaderTextFont), typeof(string), typeof(NavigationShellHeaderView), default(string), BindingMode.TwoWay);

        public string HeaderTextFont
        {
            get
            {
                return (string)GetValue(HeaderTextFontProperty);
            }

            set
            {
                SetValue(HeaderTextFontProperty, value);
            }
        }
        
        /// <summary>
        /// Attached property for <seealso cref="DescriptionTextFont" />
        /// </summary>
        public static readonly BindableProperty DescriptionTextFontProperty =
            BindableProperty.Create(nameof(DescriptionTextFont), typeof(string), typeof(NavigationShellHeaderView), default(string), BindingMode.TwoWay);

        public string DescriptionTextFont
        {
            get
            {
                return (string)GetValue(DescriptionTextFontProperty);
            }

            set
            {
                SetValue(DescriptionTextFontProperty, value);
            }
        }
        
        /// <summary>
        /// Attached property for <seealso cref="DescriptionTextVertical" />
        /// </summary>
        public static readonly BindableProperty DescriptionTextVerticalProperty =
            BindableProperty.Create(nameof(DescriptionTextVertical), typeof(TextAlignment), typeof(NavigationShellHeaderView), default(TextAlignment), BindingMode.TwoWay);

        public TextAlignment DescriptionTextVertical
        {
            get
            {
                return (TextAlignment)GetValue(DescriptionTextVerticalProperty);
            }

            set
            {
                SetValue(DescriptionTextVerticalProperty, value);
            }
        }

        
        /// <summary>
        /// Attached property for <seealso cref="DescriptionTextHorizontal" />
        /// </summary>
        public static readonly BindableProperty DescriptionTextHorizontalProperty =
            BindableProperty.Create(nameof(DescriptionTextHorizontal), typeof(TextAlignment), typeof(NavigationShellHeaderView), default(TextAlignment), BindingMode.TwoWay);

        public TextAlignment DescriptionTextHorizontal
        {
            get
            {
                return (TextAlignment)GetValue(DescriptionTextHorizontalProperty);
            }

            set
            {
                SetValue(DescriptionTextHorizontalProperty, value);
            }
        }


        /// <summary>
        /// Attached property for <seealso cref="DescriptionTextColor" />
        /// </summary>
        public static readonly BindableProperty DescriptionTextColorProperty =
            BindableProperty.Create(nameof(DescriptionTextColor), typeof(Color), typeof(NavigationShellHeaderView), default(Color), BindingMode.TwoWay);
        
        public Color DescriptionTextColor
        {
            get
            {
                return (Color)GetValue(DescriptionTextColorProperty);
            }

            set
            {
                SetValue(DescriptionTextColorProperty, value);
            }
        }
        
        /// <summary>
        /// Attached property for <seealso cref="DescriptionTextColor" />
        /// </summary>
        public static readonly BindableProperty DescriptionTextSizeProperty =
            BindableProperty.Create(nameof(DescriptionTextSize), typeof(double), typeof(NavigationShellHeaderView), 12.0, BindingMode.TwoWay);
        
        public double DescriptionTextSize
        {
            get
            {
                return (double)GetValue(DescriptionTextSizeProperty);
            }

            set
            {
                SetValue(DescriptionTextSizeProperty, value);
            }
        }
        public NavigationShellHeaderView()
        {
            InitializeComponent();
        }
    }
}