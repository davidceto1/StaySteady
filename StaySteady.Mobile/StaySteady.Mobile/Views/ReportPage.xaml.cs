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

		public ReportPage(Patient patient)
        {

            InitializeComponent();
			_viewModel = new  SummaryViewModel (DependencyService.Get<INavigationService>());

			_viewModel.Name1 = patient.Name;
			_viewModel.Risk1 = patient.Risk;
			_viewModel.Age1 = patient.Age;
			_viewModel.HeartRate1 = patient.HeartRate;
			_viewModel.LastUpdate1 = patient.LastUpdate;
			_viewModel.Stability1 = patient.Stability;
			_viewModel.Temperature1 = patient.Temperature;

			this.BindingContext = _viewModel;

        }

	
    }
}
