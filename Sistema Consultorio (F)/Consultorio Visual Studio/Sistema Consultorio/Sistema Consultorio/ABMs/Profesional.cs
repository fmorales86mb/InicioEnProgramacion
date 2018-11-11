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
    public partial class Profesional : Form {

        Entidades.Profesional ObjEntidadesProfesional;             

        public Profesional() {
            InitializeComponent();
        }

        public void CargarAbm(int id) {
            this.ObjEntidadesProfesional = new Entidades.Profesional();
            if (id == 0) {
                this.btnBorrar.Enabled = false;

            } else {
                this.btnBorrar.Enabled = true;
                // NO uso el gv enlazado (con DataSource) porque sino no puedo agregar filas manualmente.
                //this.gvEspecialidadDeProfesional.DataSource = this.ListaEspecialidades;                

                this.ObjEntidadesProfesional = Logica.Profesional.BuscarPorId(id);

                this.tbNombre.Text = ObjEntidadesProfesional.Nombre;
                this.tbApellido.Text = ObjEntidadesProfesional.Apellido;
                this.tbDirPersonal.Text = ObjEntidadesProfesional.DirPersonal;
                this.tbDirProfesional.Text = ObjEntidadesProfesional.DirProfesional;
                this.tbMatricula.Text = ObjEntidadesProfesional.NroMatricula;
                this.tbPolizaSeguro.Text = ObjEntidadesProfesional.PolizaSeguro;
                this.tbTelefono.Text = ObjEntidadesProfesional.NroTelefono;
                this.CargarGvEspecialidades(this.ObjEntidadesProfesional.ListaEspecialidades);
                this.CargarGvTratamientos(this.ObjEntidadesProfesional.ListaTratamientos);
            }

            this.CargarCbEspecialidades(this.ObjEntidadesProfesional);
            this.CargarCbTratamientos(this.ObjEntidadesProfesional);
            this.ShowDialog();
        }

        private void Profesional_Load(object sender, EventArgs e) {            
                        
        }
       
        private void btnCerrar_Click(object sender, EventArgs e) {
            this.Close();
        }

        // Agrega Especialidad al Gv y la quita del Combo.
        private void btnAgregarEspecialidad_Click(object sender, EventArgs e) {
            Entidades.Especialidad objEspecialidad = (Entidades.Especialidad) this.cbEspecialidad.SelectedItem;
            this.gvEspecialidadDeProfesional.Rows.Add(objEspecialidad.EspecialidadId, objEspecialidad.Nombre, objEspecialidad.Descripcion);
            this.cbEspecialidad.Items.Remove(this.cbEspecialidad.SelectedItem);
            this.cbEspecialidad.Text = "";
            // No se puede agregar una fila con Rows.Add si el gv está enlazado con un Source
            // this.gvEspecialidadDeProfesional.Rows.Add(especialidad.EspecialidadId, especialidad.Nombre, especialidad.Descripcion);
        }

        private void btnAgregarTratamiento_Click(object sender, EventArgs e) {
            Entidades.Tratamiento objTratamiento = (Entidades.Tratamiento) this.cbTratamiento.SelectedItem;
            this.gvTratamientoDeProfesional.Rows.Add(objTratamiento.TratamientoId, objTratamiento.EstadoTratamiento.Nombre, objTratamiento.Horario, objTratamiento.FechaInicio, objTratamiento.FechaFin);
            this.cbTratamiento.Items.Remove(this.cbTratamiento.SelectedItem);
            this.cbTratamiento.Text = "";
        }

        private void btnGuardar_Click(object sender, EventArgs e) {
            this.ObjEntidadesProfesional.Nombre = this.tbNombre.Text;
            this.ObjEntidadesProfesional.Apellido = this.tbApellido.Text;
            this.ObjEntidadesProfesional.NroMatricula = this.tbMatricula.Text;
            this.ObjEntidadesProfesional.NroTelefono = this.tbTelefono.Text;
            this.ObjEntidadesProfesional.DirPersonal = this.tbDirPersonal.Text;
            this.ObjEntidadesProfesional.DirProfesional = this.tbDirProfesional.Text;
            this.ObjEntidadesProfesional.PolizaSeguro = this.tbPolizaSeguro.Text;           
            if (this.ObjEntidadesProfesional.ProfesionalId > 0) {
                this.ObjEntidadesProfesional.ListaEspecialidades.Clear();
                this.ObjEntidadesProfesional.ListaTratamientos.Clear();
            }
            
            foreach(DataGridViewRow fila in this.gvEspecialidadDeProfesional.Rows) {
                Entidades.Especialidad objEspecialidad = Logica.Especialidad.BuscarPorId((int) fila.Cells["Id"].Value);
                this.ObjEntidadesProfesional.ListaEspecialidades.Add(objEspecialidad);
            }
            foreach (DataGridViewRow fila in this.gvTratamientoDeProfesional.Rows) {
                Entidades.Tratamiento objTratamiento = Logica.Tratamiento.BuscarPorId((int) fila.Cells["IdTratamiento"].Value);
                this.ObjEntidadesProfesional.ListaTratamientos.Add(objTratamiento);
            }

            this.ObjEntidadesProfesional.ProfesionalId = Logica.Profesional.Guardar(this.ObjEntidadesProfesional);
            this.Close();
        }

        private void CargarCbEspecialidades(Entidades.Profesional objProfesional) {

            List<Entidades.Especialidad> listaBd = Logica.Especialidad.TablaCompleta();

            if (objProfesional.ProfesionalId > 0) {
                bool encontrado = false;               
                foreach (Entidades.Especialidad especialidadBd in listaBd) {
                    for (int i = 0; i < objProfesional.ListaEspecialidades.Count; i++) {
                        if (especialidadBd.EspecialidadId == objProfesional.ListaEspecialidades[i].EspecialidadId) {
                            encontrado = true;
                            break;
                        } else {
                            encontrado = false;
                        }
                    }

                    if (encontrado == false) {
                        this.cbEspecialidad.Items.Add(especialidadBd);
                    }
                }

            } else {
                foreach (Entidades.Especialidad especialidadBd in listaBd) {
                    this.cbEspecialidad.Items.Add(especialidadBd);
                }
            }
        }

        private void CargarCbTratamientos(Entidades.Profesional objProfesional) {
            List<Entidades.Tratamiento> listaBd = Logica.Tratamiento.TablaCompleta();

            if (objProfesional.ProfesionalId > 0) {
                bool encontrado = false;
                foreach (Entidades.Tratamiento tratamientoBd in listaBd) {
                    for (int i = 0; i < objProfesional.ListaTratamientos.Count; i++) {
                        if (tratamientoBd.TratamientoId == objProfesional.ListaTratamientos[i].TratamientoId) {
                            encontrado = true;
                            break;
                        } else {
                            encontrado = false;
                        }
                    }

                    if (encontrado == false) {
                        this.cbTratamiento.Items.Add(tratamientoBd);
                    }
                }

            } else {
                foreach (Entidades.Tratamiento tratamientoBd in listaBd) {
                    this.cbTratamiento.Items.Add(tratamientoBd);
                }
            }
        }

        private void CargarGvEspecialidades(List<Entidades.Especialidad> listaEspecialidades) {
            for (int i = 0; i < listaEspecialidades.Count; i++) {
                Entidades.Especialidad especialidad = listaEspecialidades[i];
                this.gvEspecialidadDeProfesional.Rows.Add(especialidad.EspecialidadId, especialidad.Nombre, especialidad.Descripcion);
            }           
        }

        private void CargarGvTratamientos(List<Entidades.Tratamiento> listaTratamientos) {
            foreach (Entidades.Tratamiento tratamiento in listaTratamientos) {
                this.gvTratamientoDeProfesional.Rows.Add(tratamiento.TratamientoId, tratamiento.Nombre, tratamiento.EstadoTratamiento.Nombre, tratamiento.Horario, tratamiento.FechaInicio, tratamiento.FechaFin);
            }
        }

        private void gvEspecialidadDeProfesional_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e) {
            if (this.gvEspecialidadDeProfesional.CurrentCell.OwningColumn == this.gvEspecialidadDeProfesional.Columns["Quitar"]) {
                Entidades.Especialidad objEspecialidad = new Entidades.Especialidad();
                objEspecialidad.EspecialidadId = (int) this.gvEspecialidadDeProfesional.CurrentRow.Cells["ID"].Value;
                objEspecialidad.Nombre = this.gvEspecialidadDeProfesional.CurrentRow.Cells["Nombre"].Value.ToString();
                objEspecialidad.Descripcion = this.gvEspecialidadDeProfesional.CurrentRow.Cells["Descripcion"].Value.ToString();

                this.gvEspecialidadDeProfesional.Rows.Remove(this.gvEspecialidadDeProfesional.CurrentRow);
                this.cbEspecialidad.Items.Add(objEspecialidad);
                this.cbEspecialidad.Text = "";
            }
        }

        private void gvTratamientoDeProfesional_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e) {
            if (this.gvTratamientoDeProfesional.CurrentCell.OwningColumn == this.gvTratamientoDeProfesional.Columns["QuitarTratamiento"]) {
                Entidades.Tratamiento objTratamiento = new Entidades.Tratamiento();
                objTratamiento.TratamientoId = (int) this.gvTratamientoDeProfesional.CurrentRow.Cells["IdTratamiento"].Value;
                objTratamiento.Nombre = this.gvTratamientoDeProfesional.CurrentRow.Cells["NombreTratamiento"].Value.ToString();
                objTratamiento.EstadoTratamiento.Nombre = this.gvTratamientoDeProfesional.CurrentRow.Cells["EstadoTratamientoNombre"].Value.ToString();
                objTratamiento.Horario = this.gvTratamientoDeProfesional.CurrentRow.Cells["Horario"].Value.ToString();
                objTratamiento.FechaInicio = (DateTime) this.gvTratamientoDeProfesional.CurrentRow.Cells["FechaInicio"].Value;
                objTratamiento.FechaFin = (DateTime) this.gvTratamientoDeProfesional.CurrentRow.Cells["FechaFin"].Value;

                this.gvTratamientoDeProfesional.Rows.Remove(this.gvTratamientoDeProfesional.CurrentRow);
                this.cbTratamiento.Items.Add(objTratamiento);
                this.cbTratamiento.Text = "";
            }
        }







    }
}
