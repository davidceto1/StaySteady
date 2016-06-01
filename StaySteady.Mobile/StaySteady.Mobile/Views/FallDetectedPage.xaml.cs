using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StaySteady.Mobile.Models;
using StaySteady.Mobile.Utility;
using Xamarin.Forms;
using System.Threading;
using GalaSoft.MvvmLight.Views;
using StaySteady.Mobile.ViewModels;

namespace StaySteady.Mobile.Views
{
    public partial class FallDetectedPage : ContentPage
    {
        
        private FallDetectedViewModel _ViewModel;

        public FallDetectedPage()
        {
            InitializeComponent();
            _ViewModel = new FallDetectedViewModel(DependencyService.Get<INavigationService>());
            this.BindingContext = _ViewModel;
            this.FallLabel.TextColor = Color.FromHex("#34495E");
            FallCountdownNumber.TextColor = Color.FromHex("#34495E");
        }
    }
}
