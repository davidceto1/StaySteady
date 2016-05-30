using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Views;
using StaySteady.Mobile.Models;
using StaySteady.Mobile.Utility;

namespace StaySteady.Mobile.ViewModels
{
    class AddReminderViewModel: ViewModelBase
    {

        private INavigationService _navigationService;

        public AddReminderViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
            Model = new AddReminderModel();

            GoBackCommand = new RelayCommand(GoBack);
            AddReminderCommand = new RelayCommand(AddReminder);

        }

        public AddReminderModel Model { get; set; }

        public RelayCommand GoBackCommand { get; set; }

        public RelayCommand AddReminderCommand { get;  set; }

        private void GoBack()
        {
            _navigationService.GoBack();
        }

        private void AddReminder()
        {
            DatabaseService.GetInstance.SqLiteConnection.Insert(Model);
        }
    }
}
