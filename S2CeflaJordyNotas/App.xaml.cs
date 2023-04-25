using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace S2CeflaJordyNotas
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            //habilitación de navegación 

            MainPage = new NavigationPage( new Inicio());
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
