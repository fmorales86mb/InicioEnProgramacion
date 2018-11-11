namespace bibio_fede_2.Listas {
	partial class ListaSocio {
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
			this.dgSocio = new System.Windows.Forms.DataGridView();
			this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.FechaAlta = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.FechaBaja = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Activo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			((System.ComponentModel.ISupportInitialize)(this.dgSocio)).BeginInit();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// dgSocio
			// 
			this.dgSocio.AllowUserToAddRows = false;
			this.dgSocio.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.dgSocio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgSocio.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Apellido,
            this.Nombre,
            this.FechaAlta,
            this.FechaBaja,
            this.Activo});
			this.dgSocio.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgSocio.Location = new System.Drawing.Point(0, 0);
			this.dgSocio.Name = "dgSocio";
			this.dgSocio.ReadOnly = true;
			this.dgSocio.RowHeadersVisible = false;
			this.dgSocio.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgSocio.Size = new System.Drawing.Size(533, 162);
			this.dgSocio.TabIndex = 0;
			this.dgSocio.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgSocio_CellDoubleClick);
			// 
			// Id
			// 
			this.Id.DataPropertyName = "iSocioId";
			this.Id.HeaderText = "Id";
			this.Id.Name = "Id";
			this.Id.ReadOnly = true;
			this.Id.Visible = false;
			this.Id.Width = 41;
			// 
			// Apellido
			// 
			this.Apellido.DataPropertyName = "cApellido";
			this.Apellido.HeaderText = "Apellido";
			this.Apellido.Name = "Apellido";
			this.Apellido.ReadOnly = true;
			this.Apellido.Width = 69;
			// 
			// Nombre
			// 
			this.Nombre.DataPropertyName = "cNombre";
			this.Nombre.HeaderText = "Nombre";
			this.Nombre.Name = "Nombre";
			this.Nombre.ReadOnly = true;
			this.Nombre.Width = 69;
			// 
			// FechaAlta
			// 
			this.FechaAlta.DataPropertyName = "dFechaDeAlta";
			this.FechaAlta.HeaderText = "Fecha de Alta";
			this.FechaAlta.Name = "FechaAlta";
			this.FechaAlta.ReadOnly = true;
			this.FechaAlta.Width = 98;
			// 
			// FechaBaja
			// 
			this.FechaBaja.DataPropertyName = "dFechaDeBaja";
			this.FechaBaja.HeaderText = "Fecha de Baja";
			this.FechaBaja.Name = "FechaBaja";
			this.FechaBaja.ReadOnly = true;
			this.FechaBaja.Visible = false;
			this.FechaBaja.Width = 101;
			// 
			// Activo
			// 
			this.Activo.DataPropertyName = "bActivo";
			this.Activo.HeaderText = "Activo";
			this.Activo.Name = "Activo";
			this.Activo.ReadOnly = true;
			this.Activo.Visible = false;
			this.Activo.Width = 62;
			// 
			// panel1
			// 
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(533, 100);
			this.panel1.TabIndex = 1;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.dgSocio);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Location = new System.Drawing.Point(0, 100);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(533, 162);
			this.panel2.TabIndex = 2;
			// 
			// ListaSocio
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(533, 262);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Name = "ListaSocio";
			this.Text = "Lista de Socios";
			this.Load += new System.EventHandler(this.ListaSocio_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgSocio)).EndInit();
			this.panel2.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dgSocio;
		private System.Windows.Forms.DataGridViewTextBoxColumn Id;
		private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
		private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
		private System.Windows.Forms.DataGridViewTextBoxColumn FechaAlta;
		private System.Windows.Forms.DataGridViewTextBoxColumn FechaBaja;
		private System.Windows.Forms.DataGridViewTextBoxColumn Activo;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
	}
}