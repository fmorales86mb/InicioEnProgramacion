namespace bibio_fede_2.Formularios {
	partial class ABMPrestamo {
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
			this.btnCerrar = new System.Windows.Forms.Button();
			this.btnPrestar = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.dtFechaDeAltaSocio = new System.Windows.Forms.DateTimePicker();
			this.label8 = new System.Windows.Forms.Label();
			this.cbSocio = new System.Windows.Forms.ComboBox();
			this.dtDevuelto = new System.Windows.Forms.DateTimePicker();
			this.dtPrestado = new System.Windows.Forms.DateTimePicker();
			this.labelDevuelto = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.tbAnioEdicion = new System.Windows.Forms.TextBox();
			this.tbEditorial = new System.Windows.Forms.TextBox();
			this.tbIdioma = new System.Windows.Forms.TextBox();
			this.tbAutor = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.cbTitulo = new System.Windows.Forms.ComboBox();
			this.btnDevolver = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnCerrar
			// 
			this.btnCerrar.Location = new System.Drawing.Point(397, 449);
			this.btnCerrar.Name = "btnCerrar";
			this.btnCerrar.Size = new System.Drawing.Size(75, 23);
			this.btnCerrar.TabIndex = 0;
			this.btnCerrar.Text = "Cerrar";
			this.btnCerrar.UseVisualStyleBackColor = true;
			this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
			// 
			// btnPrestar
			// 
			this.btnPrestar.Location = new System.Drawing.Point(287, 449);
			this.btnPrestar.Name = "btnPrestar";
			this.btnPrestar.Size = new System.Drawing.Size(75, 23);
			this.btnPrestar.TabIndex = 1;
			this.btnPrestar.Text = "Prestar";
			this.btnPrestar.UseVisualStyleBackColor = true;
			this.btnPrestar.Click += new System.EventHandler(this.btnPrestar_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(30, 37);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(41, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "Título: ";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(30, 34);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(93, 13);
			this.label2.TabIndex = 4;
			this.label2.Text = "Apellido y nombre:";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.groupBox3);
			this.groupBox1.Controls.Add(this.dtDevuelto);
			this.groupBox1.Controls.Add(this.dtPrestado);
			this.groupBox1.Controls.Add(this.labelDevuelto);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Controls.Add(this.groupBox2);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(477, 420);
			this.groupBox1.TabIndex = 6;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Préstamo";
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.dtFechaDeAltaSocio);
			this.groupBox3.Controls.Add(this.label8);
			this.groupBox3.Controls.Add(this.cbSocio);
			this.groupBox3.Controls.Add(this.label2);
			this.groupBox3.Location = new System.Drawing.Point(12, 32);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(447, 109);
			this.groupBox3.TabIndex = 16;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Socio";
			// 
			// dtFechaDeAltaSocio
			// 
			this.dtFechaDeAltaSocio.Location = new System.Drawing.Point(129, 68);
			this.dtFechaDeAltaSocio.Name = "dtFechaDeAltaSocio";
			this.dtFechaDeAltaSocio.Size = new System.Drawing.Size(200, 20);
			this.dtFechaDeAltaSocio.TabIndex = 15;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(30, 75);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(75, 13);
			this.label8.TabIndex = 14;
			this.label8.Text = "Fecha de alta:";
			// 
			// cbSocio
			// 
			this.cbSocio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbSocio.FormattingEnabled = true;
			this.cbSocio.Location = new System.Drawing.Point(129, 31);
			this.cbSocio.Name = "cbSocio";
			this.cbSocio.Size = new System.Drawing.Size(228, 21);
			this.cbSocio.TabIndex = 5;
			this.cbSocio.SelectedIndexChanged += new System.EventHandler(this.cbSocio_SelectedIndexChanged);
			// 
			// dtDevuelto
			// 
			this.dtDevuelto.Enabled = false;
			this.dtDevuelto.Location = new System.Drawing.Point(74, 385);
			this.dtDevuelto.Name = "dtDevuelto";
			this.dtDevuelto.Size = new System.Drawing.Size(200, 20);
			this.dtDevuelto.TabIndex = 13;
			// 
			// dtPrestado
			// 
			this.dtPrestado.Enabled = false;
			this.dtPrestado.Location = new System.Drawing.Point(74, 345);
			this.dtPrestado.Name = "dtPrestado";
			this.dtPrestado.Size = new System.Drawing.Size(200, 20);
			this.dtPrestado.TabIndex = 12;
			// 
			// labelDevuelto
			// 
			this.labelDevuelto.AutoSize = true;
			this.labelDevuelto.Location = new System.Drawing.Point(15, 391);
			this.labelDevuelto.Name = "labelDevuelto";
			this.labelDevuelto.Size = new System.Drawing.Size(53, 13);
			this.labelDevuelto.TabIndex = 11;
			this.labelDevuelto.Text = "Devuelto:";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(15, 352);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(52, 13);
			this.label7.TabIndex = 10;
			this.label7.Text = "Prestado:";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.tbAnioEdicion);
			this.groupBox2.Controls.Add(this.tbEditorial);
			this.groupBox2.Controls.Add(this.tbIdioma);
			this.groupBox2.Controls.Add(this.tbAutor);
			this.groupBox2.Controls.Add(this.label6);
			this.groupBox2.Controls.Add(this.label5);
			this.groupBox2.Controls.Add(this.label4);
			this.groupBox2.Controls.Add(this.label3);
			this.groupBox2.Controls.Add(this.cbTitulo);
			this.groupBox2.Controls.Add(this.label1);
			this.groupBox2.Location = new System.Drawing.Point(12, 156);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(448, 171);
			this.groupBox2.TabIndex = 7;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Libro";
			// 
			// tbAnioEdicion
			// 
			this.tbAnioEdicion.Enabled = false;
			this.tbAnioEdicion.Location = new System.Drawing.Point(363, 99);
			this.tbAnioEdicion.Name = "tbAnioEdicion";
			this.tbAnioEdicion.Size = new System.Drawing.Size(74, 20);
			this.tbAnioEdicion.TabIndex = 14;
			// 
			// tbEditorial
			// 
			this.tbEditorial.Enabled = false;
			this.tbEditorial.Location = new System.Drawing.Point(77, 99);
			this.tbEditorial.Name = "tbEditorial";
			this.tbEditorial.Size = new System.Drawing.Size(176, 20);
			this.tbEditorial.TabIndex = 13;
			// 
			// tbIdioma
			// 
			this.tbIdioma.Enabled = false;
			this.tbIdioma.Location = new System.Drawing.Point(77, 135);
			this.tbIdioma.Name = "tbIdioma";
			this.tbIdioma.Size = new System.Drawing.Size(176, 20);
			this.tbIdioma.TabIndex = 12;
			// 
			// tbAutor
			// 
			this.tbAutor.Enabled = false;
			this.tbAutor.Location = new System.Drawing.Point(77, 68);
			this.tbAutor.Name = "tbAutor";
			this.tbAutor.Size = new System.Drawing.Size(176, 20);
			this.tbAutor.TabIndex = 11;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(276, 102);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(81, 13);
			this.label6.TabIndex = 10;
			this.label6.Text = "Año de edición:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(30, 138);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(41, 13);
			this.label5.TabIndex = 9;
			this.label5.Text = "Idioma:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(24, 102);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(47, 13);
			this.label4.TabIndex = 8;
			this.label4.Text = "Editorial:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(36, 71);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(35, 13);
			this.label3.TabIndex = 7;
			this.label3.Text = "Autor:";
			// 
			// cbTitulo
			// 
			this.cbTitulo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbTitulo.FormattingEnabled = true;
			this.cbTitulo.Location = new System.Drawing.Point(77, 34);
			this.cbTitulo.Name = "cbTitulo";
			this.cbTitulo.Size = new System.Drawing.Size(176, 21);
			this.cbTitulo.TabIndex = 6;
			this.cbTitulo.SelectedIndexChanged += new System.EventHandler(this.cbTitulo_SelectedIndexChanged);
			// 
			// btnDevolver
			// 
			this.btnDevolver.Location = new System.Drawing.Point(199, 449);
			this.btnDevolver.Name = "btnDevolver";
			this.btnDevolver.Size = new System.Drawing.Size(75, 23);
			this.btnDevolver.TabIndex = 7;
			this.btnDevolver.Text = "Devolver";
			this.btnDevolver.UseVisualStyleBackColor = true;
			// 
			// ABMPrestamo
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(501, 484);
			this.Controls.Add(this.btnDevolver);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.btnPrestar);
			this.Controls.Add(this.btnCerrar);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.Name = "ABMPrestamo";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Préstamo de Libro";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnCerrar;
		private System.Windows.Forms.Button btnPrestar;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.DateTimePicker dtDevuelto;
		private System.Windows.Forms.DateTimePicker dtPrestado;
		private System.Windows.Forms.Label labelDevuelto;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.TextBox tbAnioEdicion;
		private System.Windows.Forms.TextBox tbEditorial;
		private System.Windows.Forms.TextBox tbIdioma;
		private System.Windows.Forms.TextBox tbAutor;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox cbTitulo;
		private System.Windows.Forms.ComboBox cbSocio;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.DateTimePicker dtFechaDeAltaSocio;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Button btnDevolver;
	}
}