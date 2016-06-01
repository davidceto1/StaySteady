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
		
		private ReportViewModel viewModelOfReport;

		public ReportPage()
		{

			InitializeComponent();
			viewModelOfReport = new  ReportViewModel (DependencyService.Get<INavigationService>());
			this.BindingContext = viewModelOfReport;

		}

		public ReportPage(int whichOne)
		{

			InitializeComponent();
			viewModelOfReport = new  ReportViewModel (DependencyService.Get<INavigationService>(),whichOne);
			this.BindingContext = viewModelOfReport;
		}

        private void goBookAppointment(object sender, EventArgs e)
        {
            Navigation.PushAsync(new BookAppointmentPage());
        }

    }
}
