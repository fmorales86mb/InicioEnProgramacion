namespace Sistema_Consultorio.Listados {
    partial class Especialidad {
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gvEspecialidad = new System.Windows.Forms.DataGridView();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvEspecialidad)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(547, 100);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.gvEspecialidad);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(547, 276);
            this.panel2.TabIndex = 1;
            // 
            // gvEspecialidad
            // 
            this.gvEspecialidad.AllowUserToAddRows = false;
            this.gvEspecialidad.AllowUserToDeleteRows = false;
            this.gvEspecialidad.AllowUserToResizeColumns = false;
            this.gvEspecialidad.AllowUserToResizeRows = false;
            this.gvEspecialidad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvEspecialidad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvEspecialidad.Location = new System.Drawing.Point(0, 0);
            this.gvEspecialidad.Name = "gvEspecialidad";
            this.gvEspecialidad.ReadOnly = true;
            this.gvEspecialidad.RowHeadersVisible = false;
            this.gvEspecialidad.Size = new System.Drawing.Size(547, 276);
            this.gvEspecialidad.TabIndex = 0;
            this.gvEspecialidad.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvEspecialidad_CellDoubleClick);
            // 
            // Especialidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 376);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Especialidad";
            this.Text = "Especialidad";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Especialidad_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvEspecialidad)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView gvEspecialidad;
    }
}