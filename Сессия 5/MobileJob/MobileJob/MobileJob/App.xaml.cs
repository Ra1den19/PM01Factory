using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MobileJob
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            var navPage = new NavigationPage(new MainPage())
            {
                BarBackgroundColor = Color.FromHex("#2196F3"), // Цвет панели навигации
                BarTextColor = Color.White // Цвет текста на панели навигации
            };

            MainPage = navPage;
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
