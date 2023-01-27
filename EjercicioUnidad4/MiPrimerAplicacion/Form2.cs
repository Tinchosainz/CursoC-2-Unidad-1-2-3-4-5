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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if(txtApellido.Text == "")
                txtApellido.BackColor = Color.Red;
            else
                txtApellido.BackColor = System.Drawing.SystemColors.Control;

            if (txtNombre.Text == "")
                txtNombre.BackColor = Color.Red;
            else
                txtNombre.BackColor = System.Drawing.SystemColors.Control;

            if (txtEdad.Text == "")
                txtEdad.BackColor = Color.Red;
            else
                txtEdad.BackColor = System.Drawing.SystemColors.Control;

            if (txtDireccion.Text == "")
                txtDireccion.BackColor = Color.Red;
            else
                txtDireccion.BackColor = System.Drawing.SystemColors.Control;

            if(txtApellido.BackColor != Color.Red && txtNombre.BackColor != Color.Red && txtEdad.BackColor != Color.Red && txtDireccion.BackColor != Color.Red)
            {
                string Apellido = txtApellido.Text;
                string Nombre = txtNombre.Text;
                string Edad = txtEdad.Text;
                string Direccion = txtDireccion.Text;

                txtResultado.Text = "Apellido y Nombre: " + Apellido + " " + Nombre + " Edad: " + Edad + " Direccion: " + Direccion;
            }
        }

        private void txtEdad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
