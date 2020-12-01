using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace contruccion_de_interfaces
{
    public partial class Alert : Form
    {
        Dropshadow shadow;

        public Alert(string message, string window_title)
        {
            InitializeComponent();
            lbl_message.Text = message;
            int x = (500 - lbl_message.Width) / 2;
            lbl_message.Location = new Point(x, 84);
            lbl_window_title.Text = window_title;
        }

        private void Alert_Load(object sender, System.EventArgs e)
        {
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

        int ex, ey;
        bool arrastre;
        private void Alert_MouseDown(System.Windows.Forms.MouseEventArgs e)
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

        private void accept_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void accept_button_MouseEnter(object sender, System.EventArgs e)
        {
            accept_button.ForeColor = Color.FromArgb(17, 17, 17);
        }

        private void accept_button_MouseLeave(object sender, System.EventArgs e)
        {
            accept_button.ForeColor = Color.FromArgb(255, 193, 7);
        }

        private void btn_close_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }
    }
}
