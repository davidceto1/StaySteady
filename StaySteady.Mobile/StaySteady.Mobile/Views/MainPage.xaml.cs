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
            Navigation.PushAsync(new SummaryPage());
//			Navigation.PushAsync(new TestPage());
        }

        private void GoRelative(object sender, EventArgs e)
        {
			Patient newPaitent = new Patient ();
			newPaitent.Name = "Soul";
			Navigation.PushAsync(new ReportPage(newPaitent));
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
