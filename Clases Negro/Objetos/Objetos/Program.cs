using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/// <summary>
///  Tarea:
///  
/// </summary>


namespace Objetos {
    class Program  {
        static void Main(string[] args) {
			/*
			 * Ejemplo 1:

						// Aca estoy definiendo una referencia al objeto calculadora.
						Calculadora x1;
						Calculadora x2;

						// Aca estoy creando un objeto calculadora y estoy haciendo que x1 apunte a el.
						x1 = new Calculadora ();
						// x2 es otra referencia al objeto calculadora (x1 y x2 apuntan al mismo objeto)
						x2 = x1;
			*/

			ListaEnlazada3();

			System.Threading.Thread.Sleep(10000);
		}

		public static void ListaEnlazada3() {
			Nodo x;
			x = new Nodo();
			x.Dato = "0";
			x.Siguiente = new Nodo();
			Nodo ultimo;
			ultimo = x.Siguiente;

			for (int i = 1; i < 10; i++) {
				ultimo.Dato = i.ToString();
				ultimo.Siguiente = new Nodo();
				ultimo = ultimo.Siguiente;
			}	 
		}

		public static void ListaEnlazada2() {
			Nodo n;

			n = new Nodo();
			n.Dato = "uno";
			n.Siguiente = new Nodo();
			n.Siguiente.Dato = "dos";
		}

		public static void ListaEnlazada1() {
			Nodo primero;
			Nodo segundo;

			primero = new Nodo();
			segundo = new Nodo();

			primero.Dato = "Soy el primero";
			segundo.Dato = "Soy el segundo";

			primero.Siguiente = segundo;
		}

		public static void Diccionario() {
			Diccionario dic;

			dic = new Diccionario();

			dic.Agregar("libro", "objeto que contiene hojas bla");

			dic.Contar();
		}
    }

	/// Ejemplo Concreto
	/// 

	class Diccionario {
		public Diccionario() {
		}

		public Agregar(string clave, string valor) {
		}

		public int Contar() {
		}

		public void Borrar(string clave) {
		}

		public string Buscar(string clave) {
		}

		/// <summary>
		/// Tiene que imprimir toda la lista en pantalla.
		/// Console.WriteLine()
		/// 
		/// Formato:
		///		Clave -> Valor
		/// </summary>
		public void Imprimir() {
		}
	}

	class Nodo {
		public string Dato;
		public string Clave;
		public Nodo Siguiente;

		public Nodo() {
			this.Dato = "No inicializado";
			this.Siguiente = null;
		}
	}

	/// <summary>
	/// 
	/// Puntos a tener en cuenta:
	/// - Si vas a definir propiedades de la clase, entonces tenes que definir un constructor donde las inicialices
	/// 
	/// </summary>

	// 
	// Aca defino la clase calculadora, que es un nuevo tipo de datos. 
	// Ahora puedo definir objetos del tipo calculadora.
	//
    class Calculadora {
		// Esta es una propiedad de la clase.
        public int memoria;

		// Tengo la posibilidad de definir un constructor para mi clase.
		// Este metodo de la clase tiene el mismo nombre que la clase. Por eso se llama
		// constructor.
		public Calculadora() {
			Console.WriteLine("Ejecutando el constructor");
			this.memoria = 0;
		}

		/// <summary>
		/// Este es el destructor, se ejecuta cuando se destruye el objeto
		/// </summary>
		~Calculadora() {
			Console.WriteLine("Ejecutando el destructor");
		}

		// Esto es un metodo de la clase
        public int Sumar (int a, int b) {
			return a + b;
        }

		public int Restar(int a, int b) {
			return a - b;
		}
    }
}
