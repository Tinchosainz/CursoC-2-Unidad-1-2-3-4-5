using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSaludar_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Hola Mundo");
            string texto = txtNombre.Text;
            lblMostrarNombre.Text = "Hola " + texto;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("Bokita");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //MessageBox.Show("River descendido");
        }
    }
}
