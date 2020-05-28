using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CustomPopupRgPlugin
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Views.MainPage())
            {
                BarBackgroundColor = Color.FromHex("#7dbbe6"),
                BarTextColor = Color.White
            };
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
