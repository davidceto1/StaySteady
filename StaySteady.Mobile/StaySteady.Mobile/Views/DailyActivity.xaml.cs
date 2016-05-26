using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StaySteady.Mobile.Models;
using StaySteady.Mobile.Utility;
using Xamarin.Forms;
using StaySteady.Mobile.ViewModels;
using GalaSoft.MvvmLight.Views;

namespace StaySteady.Mobile.Views
{
    public partial class DailyActivity : ContentPage
    {
        private DailyActivityViewModel _viewModel;

        public DailyActivity()
        {
            InitializeComponent();
            _viewModel = new DailyActivityViewModel(DependencyService.Get<INavigationService>());
            this.BindingContext = _viewModel;           
        }
    }
}
