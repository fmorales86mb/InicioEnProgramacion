namespace bibio_fede_2.Listas {
	partial class ListaIdioma {
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
			this.dgListaIdioma = new System.Windows.Forms.DataGridView();
			this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.tbBuscar = new System.Windows.Forms.TextBox();
			this.btnBuscar = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgListaIdioma)).BeginInit();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// dgListaIdioma
			// 
			this.dgListaIdioma.AllowUserToAddRows = false;
			this.dgListaIdioma.AllowUserToDeleteRows = false;
			this.dgListaIdioma.AllowUserToResizeRows = false;
			this.dgListaIdioma.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.dgListaIdioma.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgListaIdioma.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.nombre});
			this.dgListaIdioma.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgListaIdioma.Location = new System.Drawing.Point(0, 0);
			this.dgListaIdioma.Name = "dgListaIdioma";
			this.dgListaIdioma.RowHeadersVisible = false;
			this.dgListaIdioma.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgListaIdioma.Size = new System.Drawing.Size(493, 196);
			this.dgListaIdioma.TabIndex = 0;
			this.dgListaIdioma.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgListaIdioma_CellDoubleClick);
			// 
			// id
			// 
			this.id.DataPropertyName = "iIdiomaId";
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
			this.nombre.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.nombre.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.nombre.Width = 50;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.btnBuscar);
			this.panel1.Controls.Add(this.tbBuscar);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(493, 66);
			this.panel1.TabIndex = 1;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.dgListaIdioma);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Location = new System.Drawing.Point(0, 66);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(493, 196);
			this.panel2.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(27, 30);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(43, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Buscar:";
			// 
			// tbBuscar
			// 
			this.tbBuscar.Location = new System.Drawing.Point(76, 28);
			this.tbBuscar.Name = "tbBuscar";
			this.tbBuscar.Size = new System.Drawing.Size(180, 20);
			this.tbBuscar.TabIndex = 1;
			// 
			// btnBuscar
			// 
			this.btnBuscar.Location = new System.Drawing.Point(279, 26);
			this.btnBuscar.Name = "btnBuscar";
			this.btnBuscar.Size = new System.Drawing.Size(75, 23);
			this.btnBuscar.TabIndex = 2;
			this.btnBuscar.Text = "Buscar";
			this.btnBuscar.UseVisualStyleBackColor = true;
			this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
			// 
			// ListaIdioma
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(493, 262);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Name = "ListaIdioma";
			this.Text = "Lista de Idiomas";
			this.Load += new System.EventHandler(this.ListaIdioma_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgListaIdioma)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dgListaIdioma;
		private System.Windows.Forms.DataGridViewTextBoxColumn id;
		private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Button btnBuscar;
		private System.Windows.Forms.TextBox tbBuscar;
		private System.Windows.Forms.Label label1;
	}
}