using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Árbol___Estructura_de_datos {
	
	/// <summary>
	/// Estructura de todos los nodos.
	/// </summary>
	public class Nodo {
		
		// Creo las variables. Éstas son privadas ya que sólo las utilizará esta clase.
		public int Valor;
		public Nodo Mayor;
		public Nodo Menor;

		// Creo el constructor e inicializo las variables.
		public Nodo () {
			this.Valor = 0;
			this.Mayor = null;
			this.Menor = null;
		}

		// Creo los métodos de esta clase. En este caso no tengo métodos.

	}
}
