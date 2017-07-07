using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace CustomAlert.Controls
{
    public partial class AlertView : ContentView
    {
        public AlertView()
        {
            InitializeComponent();
        }

        #region Properties

        public static readonly BindableProperty TitleProperty =
                               BindableProperty.Create("Title", typeof(string), typeof(AlertView), null);

        public string Title
        {
            get { return (string)GetValue(TitleProperty); }
            set { SetValue(TitleProperty, value); }
        }

        public static readonly BindableProperty DescriptionProperty =
                       BindableProperty.Create("Description", typeof(string), typeof(AlertView), null);

        public string Description
        {
            get { return (string)GetValue(TitleProperty); }
            set { SetValue(TitleProperty, value); }
        }

        public static readonly BindableProperty AlertTypeProperty =
                       BindableProperty.Create("AlertType", typeof(AlertTypes), typeof(AlertView), AlertTypes.Info,propertyChanged:OnAlertType);

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

        private ImageSource _alertImage;

        public ImageSource AlertImage
        {
            get { return _alertImage; }
            set { _alertImage = value; }
        }


        #endregion
    }
}
