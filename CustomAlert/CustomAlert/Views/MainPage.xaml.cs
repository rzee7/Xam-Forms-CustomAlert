using CustomAlert.Controls;
using CustomAlert.ViewModels;
using Xamarin.Forms;

namespace CustomAlert.Views
{
    public partial class MainPage : ContentPage
    {
        public MainPageViewModel ViewModel { get { return BindingContext as MainPageViewModel; } }
        public MainPage()
        {
            InitializeComponent();
            //try
            //{
            //    var d = new Controls.AlertView
            //    {
            //        Description = "This is only for testing pupose!",
            //        NegativeButtonTitle = "Cancel",
            //        PositiveButtonTitle = "Ok",
            //        AlertType = AlertTypes.Success,
            //        //HasMoreButton = true
            //    };
            //    d.SetBinding(AlertView.OnCommandProperty, "OnAlertCommand");
            //    d.SetBinding(AlertView.IsVisibleProperty, "IsAlert");
            //    gg.Children.Add(d);
            //}
            //catch (System.Exception x)
            //{

            //    //throw;
            //}
        }
    }
}
