using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TPI_2024_Parte2.Clases;

namespace TPI_2024_Parte2
{
    public partial class AdministrarServicios : Form
    {
        public AdministrarServicios()
        {
            InitializeComponent();

            cargarComboProfesionales();
            cargarComboCategorias();

            this.Text = Login.usuario;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.ResetText();

            textBox1.Enabled = !checkBox1.Checked;

            if (!checkBox1.Checked) return;

            dataGridServicios.Rows.Clear();

            foreach (Servicio servicio in Login.listaServicios)
            {
                Usuario aCargo = Login.listaUsuarios.Where(usuario => usuario.id == servicio.personal_a_cargo).First();
                CategoriaServicio categoria = Login.listaCategorias.Where(categoria => categoria.id == servicio.categoria_servicio_id).First();
                dataGridServicios.Rows.Add(servicio.nombre, categoria.nombre, servicio.descripcion, servicio.precio, aCargo.username);
            }
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
            Login.refLogin.Visible = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked) return;

            dataGridServicios.Rows.Clear();

            string subString = textBox1.Text.ToLower().Trim();

            if (string.IsNullOrEmpty(subString)) return;

            List<Servicio> coincidencias = Login.listaServicios.Where(servicio => servicio.nombre.ToLower().Contains(subString)).ToList();

            foreach (Servicio servicio in coincidencias)
            {
                Usuario aCargo = Login.listaUsuarios.Where(usuario => usuario.id == servicio.personal_a_cargo).First();
                CategoriaServicio categoria = Login.listaCategorias.Where(categoria => categoria.id == servicio.categoria_servicio_id).First();
                dataGridServicios.Rows.Add(servicio.nombre, categoria.nombre, servicio.descripcion, servicio.precio, aCargo.username);
            }
        }

        private void cargarComboProfesionales()//Esto no deberia de hacerse asi, deberia existir una clase static con metodo que reciban un control ComboBox y una List cualquier y lo cargue al control pasado como argumento.
        {
            foreach (Usuario item in Login.listaUsuarios)
                if (item.rol.Equals("personal"))
                    comboBox1.Items.Add(item);
        }

        private void cargarComboCategorias()
        {
            foreach (CategoriaServicio item in Login.listaCategorias)
                comboBoxCategorias.Items.Add(item);
        }

        private void btGenerarModificar_Click(object sender, EventArgs e)
        {
            if (rbModificarServicio.Checked)
            {
                //Metodo para modificar un servicio
                MessageBox.Show("Ups! Metodo de modificacion de servicios, aun en desarrollo.\nDisculpe las molestias.");
            }
            else
            {
                if(comboBox1.SelectedIndex == -1)
                {
                    MessageBox.Show("Debe elegir a alguien de su personal para el servicio");
                    return;
                }
                if (comboBoxCategorias.SelectedIndex == -1)
                {
                    MessageBox.Show("Debe elegir una categoria.");
                    return;
                }

                string personalId = (comboBox1.SelectedItem as Usuario).id;
                string categoriaId = (comboBoxCategorias.SelectedItem as CategoriaServicio).id;
                string nombreServ = tbNombreServicio.Text.Trim();
                string descripcion = tbDescripcionServicio.Text.Trim();
                int.TryParse(tbPrecioServicio.Text.Trim(),out int precio);

                if(string.IsNullOrEmpty(personalId) || string.IsNullOrEmpty(categoriaId) || string.IsNullOrEmpty(nombreServ) || string.IsNullOrEmpty(descripcion) || precio == 0)
                {
                    MessageBox.Show("Parece que has olvidado rellenar uno o varios campos.\nIntente nuevamente");
                    return;
                }

                Login.bd.crearUnNuevoServicio(nombreServ, descripcion, "", precio, personalId, categoriaId);
                Login.bd.obtenerServiciosYSerializar();
                MessageBox.Show("Turno asentad.");
            }
        }
    }
}
