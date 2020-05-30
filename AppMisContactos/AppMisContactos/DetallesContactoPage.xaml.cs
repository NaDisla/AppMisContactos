using AppMisContactos.Clases;
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
    public partial class DetallesContactoPage : ContentPage
    {
        public Contactos Contacto { get; set; }
        public DetallesContactoPage(Contactos contacto)
        {
            InitializeComponent();
            Contacto = contacto;

            lblNombre.Text = $"{contacto.Nombre + " " + contacto.Apellido}";
            lblTelefono.Text = contacto.Telefono;
            lblCorreo.Text = contacto.Correo;
        }
    }
}