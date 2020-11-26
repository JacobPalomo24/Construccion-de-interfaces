using System;
using System.Drawing;
using System.Windows.Forms;

namespace contruccion_de_interfaces
{
    public partial class DataRegister : Form
    {
        private Dropshadow shadow;
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
