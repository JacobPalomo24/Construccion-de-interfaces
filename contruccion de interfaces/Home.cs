using System;
using System.Drawing;
using System.Windows.Forms;

namespace contruccion_de_interfaces
{
    public partial class Home : Form
    {
        private Dropshadow shadow;

        public Home(string user)
        {
            InitializeComponent();

            // Muestra un saludo personalizado con el nombre de usuario
            lbl_greeting.Text = "¡Bienvenido, " + user + "!";
            // Obtiene la poscion en x que tendrá el saludo para que se vea centrado
            int x = (800 - lbl_greeting.Width) / 2;
            // Centra verticalmente el label saludo
            lbl_greeting.Location = new Point(x, 191);
        }

        // Cuando carga por completo el formulario
        private void Home_Load(object sender, EventArgs e)
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
        }


        /* --------------------- Configuración del arrastre del formulario ---------------- */
        /*
         * Nota: Todo este código ya fué exlicado en el código de los formularios EditDelete y SignUp
         */
        int ex, ey;

        bool arrastre;

        private void Home_MouseDown(MouseEventArgs e)
        {
            ex = e.X;
            ey = e.Y;
            arrastre = true;
        }

        private void Home_MouseUp()
        {
            arrastre = false;
        }

        private void Home_MouseMove()
        {
            if (arrastre)
            {
                Point p = new Point(MousePosition.X - this.Location.X - ex, MousePosition.Y - this.Location.Y - ey);
                this.Location = this.PointToScreen(p);
            }
        }

        private void menuBar_MouseDown(object sender, MouseEventArgs e)
        {
            Home_MouseDown(e);
        }

        private void menuBar_MouseMove(object sender, MouseEventArgs e)
        {
            Home_MouseMove();
        }

        private void menuBar_MouseUp(object sender, MouseEventArgs e)
        {
            Home_MouseUp();
        }

        private void lbl_window_title_MouseDown(object sender, MouseEventArgs e)
        {
            Home_MouseDown(e);
        }

        private void lbl_window_title_MouseMove(object sender, MouseEventArgs e)
        {
            Home_MouseMove();
        }

        private void lbl_window_title_MouseUp(object sender, MouseEventArgs e)
        {
            Home_MouseUp();
        }
        /* --------------------- Fin de la configuración del arrastre del formulario ---------------- */

        // Al precionar el boton cerrar
        private void btn_close_Click(object sender, EventArgs e)
        {
            // Termina la aplicación
            Environment.Exit(0);
        }

        // Al presionar el boton minizar
        private void btn_minimize_Click(object sender, EventArgs e)
        {
            // Minimiza el formulario actual
            this.WindowState = FormWindowState.Minimized;
        }

        /* ---------------------- Efectos hover de los botones ---------------------- */
        private void btn_settings_MouseEnter(object sender, EventArgs e)
        {
            btn_settings.Image = Properties.Resources.settings_hover;
        }

        private void btn_settings_MouseLeave(object sender, EventArgs e)
        {
            btn_settings.Image = Properties.Resources.settings;
        }

        private void btn_alta_datos_MouseEnter(object sender, EventArgs e)
        {
            btn_alta_datos.ForeColor = Color.FromArgb(17, 17, 17);
        }

        private void btn_alta_datos_MouseLeave(object sender, EventArgs e)
        {
            btn_alta_datos.ForeColor = Color.FromArgb(255, 193, 7);
        }

        private void btn_cambios_bajas_MouseEnter(object sender, EventArgs e)
        {
            btn_cambios_bajas.ForeColor = Color.FromArgb(17, 17, 17);
        }

        private void btn_cambios_bajas_MouseLeave(object sender, EventArgs e)
        {
            btn_cambios_bajas.ForeColor = Color.FromArgb(255, 193, 7);
        }
        /* ---------------------- Fin de los efectos hover de los botones ---------------------- */

        // Se ejecuta al presionar el botón de configuraciones
        private void btn_settings_Click(object sender, EventArgs e)
        {
            // Si no está abierto ya un formulario de configuraciones
            if (!FormUtils.findOpenForm("Settings"))
            {
                // Centra el formulario de configuraciones y lo muestra
                Point HomeLocation = this.Location;
                Settings settings_form = new Settings(HomeLocation);
                settings_form.Show();
            }
        }

        // Se ejecuta al presionar el botón de alta de datos
        private void btn_alta_datos_Click(object sender, EventArgs e)
        {
            // Oculta el formulario actual
            this.Hide();
            // Muestra y centra el formulario de alta de datos
            DataRegister data_register_form = new DataRegister();
            data_register_form.Location = PointToScreen(this.Location);
            data_register_form.ShowDialog();
            // Al cerrar el formulario de alta de datos, se muestra nuevamente este formulario
            this.Show();
        }

        // Se ejecuta al presionar el botón de cambios y bajas
        private void btn_cambios_bajas_Click(object sender, EventArgs e)
        {
            // Oculta el formulario actual
            this.Hide();
            // Muestra y centra el formulario de cambios y bajas
            EditDelete edit_delete_form = new EditDelete();
            edit_delete_form.Location = PointToScreen(this.Location);
            edit_delete_form.ShowDialog();
            // Al cerrar el formulario de cambios y bajas, se muestra nuevamente este formulario
            this.Show();
        }
    }
}
