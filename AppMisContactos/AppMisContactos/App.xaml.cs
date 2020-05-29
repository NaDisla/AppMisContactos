using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppMisContactos
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
        }
        public static string dbRuta;
        public App(string rutaDB)
        {
            InitializeComponent();

            MainPage = new MainPage();
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
