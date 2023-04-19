using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace rtoasaS3
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            //habilitando la navegación 
            MainPage = new NavigationPage(new Inicio());
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
