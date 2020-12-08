using System;
using System.Drawing;
using System.Windows.Forms;

namespace contruccion_de_interfaces
{
    public partial class Alert : Form
    {
        Dropshadow shadow;

        // Función que inicializa el formulario por defecto
        public Alert(string message, string window_title)
        {
            InitializeComponent();

            // Establece el texto del lbl_mensaje por el mensaje especificado
            lbl_message.Text = message;

            // Obtene la posicion en x del mensaje para que se vea centrado
            int x = (500 - lbl_message.Width) / 2;
            // Centra el mensaje
            lbl_message.Location = new Point(x, 84);
            
            // Establece el título de la venta por el especificado
            lbl_window_title.Text = window_title;
        }

        // Cuando carga por completo el formulario
        private void Alert_Load(object sender, System.EventArgs e)
        {
            // Configuración del tamoaño y de la sombra del formulario
            Width = 500;
            Height = 200;
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
        private void Alert_MouseDown(MouseEventArgs e)
        {
            ex = e.X;
            ey = e.Y;
            arrastre = true;
        }

        private void Alert_MouseUp()
        {
            arrastre = false;
        }

        private void Alert_MouseMove()
        {
            if (arrastre)
            {
                Point p = new Point(MousePosition.X - this.Location.X - ex, MousePosition.Y - this.Location.Y - ey);
                this.Location = this.PointToScreen(p);
            }
        }

        private void menuBar_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            Alert_MouseDown(e);
        }

        private void menuBar_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            Alert_MouseMove();
        }

        private void menuBar_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            Alert_MouseUp();
        }

        private void lbl_window_title_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            Alert_MouseDown(e);
        }

        private void lbl_window_title_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            Alert_MouseMove();
        }

        private void lbl_window_title_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            Alert_MouseUp();
        }
        /* --------------------- Fin de la configuración del arrastre del formulario ---------------- */

        // Se ejecuta al presionar el botón de aceptar
        private void accept_button_Click(object sender, EventArgs e)
        {
            // Cierra el formulario actual
            this.Close();
        }

        /* ---------------------- Efectos hover de los botones ---------------------- */
        private void accept_button_MouseEnter(object sender, System.EventArgs e)
        {
            accept_button.ForeColor = Color.FromArgb(17, 17, 17);
        }

        private void accept_button_MouseLeave(object sender, System.EventArgs e)
        {
            accept_button.ForeColor = Color.FromArgb(255, 193, 7);
        }
        /* ---------------------- Fin de los efectos hover de los botones ---------------------- */

        // Se ejecuta al presionar el botón de cerrar
        private void btn_close_Click(object sender, System.EventArgs e)
        {
            // Cierra el formulario actual
            this.Close();
        }
    }
}
