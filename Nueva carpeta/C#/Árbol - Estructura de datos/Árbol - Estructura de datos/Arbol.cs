using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Error en el método agregar. No se crea el árbol.

namespace Árbol___Estructura_de_datos {
	
	/// <summary>
	/// Clase Árbol.
	/// </summary>
	public class Arbol {

		// Creo las variables de la clase.

		/// <summary>
		/// Es el puntero inicial.
		/// </summary>
 		private Nodo Raiz;
		/// <summary>
		/// Es el nro de nodos que hay.
		/// </summary>
		private int Cantidad;
		/// <summary>
		/// Es el nivel en el que está determinado nodo buscado.
		/// </summary>
		private int Altura;

		// Creo al constructor e inicializo las variables.
		public Arbol () {
			this.Raiz = null;
			this.Cantidad = 0;
			this.Altura = 0;
		}

		// Ahora creo los métodos de la clase: Agregar, Buscar, Eliminar y Contador.

		
		/// <summary>
		/// Agrega el número ingresado al Arbol.
		/// </summary>
		/// <param name="numero"> número ingresado </param>
		/// <returns> true si lo agregó, false si no lo agregó </returns>
		public bool Agregar (int numero){

			// Creo las variables del método.
			bool repetido;
			Nodo nuevo;
			int i;

			// Inicilizo las variables del método.
			repetido = true;
			nuevo = null;

			// Caso inicial. 
			if (this.Raiz == null) {

				this.Raiz = new Nodo();
				this.Raiz.Valor = numero;
				this.Cantidad = this.Cantidad + 1;
				repetido = false;

			// Resto de los casos
			} else {
				nuevo = this.Raiz;

				for (i = 0; i < this.Cantidad && repetido == true; i++) {

					// Acá chequeo que el número ingresado no esté repetido.
					if (numero != nuevo.Valor) {

						// Chequeo que sea menor.
						if (numero < nuevo.Valor) {
							if (nuevo.Menor == null) {
								nuevo.Menor = new Nodo();
								nuevo = nuevo.Menor;
								nuevo.Valor = numero;
								this.Cantidad = this.Cantidad + 1;
								repetido = false;
							} else {
								nuevo = nuevo.Menor;
							}

						// Si no es igual ni menor, entonces es mayor. 
						} else {
							if (nuevo.Mayor == null) {
								nuevo.Mayor = new Nodo();
								nuevo = nuevo.Mayor;
								nuevo.Valor = numero;
								this.Cantidad = this.Cantidad + 1;
								repetido = false;
							} else {
								nuevo = nuevo.Mayor;
							}
						}
					}
				}
			}

			// Resuelvo el booleano que devuelve la función a partrir de el bool "repetido".
			if (repetido == false) {
				return true;
			} else {
				return false;
			}
		}

		/// <summary>
		/// Busca el número ingresado y si se encuentra determina su nivel. 
		/// VER SI PUEDO DEVOLVER MÁS DE UNA VARIABLE O EN TODO CASO IMPLEMENTAR QUE SE DEVUELVA LA CANTIDAD DE BUSQUEDAS QUE HIZO (SE PODRIA LLAMAR ALTURA DESDE LA RAIZ. RAIZ = 1). 
		/// VER CONVENIENCIA DE HACER UNA CLASE QUE ENGLOBE LOS METODOS Y LUEGO DEVOLVER UN OBJETO DE LA CLASE.
		/// </summary>
		/// <param name="numero"> número ingresado </param>
		/// <returns>devuelve un nro que representa la cant de búsquedas que hizo.</returns>
		public bool Buscar (int numero) {

			// Creo las variables de la función.
			Nodo nuevo;
			bool encontrado;
			int i;

			nuevo = null;
			encontrado = false;
			i = 0; 

			// Corroboro que haya algún dato ingresado.
			if (this.Raiz != null) {

				// Chequeo los nodos realizando el camino que haría el nro buscando si lo quisiera ingresar.
				nuevo = this.Raiz;
				// El recorrido del for se corta:
				// cuando "encontrado" es true o cuando "nuevo" es null (lo que significa que está en una hoja). 
				for (i = 0; encontrado == false && nuevo != null; i++ ) {
					if (nuevo.Valor == numero) {
						encontrado = true;
					} else {
						if (numero < nuevo.Valor) {
							nuevo = nuevo.Menor;
						} else {
							nuevo = nuevo.Mayor;
						}
					}
				}
			}
			
			// resulevo el booleano devuelto por la función a partir del bool encontrado.
			if (encontrado == true) {
				// Sólo actualizo "Altura" si encuentro el nodo.
				this.Altura = i;
				return true;
			} else {
				return false;
			}
		}

		/// <summary>
		/// Sólo devuelve "this.Altura", el nivel al que se encuentra el nro buscado. Se ejecuta sólo cuando se busca un nro.
		/// </summary>
		/// <returns> Altura </returns>
		public int Nivel() {
			return this.Altura;
		}

		/// <summary>
		/// Elimina el número ingresado.
		/// </summary>
		/// <param name="numero"> número ingresado </param>
		/// <returns></returns>
		public bool Eliminar (int numero) {

			bool encontrado;
			bool mayor;
			Nodo nuevo;
			Nodo buscador;

			encontrado = false;
			mayor = false;
			nuevo = null;
			buscador = null;

			// Primer paso: busco el nodo con el nro.

			// Chequeo que haya nros ingresados.
			if (this.Raiz != null) {

				// Primer caso (la raíz es el nodo buscado): sale encontrado=true, buscador=null.
				if (numero == this.Raiz.Valor) {
					encontrado = true;
				} else {
					buscador = this.Raiz;

					for (; encontrado == false && buscador != null; ) {
						// Segundo caso: sale encontrado=true, mayor=false.
						if (numero < buscador.Valor) {
							if (buscador.Menor != null && buscador.Menor.Valor == numero) {
								encontrado = true;
								mayor = false;
							} else {
								buscador = buscador.Menor;
							}
						} else {
							// Tercer caso: sale encontrado=true, mayor=true.
							if (buscador.Mayor != null && buscador.Mayor.Valor == numero) {
								encontrado = true;
								mayor = true;
							} else {
								buscador = buscador.Mayor;
							}
						}
					}
				}
			}

			// Resuelvo según si lo encontré o no.

			if (encontrado) {
				// Primer caso.
				if (buscador == null) {

					if (this.Raiz.Mayor != null) {
						if (this.Raiz.Menor != null) {
							nuevo = this.Raiz.Mayor;
							for (; nuevo.Menor != null; ) {
								nuevo = nuevo.Menor;
							}
							nuevo.Menor = this.Raiz.Menor;
							this.Raiz = this.Raiz.Mayor;
						} else {
							this.Raiz = this.Raiz.Mayor;
						}
					} else {
						if (this.Raiz.Menor != null) {
							this.Raiz = this.Raiz.Menor;
						} else {
							this.Raiz = null;
						}
					}
				} else {

					// Segundo caso.
					if (mayor == false) {

						if (buscador.Menor.Mayor != null) {
							if (buscador.Menor.Menor != null) {
								nuevo = buscador.Menor.Mayor;
								for (; nuevo.Menor != null; ) {
									nuevo = nuevo.Menor;
								}
								nuevo.Menor = buscador.Menor.Menor;
								buscador.Menor = buscador.Menor.Mayor;
							} else {
								buscador.Menor = buscador.Menor.Mayor;
							}
						} else {
							if (buscador.Menor.Menor != null) {
								buscador.Menor = buscador.Menor.Menor;
							} else {
								buscador.Menor = null;
							}
						}

						// Tercer caso.
					} else {

						if (buscador.Mayor.Mayor != null) {
							if (buscador.Mayor.Menor != null) {
								nuevo = buscador.Mayor.Mayor;
								for (; nuevo.Menor != null; ) {
									nuevo = nuevo.Menor;
								}
								nuevo.Menor = buscador.Mayor.Menor;
								buscador.Mayor = buscador.Mayor.Mayor;
							} else {
								buscador.Mayor = buscador.Mayor.Mayor;
							}
						} else {
							if (buscador.Mayor.Menor != null) {
								buscador.Mayor = buscador.Mayor.Menor;
							} else {
								buscador.Mayor = null;
							}
						}
					}
				}

				// Actualizo la cantidad de nodos.
				this.Cantidad = this.Cantidad - 1;
				return true;

			// Si no lo encontré.
			} else {
				return false;
			}
		}
		


			/*
			bool encontrado;
			bool mayor;
			Nodo nuevo;
			Nodo buscador;

			encontrado = false;
			mayor = false;
			nuevo = null;
			buscador = null;

			// Chequeo que haya nros ingresados.
			if (this.Raiz != null) {
				// Primer caso. Raíz tiene al nro, sale con: encontrado=true, buscador=null.
				if (this.Raiz.Valor == numero) {
					encontrado = true;
				} else {
					buscador = this.Raiz;

					for (; encontrado == false && buscador != null; ) {

						// Segundo caso. Si es menor sale: encontrado=true, mayor=false / encontrado=false, buscador=null.
						if (numero < buscador.Valor) {
							if (buscador.Menor != null && numero == buscador.Menor.Valor) {
								encontrado = true;
								mayor = false;
							} else {
								buscador = buscador.Menor;
							}

						// Tercer caso. Si es mayor sale: encontrado=true, mayor=true / encontrado=false, buscador=null.
						} else {
							if (buscador.Mayor != null && numero == buscador.Mayor.Valor) {
								encontrado = true;
								mayor = true;
							} else {
								buscador = buscador.Mayor;
							}
						}
					}
				}
			}

			if (encontrado) {
				// Primer caso.
				if (buscador == null) {

					if (this.Raiz.Menor == null) {
						// Caso en el que sólo existe la Raíz.
						if (this.Raiz.Mayor == null) {
							this.Raiz = null;
							// Caso en el que sólo existe raiz.mayor.
						} else {
							this.Raiz = this.Raiz.Mayor;
						}
					} else {
						// Caso en el que sólo existe raiz.menor.
						if (this.Raiz.Mayor == null) {
							this.Raiz = this.Raiz.Menor;

							// Caso en el que Mayor y Menor existan.
						} else {
							nuevo = this.Raiz;
							nuevo.Valor = nuevo.Menor.Valor;

							for (; nuevo.Menor.Menor != null; ) {
								nuevo.Menor.Valor = nuevo.Menor.Menor.Valor;
								nuevo = nuevo.Menor;
							}
							if (nuevo.Menor.Mayor == null) {
								nuevo.Menor = null;
							} else {
								nuevo.Menor = nuevo.Menor.Mayor;
							}
						}
					}
				} else {
					// Segundo caso.
					if (mayor == false) {
						nuevo = buscador;

						if (nuevo.Menor.Menor != null) {

							for (; nuevo.Menor.Menor != null; ) {
								nuevo.Menor.Valor = nuevo.Menor.Menor.Valor;
								nuevo = nuevo.Menor;
							}
							if (nuevo.Menor.Mayor == null) {
								nuevo.Menor = null;
							} else {
								nuevo.Menor = nuevo.Menor.Mayor;
							}
						} else {
							// Este caso es si el nodo justo es una hoja. 
							if (nuevo.Menor.Mayor == null){
								nuevo.Menor = null;
							} else {
								nuevo.Menor = nuevo.Menor.Mayor;
							}
						}

					// Tercer caso.
					} else {
						nuevo = buscador;

						if (nuevo.Mayor.Mayor != null) {

							for (; nuevo.Mayor.Mayor != null; ) {
								nuevo.Mayor.Valor = nuevo.Mayor.Mayor.Valor;
								nuevo = nuevo.Mayor;
							}

							if (nuevo.Mayor.Menor == null) {
								nuevo.Mayor = null;
							} else {
								nuevo.Mayor = nuevo.Mayor.Menor;
							}
						} else {
							// Caso de que sea una hoja.
							if (nuevo.Mayor.Menor == null) {
								nuevo.Mayor = null;
							} else {
								nuevo.Mayor = nuevo.Mayor.Menor;
							}
						}
					}
				}
				this.Cantidad = this.Cantidad - 1;
				return true;
			// No encontrado.
			} else {
				return false;
			}
			*/
		

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ordenador"></param>
		private void reordenador (Nodo recibido, bool mayor){
			
		}

		/// <summary>
		/// Devuelve la cantidad de números ingresados.
		/// </summary>
		/// <returns> this.cantidad </returns>
		public int Contador () {
			return this.Cantidad;
			
		}
	}
}
