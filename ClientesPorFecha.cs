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
    public partial class ClientesPorFecha : Form
    {
        public ClientesPorFecha()
        {
            InitializeComponent();
            monthCalendar1.MaxSelectionCount = 1;

            this.Text = Login.usuario;

            Login.cargarTurnos();
        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            fechaSeleccionada = e.Start;
            cargarClientesTodosPorFecha(fechaSeleccionada);
        }

        private void cargarClientesTodosPorFecha(DateTime fechaDesdeCalendario)
        {

            dataGridClientesPorFecha.Rows.Clear();

            //Se recuperan todos los turnos que coinciden con la fecha seleccionada
            IEnumerable<Turno> turnosEnFecha = Login.listaTurnos.Where(hs => hs.fechaSolo() == fechaSeleccionada);

            if (turnosEnFecha.Count() == 0)
            {

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

        private void generarInformeEnUnaFecha()//Se discrimina por tipo de pago
        {
            IEnumerable<Turno> turnosEnFecha = Login.listaTurnos.Where(hs => hs.fechaSolo() == fechaSeleccionada);

            if (turnosEnFecha.Count() == 0)
            {

                return;
            }

            InformePorFecha informe = new();

            foreach (Turno turno in turnosEnFecha)
            {

                if (!turno.is_pagado) continue;

                Servicio servicio = Login.listaServicios.Where(s => s.id == turno.servicio_id).First();


                switch (turno.metodo_de_pago)
                {
                    case "debito":
                        informe.PagosDebito += servicio.precio;
                        break;

                    case "credito":
                        informe.PagosCredito += servicio.precio;
                        break;

                    case "transferencia":
                        informe.PagosTransferencia += servicio.precio;
                        break;

                    case "efectivo":
                        informe.PagosEfectivo += servicio.precio;
                        break;
                }

            }
            MessageBox.Show($"Credito{informe.PagosCredito}-Debito{informe.PagosDebito}-Efectivo{informe.PagosEfectivo}-Transf{informe.PagosTransferencia}");

            // Generación del PDF
            Document documento = new Document();
            string rutaArchivo = @"C:\Users\114R7IN\Desktop\Informes-En-Fecha" + fechaSeleccionada.ToString("yyyyMMdd") + ".pdf";

            try
            {
                PdfWriter writer = PdfWriter.GetInstance(documento, new FileStream(rutaArchivo, FileMode.Create));
                documento.Open();

                string rutaLogo = @"C:\Users\114R7IN\Desktop\Facturas-App\logo.jpg"; // Cambia esta ruta al logo que desees
                iTextSharp.text.Image logo = iTextSharp.text.Image.GetInstance(rutaLogo);
                logo.ScaleToFit(100f, 100f); // Ajusta el tamaño del logo
                logo.Alignment = Element.ALIGN_CENTER; // Alinea el logo en el centro
                documento.Add(logo); // Agrega el logo al documento

                documento.Add(new Paragraph("Informe de Pagos - Fecha: " + fechaSeleccionada.ToString("d")));
                documento.Add(new Paragraph("\n"));

                PdfPTable tabla = new PdfPTable(5);
                tabla.AddCell("Fecha");
                tabla.AddCell("Pagos Crédito");
                tabla.AddCell("Pagos Débito");
                tabla.AddCell("Pagos Efectivo");
                tabla.AddCell("Pagos Transferencia");

                tabla.AddCell(fechaSeleccionada.ToString("d"));
                tabla.AddCell(informe.PagosCredito.ToString("C"));
                tabla.AddCell(informe.PagosDebito.ToString("C"));
                tabla.AddCell(informe.PagosEfectivo.ToString("C"));
                tabla.AddCell(informe.PagosTransferencia.ToString("C"));

                documento.Add(tabla);
                documento.Close();

                MessageBox.Show($"Informe generado correctamente!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al generar el informe: {ex.Message}");
            }
        }

        private void generarInformeEnUnRangoDeFechas()//Se discrimina por tipo de pago
        {
            DateTime inicio = monthCalendar1.SelectionStart;
            DateTime fin = monthCalendar1.SelectionEnd;
            List<DateTime> selectedDates = new List<DateTime>();

            for (DateTime date = inicio; date <= fin; date = date.AddDays(1))
                selectedDates.Add(date.Date);

            InformePorRangoDeFechas informeRango = new();
            informeRango.RangoDeInformes = new();//Instancia para la lista de Informes por cada fecha en el rango
            foreach (DateTime date in selectedDates)
            {
                IEnumerable<Turno> turnosEnFecha = Login.listaTurnos.Where(hs => hs.fechaSolo() == date);
                if (turnosEnFecha.Count() == 0) continue;
                InformePorFecha informe = new();
                foreach (Turno turno in turnosEnFecha)
                {
                    if (!turno.is_pagado) continue;
                    Servicio servicio = Login.listaServicios.Where(s => s.id == turno.servicio_id).First();
                    switch (turno.metodo_de_pago)
                    {
                        case "debito":
                            informe.PagosDebito += servicio.precio;
                            break;

                        case "credito":
                            informe.PagosCredito += servicio.precio;
                            break;

                        case "transferencia":
                            informe.PagosTransferencia += servicio.precio;
                            break;

                        case "efectivo":
                            informe.PagosEfectivo += servicio.precio;
                            break;
                    }
                }
                informe.Fecha = date.ToString("d");
                informeRango.RangoDeInformes.Add(informe);
            }

            // Generación del PDF
            Document documento = new Document();
            string rutaArchivo = @"C:\Users\114R7IN\Desktop\Informes-Por-Rango" + inicio.ToString("yyyyMMdd") + "_" + fin.ToString("yyyyMMdd") + ".pdf";

            try
            {
                PdfWriter writer = PdfWriter.GetInstance(documento, new FileStream(rutaArchivo, FileMode.Create));
                documento.Open();

                documento.Add(new Paragraph($"Informe de Pagos - Rango de Fechas: {inicio.ToString("d")} a {fin.ToString("d")}"));
                documento.Add(new Paragraph("\n"));

                PdfPTable tabla = new PdfPTable(5);
                tabla.AddCell("Fecha");
                tabla.AddCell("Pagos Crédito");
                tabla.AddCell("Pagos Débito");
                tabla.AddCell("Pagos Efectivo");
                tabla.AddCell("Pagos Transferencia");

                foreach (InformePorFecha informe in informeRango.RangoDeInformes)
                {
                    tabla.AddCell(informe.Fecha);
                    tabla.AddCell(informe.PagosCredito.ToString("C"));
                    tabla.AddCell(informe.PagosDebito.ToString("C"));
                    tabla.AddCell(informe.PagosEfectivo.ToString("C"));
                    tabla.AddCell(informe.PagosTransferencia.ToString("C"));
                }

                documento.Add(tabla);
                documento.Close();

                MessageBox.Show($"Informe generado correctamente!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al generar el informe: {ex.Message}");
            }
        }
        private void checkBoxRangoFechas_CheckedChanged(object sender, EventArgs e)
        {
            monthCalendar1.MaxSelectionCount = checkBoxRangoFechas.Checked ? 31 : 1;
        }
        private void btGeneraInforme_Click(object sender, EventArgs e)
        {
            if (checkBoxRangoFechas.Checked)
                generarInformeEnUnRangoDeFechas();
            else
                generarInformeEnUnaFecha();
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

        private void ClientesPorFecha_FormClosing(object sender, FormClosingEventArgs e)
        {
            monthCalendar1 = null;
        }

        private void ClientesPorFecha_FormClosed(object sender, FormClosedEventArgs e)
        {
            Login.refLogin.Visible = true;
        }
    }
}