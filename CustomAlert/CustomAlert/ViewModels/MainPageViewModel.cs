using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CustomAlert.ViewModels
{
    public class MainPageViewModel : BindableBase, INavigationAware
    {
        private string _title;
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        private bool _isAlert;
        public bool IsAlert
        {
            get { return _isAlert; }
            set { SetProperty(ref _isAlert, value); }
        }

        private DelegateCommand<object> _onAlertCommand;
        public DelegateCommand<object> OnAlertCommand =>
            _onAlertCommand ?? (_onAlertCommand = new DelegateCommand<object>(arg =>
            {
                if ((bool)arg)
                    return;
            }));

        private DelegateCommand _buttonCommand;
        public DelegateCommand BttonCommand =>
            _buttonCommand ?? (_buttonCommand = new DelegateCommand(() =>
            {
                IsAlert = true;
            }));

        public MainPageViewModel()
        {

        }

        public void OnNavigatedFrom(NavigationParameters parameters)
        {

        }

        public void OnNavigatingTo(NavigationParameters parameters)
        {

        }

        public void OnNavigatedTo(NavigationParameters parameters)
        {
            if (parameters.ContainsKey("title"))
                Title = (string)parameters["title"] + " and Prism";
        }
    }
}
