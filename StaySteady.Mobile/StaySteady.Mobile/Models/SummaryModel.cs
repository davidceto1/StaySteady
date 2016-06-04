using SQLite;
using StaySteady.Mobile.Utility;
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

            /*			int number = GetNumber();
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
            */

            SQLiteConnection db = DatabaseService.GetInstance().SqLiteConnection;
//			db.DropTable<StaySteadyTableModel> ();
            var data = db.Query<StaySteadyTableModel>("SELECT * FROM StaySteady ORDER by StabilityRate ASC");
            double risk = 0;
            int age;
            int i = 0;
            foreach (var row in data)
            {
                Patient curPatient = new Patient();
                curPatient.Name = row.Name;
                int.TryParse(row.Age, out age);
                curPatient.Age = age;
                curPatient.HeartRate = row.HeartRateMin + "-" + row.HeartRateMax;
                curPatient.LastUpdate = Convert.ToDateTime(row.LastUpdate);
				curPatient.Temperature = row.Temperature +"℃";
                curPatient.Stability = row.StabilityRate + "%";
                double.TryParse(row.StabilityRate, out risk);
                curPatient.Risk = ReportModel.CalculateRisk(risk);
                allpatients.Add(curPatient);
                if (row.Id == 1)
                    ReportViewModel.WhichPatient = i;
                if (i++ >= 3)
                    break;

            }

            return allpatients;
		}

		//save data into the database


		public ReportModel ModelForOnePatient{ get; set;}
	
	
	}

}

