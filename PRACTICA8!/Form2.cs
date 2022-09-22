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
    public partial class Form2 : Form
    {
        public string mensaje;
        public Form2(string mensaje)
        {
            InitializeComponent();
            lblMensaje2.Text = mensaje;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblMensaje_Click(object sender, EventArgs e)
        {

        }

        private void lblMensaje2_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            lblMensaje.Text = mensaje;
        }
    }
}
