using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lunes
{
    public partial class Ingresar : Form
    {
        string nombre;
        string contra;

        public Ingresar()
        {
            InitializeComponent();
            
        }

        private void butt_salir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void butt_ingresar_Click(object sender, EventArgs e)
        {
            nombre = txt_usuario.Text;
            contra = txt_contra.Text;

            if (nombre == "jose" && contra == "123")
            {
                MessageBox.Show("Bienvenido: " + nombre);
                Close();
            }

            else
                MessageBox.Show("Intete de nuevo");

            

        }

        private void butt_limpiar_Click(object sender, EventArgs e)
        {
            txt_usuario.Clear();
            txt_contra.Clear();
        }

        private void txt_contra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetterOrDigit(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
                contra = txt_contra.Text;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Solo Numeros y letras", "Vales pa pura verga");
            }
            

        }
    }
}
