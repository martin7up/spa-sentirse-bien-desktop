using Microsoft.VisualBasic.ApplicationServices;
using System.Runtime.CompilerServices;
using System.Text.Json;
using TPI_2024_Parte2.Clases;
using TPI_2024_Parte2.ClasesUtilitarias;
using System.Threading.Tasks;
using System.Drawing;
using Google.Cloud.Firestore;

/*
 * La idea es que la app trabaje con 4 listas, todas populadas con la informacion correspondiente en la Base de Datos remota.
 * Para mostrar informacion es directo.
 * Cada vez que se haga modificacion o eliminacion sobre algun elemento de alguna lista, se debe actualizar la info en Base de Datos y volver
 *  a descargar y popular cada lista desde Base de Datos.
 */

namespace TPI_2024_Parte2
{
    public partial class Login : Form
    {

        public static BaseDeDatos bd = new(); //Conexion a BD        
        public static string usuario;
        private string pass;

        public Login()
        {
            InitializeComponent();

            refLogin = panelLogin;

            this.Text = "Ningun usuario logueado";

            foreach (Button btn in panelIzquierdo.Controls)
            {
                btn.Enabled = false;
            }

            btDeslogueo.Visible = false;
            tbCiudad.Visible = false;
            tbDireccion.Visible = false;
            comboBox1.Visible = false;


            //Recuperado, serializado, des-serializado y carga de colecciones
            cargaUsuarios();
            cargarServicios();
            cargarTurnos();
            cargarCategorias();

            //Esto es solo para pruebas y no agotar las consultas a BD, comentar al momento de entregar
            //var json = File.ReadAllText(@"C:\Users\114R7IN\Desktop\Cred\Jasones\Usuarios.json");
            //listaUsuarios = JsonSerializer.Deserialize<List<Usuario>>(json);

            //json = File.ReadAllText(@"C:\Users\114R7IN\Desktop\Cred\Jasones\Turnos.json");
            //listaTurnos = JsonSerializer.Deserialize<List<Turno>>(json);

            //json = File.ReadAllText(@"C:\Users\114R7IN\Desktop\Cred\Jasones\Servicios.json");
            //listaServicios = JsonSerializer.Deserialize<List<Servicio>>(json);

            //json = File.ReadAllText(@"C:\Users\114R7IN\Desktop\Cred\Jasones\Categorias.json");
            //listaCategorias = JsonSerializer.Deserialize<List<CategoriaServicio>>(json);


        }
        private bool ShowMainMenuStrip()
        {
            return true;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as CheckBox).Checked)
            {
                btnIngReg.Text = "Registrarse";
                tbCiudad.Visible = true;
                tbDireccion.Visible = true;
                comboBox1.Enabled = true;
                comboBox1.Visible = true;
                limpiarCampos();
            }
            else
            {
                btnIngReg.Text = "Ingresar";
                tbCiudad.Visible = false;
                tbDireccion.Visible = false;
                comboBox1.Enabled = false;
                comboBox1.Visible = false;
                limpiarCampos();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            FormServicios = new();
            mostrarForm(FormServicios);
        }

        private void btnIngReg_Click(object sender, EventArgs e)
        {
            if (checkBoxSoyNuevo.Checked)
            {
                registrarUnUsuario();

                limpiarCampos();

                return;
            }

            //Comprobacion campos vacios
            if (string.IsNullOrEmpty(tBoxUsuario.Text.Trim()) || string.IsNullOrEmpty(mtBoxUsuarioPass.Text.Trim()))
            {
                MessageBox.Show("Uno o mas campos se encuentran vacios.");
                limpiarCampos();
                return;
            }

            //Busqueda usuario en lista
            usuario = tBoxUsuario.Text.Trim();
            pass = mtBoxUsuarioPass.Text.Trim();

            if (listaUsuarios.Where(u => u.username == usuario).Any(u => u.password == pass))
            {
                //Usuario encontrado
                usuarioLogeado = (listaUsuarios.Where(u => u.username == usuario).First()) as Usuario;

                btnIngReg.Visible = false;
                tBoxUsuario.Enabled = false;
                mtBoxUsuarioPass.Enabled = false;
                btDeslogueo.Visible = true;
                checkBoxSoyNuevo.Enabled = false;
                checkBoxSoyNuevo.Visible = false;
                comboBox1.Enabled = false;
                comboBox1.Visible = false;

                accesosFuncionalidades(usuarioLogeado.rol);

                MessageBox.Show($"Bienvenido/a {usuarioLogeado.username}");
            }
            else
            {
                //Usuario no encontrado o no corresponde contrasenia
                MessageBox.Show($"Usuario o contrasenia, o ambos son incorrectos");
                limpiarCampos();
                return;
            }
        }

        private void btDeslogueo_Click(object sender, EventArgs e)
        {
            foreach (Button btn in panelIzquierdo.Controls)
            {
                btn.Enabled = false;
            }

            tBoxUsuario.Enabled = true;
            mtBoxUsuarioPass.Enabled = true;
            btDeslogueo.Visible = false;
            btnIngReg.Visible = true;
            checkBoxSoyNuevo.Visible = false;
            comboBox1.Enabled = true;
            comboBox1.Visible = true;

            limpiarCampos();

            checkBoxSoyNuevo.Enabled = true;
            MessageBox.Show($"Hasta la proxima {usuarioLogeado.username}");
            usuarioLogeado = null;

            //Se pasan las listas a null
            listaTurnos = null;
            listaServicios = null;
            listaCategorias = null;

            this.Text = "Ningun usuario logueado";
        }

        private void limpiarCampos()
        {
            tBoxUsuario.ResetText();
            mtBoxUsuarioPass.ResetText();
            tbCiudad.ResetText();
            tbDireccion.ResetText();
            comboBox1.SelectedIndex = -1;
        }

        public static async Task cargaUsuarios()
        {

            await bd.obtenerUsuariosYSerializar();//Ademas de recuperar la coleccion completa, genera un .json con la coleccion que recupero.
            var json = File.ReadAllText(@"C:\Users\114R7IN\Desktop\Cred\Jasones\Usuarios.json");
            listaUsuarios = JsonSerializer.Deserialize<List<Usuario>>(json);
        }

        public static async Task cargarTurnos()
        {
            await bd.obtenerTurnosYSerializar();//Ademas de recuperar la coleccion completa, genera un .json con la coleccion que recupero.
            var json = File.ReadAllText(@"C:\Users\114R7IN\Desktop\Cred\Jasones\Turnos.json");
            listaTurnos = JsonSerializer.Deserialize<List<Turno>>(json);
        }

        public static async Task cargarServicios()
        {
            await bd.obtenerServiciosYSerializar();//Ademas de recuperar la coleccion completa, genera un .json con la coleccion que recupero.
            var json = File.ReadAllText(@"C:\Users\114R7IN\Desktop\Cred\Jasones\Servicios.json");
            listaServicios = JsonSerializer.Deserialize<List<Servicio>>(json);//Se des-serializa para dejar disponible la coleccion
        }

        public static async Task cargarCategorias()
        {
            await bd.obtenerCategoriaServiciosYSerializar();//Ademas de recuperar la coleccion completa, genera un .json con la coleccion que recupero.
            var json = File.ReadAllText(@"C:\Users\114R7IN\Desktop\Cred\Jasones\Categorias.json");
            listaCategorias = JsonSerializer.Deserialize<List<CategoriaServicio>>(json);
        }

        private void btClientesPorFecha_Click(object sender, EventArgs e)
        {
            formuClientesPorFecha = new();
            mostrarForm(formuClientesPorFecha);
        }

        private void btClientesTodos_Click(object sender, EventArgs e)
        {
            formuClientesTodos = new();
            mostrarForm(formuClientesTodos);
        }

        private void btClientesPorProfesional_Click(object sender, EventArgs e)
        {
            formuClientesPorProfesional = new();
            mostrarForm(formuClientesPorProfesional);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            formuFactura = new();
            mostrarForm(formuFactura);
        }

        private void accesosFuncionalidades(string rol)
        {
            foreach (Button btn in panelIzquierdo.Controls)
            {
                btn.Enabled = false;
            }

            if (rol == "admin")
            {
                foreach (Button btn in panelIzquierdo.Controls)
                {
                    btn.Enabled = true;
                }
                this.Text = "Logueado como Administrador";
                return;
            }

            if (rol == "personal")//AGREGAR NUEVO BOTONES
            {
                this.Text = "Logueado como Personal";
                btClientesPorProfesional.Enabled = true;
                return;
            }

            if (rol == "administrativo")//AGREGAR NUEVO BOTONES
            {
                btClientesPorFecha.Enabled = true;
                btClientesTodos.Enabled = true;
                pagosPorCliente.Enabled = true;
                this.Text = "Logueado como Administrativo";
                return;
            }
            MessageBox.Show("Que raro... no eres un tipo de usuario valido... comunicate con el administrado lo antes posible.");
        }

        private void mostrarForm(Form form)
        {

            foreach (Control control in pWelcome.Controls)
            {
                if (control is Form)
                {

                    control.Dispose();

                }
            }

            panelLogin.Visible = false;

            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;

            pWelcome.Controls.Add(form);
            form.Show();
        }

        private void registrarUnUsuario()
        {
            string ciudad = tbCiudad.Text.Trim();
            string direccion = tbDireccion.Text.Trim();
            string correo = tBoxUsuario.Text.Trim();
            string pass = mtBoxUsuarioPass.Text.Trim();

            if (string.IsNullOrEmpty(ciudad) || string.IsNullOrEmpty(direccion) || string.IsNullOrEmpty(correo) || string.IsNullOrEmpty(pass) || comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Parece que dejado uno o mas campos vacios o mal editados; intente nuevamente.");

                limpiarCampos();

                return;
            }

            var confirmacion = MessageBox.Show($"Usuario : {correo}\nCiudad : {ciudad}\nDireccion : {direccion}\nRol : {comboBox1.SelectedItem.ToString()}",
                                   "Son estos datos correctos ¿?",
                                   MessageBoxButtons.YesNo,
                                   MessageBoxIcon.Question);

            if (confirmacion == DialogResult.Yes)
            {
                //bd.crearUnNuevoUusario(correo, ciudad, direccion, pass, "", "usuario");//Ver de dar opcion del tipo de usuario a crear
                MessageBox.Show("Se ha enviado la peticion de registro.");
            }




        }

        private void btTurnos_Click(object sender, EventArgs e)
        {
            agregarTurno = new();
            mostrarForm(agregarTurno);
        }
    }
}

/*
    var json = File.ReadAllText(@"C:\Users\114R7IN\Desktop\Cred\Jasones\Usuarios.json");
    listaUsuarios = JsonSerializer.Deserialize<List<Usuario>>(json);

    json = File.ReadAllText(@"C:\Users\114R7IN\Desktop\Cred\Jasones\Turnos.json");
    listaTurnos = JsonSerializer.Deserialize<List<Turno>>(json);

    json = File.ReadAllText(@"C:\Users\114R7IN\Desktop\Cred\Jasones\Servicios.json");
    listaServicios = JsonSerializer.Deserialize<List<Servicio>>(json);

    json = File.ReadAllText(@"C:\Users\114R7IN\Desktop\Cred\Jasones\Categorias.json");
    listaCategorias = JsonSerializer.Deserialize<List<CategoriaServicio>>(json);
  */