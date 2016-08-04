namespace AsignaciondeCursos
{
    partial class form_Modificar_Eliminar
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
            this.data = new System.Windows.Forms.DataGridView();
            this.txt_IDcarreram = new System.Windows.Forms.TextBox();
            this.txt_aniom = new System.Windows.Forms.TextBox();
            this.txt_carnem = new System.Windows.Forms.TextBox();
            this.txt_nombre1m = new System.Windows.Forms.TextBox();
            this.txt_nombre2m = new System.Windows.Forms.TextBox();
            this.txt_apellido1m = new System.Windows.Forms.TextBox();
            this.txt_apellido2m = new System.Windows.Forms.TextBox();
            this.txt_correom = new System.Windows.Forms.TextBox();
            this.txt_direccionm = new System.Windows.Forms.TextBox();
            this.txt_fecham = new System.Windows.Forms.TextBox();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.btn_modificarm = new System.Windows.Forms.Button();
            this.carne = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.data)).BeginInit();
            this.SuspendLayout();
            // 
            // data
            // 
            this.data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data.Location = new System.Drawing.Point(23, 234);
            this.data.Name = "data";
            this.data.Size = new System.Drawing.Size(709, 155);
            this.data.TabIndex = 0;
            this.data.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datadoubleclick);
            // 
            // txt_IDcarreram
            // 
            this.txt_IDcarreram.Location = new System.Drawing.Point(89, 22);
            this.txt_IDcarreram.Name = "txt_IDcarreram";
            this.txt_IDcarreram.Size = new System.Drawing.Size(92, 20);
            this.txt_IDcarreram.TabIndex = 1;
            // 
            // txt_aniom
            // 
            this.txt_aniom.Location = new System.Drawing.Point(196, 22);
            this.txt_aniom.Name = "txt_aniom";
            this.txt_aniom.Size = new System.Drawing.Size(100, 20);
            this.txt_aniom.TabIndex = 2;
            // 
            // txt_carnem
            // 
            this.txt_carnem.Location = new System.Drawing.Point(302, 22);
            this.txt_carnem.Name = "txt_carnem";
            this.txt_carnem.Size = new System.Drawing.Size(100, 20);
            this.txt_carnem.TabIndex = 3;
            // 
            // txt_nombre1m
            // 
            this.txt_nombre1m.Location = new System.Drawing.Point(89, 65);
            this.txt_nombre1m.Name = "txt_nombre1m";
            this.txt_nombre1m.Size = new System.Drawing.Size(129, 20);
            this.txt_nombre1m.TabIndex = 4;
            // 
            // txt_nombre2m
            // 
            this.txt_nombre2m.Location = new System.Drawing.Point(283, 65);
            this.txt_nombre2m.Name = "txt_nombre2m";
            this.txt_nombre2m.Size = new System.Drawing.Size(136, 20);
            this.txt_nombre2m.TabIndex = 5;
            // 
            // txt_apellido1m
            // 
            this.txt_apellido1m.Location = new System.Drawing.Point(89, 91);
            this.txt_apellido1m.Name = "txt_apellido1m";
            this.txt_apellido1m.Size = new System.Drawing.Size(129, 20);
            this.txt_apellido1m.TabIndex = 6;
            // 
            // txt_apellido2m
            // 
            this.txt_apellido2m.Location = new System.Drawing.Point(283, 91);
            this.txt_apellido2m.Name = "txt_apellido2m";
            this.txt_apellido2m.Size = new System.Drawing.Size(136, 20);
            this.txt_apellido2m.TabIndex = 7;
            // 
            // txt_correom
            // 
            this.txt_correom.Location = new System.Drawing.Point(89, 126);
            this.txt_correom.Name = "txt_correom";
            this.txt_correom.Size = new System.Drawing.Size(169, 20);
            this.txt_correom.TabIndex = 8;
            // 
            // txt_direccionm
            // 
            this.txt_direccionm.Location = new System.Drawing.Point(89, 152);
            this.txt_direccionm.Name = "txt_direccionm";
            this.txt_direccionm.Size = new System.Drawing.Size(169, 20);
            this.txt_direccionm.TabIndex = 9;
            // 
            // txt_fecham
            // 
            this.txt_fecham.Location = new System.Drawing.Point(89, 178);
            this.txt_fecham.Name = "txt_fecham";
            this.txt_fecham.Size = new System.Drawing.Size(169, 20);
            this.txt_fecham.TabIndex = 10;
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Location = new System.Drawing.Point(494, 34);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(148, 27);
            this.btn_eliminar.TabIndex = 12;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.UseVisualStyleBackColor = true;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // btn_modificarm
            // 
            this.btn_modificarm.Location = new System.Drawing.Point(494, 91);
            this.btn_modificarm.Name = "btn_modificarm";
            this.btn_modificarm.Size = new System.Drawing.Size(148, 30);
            this.btn_modificarm.TabIndex = 13;
            this.btn_modificarm.Text = "Modificar";
            this.btn_modificarm.UseVisualStyleBackColor = true;
            this.btn_modificarm.Click += new System.EventHandler(this.btn_modificarm_Click);
            // 
            // carne
            // 
            this.carne.AutoSize = true;
            this.carne.Location = new System.Drawing.Point(31, 25);
            this.carne.Name = "carne";
            this.carne.Size = new System.Drawing.Size(34, 13);
            this.carne.TabIndex = 14;
            this.carne.Text = "carne";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Nombres";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Apellidos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "correo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "direccion";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "fecha_nac";
            // 
            // form_Modificar_Eliminar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 401);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.carne);
            this.Controls.Add(this.btn_modificarm);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.txt_fecham);
            this.Controls.Add(this.txt_direccionm);
            this.Controls.Add(this.txt_correom);
            this.Controls.Add(this.txt_apellido2m);
            this.Controls.Add(this.txt_apellido1m);
            this.Controls.Add(this.txt_nombre2m);
            this.Controls.Add(this.txt_nombre1m);
            this.Controls.Add(this.txt_carnem);
            this.Controls.Add(this.txt_aniom);
            this.Controls.Add(this.txt_IDcarreram);
            this.Controls.Add(this.data);
            this.Name = "form_Modificar_Eliminar";
            this.Text = "form_Modificar_Eliminar";
            this.Load += new System.EventHandler(this.form_Modificar_Eliminar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView data;
        private System.Windows.Forms.TextBox txt_IDcarreram;
        private System.Windows.Forms.TextBox txt_aniom;
        private System.Windows.Forms.TextBox txt_carnem;
        private System.Windows.Forms.TextBox txt_nombre1m;
        private System.Windows.Forms.TextBox txt_nombre2m;
        private System.Windows.Forms.TextBox txt_apellido1m;
        private System.Windows.Forms.TextBox txt_apellido2m;
        private System.Windows.Forms.TextBox txt_correom;
        private System.Windows.Forms.TextBox txt_direccionm;
        private System.Windows.Forms.TextBox txt_fecham;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Button btn_modificarm;
        private System.Windows.Forms.Label carne;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}