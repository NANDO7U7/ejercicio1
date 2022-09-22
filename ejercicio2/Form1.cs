using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio2
{

    public partial class Form1 : Form
    {
        public List<Estudiantes> listEstudents = new List<Estudiantes>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregarResgistro_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtID.Text) || string.IsNullOrEmpty(txtNombres.Text) || string.IsNullOrEmpty(txtxApellidos.Text))

            {
                MessageBox.Show("Debio Completar el campo");
            }

            else
            {
                int iD = int.Parse(txtID.Text);
                string nombre = txtNombres.Text;
                string apellidos = txtxApellidos.Text;
                listEstudents.Add(new Estudiantes()
                {
                    Id = iD,
                    Nombres = nombre,
                    Apellidos = apellidos
                });
                MessageBox.Show("Su registro fue agregado con exito ");
                txtID.Clear();
                txtNombres.Clear();
                txtxApellidos.Clear();
            }
        }

        private void btnEnviarDatos_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            if (listEstudents.Count > 0)
            {
                //enviar los datos
                f2.listEstudents = this.listEstudents;
                f2.Show();
            }
            {
                MessageBox.Show("Dbe agregar al menos u  registro");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregarResgistro_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtID.Text) || string.IsNullOrEmpty(txtNombres.Text) || string.IsNullOrEmpty(txtxApellidos.Text))

            {
                MessageBox.Show("Debio Completar el campo");
            }

            else
            {
                int iD = int.Parse(txtID.Text);
                string nombre = txtNombres.Text;
                string apellidos = txtxApellidos.Text;
                listEstudents.Add(new Estudiantes()
                {
                    Id = iD,
                    Nombres = nombre,
                    Apellidos = apellidos
                });
                MessageBox.Show("Su registro fue agregado con exito ");
                txtID.Clear();
                txtNombres.Clear();
                txtxApellidos.Clear();
            }
        }

        private void btnEnviarDatos_Click_1(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            if (listEstudents.Count > 0)
            {
                //enviar los datos
                f2.listEstudents = this.listEstudents;
                f2.Show();
            }
            {
                MessageBox.Show("Dbe agregar al menos u  registro");

                {

                }

            }
        }
    }
}
    