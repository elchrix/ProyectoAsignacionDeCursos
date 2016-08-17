namespace AsignaciondeCursos
{
    partial class form_cat
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_cat));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btn_cursos_Activos = new System.Windows.Forms.ToolStripButton();
            this.btn_hisrial = new System.Windows.Forms.ToolStripButton();
            this.btn_cuenta = new System.Windows.Forms.ToolStripDropDownButton();
            this.cambiarContraseñaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesiónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.toolStrip1);
            this.splitContainer1.Size = new System.Drawing.Size(666, 474);
            this.splitContainer1.SplitterDistance = 41;
            this.splitContainer1.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_cursos_Activos,
            this.btn_hisrial,
            this.btn_cuenta});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(666, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btn_cursos_Activos
            // 
            this.btn_cursos_Activos.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btn_cursos_Activos.Image = ((System.Drawing.Image)(resources.GetObject("btn_cursos_Activos.Image")));
            this.btn_cursos_Activos.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_cursos_Activos.Name = "btn_cursos_Activos";
            this.btn_cursos_Activos.Size = new System.Drawing.Size(87, 22);
            this.btn_cursos_Activos.Text = "Cursos activos";
            this.btn_cursos_Activos.Click += new System.EventHandler(this.btn_cursos_Activos_Click);
            // 
            // btn_hisrial
            // 
            this.btn_hisrial.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btn_hisrial.Image = ((System.Drawing.Image)(resources.GetObject("btn_hisrial.Image")));
            this.btn_hisrial.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_hisrial.Name = "btn_hisrial";
            this.btn_hisrial.Size = new System.Drawing.Size(108, 22);
            this.btn_hisrial.Text = "Historial de cursos";
            this.btn_hisrial.Click += new System.EventHandler(this.btn_hisrial_Click);
            // 
            // btn_cuenta
            // 
            this.btn_cuenta.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btn_cuenta.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cambiarContraseñaToolStripMenuItem,
            this.cerrarSesiónToolStripMenuItem});
            this.btn_cuenta.Image = ((System.Drawing.Image)(resources.GetObject("btn_cuenta.Image")));
            this.btn_cuenta.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_cuenta.Name = "btn_cuenta";
            this.btn_cuenta.Size = new System.Drawing.Size(58, 22);
            this.btn_cuenta.Text = "Cuenta";
            // 
            // cambiarContraseñaToolStripMenuItem
            // 
            this.cambiarContraseñaToolStripMenuItem.Name = "cambiarContraseñaToolStripMenuItem";
            this.cambiarContraseñaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cambiarContraseñaToolStripMenuItem.Text = "Cambiar contraseña";
            this.cambiarContraseñaToolStripMenuItem.Click += new System.EventHandler(this.cambiarContraseñaToolStripMenuItem_Click);
            // 
            // cerrarSesiónToolStripMenuItem
            // 
            this.cerrarSesiónToolStripMenuItem.Name = "cerrarSesiónToolStripMenuItem";
            this.cerrarSesiónToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cerrarSesiónToolStripMenuItem.Text = "Cerrar sesión";
            this.cerrarSesiónToolStripMenuItem.Click += new System.EventHandler(this.cerrarSesiónToolStripMenuItem_Click);
            // 
            // form_cat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 474);
            this.Controls.Add(this.splitContainer1);
            this.Name = "form_cat";
            this.Text = "Modulo Catedratico";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.form_cat_FormClosing);
            this.Load += new System.EventHandler(this.form_cat_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btn_cursos_Activos;
        private System.Windows.Forms.ToolStripButton btn_hisrial;
        private System.Windows.Forms.ToolStripDropDownButton btn_cuenta;
        private System.Windows.Forms.ToolStripMenuItem cambiarContraseñaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesiónToolStripMenuItem;
    }
}

