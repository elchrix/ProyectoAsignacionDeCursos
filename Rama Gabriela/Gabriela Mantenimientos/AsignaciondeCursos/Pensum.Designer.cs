namespace AsignaciondeCursos
{
    partial class eliminar_registros
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
            this.dgv_eliminar_facultad = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_eliminar_facultad)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_eliminar_facultad
            // 
            this.dgv_eliminar_facultad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_eliminar_facultad.Location = new System.Drawing.Point(123, 30);
            this.dgv_eliminar_facultad.Name = "dgv_eliminar_facultad";
            this.dgv_eliminar_facultad.RowTemplate.Height = 24;
            this.dgv_eliminar_facultad.Size = new System.Drawing.Size(633, 231);
            this.dgv_eliminar_facultad.TabIndex = 0;
            this.dgv_eliminar_facultad.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_eliminar_facultad_CellContentClick);
            // 
            // eliminar_registros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 594);
            this.Controls.Add(this.dgv_eliminar_facultad);
            this.Name = "eliminar_registros";
            this.Text = "eliminar_registros";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_eliminar_facultad)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_eliminar_facultad;
    }
}