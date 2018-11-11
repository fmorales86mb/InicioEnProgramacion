using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/// <summary>
/// - Agregar siempre un comentario por funcion.
/// Tarea:
    
namespace WindowsFormsApplication1 {
	// Creo la clase formulario
	public partial class frmDiccionario : Form 	{
        // creo un puntero a un objeto diccionario
		private Diccionario dic;

		//constructor
		public frmDiccionario() {
			InitializeComponent();
			
			//Dentro del constructor inicializo las propiedades del formulario 
            this.dic = new Diccionario ();
			this.tbCantidad.Text = "0";
		}

		
		private void btnCerrar_Click(object sender, EventArgs e) {
			this.Close ();
		}

        private void btnBuscar_Click(object sender, EventArgs e) {
			if (this.dic.Buscar (this.tbPalabra.Text) == null) {
				MessageBox.Show ("Palabra NO encontrada");
				this.tbDescripcion.Text = null;
			} else {
				string def;
				def = this.dic.Buscar (this.tbPalabra.Text);
				this.tbDescripcion.Text = def;
			}
        }

        private void btnAgregar_Click(object sender, EventArgs e) {

			if (this.dic.Agregar (this.tbPalabra.Text, this.tbDescripcion.Text) == true){
				MessageBox.Show ("Palabra agregada con éxito");
				this.tbDescripcion.Text = null;
				this.tbPalabra.Text = null;
				this.tbCantidad.Text = this.dic.Cantidad.ToString ();
			} else {
				MessageBox.Show ("Esta palabra ya existe");
				this.tbDescripcion.Text = null;
			}
        }

		private void btnEliminar_Click(object sender, EventArgs e) {
			// Al poner la condición en el if, se ejecuta la función y luego se evalua. Es decir que la función queda ejecutada. (la palabra se borra)
			if (this.dic.Borrar (this.tbPalabra.Text) == true) {
				MessageBox.Show ("Palabra eliminada con éxito");
				this.tbPalabra.Text = null;
				this.tbDescripcion.Text = null;
				this.tbCantidad.Text = this.dic.Cantidad.ToString ();
				
			} else {
				MessageBox.Show ("Palabra NO encontrada");
				this.tbDescripcion.Text = null;
			}
		}

		private void btnModificar_Click (object sender, EventArgs e) {
			if (this.dic.Modificar (this.tbPalabra.Text, this.tbDescripcion.Text) == true) {
				MessageBox.Show ("Definición modificada");
			}
		}
    }

    // Creo una nueva clase. Luego voy a utilizarla en otra clase más abajo.
    class Nodo {
        
        // Primero creo las propiedades o variables. "siguiente" es un puntero a un objeto de la clase nodo.
        public string Palabra;
        public string Definicion;
        public Nodo Siguiente;

        // Luego creo al constructor e inicializo las variables.
        public Nodo () {
            this.Palabra = "";
            this.Definicion = "";
            this.Siguiente = null;
        }
        
        // Por último creo los métodos o funciones. En este caso no tengo funciones.

    }
    
    // Nueva clase.
    class Diccionario {
        // creo las propiedades o variables. "Nodo" es un objeto de la clase "Nodo" que creé más arriba.
        private Nodo Primero;
        private int Cantidad;

        // Creo el constructor y dentro de él inicializo las variables.
        public Diccionario () {
            this.Primero = null;
            this.Cantidad = 0;
        }

        // Ahora implemento los métodos o funciones.

        // Agrega una palabra y su definicion al diccionario. Si lo pudo agregar devuelve true, sino false.
        public bool Agregar (string clave, string valor) {
            Nodo nuevo;
            int i;
            bool esRepetido = false;

			// Caso primero. Sólo si no hay palabras ya ingresadas.
            if (this.Cantidad == 0) {
                this.Primero = new Nodo();
                this.Primero.Palabra = clave;
                this.Primero.Definicion = valor;
                this.Cantidad = 1;

            } else {
                nuevo = this.Primero;
                // chequea que el primero no sea el repetido
                if (nuevo.Palabra == clave) {
                    esRepetido = true;
                }

                // Corta si i llego a la cantidad y si encontro un repetido antes
                for (i = 1; i < this.Cantidad && !esRepetido; i++) {
                    nuevo = nuevo.Siguiente;

                    // Chequea que no haya repetidos en los siguientes
                    if (nuevo.Palabra == clave) {
                        esRepetido = true;
                    }
                }

                // Solo agrega el nodo si no hay repetidos y actualiza "cantidad".
                if (!esRepetido) {
                    nuevo.Siguiente = new Nodo ();
                    nuevo = nuevo.Siguiente;
                    nuevo.Palabra = clave;
                    nuevo.Definicion = valor;

                    this.Cantidad = this.Cantidad + 1;
                }
            }

            if (esRepetido) {
                return false;

            } else {
                return true;
            }

        }
        

        /// <summary>
        ///  Borra un elemento de la lista
        /// </summary>
        /// <param name="clave"></param>
		public bool Borrar(string clave) {
			
			// Creo las variables.
			int i;
			Nodo nuevo;
			nuevo = this.Primero;
			bool detectado;
			detectado = false;

			if (this.Cantidad != 0) {

				// Compruebo el primer nodo
				if (nuevo.Palabra == clave) {
					detectado = true;
				} else {


                    //ERR: Si hay una sola palabra pincha.

					// Compruebo el segundo nodo
					if (nuevo.Siguiente != null && nuevo.Siguiente.Palabra == clave) {
						detectado = true;
					}

					// Este for comprueba los siguientes de cada nodo empezando por el siguiente del segundo.
					for (i = 1; i < this.Cantidad && !detectado; i++) {
						nuevo = nuevo.Siguiente;

						// Tengo que corroborar que el siguiente exista, sino puede tirar error. Si el siguiente no existe es que ya comprobé todos.
						if (nuevo.Siguiente != null) {
							if (nuevo.Siguiente.Palabra == clave) {
								detectado = true;
							}
						}
					}
				}
			}

			// Hago que el puntero que va al q quiero borrar lo saltee y vaya al siguiente. Con esto el nodo que quiero borrar ya no tiene puntero que lo marque 
			// y queda en el limbo.
			if (detectado) {
				// En el caso puntual de que el nodo detectado sea el primero, resuelvo para que primero no desaparezca. Igual no sé si es necesario, desaparece???
				if (nuevo == this.Primero && this.Primero.Palabra == clave) {
					this.Primero = this.Primero.Siguiente;

				} else {
					nuevo.Siguiente = nuevo.Siguiente.Siguiente;
				}

				this.Cantidad = this.Cantidad - 1;
				return true;

			} else {
				return false;
			}
		}

		/// <summary>
        /// Devuelve la cantidad de elementos de la lista
        /// </summary>
        public int CantidadDeElementos()
        {
            return (this.Cantidad);
        }
        
        /// <summary>
        /// Recibe una clave y tiene que devolver el valor
        /// </summary>
        /// <param name="clave">Clave tiene que ser una clave ya ingresada. es un string</param>
        /// <returns>Devuelve la propiedad Descripcion de la palabra buscada, o null si no encontro la palabra</returns>
        public string Buscar (string clave) {
            Nodo nuevo;
            string ret = null;

            if (Cantidad > 0) {
                nuevo = this.Primero;
                for (int i = 0; i < this.Cantidad; i++) {
                    if (nuevo.Palabra == clave) {
                        ret = nuevo.Definicion;

                        // Break sirve para salir del ciclo en el que esta metido (el for). Termina el ciclo
                        break;
                    }

                    nuevo = nuevo.Siguiente;
                }
            }

            return ret;
        }

        /// <summary>
        ///  Busca el elemento y si lo encuentra lo modifica.
        /// </summary>
        /// <param name="clave"></param>
        /// <param name="valor"></param>
        /// 
        public bool Modificar (string clave, string valor) {
			bool Encontrado;
            int i;

            Encontrado = false;
			Nodo nuevo;
			nuevo = this.Primero;
			
			// Corroboro que haya palabras ingresadas para evitar que salte un error.
			if (this.Cantidad != 0) {

				// Pruebo con la primer palabra.
				if (nuevo.Palabra == clave) {
					Encontrado = true;
				}

				// Acá corroboro el resto comenzando por la segunda palabra (ya que la primera ya fue chequeada).
				for (i = 1; i < this.Cantidad && Encontrado == false; i++) {
					// Con este método el proceso se frena cuando encuentro el nodo correcto que queda igual a "nuevo". 
					nuevo = nuevo.Siguiente;
					if (nuevo.Palabra == clave) {
						Encontrado = true;
					}
				}
			}

			if (Encontrado == true) {
				nuevo.Definicion = valor;
				return true;
			} else {
				return false;
			}
		}
    }
}
