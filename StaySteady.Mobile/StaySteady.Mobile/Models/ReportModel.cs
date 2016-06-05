//process the data of current patient
using System;

namespace StaySteady.Mobile
{
	public class ReportModel
	{
		//set the threshold of the judgement of the risk
		private const double THRELOW = 25;
		private const double THREHIGH = 50;
	


		public double Stability{get;set;}


		public ReportModel ()
		{
			
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
		public static string CalculateRisk(double stability){
			string risk;
			if (stability > 0 && stability < THRELOW)
				risk = "High";
			else if (stability >= THRELOW && stability < THREHIGH)
				risk = "Medium";
			else if (stability >= THREHIGH && stability <= 100)
				risk = "Low";
			else
				risk = "Invalid Stability Information!";

			return risk;
		}


	}
}

