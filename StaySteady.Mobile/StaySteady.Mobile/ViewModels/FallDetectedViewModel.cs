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
using Xamarin.Forms;

namespace StaySteady.Mobile.ViewModels
{
    public class FallDetectedViewModel:ViewModelBase
    {
        private IDialer _dialer;
        private INavigationService _navigationService;

        public FallDetectedViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
            _dialer = DependencyService.Get<IDialer>();
            CallEmergencyNumberCommand = new RelayCommand(CallEmergencyNumber);
            GoBackCommand = new RelayCommand(GoBack);
            Model = new FallDetectedModel();
            Model.CountDownInteger = 30;
            ExecuteTimer();
        }

        public FallDetectedModel Model { get; set; }

        public RelayCommand CallEmergencyNumberCommand { get; private set; }

        public RelayCommand GoBackCommand { get; set; }

        private void CallEmergencyNumber()
        {
            CallEmergency();
        }

        private void CallEmergency()
        {
            _dialer.Dial("000");
        }

        private void GoBack()
        {
            _navigationService.GoBack();
        }

        private void ExecuteTimer()
        {
            Device.StartTimer(new TimeSpan(0, 0, 0, 1), () =>
            {
                if (Model.CountDownInteger > 0)
                {
                    Model.CountDownInteger--;
                    return true;
                }
                else
                {
                    CallEmergency();
                    return false;
                }
                    
                
            });
        }
    }
}
