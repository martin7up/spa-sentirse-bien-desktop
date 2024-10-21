using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TPI_2024_Parte2.Clases;

namespace TPI_2024_Parte2
{
    public partial class ClientesTodos : Form
    {
        public ClientesTodos()
        {
            InitializeComponent();

            cargarClientesTodos();

            this.Text = Login.usuario;
        }
        private void cargarClientesTodos()
        {
            dataGridClientes.Rows.Clear();

            foreach (Usuario user in Login.listaUsuarios)
                dataGridClientes.Rows.Add(user.username, user.direccion, user.ciudad);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var confirmacion = MessageBox.Show("Desea cerrar completamente esta ventana?",
                                   "Si / No",
                                   MessageBoxButtons.YesNo,
                                   MessageBoxIcon.Question);

            if (confirmacion == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void ClientesTodos_FormClosed(object sender, FormClosedEventArgs e)
        {
            Login.panelLogin.Visible = true;
        }
    }
}
