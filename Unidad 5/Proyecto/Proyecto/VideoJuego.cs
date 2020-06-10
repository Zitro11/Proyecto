using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;

namespace Proyecto
{
	//creacion del delegado
	public delegate void MiDelegado(String Nombre);

    class VideoJuego
    {
		//creacion del evento
		public event MiDelegado Aviso;

		private string _strNombre = "";

		public string Nombre
		{
			get { return _strNombre; }
			set { _strNombre = value; }
		}

		private string _strCampaña;

		public string Campaña
		{
			get { return _strCampaña; }
			set { _strCampaña = value; }
		}

		private string _strMultijugador;

		public string Multijugador
		{
			get { return _strMultijugador; }
			set { _strMultijugador = value; }
		}

		private string _strTipoJuego;

		public string TipoJuego
		{
			get { return _strTipoJuego; }
			set { _strTipoJuego = value; }
		}

		private string _strPlataforma;

		public string Plataforma
		{
			get { return _strPlataforma; }
			set { _strPlataforma = value; }
		}
		private string _strEdad;

		public string Edad
		{
			get { return _strEdad; }
			set { _strEdad = value; }
		}

		private string _strCompañia;

		public string Compañia
		{
			get { return _strCompañia; }
			set { _strCompañia = value; }
		}

		private string _strDireccion;

		public string Direccion
		{
			get { return _strDireccion; }
			set
			{
				_strDireccion = value;
				Aviso(Nombre); //invocando el evento
			}
		}

	}
}
