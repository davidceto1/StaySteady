using System;
using GalaSoft.MvvmLight;
using System.ComponentModel;

namespace StaySteady.Mobile
{
	public class ReportViewModel:ViewModelBase
	{
		string name;
		public ReportViewModel (Patient patientMary)
		{
			name = patientMary.Name;
		}
//
		public string PatientName{set;get;}
//		{
//			set {
//				if (name != value)
//				{
//					name = value;
//
//				}
//			}
//
//		
//			get { return name; }
//		}

	}
}

