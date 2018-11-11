using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bibio_fede_2.Formularios {
	public partial class ABMAutor: Form {
		// Creo un puntero autor para el uso privado de la clase.
		private Autor MiAutor;

		// Constructor
		public ABMAutor () {
			InitializeComponent ();
		}

		/// <summary>
		/// Muestra el formulario con el autor del id que le pidamos o con uno nuevo si el id es cero.
		/// </summary>
		/// <param name="id"></param>
		public void MostrarFormulario (int id) {
			if (id != 0) {
				this.MiAutor = BDAutor.BuscarPorId (id);
				this.tbNombre.Text = this.MiAutor.Nombre;
				this.tbApellido.Text = this.MiAutor.Apellido;
				this.btnBorrar.Enabled = true;
			} else {
				this.MiAutor = new Autor ();
				this.tbNombre.Text = "";
				this.tbApellido.Text = "";
				this.btnBorrar.Enabled = false;
			}

			// Establezco el tipo de borde para que no pueda cambiarse el tamaño de la ventana.
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			//this.Show ();
			
			// Este show muestra la ventana pero no se puede usar las otras hasta cerrarla.
			this.ShowDialog ();
		}

		private void btnCerrar_Click (object sender, EventArgs e) {
			this.Close ();
		}

		private void btnBorrar_Click (object sender, EventArgs e) {
			// Esta función genera un mensaje de consulta "si o no". Hay otros tipos de mensajes.
			DialogResult dialogResult = MessageBox.Show ("Seguro desea borrar este autor?", "Alerta!!!", MessageBoxButtons.YesNo);

			if (dialogResult == DialogResult.Yes) {
				BDAutor.Borrar (MiAutor.AutorId);
				this.Close ();
			} else if (dialogResult == DialogResult.No) {
				//do something else
			}	
		}

		private void btnGuardar_Click (object sender, EventArgs e) {
			// Validaciones.
			if (this.tbApellido.Text == "") {
				MessageBox.Show ("Faltan completar campos");
				return;
			} else if (this.tbNombre.Text == "") {
				MessageBox.Show ("Faltan completar campos");
				return;
			} else if (this.tbNombre.Text.IndexOf ("'") >= 0 || this.tbApellido.Text.IndexOf ("'") >= 0) {
				MessageBox.Show ("No se puede ingresar '");
				return;
			}

			this.MiAutor.Nombre = this.tbNombre.Text;
			this.MiAutor.Apellido = this.tbApellido.Text;
			BDAutor.Guardar (MiAutor);
			this.Close ();
		}
	}
}
