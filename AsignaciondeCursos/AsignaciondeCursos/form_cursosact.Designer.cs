namespace AsignaciondeCursos
{
    partial class form_cursosact
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.aprobado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btn_guardarn = new System.Windows.Forms.Button();
            this.btn_editarnotas = new System.Windows.Forms.Button();
            this.lbl_anio = new System.Windows.Forms.Label();
            this.lbl_semestre = new System.Windows.Forms.Label();
            this.txt_anio = new System.Windows.Forms.TextBox();
            this.txt_semestre = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.aprobado});
            this.dataGridView1.Location = new System.Drawing.Point(56, 136);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(675, 331);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // aprobado
            // 
            this.aprobado.HeaderText = "Aprobado";
            this.aprobado.Name = "aprobado";
            this.aprobado.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.aprobado.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(268, 95);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(242, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btn_guardarn
            // 
            this.btn_guardarn.Location = new System.Drawing.Point(294, 12);
            this.btn_guardarn.Name = "btn_guardarn";
            this.btn_guardarn.Size = new System.Drawing.Size(65, 65);
            this.btn_guardarn.TabIndex = 2;
            this.btn_guardarn.Text = "Guardar notas";
            this.btn_guardarn.UseVisualStyleBackColor = true;
            this.btn_guardarn.Click += new System.EventHandler(this.btn_guardarn_Click);
            // 
            // btn_editarnotas
            // 
            this.btn_editarnotas.Location = new System.Drawing.Point(409, 12);
            this.btn_editarnotas.Name = "btn_editarnotas";
            this.btn_editarnotas.Size = new System.Drawing.Size(65, 65);
            this.btn_editarnotas.TabIndex = 3;
            this.btn_editarnotas.Text = "Editar Notas";
            this.btn_editarnotas.UseVisualStyleBackColor = true;
            this.btn_editarnotas.Click += new System.EventHandler(this.btn_editarnotas_Click);
            // 
            // lbl_anio
            // 
            this.lbl_anio.AutoSize = true;
            this.lbl_anio.Location = new System.Drawing.Point(53, 64);
            this.lbl_anio.Name = "lbl_anio";
            this.lbl_anio.Size = new System.Drawing.Size(26, 13);
            this.lbl_anio.TabIndex = 4;
            this.lbl_anio.Text = "Año";
            // 
            // lbl_semestre
            // 
            this.lbl_semestre.AutoSize = true;
            this.lbl_semestre.Location = new System.Drawing.Point(53, 98);
            this.lbl_semestre.Name = "lbl_semestre";
            this.lbl_semestre.Size = new System.Drawing.Size(51, 13);
            this.lbl_semestre.TabIndex = 5;
            this.lbl_semestre.Text = "Semestre";
            // 
            // txt_anio
            // 
            this.txt_anio.Enabled = false;
            this.txt_anio.Location = new System.Drawing.Point(118, 57);
            this.txt_anio.Name = "txt_anio";
            this.txt_anio.Size = new System.Drawing.Size(78, 20);
            this.txt_anio.TabIndex = 6;
            // 
            // txt_semestre
            // 
            this.txt_semestre.Enabled = false;
            this.txt_semestre.Location = new System.Drawing.Point(118, 91);
            this.txt_semestre.Name = "txt_semestre";
            this.txt_semestre.Size = new System.Drawing.Size(78, 20);
            this.txt_semestre.TabIndex = 7;
            // 
            // form_cursosact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 479);
            this.Controls.Add(this.txt_semestre);
            this.Controls.Add(this.txt_anio);
            this.Controls.Add(this.lbl_semestre);
            this.Controls.Add(this.lbl_anio);
            this.Controls.Add(this.btn_editarnotas);
            this.Controls.Add(this.btn_guardarn);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "form_cursosact";
            this.Text = "form_cursosact";
            this.Load += new System.EventHandler(this.form_cursosact_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btn_guardarn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn aprobado;
        private System.Windows.Forms.Button btn_editarnotas;
        private System.Windows.Forms.Label lbl_anio;
        private System.Windows.Forms.Label lbl_semestre;
        private System.Windows.Forms.TextBox txt_anio;
        private System.Windows.Forms.TextBox txt_semestre;
    }
}