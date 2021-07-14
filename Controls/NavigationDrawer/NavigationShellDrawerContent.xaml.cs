using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PulseXLibraries.Models.NavigationDrawerModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PulseXLibraries.Controls.NavigationDrawer
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NavigationShellDrawerContent : ContentView
    {
        
        
        /// <summary>
        /// Attached property for <seealso cref="ShellDataTemplate" />
        /// </summary>
        public static readonly BindableProperty ShellDataTemplateProperty =
            BindableProperty.Create(nameof(DataTemplate), typeof(DataTemplate), typeof(NavigationShellDrawerContent), default(DataTemplate));

        /// <summary>
        /// Gets or sets ShellDataTemplate
        /// </summary>
        public DataTemplate ShellDataTemplate
        {
            get
            {
                return (DataTemplate)GetValue(ShellDataTemplateProperty);
            }
            set
            {
                SetValue(ShellDataTemplateProperty, value);
            }
        }
        
        /// <summary>
        /// Attached property for <seealso cref="FontImageItem" />
        /// </summary>
        public static readonly BindableProperty FontImageItemProperty =
            BindableProperty.Create(nameof(FontImageSource), typeof(FontImageSource), typeof(NavigationShellDrawerContent), default(IEnumerable<NavigationDrawerItemModel>));

        /// <summary>
        /// Gets or sets ItemsSource
        /// </summary>
        public FontImageSource FontImageItem
        {
            get
            {
                return (FontImageSource)GetValue(FontImageItemProperty);
            }
            set
            {
                SetValue(FontImageItemProperty, value);
            }
        }
        
        
        /// <summary>
        /// Attached property for <seealso cref="ItemFontFamily" />
        /// </summary>
        public static readonly BindableProperty ItemFontFamilyProperty =
            BindableProperty.Create(nameof(ItemFontFamily), typeof(string), typeof(NavigationShellDrawerContent), default(string));

        /// <summary>
        /// Gets or sets ItemFontFamily
        /// </summary>
        public string ItemFontFamily
        {
            get
            {
                return (string)GetValue(ItemFontFamilyProperty);
            }
            set
            {
                SetValue(ItemFontFamilyProperty, value);
            }
        }
        
        
        /// <summary>
        /// Attached property for <seealso cref="ItemText" />
        /// </summary>
        public static readonly BindableProperty ItemTextProperty =
            BindableProperty.Create(nameof(ItemText), typeof(string), typeof(NavigationShellDrawerContent), default(string));

        /// <summary>
        /// Gets or sets ItemsSource
        /// </summary>
        public string ItemText
        {
            get
            {
                return (string)GetValue(FontImageItemProperty);
            }
            set
            {
                SetValue(FontImageItemProperty, value);
            }
        }
        
        
        /// <summary>
        /// Attached property for <seealso cref="ItemTextColor" />
        /// </summary>
        public static readonly BindableProperty ItemTextColorProperty =
            BindableProperty.Create(nameof(ItemTextColor), typeof(Color), typeof(NavigationShellDrawerContent), Color.Gray);

        /// <summary>
        /// Gets or sets ItemsSource
        /// </summary>
        public Color ItemTextColor
        {
            get
            {
                return (Color)GetValue(ItemTextColorProperty);
            }
            set
            {
                SetValue(ItemFontSizeProperty, value);
            }
        }
        
        
        /// <summary>
        /// Attached property for <seealso cref="ItemFontSize" />
        /// </summary>
        public static readonly BindableProperty ItemFontSizeProperty =
            BindableProperty.Create(nameof(ItemFontSize), typeof(double), typeof(NavigationShellDrawerContent), 12.0);

        /// <summary>
        /// Gets or sets ItemsSource
        /// </summary>
        public double ItemFontSize
        {
            get
            {
                return (double)GetValue(ItemFontSizeProperty);
            }
            set
            {
                SetValue(ItemFontSizeProperty, value);
            }
        }
        
        public NavigationShellDrawerContent()
        {
            InitializeComponent();
        }
    }
}