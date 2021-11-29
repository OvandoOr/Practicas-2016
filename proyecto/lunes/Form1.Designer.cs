namespace lunes
{
    partial class Ingresar
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
            this.txt_contra = new System.Windows.Forms.TextBox();
            this.txt_usuario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.butt_salir = new System.Windows.Forms.Button();
            this.butt_ingresar = new System.Windows.Forms.Button();
            this.butt_limpiar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_contra
            // 
            this.txt_contra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_contra.Location = new System.Drawing.Point(170, 179);
            this.txt_contra.Name = "txt_contra";
            this.txt_contra.PasswordChar = '*';
            this.txt_contra.Size = new System.Drawing.Size(187, 26);
            this.txt_contra.TabIndex = 11;
            this.txt_contra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_contra_KeyPress);
            // 
            // txt_usuario
            // 
            this.txt_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_usuario.Location = new System.Drawing.Point(170, 122);
            this.txt_usuario.Name = "txt_usuario";
            this.txt_usuario.Size = new System.Drawing.Size(187, 26);
            this.txt_usuario.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(63, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Contraseña";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nombre de usuario";
            // 
            // butt_salir
            // 
            this.butt_salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butt_salir.Location = new System.Drawing.Point(256, 260);
            this.butt_salir.Name = "butt_salir";
            this.butt_salir.Size = new System.Drawing.Size(101, 38);
            this.butt_salir.TabIndex = 7;
            this.butt_salir.Text = "Salir";
            this.butt_salir.UseVisualStyleBackColor = true;
            this.butt_salir.Click += new System.EventHandler(this.butt_salir_Click);
            // 
            // butt_ingresar
            // 
            this.butt_ingresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butt_ingresar.Location = new System.Drawing.Point(149, 260);
            this.butt_ingresar.Name = "butt_ingresar";
            this.butt_ingresar.Size = new System.Drawing.Size(101, 38);
            this.butt_ingresar.TabIndex = 6;
            this.butt_ingresar.Text = "Ingresar";
            this.butt_ingresar.UseVisualStyleBackColor = true;
            this.butt_ingresar.Click += new System.EventHandler(this.butt_ingresar_Click);
            // 
            // butt_limpiar
            // 
            this.butt_limpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butt_limpiar.Location = new System.Drawing.Point(42, 260);
            this.butt_limpiar.Name = "butt_limpiar";
            this.butt_limpiar.Size = new System.Drawing.Size(101, 38);
            this.butt_limpiar.TabIndex = 12;
            this.butt_limpiar.Text = "Limpiar";
            this.butt_limpiar.UseVisualStyleBackColor = true;
            this.butt_limpiar.Click += new System.EventHandler(this.butt_limpiar_Click);
            // 
            // Ingresar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(371, 323);
            this.Controls.Add(this.butt_limpiar);
            this.Controls.Add(this.txt_contra);
            this.Controls.Add(this.txt_usuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.butt_salir);
            this.Controls.Add(this.butt_ingresar);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Ingresar";
            this.Text = "Iniciar sesion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_contra;
        private System.Windows.Forms.TextBox txt_usuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button butt_salir;
        private System.Windows.Forms.Button butt_ingresar;
        private System.Windows.Forms.Button butt_limpiar;
    }
}