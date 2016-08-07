namespace AsignaciondeCursos
{
    partial class form_edificio
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
            this.dgv_edificio = new System.Windows.Forms.DataGridView();
            this.Btn_modificaredifici = new System.Windows.Forms.Button();
            this.Btn_actualizar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_cantsalones = new System.Windows.Forms.TextBox();
            this.Btn_ingresaredificio = new System.Windows.Forms.Button();
            this.txt_tamanio = new System.Windows.Forms.TextBox();
            this.txt_pisos = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_idedificio = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Btn_elimnar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_edificio)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_edificio
            // 
            this.dgv_edificio.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_edificio.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_edificio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_edificio.Location = new System.Drawing.Point(23, 274);
            this.dgv_edificio.Name = "dgv_edificio";
            this.dgv_edificio.RowTemplate.Height = 24;
            this.dgv_edificio.Size = new System.Drawing.Size(774, 226);
            this.dgv_edificio.TabIndex = 5;
            // 
            // Btn_modificaredifici
            // 
            this.Btn_modificaredifici.Location = new System.Drawing.Point(268, 538);
            this.Btn_modificaredifici.Name = "Btn_modificaredifici";
            this.Btn_modificaredifici.Size = new System.Drawing.Size(118, 47);
            this.Btn_modificaredifici.TabIndex = 7;
            this.Btn_modificaredifici.Text = "Modificar";
            this.Btn_modificaredifici.UseVisualStyleBackColor = true;
            this.Btn_modificaredifici.Click += new System.EventHandler(this.Btn_modificaredifici_Click);
            // 
            // Btn_actualizar
            // 
            this.Btn_actualizar.BackgroundImage = global::AsignaciondeCursos.Properties.Resources.refresh2;
            this.Btn_actualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Btn_actualizar.Location = new System.Drawing.Point(13, 538);
            this.Btn_actualizar.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_actualizar.Name = "Btn_actualizar";
            this.Btn_actualizar.Size = new System.Drawing.Size(63, 44);
            this.Btn_actualizar.TabIndex = 8;
            this.Btn_actualizar.UseVisualStyleBackColor = true;
            this.Btn_actualizar.Click += new System.EventHandler(this.boton_actualizar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txt_cantsalones);
            this.groupBox2.Controls.Add(this.Btn_ingresaredificio);
            this.groupBox2.Controls.Add(this.txt_tamanio);
            this.groupBox2.Controls.Add(this.txt_pisos);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txt_idedificio);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(23, 11);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(788, 247);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Eficicio";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(76, 103);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 17);
            this.label4.TabIndex = 32;
            this.label4.Text = "No. de Pisos:";
            // 
            // txt_cantsalones
            // 
            this.txt_cantsalones.Location = new System.Drawing.Point(663, 101);
            this.txt_cantsalones.Margin = new System.Windows.Forms.Padding(4);
            this.txt_cantsalones.Name = "txt_cantsalones";
            this.txt_cantsalones.Size = new System.Drawing.Size(95, 22);
            this.txt_cantsalones.TabIndex = 31;
            // 
            // Btn_ingresaredificio
            // 
            this.Btn_ingresaredificio.Location = new System.Drawing.Point(302, 180);
            this.Btn_ingresaredificio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_ingresaredificio.Name = "Btn_ingresaredificio";
            this.Btn_ingresaredificio.Size = new System.Drawing.Size(125, 44);
            this.Btn_ingresaredificio.TabIndex = 28;
            this.Btn_ingresaredificio.Text = "Ingresar";
            this.Btn_ingresaredificio.UseVisualStyleBackColor = true;
            this.Btn_ingresaredificio.Click += new System.EventHandler(this.Btn_ingresaredificio_Click);
            // 
            // txt_tamanio
            // 
            this.txt_tamanio.Location = new System.Drawing.Point(376, 101);
            this.txt_tamanio.Margin = new System.Windows.Forms.Padding(4);
            this.txt_tamanio.Name = "txt_tamanio";
            this.txt_tamanio.Size = new System.Drawing.Size(95, 22);
            this.txt_tamanio.TabIndex = 30;
            // 
            // txt_pisos
            // 
            this.txt_pisos.Location = new System.Drawing.Point(171, 101);
            this.txt_pisos.Margin = new System.Windows.Forms.Padding(4);
            this.txt_pisos.Name = "txt_pisos";
            this.txt_pisos.Size = new System.Drawing.Size(83, 22);
            this.txt_pisos.TabIndex = 29;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(300, 52);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 17);
            this.label7.TabIndex = 27;
            this.label7.Text = "ID Edificio:";
            // 
            // txt_idedificio
            // 
            this.txt_idedificio.Location = new System.Drawing.Point(376, 52);
            this.txt_idedificio.Margin = new System.Windows.Forms.Padding(4);
            this.txt_idedificio.Name = "txt_idedificio";
            this.txt_idedificio.Size = new System.Drawing.Size(95, 22);
            this.txt_idedificio.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(299, 103);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 17);
            this.label6.TabIndex = 26;
            this.label6.Text = "Tamaño:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(532, 101);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 17);
            this.label5.TabIndex = 25;
            this.label5.Text = "Cantidad Salones:";
            // 
            // Btn_elimnar
            // 
            this.Btn_elimnar.Location = new System.Drawing.Point(413, 538);
            this.Btn_elimnar.Name = "Btn_elimnar";
            this.Btn_elimnar.Size = new System.Drawing.Size(118, 47);
            this.Btn_elimnar.TabIndex = 10;
            this.Btn_elimnar.Text = "Eliminar";
            this.Btn_elimnar.UseVisualStyleBackColor = true;
            this.Btn_elimnar.Click += new System.EventHandler(this.Btn_elimnar_Click);
            // 
            // form_edificio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 631);
            this.Controls.Add(this.Btn_elimnar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.Btn_actualizar);
            this.Controls.Add(this.Btn_modificaredifici);
            this.Controls.Add(this.dgv_edificio);
            this.Name = "form_edificio";
            this.Text = "form_edificio";
            this.Load += new System.EventHandler(this.form_edificio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_edificio)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgv_edificio;
        private System.Windows.Forms.Button Btn_modificaredifici;
        private System.Windows.Forms.Button Btn_actualizar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_cantsalones;
        private System.Windows.Forms.Button Btn_ingresaredificio;
        private System.Windows.Forms.TextBox txt_tamanio;
        private System.Windows.Forms.TextBox txt_pisos;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_idedificio;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Btn_elimnar;
    }
}