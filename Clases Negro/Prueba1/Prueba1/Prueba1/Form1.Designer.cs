namespace Prueba1
{
	partial class frmPrincipal
	{
		/// <summary>
		/// Variable del diseñador requerida.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Limpiar los recursos que se estén utilizando.
		/// </summary>
		/// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Código generado por el Diseñador de Windows Forms

		/// <summary>
		/// Método necesario para admitir el Diseñador. No se puede modificar
		/// el contenido del método con el editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			this.btnCerrar = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.tbNombre = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.tbNombre2 = new System.Windows.Forms.TextBox();
			this.btnCopiar = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btnBorrar = new System.Windows.Forms.Button();
			this.lbPersona = new System.Windows.Forms.Label();
			this.btnAgregar = new System.Windows.Forms.Button();
			this.tbPersona1 = new System.Windows.Forms.TextBox();
			this.listbPersonas = new System.Windows.Forms.ListBox();
			this.tbBuscador = new System.Windows.Forms.TextBox();
			this.labelBuscador = new System.Windows.Forms.Label();
			this.labelConfirmador = new System.Windows.Forms.Label();
			this.btnConfirmar = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnCerrar
			// 
			this.btnCerrar.Location = new System.Drawing.Point(564, 464);
			this.btnCerrar.Name = "btnCerrar";
			this.btnCerrar.Size = new System.Drawing.Size(75, 23);
			this.btnCerrar.TabIndex = 0;
			this.btnCerrar.Text = "Cerrar";
			this.btnCerrar.UseVisualStyleBackColor = true;
			this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 23);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(44, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Nombre";
			// 
			// tbNombre
			// 
			this.tbNombre.Location = new System.Drawing.Point(62, 20);
			this.tbNombre.Name = "tbNombre";
			this.tbNombre.Size = new System.Drawing.Size(196, 20);
			this.tbNombre.TabIndex = 2;
			this.tbNombre.TextChanged += new System.EventHandler(this.tbNombre_TextChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 49);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(50, 13);
			this.label2.TabIndex = 4;
			this.label2.Text = "Nombre2";
			// 
			// tbNombre2
			// 
			this.tbNombre2.Location = new System.Drawing.Point(62, 46);
			this.tbNombre2.Name = "tbNombre2";
			this.tbNombre2.Size = new System.Drawing.Size(194, 20);
			this.tbNombre2.TabIndex = 5;
			// 
			// btnCopiar
			// 
			this.btnCopiar.Location = new System.Drawing.Point(185, 72);
			this.btnCopiar.Name = "btnCopiar";
			this.btnCopiar.Size = new System.Drawing.Size(71, 25);
			this.btnCopiar.TabIndex = 6;
			this.btnCopiar.Text = "Identificar";
			this.btnCopiar.UseVisualStyleBackColor = true;
			this.btnCopiar.Click += new System.EventHandler(this.btnCopiar_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.btnConfirmar);
			this.groupBox1.Controls.Add(this.labelConfirmador);
			this.groupBox1.Controls.Add(this.labelBuscador);
			this.groupBox1.Controls.Add(this.tbBuscador);
			this.groupBox1.Controls.Add(this.btnBorrar);
			this.groupBox1.Controls.Add(this.lbPersona);
			this.groupBox1.Controls.Add(this.btnAgregar);
			this.groupBox1.Controls.Add(this.tbPersona1);
			this.groupBox1.Controls.Add(this.listbPersonas);
			this.groupBox1.Location = new System.Drawing.Point(281, 20);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(358, 428);
			this.groupBox1.TabIndex = 7;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "groupBox1";
			// 
			// btnBorrar
			// 
			this.btnBorrar.Location = new System.Drawing.Point(242, 132);
			this.btnBorrar.Name = "btnBorrar";
			this.btnBorrar.Size = new System.Drawing.Size(90, 22);
			this.btnBorrar.TabIndex = 4;
			this.btnBorrar.Text = "Borrar";
			this.btnBorrar.UseVisualStyleBackColor = true;
			this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
			// 
			// lbPersona
			// 
			this.lbPersona.AutoSize = true;
			this.lbPersona.Location = new System.Drawing.Point(28, 29);
			this.lbPersona.Name = "lbPersona";
			this.lbPersona.Size = new System.Drawing.Size(46, 13);
			this.lbPersona.TabIndex = 3;
			this.lbPersona.Text = "Persona";
			// 
			// btnAgregar
			// 
			this.btnAgregar.Location = new System.Drawing.Point(242, 24);
			this.btnAgregar.Name = "btnAgregar";
			this.btnAgregar.Size = new System.Drawing.Size(91, 22);
			this.btnAgregar.TabIndex = 2;
			this.btnAgregar.Text = "Agregar";
			this.btnAgregar.UseVisualStyleBackColor = true;
			this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
			// 
			// tbPersona1
			// 
			this.tbPersona1.Location = new System.Drawing.Point(91, 26);
			this.tbPersona1.Name = "tbPersona1";
			this.tbPersona1.Size = new System.Drawing.Size(145, 20);
			this.tbPersona1.TabIndex = 1;
			// 
			// listbPersonas
			// 
			this.listbPersonas.FormattingEnabled = true;
			this.listbPersonas.Location = new System.Drawing.Point(113, 60);
			this.listbPersonas.Name = "listbPersonas";
			this.listbPersonas.Size = new System.Drawing.Size(109, 95);
			this.listbPersonas.TabIndex = 0;
			// 
			// tbBuscador
			// 
			this.tbBuscador.Location = new System.Drawing.Point(99, 226);
			this.tbBuscador.Name = "tbBuscador";
			this.tbBuscador.Size = new System.Drawing.Size(136, 20);
			this.tbBuscador.TabIndex = 5;
			// 
			// labelBuscador
			// 
			this.labelBuscador.AutoSize = true;
			this.labelBuscador.Location = new System.Drawing.Point(41, 229);
			this.labelBuscador.Name = "labelBuscador";
			this.labelBuscador.Size = new System.Drawing.Size(52, 13);
			this.labelBuscador.TabIndex = 7;
			this.labelBuscador.Text = "Buscador";
			// 
			// labelConfirmador
			// 
			this.labelConfirmador.AutoSize = true;
			this.labelConfirmador.Location = new System.Drawing.Point(150, 276);
			this.labelConfirmador.Name = "labelConfirmador";
			this.labelConfirmador.Size = new System.Drawing.Size(0, 13);
			this.labelConfirmador.TabIndex = 8;
			// 
			// btnConfirmar
			// 
			this.btnConfirmar.Location = new System.Drawing.Point(242, 224);
			this.btnConfirmar.Name = "btnConfirmar";
			this.btnConfirmar.Size = new System.Drawing.Size(75, 23);
			this.btnConfirmar.TabIndex = 9;
			this.btnConfirmar.Text = "Confirmar";
			this.btnConfirmar.UseVisualStyleBackColor = true;
			this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
			// 
			// frmPrincipal
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(651, 499);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.btnCopiar);
			this.Controls.Add(this.tbNombre2);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.tbNombre);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnCerrar);
			this.Name = "frmPrincipal";
			this.Text = "Ventana Principal";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnCerrar;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox tbNombre;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox tbNombre2;
		private System.Windows.Forms.Button btnCopiar;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button btnAgregar;
		private System.Windows.Forms.TextBox tbPersona1;
		private System.Windows.Forms.ListBox listbPersonas;
		private System.Windows.Forms.Label lbPersona;
		private System.Windows.Forms.Button btnBorrar;
		private System.Windows.Forms.Button btnConfirmar;
		private System.Windows.Forms.Label labelConfirmador;
		private System.Windows.Forms.Label labelBuscador;
		private System.Windows.Forms.TextBox tbBuscador;
	}
}

