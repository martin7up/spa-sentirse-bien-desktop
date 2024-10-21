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
            button1 = new Button();
            btGenerarInforme = new Button();
            checkBoxGenerarInforme = new CheckBox();
            checkBoxCalendario = new CheckBox();
            monthCalendar1 = new MonthCalendar();
            cbPersonal = new ComboBox();
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
            panelClientesPorProfesional.Controls.Add(button1);
            panelClientesPorProfesional.Controls.Add(btGenerarInforme);
            panelClientesPorProfesional.Controls.Add(checkBoxGenerarInforme);
            panelClientesPorProfesional.Controls.Add(checkBoxCalendario);
            panelClientesPorProfesional.Controls.Add(monthCalendar1);
            panelClientesPorProfesional.Controls.Add(cbPersonal);
            panelClientesPorProfesional.Controls.Add(label1);
            panelClientesPorProfesional.Location = new Point(640, 12);
            panelClientesPorProfesional.Name = "panelClientesPorProfesional";
            panelClientesPorProfesional.Size = new Size(272, 429);
            panelClientesPorProfesional.TabIndex = 6;
            // 
            // button1
            // 
            button1.Location = new Point(194, 402);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 10;
            button1.Text = "CERRAR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btGenerarInforme
            // 
            btGenerarInforme.Location = new Point(6, 335);
            btGenerarInforme.Name = "btGenerarInforme";
            btGenerarInforme.Size = new Size(248, 23);
            btGenerarInforme.TabIndex = 9;
            btGenerarInforme.Text = "Generar Informe";
            btGenerarInforme.UseVisualStyleBackColor = true;
            btGenerarInforme.Click += btGenerarInforme_Click;
            // 
            // checkBoxGenerarInforme
            // 
            checkBoxGenerarInforme.AutoSize = true;
            checkBoxGenerarInforme.Location = new Point(6, 310);
            checkBoxGenerarInforme.Name = "checkBoxGenerarInforme";
            checkBoxGenerarInforme.Size = new Size(112, 19);
            checkBoxGenerarInforme.TabIndex = 8;
            checkBoxGenerarInforme.Text = "Generar informe";
            checkBoxGenerarInforme.UseVisualStyleBackColor = true;
            checkBoxGenerarInforme.CheckedChanged += checkBoxGenerarInforme_CheckedChanged;
            // 
            // checkBoxCalendario
            // 
            checkBoxCalendario.AutoSize = true;
            checkBoxCalendario.Location = new Point(6, 105);
            checkBoxCalendario.Name = "checkBoxCalendario";
            checkBoxCalendario.Size = new Size(235, 19);
            checkBoxCalendario.TabIndex = 7;
            checkBoxCalendario.Text = "Quiero buscar en una fecha especifica...";
            checkBoxCalendario.UseVisualStyleBackColor = true;
            checkBoxCalendario.CheckedChanged += checkBoxCalendario_CheckedChanged;
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(6, 136);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 6;
            monthCalendar1.DateSelected += monthCalendar1_DateSelected;
            // 
            // cbPersonal
            // 
            cbPersonal.FormattingEnabled = true;
            cbPersonal.Location = new Point(3, 30);
            cbPersonal.Name = "cbPersonal";
            cbPersonal.Size = new Size(248, 23);
            cbPersonal.TabIndex = 3;
            cbPersonal.DropDown += cbPersonal_DropDown;
            cbPersonal.SelectedIndexChanged += cbPersonal_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 6);
            label1.Name = "label1";
            label1.Size = new Size(142, 15);
            label1.TabIndex = 2;
            label1.Text = "Seleccione un Profesional";
            // 
            // ClientesPorProfesional
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(921, 449);
            Controls.Add(panelClientesPorProfesional);
            Controls.Add(dataGridPorProfesional);
            Name = "ClientesPorProfesional";
            Text = "ClientesPorProfesional";
            FormClosing += ClientesPorProfesional_FormClosing;
            FormClosed += ClientesPorProfesional_FormClosed;
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
        private DataGridViewTextBoxColumn nombreCliente;
        private DataGridViewTextBoxColumn hsTurno;
        private DataGridViewTextBoxColumn Fecha;
        private DataGridViewTextBoxColumn Profesional;
        private MonthCalendar monthCalendar1;
        private CheckBox checkBoxCalendario;
        private Button btGenerarInforme;
        private CheckBox checkBoxGenerarInforme;
        private Button button1;
    }
}