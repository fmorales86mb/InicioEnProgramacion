namespace bibio_fede_2.Listas {
	partial class ListaLibro {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose (bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose ();
			}
			base.Dispose (disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent () {
			this.dgListaLibro = new System.Windows.Forms.DataGridView();
			this.Nro = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.titulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.autorapellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.autornombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.nombretipolibro = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.descorta = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.idiomanombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.editorialnombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.anioedicion = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.deslarga = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.tbTitulo = new System.Windows.Forms.TextBox();
			this.btnBuscar = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.tbApellidoAutor = new System.Windows.Forms.TextBox();
			this.tbTipoLibro = new System.Windows.Forms.TextBox();
			this.tbIdioma = new System.Windows.Forms.TextBox();
			this.tbEditorial = new System.Windows.Forms.TextBox();
			this.tbNombreAutor = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dgListaLibro)).BeginInit();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// dgListaLibro
			// 
			this.dgListaLibro.AllowUserToAddRows = false;
			this.dgListaLibro.AllowUserToResizeRows = false;
			this.dgListaLibro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgListaLibro.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nro,
            this.id,
            this.titulo,
            this.autorapellido,
            this.autornombre,
            this.nombretipolibro,
            this.descorta,
            this.idiomanombre,
            this.editorialnombre,
            this.anioedicion,
            this.deslarga});
			this.dgListaLibro.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgListaLibro.Location = new System.Drawing.Point(0, 0);
			this.dgListaLibro.Name = "dgListaLibro";
			this.dgListaLibro.RowHeadersVisible = false;
			this.dgListaLibro.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgListaLibro.Size = new System.Drawing.Size(960, 303);
			this.dgListaLibro.TabIndex = 0;
			this.dgListaLibro.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgListaLibro_CellDoubleClick);
			// 
			// Nro
			// 
			this.Nro.HeaderText = "Nro";
			this.Nro.Name = "Nro";
			this.Nro.ReadOnly = true;
			// 
			// id
			// 
			this.id.DataPropertyName = "LibroId";
			this.id.HeaderText = "ID";
			this.id.Name = "id";
			this.id.ReadOnly = true;
			this.id.Visible = false;
			// 
			// titulo
			// 
			this.titulo.DataPropertyName = "LibroTitulo";
			this.titulo.HeaderText = "Título";
			this.titulo.Name = "titulo";
			this.titulo.ReadOnly = true;
			// 
			// autorapellido
			// 
			this.autorapellido.DataPropertyName = "AutorApellido";
			this.autorapellido.HeaderText = "Apellido Autor";
			this.autorapellido.Name = "autorapellido";
			this.autorapellido.ReadOnly = true;
			// 
			// autornombre
			// 
			this.autornombre.DataPropertyName = "AutorNombre";
			this.autornombre.HeaderText = "Nombre Autor";
			this.autornombre.Name = "autornombre";
			this.autornombre.ReadOnly = true;
			// 
			// nombretipolibro
			// 
			this.nombretipolibro.DataPropertyName = "TipoLibroNombre";
			this.nombretipolibro.HeaderText = "Tipo de Libro";
			this.nombretipolibro.Name = "nombretipolibro";
			this.nombretipolibro.ReadOnly = true;
			// 
			// descorta
			// 
			this.descorta.DataPropertyName = "LibroDescripcionCorta";
			this.descorta.HeaderText = "Descripción breve";
			this.descorta.Name = "descorta";
			this.descorta.ReadOnly = true;
			// 
			// idiomanombre
			// 
			this.idiomanombre.DataPropertyName = "IdiomaNombre";
			this.idiomanombre.HeaderText = "Idioma";
			this.idiomanombre.Name = "idiomanombre";
			this.idiomanombre.ReadOnly = true;
			// 
			// editorialnombre
			// 
			this.editorialnombre.DataPropertyName = "EditorialNombre";
			this.editorialnombre.HeaderText = "Editorial";
			this.editorialnombre.Name = "editorialnombre";
			this.editorialnombre.ReadOnly = true;
			// 
			// anioedicion
			// 
			this.anioedicion.DataPropertyName = "LibroAnioEdicion";
			this.anioedicion.HeaderText = "Año de la Edición";
			this.anioedicion.Name = "anioedicion";
			this.anioedicion.ReadOnly = true;
			// 
			// deslarga
			// 
			this.deslarga.DataPropertyName = "LibroDescripcionLarga";
			this.deslarga.HeaderText = "Descripción Completa";
			this.deslarga.Name = "deslarga";
			this.deslarga.ReadOnly = true;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.tbNombreAutor);
			this.panel1.Controls.Add(this.label6);
			this.panel1.Controls.Add(this.tbEditorial);
			this.panel1.Controls.Add(this.tbIdioma);
			this.panel1.Controls.Add(this.tbTipoLibro);
			this.panel1.Controls.Add(this.tbApellidoAutor);
			this.panel1.Controls.Add(this.label5);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.btnBuscar);
			this.panel1.Controls.Add(this.tbTitulo);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(960, 115);
			this.panel1.TabIndex = 1;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.dgListaLibro);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Location = new System.Drawing.Point(0, 115);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(960, 303);
			this.panel2.TabIndex = 2;
			// 
			// tbTitulo
			// 
			this.tbTitulo.Location = new System.Drawing.Point(56, 26);
			this.tbTitulo.Name = "tbTitulo";
			this.tbTitulo.Size = new System.Drawing.Size(203, 20);
			this.tbTitulo.TabIndex = 0;
			// 
			// btnBuscar
			// 
			this.btnBuscar.Location = new System.Drawing.Point(857, 72);
			this.btnBuscar.Name = "btnBuscar";
			this.btnBuscar.Size = new System.Drawing.Size(75, 23);
			this.btnBuscar.TabIndex = 2;
			this.btnBuscar.Text = "Buscar";
			this.btnBuscar.UseVisualStyleBackColor = true;
			this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 29);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(38, 13);
			this.label1.TabIndex = 3;
			this.label1.Text = "Título:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 75);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(75, 13);
			this.label2.TabIndex = 4;
			this.label2.Text = "Apellido Autor:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(268, 77);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(72, 13);
			this.label3.TabIndex = 5;
			this.label3.Text = "Tipo de Libro:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(557, 29);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(41, 13);
			this.label4.TabIndex = 6;
			this.label4.Text = "Idioma:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(551, 77);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(47, 13);
			this.label5.TabIndex = 7;
			this.label5.Text = "Editorial:";
			// 
			// tbApellidoAutor
			// 
			this.tbApellidoAutor.Location = new System.Drawing.Point(93, 72);
			this.tbApellidoAutor.Name = "tbApellidoAutor";
			this.tbApellidoAutor.Size = new System.Drawing.Size(166, 20);
			this.tbApellidoAutor.TabIndex = 8;
			// 
			// tbTipoLibro
			// 
			this.tbTipoLibro.Location = new System.Drawing.Point(355, 74);
			this.tbTipoLibro.Name = "tbTipoLibro";
			this.tbTipoLibro.Size = new System.Drawing.Size(178, 20);
			this.tbTipoLibro.TabIndex = 9;
			// 
			// tbIdioma
			// 
			this.tbIdioma.Location = new System.Drawing.Point(616, 26);
			this.tbIdioma.Name = "tbIdioma";
			this.tbIdioma.Size = new System.Drawing.Size(178, 20);
			this.tbIdioma.TabIndex = 10;
			// 
			// tbEditorial
			// 
			this.tbEditorial.Location = new System.Drawing.Point(616, 72);
			this.tbEditorial.Name = "tbEditorial";
			this.tbEditorial.Size = new System.Drawing.Size(178, 20);
			this.tbEditorial.TabIndex = 11;
			// 
			// tbNombreAutor
			// 
			this.tbNombreAutor.Location = new System.Drawing.Point(355, 26);
			this.tbNombreAutor.Name = "tbNombreAutor";
			this.tbNombreAutor.Size = new System.Drawing.Size(178, 20);
			this.tbNombreAutor.TabIndex = 13;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(268, 29);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(75, 13);
			this.label6.TabIndex = 12;
			this.label6.Text = "Nombre Autor:";
			// 
			// ListaLibro
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(960, 418);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Name = "ListaLibro";
			this.Text = "Lista de Libros";
			this.Load += new System.EventHandler(this.ListaLibro_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgListaLibro)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dgListaLibro;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.DataGridViewTextBoxColumn Nro;
		private System.Windows.Forms.DataGridViewTextBoxColumn id;
		private System.Windows.Forms.DataGridViewTextBoxColumn titulo;
		private System.Windows.Forms.DataGridViewTextBoxColumn autorapellido;
		private System.Windows.Forms.DataGridViewTextBoxColumn autornombre;
		private System.Windows.Forms.DataGridViewTextBoxColumn nombretipolibro;
		private System.Windows.Forms.DataGridViewTextBoxColumn descorta;
		private System.Windows.Forms.DataGridViewTextBoxColumn idiomanombre;
		private System.Windows.Forms.DataGridViewTextBoxColumn editorialnombre;
		private System.Windows.Forms.DataGridViewTextBoxColumn anioedicion;
		private System.Windows.Forms.DataGridViewTextBoxColumn deslarga;
		private System.Windows.Forms.TextBox tbEditorial;
		private System.Windows.Forms.TextBox tbIdioma;
		private System.Windows.Forms.TextBox tbTipoLibro;
		private System.Windows.Forms.TextBox tbApellidoAutor;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnBuscar;
		private System.Windows.Forms.TextBox tbTitulo;
		private System.Windows.Forms.TextBox tbNombreAutor;
		private System.Windows.Forms.Label label6;
	}
}