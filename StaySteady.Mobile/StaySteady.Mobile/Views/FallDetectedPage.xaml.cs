using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StaySteady.Mobile.Models;
using StaySteady.Mobile.Utility;
using Xamarin.Forms;

namespace StaySteady.Mobile.Views
{
    public partial class FallDetectedPage : ContentPage
    {
        private IDialer _dialer;

        

        public FallDetectedPage()
        {
            InitializeComponent();
            _dialer = DependencyService.Get<IDialer>();
            FallDetectedModel Model = new FallDetectedModel();
            Model.CountDownInteger = 30;
            this.BindingContext = Model;
        }

        private void Button_OnClicked(object sender, EventArgs e)
        {
            Navigation.PopAsync(true);
        }

        private void Emergency_OnClicked(object sender, EventArgs e)
        {
            _dialer.Dial("000");
        }

        
    }
}
