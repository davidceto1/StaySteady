using System;
using GalaSoft.MvvmLight;
using System.Collections.ObjectModel;
namespace StaySteady.Mobile
{
	public class PatientBody:ViewModelBase
	{
		ObservableCollection<Patient> patients = new ObservableCollection<Patient>();
		public PatientBody ()
		{
		}
//		public ObservableCollection<Patient> Patients
//		{
//			set { SetProperty(ref patients, value); }
//			get { return patients; }
//		}
	}
}

