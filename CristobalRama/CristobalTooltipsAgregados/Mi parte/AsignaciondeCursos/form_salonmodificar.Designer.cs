namespace AsignaciondeCursos
{
    partial class form_salonmodificar
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbo_estatus = new System.Windows.Forms.ComboBox();
            this.Btn_actualizar = new System.Windows.Forms.Button();
            this.txt_cantaprox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_tamanio = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbo_edificio = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txt_no_salon = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cbo_estatus);
            this.groupBox1.Controls.Add(this.Btn_actualizar);
            this.groupBox1.Controls.Add(this.txt_cantaprox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_tamanio);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbo_edificio);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.txt_no_salon);
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Controls.Add(this.label22);
            this.groupBox1.Location = new System.Drawing.Point(24, 210);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(774, 210);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Salon";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(570, 96);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 17);
            this.label3.TabIndex = 43;
            this.label3.Text = "Estatus:";
            // 
            // cbo_estatus
            // 
            this.cbo_estatus.FormattingEnabled = true;
            this.cbo_estatus.Items.AddRange(new object[] {
            "Vacio",
            "Ocupado"});
            this.cbo_estatus.Location = new System.Drawing.Point(636, 94);
            this.cbo_estatus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbo_estatus.Name = "cbo_estatus";
            this.cbo_estatus.Size = new System.Drawing.Size(107, 24);
            this.cbo_estatus.TabIndex = 42;
            // 
            // Btn_actualizar
            // 
            this.Btn_actualizar.Location = new System.Drawing.Point(326, 149);
            this.Btn_actualizar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_actualizar.Name = "Btn_actualizar";
            this.Btn_actualizar.Size = new System.Drawing.Size(115, 34);
            this.Btn_actualizar.TabIndex = 37;
            this.Btn_actualizar.Text = "Actualizar";
            this.toolTip1.SetToolTip(this.Btn_actualizar, "Al dar clic en este se guardaran los cambios realizados");
            this.Btn_actualizar.UseVisualStyleBackColor = true;
            this.Btn_actualizar.Click += new System.EventHandler(this.Btn_actualizar_Click);
            // 
            // txt_cantaprox
            // 
            this.txt_cantaprox.Location = new System.Drawing.Point(427, 96);
            this.txt_cantaprox.Margin = new System.Windows.Forms.Padding(4);
            this.txt_cantaprox.Name = "txt_cantaprox";
            this.txt_cantaprox.Size = new System.Drawing.Size(95, 22);
            this.txt_cantaprox.TabIndex = 41;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(288, 96);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 17);
            this.label2.TabIndex = 40;
            this.label2.Text = "Capacidad Aprox.";
            // 
            // txt_tamanio
            // 
            this.txt_tamanio.Location = new System.Drawing.Point(156, 96);
            this.txt_tamanio.Margin = new System.Windows.Forms.Padding(4);
            this.txt_tamanio.Name = "txt_tamanio";
            this.txt_tamanio.Size = new System.Drawing.Size(95, 22);
            this.txt_tamanio.TabIndex = 39;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 96);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 17);
            this.label1.TabIndex = 38;
            this.label1.Text = "Tamaño:";
            // 
            // cbo_edificio
            // 
            this.cbo_edificio.FormattingEnabled = true;
            this.cbo_edificio.Location = new System.Drawing.Point(427, 54);
            this.cbo_edificio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbo_edificio.Name = "cbo_edificio";
            this.cbo_edificio.Size = new System.Drawing.Size(83, 24);
            this.cbo_edificio.TabIndex = 36;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(409, 61);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(13, 17);
            this.label15.TabIndex = 35;
            this.label15.Text = "-";
            // 
            // txt_no_salon
            // 
            this.txt_no_salon.Location = new System.Drawing.Point(315, 56);
            this.txt_no_salon.Margin = new System.Windows.Forms.Padding(4);
            this.txt_no_salon.Name = "txt_no_salon";
            this.txt_no_salon.Size = new System.Drawing.Size(83, 22);
            this.txt_no_salon.TabIndex = 32;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(323, 35);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(74, 17);
            this.label20.TabIndex = 33;
            this.label20.Text = "No. Salon:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(431, 35);
            this.label22.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(70, 17);
            this.label22.TabIndex = 34;
            this.label22.Text = "ID Edificio";
            // 
            // form_salonmodificar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 631);
            this.Controls.Add(this.groupBox1);
            this.Name = "form_salonmodificar";
            this.Text = "form_salonmodificar";
            this.Load += new System.EventHandler(this.form_salonmodificar_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Btn_actualizar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label22;
        public System.Windows.Forms.TextBox txt_cantaprox;
        public System.Windows.Forms.TextBox txt_tamanio;
        public System.Windows.Forms.TextBox txt_no_salon;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.ComboBox cbo_edificio;
        public System.Windows.Forms.ComboBox cbo_estatus;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}