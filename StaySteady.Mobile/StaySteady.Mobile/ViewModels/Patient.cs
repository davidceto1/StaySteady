using System;
using GalaSoft.MvvmLight;

namespace StaySteady.Mobile
{
	public class Patient:ViewModelBase
	{
		string name,risk,heartRate;
		DateTime lastUpdate;
		int age;
		double stability,temperature;

		public Patient ()
		{
		}

		public Patient (string namea){
			name = namea;
		}

//		public string Name {
//
//			set { SetProperty (ref name, value); }
//			get { return name; }
//		}

		public string Name{ set; get;}

	}
}

