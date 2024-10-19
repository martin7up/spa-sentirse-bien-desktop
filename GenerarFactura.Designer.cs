namespace TPI_2024_Parte2
{
    partial class GenerarFactura
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridTurnosDelCliente = new DataGridView();
            Cliente = new DataGridViewTextBoxColumn();
            DireccionCliente = new DataGridViewTextBoxColumn();
            Fecha = new DataGridViewTextBoxColumn();
            Horario = new DataGridViewTextBoxColumn();
            isPagado = new DataGridViewTextBoxColumn();
            Precio = new DataGridViewTextBoxColumn();
            cbClientes = new ComboBox();
            btGenerarFactura = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridTurnosDelCliente).BeginInit();
            SuspendLayout();
            // 
            // dataGridTurnosDelCliente
            // 
            dataGridTurnosDelCliente.AllowUserToAddRows = false;
            dataGridTurnosDelCliente.AllowUserToDeleteRows = false;
            dataGridTurnosDelCliente.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridTurnosDelCliente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridTurnosDelCliente.Columns.AddRange(new DataGridViewColumn[] { Cliente, DireccionCliente, Fecha, Horario, isPagado, Precio });
            dataGridTurnosDelCliente.Location = new Point(12, 7);
            dataGridTurnosDelCliente.MultiSelect = false;
            dataGridTurnosDelCliente.Name = "dataGridTurnosDelCliente";
            dataGridTurnosDelCliente.ReadOnly = true;
            dataGridTurnosDelCliente.RowHeadersVisible = false;
            dataGridTurnosDelCliente.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridTurnosDelCliente.ShowCellErrors = false;
            dataGridTurnosDelCliente.ShowCellToolTips = false;
            dataGridTurnosDelCliente.ShowEditingIcon = false;
            dataGridTurnosDelCliente.ShowRowErrors = false;
            dataGridTurnosDelCliente.Size = new Size(743, 431);
            dataGridTurnosDelCliente.TabIndex = 2;
            // 
            // Cliente
            // 
            Cliente.HeaderText = "Nombre";
            Cliente.Name = "Cliente";
            Cliente.ReadOnly = true;
            // 
            // DireccionCliente
            // 
            DireccionCliente.HeaderText = "Direccion";
            DireccionCliente.Name = "DireccionCliente";
            DireccionCliente.ReadOnly = true;
            // 
            // Fecha
            // 
            Fecha.HeaderText = "Fecha";
            Fecha.Name = "Fecha";
            Fecha.ReadOnly = true;
            // 
            // Horario
            // 
            Horario.HeaderText = "Horario del Turno";
            Horario.Name = "Horario";
            Horario.ReadOnly = true;
            // 
            // isPagado
            // 
            isPagado.HeaderText = "Pago Efectuado";
            isPagado.Name = "isPagado";
            isPagado.ReadOnly = true;
            // 
            // Precio
            // 
            Precio.HeaderText = "Precio";
            Precio.Name = "Precio";
            Precio.ReadOnly = true;
            // 
            // cbClientes
            // 
            cbClientes.FormattingEnabled = true;
            cbClientes.Location = new Point(761, 7);
            cbClientes.Name = "cbClientes";
            cbClientes.Size = new Size(215, 23);
            cbClientes.TabIndex = 3;
            cbClientes.DropDown += comboBox1_DropDown;
            cbClientes.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // btGenerarFactura
            // 
            btGenerarFactura.Location = new Point(761, 398);
            btGenerarFactura.Name = "btGenerarFactura";
            btGenerarFactura.Size = new Size(205, 40);
            btGenerarFactura.TabIndex = 4;
            btGenerarFactura.Text = "Generar Factura";
            btGenerarFactura.UseVisualStyleBackColor = true;
            btGenerarFactura.Click += btGenerarFactura_Click;
            // 
            // GenerarFactura
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(978, 450);
            Controls.Add(btGenerarFactura);
            Controls.Add(cbClientes);
            Controls.Add(dataGridTurnosDelCliente);
            Name = "GenerarFactura";
            Text = "GenerarFactura";
            ((System.ComponentModel.ISupportInitialize)dataGridTurnosDelCliente).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridTurnosDelCliente;
        private DataGridViewTextBoxColumn Cliente;
        private DataGridViewTextBoxColumn DireccionCliente;
        private DataGridViewTextBoxColumn Fecha;
        private DataGridViewTextBoxColumn Horario;
        private DataGridViewTextBoxColumn isPagado;
        private DataGridViewTextBoxColumn Precio;
        private ComboBox cbClientes;
        private Button btGenerarFactura;
    }
}