namespace Árbol___Estructura_de_datos {
	partial class Form1 {
		/// <summary>
		/// Variable del diseñador requerida.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Limpiar los recursos que se estén utilizando.
		/// </summary>
		/// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
		protected override void Dispose (bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose ();
			}
			base.Dispose (disposing);
		}

		#region Código generado por el Diseñador de Windows Forms

		/// <summary>
		/// Método necesario para admitir el Diseñador. No se puede modificar
		/// el contenido del método con el editor de código.
		/// </summary>
		private void InitializeComponent () {
			this.btnCerrar = new System.Windows.Forms.Button();
			this.btnIngresar = new System.Windows.Forms.Button();
			this.btnBuscar = new System.Windows.Forms.Button();
			this.tbdato = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.tbContador = new System.Windows.Forms.TextBox();
			this.btnEliminar = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnCerrar
			// 
			this.btnCerrar.Location = new System.Drawing.Point(200, 119);
			this.btnCerrar.Name = "btnCerrar";
			this.btnCerrar.Size = new System.Drawing.Size(75, 23);
			this.btnCerrar.TabIndex = 0;
			this.btnCerrar.Text = "Cerrar";
			this.btnCerrar.UseVisualStyleBackColor = true;
			this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
			// 
			// btnIngresar
			// 
			this.btnIngresar.Location = new System.Drawing.Point(200, 32);
			this.btnIngresar.Name = "btnIngresar";
			this.btnIngresar.Size = new System.Drawing.Size(75, 23);
			this.btnIngresar.TabIndex = 1;
			this.btnIngresar.Text = "Ingresar";
			this.btnIngresar.UseVisualStyleBackColor = true;
			this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
			// 
			// btnBuscar
			// 
			this.btnBuscar.Location = new System.Drawing.Point(200, 61);
			this.btnBuscar.Name = "btnBuscar";
			this.btnBuscar.Size = new System.Drawing.Size(75, 23);
			this.btnBuscar.TabIndex = 2;
			this.btnBuscar.Text = "Buscar";
			this.btnBuscar.UseVisualStyleBackColor = true;
			this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
			// 
			// tbdato
			// 
			this.tbdato.Location = new System.Drawing.Point(35, 37);
			this.tbdato.Name = "tbdato";
			this.tbdato.Size = new System.Drawing.Size(100, 20);
			this.tbdato.TabIndex = 3;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(42, 88);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(50, 13);
			this.label1.TabIndex = 4;
			this.label1.Text = "Contador";
			// 
			// tbContador
			// 
			this.tbContador.Location = new System.Drawing.Point(103, 85);
			this.tbContador.Name = "tbContador";
			this.tbContador.Size = new System.Drawing.Size(32, 20);
			this.tbContador.TabIndex = 5;
			// 
			// btnEliminar
			// 
			this.btnEliminar.Location = new System.Drawing.Point(200, 90);
			this.btnEliminar.Name = "btnEliminar";
			this.btnEliminar.Size = new System.Drawing.Size(75, 23);
			this.btnEliminar.TabIndex = 6;
			this.btnEliminar.Text = "Eliminar";
			this.btnEliminar.UseVisualStyleBackColor = true;
			this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(290, 156);
			this.Controls.Add(this.btnEliminar);
			this.Controls.Add(this.tbContador);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.tbdato);
			this.Controls.Add(this.btnBuscar);
			this.Controls.Add(this.btnIngresar);
			this.Controls.Add(this.btnCerrar);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnCerrar;
		private System.Windows.Forms.Button btnIngresar;
		private System.Windows.Forms.Button btnBuscar;
		private System.Windows.Forms.TextBox tbdato;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox tbContador;
		private System.Windows.Forms.Button btnEliminar;
	}
}

