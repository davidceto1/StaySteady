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

		public SummaryPage()
		{
			InitializeComponent();
			_viewModel = new SummaryViewModel (DependencyService.Get<INavigationService>());
			this.BindingContext = _viewModel;
		}
    }
}
