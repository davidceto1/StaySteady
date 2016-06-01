//process the data of current patient
using System;

namespace StaySteady.Mobile
{
	public class ReportModel
	{
		//set the threshold of the judgement of the risk
		private const double THRELOW = 0.25;
		private const double THREHIGH = 0.75;
	


		public double Stability{get;set;}


		public ReportModel ()
		{
			
		}

	
		//retrive the data of the patients, access the database
		public static string GetPatientData(int whichRow, string whichItem){
			//read data from database
			string dataOfThisRow;
			if (whichRow == 0) {
				switch (whichItem) {
				case "Name":
					dataOfThisRow = "Linda";
					break;
				case "Age":
					dataOfThisRow = "80";
					break;
				case "Temperature":
					dataOfThisRow = "36°C";
					break;
				case "HeartRate":
					dataOfThisRow = "60-120bpm";
					break;
				case "Stability":
					dataOfThisRow = "12%";
					break;
				case "Risk":
					dataOfThisRow = "High";
					break;
				case "LastUpdate":
//					dataOfThisRow = "2/27/2016 12:13 PM";
					dataOfThisRow = "2016/2/20 12:13:33";
					break;
				default:
					dataOfThisRow = "Unknown";
					break;
				}
			} else if (whichRow == 1) {
				switch (whichItem) {
				case "Name":
					dataOfThisRow = "Amy";
					break;
				case "Age":
					dataOfThisRow = "85";
					break;
				case "Temperature":
					dataOfThisRow = "36°C";
					break;
				case "HeartRate":
					dataOfThisRow = "60-120bpm";
					break;
				case "Stability":
					dataOfThisRow = "15%";
					break;
				case "Risk":
					dataOfThisRow = "High";
					break;
				case "LastUpdate":
						//					dataOfThisRow = "2/27/2016 12:13 PM";
					dataOfThisRow = "2016/2/20 12:13:33";
					break;
				default:
					dataOfThisRow = "Unknown";
					break;
				}
			} else if (whichRow == 2) {
				switch (whichItem) {
				case "Name":
					dataOfThisRow = "Mariah";
					break;
				case "Age":
					dataOfThisRow = "71";
					break;
				case "Temperature":
					dataOfThisRow = "36°C";
					break;
				case "HeartRate":
					dataOfThisRow = "60-120bpm";
					break;
				case "Stability":
					dataOfThisRow = "80%";
					break;
				case "Risk":
					dataOfThisRow = "Low";
					break;
				case "LastUpdate":
						//					dataOfThisRow = "2/27/2016 12:13 PM";
					dataOfThisRow = "2016/2/20 12:13:33";
					break;
				default:
					dataOfThisRow = "Unknown";
					break;
				}
			} else if (whichRow == 3) {
				switch (whichItem) {
				case "Name":
					dataOfThisRow = "Valerie";
					break;
				case "Age":
					dataOfThisRow = "65";
					break;
				case "Temperature":
					dataOfThisRow = "36°C";
					break;
				case "HeartRate":
					dataOfThisRow = "60-120bpm";
					break;
				case "Stability":
					dataOfThisRow = "45%";
					break;
				case "Risk":
					dataOfThisRow = "Medium";
					break;
				case "LastUpdate":
						//					dataOfThisRow = "2/27/2016 12:13 PM";
					dataOfThisRow = "2016/2/20 12:13:33";
					break;
				default:
					dataOfThisRow = "Medium";
					break;
				}
			} else
				dataOfThisRow = "";
					
			
			return dataOfThisRow;

		}



		//save the calculated data into the database
		public void SaveData(){
			//write data to database


		}

		//retrive the data of the sensors, access the database
		public void GetSensorData(){
			//read data from database


		}

		// using the data of the sensors to calculate the stability
		public double CalculateStability(double para){
			double stability;
			// algorithms
			stability = para;

			return stability;
			
		}

		//decide the risk of this person
		public string CalculateRisk(double stability){
			string risk;
			if (stability > 0 && stability < THRELOW)
				risk = "High";
			else if (stability >= THRELOW && stability < THREHIGH)
				risk = "Medium";
			else if (stability >= THREHIGH && stability <= 1)
				risk = "Low";
			else
				risk = "Invalid Stability Information!";

			return risk;
		}


	}
}

