using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * Tarea:
 * - Hacer que el otro combo actualize el valor del textbox asociado cuando se cambia el indice.
 * - Reemplazar la asignacion de objetos en la carga de los combos por asignacion de indices.
 */

namespace bibio_fede_2.Formularios {
	public partial class ABMLibro: Form {
		// Creo las variables de la clase. Con mayúscula (las variables de los métodos con minúscula).
		private Libro Libro;

		public ABMLibro () {
			InitializeComponent ();

			// Cargo los combos
			CargarCBIdioma ();
			CargarCBEditorial ();
			CargarCBAutor ();
			CargarCBTipoLibro ();
			CargarCBAnioEdicion ();

			this.tbEditorialDireccion.Enabled = false;
			this.tbTipoLibroDescripcion.Enabled = false;
		}

		/*
		private List<Autor> listaautor;
		private List<Editorial> listaeditorial;
		private List<int> lista_id_editoriales;
		private List<Idioma> listaidioma;
		private List<TipoLibro> listatipolibro;
		*/

		public void MostrarFormulario (int id) {
			// Si voy a cargar un libro nuevo (id = 0).
			if (id == 0) {
				this.Libro = new Libro ();
				this.cbAutor.SelectedIndex = -1;
				this.cbEditorialNombre.SelectedIndex = -1;
				this.cbIdiomaNombre.SelectedIndex = -1;
				this.cbTipoLibroNombre.SelectedIndex = -1;
				this.cbAnio.SelectedIndex = -1;
				this.tbDescripcionCorta.Text = "";
				this.tbDescripcionLarga.Text = "";
				this.tbTitulo.Text = "";
				this.btnBorrar.Enabled = false;
				this.btnPrestamo.Enabled = false;
												
			// Si voy a cargar un libro existente.
			} else {
				this.Libro = BDLibro.BuscarPorId (id);
				this.Cargarlibro ();
				this.btnBorrar.Enabled = true;
			}

			// Establezco el tipo de borde de la ventana para que no se pueda cambiar de tamaño.
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.ShowDialog ();
		}

		private void btnCerrar_Click (object sender, EventArgs e) {
			this.Close ();
		}

		// Funciones que cargan los datos desde la BD hasta los Combos.

		private void CargarCBIdioma () {
			// Creo el puntero pero no creo una lista nueva, ya que asocio al puntero a una función que devuelve una lista ya creada.
			List<Idioma> lista;
						
			// Obtengo la lista de idiomas.
			lista = BDIdioma.ListaCompleta ();
			
			// Cargo la lista al combobox.
			for (int i = 0; i < lista.Count; i++) {
				this.cbIdiomaNombre.Items.Add (lista[i]);
			}
		}

		private void CargarCBEditorial () {
			List<Editorial> lista;

			lista = BDEditorial.ListaCompleta ();

			// Lista.Count inicia en 1, pero el primer item de la lista cominenza con 0. 
			for (int i = 0; i < lista.Count; i++) {
				this.cbEditorialNombre.Items.Add (lista [i]);
			}

			// Forma un poco menos trambolica que la de guardar solo los ids
			
			/*
			for (int i = 0; i < lista.Count; i++) {
				this.cbEditorialNombre.Items.Add (new VistaEditorial (lista [i]));
			}
			*/
		}

		private void CargarCBAutor () {
			// Creo el puntero.
			List<Autor> lista;
			
			// No creo una nueva lista, ya que asocio al puntero a una función que me devuelve una lista ya creada.
			lista = BDAutor.ListaCompleta ();

			// Cargo la lista al combo.
			// El combo convierte en texto con el ToString lo que le doy. En este caso le doy un objeto de la clase Autor. 
			// Si no modifico el ToString en la clase Autor me va a mostrar el nombre de la clase, algo así como "biblio_fede2 TipoLibro".
			for (int i = 0; i < lista.Count; i++) {
				this.cbAutor.Items.Add (lista[i]);
			}
		}

		private void CargarCBTipoLibro () {
			List<TipoLibro> lista;

			lista = BDTipoLibro.ListaCompleta ();

			for (int i = 0; i < lista.Count; i++) {
				this.cbTipoLibroNombre.Items.Add (lista[i]);
			}
		}

		private void CargarCBAnioEdicion () {
			for (int i = 1900; i < 2051; i++) {
				this.cbAnio.Items.Add (i.ToString ());
			} 
		}

		private void Cargarlibro () {
			Editorial ed;
			Autor au;
			TipoLibro tipo;
			Idioma idio;
			// CONSULTA: ¿Creo para cada "for" un nuevo int i o con uno sólo alcanza?
			int i; 

			/*
			 * No es necesario crear nuevos objetos ya que asigno los punteros a objetos ya existentes.
			ed = new Editorial ();
			au = new Autor ();
			tipo = new TipoLibro ();
			idio = new Idioma ();
			*/
			 
			// Cargo los items que no tienen combo.
			this.tbTitulo.Text = this.Libro.Titulo;
			this.tbDescripcionCorta.Text = this.Libro.DescripcionCorta;
			this.tbDescripcionLarga.Text = this.Libro.DescripcionLarga;

			// Cargo los items con combo.
			for (i = 0; i < this.cbEditorialNombre.Items.Count; i++) {
				ed = (Editorial) this.cbEditorialNombre.Items [i];
				if (Libro.Editorial.EditorialId == ed.EditorialId) {
					this.cbEditorialNombre.SelectedIndex = i;
					break;
				}
			}
			
			for (i = 0; i < this.cbAutor.Items.Count; i++) {
				au = (Autor) this.cbAutor.Items [i];
				if (Libro.Autor.AutorId == au.AutorId) {
					this.cbAutor.SelectedItem = this.cbAutor.Items [i];
					break;
				}
			}

			for (i = 0; i < this.cbTipoLibroNombre.Items.Count; i++) {
				tipo = (TipoLibro) this.cbTipoLibroNombre.Items [i];
				if (Libro.Tipo.TipoLibroId == tipo.TipoLibroId) {
					this.cbTipoLibroNombre.SelectedItem = this.cbTipoLibroNombre.Items [i];
					break;
				}
			}

			for (i = 0; i < this.cbIdiomaNombre.Items.Count; i++) {
				idio = (Idioma) this.cbIdiomaNombre.Items [i];
				if (Libro.Idioma.idiomaId == idio.idiomaId) {
					this.cbIdiomaNombre.SelectedItem = this.cbIdiomaNombre.Items [i];
					break;
				}
			}

			for (i = 0; i < this.cbAnio.Items.Count; i++) {
				if (this.Libro.AnioEdicion == Convert.ToInt32 (this.cbAnio.Items [i])) {
					this.cbAnio.SelectedItem = this.cbAnio.Items [i];
					break;
				}
			}
		}

		private void btnGuardar_Click (object sender, EventArgs e) {
			// Validaciones.
			if (this.tbTitulo.Text == "") {
				MessageBox.Show ("Fatlan completar campos");
				return;
			} else if (this.tbTitulo.Text.IndexOf ("'") >= 0 || this.tbTitulo.Text.IndexOf (";") >= 0) {
				MessageBox.Show ("No se pueden ingresar ', ;");
				return;
			} else if (this.tbDescripcionCorta.Text.IndexOf ("'") >= 0 || this.tbDescripcionCorta.Text.IndexOf (";") >= 0) {
				MessageBox.Show ("No se pueden ingresar ', ;");
				return;
			} else if (this.tbDescripcionLarga.Text.IndexOf ("'") >= 0 || this.tbDescripcionLarga.Text.IndexOf (";") >= 0) {
				MessageBox.Show ("No se pueden ingresar ', ;");
				return;
			}
			
			if (this.cbEditorialNombre.SelectedIndex < 0) {
				MessageBox.Show ("Fatlan completar campos");
				return;
			} else if (this.cbAutor.SelectedIndex < 0) {
				MessageBox.Show ("Fatlan completar campos");
				return;
			} else if (this.cbTipoLibroNombre.SelectedIndex < 0) {
				MessageBox.Show ("Fatlan completar campos");
				return;
			} else if (this.cbIdiomaNombre.SelectedIndex < 0) {
				MessageBox.Show ("Fatlan completar campos");
				return;
			} else if (this.cbAnio.SelectedIndex < 0) {
				MessageBox.Show ("Fatlan completar campos");
				return;
			}
			
			// Creo los punteros.
			Editorial editorial;
			Autor autor;
			Idioma idioma;
			TipoLibro tipo;

			// Asigno al puntero a un objeto ya creado.
			// Asigno al objeto un item del cb. indico el indice seleccionado en el cb para traer al item.
			// Indico entre parentesis qué tipo de objeto es el que me devuelve ya que le cb no lo sabe.
			editorial = (Editorial) this.cbEditorialNombre.Items [this.cbEditorialNombre.SelectedIndex];
			autor = (Autor) this.cbAutor.Items [this.cbAutor.SelectedIndex];
			idioma = (Idioma) this.cbIdiomaNombre.Items [this.cbIdiomaNombre.SelectedIndex];
			tipo = (TipoLibro) this.cbTipoLibroNombre.Items [this.cbTipoLibroNombre.SelectedIndex];

			// Asigno los valores al objeto Libro de la clase.
			Libro.Autor = autor;
			Libro.Editorial = editorial;
			Libro.Idioma = idioma;
			Libro.Tipo = tipo;
			Libro.DescripcionCorta = this.tbDescripcionCorta.Text;
			Libro.DescripcionLarga = this.tbDescripcionLarga.Text;
			Libro.AnioEdicion = Convert.ToInt32 (this.cbAnio.SelectedItem);
			Libro.Titulo = this.tbTitulo.Text;
			Libro.Activo = true;

			
			BDLibro.Guardar (Libro);
			this.Close ();
			
			/*	
			 * Forma básica de encontrar el objeto que se seleccionó en el CB. No es recomendable porque es una búsqueda indirecta.
			
			int i;
			Idioma idioma;

			i = this.cbIdiomaNombre.SelectedIndex;

			idioma = lista [i];
			
			*/
		}

		private void cbEditorialNombre_SelectedIndexChanged (object sender, EventArgs e) {
			/*
			Editorial ed;
			ed = (Editorial) this.cbEditorialNombre.SelectedItem;
			this.tbEditorialDireccion.Text = ed.Dirección;
			*/

			this.tbEditorialDireccion.Text = ((Editorial) this.cbEditorialNombre.SelectedItem).Dirección;
		}

		private void cbTipoLibroNombre_SelectedIndexChanged (object sender, EventArgs e) {
			this.tbTipoLibroDescripcion.Text = ((TipoLibro) this.cbTipoLibroNombre.SelectedItem).Descripcion;
		}

		private void btnBorrar_Click (object sender, EventArgs e) {
			BDLibro.Borrar (this.Libro.LibroId);
			this.Close ();
		}

		private void btnEditorialMasbtnEditorialMas_Click (object sender, EventArgs e) {
			Formularios.ABMEditorial form;
			form = new ABMEditorial ();
			form.MostrarFormulario (0);
			// Luego de cerrado form tengo que borrar los items del combo para que cuando los recargue no se repitan.
			this.cbEditorialNombre.Items.Clear ();
			this.CargarCBEditorial ();
		}

		private void btnAutorMas_Click (object sender, EventArgs e) {
			Formularios.ABMAutor form;
			form = new ABMAutor ();
			form.MostrarFormulario (0);
			this.cbAutor.Items.Clear ();
			this.CargarCBAutor ();
		}

		private void btnTipoLibroMas_Click (object sender, EventArgs e) {
			Formularios.ABMTipoLibro form;
			form = new ABMTipoLibro ();
			form.MostrarFormulario (0);
			this.cbTipoLibroNombre.Items.Clear ();
			this.CargarCBTipoLibro ();
		}

		private void btnIdiomaMas_Click (object sender, EventArgs e) {
			Formularios.ABMIdioma form;
			form = new ABMIdioma ();
			form.MostrarFormulario (0);
			this.cbIdiomaNombre.Items.Clear ();
			this.CargarCBIdioma ();
		}
	}
}
