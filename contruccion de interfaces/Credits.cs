﻿using System;
using System.Drawing;
using System.Windows.Forms;

namespace contruccion_de_interfaces
{
    public partial class Credits : Form
    {
        private Dropshadow shadow;
        public Credits()
        {
            InitializeComponent();
        }

        private void Credits_Load(object sender, System.EventArgs e)
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

        private void Credits_MouseDown(MouseEventArgs e)
        {
            ex = e.X;
            ey = e.Y;
            arrastre = true;
        }

        private void Credits_MouseUp()
        {
            arrastre = false;
        }

        private void Credits_MouseMove()
        {
            if (arrastre)
            {
                Point p = new Point(MousePosition.X - this.Location.X - ex, MousePosition.Y - this.Location.Y - ey);
                this.Location = this.PointToScreen(p);
            }
        }

        private void menuBar_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            Credits_MouseDown(e);
        }

        private void menuBar_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            Credits_MouseMove();
        }

        private void menuBar_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            Credits_MouseUp();
        }

        private void lbl_window_title_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            Credits_MouseDown(e);
        }

        private void lbl_window_title_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            Credits_MouseMove();
        }

        private void lbl_window_title_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            Credits_MouseUp();
        }

        private void btn_okay_MouseEnter(object sender, EventArgs e)
        {
            btn_okay.ForeColor = Color.FromArgb(17, 17, 17);
        }

        private void btn_okay_MouseLeave(object sender, EventArgs e)
        {
            btn_okay.ForeColor = Color.FromArgb(255, 193, 7);
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_okay_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
