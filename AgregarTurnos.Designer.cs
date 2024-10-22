namespace TPI_2024_Parte2
{
    partial class AgregarTurnos
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
            button2 = new Button();
            label3 = new Label();
            label2 = new Label();
            comboBox2 = new ComboBox();
            comboBoxClientes = new ComboBox();
            button1 = new Button();
            label1 = new Label();
            dateTimePicker2 = new DateTimePicker();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(button2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(comboBox2);
            panel1.Controls.Add(comboBoxClientes);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(dateTimePicker2);
            panel1.Location = new Point(12, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(890, 507);
            panel1.TabIndex = 0;
            // 
            // button2
            // 
            button2.Location = new Point(332, 370);
            button2.Name = "button2";
            button2.Size = new Size(257, 67);
            button2.TabIndex = 8;
            button2.Text = "ASENTAR TURNO";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(397, 240);
            label3.Name = "label3";
            label3.Size = new Size(123, 15);
            label3.TabIndex = 7;
            label3.Text = "Seleccione un servicio";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(400, 133);
            label2.Name = "label2";
            label2.Size = new Size(118, 15);
            label2.TabIndex = 6;
            label2.Text = "Seleccione un cliente";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(332, 258);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(257, 23);
            comboBox2.TabIndex = 5;
            // 
            // comboBoxClientes
            // 
            comboBoxClientes.FormattingEnabled = true;
            comboBoxClientes.Location = new Point(332, 151);
            comboBoxClientes.Name = "comboBoxClientes";
            comboBoxClientes.Size = new Size(257, 23);
            comboBoxClientes.TabIndex = 4;
            // 
            // button1
            // 
            button1.Location = new Point(805, 476);
            button1.Name = "button1";
            button1.Size = new Size(82, 23);
            button1.TabIndex = 3;
            button1.Text = "CERRAR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(332, 83);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 2;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(332, 57);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(257, 23);
            dateTimePicker2.TabIndex = 1;
            dateTimePicker2.ValueChanged += dateTimePicker2_ValueChanged;
            // 
            // AgregarTurnos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 516);
            Controls.Add(panel1);
            Name = "AgregarTurnos";
            Text = "AgregarTurnos";
            FormClosed += AgregarTurnos_FormClosed;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DateTimePicker dateTimePicker2;
        private Label label1;
        private Button button1;
        private ComboBox comboBox2;
        private ComboBox comboBoxClientes;
        private Button button2;
        private Label label3;
        private Label label2;
    }
}