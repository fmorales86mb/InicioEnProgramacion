namespace bibio_fede_2.Listas {
	partial class ListaPrestamo {
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
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.dgPrestamo = new System.Windows.Forms.DataGridView();
			this.Nro = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.IdPrestamo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ApellidoSocio = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.NombreSocio = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Titulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.FechaPrestamo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.label1 = new System.Windows.Forms.Label();
			this.btnBuscar = new System.Windows.Forms.Button();
			this.tbNombreSocio = new System.Windows.Forms.TextBox();
			this.tbApellidoSocio = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.tbTituloLibro = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label5 = new System.Windows.Forms.Label();
			this.dtDesde = new System.Windows.Forms.DateTimePicker();
			this.dtHasta = new System.Windows.Forms.DateTimePicker();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgPrestamo)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.groupBox1);
			this.panel1.Controls.Add(this.tbTituloLibro);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.tbApellidoSocio);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.tbNombreSocio);
			this.panel1.Controls.Add(this.btnBuscar);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1004, 112);
			this.panel1.TabIndex = 0;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.dgPrestamo);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Location = new System.Drawing.Point(0, 112);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(1004, 173);
			this.panel2.TabIndex = 1;
			// 
			// dgPrestamo
			// 
			this.dgPrestamo.AllowUserToAddRows = false;
			this.dgPrestamo.AllowUserToDeleteRows = false;
			this.dgPrestamo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.dgPrestamo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgPrestamo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nro,
            this.IdPrestamo,
            this.ApellidoSocio,
            this.NombreSocio,
            this.Titulo,
            this.FechaPrestamo});
			this.dgPrestamo.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgPrestamo.Location = new System.Drawing.Point(0, 0);
			this.dgPrestamo.Name = "dgPrestamo";
			this.dgPrestamo.RowHeadersVisible = false;
			this.dgPrestamo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgPrestamo.Size = new System.Drawing.Size(1004, 173);
			this.dgPrestamo.TabIndex = 0;
			// 
			// Nro
			// 
			this.Nro.HeaderText = "Nro";
			this.Nro.Name = "Nro";
			this.Nro.ReadOnly = true;
			this.Nro.Width = 49;
			// 
			// IdPrestamo
			// 
			this.IdPrestamo.DataPropertyName = "iPrestamoLibroId";
			this.IdPrestamo.HeaderText = "IdPrestamo";
			this.IdPrestamo.Name = "IdPrestamo";
			this.IdPrestamo.ReadOnly = true;
			this.IdPrestamo.Visible = false;
			this.IdPrestamo.Width = 85;
			// 
			// ApellidoSocio
			// 
			this.ApellidoSocio.DataPropertyName = "cApellido";
			this.ApellidoSocio.HeaderText = "Apellido";
			this.ApellidoSocio.Name = "ApellidoSocio";
			this.ApellidoSocio.ReadOnly = true;
			this.ApellidoSocio.Width = 69;
			// 
			// NombreSocio
			// 
			this.NombreSocio.DataPropertyName = "cNombre";
			this.NombreSocio.HeaderText = "Nombre";
			this.NombreSocio.Name = "NombreSocio";
			this.NombreSocio.ReadOnly = true;
			this.NombreSocio.Width = 69;
			// 
			// Titulo
			// 
			this.Titulo.DataPropertyName = "cTitulo";
			this.Titulo.HeaderText = "Título";
			this.Titulo.Name = "Titulo";
			this.Titulo.ReadOnly = true;
			this.Titulo.Width = 60;
			// 
			// FechaPrestamo
			// 
			this.FechaPrestamo.DataPropertyName = "dFechaSalida";
			this.FechaPrestamo.HeaderText = "Fecha del Prestamo";
			this.FechaPrestamo.Name = "FechaPrestamo";
			this.FechaPrestamo.ReadOnly = true;
			this.FechaPrestamo.Width = 115;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 28);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(77, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Nombre Socio:";
			// 
			// btnBuscar
			// 
			this.btnBuscar.Location = new System.Drawing.Point(917, 78);
			this.btnBuscar.Name = "btnBuscar";
			this.btnBuscar.Size = new System.Drawing.Size(75, 23);
			this.btnBuscar.TabIndex = 1;
			this.btnBuscar.Text = "Buscar";
			this.btnBuscar.UseVisualStyleBackColor = true;
			// 
			// tbNombreSocio
			// 
			this.tbNombreSocio.Location = new System.Drawing.Point(95, 25);
			this.tbNombreSocio.Name = "tbNombreSocio";
			this.tbNombreSocio.Size = new System.Drawing.Size(148, 20);
			this.tbNombreSocio.TabIndex = 2;
			// 
			// tbApellidoSocio
			// 
			this.tbApellidoSocio.Location = new System.Drawing.Point(95, 75);
			this.tbApellidoSocio.Name = "tbApellidoSocio";
			this.tbApellidoSocio.Size = new System.Drawing.Size(148, 20);
			this.tbApellidoSocio.TabIndex = 4;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 78);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(77, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "Apellido Socio:";
			// 
			// tbTituloLibro
			// 
			this.tbTituloLibro.Location = new System.Drawing.Point(347, 25);
			this.tbTituloLibro.Name = "tbTituloLibro";
			this.tbTituloLibro.Size = new System.Drawing.Size(148, 20);
			this.tbTituloLibro.TabIndex = 6;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(264, 28);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(64, 13);
			this.label3.TabIndex = 5;
			this.label3.Text = "Título Libro:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(117, 16);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(41, 13);
			this.label4.TabIndex = 7;
			this.label4.Text = "Desde:";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.dtHasta);
			this.groupBox1.Controls.Add(this.dtDesde);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Location = new System.Drawing.Point(517, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(394, 94);
			this.groupBox1.TabIndex = 9;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Fecha del Préstamo";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(120, 51);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(38, 13);
			this.label5.TabIndex = 9;
			this.label5.Text = "Hasta:";
			// 
			// dtDesde
			// 
			this.dtDesde.Location = new System.Drawing.Point(164, 13);
			this.dtDesde.Name = "dtDesde";
			this.dtDesde.Size = new System.Drawing.Size(200, 20);
			this.dtDesde.TabIndex = 10;
			// 
			// dtHasta
			// 
			this.dtHasta.Location = new System.Drawing.Point(164, 49);
			this.dtHasta.Name = "dtHasta";
			this.dtHasta.Size = new System.Drawing.Size(200, 20);
			this.dtHasta.TabIndex = 11;
			// 
			// ListaPrestamo
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1004, 285);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Name = "ListaPrestamo";
			this.Text = "Lista de Préstamos";
			this.Load += new System.EventHandler(this.ListaPrestamo_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgPrestamo)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.DataGridView dgPrestamo;
		private System.Windows.Forms.DataGridViewTextBoxColumn Nro;
		private System.Windows.Forms.DataGridViewTextBoxColumn IdPrestamo;
		private System.Windows.Forms.DataGridViewTextBoxColumn ApellidoSocio;
		private System.Windows.Forms.DataGridViewTextBoxColumn NombreSocio;
		private System.Windows.Forms.DataGridViewTextBoxColumn Titulo;
		private System.Windows.Forms.DataGridViewTextBoxColumn FechaPrestamo;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.DateTimePicker dtHasta;
		private System.Windows.Forms.DateTimePicker dtDesde;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox tbTituloLibro;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox tbApellidoSocio;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox tbNombreSocio;
		private System.Windows.Forms.Button btnBuscar;
		private System.Windows.Forms.Label label1;
	}
}