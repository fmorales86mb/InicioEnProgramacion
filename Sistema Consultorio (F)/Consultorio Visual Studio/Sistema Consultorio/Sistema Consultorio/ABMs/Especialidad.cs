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
    public partial class AbmEspecialidad : Form {

        Entidades.Especialidad ObjEntidadesEspecialidad;

        public AbmEspecialidad() {
            InitializeComponent();
            this.tbNombre.Text = "";
            this.tbDescripcion.Text = "";
            this.btnBorrar.Enabled = false;
        }

        private void btnCerrar_Click(object sender, EventArgs e) {
            this.Close();
        }

        /// <summary>
        /// Carga el abm y lo muestra.
        /// </summary>
        /// <param name="id">Menor a cero para cargar en blanco.</param>
        public void CargarAbm(int id) {
            if (id == 0) {

            } else {
                this.btnBorrar.Enabled = true;

                this.ObjEntidadesEspecialidad = Logica.Especialidad.BuscarPorId(id);

                this.tbNombre.Text = ObjEntidadesEspecialidad.Nombre;
                this.tbDescripcion.Text = ObjEntidadesEspecialidad.Descripcion;                
            }

            this.ShowDialog();
            
        }

        private void AbmEspecialidad_Load(object sender, EventArgs e) {

        }

        private void btnGuardar_Click(object sender, EventArgs e) {
            if (this.tbNombre.Text != "") {                
                this.ObjEntidadesEspecialidad = new Entidades.Especialidad();               
                
                this.ObjEntidadesEspecialidad.Nombre = this.tbNombre.Text;
                this.ObjEntidadesEspecialidad.Descripcion = this.tbDescripcion.Text;
                Logica.Especialidad.GuardarNuevo(this.ObjEntidadesEspecialidad);
            } else {
                MessageBox.Show("Debe completar los espacios obligatorios");
            }

            this.Close();
        }
    }
}
