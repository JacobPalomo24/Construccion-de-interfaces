using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace contruccion_de_interfaces
{
    public partial class EditDelete : Form
    {
        private Dropshadow shadow;

        public EditDelete()
        {
            InitializeComponent();

            if (!btn_save.Enabled)
            {
                btn_save.FlatAppearance.BorderColor = Color.FromArgb(66, 66, 66);
                btn_save.ForeColor = Color.FromArgb(66, 66, 66);
            }

            if (!btn_search_file.Enabled)
            {
                btn_search_file.FlatAppearance.BorderColor = Color.FromArgb(66, 66, 66);
                btn_search_file.ForeColor = Color.FromArgb(66, 66, 66);
            }

            if (!btn_delete_file.Enabled)
            {
                btn_delete_file.FlatAppearance.BorderColor = Color.FromArgb(66, 66, 66);
                btn_delete_file.ForeColor = Color.FromArgb(66, 66, 66);
            }

            if (!btn_delete_file.Enabled)
            {
                btn_delete_file.FlatAppearance.BorderColor = Color.FromArgb(66, 66, 66);
                btn_delete_file.ForeColor = Color.FromArgb(66, 66, 66);
            }
        }

        private void EditDelete_Load(object sender, EventArgs e)
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

        private void EditDelete_MouseDown(MouseEventArgs e)
        {
            ex = e.X;
            ey = e.Y;
            arrastre = true;
        }

        private void EditDelete_MouseUp()
        {
            arrastre = false;
        }

        private void EditDelete_MouseMove()
        {
            if (arrastre)
            {
                Point p = new Point(MousePosition.X - this.Location.X - ex, MousePosition.Y - this.Location.Y - ey);
                this.Location = this.PointToScreen(p);
            }
        }

        private void menuBar_MouseDown(object sender, MouseEventArgs e)
        {
            EditDelete_MouseDown(e);
        }

        private void menuBar_MouseMove(object sender, MouseEventArgs e)
        {
            EditDelete_MouseMove();
        }

        private void menuBar_MouseUp(object sender, MouseEventArgs e)
        {
            EditDelete_MouseUp();
        }

        private void lbl_window_title_MouseDown(object sender, MouseEventArgs e)
        {
            EditDelete_MouseDown(e);
        }

        private void lbl_window_title_MouseMove(object sender, MouseEventArgs e)
        {
            EditDelete_MouseMove();
        }

        private void lbl_window_title_MouseUp(object sender, MouseEventArgs e)
        {
            EditDelete_MouseUp();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btn_cancel_MouseEnter(object sender, EventArgs e)
        {
            btn_cancel.ForeColor = Color.FromArgb(17, 17, 17);
        }

        private void btn_cancel_MouseLeave(object sender, EventArgs e)
        {
            btn_cancel.ForeColor = Color.FromArgb(255, 193, 7);
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

        private void btn_search_file_MouseEnter(object sender, EventArgs e)
        {
            btn_search_file.ForeColor = Color.FromArgb(17, 17, 17);
        }

        private void btn_search_file_MouseLeave(object sender, EventArgs e)
        {
            btn_search_file.ForeColor = Color.FromArgb(255, 193, 7);
        }

        private void btn_delete_file_MouseEnter(object sender, EventArgs e)
        {
            btn_delete_file.ForeColor = Color.FromArgb(17, 17, 17);
        }

        private void btn_delete_file_MouseLeave(object sender, EventArgs e)
        {
            btn_delete_file.ForeColor = Color.FromArgb(255, 193, 7);
        }

        private void input_id_TextChange(object sender, System.EventArgs e)
        {
            if (input_id.Text != "" && input_date.Text != "")
            {
                btn_search_file.Enabled = true;
            }
            else
            {
                btn_search_file.Enabled = false;
            }
        }

        private void input_date_TextChange(object sender, System.EventArgs e)
        {
            if (input_id.Text != "" && input_date.Text != "")
            {
                btn_search_file.Enabled = true;
            }
            else
            {
                btn_search_file.Enabled = false;
            }
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

        private void btn_search_file_Click(object sender, EventArgs e)
        {
            input_precipitation.Enabled = true;
            input_precipitation.PlaceholderText = "Precipitación";
            lbl_precipitation.ForeColor = Color.White;

            input_evaporation.Enabled = true;
            input_evaporation.PlaceholderText = "Evaporación";
            lbl_evaporation.ForeColor = Color.White;

            input_maximum_temperature.Enabled = true;
            input_maximum_temperature.PlaceholderText = "Temperatura máxima";
            lbl_maximum_temperature.ForeColor = Color.White;

            input_minimum_temperature.Enabled = true;
            input_minimum_temperature.PlaceholderText = "Temperatura mínima";
            lbl_minimum_temperature.ForeColor = Color.White;

            btn_delete_file.Enabled = true;

            lbl_notifications.Text = "¡Archivo encontrado correctamente!";
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

        private void btn_search_file_EnabledChanged(object sender, System.EventArgs e)
        {
            if (!btn_search_file.Enabled)
            {
                btn_search_file.FlatAppearance.BorderColor = Color.FromArgb(66, 66, 66);
                btn_search_file.ForeColor = Color.FromArgb(66, 66, 66);
            }
            else
            {
                btn_search_file.FlatAppearance.BorderColor = Color.FromArgb(255, 193, 7);
                btn_search_file.ForeColor = Color.FromArgb(255, 193, 7);
            }
        }

        private void btn_delete_file_EnabledChanged(object sender, System.EventArgs e)
        {
            if (!btn_delete_file.Enabled)
            {
                btn_delete_file.FlatAppearance.BorderColor = Color.FromArgb(66, 66, 66);
                btn_delete_file.ForeColor = Color.FromArgb(66, 66, 66);
            }
            else
            {
                btn_delete_file.FlatAppearance.BorderColor = Color.FromArgb(255, 193, 7);
                btn_delete_file.ForeColor = Color.FromArgb(255, 193, 7);
            }
        }

    }
}
