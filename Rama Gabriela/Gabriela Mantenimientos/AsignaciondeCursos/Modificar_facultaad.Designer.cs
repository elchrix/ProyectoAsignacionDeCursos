namespace AsignaciondeCursos
{
    partial class Modificar_facultaad
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_nombrefacultad = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Btn_ingresarfacultad = new System.Windows.Forms.Button();
            this.txt_idfacultad = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_nombrefacultad);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.Btn_ingresarfacultad);
            this.groupBox1.Controls.Add(this.txt_idfacultad);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Location = new System.Drawing.Point(72, 167);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(775, 250);
            this.groupBox1.TabIndex = 40;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Facultad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(407, 34);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 17);
            this.label4.TabIndex = 47;
            this.label4.Text = "Nombre Facultad:";
            // 
            // txt_nombrefacultad
            // 
            this.txt_nombrefacultad.Location = new System.Drawing.Point(363, 57);
            this.txt_nombrefacultad.Margin = new System.Windows.Forms.Padding(4);
            this.txt_nombrefacultad.Name = "txt_nombrefacultad";
            this.txt_nombrefacultad.Size = new System.Drawing.Size(212, 22);
            this.txt_nombrefacultad.TabIndex = 46;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(101, 59);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 17);
            this.label8.TabIndex = 43;
            this.label8.Text = "Ingrese:";
            // 
            // Btn_ingresarfacultad
            // 
            this.Btn_ingresarfacultad.Location = new System.Drawing.Point(319, 135);
            this.Btn_ingresarfacultad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_ingresarfacultad.Name = "Btn_ingresarfacultad";
            this.Btn_ingresarfacultad.Size = new System.Drawing.Size(115, 34);
            this.Btn_ingresarfacultad.TabIndex = 41;
            this.Btn_ingresarfacultad.Text = "Modificar";
            this.Btn_ingresarfacultad.UseVisualStyleBackColor = true;
            this.Btn_ingresarfacultad.Click += new System.EventHandler(this.Btn_ingresarfacultad_Click);
            // 
            // txt_idfacultad
            // 
            this.txt_idfacultad.Location = new System.Drawing.Point(245, 57);
            this.txt_idfacultad.Margin = new System.Windows.Forms.Padding(4);
            this.txt_idfacultad.Name = "txt_idfacultad";
            this.txt_idfacultad.Size = new System.Drawing.Size(100, 22);
            this.txt_idfacultad.TabIndex = 1;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(261, 34);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(85, 17);
            this.label13.TabIndex = 39;
            this.label13.Text = "Id. Facultad:";
            // 
            // Modificar_facultaad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 604);
            this.Controls.Add(this.groupBox1);
            this.Name = "Modificar_facultaad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Modificar_facultaad";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button Btn_ingresarfacultad;
        private System.Windows.Forms.Label label13;
        public System.Windows.Forms.TextBox txt_nombrefacultad;
        public System.Windows.Forms.TextBox txt_idfacultad;
    }
}