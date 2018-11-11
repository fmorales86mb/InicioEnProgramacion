using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Consultorio {
    public partial class FormularioPrincipal : Form {
        public FormularioPrincipal() {
            InitializeComponent();
        }

        // btn cerrar
        private void menuArchivoSalir_Click(object sender, EventArgs e) {
            this.Close();
        }

        // listado especialidad
        private void especialidadToolStripMenuItem_Click(object sender, EventArgs e) {
            Listados.Especialidad listaEspecialidad = new Listados.Especialidad();
            listaEspecialidad.MdiParent = this;
            listaEspecialidad.Show();
        }

        // abm especialidad
        private void menuNuevoEspecialidad_Click(object sender, EventArgs e) {
            AbmEspecialidad abm = new AbmEspecialidad();
            abm.CargarAbm(0);
        }

        // abm profesional
        private void profesionalToolStripMenuItem_Click(object sender, EventArgs e) {
            ABMs.Profesional abm = new ABMs.Profesional();
            abm.CargarAbm(0);
        }

        // listado profesional
        private void profecionalToolStripMenuItem_Click(object sender, EventArgs e) {
            Listados.Profesional ListaProfesional = new Listados.Profesional();
            ListaProfesional.MdiParent = this;
            ListaProfesional.Show();
        }

        // abm estadoTratamiento
        private void estadoDelTratamientoToolStripMenuItem_Click(object sender, EventArgs e) {
            ABMs.EstadoTratamiento abm = new ABMs.EstadoTratamiento();
            abm.CargarAbm(0);
        }


    }
}
