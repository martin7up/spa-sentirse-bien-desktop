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
        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            fechaSeleccionada = e.Start;
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

        private void generarInformeEnUnaFecha()//Se discrimina por tipo de pago
        {
            IEnumerable<Turno> turnosEnFecha = Login.listaTurnos.Where(hs => hs.fechaSolo() == fechaSeleccionada);

            if (turnosEnFecha.Count() == 0)
            {
                MessageBox.Show($"No se registro ningun pago en {fechaSeleccionada.ToString("d")}");
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

            //----------------------------------INFORME DE INGRESOS EN UNA FECHA-----------------------------------------------------------------------------------------------
            string fechaCreacionDeInforme = DateTime.Now.ToString("d"); //(para titulo digamos)

            string[] aux = new string[5]; //Array contenedor de un bloque, no hay mas.
    
            aux[0] = informe.Fecha; //En la que se esta averiguado cuanto se facturo
            aux[1] = informe.PagosCredito.ToString();
            aux[2] = informe.PagosDebito.ToString();
            aux[3] = informe.PagosEfectivo.ToString();
            aux[4] = informe.PagosTransferencia.ToString();
            //Fin del unico bloque.
            
            //--------------------------------------------------------------------------------------------------------------------------------------------------------------------------


            //informe.Fecha = fechaSeleccionada.ToString("d");

            //var json = JsonSerializer.Serialize(informe, new JsonSerializerOptions
            //{
            //    WriteIndented = true // For better readability of the JSON file
            //});

            //File.WriteAllText(@"C:\Users\114R7IN\Desktop\Informes-En-Fecha\informe.json", json);

            //MessageBox.Show("Informe generado.");
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

            //----------------------------------INFORME DE INGRESOS EN UN RANGO DE FECHAS-----------------------------------------------------------------------------------------------
            string desde_hasta = $"{selectedDates.First().ToString("d")} >>> {selectedDates.Last().ToString("d")}"; //Fechas desde y hasta en la consulta del informe(para titulo digamos)
            
            string[] aux = new string[5]; //Array contenedor de un bloque del informe; es Un informe de informes en este caso
            
            foreach(InformePorFecha informe in informeRango.RangoDeInformes)
            {
                aux[0] = informe.Fecha;
                aux[1] = informe.PagosCredito.ToString();
                aux[2] = informe.PagosDebito.ToString();
                aux[3] = informe.PagosEfectivo.ToString();
                aux[4] = informe.PagosTransferencia.ToString();
                //Fin primer bloque; continua al segundo si lo hay, luego al tercero si lo hay, etc...
            }
            //--------------------------------------------------------------------------------------------------------------------------------------------------------------------------
            //var json = JsonSerializer.Serialize(informeRango, new JsonSerializerOptions
            //{
            //    WriteIndented = true // For better readability of the JSON file
            //});

            //File.WriteAllText(@"C:\Users\114R7IN\Desktop\Informes-Por-Rango\informe-Rango.json", json);

            //MessageBox.Show("Informe generado.");
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
    }
}