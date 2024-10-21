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
            NombreCli = new DataGridViewTextBoxColumn();
            DireccionCliente = new DataGridViewTextBoxColumn();
            Fecha = new DataGridViewTextBoxColumn();
            Horario = new DataGridViewTextBoxColumn();
            isPagado = new DataGridViewTextBoxColumn();
            Precio = new DataGridViewTextBoxColumn();
            MedioPago = new DataGridViewTextBoxColumn();
            Cancelado = new DataGridViewTextBoxColumn();
            Id = new DataGridViewTextBoxColumn();
            cbClientes = new ComboBox();
            btGenerarFactura = new Button();
            panelPago = new Panel();
            rbEfectivo = new RadioButton();
            rbDebito = new RadioButton();
            rbCredito = new RadioButton();
            rbTransferencia = new RadioButton();
            btAsentarPago = new Button();
            btHabDeshab = new Button();
            panelHabilitarDeshab = new Panel();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridTurnosDelCliente).BeginInit();
            panelPago.SuspendLayout();
            panelHabilitarDeshab.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridTurnosDelCliente
            // 
            dataGridTurnosDelCliente.AllowUserToAddRows = false;
            dataGridTurnosDelCliente.AllowUserToDeleteRows = false;
            dataGridTurnosDelCliente.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridTurnosDelCliente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridTurnosDelCliente.Columns.AddRange(new DataGridViewColumn[] { NombreCli, DireccionCliente, Fecha, Horario, isPagado, Precio, MedioPago, Cancelado, Id });
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
            dataGridTurnosDelCliente.CellClick += dataGridTurnosDelCliente_CellClick;
            // 
            // NombreCli
            // 
            NombreCli.HeaderText = "Cliente";
            NombreCli.Name = "NombreCli";
            NombreCli.ReadOnly = true;
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
            // MedioPago
            // 
            MedioPago.HeaderText = "Medio de Pago";
            MedioPago.Name = "MedioPago";
            MedioPago.ReadOnly = true;
            // 
            // Cancelado
            // 
            Cancelado.HeaderText = "Cancelado";
            Cancelado.Name = "Cancelado";
            Cancelado.ReadOnly = true;
            // 
            // Id
            // 
            Id.HeaderText = "IDTURNO";
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Visible = false;
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
            btGenerarFactura.Location = new Point(758, 75);
            btGenerarFactura.Name = "btGenerarFactura";
            btGenerarFactura.Size = new Size(215, 40);
            btGenerarFactura.TabIndex = 4;
            btGenerarFactura.Text = "Generar Factura";
            btGenerarFactura.UseVisualStyleBackColor = true;
            btGenerarFactura.Click += btGenerarFactura_Click;
            // 
            // panelPago
            // 
            panelPago.Controls.Add(rbEfectivo);
            panelPago.Controls.Add(rbDebito);
            panelPago.Controls.Add(rbCredito);
            panelPago.Controls.Add(rbTransferencia);
            panelPago.Controls.Add(btAsentarPago);
            panelPago.Location = new Point(761, 171);
            panelPago.Name = "panelPago";
            panelPago.Size = new Size(215, 185);
            panelPago.TabIndex = 5;
            // 
            // rbEfectivo
            // 
            rbEfectivo.AutoSize = true;
            rbEfectivo.Location = new Point(7, 84);
            rbEfectivo.Name = "rbEfectivo";
            rbEfectivo.Size = new Size(67, 19);
            rbEfectivo.TabIndex = 7;
            rbEfectivo.TabStop = true;
            rbEfectivo.Text = "Efectivo";
            rbEfectivo.UseVisualStyleBackColor = true;
            // 
            // rbDebito
            // 
            rbDebito.AutoSize = true;
            rbDebito.Location = new Point(7, 59);
            rbDebito.Name = "rbDebito";
            rbDebito.Size = new Size(60, 19);
            rbDebito.TabIndex = 6;
            rbDebito.TabStop = true;
            rbDebito.Text = "Debito";
            rbDebito.UseVisualStyleBackColor = true;
            // 
            // rbCredito
            // 
            rbCredito.AutoSize = true;
            rbCredito.Location = new Point(7, 34);
            rbCredito.Name = "rbCredito";
            rbCredito.Size = new Size(64, 19);
            rbCredito.TabIndex = 5;
            rbCredito.TabStop = true;
            rbCredito.Text = "Credito";
            rbCredito.UseVisualStyleBackColor = true;
            // 
            // rbTransferencia
            // 
            rbTransferencia.AutoSize = true;
            rbTransferencia.Location = new Point(7, 9);
            rbTransferencia.Name = "rbTransferencia";
            rbTransferencia.Size = new Size(94, 19);
            rbTransferencia.TabIndex = 4;
            rbTransferencia.TabStop = true;
            rbTransferencia.Text = "Transferencia";
            rbTransferencia.UseVisualStyleBackColor = true;
            // 
            // btAsentarPago
            // 
            btAsentarPago.Location = new Point(3, 114);
            btAsentarPago.Name = "btAsentarPago";
            btAsentarPago.Size = new Size(209, 65);
            btAsentarPago.TabIndex = 1;
            btAsentarPago.Text = "Asentar Pago";
            btAsentarPago.UseVisualStyleBackColor = true;
            btAsentarPago.Click += btAsentarPago_Click;
            // 
            // btHabDeshab
            // 
            btHabDeshab.Location = new Point(4, 12);
            btHabDeshab.Name = "btHabDeshab";
            btHabDeshab.Size = new Size(209, 23);
            btHabDeshab.TabIndex = 6;
            btHabDeshab.TabStop = false;
            btHabDeshab.Text = "Cancelar Turno";
            btHabDeshab.UseVisualStyleBackColor = true;
            btHabDeshab.Click += btHabDeshab_Click;
            // 
            // panelHabilitarDeshab
            // 
            panelHabilitarDeshab.Controls.Add(btHabDeshab);
            panelHabilitarDeshab.Location = new Point(761, 121);
            panelHabilitarDeshab.Name = "panelHabilitarDeshab";
            panelHabilitarDeshab.Size = new Size(215, 46);
            panelHabilitarDeshab.TabIndex = 7;
            // 
            // button1
            // 
            button1.Location = new Point(891, 415);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 8;
            button1.Text = "CERRAR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // GenerarFactura
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(978, 450);
            Controls.Add(button1);
            Controls.Add(panelHabilitarDeshab);
            Controls.Add(panelPago);
            Controls.Add(btGenerarFactura);
            Controls.Add(cbClientes);
            Controls.Add(dataGridTurnosDelCliente);
            Name = "GenerarFactura";
            Text = "GenerarFactura";
            FormClosed += GenerarFactura_FormClosed;
            ((System.ComponentModel.ISupportInitialize)dataGridTurnosDelCliente).EndInit();
            panelPago.ResumeLayout(false);
            panelPago.PerformLayout();
            panelHabilitarDeshab.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridTurnosDelCliente;
        private ComboBox cbClientes;
        private Button btGenerarFactura;
        private DataGridViewTextBoxColumn DireccionCliente;
        private DataGridViewTextBoxColumn Fecha;
        private DataGridViewTextBoxColumn Horario;
        private DataGridViewTextBoxColumn isPagado;
        private DataGridViewTextBoxColumn Precio;
        private DataGridViewTextBoxColumn MedioPago;
        private DataGridViewTextBoxColumn Cancelado;
        private DataGridViewTextBoxColumn NombreCli;
        private Panel panelPago;
        private Button btAsentarPago;
        private DataGridViewTextBoxColumn Id;
        private RadioButton rbEfectivo;
        private RadioButton rbDebito;
        private RadioButton rbCredito;
        private RadioButton rbTransferencia;
        private Button btHabDeshab;
        private Panel panelHabilitarDeshab;
        private Button button1;
    }
}