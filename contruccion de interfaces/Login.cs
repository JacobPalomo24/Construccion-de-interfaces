using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace contruccion_de_interfaces
{
    public partial class Login : Form
    {

        private Dropshadow shadow;
        // Ruta donde se encuentra o donde se encontrará el archivo de la base de datos
        private string path = @"C:\Users\jocel\source\repos\Construccion-de-interfaces\contruccion de interfaces\Data\users.txt";

        // Función que inicializa el formulario por defecto
        public Login()
        {
            InitializeComponent();

            // Sí el botón login está desactivado
            if (!btn_login.Enabled)
            {
                // Color del borde del botón a un gris más claro que el del fondo para parcer deshabilitado
                btn_login.FlatAppearance.BorderColor = Color.FromArgb(66, 66, 66);
                // Color del texto del botón a un gris más claro que el del fondo para parcer deshabilitado
                btn_login.ForeColor = Color.FromArgb(66, 66, 66);
            }
        }

        // Cuando carga por completo el formulario
        private void Login_Load(object sender, System.EventArgs e)
        {
            // Configuración del tamoaño y de la sombra del formulario
            Width = 800;
            Height = 450;
            if (!DesignMode)
            {
                shadow = new Dropshadow(this)
                {
                    ShadowV = 5,
                    ShadowH = 5,
                    ShadowBlur = 10,
                    ShadowSpread = -5,
                    ShadowColor = Color.FromArgb(150, 0, 0, 0)
                };
                shadow.RefreshShadow();
            }

            this.ActiveControl = btn_login;
        }

        /* --------------------- Configuración del arrastre del formulario ---------------- */
        /*
         * Nota: Todo este código ya fué exlicado en el código de los formularios EditDelete y SignUp
         */
        int ex, ey;

        bool arrastre;

        private void Login_MouseDown(System.Windows.Forms.MouseEventArgs e)
        {
            ex = e.X;
            ey = e.Y;
            arrastre = true;
        }

        private void Login_MouseUp()
        {
            arrastre = false;
        }

        private void Login_MouseMove()
        {
            if (arrastre)
            {
                Point p = new Point(MousePosition.X - this.Location.X - ex, MousePosition.Y - this.Location.Y - ey);
                this.Location = this.PointToScreen(p);
            }
        }

        private void menuBar_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            Login_MouseDown(e);
        }

        private void menuBar_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            Login_MouseMove();
        }

        private void menuBar_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            Login_MouseUp();
        }

        private void lbl_window_title_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            Login_MouseDown(e);
        }

        private void lbl_window_title_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            Login_MouseMove();
        }

        private void lbl_window_title_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            Login_MouseUp();
        }
        /* --------------------- Fin de la configuración del arrastre del formulario ---------------- */

        // Se ejecuta al presionar el botón cerrar
        private void btn_close_Click(object sender, System.EventArgs e)
        {
            // Cierra el formulario actual
            this.Close();
        }

        // Se ejecuta al presionar el botón minizar
        private void btn_minimize_Click(object sender, System.EventArgs e)
        {
            // Minimiza el formulario actual
            this.WindowState = FormWindowState.Minimized;
        }

        /* ---------------------- Efectos hover de los botones ---------------------- */
        private void btn_login_MouseEnter(object sender, System.EventArgs e)
        {
            btn_login.ForeColor = Color.FromArgb(17, 17, 17);
        }

        private void btn_login_MouseLeave(object sender, System.EventArgs e)
        {
            btn_login.ForeColor = Color.FromArgb(255, 193, 7);
        }
        /* ---------------------- Fin de los efectos hover de los botones ---------------------- */

        // Se ejecuta cuando presionas el link de registrarse
        private void link_sign_up_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Oculta el formulario actual
            this.Hide();

            // Muestra el formulario de registrarse
            SignUp signup_form = new SignUp();
            signup_form.Location = signup_form.PointToScreen(this.Location);
            signup_form.ShowDialog();

            // Al cerrar el form de regitrarse muestra nuevamente el formulario actual
            this.Show();
        }

        /* ------------------------ Validación del formulario --------------------------- */
        // Nota: este fragmento de código también ya fué explicado en los dos forms mencionados anteriormente
        private void input_username_TextChange(object sender, System.EventArgs e)
        {
            if (input_username.Text != "" && input_password.Text != "")
            {
                btn_login.Enabled = true;
            }
            else
            {
                btn_login.Enabled = false;
            }
        }

        private void input_password_TextChange(object sender, System.EventArgs e)
        {
            if (input_username.Text != "" && input_password.Text != "")
            {
                btn_login.Enabled = true;
            }
            else
            {
                btn_login.Enabled = false;
            }
        }

        private void btn_login_EnabledChange(object sender, System.EventArgs e)
        {
            if (!btn_login.Enabled)
            {
                btn_login.FlatAppearance.BorderColor = Color.FromArgb(66, 66, 66);
                btn_login.ForeColor = Color.FromArgb(66, 66, 66);
            }
            else
            {
                btn_login.FlatAppearance.BorderColor = Color.FromArgb(255, 193, 7);
                btn_login.ForeColor = Color.FromArgb(255, 193, 7);
            }
        }
        /* ------------------------ Fin de la validación del formulario --------------------------- */

        // Se ejecuta al hacer clic en el botón iniciar sesión
        private void btn_login_Click(object sender, EventArgs e)
        {
            // Guardo los datos ingresados en cada uno de los campos en las siguientes varibales
            string username = input_username.Text.Trim(), pass = input_password.Text.Trim();

            // Sí los todos los campos están llenos
            if (username != "" && pass != "")
            {
                // Sí el usuario exitse y son correctas sus credenciales
                if (userExist(username, pass))
                {
                    // Oculta el formulario actual
                    this.Hide();

                    // Muestra el formulario home
                    Home home_form = new Home(username);
                    home_form.Location = PointToScreen(this.Location);
                    home_form.ShowDialog();

                    // Al cerrar el formulario home o cerrar sesión muestra nuevamente el fomrulario actual
                    this.Show();
                }
                // Sí no existe el usuario o sus credenciales son incorrectas
                else
                {
                    // Muestra el siguiente mensaje
                    Alert alert = new Alert("Usuario o contraseña incorrectos.", "Credenciales incorrectas");
                    alert.ShowDialog();
                }
            }
        }

        // Función que compruba la existencia y validación de los usuarios
        private bool userExist(string username, string pass)
        {
            // Si el archivo en la ruta 'path' existe
            if (File.Exists(path))
            {
                // Creo una variable de existeUsuario de tipo bool
                bool eUser = false;

                // Leo el archivo y guardo sus datos
                StreamReader reader = File.OpenText(path);
                string contenido = reader.ReadToEnd();
                reader.Close();

                // Separo el contenido del archivo por saltos de linea en el siguiente arreglo
                string[] users = contenido.Split('\n');

                // Ciclo para buscar en todos los usernames de la base de datos
                for (int i = 1; i < users.Length; i += 5)
                {
                    // Sí el usuario que se ingresó está en la base de datos
                    if (users[i].Trim().Substring(10).Equals(username))
                    {
                        // Comprueba que la contraseña ingresada sea la correcta
                        if (users[i + 1].Trim().Substring(10).Equals(pass))
                        {
                            // De ser así, devuelve true
                            eUser = true;
                            // Termina el ciclo
                            break;
                        }
                        // Sí la contraseña es incorrecta
                        else
                        {
                            // Devuelve false
                            eUser = false;
                            // Termina el ciclo
                            break;
                        }
                    }
                    // Si el usuario no existe
                    else
                    {
                        // Devuelve false
                        eUser = false;
                    }
                }

                // Devuelve la variable eUser
                return eUser;
            }
            // Si no existe ningun archivo
            else
            {
                // Devuelve false
                return false;
            }
        }
    }
}
