using AppMisContactos.Clases;
using SQLite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppMisContactos
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        List<Contactos> contactosLista;
        public MainPage()
        {
            InitializeComponent();
            contactosLista = new List<Contactos>();
            listContactos.ItemSelected += ListContactos_ItemSelected;
        }

        private void ListContactos_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var contactoSeleccionado = e.SelectedItem as Contactos;
            Navigation.PushAsync(new DetallesContactoPage(contactoSeleccionado));
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            using(var conn = new SQLiteConnection(App.dbRuta))
            {
                conn.CreateTable<Contactos>();
                contactosLista = conn.Table<Contactos>().ToList();

                listContactos.ItemsSource = contactosLista;
            }
            /*contactosLista = await App.cliente.GetTable<Contactos>().ToListAsync();
            listContactos.ItemsSource = contactosLista;*/
        }
        private void ToolbarItem_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new NuevoContactoPage());
        }
    }
}
