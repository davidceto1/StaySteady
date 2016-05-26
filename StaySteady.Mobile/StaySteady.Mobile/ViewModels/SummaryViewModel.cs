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
	public class SummaryViewModel:ViewModelBase
	{
		private INavigationService _navigationService;
		public SummaryViewModel (INavigationService navigationService)
		{
			_navigationService = navigationService;

			//Initialize Icommand properties
			PatientName5 = "Volerie";
			TakeNextAction = new Command (ShowMessage);
			
		}
	

		private void ShowMessage()
		{
	//		new ReportPage(); 
//			string name = patient
			//PatientName5 = "Volerie";
			Patient testPerson = new Patient();
			testPerson.Name = PatientName5;
			ReportPage thisPatientReport = new ReportPage (testPerson);


			App.Navigation.PushAsync(thisPatientReport);

		}

		public ICommand TakeNextAction{private set; get;}

		public string PatientName5{ set; get;}

	}
}

