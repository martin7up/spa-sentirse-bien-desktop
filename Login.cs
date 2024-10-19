using Microsoft.VisualBasic.ApplicationServices;
using System.Runtime.CompilerServices;
using System.Text.Json;
using TPI_2024_Parte2.Clases;

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
        private string usuario;
        private string pass;
        public Login()
        {
            InitializeComponent();

            btDeslogueo.Visible = false;

            //Trabajar de momento sin conectar a BD-------------------------------------------------------------
            var json = File.ReadAllText(@"C:\Users\114R7IN\source\repos\pruebas-FireBase\JASONES\usuarios.json");
            listaUsuarios = JsonSerializer.Deserialize<List<Usuario>>(json);
            //--------------------------------------------------------------------------------------------------

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
                lbUsuario.Text = "Direccion Email";
                lbUsuario.TextAlign = ContentAlignment.MiddleCenter;
                lbContrasenia.Text = "Defina una contraseña";
                lbContrasenia.TextAlign = ContentAlignment.MiddleCenter;
            }
            else
            {
                btnIngReg.Text = "Ingresar";
                lbUsuario.Text = "Usuario";
                lbUsuario.TextAlign = ContentAlignment.MiddleCenter;
                lbContrasenia.Text = "Contraseña";
                lbContrasenia.TextAlign = ContentAlignment.MiddleCenter;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (FormServicios is null)
            {
                FormServicios = new();
                FormServicios.ShowDialog();
            }
            else
            {
                FormServicios.ShowDialog();
            }
        }

        private void btnIngReg_Click(object sender, EventArgs e)
        {
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

                //Trabajar de momento sin conectar a BD-------------------------------------------------------------
                var json = File.ReadAllText(@"C:\Users\114R7IN\source\repos\pruebas-FireBase\JASONES\turnos.json");
                listaTurnos = JsonSerializer.Deserialize<List<Turno>>(json);

                json = File.ReadAllText(@"C:\Users\114R7IN\source\repos\pruebas-FireBase\JASONES\servicios.json");
                listaServicios = JsonSerializer.Deserialize<List<Servicio>>(json);
                //--------------------------------------------------------------------------------------------------

                MessageBox.Show($"Usuario : {usuarioLogeado.username}; tu rol es : {usuarioLogeado.rol}");
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
            tBoxUsuario.Enabled = true;
            mtBoxUsuarioPass.Enabled = true;
            btDeslogueo.Visible = false;
            btnIngReg.Visible = true;

            limpiarCampos();

            checkBoxSoyNuevo.Enabled = true;
            usuarioLogeado = null;

            //Se pasan las listas a null
            listaTurnos = null;
            listaServicios = null;

            MessageBox.Show($"El usuario se ha deslogueado correctamente >>> {usuarioLogeado is null}");
        }

        private void limpiarCampos()
        {
            tBoxUsuario.ResetText();
            mtBoxUsuarioPass.ResetText();
        }

        private void btClientesPorFecha_Click(object sender, EventArgs e)
        {
            formuClientesPorFecha = new();
            formuClientesPorFecha.Show();
        }

        private void btClientesTodos_Click(object sender, EventArgs e)
        {
            formuClientesTodos = new();
            formuClientesTodos.Show();
        }

        private void btClientesPorProfesional_Click(object sender, EventArgs e)
        {
            formuClientesPorProfesional = new();
            formuClientesPorProfesional.Show();
        }
    }
}
