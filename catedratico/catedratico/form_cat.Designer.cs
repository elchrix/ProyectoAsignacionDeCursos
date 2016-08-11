namespace catedratico
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btn_cursosact = new System.Windows.Forms.Button();
            this.btn_historial = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btn_cursosact);
            this.splitContainer1.Panel1.Controls.Add(this.btn_historial);
            this.splitContainer1.Size = new System.Drawing.Size(1085, 457);
            this.splitContainer1.SplitterDistance = 243;
            this.splitContainer1.TabIndex = 0;
            // 
            // btn_cursosact
            // 
            this.btn_cursosact.Location = new System.Drawing.Point(32, 212);
            this.btn_cursosact.Name = "btn_cursosact";
            this.btn_cursosact.Size = new System.Drawing.Size(175, 100);
            this.btn_cursosact.TabIndex = 1;
            this.btn_cursosact.Text = "Cursos activos";
            this.btn_cursosact.UseVisualStyleBackColor = true;
            // 
            // btn_historial
            // 
            this.btn_historial.Location = new System.Drawing.Point(32, 38);
            this.btn_historial.Name = "btn_historial";
            this.btn_historial.Size = new System.Drawing.Size(176, 93);
            this.btn_historial.TabIndex = 0;
            this.btn_historial.Text = "Historial de Cursos";
            this.btn_historial.UseVisualStyleBackColor = true;
            this.btn_historial.Click += new System.EventHandler(this.btn_historial_Click);
            // 
            // form_cat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1085, 457);
            this.Controls.Add(this.splitContainer1);
            this.Name = "form_cat";
            this.Text = "Modulo Catedratico";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.form_cat_FormClosing);
            this.Load += new System.EventHandler(this.form_cat_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btn_cursosact;
        private System.Windows.Forms.Button btn_historial;
    }
}

