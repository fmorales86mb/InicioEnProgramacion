namespace bibio_fede_2.Formularios {
	partial class ABMSocio {
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
			this.btnGuardar = new System.Windows.Forms.Button();
			this.btnBorrar = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.dtBaja = new System.Windows.Forms.DateTimePicker();
			this.dtAlta = new System.Windows.Forms.DateTimePicker();
			this.tbApellido = new System.Windows.Forms.TextBox();
			this.tbNombre = new System.Windows.Forms.TextBox();
			this.labelBaja = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnCerrar
			// 
			this.btnCerrar.Location = new System.Drawing.Point(288, 195);
			this.btnCerrar.Name = "btnCerrar";
			this.btnCerrar.Size = new System.Drawing.Size(75, 23);
			this.btnCerrar.TabIndex = 0;
			this.btnCerrar.Text = "Cerrar";
			this.btnCerrar.UseVisualStyleBackColor = true;
			this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
			// 
			// btnGuardar
			// 
			this.btnGuardar.Location = new System.Drawing.Point(171, 195);
			this.btnGuardar.Name = "btnGuardar";
			this.btnGuardar.Size = new System.Drawing.Size(75, 23);
			this.btnGuardar.TabIndex = 1;
			this.btnGuardar.Text = "Guardar";
			this.btnGuardar.UseVisualStyleBackColor = true;
			this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
			// 
			// btnBorrar
			// 
			this.btnBorrar.Location = new System.Drawing.Point(81, 195);
			this.btnBorrar.Name = "btnBorrar";
			this.btnBorrar.Size = new System.Drawing.Size(75, 23);
			this.btnBorrar.TabIndex = 2;
			this.btnBorrar.Text = "Borrar";
			this.btnBorrar.UseVisualStyleBackColor = true;
			this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.dtBaja);
			this.groupBox1.Controls.Add(this.dtAlta);
			this.groupBox1.Controls.Add(this.tbApellido);
			this.groupBox1.Controls.Add(this.tbNombre);
			this.groupBox1.Controls.Add(this.labelBaja);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(351, 168);
			this.groupBox1.TabIndex = 3;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Socio";
			// 
			// dtBaja
			// 
			this.dtBaja.Enabled = false;
			this.dtBaja.Location = new System.Drawing.Point(109, 128);
			this.dtBaja.MaxDate = new System.DateTime(2199, 12, 31, 0, 0, 0, 0);
			this.dtBaja.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
			this.dtBaja.Name = "dtBaja";
			this.dtBaja.Size = new System.Drawing.Size(200, 20);
			this.dtBaja.TabIndex = 7;
			this.dtBaja.Value = new System.DateTime(2016, 11, 3, 0, 0, 0, 0);
			this.dtBaja.Visible = false;
			// 
			// dtAlta
			// 
			this.dtAlta.Enabled = false;
			this.dtAlta.Location = new System.Drawing.Point(109, 102);
			this.dtAlta.MaxDate = new System.DateTime(2099, 12, 31, 0, 0, 0, 0);
			this.dtAlta.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
			this.dtAlta.Name = "dtAlta";
			this.dtAlta.Size = new System.Drawing.Size(200, 20);
			this.dtAlta.TabIndex = 6;
			this.dtAlta.Value = new System.DateTime(2016, 10, 28, 0, 0, 0, 0);
			// 
			// tbApellido
			// 
			this.tbApellido.Location = new System.Drawing.Point(109, 66);
			this.tbApellido.Name = "tbApellido";
			this.tbApellido.Size = new System.Drawing.Size(200, 20);
			this.tbApellido.TabIndex = 5;
			// 
			// tbNombre
			// 
			this.tbNombre.Location = new System.Drawing.Point(109, 37);
			this.tbNombre.Name = "tbNombre";
			this.tbNombre.Size = new System.Drawing.Size(200, 20);
			this.tbNombre.TabIndex = 4;
			// 
			// labelBaja
			// 
			this.labelBaja.AutoSize = true;
			this.labelBaja.Location = new System.Drawing.Point(42, 134);
			this.labelBaja.Name = "labelBaja";
			this.labelBaja.Size = new System.Drawing.Size(31, 13);
			this.labelBaja.TabIndex = 3;
			this.labelBaja.Text = "Baja:";
			this.labelBaja.Visible = false;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(42, 108);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(28, 13);
			this.label3.TabIndex = 2;
			this.label3.Text = "Alta:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(42, 69);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(47, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Apellido:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(42, 40);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(47, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Nombre:";
			// 
			// ABMSocio
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(385, 232);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.btnBorrar);
			this.Controls.Add(this.btnGuardar);
			this.Controls.Add(this.btnCerrar);
			this.Name = "ABMSocio";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "ABM de Socios";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnCerrar;
		private System.Windows.Forms.Button btnGuardar;
		private System.Windows.Forms.Button btnBorrar;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.DateTimePicker dtBaja;
		private System.Windows.Forms.DateTimePicker dtAlta;
		private System.Windows.Forms.TextBox tbApellido;
		private System.Windows.Forms.TextBox tbNombre;
		private System.Windows.Forms.Label labelBaja;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
	}
}