namespace bibio_fede_2.Listas {
	partial class ListaEditorial {
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
			this.dgListaEditorial = new System.Windows.Forms.DataGridView();
			this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.btnBuscar = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.tbBuscar = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.dgListaEditorial)).BeginInit();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// dgListaEditorial
			// 
			this.dgListaEditorial.AllowUserToAddRows = false;
			this.dgListaEditorial.AllowUserToResizeRows = false;
			this.dgListaEditorial.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.dgListaEditorial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgListaEditorial.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.nombre,
            this.direccion});
			this.dgListaEditorial.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgListaEditorial.Location = new System.Drawing.Point(0, 0);
			this.dgListaEditorial.Name = "dgListaEditorial";
			this.dgListaEditorial.RowHeadersVisible = false;
			this.dgListaEditorial.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgListaEditorial.Size = new System.Drawing.Size(592, 317);
			this.dgListaEditorial.TabIndex = 0;
			this.dgListaEditorial.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgListaEditorial_CellMouseDoubleClick);
			// 
			// id
			// 
			this.id.DataPropertyName = "iEditorialId";
			this.id.HeaderText = "ID";
			this.id.Name = "id";
			this.id.ReadOnly = true;
			this.id.Visible = false;
			// 
			// nombre
			// 
			this.nombre.DataPropertyName = "cNombre";
			this.nombre.HeaderText = "Nombre ";
			this.nombre.Name = "nombre";
			this.nombre.ReadOnly = true;
			this.nombre.Width = 72;
			// 
			// direccion
			// 
			this.direccion.DataPropertyName = "cDireccion";
			this.direccion.HeaderText = "Dirección";
			this.direccion.Name = "direccion";
			this.direccion.ReadOnly = true;
			this.direccion.Width = 77;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.tbBuscar);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.btnBuscar);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(592, 100);
			this.panel1.TabIndex = 1;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.dgListaEditorial);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Location = new System.Drawing.Point(0, 100);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(592, 317);
			this.panel2.TabIndex = 2;
			// 
			// btnBuscar
			// 
			this.btnBuscar.Location = new System.Drawing.Point(304, 38);
			this.btnBuscar.Name = "btnBuscar";
			this.btnBuscar.Size = new System.Drawing.Size(75, 23);
			this.btnBuscar.TabIndex = 0;
			this.btnBuscar.Text = "Buscar";
			this.btnBuscar.UseVisualStyleBackColor = true;
			this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(31, 43);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(43, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Buscar:";
			// 
			// tbBuscar
			// 
			this.tbBuscar.Location = new System.Drawing.Point(80, 40);
			this.tbBuscar.Name = "tbBuscar";
			this.tbBuscar.Size = new System.Drawing.Size(187, 20);
			this.tbBuscar.TabIndex = 2;
			// 
			// ListaEditorial
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(592, 417);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Name = "ListaEditorial";
			this.Text = "Lista de Editoriales";
			this.Load += new System.EventHandler(this.ListaEditorial_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgListaEditorial)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dgListaEditorial;
		private System.Windows.Forms.DataGridViewTextBoxColumn id;
		private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
		private System.Windows.Forms.DataGridViewTextBoxColumn direccion;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.TextBox tbBuscar;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnBuscar;
	}
}