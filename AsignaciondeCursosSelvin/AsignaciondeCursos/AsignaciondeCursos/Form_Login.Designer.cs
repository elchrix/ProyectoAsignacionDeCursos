namespace AsignaciondeCursos
{
    partial class Form_Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Login));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_usuario = new System.Windows.Forms.TextBox();
            this.txt_contraseña = new System.Windows.Forms.TextBox();
            this.rdb_cate = new System.Windows.Forms.RadioButton();
            this.rdb_admin = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_logear = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(163, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(163, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Contraseña";
            // 
            // txt_usuario
            // 
            this.txt_usuario.Location = new System.Drawing.Point(252, 90);
            this.txt_usuario.Name = "txt_usuario";
            this.txt_usuario.Size = new System.Drawing.Size(178, 20);
            this.txt_usuario.TabIndex = 2;
            // 
            // txt_contraseña
            // 
            this.txt_contraseña.Location = new System.Drawing.Point(252, 149);
            this.txt_contraseña.Name = "txt_contraseña";
            this.txt_contraseña.Size = new System.Drawing.Size(178, 20);
            this.txt_contraseña.TabIndex = 3;
            // 
            // rdb_cate
            // 
            this.rdb_cate.AutoSize = true;
            this.rdb_cate.Location = new System.Drawing.Point(344, 208);
            this.rdb_cate.Name = "rdb_cate";
            this.rdb_cate.Size = new System.Drawing.Size(79, 17);
            this.rdb_cate.TabIndex = 4;
            this.rdb_cate.TabStop = true;
            this.rdb_cate.Text = "Catedrático";
            this.rdb_cate.UseVisualStyleBackColor = true;
            // 
            // rdb_admin
            // 
            this.rdb_admin.AutoSize = true;
            this.rdb_admin.Location = new System.Drawing.Point(251, 208);
            this.rdb_admin.Name = "rdb_admin";
            this.rdb_admin.Size = new System.Drawing.Size(90, 17);
            this.rdb_admin.TabIndex = 5;
            this.rdb_admin.TabStop = true;
            this.rdb_admin.Text = "Administrativa";
            this.rdb_admin.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(163, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tipo de cuenta:";
            // 
            // btn_logear
            // 
            this.btn_logear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_logear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_logear.Location = new System.Drawing.Point(201, 286);
            this.btn_logear.Name = "btn_logear";
            this.btn_logear.Size = new System.Drawing.Size(184, 75);
            this.btn_logear.TabIndex = 7;
            this.btn_logear.Text = "Logear";
            this.btn_logear.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_logear.UseVisualStyleBackColor = true;
            this.btn_logear.Click += new System.EventHandler(this.btn_logear_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(216, 301);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(51, 49);
            this.panel1.TabIndex = 8;
            // 
            // Form_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 392);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_logear);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rdb_admin);
            this.Controls.Add(this.rdb_cate);
            this.Controls.Add(this.txt_contraseña);
            this.Controls.Add(this.txt_usuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form_Login";
            this.Text = "Form_Login";
            this.Load += new System.EventHandler(this.Form_Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_usuario;
        private System.Windows.Forms.TextBox txt_contraseña;
        private System.Windows.Forms.RadioButton rdb_cate;
        private System.Windows.Forms.RadioButton rdb_admin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_logear;
        private System.Windows.Forms.Panel panel1;
    }
}