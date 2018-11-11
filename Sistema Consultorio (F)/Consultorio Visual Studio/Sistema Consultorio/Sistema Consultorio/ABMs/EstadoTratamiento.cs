using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Consultorio.ABMs {
    public partial class EstadoTratamiento : Form {

        Entidades.EstadoTratamiento ObjEstadoTratamiento;

        public EstadoTratamiento() {
            InitializeComponent();
        }

        public void CargarAbm(int id) {
            this.ObjEstadoTratamiento = new Entidades.EstadoTratamiento();

            if (id == 0) {
                this.btnBorrar.Enabled = false;
            } else {
                this.btnBorrar.Enabled = true;
                this.ObjEstadoTratamiento = Logica.EstadoTratamiento.BuscarPorId(id);
                this.tbNombre.Text = this.ObjEstadoTratamiento.Nombre;
                this.tbDescripcion.Text = this.ObjEstadoTratamiento.Descripcion;
            }

            this.ShowDialog();
        }

        private void btnCerrar_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e) {
            this.ObjEstadoTratamiento.Nombre = this.tbNombre.Text;
            this.ObjEstadoTratamiento.Descripcion = this.tbDescripcion.Text;
            Logica.EstadoTratamiento.GuardarNuevo(this.ObjEstadoTratamiento);
            this.Close();
        }
    }
}
