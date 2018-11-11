namespace bibio_fede_2.Listas {
	partial class ListaTipoLibro {
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
			this.dgListaTipoLibro = new System.Windows.Forms.DataGridView();
			this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			((System.ComponentModel.ISupportInitialize)(this.dgListaTipoLibro)).BeginInit();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// dgListaTipoLibro
			// 
			this.dgListaTipoLibro.AllowUserToAddRows = false;
			this.dgListaTipoLibro.AllowUserToResizeRows = false;
			this.dgListaTipoLibro.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.dgListaTipoLibro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgListaTipoLibro.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.nombre,
            this.descripcion});
			this.dgListaTipoLibro.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgListaTipoLibro.Location = new System.Drawing.Point(0, 0);
			this.dgListaTipoLibro.Name = "dgListaTipoLibro";
			this.dgListaTipoLibro.RowHeadersVisible = false;
			this.dgListaTipoLibro.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgListaTipoLibro.Size = new System.Drawing.Size(284, 162);
			this.dgListaTipoLibro.TabIndex = 0;
			this.dgListaTipoLibro.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgListaTipoLibro_CellDoubleClick);
			// 
			// id
			// 
			this.id.DataPropertyName = "iTipoLibroId";
			this.id.HeaderText = "ID";
			this.id.Name = "id";
			this.id.ReadOnly = true;
			this.id.Visible = false;
			// 
			// nombre
			// 
			this.nombre.DataPropertyName = "cNombre";
			this.nombre.HeaderText = "Nombre";
			this.nombre.Name = "nombre";
			this.nombre.ReadOnly = true;
			this.nombre.Width = 69;
			// 
			// descripcion
			// 
			this.descripcion.DataPropertyName = "cDescripcion";
			this.descripcion.HeaderText = "Descripción";
			this.descripcion.Name = "descripcion";
			this.descripcion.ReadOnly = true;
			this.descripcion.Width = 88;
			// 
			// panel1
			// 
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(284, 100);
			this.panel1.TabIndex = 1;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.dgListaTipoLibro);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Location = new System.Drawing.Point(0, 100);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(284, 162);
			this.panel2.TabIndex = 2;
			// 
			// ListaTipoLibro
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 262);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Name = "ListaTipoLibro";
			this.Text = "Lista de Tipos de Libros";
			this.Load += new System.EventHandler(this.ListaTipoLibro_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgListaTipoLibro)).EndInit();
			this.panel2.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dgListaTipoLibro;
		private System.Windows.Forms.DataGridViewTextBoxColumn id;
		private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
		private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
	}
}