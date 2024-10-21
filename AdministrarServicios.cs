using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPI_2024_Parte2
{
    public partial class AdministrarServicios : Form
    {
        public AdministrarServicios()
        {
            InitializeComponent();

            this.Text = Login.usuario;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            label1.Enabled = (sender as CheckBox).Checked;
        }

        private void btCerrar_Click(object sender, EventArgs e)
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

        private void AdministrarServicios_FormClosing(object sender, FormClosingEventArgs e)
        {
            /*Nada por aqui de momen*/
        }

        private void AdministrarServicios_FormClosed(object sender, FormClosedEventArgs e)
        {
            Login.panelLogin.Visible = true;
        }
    }
}
