using System;
using System.Windows.Input;
using System.Collections.Generic;
using System.Linq;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Views;
using GalaSoft.MvvmLight.Command;
using Xamarin.Forms;
using StaySteady.Mobile.Utility;
using StaySteady.Mobile.Views;
//using StaySteady.Mobile.Models;

using StaySteady.Mobile.Models;

namespace StaySteady.Mobile.ViewModels
{
	

	public class SummaryViewModel:ViewModelBase
	{
		

		List<Patient> patientArray = new List<Patient> ();

		public SummaryViewModel (INavigationService navigationService)
		{

           
            patientArray = SummaryModel.CreatePatientData();      

            int i = 0;
			Name1 = patientArray [i].Name;
			Risk1 = patientArray [i].Risk;
			Age1 = patientArray [i].Age;
			HeartRate1 = patientArray [i].HeartRate;
			LastUpdate1 = patientArray [i].LastUpdate;
			Stability1 = patientArray [i].Stability;
			Temperature1 = patientArray [i].Temperature;
			i = 1;
			Name2 = patientArray [i].Name;
			Risk2 = patientArray [i].Risk;
			Age2 = patientArray [i].Age;
			HeartRate2 = patientArray [i].HeartRate;
			LastUpdate2 = patientArray [i].LastUpdate;
			Stability2 = patientArray [i].Stability;
			Temperature2 = patientArray [i].Temperature;
			i = 2;
			Name3 = patientArray [i].Name;
			Risk3 = patientArray [i].Risk;
			Age3 = patientArray [i].Age;
			HeartRate3 = patientArray [i].HeartRate;
			LastUpdate3 = patientArray [i].LastUpdate;
			Stability3 = patientArray [i].Stability;
			Temperature3 = patientArray [i].Temperature;
			i = 3;
			Name4 = patientArray [i].Name;
			Risk4 = patientArray [i].Risk;
			Age4 = patientArray [i].Age;
			HeartRate4 = patientArray [i].HeartRate;
			LastUpdate4 = patientArray [i].LastUpdate;
			Stability4 = patientArray [i].Stability;
			Temperature4 = patientArray [i].Temperature;

			TakeNextAction1 = new Command (ShowMessage1);

			TakeNextAction2 = new Command (ShowMessage2);

			TakeNextAction3 = new Command (ShowMessage3);

			TakeNextAction4 = new Command (ShowMessage4);
		}


		private void ShowMessage1()
		{
			
			App.Navigation.PushAsync(new ReportPage (0));

		}

		private void ShowMessage2()
		{

		App.Navigation.PushAsync(new ReportPage (1));

		}
		private void ShowMessage3()
		{
			App.Navigation.PushAsync(new ReportPage (2));

		}
		private void ShowMessage4()
		{
			App.Navigation.PushAsync(new ReportPage (3));

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


	}
}

