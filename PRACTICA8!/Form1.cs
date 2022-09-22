using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRACTICA8_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMensaje1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMensaje1.Text))
            {
                MessageBox.Show("Debe cpmpletar el campo solicitado");
            }

            string mensjae = txtMensaje1.Text;
            Form2 f2 = new Form2("");
            f2.mensaje = mensjae;

            f2.Show();
        }

        private void btnmesaje2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMensaje2.Text))
            {
                MessageBox.Show("Debe cpmpletar el campo solicitado");
            }

            string mensjae = txtMensaje2.Text;
            Form2 f2 = new Form2("");
            f2.mensaje = mensjae;

            f2.Show();
        }
    }
}
