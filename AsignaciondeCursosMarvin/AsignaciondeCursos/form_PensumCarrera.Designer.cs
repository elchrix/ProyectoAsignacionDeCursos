﻿namespace AsignaciondeCursos
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.cbo_carrera = new System.Windows.Forms.ComboBox();
            this.cbo_pensum = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbo_facultad = new System.Windows.Forms.ComboBox();
            this.btn_conexion = new System.Windows.Forms.Button();
            this.dgv_pensum = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_pensum)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(120, 176);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(111, 21);
            this.comboBox1.TabIndex = 5;
            // 
            // cbo_carrera
            // 
            this.cbo_carrera.FormattingEnabled = true;
            this.cbo_carrera.Location = new System.Drawing.Point(277, 27);
            this.cbo_carrera.Name = "cbo_carrera";
            this.cbo_carrera.Size = new System.Drawing.Size(111, 21);
            this.cbo_carrera.TabIndex = 2;
            this.cbo_carrera.SelectedIndexChanged += new System.EventHandler(this.cbo_carrera_SelectedIndexChanged);
            // 
            // cbo_pensum
            // 
            this.cbo_pensum.FormattingEnabled = true;
            this.cbo_pensum.Location = new System.Drawing.Point(461, 27);
            this.cbo_pensum.Name = "cbo_pensum";
            this.cbo_pensum.Size = new System.Drawing.Size(111, 21);
            this.cbo_pensum.TabIndex = 3;
            this.cbo_pensum.SelectedIndexChanged += new System.EventHandler(this.cbo_pensum_SelectedIndexChanged);
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(120, 149);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(111, 21);
            this.comboBox4.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Facultad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(230, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Carrera";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(410, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Pensum";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(57, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "label5";
            // 
            // cbo_facultad
            // 
            this.cbo_facultad.FormattingEnabled = true;
            this.cbo_facultad.Location = new System.Drawing.Point(81, 27);
            this.cbo_facultad.Name = "cbo_facultad";
            this.cbo_facultad.Size = new System.Drawing.Size(111, 21);
            this.cbo_facultad.TabIndex = 1;
            this.cbo_facultad.SelectedIndexChanged += new System.EventHandler(this.cbo_facultad_SelectedIndexChanged);
            // 
            // btn_conexion
            // 
            this.btn_conexion.Location = new System.Drawing.Point(410, 92);
            this.btn_conexion.Name = "btn_conexion";
            this.btn_conexion.Size = new System.Drawing.Size(75, 23);
            this.btn_conexion.TabIndex = 11;
            this.btn_conexion.Text = "Conexion";
            this.btn_conexion.UseVisualStyleBackColor = true;
            this.btn_conexion.Click += new System.EventHandler(this.btn_conexion_Click);
            // 
            // dgv_pensum
            // 
            this.dgv_pensum.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_pensum.Location = new System.Drawing.Point(30, 248);
            this.dgv_pensum.Name = "dgv_pensum";
            this.dgv_pensum.Size = new System.Drawing.Size(542, 150);
            this.dgv_pensum.TabIndex = 12;
            // 
            // form_PensumCarrera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 432);
            this.Controls.Add(this.dgv_pensum);
            this.Controls.Add(this.btn_conexion);
            this.Controls.Add(this.cbo_facultad);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.cbo_pensum);
            this.Controls.Add(this.cbo_carrera);
            this.Controls.Add(this.comboBox1);
            this.Name = "form_PensumCarrera";
            this.Text = "Pensum";
            this.Load += new System.EventHandler(this.form_PensumCarrera_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_pensum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox cbo_carrera;
        private System.Windows.Forms.ComboBox cbo_pensum;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbo_facultad;
        private System.Windows.Forms.Button btn_conexion;
        private System.Windows.Forms.DataGridView dgv_pensum;
    }
}