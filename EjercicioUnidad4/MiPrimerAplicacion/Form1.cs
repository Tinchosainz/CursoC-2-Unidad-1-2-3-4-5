using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiPrimerAplicacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Bienvenidos a C#");
        }
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show("Chau Chau ...");
        }

        private void btnBoton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se disparo el evento Click", "Atención");
            if (txtNombre.Text == "")
                txtNombre.BackColor = Color.Red;
            else
                txtNombre.BackColor = System.Drawing.SystemColors.Control;
        }
        private void Form1_Click(object sender, EventArgs e)
        {
            MouseEventArgs click = (MouseEventArgs)e;
            if (click.Button == MouseButtons.Left)
                MessageBox.Show("Presiono el botón Izquierdo", "Atención");
            else if (click.Button == MouseButtons.Right)
                MessageBox.Show("Presiono el Botón Derecho", "Atención");
            else
            if (click.Button == MouseButtons.Middle)
                MessageBox.Show("Presiono el botón del Medio", "Atención");
        }
        private void lblEtiqueta_MouseMove(object sender, MouseEventArgs e)
        {
            lblEtiqueta.BackColor = Color.Cyan;
            lblEtiqueta.Cursor = Cursors.Hand;
        }
        private void lblEtiqueta_MouseLeave(object sender, EventArgs e)
        {
            lblEtiqueta.BackColor = System.Drawing.SystemColors.Control;
            lblEtiqueta.Cursor = Cursors.Arrow;
        }
        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 59) && e.KeyChar != 8)
                e.Handled = true;
        }
        private void txtApellido_Leave(object sender, EventArgs e)
        {
            MessageBox.Show("Tiene " + txtApellido.Text.Length + " Caracteres");
        }
    }
}
