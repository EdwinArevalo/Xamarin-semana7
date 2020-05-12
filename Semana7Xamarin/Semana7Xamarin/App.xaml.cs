using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Semana7Xamarin
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage =  new NavigationPage(new TextToSpeechDemo());
            //MainPage = new NavigationPage(new BatteryDemo()); 
            MainPage = new NavigationPage(new QRreader());
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
