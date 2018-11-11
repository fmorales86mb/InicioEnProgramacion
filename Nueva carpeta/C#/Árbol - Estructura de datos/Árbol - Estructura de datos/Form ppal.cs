using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Árbol___Estructura_de_datos {
	
	// Calse Formulario
	public partial class Form1: Form {

		// Creo las variables.
		private Arbol EstructuraDatos;
		int Dato;

		// Constructor. Inicializo las variables de la clase.
		public Form1 () {
			InitializeComponent ();
			this.EstructuraDatos = new Arbol ();
			this.tbContador.Text = "0";
		}

		/// <summary>
		/// Cierra el formulario
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnCerrar_Click (object sender, EventArgs e) {
			this.Close ();

		}

		/// <summary>
		/// Ingresa el nro ingresado en el tb a la estructura de datos y actualiza el tbContador.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnIngresar_Click(object sender, EventArgs e) {

			if (int.TryParse (this.tbdato.Text , out this.Dato)) {
 				if (this.EstructuraDatos.Agregar(this.Dato) == true) {
					this.tbdato.Text = "";
					this.tbContador.Text = this.EstructuraDatos.Contador().ToString ();
				} else {
					MessageBox.Show ("Número repetido");
				}
			}
		}

		/// <summary>
		/// Busca el nro del tb en la estructrua de datos
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnBuscar_Click(object sender, EventArgs e) {
			
			int i;

			if (int.TryParse (this.tbdato.Text, out this.Dato)){
				if (this.EstructuraDatos.Buscar (this.Dato) == true){
					i = this.EstructuraDatos.Nivel ();
					MessageBox.Show ("Numero encontrado en nivel " + i);
				} else {
					MessageBox.Show ("Numero NO encontrado.");
				}
			}

		}

		private void btnEliminar_Click(object sender, EventArgs e) {

			if (int.TryParse(this.tbdato.Text, out this.Dato)) {
				if (this.EstructuraDatos.Eliminar(this.Dato)) {
					this.tbContador.Text = this.EstructuraDatos.Contador().ToString();
					MessageBox.Show("Elemento eliminado");
				} else {
					MessageBox.Show("Este elemento no está ingresado");
				}
			}
		}
	}
}
