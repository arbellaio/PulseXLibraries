using System;
using System.Windows.Input;
using PulseXLibraries.Helpers.CommandLocker;
using PulseXLibraries.ValueConverters;
using PulseXLibraries.ViewModels.Base;
using Rg.Plugins.Popup.Pages;
using Rg.Plugins.Popup.Services;
using Xamarin.Forms;

namespace PulseXLibraries.Views.BasePopup
{
    public class PopupBase : PopupPage
    {
        public BaseViewModel ViewModel => BindingContext as BaseViewModel;

        public static readonly BindableProperty ShowSaveButtonProperty =
            BindableProperty.Create("ShowSaveButton", typeof(bool), typeof(PopupBase), false);


        public static readonly BindableProperty SaveButtonTextProperty =
            BindableProperty.Create("SaveButtonText", typeof(string), typeof(PopupBase), "Done");

        public static readonly BindableProperty SaveButtonTextColorProperty =
            BindableProperty.Create("SaveButtonTextColor", typeof(Color), typeof(PopupBase), Color.Default);

        public static readonly BindableProperty ShowCancelButtonProperty =
            BindableProperty.Create("ShowCancelButton", typeof(bool), typeof(PopupBase), true);

        public static readonly BindableProperty DisableCancelPopProperty =
            BindableProperty.Create("DisableCancelPopProperty", typeof(bool), typeof(PopupBase), false);

        public static readonly BindableProperty CancelButtonTextProperty =
            BindableProperty.Create("CancelButtonText", typeof(string), typeof(PopupBase),"Cancel");

        public static readonly BindableProperty CancelButtonTextColorProperty =
            BindableProperty.Create("CancelButtonTextColor", typeof(Color), typeof(PopupBase), Color.Default);

        public static readonly BindableProperty ShowHeaderProperty =
            BindableProperty.Create("ShowHeader", typeof(bool), typeof(PopupBase), true);

        public static readonly BindableProperty SaveButtonEnabledProperty =
            BindableProperty.Create("SaveButtonEnabled", typeof(bool), typeof(PopupBase), true);


        public PopupBase()
        {
            ControlTemplate template = new ControlTemplate(typeof(PopupTemplate));
            HasSystemPadding = false;
            this.ControlTemplate = template;
        }

        protected override bool OnBackgroundClicked()
        {
            return false;
        }

        public bool ShowHeader
        {
            get { return (bool)GetValue(ShowHeaderProperty); }
            set { SetValue(ShowHeaderProperty, value); }
        }

        public bool ShowSaveButton
        {
            get { return (bool)GetValue(ShowSaveButtonProperty); }
            set { SetValue(ShowSaveButtonProperty, value); }
        }

        public string SaveButtonText
        {
            get { return (string)GetValue(SaveButtonTextProperty); }
            set { SetValue(SaveButtonTextProperty, value); }
        }

        public Color SaveButtonTextColor
        {
            get { return (Color)GetValue(SaveButtonTextColorProperty); }
            set { SetValue(SaveButtonTextColorProperty, value); }
        }

        #region SaveCommand

        public static BindableProperty SaveCommandProperty =
            BindableProperty.Create("SaveCommand", typeof(ICommand), typeof(PopupBase), null);

        public ICommand SaveCommand
        {
            get => (ICommand)this.GetValue(SaveCommandProperty);
            set { SetValue(SaveCommandProperty, value); }
        }

        #endregion SaveCommand

        #region CancelCommand

        public static BindableProperty CancelCommandProperty =
            BindableProperty.Create("CancelCommand", typeof(ICommand), typeof(PopupBase), null);

        public ICommand CancelCommand
        {
            get => (ICommand)this.GetValue(CancelCommandProperty);
            set { SetValue(CancelCommandProperty, value); }
        }

        #endregion CancelCommand


        public bool ShowCancelButton
        {
            get { return (bool)GetValue(ShowCancelButtonProperty); }
            set { SetValue(ShowCancelButtonProperty, value); }
        }

        public bool DisableCancelPop
        {
            get { return (bool)GetValue(DisableCancelPopProperty); }
            set { SetValue(DisableCancelPopProperty, value); }
        }

        public string CancelButtonText
        {
            get { return (string)GetValue(CancelButtonTextProperty); }
            set { SetValue(CancelButtonTextProperty, value); }
        }


        public Color CancelButtonTextColor
        {
            get { return (Color)GetValue(CancelButtonTextColorProperty); }
            set { SetValue(CancelButtonTextColorProperty, value); }
        }

        public bool SaveButtonEnabled
        {
            get { return (bool)GetValue(SaveButtonEnabledProperty); }
            set { SetValue(SaveButtonEnabledProperty, value); }
        }

        public Action OnSaveClicked { get; set; }


        public Action OnCancelClicked { get; set; }

        public virtual void Initialize()
        {
        }
    }


    public class PopupTemplate : ContentView
    {
        StackLayout stack;

        public ICommand SaveCommand => new Command(SaveCommandLocker.Execute);

        protected CommandLockerHelper SaveCommandLocker =>
            new CommandLockerHelper(async (e) => { SaveButtonClicked(e); });

        public ICommand CancelCommand => new Command(CancelCommandLocker.Execute);

        protected CommandLockerHelper CancelCommandLocker =>
            new CommandLockerHelper(async (e) => { CancelButtonClicked(e); });


        public PopupTemplate()
        {
            SetPopupLayout();
            SetMainStack();
            AddContent();
        }

        void SetPopupLayout()
        {
            VerticalOptions = LayoutOptions.CenterAndExpand;
            HorizontalOptions = LayoutOptions.CenterAndExpand;
        }

        void SetMainStack()
        {
            stack = new StackLayout()
            {
                Spacing = 0,
                VerticalOptions = LayoutOptions.CenterAndExpand,
                BackgroundColor = Color.White,
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                WidthRequest = BaseApp.BaseApp.ScreenHeight,
                HeightRequest = BaseApp.BaseApp.ScreenWidth
            };

            WidthRequest = BaseApp.BaseApp.ScreenHeight;
            HeightRequest = BaseApp.BaseApp.ScreenHeight;
        }

        void AddContent()
        {
            Button cancelButton = new Button
            {
                Text = "Cancel", BackgroundColor = Color.Transparent, VerticalOptions = LayoutOptions.Center
            };
            cancelButton.SetBinding(IsVisibleProperty, new TemplateBinding("ShowCancelButton"));
            cancelButton.SetBinding(Button.TextProperty, new TemplateBinding("CancelButtonText"));
            cancelButton.SetBinding(Button.TextColorProperty, new TemplateBinding("CancelButtonTextColor"));

            Button saveButton = new Button
                { Text = "Done", BackgroundColor = Color.Transparent, VerticalOptions = LayoutOptions.Center };
            saveButton.SetBinding(IsVisibleProperty, new TemplateBinding("ShowSaveButton"));
            saveButton.SetBinding(Button.TextProperty, new TemplateBinding("SaveButtonText"));
            saveButton.SetBinding(Button.TextColorProperty, new TemplateBinding("SaveButtonTextColor"));
            saveButton.SetBinding(Button.IsEnabledProperty, new TemplateBinding("SaveButtonEnabled"));

            Button rightButton = new Button
                { Text = "       ", BackgroundColor = Color.Transparent, VerticalOptions = LayoutOptions.Center };
            rightButton.SetBinding(IsVisibleProperty,
                new TemplateBinding("ShowSaveButton") { Converter = new InverseBoolConverter() });

            Label titleLabel = new Label()
            {
                Margin = 10,
                HorizontalTextAlignment = TextAlignment.Center,
                VerticalTextAlignment = TextAlignment.End,
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                VerticalOptions = LayoutOptions.Center,
            };
            titleLabel.SetBinding(Label.TextProperty, new TemplateBinding("Title"));

            StackLayout horizontalStack = new StackLayout()
            {
                Orientation = StackOrientation.Horizontal,
                Padding = new Thickness(0, 2, 0, 0),
                BackgroundColor = Color.FromHex("#f7f7f7")
            };
            horizontalStack.SetBinding(IsVisibleProperty, new TemplateBinding("ShowHeader"));
            horizontalStack.Children.Add(cancelButton);
            horizontalStack.Children.Add(titleLabel);
            horizontalStack.Children.Add(saveButton);
            horizontalStack.Children.Add(rightButton);

            saveButton.Command = SaveCommand;
            saveButton.CommandParameter = saveButton;

            cancelButton.Command = CancelCommand;
            cancelButton.CommandParameter = cancelButton;

            var contentPresenter = new ContentPresenter() { VerticalOptions = LayoutOptions.FillAndExpand };
            stack.Children.Add(horizontalStack);
            stack.Children.Add(contentPresenter);
            this.Content = stack;
        }

        private static void SaveButtonClicked(object sender)
        {
            try
            {
                var popup = (PopupBase)(((Button)sender).Parent.Parent.Parent.Parent);
                if (popup != null)
                {
                    popup.OnSaveClicked?.Invoke();
                    popup.SaveCommand?.Execute(null);
                }
            }
            catch
            {
            }
        }

        private static void CancelButtonClicked(object sender)
        {
            try
            {
                var popup = (PopupBase)(((Button)sender).Parent.Parent.Parent.Parent);
                if (popup == null)
                    PopupNavigation.Instance.PopAsync();
                else
                {
                    if (!popup.DisableCancelPop)
                        PopupNavigation.Instance.PopAsync();
                    popup.OnCancelClicked?.Invoke();
                    popup.CancelCommand?.Execute(null);
                }
            }
            catch
            {
            }
        }
    }
}