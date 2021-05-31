using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formulaarios_y_Menú_C_Sharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ListadosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void SalirToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void bSalir_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("¿Está seguro que desea Salir?", "Salir del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (respuesta == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void bClientes_Click(object sender, EventArgs e)
        {
            Form cli = new Clientes();
            cli.BackColor = Color.Red;
            cli.ShowDialog();
        }

        private void bProveedores_Click(object sender, EventArgs e)
        {
            Form pro = new Proveedores();
            pro.BackColor = Color.Green;
            pro.ShowDialog();
        }

        private void bListados_Click(object sender, EventArgs e)
        {
            Form lis = new Listados();
            lis.BackColor = Color.Blue;
            lis.ShowDialog();
        }

        private void listadosToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Form lis = new Listados();
            lis.BackColor = Color.Blue;
            lis.ShowDialog();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form cli = new Clientes();
            cli.BackColor = Color.Red;
            cli.ShowDialog();
        }

        private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form pro = new Proveedores();
            pro.BackColor = Color.Green;
            pro.ShowDialog();
        }

        private void salirToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("¿Está seguro que desea Salir?", "Salir del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (respuesta == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
