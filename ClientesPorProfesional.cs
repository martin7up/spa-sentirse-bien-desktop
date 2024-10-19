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
    public partial class ClientesPorProfesional : Form
    {
        //Vbles-------------------------------------------------------------------------------------------------------------------------------------------
        private Usuario profesional;
        private DateTime fechaSeleccionada;
        //------------------------------------------------------------------------------------------------------------------------------------------------
        
        //Constructor-------------------------------------------------------------------------------------------------------------------------------------
        public ClientesPorProfesional()
        {
            InitializeComponent();
            cargarComboBox();

            monthCalendar1.MaxSelectionCount = 1;
            monthCalendar1.Enabled = false;
        }
        //------------------------------------------------------------------------------------------------------------------------------------------------

        //Eventos-----------------------------------------------------------------------------------------------------------------------------------------
        private void cbPersonal_DropDown(object sender, EventArgs e)
        {
            cbPersonal.SelectedIndex = -1;
        }
        private void cbPersonal_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Limpieza de grid
            dataGridPorProfesional.Rows.Clear();

            //Evita que se rompa todo
            if (cbPersonal.SelectedIndex < 0) return;

            //Aqui se selecciona un profesional
            profesional = (cbPersonal.SelectedItem as Usuario);

            //Selecciona si se carga por profesional y fecha o solo por profesional
            if (!checkBoxCalendario.Checked)
            {
                cargarDataGridPorProfesional(profesional);
            }
            else
            {
                cargarDataGridPorProfesionalYFecha(profesional, fechaSeleccionada);
            }
        }
        private void checkBoxCalendario_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cc = sender as CheckBox;    //Recordando la RestoApp de Prog 3
            monthCalendar1.Enabled = cc.Checked;
            fechaSeleccionada = DateTime.Now.Date;
        }
        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            fechaSeleccionada = monthCalendar1.SelectionStart.Date;
        }
        //------------------------------------------------------------------------------------------------------------------------------------------------

        //Metodos-----------------------------------------------------------------------------------------------------------------------------------------
        private void cargarComboBox()
        {
            //En este punto se deberia de actualizar la lista de usuario desde la BD
            foreach (Usuario item in Login.listaUsuarios)
            {
                if (item.rol.Equals("personal"))
                {
                    cbPersonal.Items.Add(item);
                }
            }
        }
        private void cargarDataGridPorProfesional(Usuario profesional)
        {
            //Limpieza del datagrid
            dataGridPorProfesional.Rows.Clear();

            //Se recuperan todos los servicios que coinciden con el profesional seleccionado
            IEnumerable<Servicio> servicios = Login.listaServicios.Where(s => s.personal_a_cargo == profesional.id);

            if (servicios.Count() == 0) return;

            foreach (Servicio servicio in servicios)
            {
                IEnumerable<Turno> turnos = Login.listaTurnos.Where(t => t.servicio_id == servicio.id);

                if (turnos.Count() == 0) continue;

                Usuario user;

                foreach (Turno turno in turnos)
                {
                    user = Login.listaUsuarios.Where(u => u.id == turno.usuario_id).First();
                    dataGridPorProfesional.Rows.Add(user.username, turno.fechaTurno().ToString("t"), turno.fechaSolo().ToString("d"), profesional.username);
                }
            }

        }
        private void cargarDataGridPorProfesionalYFecha(Usuario profesional, DateTime fecha)
        {
            //Limpieza del datagrid
            dataGridPorProfesional.Rows.Clear();

            //Se recuperan todos los servicios que coinciden con el profesional seleccionado
            IEnumerable<Servicio> servicios = Login.listaServicios.Where(s => s.personal_a_cargo == profesional.id);

            if (servicios.Count() == 0) return;

            foreach (Servicio servicio in servicios)
            {
                IEnumerable<Turno> turnos = Login.listaTurnos.Where(t => t.servicio_id == servicio.id).Where(t => t.fechaSolo() == fechaSeleccionada);

                if (turnos.Count() == 0) continue;

                Usuario user;

                foreach (Turno turno in turnos)
                {
                    user = Login.listaUsuarios.Where(u => u.id == turno.usuario_id).First();
                    dataGridPorProfesional.Rows.Add(user.username, turno.fechaTurno().ToString("t"), turno.fechaSolo().ToString("d"), profesional.username);
                }
            }
        }
        //------------------------------------------------------------------------------------------------------------------------------------------------
    }
}