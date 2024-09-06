using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            agregar();
        }

        public void agregar()
        {
            string nombre = tbnombre.Text.Trim();
            if (string.IsNullOrEmpty(nombre))
            {
                MessageBox.Show("No se puede quedar vacio el nombre");
                tbnombre.Focus();
                return;
            }
            cmbnombres.Items.Add(nombre);
            tbnombre.Text = "";
            tbnombre.Focus();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnmover_Click(object sender, EventArgs e)
        {
            int cant = cmbnombres.Items.Count;
            for (int i = 0; i < cant; i++)
            {
                string nombre = cmbnombres.Items[i].ToString();
                cmbnombres2.Items.Add(nombre);
            }
        }
    }
}
