using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StaySteady.Mobile.ViewModels;
using GalaSoft.MvvmLight.Views;

using Xamarin.Forms;

namespace StaySteady.Mobile.Views
{
    public partial class ReportPage : ContentPage
    {
		private SummaryViewModel _viewModel;
		//private string name;
		public ReportPage(Patient patient)
        {
//			patient_e.Text = name;
            InitializeComponent();
			_viewModel = new  SummaryViewModel (DependencyService.Get<INavigationService>());
			_viewModel.PatientName5 = patient.Name;
			this.BindingContext = _viewModel;
			//BindingContext = patient;
        }

		//public string Name {set; get;}
    }
}
