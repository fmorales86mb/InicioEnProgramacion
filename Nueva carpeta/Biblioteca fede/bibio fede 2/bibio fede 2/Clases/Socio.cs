using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bibio_fede_2 {
	public class Socio {
		public int SocioId;
		public string Nombre;
		public string Apellido;
		public DateTime FechaDeAlta;
		public DateTime FechaDeBaja;
		public bool Activo;

		public override string ToString () {
			string apellidoynombre;
			apellidoynombre = this.Apellido + ", " + this.Nombre;

			return apellidoynombre;
		}
	}
}
