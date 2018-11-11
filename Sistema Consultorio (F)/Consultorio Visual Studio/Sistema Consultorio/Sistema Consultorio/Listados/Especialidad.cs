using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Consultorio.Listados {
    public partial class Especialidad : Form {

        public Especialidad() {
            InitializeComponent();
        }

        private void Especialidad_Load(object sender, EventArgs e) {
            this.CargarTablaCompleta();
            this.Dock = DockStyle.Fill;
        }

        private void CargarTablaCompleta() {
            this.gvEspecialidad.DataSource = Logica.Especialidad.TablaCompleta();
            this.gvEspecialidad.Columns[0].Visible = false;
        }

        private void gvEspecialidad_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
            int id = (int) this.gvEspecialidad.CurrentRow.Cells[0].Value;

            AbmEspecialidad abm = new AbmEspecialidad();
            abm.CargarAbm(id);
        }
    }
}
