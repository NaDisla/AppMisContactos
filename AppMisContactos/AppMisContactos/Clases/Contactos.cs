using System;
using System.Collections.Generic;
using System.Text;

namespace AppMisContactos.Clases
{
    public class Contactos
    {
		private int id;

		public int Id
		{
			get { return id; }
			set { id = value; }
		}

		private string nombreContacto;

		public string NombreContacto
		{
			get { return nombreContacto; }
			set { nombreContacto = value; }
		}

		private string apellidoContacto;

		public string ApellidoContacto
		{
			get { return apellidoContacto; }
			set { apellidoContacto = value; }
		}

		private string correoContacto;

		public string CorreoContacto
		{
			get { return correoContacto; }
			set { correoContacto = value; }
		}

		private string telefonoContacto;

		public string TelefonoContacto
		{
			get { return telefonoContacto; }
			set { telefonoContacto = value; }
		}


	}
}
