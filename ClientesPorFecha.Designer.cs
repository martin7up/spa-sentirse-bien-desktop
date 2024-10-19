using TPI_2024_Parte2.Clases;

namespace TPI_2024_Parte2
{
    partial class ClientesPorFecha
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
            panelGrid = new Panel();
            dataGridClientesPorFecha = new DataGridView();
            Cliente = new DataGridViewTextBoxColumn();
            DireccionCliente = new DataGridViewTextBoxColumn();
            Fecha = new DataGridViewTextBoxColumn();
            Horario = new DataGridViewTextBoxColumn();
            monthCalendar1 = new MonthCalendar();
            panelMostrarPorFecha = new Panel();
            rbMostrarPorFecha = new RadioButton();
            panelGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridClientesPorFecha).BeginInit();
            panelMostrarPorFecha.SuspendLayout();
            SuspendLayout();
            // 
            // panelGrid
            // 
            panelGrid.Controls.Add(dataGridClientesPorFecha);
            panelGrid.Location = new Point(12, 12);
            panelGrid.Name = "panelGrid";
            panelGrid.Size = new Size(572, 437);
            panelGrid.TabIndex = 0;
            // 
            // dataGridClientesPorFecha
            // 
            dataGridClientesPorFecha.AllowUserToAddRows = false;
            dataGridClientesPorFecha.AllowUserToDeleteRows = false;
            dataGridClientesPorFecha.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridClientesPorFecha.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridClientesPorFecha.Columns.AddRange(new DataGridViewColumn[] { Cliente, DireccionCliente, Fecha, Horario });
            dataGridClientesPorFecha.Location = new Point(3, 3);
            dataGridClientesPorFecha.MultiSelect = false;
            dataGridClientesPorFecha.Name = "dataGridClientesPorFecha";
            dataGridClientesPorFecha.ReadOnly = true;
            dataGridClientesPorFecha.RowHeadersVisible = false;
            dataGridClientesPorFecha.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridClientesPorFecha.ShowCellErrors = false;
            dataGridClientesPorFecha.ShowCellToolTips = false;
            dataGridClientesPorFecha.ShowEditingIcon = false;
            dataGridClientesPorFecha.ShowRowErrors = false;
            dataGridClientesPorFecha.Size = new Size(564, 431);
            dataGridClientesPorFecha.TabIndex = 1;
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
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(9, 48);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 1;
            monthCalendar1.DateSelected += monthCalendar1_DateSelected;
            // 
            // panelMostrarPorFecha
            // 
            panelMostrarPorFecha.Controls.Add(rbMostrarPorFecha);
            panelMostrarPorFecha.Controls.Add(monthCalendar1);
            panelMostrarPorFecha.Location = new Point(590, 12);
            panelMostrarPorFecha.Name = "panelMostrarPorFecha";
            panelMostrarPorFecha.Size = new Size(272, 219);
            panelMostrarPorFecha.TabIndex = 1;
            // 
            // rbMostrarPorFecha
            // 
            rbMostrarPorFecha.AutoSize = true;
            rbMostrarPorFecha.Location = new Point(9, 17);
            rbMostrarPorFecha.Name = "rbMostrarPorFecha";
            rbMostrarPorFecha.Size = new Size(122, 19);
            rbMostrarPorFecha.TabIndex = 0;
            rbMostrarPorFecha.Text = "Clientes por Fecha";
            rbMostrarPorFecha.UseVisualStyleBackColor = true;
            // 
            // ClientesPorFecha
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(865, 461);
            Controls.Add(panelMostrarPorFecha);
            Controls.Add(panelGrid);
            Name = "ClientesPorFecha";
            Text = "Form1";
            panelGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridClientesPorFecha).EndInit();
            panelMostrarPorFecha.ResumeLayout(false);
            panelMostrarPorFecha.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelGrid;
        private DataGridView dataGridClientesPorFecha;
        private DataGridViewTextBoxColumn Cliente;
        private DataGridViewTextBoxColumn DireccionCliente;
        private DataGridViewTextBoxColumn Fecha;
        private DataGridViewTextBoxColumn Horario;

        //Vbles de funcionalidad-------------------------------------------------------------------
        private DateTime fechaSeleccionada = new();
        private MonthCalendar monthCalendar1;
        private Panel panelMostrarPorFecha;
        private RadioButton rbMostrarPorFecha;
        //-----------------------------------------------------------------------------------------
    }
}