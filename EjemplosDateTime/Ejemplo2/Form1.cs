﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPrueba1_Click(object sender, EventArgs e)
        {
            DateTime fecha1;
            fecha1 = dtpFecha.Value;
            MessageBox.Show("La feche es " + fecha1.ToString("dd/MM/yyyy"));
        }

        private void btnPrueba2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("La feche es " + calFecha.SelectionStart);
        }
    }
}
