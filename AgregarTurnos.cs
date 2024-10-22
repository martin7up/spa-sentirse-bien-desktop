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
    public partial class AgregarTurnos : Form
    {
        public AgregarTurnos()
        {
            InitializeComponent();
            dateTimePicker2.Format = DateTimePickerFormat.Time;
            cargarComboClientes();
            cargarComboServicios();
            label1.TextAlign = ContentAlignment.MiddleCenter;
            
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            label1.Text = $"{dateTimePicker2.Value.ToString("f")}";
        }

        private void cargarComboClientes()
        {
            foreach (Usuario item in Login.listaUsuarios)
                if (item.rol.Equals("usuario"))
                    comboBoxClientes.Items.Add(item);
        }
        private void cargarComboServicios()
        {
            foreach (Servicio item in Login.listaServicios)
                comboBox2.Items.Add(item);
        }

        private void button1_Click(object sender, EventArgs e)
        {
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
        }

        private void AgregarTurnos_FormClosed(object sender, FormClosedEventArgs e)
        {
            Login.refLogin.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string idUsuario = (comboBoxClientes.SelectedItem as Usuario).id;
            string idServicio = (comboBox2.SelectedItem as Servicio).id;
            DateTime fechaTurno = dateTimePicker2.Value;

            var confirmacion = MessageBox.Show($"Cliente : {(comboBoxClientes.SelectedItem as Usuario).username}\nServicio : {(comboBox2.SelectedItem as Servicio).nombre}\nPrecio : {(comboBox2.SelectedItem as Servicio).precio} $\nFecha reservada : {label1.Text}",
                                       "Son correctos estos datos ¿?",
                                       MessageBoxButtons.YesNo,
                                       MessageBoxIcon.Question);

            if (confirmacion == DialogResult.Yes)
            {
                Login.bd.crearUnNuevoTurno(idUsuario, idServicio, fechaTurno);
                
                MessageBox.Show("Se acento correctamente el turno.");
                
                Login.bd.obtenerTurnosYSerializar();

            }
        }
    }
}
