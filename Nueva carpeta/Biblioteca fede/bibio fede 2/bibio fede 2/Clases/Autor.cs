using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bibio_fede_2 {
	
	/// <summary>
	/// Clase Autor
	/// </summary>
	public class Autor {
		// Creo las variables de la clase.
		// Nota: Tiene que tener al menos los mismos campos y nombres que los que tiene en la tabla.
		public int AutorId;
		public string Nombre;
		public string Apellido;
		private string ApellidoYNombre;
			
		// Sobreescribo el TS para que el combo devuelva la variable que le indique.
		public override string ToString () {
			this.ApellidoYNombre = Apellido + ", " + Nombre;
			return this.ApellidoYNombre;
		}
	}
}
