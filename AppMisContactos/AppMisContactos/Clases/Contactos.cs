using System;
using System.Collections.Generic;
using System.Text;

namespace AppMisContactos.Clases
{
    public class Contactos
    {
		private string nombre;

		public string Nombre
		{
			get { return nombre; }
			set { nombre = value; }
		}

		private string apellido;

		public string Apellido
		{
			get { return apellido; }
			set { apellido = value; }
		}

		private string correo;

		public string Correo
		{
			get { return correo; }
			set { correo = value; }
		}

		private string telefono;

		public string Telefono
		{
			get { return telefono; }
			set { telefono = value; }
		}


	}
}
