using System;
using System.Windows.Input;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Views;
using GalaSoft.MvvmLight.Command;
using Xamarin.Forms;
using StaySteady.Mobile.Utility;
using StaySteady.Mobile.Views;

using StaySteady.Mobile.Models;

namespace StaySteady.Mobile.ViewModels
{
	public class SummaryViewModel:ViewModelBase
	{
		private int whichButtonClicked = 0;
		public SummaryViewModel (INavigationService navigationService)
		{
//			WhichButtonClicked = 1;
			TakeNextAction1 = new Command (ShowMessage1);
//			WhichButtonClicked = 2;
			TakeNextAction2 = new Command (ShowMessage2);
//			WhichButtonClicked = 3;
			TakeNextAction3 = new Command (ShowMessage3);
//			WhichButtonClicked = 4;
			TakeNextAction4 = new Command (ShowMessage4);
		}
	

		private void ShowMessage1()
		{
			Patient thisPatient = new Patient(Risk1, LastUpdate1, Name1, Age1, Stability1, Temperature1, HeartRate1);
//			switch(WhichButtonClicked)
//			{
//			case 1:
//				thisPatient = new Patient (Risk1, LastUpdate1, Name1, Age1, Stability1, Temperature1, HeartRate1);
//				break;
//			case 2:
//				thisPatient = new Patient (Risk2, LastUpdate2, Name2, Age2, Stability2, Temperature2, HeartRate2);
//				break;
//			case 3:
//				thisPatient = new Patient (Risk3, LastUpdate3, Name3, Age3, Stability3, Temperature3, HeartRate3);
//				break;
//			case 4:
//				thisPatient = new Patient (Risk4, LastUpdate4, Name4, Age4, Stability4, Temperature4, HeartRate4);
//				break;
//			default: 
//				break;	
//			}

			ReportPage thisPatientReport = new ReportPage (thisPatient);
			App.Navigation.PushAsync(thisPatientReport);

		}

		private void ShowMessage2()
		{
			Patient thisPatient = new Patient (Risk2, LastUpdate2, Name2, Age2, Stability2, Temperature2, HeartRate2);
			ReportPage thisPatientReport = new ReportPage (thisPatient);
			App.Navigation.PushAsync(thisPatientReport);

		}
		private void ShowMessage3()
		{
			Patient thisPatient = new Patient (Risk3, LastUpdate3, Name3, Age3, Stability3, Temperature3, HeartRate3);
			ReportPage thisPatientReport = new ReportPage (thisPatient);
			App.Navigation.PushAsync(thisPatientReport);

		}
		private void ShowMessage4()
		{
			Patient thisPatient = new Patient (Risk4, LastUpdate4, Name4, Age4, Stability4, Temperature4, HeartRate4);
			ReportPage thisPatientReport = new ReportPage (thisPatient);
			App.Navigation.PushAsync(thisPatientReport);

		}

		public Command TakeNextAction1{private set; get;}
		public Command TakeNextAction2{private set; get;}
		public Command TakeNextAction3{private set; get;}
		public Command TakeNextAction4{private set; get;}


		public string Name1{ set; get;}
		public string Risk1{ set; get;}
		public string HeartRate1{ set; get;}
		public string Stability1{ set; get;}
		public string Temperature1{ set; get;}
		public DateTime LastUpdate1{ set; get;}
		public int Age1{ set; get;}

		public string Name2{ set; get;}
		public string Risk2{ set; get;}
		public string HeartRate2{ set; get;}
		public string Stability2{ set; get;}
		public string Temperature2{ set; get;}
		public DateTime LastUpdate2{ set; get;}
		public int Age2{ set; get;}

		public string Name3{ set; get;}
		public string Risk3{ set; get;}
		public string HeartRate3{ set; get;}
		public string Stability3{ set; get;}
		public string Temperature3{ set; get;}
		public DateTime LastUpdate3{ set; get;}
		public int Age3{ set; get;}

		public string Name4{ set; get;}
		public string Risk4{ set; get;}
		public string HeartRate4{ set; get;}
		public string Stability4{ set; get;}
		public string Temperature4{ set; get;}
		public DateTime LastUpdate4{ set; get;}
		public int Age4{ set; get;}

		public int WhichButtonClicked{ set; get;}
	}
}

