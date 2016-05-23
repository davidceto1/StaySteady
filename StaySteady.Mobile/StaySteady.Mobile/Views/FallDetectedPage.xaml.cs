using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StaySteady.Mobile.Models;
using StaySteady.Mobile.Utility;
using Xamarin.Forms;
using System.Threading;

namespace StaySteady.Mobile.Views
{
    public partial class FallDetectedPage : ContentPage
    {
        private IDialer _dialer;
        private FallDetectedModel _model;

        public FallDetectedPage()
        {
            InitializeComponent();
            _dialer = DependencyService.Get<IDialer>();
            _model = new FallDetectedModel();
            _model.CountDownInteger = 30;
            this.BindingContext = _model;
            Device.StartTimer(new TimeSpan(0,0,0,1), () =>
            {
                _model.CountDownInteger--;
                return true;
            });
        }

        private void Button_OnClicked(object sender, EventArgs e)
        {
            Navigation.PopAsync(true);
        }

        private void Emergency_OnClicked(object sender, EventArgs e)
        {
            _dialer.Dial("000");
        }


        private void Extra_OnClicked(object sender, EventArgs e)
        {
            _model.CountDownInteger--;
        }


    }
}
