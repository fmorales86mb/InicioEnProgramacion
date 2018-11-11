namespace bibio_fede_2.Listas {
	partial class ListaBiblioteca {
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
			this.dgListaBiblioteca = new System.Windows.Forms.DataGridView();
			this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.tbBuscar = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.btnBuscar = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgListaBiblioteca)).BeginInit();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// dgListaBiblioteca
			// 
			this.dgListaBiblioteca.AllowUserToAddRows = false;
			this.dgListaBiblioteca.AllowUserToDeleteRows = false;
			this.dgListaBiblioteca.AllowUserToResizeRows = false;
			this.dgListaBiblioteca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgListaBiblioteca.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.nombre,
            this.descripcion});
			this.dgListaBiblioteca.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgListaBiblioteca.Location = new System.Drawing.Point(0, 0);
			this.dgListaBiblioteca.Name = "dgListaBiblioteca";
			this.dgListaBiblioteca.RowHeadersVisible = false;
			this.dgListaBiblioteca.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgListaBiblioteca.ShowEditingIcon = false;
			this.dgListaBiblioteca.Size = new System.Drawing.Size(818, 304);
			this.dgListaBiblioteca.TabIndex = 0;
			this.dgListaBiblioteca.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgListaBiblioteca_CellDoubleClick);
			this.dgListaBiblioteca.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgListaBiblioteca_KeyDown);
			// 
			// id
			// 
			this.id.DataPropertyName = "iBibliotecaId";
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
			// 
			// descripcion
			// 
			this.descripcion.DataPropertyName = "cDescripcion";
			this.descripcion.HeaderText = "Descripción";
			this.descripcion.Name = "descripcion";
			this.descripcion.ReadOnly = true;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.btnBuscar);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.tbBuscar);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(818, 100);
			this.panel1.TabIndex = 1;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.dgListaBiblioteca);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Location = new System.Drawing.Point(0, 100);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(818, 304);
			this.panel2.TabIndex = 2;
			// 
			// tbBuscar
			// 
			this.tbBuscar.Location = new System.Drawing.Point(91, 41);
			this.tbBuscar.Name = "tbBuscar";
			this.tbBuscar.Size = new System.Drawing.Size(191, 20);
			this.tbBuscar.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(42, 44);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(43, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Buscar:";
			// 
			// btnBuscar
			// 
			this.btnBuscar.Location = new System.Drawing.Point(320, 39);
			this.btnBuscar.Name = "btnBuscar";
			this.btnBuscar.Size = new System.Drawing.Size(75, 23);
			this.btnBuscar.TabIndex = 2;
			this.btnBuscar.Text = "Buscar";
			this.btnBuscar.UseVisualStyleBackColor = true;
			this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
			// 
			// ListaBiblioteca
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(818, 404);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Name = "ListaBiblioteca";
			this.Text = "Lista de Bibliotecas";
			this.Load += new System.EventHandler(this.ListaBiblioteca_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgListaBiblioteca)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dgListaBiblioteca;
		private System.Windows.Forms.DataGridViewTextBoxColumn id;
		private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
		private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Button btnBuscar;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox tbBuscar;
	}
}