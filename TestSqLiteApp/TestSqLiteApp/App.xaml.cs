using System;
using System.IO;
using TestSqLiteApp.Repository;
using TestSqLiteApp.Services;
using TestSqLiteApp.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TestSqLiteApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            DependencyService.Register<MockDataStore>();
            DependencyService.Register<FriendRepository>();
            MainPage = new AppShell();
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
