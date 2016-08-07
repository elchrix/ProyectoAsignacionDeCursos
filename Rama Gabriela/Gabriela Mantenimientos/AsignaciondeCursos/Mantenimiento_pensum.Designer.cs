namespace AsignaciondeCursos
{
    partial class Mantenimiento_pensum
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
            this.cbo_idcarrera = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Btn_ingresarpensum = new System.Windows.Forms.Button();
            this.txt_anio = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dgv_pensum = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_pensum)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cbo_idcarrera);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.Btn_ingresarpensum);
            this.groupBox3.Controls.Add(this.txt_anio);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Location = new System.Drawing.Point(36, 45);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(775, 159);
            this.groupBox3.TabIndex = 41;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Pensum";
            // 
            // cbo_idcarrera
            // 
            this.cbo_idcarrera.FormattingEnabled = true;
            this.cbo_idcarrera.Location = new System.Drawing.Point(245, 59);
            this.cbo_idcarrera.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbo_idcarrera.Name = "cbo_idcarrera";
            this.cbo_idcarrera.Size = new System.Drawing.Size(100, 24);
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
            // Btn_ingresarpensum
            // 
            this.Btn_ingresarpensum.Location = new System.Drawing.Point(325, 108);
            this.Btn_ingresarpensum.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_ingresarpensum.Name = "Btn_ingresarpensum";
            this.Btn_ingresarpensum.Size = new System.Drawing.Size(115, 34);
            this.Btn_ingresarpensum.TabIndex = 3;
            this.Btn_ingresarpensum.Text = "Ingresar";
            this.Btn_ingresarpensum.UseVisualStyleBackColor = true;
            this.Btn_ingresarpensum.Click += new System.EventHandler(this.Btn_ingresarpensum_Click);
            // 
            // txt_anio
            // 
            this.txt_anio.Location = new System.Drawing.Point(355, 62);
            this.txt_anio.Margin = new System.Windows.Forms.Padding(4);
            this.txt_anio.Name = "txt_anio";
            this.txt_anio.Size = new System.Drawing.Size(220, 22);
            this.txt_anio.TabIndex = 2;
            this.txt_anio.TextChanged += new System.EventHandler(this.txt_anio_TextChanged);
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
            // dgv_pensum
            // 
            this.dgv_pensum.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_pensum.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_pensum.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_pensum.Location = new System.Drawing.Point(36, 225);
            this.dgv_pensum.Name = "dgv_pensum";
            this.dgv_pensum.RowTemplate.Height = 24;
            this.dgv_pensum.Size = new System.Drawing.Size(775, 249);
            this.dgv_pensum.TabIndex = 42;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(463, 501);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(115, 39);
            this.button3.TabIndex = 5;
            this.button3.Text = "Eliminar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(302, 501);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 39);
            this.button1.TabIndex = 4;
            this.button1.Text = "Actualizar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Mantenimiento_pensum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 633);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dgv_pensum);
            this.Controls.Add(this.groupBox3);
            this.Name = "Mantenimiento_pensum";
            this.Text = "Mantenimiento_pensum";
            this.Load += new System.EventHandler(this.Mantenimiento_pensum_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_pensum)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        public System.Windows.Forms.ComboBox cbo_idcarrera;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button Btn_ingresarpensum;
        public System.Windows.Forms.TextBox txt_anio;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView dgv_pensum;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
    }
}