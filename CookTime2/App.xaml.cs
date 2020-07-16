using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using CookTime2.Services;
using CookTime2.Views;

namespace CookTime2
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new NavigationPage(new LoginPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
