using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StaySteady.Mobile.Utility;
using Xamarin.Forms;

namespace StaySteady.Mobile.Views
{
    public partial class MainPage : ContentPage
    {
        

        public MainPage()
        {
            InitializeComponent();
        }

        private void GoElder(object sender, EventArgs e)
        {
            Navigation.PushAsync(new DailyActivity());
        }

        private void GoDoctor(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SummaryPage2());
        }

        private void GoRelative(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ReportPage2());
        }

        private void Button_OnClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new FallDetectedPage());
        }

        private void AddReminderButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AddReminderPage());
        }

        private void Tutorial_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Exercise());
        }
    }
}
