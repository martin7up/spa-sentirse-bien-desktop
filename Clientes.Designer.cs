namespace TPI_2024_Parte2
{
    partial class Clientes
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
            panel1 = new Panel();
            panelMostrarPorFecha = new Panel();
            panelClientesPorProfesional = new Panel();
            rbMostrarPorFecha = new RadioButton();
            rbClientesPorProfesional = new RadioButton();
            monthCalendar1 = new MonthCalendar();
            label1 = new Label();
            comboBox1 = new ComboBox();
            dataGridView1 = new DataGridView();
            Nombre = new DataGridViewTextBoxColumn();
            FechaAtencion = new DataGridViewTextBoxColumn();
            Hora = new DataGridViewTextBoxColumn();
            Servicio = new DataGridViewTextBoxColumn();
            Profesional = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            panelMostrarPorFecha.SuspendLayout();
            panelClientesPorProfesional.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(dataGridView1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(682, 426);
            panel1.TabIndex = 0;
            // 
            // panelMostrarPorFecha
            // 
            panelMostrarPorFecha.Controls.Add(monthCalendar1);
            panelMostrarPorFecha.Controls.Add(rbMostrarPorFecha);
            panelMostrarPorFecha.Location = new Point(700, 12);
            panelMostrarPorFecha.Name = "panelMostrarPorFecha";
            panelMostrarPorFecha.Size = new Size(272, 203);
            panelMostrarPorFecha.TabIndex = 1;
            // 
            // panelClientesPorProfesional
            // 
            panelClientesPorProfesional.Controls.Add(comboBox1);
            panelClientesPorProfesional.Controls.Add(label1);
            panelClientesPorProfesional.Controls.Add(rbClientesPorProfesional);
            panelClientesPorProfesional.Location = new Point(700, 221);
            panelClientesPorProfesional.Name = "panelClientesPorProfesional";
            panelClientesPorProfesional.Size = new Size(272, 217);
            panelClientesPorProfesional.TabIndex = 2;
            // 
            // rbMostrarPorFecha
            // 
            rbMostrarPorFecha.AutoSize = true;
            rbMostrarPorFecha.Location = new Point(144, 3);
            rbMostrarPorFecha.Name = "rbMostrarPorFecha";
            rbMostrarPorFecha.Size = new Size(122, 19);
            rbMostrarPorFecha.TabIndex = 0;
            rbMostrarPorFecha.TabStop = true;
            rbMostrarPorFecha.Text = "Clientes por Fecha";
            rbMostrarPorFecha.UseVisualStyleBackColor = true;
            // 
            // rbClientesPorProfesional
            // 
            rbClientesPorProfesional.AutoSize = true;
            rbClientesPorProfesional.Location = new Point(119, 3);
            rbClientesPorProfesional.Name = "rbClientesPorProfesional";
            rbClientesPorProfesional.Size = new Size(150, 19);
            rbClientesPorProfesional.TabIndex = 1;
            rbClientesPorProfesional.TabStop = true;
            rbClientesPorProfesional.Text = "Clientes por Profesional";
            rbClientesPorProfesional.UseVisualStyleBackColor = true;
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(15, 32);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 25);
            label1.Name = "label1";
            label1.Size = new Size(142, 15);
            label1.TabIndex = 2;
            label1.Text = "Seleccione un Profesional";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(15, 43);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(248, 23);
            comboBox1.TabIndex = 3;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Nombre, FechaAtencion, Hora, Servicio, Profesional });
            dataGridView1.Location = new Point(3, 3);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.ShowCellErrors = false;
            dataGridView1.ShowCellToolTips = false;
            dataGridView1.ShowEditingIcon = false;
            dataGridView1.ShowRowErrors = false;
            dataGridView1.Size = new Size(676, 420);
            dataGridView1.TabIndex = 0;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre Cliente";
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            // 
            // FechaAtencion
            // 
            FechaAtencion.HeaderText = "Fecha de Turno";
            FechaAtencion.Name = "FechaAtencion";
            FechaAtencion.ReadOnly = true;
            // 
            // Hora
            // 
            Hora.HeaderText = "Horario de Atencion";
            Hora.Name = "Hora";
            Hora.ReadOnly = true;
            // 
            // Servicio
            // 
            Servicio.HeaderText = "Servicio";
            Servicio.Name = "Servicio";
            Servicio.ReadOnly = true;
            // 
            // Profesional
            // 
            Profesional.HeaderText = "Profesional a Cargo";
            Profesional.Name = "Profesional";
            Profesional.ReadOnly = true;
            // 
            // Clientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 450);
            Controls.Add(panelClientesPorProfesional);
            Controls.Add(panelMostrarPorFecha);
            Controls.Add(panel1);
            Name = "Clientes";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panelMostrarPorFecha.ResumeLayout(false);
            panelMostrarPorFecha.PerformLayout();
            panelClientesPorProfesional.ResumeLayout(false);
            panelClientesPorProfesional.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panelMostrarPorFecha;
        private RadioButton rbMostrarPorFecha;
        private Panel panelClientesPorProfesional;
        private RadioButton rbClientesPorProfesional;
        private MonthCalendar monthCalendar1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn FechaAtencion;
        private DataGridViewTextBoxColumn Hora;
        private DataGridViewTextBoxColumn Servicio;
        private DataGridViewTextBoxColumn Profesional;
        private ComboBox comboBox1;
        private Label label1;
    }
}