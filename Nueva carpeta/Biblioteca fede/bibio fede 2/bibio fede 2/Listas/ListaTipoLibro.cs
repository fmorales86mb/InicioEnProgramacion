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
	public partial class ListaTipoLibro: Form {
		public ListaTipoLibro () {
			InitializeComponent ();
		}

		private void ListaTipoLibro_Load (object sender, EventArgs e) {
			DataTable tabla;
			tabla = BDTipoLibro.CargarTabla ();

			dgListaTipoLibro.DataSource = tabla;
		}

		private void dgListaTipoLibro_CellDoubleClick (object sender, DataGridViewCellEventArgs e) {
			int id;
			id = (int) this.dgListaTipoLibro.CurrentRow.Cells ["id"].Value;

			Formularios.ABMTipoLibro abm;
			abm = new Formularios.ABMTipoLibro ();
			abm.MostrarFormulario (id);
		}
	}
}
