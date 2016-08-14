namespace AsignaciondeCursos
{
    partial class form_modificar_facultad
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
            this.label4 = new System.Windows.Forms.Label();
            this.txt_nombrefacultad = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_modificar = new System.Windows.Forms.Button();
            this.txt_idfacultad = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(340, 48);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 17);
            this.label4.TabIndex = 53;
            this.label4.Text = "Nombre Facultad:";
            // 
            // txt_nombrefacultad
            // 
            this.txt_nombrefacultad.Location = new System.Drawing.Point(296, 70);
            this.txt_nombrefacultad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_nombrefacultad.Name = "txt_nombrefacultad";
            this.txt_nombrefacultad.Size = new System.Drawing.Size(212, 22);
            this.txt_nombrefacultad.TabIndex = 52;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(35, 73);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 17);
            this.label8.TabIndex = 51;
            this.label8.Text = "Ingrese:";
            // 
            // btn_modificar
            // 
            this.btn_modificar.Location = new System.Drawing.Point(252, 149);
            this.btn_modificar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_modificar.Name = "btn_modificar";
            this.btn_modificar.Size = new System.Drawing.Size(115, 34);
            this.btn_modificar.TabIndex = 50;
            this.btn_modificar.Text = "Modificar";
            this.toolTip1.SetToolTip(this.btn_modificar, "Al dar clic en este boton se guardaran los cambios realizados");
            this.btn_modificar.UseVisualStyleBackColor = true;
            this.btn_modificar.Click += new System.EventHandler(this.btn_modificar_Click);
            // 
            // txt_idfacultad
            // 
            this.txt_idfacultad.Location = new System.Drawing.Point(179, 70);
            this.txt_idfacultad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_idfacultad.Name = "txt_idfacultad";
            this.txt_idfacultad.ReadOnly = true;
            this.txt_idfacultad.Size = new System.Drawing.Size(100, 22);
            this.txt_idfacultad.TabIndex = 48;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(195, 48);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(85, 17);
            this.label13.TabIndex = 49;
            this.label13.Text = "Id. Facultad:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.txt_nombrefacultad);
            this.groupBox1.Controls.Add(this.txt_idfacultad);
            this.groupBox1.Controls.Add(this.btn_modificar);
            this.groupBox1.Location = new System.Drawing.Point(76, 73);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(553, 247);
            this.groupBox1.TabIndex = 54;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Modificar:";
            // 
            // form_modificar_facultad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 433);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "form_modificar_facultad";
            this.Text = "form_modificar_facultad";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txt_nombrefacultad;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_modificar;
        public System.Windows.Forms.TextBox txt_idfacultad;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}