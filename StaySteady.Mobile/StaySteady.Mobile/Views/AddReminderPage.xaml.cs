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
    public partial class AddReminderPage : ContentPage
    {
        private AddReminderViewModel _bindingContext;

        public AddReminderPage()
        {
            InitializeComponent();
            _bindingContext = new AddReminderViewModel(DependencyService.Get<INavigationService>());
            this.BindingContext = _bindingContext;
            this.MyTimePicker.SetBinding(TimePicker.TimeProperty,"Model.Times", BindingMode.TwoWay,null,null);
        }
    }
}
