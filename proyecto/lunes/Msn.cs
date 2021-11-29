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
    public partial class Msn : Form
    {
        string Nombre2, Apellido2, Calificacion2,correo2;

        private void Msn_FormClosed(object sender, FormClosedEventArgs e)
        {
            Agregar_Client.Form1Instance.Close();
        }

        int codigo = 1;
        
        public Msn(string Nombre,string Apellido , string Calificacion, string correo)//Ovandillo
        {
            //recivir las variables nombre ,apellido y calificacion en otras variables del segundo form para poder verlas en el datagriview
            InitializeComponent();
            this.Nombre2 = Nombre;
            this.Apellido2 = Apellido;
            this.Calificacion2 = Calificacion;
            this.correo2 = correo;

            dataGridView1.Rows.Add(codigo, Nombre2, Apellido2, Calificacion2, correo2);//para agregar columnas al data grievview
            codigo++;

        }

        private void btnSalir2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
