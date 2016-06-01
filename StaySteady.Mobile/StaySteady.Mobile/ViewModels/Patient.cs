using System;
using GalaSoft.MvvmLight;

namespace StaySteady.Mobile
{
	public class Patient:ViewModelBase
	{
		//private ReportModel modelForReport;

		public Patient ()
		{
			

		}

		public Patient (string namePatient){
			Name = namePatient;
		}

		public Patient (string riskPatient,DateTime lastdate,string namePatient,int agePatient,string staPatient,string temperatureP,string hearRateP){
			Risk = riskPatient;
			LastUpdate = lastdate;
			Name = namePatient;
			Age = agePatient;
			Stability = staPatient;
			Temperature = temperatureP;
			HeartRate = hearRateP;
		}


		public string Name{ set; get;}
		public string Risk{ set; get;}
		public string HeartRate{ set; get;}
		public string Stability{ set; get;}
		public string Temperature{ set; get;}
		public DateTime LastUpdate{ set; get;}
		public int Age{ set; get;}

	}
}

