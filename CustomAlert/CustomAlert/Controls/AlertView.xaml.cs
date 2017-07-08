using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace CustomAlert.Controls
{
    public partial class AlertView : ContentView
    {
        public AlertView()
        {
            InitializeComponent();
        }

        #region Bindable Properties

        public static readonly BindableProperty AlertTitleProperty =
                               BindableProperty.Create("AlertTitle", typeof(string), typeof(AlertView), "", defaultBindingMode: BindingMode.TwoWay);

        public string AlertTitle
        {
            get { return (string)GetValue(AlertTitleProperty); }
            set { SetValue(AlertTitleProperty, value); }
        }

        public static readonly BindableProperty DescriptionProperty =
                       BindableProperty.Create("Description", typeof(string), typeof(AlertView), "", defaultBindingMode: BindingMode.TwoWay);

        public string Description
        {
            get { return (string)GetValue(DescriptionProperty); }
            set { SetValue(DescriptionProperty, value); }
        }

        public static readonly BindableProperty PositiveButtonTitleProperty =
                       BindableProperty.Create("PositiveButtonTitle", typeof(string), typeof(AlertView), "", defaultBindingMode: BindingMode.TwoWay);

        public string PositiveButtonTitle
        {
            get { return (string)GetValue(PositiveButtonTitleProperty); }
            set { SetValue(PositiveButtonTitleProperty, value); }
        }

        public static readonly BindableProperty NegativeButtonTitleProperty =
                       BindableProperty.Create("NegativeButtonTitle", typeof(string), typeof(AlertView), "", defaultBindingMode: BindingMode.TwoWay);

        public string NegativeButtonTitle
        {
            get { return (string)GetValue(NegativeButtonTitleProperty); }
            set { SetValue(NegativeButtonTitleProperty, value); }
        }

        public static readonly BindableProperty HeaderBackgroundColorProperty =
                       BindableProperty.Create("HeaderBackgroundColor", typeof(Color), typeof(AlertView), Color.FromHex("#2D9EE0"), defaultBindingMode: BindingMode.TwoWay);

        public Color HeaderBackgroundColor
        {
            get { return (Color)GetValue(HeaderBackgroundColorProperty); }
            set { SetValue(HeaderBackgroundColorProperty, value); }
        }

        public static readonly BindableProperty HasPositiveButtonProperty =
                       BindableProperty.Create("HasPositiveButton", typeof(bool), typeof(AlertView), false, defaultBindingMode:BindingMode.TwoWay, propertyChanged: (b, o, n) =>
                       {
                       });

        public bool HasPositiveButton
        {
            get { return (bool)GetValue(HasPositiveButtonProperty); }
            set { SetValue(HasPositiveButtonProperty, value); }
        }

        public static readonly BindableProperty AlertTypeProperty =
                       BindableProperty.Create("AlertType", typeof(AlertTypes), typeof(AlertView), AlertTypes.Info, defaultBindingMode: BindingMode.TwoWay, propertyChanged: OnAlertType);

        private static void OnAlertType(BindableObject bindable, object oldValue, object newValue)
        {
            var currentView = bindable as AlertView;
            AlertTypes type = (AlertTypes)newValue;
            string alertImageName = Constants.GetImage(type);

            if (currentView == null || string.IsNullOrEmpty(alertImageName))
                return;

            currentView.AlertImage = ImageSource.FromResource(alertImageName);
        }

        public AlertTypes AlertType
        {
            get { return (AlertTypes)GetValue(AlertTypeProperty); }
            set { SetValue(AlertTypeProperty, value); }
        }

        public static readonly BindableProperty AlertImageProperty =
                       BindableProperty.Create("AlertImage", typeof(ImageSource), typeof(AlertView), null);

        public ImageSource AlertImage
        {
            get { return (ImageSource)GetValue(AlertImageProperty); }
            set { SetValue(AlertImageProperty, value); }
        }

        public static readonly BindableProperty CommandParameterProperty =
                       BindableProperty.Create("CommandParameter", typeof(bool), typeof(AlertView), false);

        public bool CommandParameter
        {
            get { return (bool)GetValue(CommandParameterProperty); }
            set { SetValue(CommandParameterProperty, value); }
        }

        #endregion

        #region Bindable Commands

        public static readonly BindableProperty OnCommandProperty =
                       BindableProperty.Create("OnCommand", typeof(ICommand), typeof(AlertView), null, defaultBindingMode: BindingMode.TwoWay);

        public ICommand OnCommand
        {
            get { return (ICommand)GetValue(OnCommandProperty); }
            set { SetValue(OnCommandProperty, value); }
        }

        public Command<string> ButtonCommand
        {
            get
            {
                return new Command<string>(arg =>
                {
                    IsVisible = false;
                    if (OnCommand != null)
                        OnCommand.Execute(arg.Equals("yes", StringComparison.CurrentCultureIgnoreCase)); //True: If pressed 'Yes' Button.
                });
            }
        }


        #endregion

        protected override void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            base.OnPropertyChanged(propertyName);
            var d = Description;
        }

    }
}
