namespace TPI_2024_Parte2
{
    partial class AdministrarServicios
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
            dataGridServicios = new DataGridView();
            Nombre = new DataGridViewTextBoxColumn();
            Categoria = new DataGridViewTextBoxColumn();
            Descripcion = new DataGridViewTextBoxColumn();
            Precio = new DataGridViewTextBoxColumn();
            Profesional = new DataGridViewTextBoxColumn();
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            checkBox1 = new CheckBox();
            textBox1 = new TextBox();
            panel3 = new Panel();
            label5 = new Label();
            comboBoxCategorias = new ComboBox();
            btCerrar = new Button();
            rbModificarServicio = new RadioButton();
            label8 = new Label();
            comboBox1 = new ComboBox();
            btGenerarModificar = new Button();
            label6 = new Label();
            tbPrecioServicio = new TextBox();
            tbDescripcionServicio = new TextBox();
            label4 = new Label();
            label3 = new Label();
            tbNombreServicio = new TextBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridServicios).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridServicios
            // 
            dataGridServicios.AllowUserToAddRows = false;
            dataGridServicios.AllowUserToDeleteRows = false;
            dataGridServicios.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            dataGridServicios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridServicios.Columns.AddRange(new DataGridViewColumn[] { Nombre, Categoria, Descripcion, Precio, Profesional });
            dataGridServicios.Location = new Point(3, 3);
            dataGridServicios.MultiSelect = false;
            dataGridServicios.Name = "dataGridServicios";
            dataGridServicios.ReadOnly = true;
            dataGridServicios.RowHeadersVisible = false;
            dataGridServicios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridServicios.ShowCellToolTips = false;
            dataGridServicios.ShowEditingIcon = false;
            dataGridServicios.Size = new Size(614, 542);
            dataGridServicios.TabIndex = 0;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            // 
            // Categoria
            // 
            Categoria.HeaderText = "Categoria";
            Categoria.Name = "Categoria";
            Categoria.ReadOnly = true;
            // 
            // Descripcion
            // 
            Descripcion.HeaderText = "Descripcion";
            Descripcion.Name = "Descripcion";
            Descripcion.ReadOnly = true;
            // 
            // Precio
            // 
            Precio.HeaderText = "Precio actual";
            Precio.Name = "Precio";
            Precio.ReadOnly = true;
            // 
            // Profesional
            // 
            Profesional.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            Profesional.HeaderText = "Profesional a Cargo";
            Profesional.Name = "Profesional";
            Profesional.ReadOnly = true;
            Profesional.Width = 135;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panel1.Controls.Add(dataGridServicios);
            panel1.Location = new Point(12, 107);
            panel1.Name = "panel1";
            panel1.Size = new Size(620, 548);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 11);
            label1.Name = "label1";
            label1.Size = new Size(152, 15);
            label1.TabIndex = 2;
            label1.Text = "Buscar Servicio por nombre";
            // 
            // panel2
            // 
            panel2.Controls.Add(checkBox1);
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(12, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(443, 89);
            panel2.TabIndex = 2;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(14, 63);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(100, 19);
            checkBox1.TabIndex = 4;
            checkBox1.Text = "Mostrar todos";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(14, 29);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(409, 23);
            textBox1.TabIndex = 3;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel3.Controls.Add(label5);
            panel3.Controls.Add(comboBoxCategorias);
            panel3.Controls.Add(btCerrar);
            panel3.Controls.Add(rbModificarServicio);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(comboBox1);
            panel3.Controls.Add(btGenerarModificar);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(tbPrecioServicio);
            panel3.Controls.Add(tbDescripcionServicio);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(tbNombreServicio);
            panel3.Controls.Add(label2);
            panel3.Location = new Point(635, 12);
            panel3.Name = "panel3";
            panel3.Size = new Size(337, 643);
            panel3.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(9, 341);
            label5.Name = "label5";
            label5.Size = new Size(121, 15);
            label5.TabIndex = 23;
            label5.Text = "Categoria del Servicio";
            // 
            // comboBoxCategorias
            // 
            comboBoxCategorias.FormattingEnabled = true;
            comboBoxCategorias.Location = new Point(9, 359);
            comboBoxCategorias.Name = "comboBoxCategorias";
            comboBoxCategorias.Size = new Size(317, 23);
            comboBoxCategorias.Sorted = true;
            comboBoxCategorias.TabIndex = 22;
            // 
            // btCerrar
            // 
            btCerrar.Location = new Point(3, 614);
            btCerrar.Name = "btCerrar";
            btCerrar.Size = new Size(331, 23);
            btCerrar.TabIndex = 21;
            btCerrar.Text = "CERRAR ESTA VENTANA";
            btCerrar.UseVisualStyleBackColor = true;
            btCerrar.Click += btCerrar_Click;
            // 
            // rbModificarServicio
            // 
            rbModificarServicio.AutoSize = true;
            rbModificarServicio.Location = new Point(205, 252);
            rbModificarServicio.Name = "rbModificarServicio";
            rbModificarServicio.Size = new Size(120, 19);
            rbModificarServicio.TabIndex = 20;
            rbModificarServicio.TabStop = true;
            rbModificarServicio.Text = "Modificar Servicio";
            rbModificarServicio.TextAlign = ContentAlignment.MiddleCenter;
            rbModificarServicio.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(9, 283);
            label8.Name = "label8";
            label8.Size = new Size(170, 15);
            label8.TabIndex = 19;
            label8.Text = "Profesional a cargo del servicio";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(9, 301);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(317, 23);
            comboBox1.Sorted = true;
            comboBox1.TabIndex = 18;
            // 
            // btGenerarModificar
            // 
            btGenerarModificar.Location = new Point(9, 458);
            btGenerarModificar.Name = "btGenerarModificar";
            btGenerarModificar.Size = new Size(316, 63);
            btGenerarModificar.TabIndex = 16;
            btGenerarModificar.Text = "Crear Nuevo Servicio";
            btGenerarModificar.UseVisualStyleBackColor = true;
            btGenerarModificar.Click += btGenerarModificar_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(127, 254);
            label6.Name = "label6";
            label6.Size = new Size(13, 15);
            label6.TabIndex = 13;
            label6.Text = "$";
            // 
            // tbPrecioServicio
            // 
            tbPrecioServicio.Location = new Point(7, 248);
            tbPrecioServicio.Name = "tbPrecioServicio";
            tbPrecioServicio.PlaceholderText = "US$ / EUR";
            tbPrecioServicio.Size = new Size(114, 23);
            tbPrecioServicio.TabIndex = 10;
            // 
            // tbDescripcionServicio
            // 
            tbDescripcionServicio.Location = new Point(5, 159);
            tbDescripcionServicio.Multiline = true;
            tbDescripcionServicio.Name = "tbDescripcionServicio";
            tbDescripcionServicio.PlaceholderText = "...descripcion que denote las virtudes del servicio";
            tbDescripcionServicio.Size = new Size(321, 68);
            tbDescripcionServicio.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(5, 230);
            label4.Name = "label4";
            label4.Size = new Size(84, 15);
            label4.TabIndex = 8;
            label4.Text = "Precio Servicio";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(5, 141);
            label3.Name = "label3";
            label3.Size = new Size(113, 15);
            label3.TabIndex = 6;
            label3.Text = "Descripcion Servicio";
            // 
            // tbNombreServicio
            // 
            tbNombreServicio.Location = new Point(3, 115);
            tbNombreServicio.Name = "tbNombreServicio";
            tbNombreServicio.PlaceholderText = "...nombre del servicio a crear";
            tbNombreServicio.Size = new Size(323, 23);
            tbNombreServicio.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(5, 97);
            label2.Name = "label2";
            label2.Size = new Size(95, 15);
            label2.TabIndex = 4;
            label2.Text = "Nombre Servicio";
            // 
            // AdministrarServicios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 661);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "AdministrarServicios";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdministrarServicios";
            FormClosing += AdministrarServicios_FormClosing;
            FormClosed += AdministrarServicios_FormClosed;
            ((System.ComponentModel.ISupportInitialize)dataGridServicios).EndInit();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridServicios;
        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private CheckBox checkBox1;
        private TextBox textBox1;
        private Panel panel3;
        private TextBox tbNombreServicio;
        private Label label2;
        private Label label3;
        private Label label6;
        private TextBox tbPrecioServicio;
        private TextBox tbDescripcionServicio;
        private Label label4;
        private Button btGenerarModificar;
        private ComboBox comboBox1;
        private RadioButton rbModificarServicio;
        private Label label8;
        private Button btCerrar;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Categoria;
        private DataGridViewTextBoxColumn Descripcion;
        private DataGridViewTextBoxColumn Precio;
        private DataGridViewTextBoxColumn Profesional;
        private Label label5;
        private ComboBox comboBoxCategorias;
    }
}