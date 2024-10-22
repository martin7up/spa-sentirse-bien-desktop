using System.Data;
using iTextSharp.text;
using iTextSharp.text.pdf;
using TPI_2024_Parte2.Clases;
using iTextSharp.text.pdf.draw;
using System.Diagnostics;



namespace TPI_2024_Parte2
{//Faltaria poder cambiar el valor de is_pagado y impactarlo en BD
    public partial class GenerarFactura : Form
    {
        private Usuario cliente;
        private Factura factura;
        public GenerarFactura()
        {

            InitializeComponent();
            
            Login.cargarTurnos();

            cargarComboBox();
            panelPago.Enabled = false;
            dataGridTurnosDelCliente.Rows.Clear();
            btHabDeshab.Text = "";

            this.Text = Login.usuario;
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
                dataGridTurnosDelCliente.Rows.Add(cliente.username, cliente.direccion, turno.fechaTurno().ToString("d"), turno.fechaTurno().ToString("t"), turno.is_pagado ? "Pagado" : "Pendiente", servicio.precio, turno.metodo_de_pago, turno.is_cancelado ? "Cancelado" : "Vigente", turno.id);
            }
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
        private void btGenerarFactura_Click(object sender, EventArgs e)
        {
            if (dataGridTurnosDelCliente.SelectedRows.Count != 1)
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

            string logoPath = @"C:\Users\114R7IN\Desktop\Facturas-App\logo.jpg"; // Cambia esto a la ruta de tu logo
            string pdfPath = @"C:\Users\114R7IN\Desktop\Facturas-App" + $"factura-{factura.NombreCliente}.pdf";

            try
            {
                Document pdfDoc = new Document(PageSize.A4, 50, 50, 50, 50); // Añadir márgenes
                PdfWriter.GetInstance(pdfDoc, new FileStream(pdfPath, FileMode.Create));

                pdfDoc.Open();

                // Agregar logo
                if (File.Exists(logoPath))
                {
                    iTextSharp.text.Image logo = iTextSharp.text.Image.GetInstance(logoPath);
                    logo.ScaleToFit(100f, 100f);
                    logo.Alignment = Element.ALIGN_CENTER; // Centrar el logo
                    pdfDoc.Add(logo);
                }

                // Título del spa
                Paragraph tituloSpa = new Paragraph("Spa - Sentirse Bien", FontFactory.GetFont("Arial", Convert.ToString(18), Font.Bold));
                tituloSpa.Alignment = Element.ALIGN_CENTER; // Centrar el título
                pdfDoc.Add(tituloSpa);

                // Espacio en blanco
                pdfDoc.Add(new Paragraph(" "));

                // Título de factura
                Paragraph tituloFactura = new Paragraph("Factura", FontFactory.GetFont("Arial", Convert.ToString(16), Font.Bold));
                tituloFactura.Alignment = Element.ALIGN_CENTER;
                pdfDoc.Add(tituloFactura);

                pdfDoc.Add(new Paragraph(" ")); // Espacio en blanco

                // Número de factura y fecha de emisión
                Paragraph detallesFactura = new Paragraph($"Fecha de Emisión: {DateTime.Now.ToString("dd/MM/yyyy")}", FontFactory.GetFont("Arial", 12));
                detallesFactura.Alignment = Element.ALIGN_RIGHT;
                pdfDoc.Add(detallesFactura);

                pdfDoc.Add(new Paragraph(" ")); // Espacio en blanco


                // Crear tabla de datos con bordes visibles
                PdfPTable table = new PdfPTable(2);
                table.WidthPercentage = 100; // Ancho de la tabla ajustado al 100% del documento
                float[] widths = new float[] { 1f, 2f }; // Definir ancho de columnas
                table.SetWidths(widths);

                // Formato para las celdas de los títulos (negrita)
                PdfPCell cellLeftTitle = new PdfPCell()
                {
                    BackgroundColor = new BaseColor(230, 230, 230), // Color de fondo para las celdas de título
                    Padding = 5, // Espaciado interno
                    BorderWidth = 1, // Grosor del borde
                    HorizontalAlignment = Element.ALIGN_LEFT
                };

                // Formato para las celdas de los valores
                PdfPCell cellRightValue = new PdfPCell()
                {
                    Padding = 5,
                    BorderWidth = 1,
                    HorizontalAlignment = Element.ALIGN_LEFT
                };

                // Agregar datos a la tabla
                cellLeftTitle.Phrase = new Phrase("Nombre del Cliente:", FontFactory.GetFont("Arial", Convert.ToString(12), Font.Bold));
                cellRightValue.Phrase = new Phrase(factura.NombreCliente, FontFactory.GetFont("Arial", 12));
                table.AddCell(cellLeftTitle);
                table.AddCell(cellRightValue);

                cellLeftTitle.Phrase = new Phrase("Dirección:", FontFactory.GetFont("Arial", Convert.ToString(12), Font.Bold));
                cellRightValue.Phrase = new Phrase(factura.Direccion, FontFactory.GetFont("Arial", 12));
                table.AddCell(cellLeftTitle);
                table.AddCell(cellRightValue);

                cellLeftTitle.Phrase = new Phrase("Fecha del Turno:", FontFactory.GetFont("Arial", Convert.ToString(12), Font.Bold));
                cellRightValue.Phrase = new Phrase(factura.FechaTurno, FontFactory.GetFont("Arial", 12));
                table.AddCell(cellLeftTitle);
                table.AddCell(cellRightValue);

                cellLeftTitle.Phrase = new Phrase("Horario del Turno:", FontFactory.GetFont("Arial", Convert.ToString(12), Font.Bold));
                cellRightValue.Phrase = new Phrase(factura.HorarioDelTurno, FontFactory.GetFont("Arial", 12));
                table.AddCell(cellLeftTitle);
                table.AddCell(cellRightValue);

                // Formato para el precio (moneda)
                decimal precio = decimal.Parse(factura.Precio);
                string precioFormateado = precio.ToString("C", System.Globalization.CultureInfo.GetCultureInfo("es-AR")); // Ajusta a tu moneda

                cellLeftTitle.Phrase = new Phrase("Precio:", FontFactory.GetFont("Arial", Convert.ToString(12), Font.Bold));
                cellRightValue.Phrase = new Phrase(precioFormateado, FontFactory.GetFont("Arial", 12));
                table.AddCell(cellLeftTitle);
                table.AddCell(cellRightValue);

                // Agregar la tabla al documento
                pdfDoc.Add(table);

                pdfDoc.Add(new Paragraph(" ")); // Espacio en blanco

                // Agregar una línea divisoria
                pdfDoc.Add(new LineSeparator(1f, 100f, BaseColor.BLACK, Element.ALIGN_CENTER, -2));

                // Pie de página
                Paragraph piePagina = new Paragraph("Gracias por elegir nuestros servicios.", FontFactory.GetFont("Arial", Convert.ToString(10), Font.Italic));
                piePagina.Alignment = Element.ALIGN_CENTER;
                pdfDoc.Add(piePagina);

                pdfDoc.Close();

                // Previsualizar el PDF al finalizar
                Process.Start(new ProcessStartInfo(pdfPath) { UseShellExecute = true });

                MessageBox.Show("Factura generada correctamente en PDF.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al generar el PDF: " + ex.Message);
            }

        }

        private void dataGridTurnosDelCliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            panelPago.Enabled = dataGridTurnosDelCliente.SelectedRows[0].Cells[4].Value.ToString().Equals("Pendiente");
            btHabDeshab.Text = dataGridTurnosDelCliente.SelectedRows[0].Cells[7].Value.ToString().Equals("Cancelado") ? "Restaurar Turno" : "Cancelar Turno";
        }

        private void btAsentarPago_Click(object sender, EventArgs e)
        {
            string medio = "";

            if (rbCredito.Checked) medio = rbCredito.Text.ToLower();
            if (rbDebito.Checked) medio = rbDebito.Text.ToLower();
            if (rbEfectivo.Checked) medio = rbEfectivo.Text.ToLower();
            if (rbTransferencia.Checked) medio = rbTransferencia.Text.ToLower();

            Login.bd.pagarUnTurno(dataGridTurnosDelCliente.SelectedRows[0].Cells[8].Value.ToString(), medio);//>>>Modificacion en BD

            MessageBox.Show($"Pago efectuado; medio : {medio}");

            //MessageBox.Show($"Pago efectuado; id turno : {dataGridTurnosDelCliente.SelectedRows[0].Cells[8].Value.ToString()}");

            Login.cargarTurnos();//>>>Carga desde BD

            dataGridTurnosDelCliente.Rows.Clear();

            panelPago.Enabled = false;

            cargarDataGridTurnoDelCliente();

        }

        private void btHabDeshab_Click(object sender, EventArgs e)
        {
            bool valor = !dataGridTurnosDelCliente.SelectedRows[0].Cells[7].Value.ToString().Equals("Cancelado");

            Login.bd.habilitarODeshabilitarUnTurno(dataGridTurnosDelCliente.SelectedRows[0].Cells[8].Value.ToString(), valor);//>>>Modificacion en BD

            //MessageBox.Show($"Se modifico el turno {dataGridTurnosDelCliente.SelectedRows[0].Cells[8].Value.ToString()}");

            MessageBox.Show("Turno modificado!");

            Login.cargarTurnos();//>>>Carga desde BD

            dataGridTurnosDelCliente.Rows.Clear();

            btHabDeshab.Text = "";

            cargarDataGridTurnoDelCliente();

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

        private void GenerarFactura_FormClosed(object sender, FormClosedEventArgs e)
        {
            Login.refLogin.Visible = true;
        }
    }
}

//var json = File.ReadAllText(@"C:\Users\114R7IN\source\repos\pruebas-FireBase\JASONES\turnos.json");
//listaTurnos = JsonSerializer.Deserialize<List<Turno>>(json);