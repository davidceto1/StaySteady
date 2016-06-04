using System;
using GalaSoft.MvvmLight;
using System.ComponentModel;
using StaySteady.Mobile.Models;
using GalaSoft.MvvmLight.Views;
using System.Collections.Generic;
using Xamarin.Forms;
using StaySteady.Mobile.Views;

namespace StaySteady.Mobile
{
	public class ReportViewModel:ViewModelBase
	{

		List<Patient> allPatients = new List<Patient> ();

		public ReportViewModel (INavigationService navigationService)
		{
			WhichPatient = 0;
			allPatients = SummaryModel.CreatePatientData ();
			Name = allPatients [WhichPatient].Name;
			Risk = allPatients [WhichPatient].Risk;
			Age = allPatients [WhichPatient].Age;
			HeartRate = allPatients [WhichPatient].HeartRate;
			LastUpdate = allPatients [WhichPatient].LastUpdate;
			Stability = allPatients [WhichPatient].Stability;
			Temperature = allPatients [WhichPatient].Temperature;
			GoBook = new Command (OpenAppointPage);

		}

		public ReportViewModel (INavigationService navigationService, int i)
		{
			WhichPatient = i;
			allPatients = SummaryModel.CreatePatientData ();
			Name = allPatients [WhichPatient].Name;
			Risk = allPatients [WhichPatient].Risk;
			Age = allPatients [WhichPatient].Age;
			HeartRate = allPatients [WhichPatient].HeartRate;
			LastUpdate = allPatients [WhichPatient].LastUpdate;
			Stability = allPatients [WhichPatient].Stability;
			Temperature = allPatients [WhichPatient].Temperature;
			GoBook = new Command (OpenAppointPage);

		}

		private void OpenAppointPage()
		{
			App.Navigation.PushAsync(new BookAppointmentPage());

		}	

		public string Name{ set; get;}
		public string Risk{ set; get;}
		public string HeartRate{ set; get;}
		public string Stability{ set; get;}
		public string Temperature{ set; get;}
		public DateTime LastUpdate{ set; get;}
		public int Age{ set; get;}

		public SummaryModel SummaryModelData { get; set; }
		public int WhichPatient  { get; set; }

		public Command GoBook{private set; get;}

	}
}

