using System;

namespace StaySteady.Mobile
{
	public class Paitient:ViewModelBase
	{
		string name,risk,heartRate;
		DateTime lastUpdate;
		int age;
		double stability,temperature;

		public Paitient ()
		{
		}

		public string Name {

			set { SetProperty (ref name, value); }
			get { return name; }
		}

	}
}

