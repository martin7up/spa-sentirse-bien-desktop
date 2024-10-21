namespace TPI_2024_Parte2
{
    partial class ClientesTodos
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
            dataGridClientes = new DataGridView();
            Nombre = new DataGridViewTextBoxColumn();
            Direccion = new DataGridViewTextBoxColumn();
            Ciudad = new DataGridViewTextBoxColumn();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridClientes).BeginInit();
            SuspendLayout();
            // 
            // dataGridClientes
            // 
            dataGridClientes.AllowUserToAddRows = false;
            dataGridClientes.AllowUserToDeleteRows = false;
            dataGridClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridClientes.Columns.AddRange(new DataGridViewColumn[] { Nombre, Direccion, Ciudad });
            dataGridClientes.Location = new Point(12, 12);
            dataGridClientes.MultiSelect = false;
            dataGridClientes.Name = "dataGridClientes";
            dataGridClientes.ReadOnly = true;
            dataGridClientes.RowHeadersVisible = false;
            dataGridClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridClientes.ShowCellErrors = false;
            dataGridClientes.ShowCellToolTips = false;
            dataGridClientes.ShowEditingIcon = false;
            dataGridClientes.ShowRowErrors = false;
            dataGridClientes.Size = new Size(776, 423);
            dataGridClientes.TabIndex = 1;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre Cliente";
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            // 
            // Direccion
            // 
            Direccion.HeaderText = "Domicilio";
            Direccion.Name = "Direccion";
            Direccion.ReadOnly = true;
            // 
            // Ciudad
            // 
            Ciudad.HeaderText = "Ciudad";
            Ciudad.Name = "Ciudad";
            Ciudad.ReadOnly = true;
            // 
            // button1
            // 
            button1.Location = new Point(712, 452);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "CERRAR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // ClientesTodos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(799, 487);
            Controls.Add(button1);
            Controls.Add(dataGridClientes);
            Name = "ClientesTodos";
            Text = "Form1";
            FormClosed += ClientesTodos_FormClosed;
            ((System.ComponentModel.ISupportInitialize)dataGridClientes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridClientes;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Direccion;
        private DataGridViewTextBoxColumn Ciudad;
        private Button button1;
    }
}