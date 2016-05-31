using System;
using System.Collections.Generic;

namespace StaySteady.Mobile.Models
{
	public class SummaryModel
	{
//		private ReportModel modelForOnePatient;
		private int patientNum;

		public SummaryModel ()
		{
			patientNum = GetNumber ();
		}

		public int PatientNum { get; set;}

		//get the total patients
		public static int GetNumber()
		{
			int patientNum;
			//read from the database
			patientNum = 4;

			return patientNum;
		}


		//create the patient list array
		public static List<Patient> CreatePatientData(){
			List<Patient> allpatients = new List<Patient> ();

			int number = GetNumber();
			for (int i = 0; i < number; i++) {
				Patient curPatient = new Patient();
				curPatient.Name = ReportModel.GetPatientData (i, "Name");
				curPatient.Age = int.Parse(ReportModel.GetPatientData (i, "Age"));
				curPatient.HeartRate = ReportModel.GetPatientData (i, "HeartRate");
				curPatient.LastUpdate = Convert.ToDateTime(ReportModel.GetPatientData(i,"LastUpdate"));
				curPatient.Temperature = ReportModel.GetPatientData (i, "Temperature");
				curPatient.Stability = ReportModel.GetPatientData (i, "Stability");
				curPatient.Risk = ReportModel.GetPatientData (i, "Risk");
				allpatients.Add (curPatient);
			}
			return allpatients;
		}

		//save data into the database


		public ReportModel ModelForOnePatient{ get; set;}
	
	
	}

}

