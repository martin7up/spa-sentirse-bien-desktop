using iTextSharp.text.pdf;
using iTextSharp.text;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
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
            btGenerarInforme.Enabled = false;

            this.Text = Login.usuario;
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
            CheckBox cc = sender as CheckBox;
            monthCalendar1.Enabled = cc.Checked;
            fechaSeleccionada = DateTime.Now.Date;
        }
        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            fechaSeleccionada = monthCalendar1.SelectionStart.Date;
        }
        private void checkBoxGenerarInforme_CheckedChanged(object sender, EventArgs e)
        {
            monthCalendar1.MaxSelectionCount = checkBoxGenerarInforme.Checked ? 31 : 1;
            btGenerarInforme.Enabled = checkBoxGenerarInforme.Checked;
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
        private void btGenerarInforme_Click(object sender, EventArgs e)
        {
            DateTime inicio = monthCalendar1.SelectionStart;
            DateTime fin = monthCalendar1.SelectionEnd;
            List<DateTime> selectedDates = new List<DateTime>();

            for (DateTime date = inicio; date <= fin; date = date.AddDays(1))
            {
                selectedDates.Add(date.Date);
            }

            if (selectedDates.Count == 0) return;

            //Se recuperan todos los servicios que coinciden con el profesional seleccionado
            IEnumerable<Servicio> servicios = Login.listaServicios.Where(s => s.personal_a_cargo == profesional.id);

            if (servicios.Count() == 0) return;

            InformePorProfesionalEnRango informeRangoPorProfesional = new();// Ver si corresponde colocar mas abajo
            informeRangoPorProfesional.FechaDeInforme = DateTime.Now.ToString("d");//Fecha y hora en la que se esta confeccionando el informe
            informeRangoPorProfesional.ListaInforme = new();

            foreach (DateTime fecha in selectedDates)
            {

                InformeProfesionalEnUnDia informeDia = new(); //Nombre de clase y de vble erroneos, deberia ser InformeDeUnTurno informeTurno ...

                foreach (Servicio servicio in servicios)
                {
                    IEnumerable<Turno> turnos = Login.listaTurnos.Where(t => t.fechaSolo() == fecha).Where(t => t.servicio_id == servicio.id);

                    if (turnos.Count() == 0) continue;

                    Usuario user;

                    foreach (Turno turno in turnos)
                    {
                        user = Login.listaUsuarios.Where(u => u.id == turno.usuario_id).First();

                        informeDia.HoraTurno = turno.fechaTurno().ToString("t");
                        informeDia.FechaTurno = turno.fechaSolo().ToString("d");
                        informeDia.Cliente = user.username;
                        informeDia.DireccionCliente = user.direccion;
                        informeDia.NombreServicio = servicio.nombre;
                        informeDia.PrecioServicio = servicio.precio;
                        informeDia.Profesional = profesional.username;

                        informeRangoPorProfesional.ListaInforme.Add(informeDia);
                    }
                }
            }

            // Generar PDF
            Document documento = new Document();
            string rutaArchivo = @"C:\Users\114R7IN\Desktop\Informes-Por-Profesional\" + $"{profesional.username}-InformeRango_{inicio.ToString("yyyyMMdd")}_{fin.ToString("yyyyMMdd")}.pdf";

            try
            {
                PdfWriter writer = PdfWriter.GetInstance(documento, new FileStream(rutaArchivo, FileMode.Create));
                documento.Open();

                // Cargar el logo
                string rutaLogo = @"C:\Users\114R7IN\Desktop\Facturas-App\logo.jpg"; // Cambia esta ruta al logo que desees
                iTextSharp.text.Image logo = iTextSharp.text.Image.GetInstance(rutaLogo);
                logo.ScaleToFit(100f, 100f); // Ajusta el tamaño del logo
                logo.Alignment = Element.ALIGN_CENTER; // Alinea el logo en el centro
                documento.Add(logo); // Agrega el logo al documento



                // Título del informe
                documento.Add(new Paragraph($"Informe de Servicios Atendidos por {profesional.username}"));
                documento.Add(new Paragraph($"Desde el {selectedDates.First().ToString("d")} hasta el {selectedDates.Last().ToString("d")}"));
                documento.Add(new Paragraph("Fecha de Creación del Informe: " + informeRangoPorProfesional.FechaDeInforme));
                documento.Add(new Paragraph("\n"));

                // Crear tabla
                PdfPTable tabla = new PdfPTable(7); // 7 columnas: Fecha, Hora, Cliente, Dirección, Servicio, Precio, Profesional
                tabla.AddCell("Fecha del Turno");
                tabla.AddCell("Hora del Turno");
                tabla.AddCell("Cliente");
                tabla.AddCell("Dirección del Cliente");
                tabla.AddCell("Servicio");
                tabla.AddCell("Precio");
                tabla.AddCell("Profesional");

                // Llenar la tabla con los datos del informe
                foreach (InformeProfesionalEnUnDia informe in informeRangoPorProfesional.ListaInforme)
                {
                    tabla.AddCell(informe.FechaTurno);
                    tabla.AddCell(informe.HoraTurno);
                    tabla.AddCell(informe.Cliente);
                    tabla.AddCell(informe.DireccionCliente);
                    tabla.AddCell(informe.NombreServicio);
                    tabla.AddCell(informe.PrecioServicio.ToString("C"));
                    tabla.AddCell(informe.Profesional);
                }

                // Agregar la tabla al documento
                documento.Add(tabla);
                documento.Close();

                MessageBox.Show($"Informe generado correctamente!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al generar el informe: {ex.Message}");
            }
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

        private void ClientesPorProfesional_FormClosing(object sender, FormClosingEventArgs e)
        {
            Profesional = null;
        }

        private void ClientesPorProfesional_FormClosed(object sender, FormClosedEventArgs e)
        {
            Login.panelLogin.Visible = true;
        }
        //------------------------------------------------------------------------------------------------------------------------------------------------
    }
}