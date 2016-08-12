namespace AsignaciondeCursos
{
    partial class form_MantenimientosPensum
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_MantenimientosPensum));
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.dgv_pensum = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbo_idcarrera = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_anio = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btn_ingresar = new System.Windows.Forms.Button();
            this.btn_modificar = new System.Windows.Forms.Button();
            this.btn_actualizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_pensum)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Location = new System.Drawing.Point(610, 323);
            this.btn_eliminar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(86, 32);
            this.btn_eliminar.TabIndex = 44;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.UseVisualStyleBackColor = true;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // dgv_pensum
            // 
            this.dgv_pensum.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_pensum.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_pensum.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_pensum.Location = new System.Drawing.Point(14, 200);
            this.dgv_pensum.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_pensum.Name = "dgv_pensum";
            this.dgv_pensum.RowTemplate.Height = 24;
            this.dgv_pensum.Size = new System.Drawing.Size(581, 202);
            this.dgv_pensum.TabIndex = 46;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cbo_idcarrera);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.txt_anio);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Location = new System.Drawing.Point(14, 54);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(581, 129);
            this.groupBox3.TabIndex = 45;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Pensum";
            // 
            // cbo_idcarrera
            // 
            this.cbo_idcarrera.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_idcarrera.FormattingEnabled = true;
            this.cbo_idcarrera.Location = new System.Drawing.Point(148, 48);
            this.cbo_idcarrera.Margin = new System.Windows.Forms.Padding(2);
            this.cbo_idcarrera.Name = "cbo_idcarrera";
            this.cbo_idcarrera.Size = new System.Drawing.Size(204, 21);
            this.cbo_idcarrera.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(76, 50);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 13);
            this.label9.TabIndex = 26;
            this.label9.Text = "Ingrese:";
            // 
            // txt_anio
            // 
            this.txt_anio.Location = new System.Drawing.Point(357, 50);
            this.txt_anio.Name = "txt_anio";
            this.txt_anio.Size = new System.Drawing.Size(75, 20);
            this.txt_anio.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(354, 28);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(87, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "Año del Pensum:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(163, 28);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 13);
            this.label11.TabIndex = 21;
            this.label11.Text = "Carrera:";
            // 
            // btn_ingresar
            // 
            this.btn_ingresar.Location = new System.Drawing.Point(610, 113);
            this.btn_ingresar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_ingresar.Name = "btn_ingresar";
            this.btn_ingresar.Size = new System.Drawing.Size(86, 28);
            this.btn_ingresar.TabIndex = 3;
            this.btn_ingresar.Text = "Ingresar";
            this.btn_ingresar.UseVisualStyleBackColor = true;
            this.btn_ingresar.Click += new System.EventHandler(this.btn_ingresar_Click);
            // 
            // btn_modificar
            // 
            this.btn_modificar.Location = new System.Drawing.Point(610, 265);
            this.btn_modificar.Name = "btn_modificar";
            this.btn_modificar.Size = new System.Drawing.Size(79, 31);
            this.btn_modificar.TabIndex = 47;
            this.btn_modificar.Text = "Modificar";
            this.btn_modificar.UseVisualStyleBackColor = true;
            this.btn_modificar.Click += new System.EventHandler(this.btn_modificar_Click);
            // 
            // btn_actualizar
            // 
            this.btn_actualizar.Image = ((System.Drawing.Image)(resources.GetObject("btn_actualizar.Image")));
            this.btn_actualizar.Location = new System.Drawing.Point(14, 407);
            this.btn_actualizar.Name = "btn_actualizar";
            this.btn_actualizar.Size = new System.Drawing.Size(58, 28);
            this.btn_actualizar.TabIndex = 48;
            this.btn_actualizar.UseVisualStyleBackColor = true;
            this.btn_actualizar.Click += new System.EventHandler(this.btn_actualizar_Click);
            // 
            // form_MantenimientosPensum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 464);
            this.Controls.Add(this.btn_actualizar);
            this.Controls.Add(this.btn_modificar);
            this.Controls.Add(this.btn_ingresar);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.dgv_pensum);
            this.Controls.Add(this.groupBox3);
            this.Name = "form_MantenimientosPensum";
            this.Text = "form_MantenimientosPensum";
            this.Load += new System.EventHandler(this.form_MantenimientosPensum_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_pensum)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.DataGridView dgv_pensum;
        private System.Windows.Forms.GroupBox groupBox3;
        public System.Windows.Forms.ComboBox cbo_idcarrera;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_ingresar;
        public System.Windows.Forms.TextBox txt_anio;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btn_modificar;
        private System.Windows.Forms.Button btn_actualizar;
    }
}