using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bibio_fede_2 {

	/// <summary>
	/// Clase editorial.
	/// </summary>
	public class Editorial {
		// Variables de la clase.
		public int EditorialId;
		public string Nombre;
		public string Dirección;

		public override string ToString () {
			return this.Nombre;
		}
		
	}

	/*
	public class VistaEditorial {
		public string Nombre;
		public int EditorialId;

		public VistaEditorial (Editorial ed) {
			this.Nombre = ed.Nombre;
			this.EditorialId = ed.EditorialId;
		}

		public override string ToString () {
			return this.Nombre;
		}
	}
	 */ 
}
