﻿using TPI_2024_Parte2.Clases;

namespace TPI_2024_Parte2
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pWelcome = new Panel();
            panel2 = new Panel();
            btDeslogueo = new Button();
            btnIngReg = new Button();
            checkBoxSoyNuevo = new CheckBox();
            mtBoxUsuarioPass = new MaskedTextBox();
            lbUsuario = new Label();
            checkBox1 = new CheckBox();
            lbContrasenia = new Label();
            tBoxUsuario = new TextBox();
            panel1 = new Panel();
            button7 = new Button();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            pWelcome.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pWelcome
            // 
            pWelcome.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pWelcome.BorderStyle = BorderStyle.FixedSingle;
            pWelcome.Controls.Add(panel2);
            pWelcome.Location = new Point(102, 0);
            pWelcome.Name = "pWelcome";
            pWelcome.Size = new Size(363, 413);
            pWelcome.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.None;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(btDeslogueo);
            panel2.Controls.Add(btnIngReg);
            panel2.Controls.Add(checkBoxSoyNuevo);
            panel2.Controls.Add(mtBoxUsuarioPass);
            panel2.Controls.Add(lbUsuario);
            panel2.Controls.Add(checkBox1);
            panel2.Controls.Add(lbContrasenia);
            panel2.Controls.Add(tBoxUsuario);
            panel2.Location = new Point(47, 43);
            panel2.Name = "panel2";
            panel2.Size = new Size(264, 324);
            panel2.TabIndex = 7;
            // 
            // btDeslogueo
            // 
            btDeslogueo.Location = new Point(30, 271);
            btDeslogueo.Name = "btDeslogueo";
            btDeslogueo.Size = new Size(202, 26);
            btDeslogueo.TabIndex = 7;
            btDeslogueo.Text = "Desloguearme";
            btDeslogueo.UseVisualStyleBackColor = true;
            btDeslogueo.Click += btDeslogueo_Click;
            // 
            // btnIngReg
            // 
            btnIngReg.Anchor = AnchorStyles.None;
            btnIngReg.Location = new Point(94, 144);
            btnIngReg.Name = "btnIngReg";
            btnIngReg.Size = new Size(75, 52);
            btnIngReg.TabIndex = 5;
            btnIngReg.Text = "Ingresar";
            btnIngReg.UseVisualStyleBackColor = true;
            btnIngReg.Click += btnIngReg_Click;
            // 
            // checkBoxSoyNuevo
            // 
            checkBoxSoyNuevo.Anchor = AnchorStyles.None;
            checkBoxSoyNuevo.AutoSize = true;
            checkBoxSoyNuevo.Location = new Point(88, 247);
            checkBoxSoyNuevo.Name = "checkBoxSoyNuevo";
            checkBoxSoyNuevo.Size = new Size(81, 19);
            checkBoxSoyNuevo.TabIndex = 6;
            checkBoxSoyNuevo.Text = "Soy nuevo";
            checkBoxSoyNuevo.UseVisualStyleBackColor = true;
            checkBoxSoyNuevo.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // mtBoxUsuarioPass
            // 
            mtBoxUsuarioPass.Anchor = AnchorStyles.None;
            mtBoxUsuarioPass.Location = new Point(30, 103);
            mtBoxUsuarioPass.Name = "mtBoxUsuarioPass";
            mtBoxUsuarioPass.PasswordChar = 'x';
            mtBoxUsuarioPass.Size = new Size(202, 23);
            mtBoxUsuarioPass.TabIndex = 0;
            mtBoxUsuarioPass.TextAlign = HorizontalAlignment.Center;
            // 
            // lbUsuario
            // 
            lbUsuario.Anchor = AnchorStyles.None;
            lbUsuario.AutoSize = true;
            lbUsuario.Location = new Point(30, 15);
            lbUsuario.Name = "lbUsuario";
            lbUsuario.Size = new Size(47, 15);
            lbUsuario.TabIndex = 1;
            lbUsuario.Text = "Usuario";
            lbUsuario.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // checkBox1
            // 
            checkBox1.Anchor = AnchorStyles.None;
            checkBox1.AutoSize = true;
            checkBox1.Checked = true;
            checkBox1.CheckState = CheckState.Checked;
            checkBox1.Location = new Point(88, 225);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(90, 19);
            checkBox1.TabIndex = 4;
            checkBox1.Text = "Recordarme";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // lbContrasenia
            // 
            lbContrasenia.Anchor = AnchorStyles.None;
            lbContrasenia.AutoSize = true;
            lbContrasenia.Location = new Point(30, 85);
            lbContrasenia.Name = "lbContrasenia";
            lbContrasenia.Size = new Size(67, 15);
            lbContrasenia.TabIndex = 2;
            lbContrasenia.Text = "Contraseña";
            lbContrasenia.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tBoxUsuario
            // 
            tBoxUsuario.Anchor = AnchorStyles.None;
            tBoxUsuario.Location = new Point(30, 33);
            tBoxUsuario.Name = "tBoxUsuario";
            tBoxUsuario.Size = new Size(202, 23);
            tBoxUsuario.TabIndex = 3;
            tBoxUsuario.TextAlign = HorizontalAlignment.Center;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(button7);
            panel1.Controls.Add(button6);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(93, 413);
            panel1.TabIndex = 1;
            // 
            // button7
            // 
            button7.Location = new Point(3, 291);
            button7.Name = "button7";
            button7.Size = new Size(85, 50);
            button7.TabIndex = 7;
            button7.Text = "Administrar Servicios";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button6
            // 
            button6.Location = new Point(3, 179);
            button6.Name = "button6";
            button6.Size = new Size(85, 50);
            button6.TabIndex = 6;
            button6.Text = "Habilitar Usuarios";
            button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(3, 124);
            button5.Name = "button5";
            button5.Size = new Size(85, 50);
            button5.TabIndex = 5;
            button5.Text = "Administrar Usuarios";
            button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(3, 235);
            button4.Name = "button4";
            button4.Size = new Size(85, 50);
            button4.TabIndex = 4;
            button4.Text = "Estadisticas laborales";
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(3, 69);
            button3.Name = "button3";
            button3.Size = new Size(85, 50);
            button3.TabIndex = 3;
            button3.Text = "Serv por fecha";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(3, 41);
            button2.Name = "button2";
            button2.Size = new Size(85, 23);
            button2.TabIndex = 2;
            button2.Text = "Clientes";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(3, 12);
            button1.Name = "button1";
            button1.Size = new Size(85, 23);
            button1.TabIndex = 1;
            button1.Text = "Pagos";
            button1.UseVisualStyleBackColor = true;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(465, 413);
            Controls.Add(panel1);
            Controls.Add(pWelcome);
            Name = "Login";
            Text = "SPA-Sentirse Bien.";
            pWelcome.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pWelcome;
        private TextBox tBoxUsuario;
        private MaskedTextBox mtBoxUsuarioPass;
        private Label lbContrasenia;
        private Label lbUsuario;

        private CheckBox checkBox1;
        private CheckBox checkBoxSoyNuevo;
        private Button btnIngReg;

        private Panel panel1;
        private Button button6;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private Panel panel2;
        private Button button7;

        //Vbles que no son de disenio o funcionalidad
        private AdministrarServicios FormServicios;
        private Usuario usuarioLogeado;
        //--------------------------------------------------------------------------------------

        //Para trabajar momentaneamente sin conexion--------------------------------------------
        public List<Usuario> listaUsuarios;
        private Button btDeslogueo;
        //--------------------------------------------------------------------------------------
    }
}