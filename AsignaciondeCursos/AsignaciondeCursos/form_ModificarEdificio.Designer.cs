namespace AsignaciondeCursos
{
    partial class form_ModificarEdificio
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_cantsalones = new System.Windows.Forms.TextBox();
            this.Btn_modificaredificio = new System.Windows.Forms.Button();
            this.txt_tamanio = new System.Windows.Forms.TextBox();
            this.txt_pisos = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_idedificio = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txt_cantsalones);
            this.groupBox2.Controls.Add(this.txt_tamanio);
            this.groupBox2.Controls.Add(this.txt_pisos);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txt_idedificio);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(31, 93);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(591, 158);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Eficicio";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 32;
            this.label4.Text = "No. de Pisos:";
            // 
            // txt_cantsalones
            // 
            this.txt_cantsalones.Location = new System.Drawing.Point(497, 82);
            this.txt_cantsalones.Name = "txt_cantsalones";
            this.txt_cantsalones.Size = new System.Drawing.Size(72, 20);
            this.txt_cantsalones.TabIndex = 4;
            // 
            // Btn_modificaredificio
            // 
            this.Btn_modificaredificio.Location = new System.Drawing.Point(288, 24);
            this.Btn_modificaredificio.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_modificaredificio.Name = "Btn_modificaredificio";
            this.Btn_modificaredificio.Size = new System.Drawing.Size(65, 65);
            this.Btn_modificaredificio.TabIndex = 5;
            this.Btn_modificaredificio.Text = "Actualizar";
            this.Btn_modificaredificio.UseVisualStyleBackColor = true;
            this.Btn_modificaredificio.Click += new System.EventHandler(this.Btn_modificaredificio_Click);
            // 
            // txt_tamanio
            // 
            this.txt_tamanio.Location = new System.Drawing.Point(282, 82);
            this.txt_tamanio.Name = "txt_tamanio";
            this.txt_tamanio.Size = new System.Drawing.Size(72, 20);
            this.txt_tamanio.TabIndex = 3;
            // 
            // txt_pisos
            // 
            this.txt_pisos.Location = new System.Drawing.Point(128, 82);
            this.txt_pisos.Name = "txt_pisos";
            this.txt_pisos.Size = new System.Drawing.Size(63, 20);
            this.txt_pisos.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(220, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 27;
            this.label7.Text = "ID Edificio:";
            // 
            // txt_idedificio
            // 
            this.txt_idedificio.Location = new System.Drawing.Point(282, 42);
            this.txt_idedificio.Name = "txt_idedificio";
            this.txt_idedificio.Size = new System.Drawing.Size(72, 20);
            this.txt_idedificio.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(224, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "Tamaño:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(399, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Cantidad Salones:";
            // 
            // form_ModificarEdificio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 282);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.Btn_modificaredificio);
            this.Name = "form_ModificarEdificio";
            this.Text = "form_ModificarEdificio";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txt_cantsalones;
        private System.Windows.Forms.Button Btn_modificaredificio;
        public System.Windows.Forms.TextBox txt_tamanio;
        public System.Windows.Forms.TextBox txt_pisos;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox txt_idedificio;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
    }
}