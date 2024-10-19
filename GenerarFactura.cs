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
    public partial class GenerarFactura : Form
    {
        private Usuario cliente;
        private Factura factura;

        public GenerarFactura()
        {
            InitializeComponent();
            cargarComboBox();
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Limpieza de grid
            dataGridTurnosDelCliente.Rows.Clear();

            //Evita que se rompa todo
            if (cbClientes.SelectedIndex < 0) return;

            //Aqui se selecciona un profesional
            cliente = (cbClientes.SelectedItem as Usuario);

            cargarDataGridTurnoDelCliente();
        }
        private void comboBox1_DropDown(object sender, EventArgs e)
        {
            cbClientes.SelectedIndex = -1;
        }
        private void cargarComboBox()
        {
            //En este punto se deberia de actualizar la lista de usuario desde la BD
            foreach (Usuario item in Login.listaUsuarios)
            {
                if (item.rol.Equals("usuario"))
                {
                    cbClientes.Items.Add(item);
                }
            }
        }
        private void cargarDataGridTurnoDelCliente()
        {
            //Se recuperan todos los turno que coinciden con el cliente seleccionado
            IEnumerable<Turno> turnos = Login.listaTurnos.Where(t => t.usuario_id == cliente.id);

            if (turnos.Count() == 0)
            {
                MessageBox.Show("El cliente en cuestion no tiene ningun turno reservado.");
                return;
            }

            Servicio servicio;

            foreach (Turno turno in turnos)
            {
                servicio = Login.listaServicios.Where(s => s.id == turno.servicio_id).First();
                dataGridTurnosDelCliente.Rows.Add(cliente.username, cliente.direccion, turno.fechaTurno().ToString("d"), turno.fechaTurno().ToString("t"), turno.is_pagado, servicio.precio);
            }
        }

        private void btGenerarFactura_Click(object sender, EventArgs e)
        {
            if(dataGridTurnosDelCliente.SelectedRows.Count != 1)
            {
                MessageBox.Show("Seleccione algun registro para generar la factura.");
                return;
            }

            factura = new();

            DataGridViewCellCollection cell = (dataGridTurnosDelCliente.SelectedRows[0].Cells) as DataGridViewCellCollection;

            factura.NombreCliente = cell[0].Value.ToString();
            factura.Direccion = cell[1].Value.ToString();
            factura.FechaTurno = cell[2].Value.ToString();
            factura.HorarioDelTurno = cell[3].Value.ToString();
            factura.Precio = cell[5].Value.ToString();

            var json = JsonSerializer.Serialize(factura, new JsonSerializerOptions
            {
                WriteIndented = true // For better readability of the JSON file
            });

            File.WriteAllText(@"C:\Users\114R7IN\Desktop\Facturas-App\"+$"factura-{factura.NombreCliente}.json", json);
            
            MessageBox.Show("Factura generada.");
        }
    }
}




//var json = File.ReadAllText(@"C:\Users\114R7IN\source\repos\pruebas-FireBase\JASONES\turnos.json");
//listaTurnos = JsonSerializer.Deserialize<List<Turno>>(json);
