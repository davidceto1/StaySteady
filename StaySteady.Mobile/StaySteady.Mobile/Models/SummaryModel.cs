using SQLite;
using StaySteady.Mobile.Utility;
using System;
using System.Collections.Generic;

namespace StaySteady.Mobile.Models
{
	public class SummaryModel
	{


		public SummaryModel ()
		{

		}



		//create the patient list array, get data from database
		public static List<Patient> CreatePatientData(){
			List<Patient> allpatients = new List<Patient> ();
			SQLiteConnection db = DatabaseService.GetInstance().SqLiteConnection;
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
			
	
	
	}

}

