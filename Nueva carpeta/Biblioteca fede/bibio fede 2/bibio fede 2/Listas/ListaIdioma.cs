using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bibio_fede_2.Listas {
	public partial class ListaIdioma: Form {
		public ListaIdioma () {
			InitializeComponent ();
		}

		private void ListaIdioma_Load (object sender, EventArgs e) {
			DataTable tabla;
			tabla = BDIdioma.CargarTabla ();

			dgListaIdioma.DataSource = tabla;
		}

		private void dgListaIdioma_CellDoubleClick (object sender, DataGridViewCellEventArgs e) {
			// Forma de obtener el valor de una determinada celda en una fila seleccionada.
			int id;
			id = (int) this.dgListaIdioma.CurrentRow.Cells ["id"].Value;

			Formularios.ABMIdioma abm;
			abm = new Formularios.ABMIdioma ();

			abm.MostrarFormulario (id);
		}

		private void btnBuscar_Click (object sender, EventArgs e) {
			DataTable tabla;
			tabla = BDIdioma.Buscar (this.tbBuscar.Text);
			dgListaIdioma.DataSource = tabla;
		}
	}
}
