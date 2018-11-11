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
	public partial class ABMBiblioteca: Form {
		// Variable de la clase. ¿Antes o después del constructor? Antes y en mayúscula, para encontrarla fácil.
		private Biblioteca Biblio;

		// Constructor.
		public ABMBiblioteca () {
			InitializeComponent ();
		}

		public void MostrarFormulario (int id) {
			if (id == 0) {
				this.Biblio = new Biblioteca ();
				this.tbNombre.Text = "";
				this.tbDescripcion.Text = "";
				// Habilita o desabilita el btn.
				this.btnBorrar.Enabled = false;
			} else {
				this.Biblio = BDBiblioteca.BuscarPorId (id);
				this.tbNombre.Text = this.Biblio.Nombre;
				this.tbDescripcion.Text = this.Biblio.Descripcion;
				this.btnBorrar.Enabled = true;
			}

			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.ShowDialog ();
		}

		private void btnCerrar_Click (object sender, EventArgs e) {
			this.Close ();
		}

		private void btnBorrar_Click (object sender, EventArgs e) {
			// Creo una variable que guarda la respuesta del cuadro de diálogo.
			DialogResult consulta;
			consulta = MessageBox.Show ("Seguro desea borrar esta Biblioteca?", "Ey!", MessageBoxButtons.YesNo);

			// Resuelvo según haya respondido el usuario.
			if (consulta == DialogResult.Yes) {
				BDBiblioteca.Borrar (this.Biblio.BibliotecaId);
				this.Close ();
			} else if (consulta == DialogResult.No) {
				
			}	
		}

		private void btnGuardar_Click (object sender, EventArgs e) {
			// Validaciones.
			if (this.tbNombre.Text == "") {
				MessageBox.Show ("Faltan completar campos");
				return;
			} else if (this.tbNombre.Text.IndexOf ("'") >= 0) {
				MessageBox.Show ("No se puede ingresar '");
				return;
			}

			this.Biblio.Nombre = this.tbNombre.Text;
			this.Biblio.Descripcion = this.tbDescripcion.Text;
			BDBiblioteca.Guardar (Biblio);
			this.Close ();
		}
	}
}
