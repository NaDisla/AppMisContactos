using Microsoft.WindowsAzure.MobileServices;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppMisContactos
{
    public partial class App : Application
    {
        public static MobileServiceClient cliente = new MobileServiceClient("https://udemy-contactos.azurewebsites.net");
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());
        }
        public static string dbRuta;
        public App(string rutaDB)
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());
            dbRuta = rutaDB;
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
