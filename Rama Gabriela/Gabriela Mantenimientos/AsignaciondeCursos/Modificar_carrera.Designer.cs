namespace AsignaciondeCursos
{
    partial class Modificar_carrera
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
            this.cbo_id__facultad = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_nombre_carrera = new System.Windows.Forms.TextBox();
            this.txt_ciclos = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.txt_carrera = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbo_id__facultad);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_nombre_carrera);
            this.groupBox1.Controls.Add(this.txt_ciclos);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.txt_carrera);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(59, 172);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(775, 159);
            this.groupBox1.TabIndex = 53;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Carrera";
            // 
            // cbo_id__facultad
            // 
            this.cbo_id__facultad.FormattingEnabled = true;
            this.cbo_id__facultad.Location = new System.Drawing.Point(302, 66);
            this.cbo_id__facultad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbo_id__facultad.Name = "cbo_id__facultad";
            this.cbo_id__facultad.Size = new System.Drawing.Size(100, 24);
            this.cbo_id__facultad.TabIndex = 2;
            this.cbo_id__facultad.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(519, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 17);
            this.label1.TabIndex = 37;
            this.label1.Text = "Nombre de Carrera:";
            // 
            // txt_nombre_carrera
            // 
            this.txt_nombre_carrera.Location = new System.Drawing.Point(535, 66);
            this.txt_nombre_carrera.Margin = new System.Windows.Forms.Padding(4);
            this.txt_nombre_carrera.Name = "txt_nombre_carrera";
            this.txt_nombre_carrera.Size = new System.Drawing.Size(100, 22);
            this.txt_nombre_carrera.TabIndex = 4;
            // 
            // txt_ciclos
            // 
            this.txt_ciclos.Location = new System.Drawing.Point(409, 66);
            this.txt_ciclos.Margin = new System.Windows.Forms.Padding(4);
            this.txt_ciclos.Name = "txt_ciclos";
            this.txt_ciclos.Size = new System.Drawing.Size(100, 22);
            this.txt_ciclos.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(299, 37);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 17);
            this.label2.TabIndex = 34;
            this.label2.Text = "Id. Facultad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(101, 65);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 17);
            this.label3.TabIndex = 33;
            this.label3.Text = "Ingrese:";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(341, 109);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(115, 34);
            this.button3.TabIndex = 5;
            this.button3.Text = "Modificar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // txt_carrera
            // 
            this.txt_carrera.Location = new System.Drawing.Point(194, 67);
            this.txt_carrera.Margin = new System.Windows.Forms.Padding(4);
            this.txt_carrera.Name = "txt_carrera";
            this.txt_carrera.Size = new System.Drawing.Size(100, 22);
            this.txt_carrera.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(432, 37);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 17);
            this.label4.TabIndex = 30;
            this.label4.Text = "Ciclos:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(200, 37);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 17);
            this.label5.TabIndex = 29;
            this.label5.Text = "Id. Carrera:";
            // 
            // Modificar_carrera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 604);
            this.Controls.Add(this.groupBox1);
            this.Name = "Modificar_carrera";
            this.Text = "Modificar_carrera";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.ComboBox cbo_id__facultad;
        public System.Windows.Forms.TextBox txt_nombre_carrera;
        public System.Windows.Forms.TextBox txt_ciclos;
        public System.Windows.Forms.TextBox txt_carrera;
    }
}