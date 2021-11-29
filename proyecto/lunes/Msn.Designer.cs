namespace lunes
{
    partial class Msn
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
            this.btnSalir2 = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Calificacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalir2
            // 
            this.btnSalir2.Location = new System.Drawing.Point(339, 37);
            this.btnSalir2.Name = "btnSalir2";
            this.btnSalir2.Size = new System.Drawing.Size(75, 23);
            this.btnSalir2.TabIndex = 1;
            this.btnSalir2.Text = "Salir";
            this.btnSalir2.UseVisualStyleBackColor = true;
            this.btnSalir2.Click += new System.EventHandler(this.btnSalir2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Nombre,
            this.Apellidos,
            this.Calificacion,
            this.Correo});
            this.dataGridView1.Location = new System.Drawing.Point(2, 89);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(534, 150);
            this.dataGridView1.TabIndex = 2;
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // Apellidos
            // 
            this.Apellidos.HeaderText = "Apellidos";
            this.Apellidos.Name = "Apellidos";
            // 
            // Calificacion
            // 
            this.Calificacion.HeaderText = "Calificacion";
            this.Calificacion.Name = "Calificacion";
            // 
            // Correo
            // 
            this.Correo.HeaderText = "Correo";
            this.Correo.Name = "Correo";
            // 
            // Msn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 261);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnSalir2);
            this.Name = "Msn";
            this.Text = "Msn";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Msn_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnSalir2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Calificacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Correo;
    }
}