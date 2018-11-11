using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Cambio el "Dock" del dg en el disañador o por el código para que se adapte a la ventana.
// Para que el dg no quede solapado al panel, creo otro panel en el que meto al dg. Entre los paneles no se solapan.

namespace bibio_fede_2.Listas {
	public partial class ListaAutor: Form {
		DataTable Tabla;

		public ListaAutor () {
			InitializeComponent ();
		}

		private void ListaAutor_Load (object sender, EventArgs e) {
			this.Tabla = BDAutor.CargarTabla ();
			this.dgListaAutor.DataSource = this.Tabla;
		}

		private void dgListaAutor_CellDoubleClick (object sender, DataGridViewCellEventArgs e) {
			int id;
			id = (int) this.dgListaAutor.CurrentRow.Cells ["id"].Value;

			Formularios.ABMAutor abm;
			abm = new Formularios.ABMAutor ();
			abm.MostrarFormulario (id);

            this.Tabla = BDAutor.Buscar (this.tbBuscar.Text);
			this.dgListaAutor.DataSource = this.Tabla;
        }

		private void btnBuscar_Click (object sender, EventArgs e) {
			if (this.tbBuscar.Text.IndexOf ("'") >= 0) {
				MessageBox.Show ("El campo no puede contener '");
				return;
			}
			this.Tabla = BDAutor.Buscar (this.tbBuscar.Text);
			this.dgListaAutor.DataSource = this.Tabla;
		}

		private void btnActualizar_Click (object sender, EventArgs e) {
			this.Tabla = BDAutor.CargarTabla ();
			this.dgListaAutor.DataSource = this.Tabla;
		}
	}
}
