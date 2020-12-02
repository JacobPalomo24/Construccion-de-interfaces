using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace contruccion_de_interfaces
{
    public partial class DataRegister : Form
    {
        private Dropshadow shadow;
        private string path = @"C:\Users\jocel\source\repos\Construccion-de-interfaces\contruccion de interfaces\Data\database.txt";
        private int id = 0;

        public DataRegister()
        {
            InitializeComponent();

            if (!btn_save.Enabled)
            {
                btn_save.FlatAppearance.BorderColor = Color.FromArgb(66, 66, 66);
                btn_save.ForeColor = Color.FromArgb(66, 66, 66);
            }
        }

        private void DataRegister_Load(object sender, EventArgs e)
        {
            DateTime today = DateTime.Today;

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

            input_date.Text = today.ToString("dd/MM/yyyy");

            if (File.Exists(path))
            {
                StreamReader reader = File.OpenText(path);
                string contenido = reader.ReadToEnd();
                reader.Close();

                string[] climas = contenido.Split('\n');

                for (int i = 0; i < climas.Length; i += 8)
                {
                    id = int.Parse(climas[i].Trim().Substring(15));
                }

                id++;
            }
            else
            {
                id++;
            }

            input_id.Text = id.ToString();
        }

        int ex, ey;

        bool arrastre;

        private void DataRegister_MouseDown(MouseEventArgs e)
        {
            ex = e.X;
            ey = e.Y;
            arrastre = true;
        }

        private void DataRegister_MouseUp()
        {
            arrastre = false;
        }

        private void DataRegister_MouseMove()
        {
            if (arrastre)
            {
                Point p = new Point(MousePosition.X - this.Location.X - ex, MousePosition.Y - this.Location.Y - ey);
                this.Location = this.PointToScreen(p);
            }
        }

        private void menuBar_MouseDown(object sender, MouseEventArgs e)
        {
            DataRegister_MouseDown(e);
        }

        private void menuBar_MouseMove(object sender, MouseEventArgs e)
        {
            DataRegister_MouseMove();
        }

        private void menuBar_MouseUp(object sender, MouseEventArgs e)
        {
            DataRegister_MouseUp();
        }

        private void lbl_window_title_MouseDown(object sender, MouseEventArgs e)
        {
            DataRegister_MouseDown(e);
        }

        private void lbl_window_title_MouseMove(object sender, MouseEventArgs e)
        {
            DataRegister_MouseMove();
        }

        private void lbl_window_title_MouseUp(object sender, MouseEventArgs e)
        {
            DataRegister_MouseUp();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btn_back_MouseEnter(object sender, EventArgs e)
        {
            btn_back.ForeColor = Color.FromArgb(17, 17, 17);
        }

        private void btn_back_MouseLeave(object sender, EventArgs e)
        {
            btn_back.ForeColor = Color.FromArgb(255, 193, 7);
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            string ID = input_id.Text.Trim(), date = input_date.Text.Trim(), precipitation = input_precipitation.Text.Trim(), evaporation = input_evaporation.Text.Trim(), max_temp = input_maximum_temperature.Text.Trim(), min_temp = input_minimum_temperature.Text.Trim();

            Alert alert;

            if (ID != "" && date != "" && precipitation != "" && evaporation != "" && max_temp != "" && min_temp != "")
            {
                string[] clima = { "ID:            " + ID,
                                   "DATE:          " + date,
                                   "PRECIPITACION: " + precipitation,
                                   "EVAPORACION:   " + evaporation,
                                   "TEMP-MA:       " + max_temp,
                                   "TEMP-MI:       " + min_temp,
                                   "STATUS:        1",
                                   "--------------------------------------------"};

                if (File.Exists(path))
                {
                    StreamReader reader = File.OpenText(path);
                    string contenido = reader.ReadToEnd();
                    reader.Close();

                    for (int o = 0; o < clima.Length; o++)
                    {
                        contenido += "\n" + clima[o];
                    }

                    string[] climas = contenido.Split('\n');

                    StreamWriter writer = new StreamWriter(path);
                    for (int i = 0; i < climas.Length; i++)
                    {
                        if (i == climas.Length - 1)
                        {
                            writer.Write(climas[i].Trim());
                        }
                        else
                        {
                            writer.Write(climas[i].Trim() + "\n");
                        }
                    }
                    writer.Close();

                    input_precipitation.Text = "";
                    input_evaporation.Text = "";
                    input_maximum_temperature.Text = "";
                    input_minimum_temperature.Text = "";
                    DataRegister_Load(sender, e);
                }
                else
                {
                    StreamWriter writer = new StreamWriter(path);
                    for (int i = 0; i < clima.Length; i++)
                    {
                        if (i == clima.Length - 1)
                        {
                            writer.Write(clima[i]);
                        }
                        else
                        {
                            writer.Write(clima[i] + "\n");
                        }
                    }
                    writer.Close();
                }
            }
            else
            {
                alert = new Alert("Todos los campos deben de estar llenos.", "Campos vacíos");
            }
        }

        private void btn_save_MouseEnter(object sender, EventArgs e)
        {
            btn_save.ForeColor = Color.FromArgb(17, 17, 17);
        }

        private void btn_save_MouseLeave(object sender, EventArgs e)
        {
            btn_save.ForeColor = Color.FromArgb(255, 193, 7);
        }

        private void btn_minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void input_precipitation_TextChange(object sender, System.EventArgs e)
        {
            if (input_precipitation.Text != "" && input_evaporation.Text != "" && input_maximum_temperature.Text != "" && input_minimum_temperature.Text != "")
            {
                btn_save.Enabled = true;
            }
            else
            {
                btn_save.Enabled = false;
            }
        }

        private void input_evaporation_TextChange(object sender, System.EventArgs e)
        {
            if (input_precipitation.Text != "" && input_evaporation.Text != "" && input_maximum_temperature.Text != "" && input_minimum_temperature.Text != "")
            {
                btn_save.Enabled = true;
            }
            else
            {
                btn_save.Enabled = false;
            }
        }

        private void input_maximum_temperature_TextChange(object sender, System.EventArgs e)
        {
            if (input_precipitation.Text != "" && input_evaporation.Text != "" && input_maximum_temperature.Text != "" && input_minimum_temperature.Text != "")
            {
                btn_save.Enabled = true;
            }
            else
            {
                btn_save.Enabled = false;
            }
        }

        private void input_minimum_temperature_TextChange(object sender, System.EventArgs e)
        {
            if (input_precipitation.Text != "" && input_evaporation.Text != "" && input_maximum_temperature.Text != "" && input_minimum_temperature.Text != "")
            {
                btn_save.Enabled = true;
            }
            else
            {
                btn_save.Enabled = false;
            }
        }

        private void btn_save_EnabledChanged(object sender, System.EventArgs e)
        {
            if (!btn_save.Enabled)
            {
                btn_save.FlatAppearance.BorderColor = Color.FromArgb(66, 66, 66);
                btn_save.ForeColor = Color.FromArgb(66, 66, 66);
            }
            else
            {
                btn_save.FlatAppearance.BorderColor = Color.FromArgb(255, 193, 7);
                btn_save.ForeColor = Color.FromArgb(255, 193, 7);
            }
        }
    }
}
