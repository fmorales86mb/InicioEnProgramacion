using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bibio_fede_2.Formularios {
	public partial class ABMPrestamo: Form {
		Prestamo Prestamo;

		public ABMPrestamo () {
			InitializeComponent ();

			this.CargarComboSocio ();
			this.CargarComboTitulo ();
		}

		public void MostrarFormulario (int id) {
			if (id == 0) {
				this.dtFechaDeAltaSocio.Enabled = false;
				this.labelDevuelto.Visible = false;
				this.dtDevuelto.Visible = false;
				this.btnDevolver.Visible = false;
				this.cbSocio.SelectedIndex = -1;
				this.cbTitulo.SelectedIndex = -1;
				this.dtPrestado.Value = DateTime.Now;
			} else {
				this.Prestamo = BDPrestamo.BuscarPorId (id);
				this.CargarPrestamo ();
				this.dtFechaDeAltaSocio.Enabled = false;
				this.btnPrestar.Enabled = false;
				this.cbSocio.Enabled = false;
				this.cbTitulo.Enabled = false;
				this.labelDevuelto.Visible = true;
				this.dtDevuelto.Visible = true;
				if (this.Prestamo.Activo == true) {
					this.dtDevuelto.Value = DateTime.Now;
				} else {
					this.dtDevuelto.Value = this.Prestamo.FechaDevolucion;
				}				
			}

			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.ShowDialog ();
		}

		// Métodos que cargan los combos.
		private void CargarComboSocio () {
			// Para que el combo me devuelva el apellido y nombre tengo que hacer una modificación en el To String () de la clase Socio. 
			
			// Obtengo una lista con los Socios Activos.
			List<Socio> lista;
			lista = BDSocio.BuscarPorActivo (true);

			// Cargo la lista al combo.
			for (int i = 0; i < lista.Count; i++) {
				this.cbSocio.Items.Add (lista [i]);
			}
		}

		private void CargarComboTitulo () {
			List<Libro> lista;
			lista = BDLibro.BuscarLibrosEnPrestamo (false);

			for (int i = 0; i < lista.Count; i++) {
				this.cbTitulo.Items.Add (lista [i]);
			}
		}

		// Método que carga en los textbox y combos los datos del Prestamo.
		private void CargarPrestamo () {
			for (int i = 0; i < this.cbSocio.Items.Count; i++) {
				if (((Socio) this.cbSocio.Items [i]).SocioId == this.Prestamo.Socio.SocioId) {
					this.cbSocio.SelectedItem = i;
					Socio so = new Socio ();
					DateTime fecha = new DateTime ();

					so = (Socio) this.cbSocio.SelectedItem; // error acá, ver!!!!
					fecha = so.FechaDeAlta;
					this.dtFechaDeAltaSocio.Value = fecha;
					break;
				}
			}

			for (int i = 0; i < this.cbTitulo.Items.Count; i++) {
				if (((Libro) this.cbTitulo.Items [i]).LibroId == this.Prestamo.Libro.LibroId) {
					this.cbTitulo.SelectedItem = i;
					this.tbAutor.Text = ((Libro) this.cbTitulo.SelectedItem).Autor.Apellido + ", " + ((Libro) this.cbTitulo.SelectedItem).Autor.Nombre;
					this.tbEditorial.Text = ((Libro) this.cbTitulo.SelectedItem).Editorial.Nombre;
					this.tbIdioma.Text = ((Libro) this.cbTitulo.SelectedItem).Idioma.Nombre;
					break;
				}
			}
		}

		// Métodos que resuelven el cambio de los tb al cambiar los items de los combos.
		private void cbSocio_SelectedIndexChanged (object sender, EventArgs e) {
			if (this.cbSocio.SelectedIndex >= 0) {
				this.dtFechaDeAltaSocio.Value = ((Socio) this.cbSocio.SelectedItem).FechaDeAlta;	
			}
		}

		private void cbTitulo_SelectedIndexChanged (object sender, EventArgs e) {
			if (this.cbTitulo.SelectedIndex >= 0) {
				this.tbAutor.Text = ((Libro) this.cbTitulo.SelectedItem).Autor.Apellido + ", " + ((Libro) this.cbTitulo.SelectedItem).Autor.Nombre;
				this.tbEditorial.Text = ((Libro) this.cbTitulo.SelectedItem).Editorial.Nombre;
				this.tbIdioma.Text = ((Libro) this.cbTitulo.SelectedItem).Idioma.Nombre;
				this.tbAnioEdicion.Text = ((Libro) this.cbTitulo.SelectedItem).AnioEdicion.ToString ();
			}
		}

		// Métodos para los btn.
		private void btnCerrar_Click (object sender, EventArgs e) {
			this.Close ();
		}

		private void btnPrestar_Click (object sender, EventArgs e) {
			// Validaciones.
			if (this.cbSocio.SelectedIndex == -1) {
				MessageBox.Show ("Es necesario seleccionar un Socio.");
				return;
			} else if (this.cbTitulo.SelectedIndex == -1) {
				MessageBox.Show ("Es necesario seleccionar un Libro.");
				return;
			}

			DialogResult resultado = MessageBox.Show("¿Está seguro que desea realizar este préstamo?", "Sr. Usuario:", MessageBoxButtons.OKCancel);
			
			if (resultado == DialogResult.OK) {
				if (this.Prestamo == null) {
					this.Prestamo = new Prestamo ();
					this.Prestamo.Socio = (Socio) this.cbSocio.SelectedItem;
					this.Prestamo.Libro = (Libro) this.cbTitulo.SelectedItem;
					this.Prestamo.FechaSalida = this.dtPrestado.Value; // ¿Conviene poner directamente el valor Now?
					this.Prestamo.FechaDevolucion = DateTime.MinValue;
					this.Prestamo.Activo = true;
				}

			BDPrestamo.Guardar (Prestamo);
			this.Close ();
			} 			
		}
	}
}
