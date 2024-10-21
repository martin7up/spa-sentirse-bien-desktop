using TPI_2024_Parte2.Clases;

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
            panelLogin = new Panel();
            btDeslogueo = new Button();
            btnIngReg = new Button();
            checkBoxSoyNuevo = new CheckBox();
            mtBoxUsuarioPass = new MaskedTextBox();
            lbUsuario = new Label();
            lbContrasenia = new Label();
            tBoxUsuario = new TextBox();
            panelIzquierdo = new Panel();
            btClientesPorProfesional = new Button();
            btClientesPorFecha = new Button();
            button7 = new Button();
            btClientesTodos = new Button();
            pagosPorCliente = new Button();
            pWelcome.SuspendLayout();
            panelLogin.SuspendLayout();
            panelIzquierdo.SuspendLayout();
            SuspendLayout();
            // 
            // pWelcome
            // 
            pWelcome.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pWelcome.BorderStyle = BorderStyle.FixedSingle;
            pWelcome.Controls.Add(panelLogin);
            pWelcome.Location = new Point(191, 0);
            pWelcome.Name = "pWelcome";
            pWelcome.Size = new Size(1014, 490);
            pWelcome.TabIndex = 0;
            // 
            // panelLogin
            // 
            panelLogin.Anchor = AnchorStyles.None;
            panelLogin.BorderStyle = BorderStyle.FixedSingle;
            panelLogin.Controls.Add(btDeslogueo);
            panelLogin.Controls.Add(btnIngReg);
            panelLogin.Controls.Add(checkBoxSoyNuevo);
            panelLogin.Controls.Add(mtBoxUsuarioPass);
            panelLogin.Controls.Add(lbUsuario);
            panelLogin.Controls.Add(lbContrasenia);
            panelLogin.Controls.Add(tBoxUsuario);
            panelLogin.Location = new Point(373, 82);
            panelLogin.Name = "panelLogin";
            panelLogin.Size = new Size(264, 324);
            panelLogin.TabIndex = 7;
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
            // panelIzquierdo
            // 
            panelIzquierdo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panelIzquierdo.BorderStyle = BorderStyle.FixedSingle;
            panelIzquierdo.Controls.Add(btClientesPorProfesional);
            panelIzquierdo.Controls.Add(btClientesPorFecha);
            panelIzquierdo.Controls.Add(button7);
            panelIzquierdo.Controls.Add(btClientesTodos);
            panelIzquierdo.Controls.Add(pagosPorCliente);
            panelIzquierdo.Location = new Point(0, 0);
            panelIzquierdo.Name = "panelIzquierdo";
            panelIzquierdo.Size = new Size(185, 490);
            panelIzquierdo.TabIndex = 1;
            // 
            // btClientesPorProfesional
            // 
            btClientesPorProfesional.Location = new Point(3, 144);
            btClientesPorProfesional.Name = "btClientesPorProfesional";
            btClientesPorProfesional.Size = new Size(177, 65);
            btClientesPorProfesional.TabIndex = 9;
            btClientesPorProfesional.Text = "Turnos por Profesional";
            btClientesPorProfesional.UseVisualStyleBackColor = true;
            btClientesPorProfesional.Click += btClientesPorProfesional_Click;
            // 
            // btClientesPorFecha
            // 
            btClientesPorFecha.Location = new Point(3, 3);
            btClientesPorFecha.Name = "btClientesPorFecha";
            btClientesPorFecha.Size = new Size(177, 65);
            btClientesPorFecha.TabIndex = 8;
            btClientesPorFecha.Text = "Calendario de Turnos";
            btClientesPorFecha.UseVisualStyleBackColor = true;
            btClientesPorFecha.Click += btClientesPorFecha_Click;
            // 
            // button7
            // 
            button7.Location = new Point(7, 287);
            button7.Name = "button7";
            button7.Size = new Size(177, 65);
            button7.TabIndex = 7;
            button7.Text = "Administrar Servicios";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // btClientesTodos
            // 
            btClientesTodos.Location = new Point(3, 73);
            btClientesTodos.Name = "btClientesTodos";
            btClientesTodos.Size = new Size(177, 65);
            btClientesTodos.TabIndex = 2;
            btClientesTodos.Text = "ClientesTodos";
            btClientesTodos.UseVisualStyleBackColor = true;
            btClientesTodos.Click += btClientesTodos_Click;
            // 
            // pagosPorCliente
            // 
            pagosPorCliente.Location = new Point(3, 216);
            pagosPorCliente.Name = "pagosPorCliente";
            pagosPorCliente.Size = new Size(177, 65);
            pagosPorCliente.TabIndex = 1;
            pagosPorCliente.Text = "Pagos";
            pagosPorCliente.UseVisualStyleBackColor = true;
            pagosPorCliente.Click += button1_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1205, 490);
            Controls.Add(panelIzquierdo);
            Controls.Add(pWelcome);
            Name = "Login";
            Text = "SPA-Sentirse Bien.";
            pWelcome.ResumeLayout(false);
            panelLogin.ResumeLayout(false);
            panelLogin.PerformLayout();
            panelIzquierdo.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pWelcome;
        private TextBox tBoxUsuario;
        private MaskedTextBox mtBoxUsuarioPass;
        private Label lbContrasenia;
        private Label lbUsuario;
        private CheckBox checkBoxSoyNuevo;
        private Button btnIngReg;

        private Panel panelIzquierdo;
        private Button btClientesTodos;
        public static Panel panelLogin;
        private Button button7;
        private Button btDeslogueo;

        //Vbles que no son de disenio o funcionalidad
        private AdministrarServicios FormServicios;
        private Usuario usuarioLogeado;
        //--------------------------------------------------------------------------------------

        //Formularios llamados desde Login------------------------------------------------------
        private ClientesPorFecha formuClientesPorFecha;
        private ClientesPorProfesional formuClientesPorProfesional;
        private ClientesTodos formuClientesTodos;
        private GenerarFactura formuFactura;

        private Button btClientesPorFecha;
        private Button btClientesPorProfesional;
        private Button pagosPorCliente;
        //--------------------------------------------------------------------------------------

        //Se recargan cada vez que se hago modificacion alguna en alguno de los elementos de cualquiera de las 4 listas--------------------------------------------
        public static List<Usuario> listaUsuarios;
        public static List<Servicio> listaServicios;
        public static List<Turno> listaTurnos;
        public static List<CategoriaServicio> listaCategorias;
        //---------------------------------------------------------------------------------------------------------------------------------------------------------

    }
}
