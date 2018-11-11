namespace Sistema_Consultorio {
    partial class FormularioPrincipal {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuArchivo = new System.Windows.Forms.ToolStripMenuItem();
            this.menuArchivoSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.menuListadosEspecialidad = new System.Windows.Forms.ToolStripMenuItem();
            this.especialidadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.obraSocialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.profecionalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuNuevo = new System.Windows.Forms.ToolStripMenuItem();
            this.menuNuevoEspecialidad = new System.Windows.Forms.ToolStripMenuItem();
            this.profesionalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estadoDelTratamientoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressBar1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 307);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(417, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 16);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuArchivo,
            this.menuListadosEspecialidad,
            this.menuNuevo});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(417, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuArchivo
            // 
            this.menuArchivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuArchivoSalir});
            this.menuArchivo.Name = "menuArchivo";
            this.menuArchivo.Size = new System.Drawing.Size(60, 20);
            this.menuArchivo.Text = "Archivo";
            // 
            // menuArchivoSalir
            // 
            this.menuArchivoSalir.Name = "menuArchivoSalir";
            this.menuArchivoSalir.Size = new System.Drawing.Size(96, 22);
            this.menuArchivoSalir.Text = "Salir";
            this.menuArchivoSalir.Click += new System.EventHandler(this.menuArchivoSalir_Click);
            // 
            // menuListadosEspecialidad
            // 
            this.menuListadosEspecialidad.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.especialidadToolStripMenuItem,
            this.obraSocialToolStripMenuItem,
            this.profecionalToolStripMenuItem,
            this.usuariosToolStripMenuItem});
            this.menuListadosEspecialidad.Name = "menuListadosEspecialidad";
            this.menuListadosEspecialidad.Size = new System.Drawing.Size(62, 20);
            this.menuListadosEspecialidad.Text = "Listados";
            // 
            // especialidadToolStripMenuItem
            // 
            this.especialidadToolStripMenuItem.Name = "especialidadToolStripMenuItem";
            this.especialidadToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.especialidadToolStripMenuItem.Text = "Especialidades";
            this.especialidadToolStripMenuItem.Click += new System.EventHandler(this.especialidadToolStripMenuItem_Click);
            // 
            // obraSocialToolStripMenuItem
            // 
            this.obraSocialToolStripMenuItem.Name = "obraSocialToolStripMenuItem";
            this.obraSocialToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.obraSocialToolStripMenuItem.Text = "Obras Sociales";
            // 
            // profecionalToolStripMenuItem
            // 
            this.profecionalToolStripMenuItem.Name = "profecionalToolStripMenuItem";
            this.profecionalToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.profecionalToolStripMenuItem.Text = "Profecionales";
            this.profecionalToolStripMenuItem.Click += new System.EventHandler(this.profecionalToolStripMenuItem_Click);
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.usuariosToolStripMenuItem.Text = "Usuarios";
            // 
            // menuNuevo
            // 
            this.menuNuevo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuNuevoEspecialidad,
            this.profesionalToolStripMenuItem,
            this.estadoDelTratamientoToolStripMenuItem});
            this.menuNuevo.Name = "menuNuevo";
            this.menuNuevo.Size = new System.Drawing.Size(54, 20);
            this.menuNuevo.Text = "Nuevo";
            // 
            // menuNuevoEspecialidad
            // 
            this.menuNuevoEspecialidad.Name = "menuNuevoEspecialidad";
            this.menuNuevoEspecialidad.Size = new System.Drawing.Size(196, 22);
            this.menuNuevoEspecialidad.Text = "Especialidad";
            this.menuNuevoEspecialidad.Click += new System.EventHandler(this.menuNuevoEspecialidad_Click);
            // 
            // profesionalToolStripMenuItem
            // 
            this.profesionalToolStripMenuItem.Name = "profesionalToolStripMenuItem";
            this.profesionalToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.profesionalToolStripMenuItem.Text = "Profesional";
            this.profesionalToolStripMenuItem.Click += new System.EventHandler(this.profesionalToolStripMenuItem_Click);
            // 
            // estadoDelTratamientoToolStripMenuItem
            // 
            this.estadoDelTratamientoToolStripMenuItem.Name = "estadoDelTratamientoToolStripMenuItem";
            this.estadoDelTratamientoToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.estadoDelTratamientoToolStripMenuItem.Text = "Estado del Tratamiento";
            this.estadoDelTratamientoToolStripMenuItem.Click += new System.EventHandler(this.estadoDelTratamientoToolStripMenuItem_Click);
            // 
            // FormularioPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 329);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormularioPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultorio";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuArchivo;
        private System.Windows.Forms.ToolStripMenuItem menuArchivoSalir;
        private System.Windows.Forms.ToolStripMenuItem menuListadosEspecialidad;
        private System.Windows.Forms.ToolStripMenuItem especialidadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuNuevo;
        private System.Windows.Forms.ToolStripMenuItem menuNuevoEspecialidad;
        private System.Windows.Forms.ToolStripMenuItem obraSocialToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem profecionalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.ToolStripMenuItem profesionalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estadoDelTratamientoToolStripMenuItem;

    }
}