namespace TPI_2024_Parte2
{
    partial class ClientesPorProfesional
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
            dataGridPorProfesional = new DataGridView();
            nombreCliente = new DataGridViewTextBoxColumn();
            hsTurno = new DataGridViewTextBoxColumn();
            Fecha = new DataGridViewTextBoxColumn();
            Profesional = new DataGridViewTextBoxColumn();
            panelClientesPorProfesional = new Panel();
            checkBoxCalendario = new CheckBox();
            monthCalendar1 = new MonthCalendar();
            cbPersonal = new ComboBox();
            rbClientesPorProfesional = new RadioButton();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridPorProfesional).BeginInit();
            panelClientesPorProfesional.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridPorProfesional
            // 
            dataGridPorProfesional.AllowUserToAddRows = false;
            dataGridPorProfesional.AllowUserToDeleteRows = false;
            dataGridPorProfesional.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridPorProfesional.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridPorProfesional.Columns.AddRange(new DataGridViewColumn[] { nombreCliente, hsTurno, Fecha, Profesional });
            dataGridPorProfesional.Location = new Point(12, 12);
            dataGridPorProfesional.Name = "dataGridPorProfesional";
            dataGridPorProfesional.ReadOnly = true;
            dataGridPorProfesional.RowHeadersVisible = false;
            dataGridPorProfesional.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridPorProfesional.Size = new Size(622, 429);
            dataGridPorProfesional.TabIndex = 4;
            // 
            // nombreCliente
            // 
            nombreCliente.HeaderText = "Cliente";
            nombreCliente.Name = "nombreCliente";
            nombreCliente.ReadOnly = true;
            // 
            // hsTurno
            // 
            hsTurno.HeaderText = "Horario del Turno";
            hsTurno.Name = "hsTurno";
            hsTurno.ReadOnly = true;
            // 
            // Fecha
            // 
            Fecha.HeaderText = "Fecha";
            Fecha.Name = "Fecha";
            Fecha.ReadOnly = true;
            // 
            // Profesional
            // 
            Profesional.HeaderText = "Profesional";
            Profesional.Name = "Profesional";
            Profesional.ReadOnly = true;
            // 
            // panelClientesPorProfesional
            // 
            panelClientesPorProfesional.Controls.Add(checkBoxCalendario);
            panelClientesPorProfesional.Controls.Add(monthCalendar1);
            panelClientesPorProfesional.Controls.Add(cbPersonal);
            panelClientesPorProfesional.Controls.Add(rbClientesPorProfesional);
            panelClientesPorProfesional.Controls.Add(label1);
            panelClientesPorProfesional.Location = new Point(640, 12);
            panelClientesPorProfesional.Name = "panelClientesPorProfesional";
            panelClientesPorProfesional.Size = new Size(272, 429);
            panelClientesPorProfesional.TabIndex = 6;
            // 
            // checkBoxCalendario
            // 
            checkBoxCalendario.AutoSize = true;
            checkBoxCalendario.Location = new Point(12, 227);
            checkBoxCalendario.Name = "checkBoxCalendario";
            checkBoxCalendario.Size = new Size(235, 19);
            checkBoxCalendario.TabIndex = 7;
            checkBoxCalendario.Text = "Quiero buscar en una fecha especifica...";
            checkBoxCalendario.UseVisualStyleBackColor = true;
            checkBoxCalendario.CheckedChanged += checkBoxCalendario_CheckedChanged;
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(12, 258);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 6;
            monthCalendar1.DateSelected += monthCalendar1_DateSelected;
            // 
            // cbPersonal
            // 
            cbPersonal.FormattingEnabled = true;
            cbPersonal.Location = new Point(3, 70);
            cbPersonal.Name = "cbPersonal";
            cbPersonal.Size = new Size(248, 23);
            cbPersonal.TabIndex = 3;
            cbPersonal.DropDown += cbPersonal_DropDown;
            cbPersonal.SelectedIndexChanged += cbPersonal_SelectedIndexChanged;
            // 
            // rbClientesPorProfesional
            // 
            rbClientesPorProfesional.AutoSize = true;
            rbClientesPorProfesional.Location = new Point(119, 3);
            rbClientesPorProfesional.Name = "rbClientesPorProfesional";
            rbClientesPorProfesional.Size = new Size(150, 19);
            rbClientesPorProfesional.TabIndex = 5;
            rbClientesPorProfesional.Text = "Clientes por Profesional";
            rbClientesPorProfesional.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 40);
            label1.Name = "label1";
            label1.Size = new Size(142, 15);
            label1.TabIndex = 2;
            label1.Text = "Seleccione un Profesional";
            // 
            // ClientesPorProfesional
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(924, 450);
            Controls.Add(panelClientesPorProfesional);
            Controls.Add(dataGridPorProfesional);
            Name = "ClientesPorProfesional";
            Text = "ClientesPorProfesional";
            ((System.ComponentModel.ISupportInitialize)dataGridPorProfesional).EndInit();
            panelClientesPorProfesional.ResumeLayout(false);
            panelClientesPorProfesional.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dataGridPorProfesional;
        private Panel panelClientesPorProfesional;
        private ComboBox cbPersonal;
        private Label label1;
        private RadioButton rbClientesPorProfesional;
        private DataGridViewTextBoxColumn nombreCliente;
        private DataGridViewTextBoxColumn hsTurno;
        private DataGridViewTextBoxColumn Fecha;
        private DataGridViewTextBoxColumn Profesional;
        private MonthCalendar monthCalendar1;
        private CheckBox checkBoxCalendario;
    }
}