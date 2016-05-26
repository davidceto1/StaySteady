using System;
using System.Windows.Input;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Views;
using Xamarin.Forms;
using StaySteady.Mobile.Utility;
using StaySteady.Mobile.Views;

using StaySteady.Mobile.Models;

namespace StaySteady.Mobile.ViewModels
{
	public class SummaryPageViewModel:ViewModelBase
	{
		private INavigationService _navigationService;
		public SummaryPageViewModel (INavigationService navigationService)
		{
			_navigationService = navigationService;

			//Initialize Icommand properties
			TakeNextAction = new Command (ShowMessage);
			
		}
	

		private void ShowMessage()
		{
	//		new ReportPage(); 
				App.Navigation.PushAsync(new ReportPage());

		}

		public ICommand TakeNextAction{private set; get;}

	}
}

