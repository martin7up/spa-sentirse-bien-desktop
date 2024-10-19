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
    public partial class ClientesPorFecha : Form
    {
        public ClientesPorFecha()
        {
            InitializeComponent();

            monthCalendar1.MaxSelectionCount = 1;
        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            fechaSeleccionada =  e.Start;
            cargarClientesTodosPorFecha(fechaSeleccionada);
        }
        
        private void cargarClientesTodosPorFecha(DateTime fechaDesdeCalendario)
        {

            MessageBox.Show($"Fecha {fechaDesdeCalendario.ToString("D")}");

            dataGridClientesPorFecha.Rows.Clear();

            //Se recuperan todos los turnos que coinciden con la fecha seleccionada
            IEnumerable<Turno> turnosEnFecha = Login.listaTurnos.Where(hs => hs.fechaSolo() == fechaSeleccionada);

            if (turnosEnFecha.Count() == 0)
            {
                MessageBox.Show($"Ningun turno en la fecha {fechaDesdeCalendario.ToString("d")}");
                return;
            }


            Usuario user;

            foreach (Turno turno in turnosEnFecha)
            {
                //Como cada turno tiene solo un usuario relacionado, se lo busca y se sabe que solo sera uno; por eso se usa(.First())
                user = Login.listaUsuarios.Where(u => u.id == turno.usuario_id).First();
                dataGridClientesPorFecha.Rows.Add(user.username, user.direccion, turno.fechaSolo(), turno.fechaTurno().ToString("t"));
            }


        }

    }
}
