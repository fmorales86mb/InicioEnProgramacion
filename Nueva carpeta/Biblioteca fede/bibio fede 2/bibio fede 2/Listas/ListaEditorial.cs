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
	public partial class ListaEditorial: Form {
		public ListaEditorial () {
			InitializeComponent ();
		}

		private void ListaEditorial_Load (object sender, EventArgs e) {
			DataTable tabla = BDEditorial.CargarTabla ();
			this.dgListaEditorial.DataSource = tabla;
		}

		private void dgListaEditorial_CellMouseDoubleClick (object sender, DataGridViewCellMouseEventArgs e) {
			int id;
			id = (int) this.dgListaEditorial.CurrentRow.Cells ["id"].Value;

			Formularios.ABMEditorial abm;
			abm = new Formularios.ABMEditorial ();
			abm.MostrarFormulario (id);
		}

		private void btnBuscar_Click (object sender, EventArgs e) {
			DataTable tabla;

			if (this.tbBuscar.Text.IndexOf ("'") >= 0) {
				MessageBox.Show ("El campo contiene valores inválidos");
				return;
			}

			tabla = BDEditorial.Buscar (this.tbBuscar.Text);
			this.dgListaEditorial.DataSource = tabla;
		}
	}
}
