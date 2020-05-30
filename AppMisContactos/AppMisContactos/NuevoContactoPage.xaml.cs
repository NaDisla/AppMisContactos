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

        private void btnGuardarContacto_Clicked(object sender, EventArgs e)
        {
            Contactos nuevoContacto = new Contactos()
            {
                Nombre = txtNombre.Text,
                Apellido = txtApellido.Text,
                Correo = txtCorreo.Text,
                Telefono = txtTelefono.Text
            };

            using (var connection = new SQLiteConnection(App.dbRuta))
            {
                connection.CreateTable<Contactos>();
                connection.Insert(nuevoContacto);
            }
        }
    }
}