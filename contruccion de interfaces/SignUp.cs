﻿using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace contruccion_de_interfaces
{
    public partial class SignUp : Form
    {
        private Dropshadow shadow;
        private string path = @"C:\Users\jocel\source\repos\Construccion-de-interfaces\contruccion de interfaces\Data\users.txt";
        private bool passOk = false, userOk = false;

        private int id = 0;

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

            if (File.Exists(path))
            {
                StreamReader reader = File.OpenText(path);
                string contenido = reader.ReadToEnd();
                reader.Close();

                string[] users = contenido.Split('\n');

                for (int i = 0; i < users.Length-3; i += 5)
                {
                    id = int.Parse(users[i].Trim().Substring(10));
                }

                id++;
            }
            else
            {
                id++;
            }
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
            string username = input_username.Text, pass = input_pass.Text, confirm_pass = input_confirm_pass.Text, status = "1", symbolsPass = " !\"#$%&'()*+,-./:;<=>?@[\\]^_`{|}~", uppercase = "ABCDEFGHYJKLMNÑOPQRSTUVWXYZ", lowercase = "abcdefghijklmnñopqrstuvwxyz", numbers = "0123456789";
            bool existUsername = false, cSymbols = false, cUppercase = false, cLowercase = false, cNumbers = false;

            Alert alert;

            if (username != "" && pass != "" && confirm_pass != "")
            {

                if (File.Exists(path))
                {
                    StreamReader reader = File.OpenText(path);
                    string contenido = reader.ReadToEnd();
                    reader.Close();

                    string[] users = contenido.Split('\n');

                    for(int i = 1; i < users.Length; i+=5)
                    {
                        if (users[i].Trim().Substring(10).Equals(username))
                        {
                            existUsername = true;
                            break;
                        }
                        else
                        {
                            existUsername = false;
                        }
                    }
                }
                else
                {
                    existUsername = false;
                }

                if (!existUsername)
                {
                    if (pass.Length >= 8)
                    {
                        for (int i = 0; i < pass.Length; i++)
                        {
                            for (int o = 0; o < symbolsPass.Length; o++)
                            {
                                if (pass[i].ToString().Contains(symbolsPass[o]))
                                {
                                    cSymbols = true;
                                    break;
                                }
                            }
                        }

                        for (int i = 0; i < pass.Length; i++)
                        {
                            for (int o = 0; o < uppercase.Length; o++)
                            {
                                if (pass[i].ToString().Contains(uppercase[o]))
                                {
                                    cUppercase = true;
                                    break;
                                }
                            }
                        }

                        for (int i = 0; i < pass.Length; i++)
                        {
                            for (int o = 0; o < lowercase.Length; o++)
                            {
                                if (pass[i].ToString().Contains(lowercase[o]))
                                {
                                    cLowercase = true;
                                    break;
                                }
                            }
                        }

                        for (int i = 0; i < pass.Length; i++)
                        {
                            for (int o = 0; o < numbers.Length; o++)
                            {
                                if (pass[i].ToString().Contains(numbers[o]))
                                {
                                    cNumbers = true;
                                    break;
                                }
                            }
                        }

                        if (cSymbols)
                        {
                            if (cUppercase)
                            {
                                if (cLowercase)
                                {
                                    if (cNumbers)
                                    {
                                        if (pass == confirm_pass)
                                        {
                                            string[] user = { "ID:       " + id.ToString(),
                                                          "USERNAME: " + username,
                                                          "PASSWORD: " + pass,
                                                          "STATUS:   " + status,
                                                          "--------------------------------------------"};

                                            if (File.Exists(path))
                                            {
                                                StreamReader reader = File.OpenText(path);
                                                string contenido = reader.ReadToEnd();
                                                reader.Close();

                                                for (int o = 0; o < user.Length; o++)
                                                {
                                                    contenido += "\n" + user[o];
                                                }

                                                string[] users = contenido.Split('\n');

                                                StreamWriter writer = new StreamWriter(path);
                                                for (int i = 0; i < users.Length; i++)
                                                {
                                                    if (i == users.Length - 1)
                                                    {
                                                        writer.Write(users[i].Trim());
                                                    }
                                                    else
                                                    {
                                                        writer.Write(users[i].Trim() + "\n");
                                                    }
                                                }
                                                writer.Close();
                                            }
                                            else
                                            {
                                                StreamWriter writer = new StreamWriter(path);
                                                for (int i = 0; i < user.Length; i++)
                                                {
                                                    if (i == user.Length - 1)
                                                    {
                                                        writer.Write(user[i]);
                                                    }
                                                    else
                                                    {
                                                        writer.Write(user[i] + "\n");
                                                    }
                                                }
                                                writer.Close();
                                            }

                                            this.Dispose();
                                        }
                                        else
                                        {
                                            passOk = false;
                                            input_pass.ForeColor = Color.FromArgb(255, 0, 0);
                                            input_confirm_pass.ForeColor = Color.FromArgb(255, 0, 0);
                                            lbl_pass.ForeColor = Color.FromArgb(255, 0, 0);
                                            lbl_confirm_pass.ForeColor = Color.FromArgb(255, 0, 0);
                                            alert = new Alert("Las contraseñas deben ser iguales.", "Error en las contraseñas");
                                            alert.ShowDialog();
                                        }
                                    }
                                    else
                                    {
                                        passOk = false;
                                        input_pass.ForeColor = Color.FromArgb(255, 0, 0);
                                        lbl_pass.ForeColor = Color.FromArgb(255, 0, 0);
                                        alert = new Alert("La contraseña debe contener almenos 1 número.", "Contraseña no segura");
                                        alert.ShowDialog();
                                    }
                                }
                                else
                                {
                                    passOk = false;
                                    input_pass.ForeColor = Color.FromArgb(255, 0, 0);
                                    lbl_pass.ForeColor = Color.FromArgb(255, 0, 0);
                                    alert = new Alert("La contraseña debe contener 1 letra minúscula.", "Contraseña no segura");
                                    alert.ShowDialog();
                                }
                            }
                            else
                            {
                                passOk = false;
                                input_pass.ForeColor = Color.FromArgb(255, 0, 0);
                                lbl_pass.ForeColor = Color.FromArgb(255, 0, 0);
                                alert = new Alert("La contraseña debe de contener 1 letra mayúscula.", "Contraseña no segura");
                                alert.ShowDialog();
                            }
                        }
                        else
                        {
                            passOk = false;
                            input_pass.ForeColor = Color.FromArgb(255, 0, 0);
                            lbl_pass.ForeColor = Color.FromArgb(255, 0, 0);
                            alert = new Alert("La contraseña debe contener almenos un símbolo.", "Contraseña no segura");
                            alert.ShowDialog();
                        }
                    }
                    else
                    {
                        passOk = false;
                        input_pass.ForeColor = Color.FromArgb(255, 0, 0);
                        lbl_pass.ForeColor = Color.FromArgb(255, 0, 0);
                        alert = new Alert("La contraseña debe tener mínimo 8 caracteres.", "Contraseña no segura");
                        alert.ShowDialog();
                    }
                }
                else
                {
                    userOk = false;
                    input_username.ForeColor = Color.FromArgb(255, 0, 0);
                    lbl_username.ForeColor = Color.FromArgb(255, 0, 0);
                    alert = new Alert("El usuario ya existe, elige otro.", "Usuario existente");
                    alert.ShowDialog();
                }
            }
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

        private void input_username_GotFocus(object sender, System.EventArgs e)
        {
            if (!userOk)
            {
                passOk = true;
                input_username.ForeColor = Color.White;
                lbl_username.ForeColor = Color.White;
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

        private void input_pass_GotFocus(object sender, System.EventArgs e)
        {
            if (!passOk)
            {
                passOk = true;
                input_pass.ForeColor = Color.White;
                input_confirm_pass.ForeColor = Color.White;
                lbl_pass.ForeColor = Color.White;
                lbl_confirm_pass.ForeColor = Color.White;
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

        private void input_confirm_pass_GotFocus(object sender, System.EventArgs e)
        {
            if (!passOk)
            {
                passOk = true;
                input_pass.ForeColor = Color.White;
                input_confirm_pass.ForeColor = Color.White;
                lbl_pass.ForeColor = Color.White;
                lbl_confirm_pass.ForeColor = Color.White;
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
