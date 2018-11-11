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
    public partial class Profesional : Form {        
        
        public Profesional() {
            InitializeComponent();            
        }


        private void Profesional_Load(object sender, EventArgs e) {
            this.CargarTablaCompleta();
            this.Dock = DockStyle.Fill;
        }

        private void CargarTablaCompleta() {
            this.gvProfesional.DataSource = Logica.Profesional.TablaCompleta();            
        }

        private void gvProfesional_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
            ABMs.Profesional abm = new ABMs.Profesional();
            int id = (int) this.gvProfesional.CurrentRow.Cells[0].Value;

            abm.CargarAbm(id);
            this.gvProfesional.DataSource = Logica.Profesional.TablaCompleta();
        }
    }
}
