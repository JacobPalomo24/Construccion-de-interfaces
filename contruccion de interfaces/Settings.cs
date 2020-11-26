using System;
using System.Drawing;
using System.Windows.Forms;

namespace contruccion_de_interfaces
{
    public partial class Settings : Form
    {
        private Dropshadow shadow;
        public Settings(Point FormLocation)
        {
            this.Location = PointToScreen(FormLocation);
            InitializeComponent();
        }

        private void Settings_Load(object sender, EventArgs e)
        {
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

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

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

        private void btn_credits_Click(object sender, EventArgs e)
        {

            Credits credits_form = new Credits();
            credits_form.Location = PointToScreen(this.Location);
            credits_form.ShowDialog();
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            this.Close();
            Home.ActiveForm.Dispose();
        }

        private void btn_logout_MouseLeave(object sender, EventArgs e)
        {
            btn_logout.ForeColor = Color.FromArgb(255, 193, 7);
        }
    }
}
