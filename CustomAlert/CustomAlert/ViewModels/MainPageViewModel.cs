using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CustomAlert.ViewModels
{
	public class MainPageViewModel : BindableBase
	{
		private string _title;
		public string Title
		{
			get { return _title; }
			set { SetProperty(ref _title, value); }
		}

		private string _description;
		public string Description
		{
			get { return _description; }
			set { SetProperty(ref _description, value); }
		}

		private bool _isAlert;
		public bool IsAlert
		{
			get { return _isAlert; }
			set { SetProperty(ref _isAlert, value); }
		}

		private AlertTypes _alert;
		public AlertTypes Alert
		{
			get { return _alert; }
			set { SetProperty(ref _alert, value); }
		}

		private bool _hasPositiveButton;
		public bool HasPositiveButton
		{
			get { return _hasPositiveButton; }
			set { SetProperty(ref _hasPositiveButton, value); }
		}

        private string _okbutton = "Cancel";
        public string OkButton
        {
            get { return _okbutton; }
            set { SetProperty(ref _okbutton, value); }
        }

        private DelegateCommand<object> _onAlertCommand;
		public DelegateCommand<object> OnAlertCommand =>
			_onAlertCommand ?? (_onAlertCommand = new DelegateCommand<object>(arg =>
			{
                if ((bool)arg)
                {
                    OkButton = "Ok";
                    SuccessCommand.Execute();
                }
			}));

		private DelegateCommand _successCommand;
		public DelegateCommand SuccessCommand =>
			_successCommand ?? (_successCommand = new DelegateCommand(() =>
			{
				Title = "Success";
				Alert = AlertTypes.Success;
				Description = "I'm happy to hear that friend! Keep fulfilling your dreams & make every single day count Success is just within your reach.";
				HasPositiveButton = false;
				IsAlert = true;
			}));

		private DelegateCommand _errorCommand;
		public DelegateCommand ErrorCommand =>
			_errorCommand ?? (_errorCommand = new DelegateCommand(() =>
			{
				Title = "Error";
				Description = "It is sometimes necessary to display error text associated with error codes returned from networking-related functions. You may need to perform this task with the network management functions provided by the system.";
				HasPositiveButton = false;
				Alert = AlertTypes.Error;
				IsAlert = true;
			}));

		private DelegateCommand _infoCommand;
		public DelegateCommand InfoCommand =>
			_infoCommand ?? (_infoCommand = new DelegateCommand(() =>
			{
				Title = "Information";
				Description = "Informational text is a subset of the larger category of nonfiction (Duke & Bennett-Armistead, 2003). Its primary purpose is to inform the reader about the natural or social world.";
				Alert = AlertTypes.Info;
				HasPositiveButton = true;
				IsAlert = true;
			}));

		public MainPageViewModel()
		{

		}
	}
}
