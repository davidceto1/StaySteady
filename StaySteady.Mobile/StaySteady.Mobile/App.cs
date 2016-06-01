using StaySteady.Mobile.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GalaSoft.MvvmLight.Ioc;
using GalaSoft.MvvmLight.Views;
using StaySteady.Mobile.Models;
using StaySteady.Mobile.Utility;
using Xamarin.Forms;

namespace StaySteady.Mobile
{
    public class App : Application
    {

        public static INavigation Navigation { get; set; }

        public App()
        {
            
            MainPage = new NavigationPage(new MainPage());

            Navigation = MainPage.Navigation;

            DependencyService.Register<INavigationService,NavigationService>();

            DatabaseService.GetInstance().InitializeDB();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
