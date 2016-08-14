namespace AsignaciondeCursos
{
    partial class form_ModificarPensum
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbo_idcarrera = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_modificar = new System.Windows.Forms.Button();
            this.txt_anio = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cbo_idcarrera);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.btn_modificar);
            this.groupBox3.Controls.Add(this.txt_anio);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Location = new System.Drawing.Point(40, 55);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(775, 159);
            this.groupBox3.TabIndex = 46;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Pensum";
            // 
            // cbo_idcarrera
            // 
            this.cbo_idcarrera.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_idcarrera.Enabled = false;
            this.cbo_idcarrera.FormattingEnabled = true;
            this.cbo_idcarrera.Location = new System.Drawing.Point(197, 59);
            this.cbo_idcarrera.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbo_idcarrera.Name = "cbo_idcarrera";
            this.cbo_idcarrera.Size = new System.Drawing.Size(271, 24);
            this.cbo_idcarrera.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(101, 62);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 17);
            this.label9.TabIndex = 26;
            this.label9.Text = "Ingrese:";
            // 
            // btn_modificar
            // 
            this.btn_modificar.Location = new System.Drawing.Point(325, 108);
            this.btn_modificar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_modificar.Name = "btn_modificar";
            this.btn_modificar.Size = new System.Drawing.Size(115, 34);
            this.btn_modificar.TabIndex = 3;
            this.btn_modificar.Text = "Modificar";
            this.toolTip1.SetToolTip(this.btn_modificar, "Al dar clic en este botón se guardarán los cambios realizados");
            this.btn_modificar.UseVisualStyleBackColor = true;
            this.btn_modificar.Click += new System.EventHandler(this.btn_modificar_Click);
            // 
            // txt_anio
            // 
            this.txt_anio.Location = new System.Drawing.Point(476, 62);
            this.txt_anio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_anio.Name = "txt_anio";
            this.txt_anio.Size = new System.Drawing.Size(99, 22);
            this.txt_anio.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(472, 34);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(115, 17);
            this.label10.TabIndex = 22;
            this.label10.Text = "Año del Pensum:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(217, 34);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 17);
            this.label11.TabIndex = 21;
            this.label11.Text = "Carrera:";
            // 
            // form_ModificarPensum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 277);
            this.Controls.Add(this.groupBox3);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "form_ModificarPensum";
            this.Text = "form_ModificarPensum";
            this.Load += new System.EventHandler(this.form_ModificarPensum_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        public System.Windows.Forms.ComboBox cbo_idcarrera;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_modificar;
        public System.Windows.Forms.TextBox txt_anio;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}