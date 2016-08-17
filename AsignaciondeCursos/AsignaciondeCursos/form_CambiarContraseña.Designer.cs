namespace AsignaciondeCursos
{
    partial class form_CambiarContraseña
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_contraseña_actual = new System.Windows.Forms.TextBox();
            this.txt_contraseña_nueva = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_rep_contra_nueva = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_cambiar_contraseña = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese contraseña actual:";
            // 
            // txt_contraseña_actual
            // 
            this.txt_contraseña_actual.Location = new System.Drawing.Point(214, 178);
            this.txt_contraseña_actual.Name = "txt_contraseña_actual";
            this.txt_contraseña_actual.Size = new System.Drawing.Size(203, 20);
            this.txt_contraseña_actual.TabIndex = 1;
            // 
            // txt_contraseña_nueva
            // 
            this.txt_contraseña_nueva.Location = new System.Drawing.Point(214, 250);
            this.txt_contraseña_nueva.Name = "txt_contraseña_nueva";
            this.txt_contraseña_nueva.Size = new System.Drawing.Size(203, 20);
            this.txt_contraseña_nueva.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(74, 257);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ingrese contraseña nueva:";
            // 
            // txt_rep_contra_nueva
            // 
            this.txt_rep_contra_nueva.Location = new System.Drawing.Point(214, 290);
            this.txt_rep_contra_nueva.Name = "txt_rep_contra_nueva";
            this.txt_rep_contra_nueva.Size = new System.Drawing.Size(203, 20);
            this.txt_rep_contra_nueva.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(78, 297);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Repita contraseña nueva:";
            // 
            // btn_cambiar_contraseña
            // 
            this.btn_cambiar_contraseña.Location = new System.Drawing.Point(255, 58);
            this.btn_cambiar_contraseña.Name = "btn_cambiar_contraseña";
            this.btn_cambiar_contraseña.Size = new System.Drawing.Size(65, 65);
            this.btn_cambiar_contraseña.TabIndex = 6;
            this.btn_cambiar_contraseña.Text = "Cambiar";
            this.btn_cambiar_contraseña.UseVisualStyleBackColor = true;
            this.btn_cambiar_contraseña.Click += new System.EventHandler(this.button1_Click);
            // 
            // form_CambiarContraseña
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 455);
            this.Controls.Add(this.btn_cambiar_contraseña);
            this.Controls.Add(this.txt_rep_contra_nueva);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_contraseña_nueva);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_contraseña_actual);
            this.Controls.Add(this.label1);
            this.Name = "form_CambiarContraseña";
            this.Text = "form_CambiarContraseña";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_contraseña_actual;
        private System.Windows.Forms.TextBox txt_contraseña_nueva;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_rep_contra_nueva;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_cambiar_contraseña;
    }
}