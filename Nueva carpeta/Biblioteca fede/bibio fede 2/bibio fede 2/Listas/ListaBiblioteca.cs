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
	public partial class ListaBiblioteca: Form {
		public ListaBiblioteca () {
			InitializeComponent ();
		}

		private void ListaBiblioteca_Load (object sender, EventArgs e) {
			DataTable tabla;
			tabla = BDBiblioteca.CargarTabla ();

			dgListaBiblioteca.DataSource = tabla;
		}

		private void dgListaBiblioteca_KeyDown (object sender, KeyEventArgs e) {
			int i;

			if (e.KeyValue == 13) {
			}
		}

		private void dgListaBiblioteca_CellDoubleClick (object sender, DataGridViewCellEventArgs e) {
			int id;
			id = (int) this.dgListaBiblioteca.CurrentRow.Cells ["id"].Value;

			Formularios.ABMBiblioteca abm;
			abm = new Formularios.ABMBiblioteca ();
			abm.MostrarFormulario (id);
		}

		private void btnBuscar_Click (object sender, EventArgs e) {
			DataTable tabla;

			if (this.tbBuscar.Text.IndexOf ("'") >= 0) {
				MessageBox.Show ("El campo contiene valores inválidos");
				return;
			}

			tabla = BDBiblioteca.Buscar (this.tbBuscar.Text);
			this.dgListaBiblioteca.DataSource = tabla;
		}
	}
}
