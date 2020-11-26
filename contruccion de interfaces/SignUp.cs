using System;
using System.Drawing;
using System.Windows.Forms;

namespace contruccion_de_interfaces
{
    public partial class SignUp : Form
    {
        private Dropshadow shadow;
        public SignUp()
        {
            InitializeComponent();

            if (!btn_sign_up.Enabled)
            {
                btn_sign_up.FlatAppearance.BorderColor = Color.FromArgb(66, 66, 66);
                btn_sign_up.ForeColor = Color.FromArgb(66, 66, 66);
            }
        }

        private void signUp_Load(object sender, System.EventArgs e)
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

            this.ActiveControl = btn_sign_up;
        }

        int ex, ey;
        bool arrastre;
        private void signUp_MouseDown(System.Windows.Forms.MouseEventArgs e)
        {
            ex = e.X;
            ey = e.Y;
            arrastre = true;
        }

        private void signUp_MouseUp()
        {
            arrastre = false;
        }

        private void signUp_MouseMove()
        {
            if (arrastre)
            {
                Point p = new Point(MousePosition.X - this.Location.X - ex, MousePosition.Y - this.Location.Y - ey);
                this.Location = this.PointToScreen(p);
            }
        }

        private void menuBar_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            signUp_MouseDown(e);
        }

        private void menuBar_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            signUp_MouseMove();
        }

        private void menuBar_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            signUp_MouseUp();
        }

        private void lbl_window_title_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            signUp_MouseDown(e);
        }

        private void lbl_window_title_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            signUp_MouseMove();
        }

        private void lbl_window_title_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            signUp_MouseUp();
        }

        private void btn_close_Click(object sender, System.EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btn_minimize_Click(object sender, System.EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void lnk_lbl_login_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Dispose();
        }

        private void btn_sign_up_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btn_sign_up_MouseEnter(object sender, System.EventArgs e)
        {
            btn_sign_up.ForeColor = Color.FromArgb(17, 17, 17);
        }

        private void btn_sign_up_MouseLeave(object sender, System.EventArgs e)
        {
            btn_sign_up.ForeColor = Color.FromArgb(255, 193, 7);
        }

        private void input_username_TextChange(object sender, System.EventArgs e)
        {
            if (input_username.Text != "" && input_pass.Text != "" && input_confirm_pass.Text != "")
            {
                btn_sign_up.Enabled = true;
            }
            else
            {
                btn_sign_up.Enabled = false;
            }
        }

        private void input_pass_TextChange(object sender, System.EventArgs e)
        {
            if (input_username.Text != "" && input_pass.Text != "" && input_confirm_pass.Text != "")
            {
                btn_sign_up.Enabled = true;
            }
            else
            {
                btn_sign_up.Enabled = false;
            }
        }

        private void input_confirm_pass_TextChange(object sender, System.EventArgs e)
        {
            if (input_username.Text != "" && input_pass.Text != "" && input_confirm_pass.Text != "")
            {
                btn_sign_up.Enabled = true;
            }
            else
            {
                btn_sign_up.Enabled = false;
            }
        }
        private void btn_sign_up_EnabledChange(object sender, System.EventArgs e)
        {
            if (!btn_sign_up.Enabled)
            {
                btn_sign_up.FlatAppearance.BorderColor = Color.FromArgb(66, 66, 66);
                btn_sign_up.ForeColor = Color.FromArgb(66, 66, 66);
            }
            else
            {
                btn_sign_up.FlatAppearance.BorderColor = Color.FromArgb(255, 193, 7);
                btn_sign_up.ForeColor = Color.FromArgb(255, 193, 7);
            }
        }

    }
}
