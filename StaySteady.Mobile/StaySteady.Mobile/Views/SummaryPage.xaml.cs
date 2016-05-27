using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight.Views;
using StaySteady.Mobile.ViewModels;

using Xamarin.Forms;

namespace StaySteady.Mobile.Views
{
    public partial class SummaryPage : ContentPage
    {
		private SummaryViewModel _viewModel;
		public SummaryPage(Patient[] patientArray)
        {
			
            InitializeComponent();
			_viewModel = new SummaryViewModel (DependencyService.Get<INavigationService>());

			int i = 0;
			_viewModel.Name1 = patientArray [i].Name;
			_viewModel.Risk1 = patientArray [i].Risk;
			_viewModel.Age1 = patientArray [i].Age;
			_viewModel.HeartRate1 = patientArray [i].HeartRate;
			_viewModel.LastUpdate1 = patientArray [i].LastUpdate;
			_viewModel.Stability1 = patientArray [i].Stability;
			_viewModel.Temperature1 = patientArray [i].Temperature;
			i = 1;
			_viewModel.Name2 = patientArray [i].Name;
			_viewModel.Risk2 = patientArray [i].Risk;
			_viewModel.Age2 = patientArray [i].Age;
			_viewModel.HeartRate2 = patientArray [i].HeartRate;
			_viewModel.LastUpdate2 = patientArray [i].LastUpdate;
			_viewModel.Stability2 = patientArray [i].Stability;
			_viewModel.Temperature2 = patientArray [i].Temperature;
			i = 2;
			_viewModel.Name3 = patientArray [i].Name;
			_viewModel.Risk3 = patientArray [i].Risk;
			_viewModel.Age3 = patientArray [i].Age;
			_viewModel.HeartRate3 = patientArray [i].HeartRate;
			_viewModel.LastUpdate3 = patientArray [i].LastUpdate;
			_viewModel.Stability3 = patientArray [i].Stability;
			_viewModel.Temperature3 = patientArray [i].Temperature;
			i = 3;
			_viewModel.Name4 = patientArray [i].Name;
			_viewModel.Risk4 = patientArray [i].Risk;
			_viewModel.Age4 = patientArray [i].Age;
			_viewModel.HeartRate4 = patientArray [i].HeartRate;
			_viewModel.LastUpdate4 = patientArray [i].LastUpdate;
			_viewModel.Stability4 = patientArray [i].Stability;
			_viewModel.Temperature4 = patientArray [i].Temperature;

			this.BindingContext = _viewModel;
        }
    }
}
