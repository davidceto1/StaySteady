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
			Patient[] newPatients = new Patient[4];
			newPatients[0] = new Patient ("High",new DateTime(2016,06,01,16,29,48),"Soul",80,0.12.ToString("P"),"36°C","60-120bpm");
			newPatients[1] = new Patient ("High",new DateTime(2016,06,01,16,29,48),"Amy",85,0.15.ToString("P"),"36°C","60-120bpm");
			newPatients[2] = new Patient ("Low",new DateTime(2016,06,01,16,29,48),"Mariah",71,0.8.ToString("P"),"36°C","60-120bpm");
			newPatients[3] = new Patient ("Medium",new DateTime(2016,06,01,16,29,48),"Volerie",65,0.45.ToString("P"),"36°C","60-120bpm");

			Navigation.PushAsync(new SummaryPage(newPatients));

        }

        private void GoRelative(object sender, EventArgs e)
        {
			Patient newPaitent = new Patient ("High",new DateTime(2016,06,01,16,29,48),"Soul",80,0.12.ToString("P"),"36°C","60-120bpm");

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
