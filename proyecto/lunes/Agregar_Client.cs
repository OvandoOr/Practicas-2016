using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace lunes
{
    public partial class Agregar_Client : Form
    {
        public static Agregar_Client Form1Instance;

        public Agregar_Client()
        {
            Form1Instance = this;
            InitializeComponent();
        }

        public static bool ComprobarFormatoEmail(string email)
        {
            
            String sFormato;
            sFormato = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(email, sFormato))
            {
                if (Regex.Replace(email, sFormato, String.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        //validacion del textbox1
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Solo letras","Vales pa pura verga");
            }
            }
        //validacion del textbox2
        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Solo letras", "Vales pa pura verga");
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Solo Numeros", "Vales pa pura verga");
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
             //mandar la informacion al otro FORM Msn
            string Nombre = textBox1.Text;
            string Apellido = textBox2.Text;
            string Calificacion = textBox3.Text;
            string correo = txtCorreo.Text;
            this.Hide();
            ;

            Msn recibe = new Msn(Nombre,Apellido,Calificacion,correo);//en el parentesis va el parametro y tengo que agregar lo que aagrego el ovandillo
            recibe.Show();
            
            
        }
        //validacion de la caja de texto del correo
        private void txtCorreo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (ComprobarFormatoEmail(txtCorreo.Text) == false)
            {
                error_correo.Clear();
                error_correo.SetError(txtCorreo, "Dirección no valida");
                txtCorreo.ForeColor = Color.Red;
            }
            else
            {
                error_correo.Clear();
                txtCorreo.ForeColor = Color.Green;
            }
        }
    }
    }
