namespace AsignaciondeCursos
{
    partial class agregar_pensum
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Btn_ingresarpensum = new System.Windows.Forms.Button();
            this.cbo_idcarrera = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_anio = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.Btn_ingresarpensum);
            this.groupBox3.Controls.Add(this.cbo_idcarrera);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.txt_anio);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Location = new System.Drawing.Point(33, 192);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(775, 159);
            this.groupBox3.TabIndex = 41;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Pensum";
            // 
            // Btn_ingresarpensum
            // 
            this.Btn_ingresarpensum.Location = new System.Drawing.Point(230, 99);
            this.Btn_ingresarpensum.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_ingresarpensum.Name = "Btn_ingresarpensum";
            this.Btn_ingresarpensum.Size = new System.Drawing.Size(115, 34);
            this.Btn_ingresarpensum.TabIndex = 44;
            this.Btn_ingresarpensum.Text = "Ingresar";
            this.Btn_ingresarpensum.UseVisualStyleBackColor = true;
            this.Btn_ingresarpensum.Click += new System.EventHandler(this.Btn_ingresarpensum_Click_1);
            // 
            // cbo_idcarrera
            // 
            this.cbo_idcarrera.FormattingEnabled = true;
            this.cbo_idcarrera.Location = new System.Drawing.Point(245, 59);
            this.cbo_idcarrera.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbo_idcarrera.Name = "cbo_idcarrera";
            this.cbo_idcarrera.Size = new System.Drawing.Size(100, 24);
            this.cbo_idcarrera.TabIndex = 39;
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
            // txt_anio
            // 
            this.txt_anio.Location = new System.Drawing.Point(355, 62);
            this.txt_anio.Margin = new System.Windows.Forms.Padding(4);
            this.txt_anio.Name = "txt_anio";
            this.txt_anio.Size = new System.Drawing.Size(220, 22);
            this.txt_anio.TabIndex = 25;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(412, 34);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(115, 17);
            this.label10.TabIndex = 22;
            this.label10.Text = "Año del Pensum:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(243, 34);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(79, 17);
            this.label11.TabIndex = 21;
            this.label11.Text = "Id. Carrera:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(390, 99);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 46);
            this.button1.TabIndex = 45;
            this.button1.Text = "Ir a Mantenimiento";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // agregar_pensum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 633);
            this.Controls.Add(this.groupBox3);
            this.Name = "agregar_pensum";
            this.Text = "pensuum";
            this.Load += new System.EventHandler(this.pensuum_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cbo_idcarrera;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_anio;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button Btn_ingresarpensum;
        private System.Windows.Forms.Button button1;
    }
}