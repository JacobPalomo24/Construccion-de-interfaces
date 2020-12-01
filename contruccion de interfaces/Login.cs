using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace contruccion_de_interfaces
{
    public partial class Login : Form
    {

        private Dropshadow shadow;
        private string path = @"C:\Users\jocel\source\repos\Construccion-de-interfaces\contruccion de interfaces\Data\users.txt";

        public Login()
        {
            InitializeComponent();

            if (!btn_login.Enabled)
            {
                btn_login.FlatAppearance.BorderColor = Color.FromArgb(66, 66, 66);
                btn_login.ForeColor = Color.FromArgb(66, 66, 66);
            }
        }

        private void Login_Load(object sender, System.EventArgs e)
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

            this.ActiveControl = btn_login;
        }

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

        private void btn_close_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void btn_minimize_Click(object sender, System.EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_login_MouseEnter(object sender, System.EventArgs e)
        {
            btn_login.ForeColor = Color.FromArgb(17, 17, 17);
        }

        private void btn_login_MouseLeave(object sender, System.EventArgs e)
        {
            btn_login.ForeColor = Color.FromArgb(255, 193, 7);
        }

        private void link_sign_up_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();

            SignUp signup_form = new SignUp();
            signup_form.Location = signup_form.PointToScreen(this.Location);
            signup_form.ShowDialog();
            this.Show();
        }

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

        private void btn_login_Click(object sender, EventArgs e)
        {
            string username = input_username.Text.Trim(), pass = input_password.Text.Trim();

            if (username != "" && pass != "")
            {
                if (userExist(username, pass))
                {
                    this.Hide();

                    Home home_form = new Home(username);
                    home_form.Location = PointToScreen(this.Location);
                    home_form.ShowDialog();
                    this.Show();
                }
                else
                {
                    Alert alert = new Alert("Usuario o contraseña incorrectos.", "Credenciales incorrectas");
                    alert.ShowDialog();
                }
            }
        }

        private bool userExist(string username, string pass)
        {
            if (File.Exists(path))
            {
                bool eUser = false;

                StreamReader reader = File.OpenText(path);
                string contenido = reader.ReadToEnd();
                reader.Close();

                string[] users = contenido.Split('\n');

                for (int i = 1; i < users.Length; i+=5)
                {
                    if (users[i].Trim().Substring(10).Equals(username))
                    {
                        if(users[i + 1].Trim().Substring(10).Equals(pass))
                        {
                            eUser = true;
                            break;
                        }
                        else
                        {
                            eUser = false;
                            break;
                        }
                    }
                    else
                    {
                        eUser = false;
                    }
                }

                return eUser;
            }
            else
            {
                return false;
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
    }
}
