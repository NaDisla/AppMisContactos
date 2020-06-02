using AppMisContactos.Clases;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppMisContactos
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NuevoContactoPage : ContentPage
    {
        public NuevoContactoPage()
        {
            InitializeComponent();
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            lblHora.Text = DateTime.Now.ToShortTimeString();
        }
        private void btnGuardarContacto_Clicked(object sender, EventArgs e)
        {
                Contactos nuevoContacto = new Contactos()
                {
                    NombreContacto = txtNombre.Text,
                    ApellidoContacto = txtApellido.Text,
                    CorreoContacto = txtCorreo.Text,
                    TelefonoContacto = txtTelefono.Text
                };
            try
            {
                //await App.cliente.GetTable<Contactos>().InsertAsync(nuevoContacto);
                //await DisplayAlert("Contacto guardado", "Se ha guardado el contacto con éxito.", "OK");
                using (var connection = new SQLiteConnection(App.dbRuta))
                {
                    connection.CreateTable<Contactos>();
                    connection.Insert(nuevoContacto);
                    if (connection.Table<Contactos>().Table != null)
                    {
                        DisplayAlert("Contacto guardado", "Se ha guardado el contacto con éxito.", "OK");
                    }
                }
            }
            catch (Exception)
            {
                DisplayAlert("Error agregando el contacto", "Se produjo un error al guardar el contacto.", "OK");
            }
        }
    }
}