namespace AsignaciondeCursos
{
    partial class form_MantenimientoFacultad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_MantenimientoFacultad));
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.btn_modificar = new System.Windows.Forms.Button();
            this.dgv_facultad = new System.Windows.Forms.DataGridView();
            this.btn_ingresar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_nombrefacultad = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_actualizar = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_facultad)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Location = new System.Drawing.Point(769, 348);
            this.btn_eliminar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(115, 39);
            this.btn_eliminar.TabIndex = 53;
            this.btn_eliminar.Text = "Eliminar";
            this.toolTip1.SetToolTip(this.btn_eliminar, "Seleccione la fila que desee eliminar, luego dar clic");
            this.btn_eliminar.UseVisualStyleBackColor = true;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // btn_modificar
            // 
            this.btn_modificar.Location = new System.Drawing.Point(769, 295);
            this.btn_modificar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_modificar.Name = "btn_modificar";
            this.btn_modificar.Size = new System.Drawing.Size(115, 36);
            this.btn_modificar.TabIndex = 51;
            this.btn_modificar.Text = "Modificar";
            this.toolTip1.SetToolTip(this.btn_modificar, "Al dar clic en este botón , seguido se mostrara el formulario de modificacion");
            this.btn_modificar.UseVisualStyleBackColor = true;
            this.btn_modificar.Click += new System.EventHandler(this.btn_modificar_Click);
            // 
            // dgv_facultad
            // 
            this.dgv_facultad.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_facultad.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_facultad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_facultad.Location = new System.Drawing.Point(49, 215);
            this.dgv_facultad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_facultad.Name = "dgv_facultad";
            this.dgv_facultad.RowTemplate.Height = 24;
            this.dgv_facultad.Size = new System.Drawing.Size(672, 223);
            this.dgv_facultad.TabIndex = 55;
            // 
            // btn_ingresar
            // 
            this.btn_ingresar.Location = new System.Drawing.Point(779, 82);
            this.btn_ingresar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_ingresar.Name = "btn_ingresar";
            this.btn_ingresar.Size = new System.Drawing.Size(105, 50);
            this.btn_ingresar.TabIndex = 50;
            this.btn_ingresar.Text = "Ingresar";
            this.toolTip1.SetToolTip(this.btn_ingresar, "Al dar clic en este boton se ingresaran los datos de  Facultad\r\n a la base de dat" +
        "os");
            this.btn_ingresar.UseVisualStyleBackColor = true;
            this.btn_ingresar.Click += new System.EventHandler(this.btn_ingresar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(265, 59);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 17);
            this.label4.TabIndex = 57;
            this.label4.Text = "Nombre Facultad:";
            // 
            // txt_nombrefacultad
            // 
            this.txt_nombrefacultad.Location = new System.Drawing.Point(228, 81);
            this.txt_nombrefacultad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_nombrefacultad.Name = "txt_nombrefacultad";
            this.txt_nombrefacultad.Size = new System.Drawing.Size(212, 22);
            this.txt_nombrefacultad.TabIndex = 49;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(104, 81);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 17);
            this.label8.TabIndex = 56;
            this.label8.Text = "Ingrese:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txt_nombrefacultad);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(49, 27);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(672, 182);
            this.groupBox1.TabIndex = 58;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Facultad:";
            // 
            // btn_actualizar
            // 
            this.btn_actualizar.Image = ((System.Drawing.Image)(resources.GetObject("btn_actualizar.Image")));
            this.btn_actualizar.Location = new System.Drawing.Point(769, 404);
            this.btn_actualizar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_actualizar.Name = "btn_actualizar";
            this.btn_actualizar.Size = new System.Drawing.Size(115, 34);
            this.btn_actualizar.TabIndex = 59;
            this.btn_actualizar.UseVisualStyleBackColor = true;
            this.btn_actualizar.Click += new System.EventHandler(this.btn_actualizar_Click);
            // 
            // form_MantenimientoFacultad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 570);
            this.Controls.Add(this.btn_ingresar);
            this.Controls.Add(this.btn_actualizar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.btn_modificar);
            this.Controls.Add(this.dgv_facultad);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "form_MantenimientoFacultad";
            this.Text = "form_MantenimientoFacultad";
            this.Load += new System.EventHandler(this.form_MantenimientoFacultad_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_facultad)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Button btn_modificar;
        private System.Windows.Forms.DataGridView dgv_facultad;
        private System.Windows.Forms.Button btn_ingresar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_nombrefacultad;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_actualizar;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}