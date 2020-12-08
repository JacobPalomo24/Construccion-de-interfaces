using System;
using System.Drawing;
using System.Windows.Forms;

namespace contruccion_de_interfaces
{
    public partial class Settings : Form
    {
        private Dropshadow shadow;

        // Función que inicializa el formulario por defecto
        public Settings(Point FormLocation)
        {
            // Centra el formulario
            this.Location = PointToScreen(FormLocation);
            InitializeComponent();
        }

        // Cuando carga por completo el formulario
        private void Settings_Load(object sender, EventArgs e)
        {
            // Configuración del tamoaño y de la sombra del formulario
            Width = 400;
            Height = 225;
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

        // Se ejecuta al presionar el boton de cerrar
        private void btn_close_Click(object sender, EventArgs e)
        {
            // Cierra el formulario actual
            this.Close();
        }

        /* ---------------------- Efectos hover de los botones ---------------------- */
        private void btn_credits_MouseEnter(object sender, EventArgs e)
        {
            btn_credits.ForeColor = Color.FromArgb(17, 17, 17);
        }

        private void btn_credits_MouseLeave(object sender, EventArgs e)
        {
            btn_credits.ForeColor = Color.FromArgb(255, 193, 7);
        }

        private void btn_logout_MouseEnter(object sender, EventArgs e)
        {
            btn_logout.ForeColor = Color.FromArgb(17, 17, 17);
        }

        private void btn_logout_MouseLeave(object sender, EventArgs e)
        {
            btn_logout.ForeColor = Color.FromArgb(255, 193, 7);
        }
        /* ---------------------- Fin de los efectos hover de los botones ---------------------- */

        // Se ejecuta al presionar el boton de créditos
        private void btn_credits_Click(object sender, EventArgs e)
        {
            // Muestra los creditos de la aplicación
            Credits credits_form = new Credits();
            credits_form.Location = PointToScreen(this.Location);
            credits_form.ShowDialog();
        }

        // Se ejecuta al presionar el boton cerrar cerrar sesión
        private void btn_logout_Click(object sender, EventArgs e)
        {
            // Cierra el formulario actual
            this.Close();
            Home.ActiveForm.Dispose();
        }
    }
}
