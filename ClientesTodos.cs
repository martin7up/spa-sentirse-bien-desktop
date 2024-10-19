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
        }
        private void cargarClientesTodos()
        {
            dataGridClientes.Rows.Clear();

            foreach (Usuario user in Login.listaUsuarios)
                dataGridClientes.Rows.Add(user.username, user.direccion, user.ciudad);
        }
    }
}
