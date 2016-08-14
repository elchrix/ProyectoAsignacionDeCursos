namespace AsignaciondeCursos
{
    partial class form_PensumCarrera
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
            this.cbo_carrera = new System.Windows.Forms.ComboBox();
            this.cbo_pensum = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbo_facultad = new System.Windows.Forms.ComboBox();
            this.btn_conexion = new System.Windows.Forms.Button();
            this.btn_vistaprevia = new System.Windows.Forms.Button();
            this.dgv_muestra = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_muestra)).BeginInit();
            this.SuspendLayout();
            // 
            // cbo_carrera
            // 
            this.cbo_carrera.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_carrera.FormattingEnabled = true;
            this.cbo_carrera.Location = new System.Drawing.Point(270, 112);
            this.cbo_carrera.Name = "cbo_carrera";
            this.cbo_carrera.Size = new System.Drawing.Size(127, 21);
            this.cbo_carrera.TabIndex = 2;
            this.toolTip1.SetToolTip(this.cbo_carrera, "Seleccione una carrera");
            this.cbo_carrera.SelectedIndexChanged += new System.EventHandler(this.cbo_carrera_SelectedIndexChanged);
            // 
            // cbo_pensum
            // 
            this.cbo_pensum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_pensum.FormattingEnabled = true;
            this.cbo_pensum.Location = new System.Drawing.Point(468, 112);
            this.cbo_pensum.Name = "cbo_pensum";
            this.cbo_pensum.Size = new System.Drawing.Size(81, 21);
            this.cbo_pensum.TabIndex = 3;
            this.toolTip1.SetToolTip(this.cbo_pensum, "Seleccione el año de pensum correspondiente");
            this.cbo_pensum.SelectedIndexChanged += new System.EventHandler(this.cbo_pensum_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Facultad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(223, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Carrera";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(417, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Pensum";
            // 
            // cbo_facultad
            // 
            this.cbo_facultad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_facultad.FormattingEnabled = true;
            this.cbo_facultad.Location = new System.Drawing.Point(74, 112);
            this.cbo_facultad.Name = "cbo_facultad";
            this.cbo_facultad.Size = new System.Drawing.Size(129, 21);
            this.cbo_facultad.TabIndex = 1;
            this.toolTip1.SetToolTip(this.cbo_facultad, "Seleccione una facultad");
            this.cbo_facultad.SelectedIndexChanged += new System.EventHandler(this.cbo_facultad_SelectedIndexChanged);
            // 
            // btn_conexion
            // 
            this.btn_conexion.Location = new System.Drawing.Point(582, 365);
            this.btn_conexion.Name = "btn_conexion";
            this.btn_conexion.Size = new System.Drawing.Size(10, 10);
            this.btn_conexion.TabIndex = 11;
            this.btn_conexion.Text = "Conexion";
            this.btn_conexion.UseVisualStyleBackColor = true;
            this.btn_conexion.Visible = false;
            this.btn_conexion.Click += new System.EventHandler(this.btn_conexion_Click);
            // 
            // btn_vistaprevia
            // 
            this.btn_vistaprevia.Location = new System.Drawing.Point(240, 180);
            this.btn_vistaprevia.Name = "btn_vistaprevia";
            this.btn_vistaprevia.Size = new System.Drawing.Size(98, 50);
            this.btn_vistaprevia.TabIndex = 17;
            this.btn_vistaprevia.Text = "Vista Previa";
            this.toolTip1.SetToolTip(this.btn_vistaprevia, "Genera la vista previa del pensum solicitado");
            this.btn_vistaprevia.UseVisualStyleBackColor = true;
            this.btn_vistaprevia.Click += new System.EventHandler(this.btn_vistaprevia_Click);
            // 
            // dgv_muestra
            // 
            this.dgv_muestra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_muestra.Location = new System.Drawing.Point(23, 252);
            this.dgv_muestra.Name = "dgv_muestra";
            this.dgv_muestra.Size = new System.Drawing.Size(526, 123);
            this.dgv_muestra.TabIndex = 18;
            this.toolTip1.SetToolTip(this.dgv_muestra, "Muestra los datos que quedarán impresos dentro de la vista previa");
            this.dgv_muestra.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(129, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(359, 37);
            this.label4.TabIndex = 19;
            this.label4.Text = "Generador de Pensum";
            // 
            // form_PensumCarrera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 387);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgv_muestra);
            this.Controls.Add(this.btn_vistaprevia);
            this.Controls.Add(this.btn_conexion);
            this.Controls.Add(this.cbo_facultad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbo_pensum);
            this.Controls.Add(this.cbo_carrera);
            this.Name = "form_PensumCarrera";
            this.Text = "Pensum";
            this.Load += new System.EventHandler(this.form_PensumCarrera_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_muestra)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cbo_carrera;
        private System.Windows.Forms.ComboBox cbo_pensum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbo_facultad;
        private System.Windows.Forms.Button btn_conexion;
        private System.Windows.Forms.Button btn_vistaprevia;
        private System.Windows.Forms.DataGridView dgv_muestra;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}