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
            lbl_greeting.Text = "¡Bienvenido, " + user + "!";
            int x = (800 - lbl_greeting.Width) / 2;
            lbl_greeting.Location = new Point(x, 191);
        }

        private void Home_Load(object sender, System.EventArgs e)
        {
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

        private void menuBar_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            Home_MouseDown(e);
        }

        private void menuBar_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            Home_MouseMove();
        }

        private void menuBar_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            Home_MouseUp();
        }

        private void lbl_window_title_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            Home_MouseDown(e);
        }

        private void lbl_window_title_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            Home_MouseMove();
        }

        private void lbl_window_title_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            Home_MouseUp();
        }

        private void btn_close_Click(object sender, System.EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btn_minimize_Click(object sender, System.EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_settings_MouseEnter(object sender, System.EventArgs e)
        {
            btn_settings.Image = Properties.Resources.settings_hover;
        }

        private void btn_settings_MouseLeave(object sender, System.EventArgs e)
        {
            btn_settings.Image = Properties.Resources.settings;
        }

        private void btn_alta_datos_MouseEnter(object sender, System.EventArgs e)
        {
            btn_alta_datos.ForeColor = Color.FromArgb(17, 17, 17);
        }

        private void btn_alta_datos_MouseLeave(object sender, System.EventArgs e)
        {
            btn_alta_datos.ForeColor = Color.FromArgb(255, 193, 7);
        }

        private void btn_cambios_bajas_MouseEnter(object sender, System.EventArgs e)
        {
            btn_cambios_bajas.ForeColor = Color.FromArgb(17, 17, 17);
        }

        private void btn_settings_Click(object sender, EventArgs e)
        {

            if (!FormUtils.findOpenForm("Settings"))
            {
                Point HomeLocation = this.Location;
                Settings settings_form = new Settings(HomeLocation);
                settings_form.Show();
            }
        }

        private void btn_alta_datos_Click(object sender, EventArgs e)
        {
            this.Hide();
            DataRegister data_register_form = new DataRegister();
            data_register_form.Location = PointToScreen(this.Location);
            data_register_form.ShowDialog();
            this.Show();
        }

        private void btn_cambios_bajas_Click(object sender, EventArgs e)
        {
            this.Hide();
            EditDelete edit_delete_form = new EditDelete();
            edit_delete_form.Location = PointToScreen(this.Location);
            edit_delete_form.ShowDialog();
            this.Show();
        }

        private void btn_cambios_bajas_MouseLeave(object sender, System.EventArgs e)
        {
            btn_cambios_bajas.ForeColor = Color.FromArgb(255, 193, 7);
        }
    }
}
