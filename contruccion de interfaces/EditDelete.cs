using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace contruccion_de_interfaces
{
    public partial class EditDelete : Form
    {
        private Dropshadow shadow;
        private string path = @"C:\Users\jocel\source\repos\Construccion-de-interfaces\contruccion de interfaces\Data\database.txt";

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
            string id = input_id.Text;
            string date = input_date.Text;

            StreamReader reader = File.OpenText(path);
            string contenido = reader.ReadToEnd();
            reader.Close();
            string[] climas = contenido.Split('\n');

            bool encontradoId = false, encontradoDate = false;
            int pos = 0;

            // Search by ID
            for (int i = 0; i < climas.Length; i += 8)
            {
                if (climas[i].Trim().Substring(0, 2).Equals("ID"))
                {
                    if (climas[i].Trim().Substring(15).Equals(id))
                    {
                        encontradoId = true;
                        pos = i;
                        break;
                    }
                    else
                    {
                        encontradoId = false;
                    }
                }
            }

            // Search by Date
            for (int i = 1; i < climas.Length; i += 8)
            {
                if (climas[i].Trim().Substring(0, 4).Equals("DATE"))
                {
                    if (climas[i].Trim().Substring(15).Equals(date))
                    {
                        encontradoDate = true;
                        pos = i;
                        break;
                    }
                    else
                    {
                        encontradoDate = false;
                    }
                }
            }

            if (encontradoId || encontradoDate)
            {

                if (encontradoId)
                {
                    pos += 6;
                }
                else if (encontradoDate)
                {
                    pos += 5;
                }

                if (climas[pos].Trim().Substring(15) != "0")
                {
                    if (encontradoId)
                    {
                        pos -= 4;
                    }
                    else if (encontradoDate)
                    {
                        pos -= 4;
                    }

                    lbl_id.ForeColor = Color.FromArgb(66, 66, 66);
                    input_id.Enabled = false;
                    lbl_date.ForeColor = Color.FromArgb(66, 66, 66);
                    input_date.Enabled = false;
                    btn_search_file.Enabled = false;

                    input_precipitation.Enabled = true;
                    input_precipitation.PlaceholderText = climas[pos].Trim().Substring(15);
                    lbl_precipitation.ForeColor = Color.White;
                    pos++;
                    input_evaporation.Enabled = true;
                    input_evaporation.PlaceholderText = climas[pos].Trim().Substring(15);
                    lbl_evaporation.ForeColor = Color.White;
                    pos++;
                    input_maximum_temperature.Enabled = true;
                    input_maximum_temperature.PlaceholderText = climas[pos].Trim().Substring(15);
                    lbl_maximum_temperature.ForeColor = Color.White;
                    pos++;
                    input_minimum_temperature.Enabled = true;
                    input_minimum_temperature.PlaceholderText = climas[pos].Trim().Substring(15);
                    lbl_minimum_temperature.ForeColor = Color.White;

                    btn_delete_file.Enabled = true;

                    lbl_notifications.Text = "¡Archivo encontrado correctamente!";
                }
                else
                {
                    lbl_notifications.Text = "El archivo que buscas ha sido eliminado.";
                }
            }
            else
            {
                lbl_notifications.Text = "¡Archivo no encontrado!";
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

        private StreamWriter writer;
        private StreamReader reader;
        private void btn_delete_file_Click(object sender, EventArgs e)
        {
            string id = input_id.Text;
            string date = input_date.Text;

            reader = File.OpenText(path);
            string contenido = reader.ReadToEnd();
            reader.Close();
            string[] datos = contenido.Split('\n');

            bool encontradoId = false, encontradoDate = false;
            int pos = 0;

            // Search by ID
            for (int i = 0; i < datos.Length; i += 8)
            {
                if (datos[i].Trim().Substring(0, 2).Equals("ID"))
                {
                    if (datos[i].Trim().Substring(15).Equals(id))
                    {
                        encontradoId = true;
                        pos = i;
                        break;
                    }
                    else
                    {
                        encontradoId = false;
                    }
                }
            }

            // Search by Date
            for (int i = 1; i < datos.Length; i += 8)
            {
                if (datos[i].Trim().Substring(0, 4).Equals("DATE"))
                {
                    if (datos[i].Trim().Substring(15).Equals(date))
                    {
                        encontradoDate = true;
                        pos = i;
                        break;
                    }
                    else
                    {
                        encontradoDate = false;
                    }
                }
            }

            if (encontradoId || encontradoDate)
            {
                if (encontradoId)
                {
                    pos += 6;
                }
                else if (encontradoDate)
                {
                    pos += 5;
                }

                datos[pos] = "STATUS:        0";

                writer = new StreamWriter(path);
                writer.Flush();
                for (int i = 0; i < datos.Length; i++)
                {
                    if (i == datos.Length - 1)
                    {
                        writer.Write(datos[i]);
                    }
                    else
                    {
                        writer.Write(datos[i] + "\n");
                    }
                }
                writer.Close();

                reader = File.OpenText(path);
                contenido = reader.ReadToEnd();
                reader.Close();

                Array.Clear(datos, 0, datos.Length);
                datos = contenido.Split('\n');

                if (datos[pos].Trim().Substring(15) == "0")
                {
                    lbl_notifications.Text = "El archivo fue eliminado correctamente.";
                }
                else
                {
                    lbl_notifications.Text = "El archivo no pudo ser eliminado.";
                }
            }

            //Habilitamos la búsqueda
            lbl_id.ForeColor = Color.White;
            input_id.Text = "";
            input_id.Enabled = true;

            lbl_date.ForeColor = Color.White;
            input_date.Enabled = true;
            input_date.Text = "";

            btn_search_file.Enabled = true;

            // Desahabilitamos la sección editar
            input_precipitation.Enabled = false;
            input_precipitation.PlaceholderText = "";
            input_precipitation.Text = "";
            lbl_precipitation.ForeColor = Color.FromArgb(66, 66, 66);

            input_evaporation.Enabled = false;
            input_evaporation.PlaceholderText = "";
            input_evaporation.Text = "";
            lbl_evaporation.ForeColor = Color.FromArgb(66, 66, 66);

            input_maximum_temperature.Enabled = false;
            input_maximum_temperature.PlaceholderText = "";
            input_maximum_temperature.Text = "";
            lbl_maximum_temperature.ForeColor = Color.FromArgb(66, 66, 66);

            input_minimum_temperature.Enabled = false;
            input_minimum_temperature.PlaceholderText = "";
            input_minimum_temperature.Text = "";
            lbl_minimum_temperature.ForeColor = Color.FromArgb(66, 66, 66);

            btn_save.Enabled = false;
            btn_delete_file.Enabled = false;
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

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (input_precipitation.Text.Trim() != "" && input_evaporation.Text.Trim() != "" && input_maximum_temperature.Text.Trim() != "" && input_minimum_temperature.Text.Trim() != "")
            {
                string id = input_id.Text,
                       date = input_date.Text;

                string[] newData = { input_precipitation.Text.Trim(), input_evaporation.Text.Trim(), input_maximum_temperature.Text.Trim(), input_minimum_temperature.Text.Trim() };

                bool encontradoId = false, encontradoDate = false;
                int pos = 0;

                StreamReader reader = File.OpenText(path);
                string contenido = reader.ReadToEnd();
                reader.Close();
                string[] datos = contenido.Split('\n');

                // Search by ID
                for (int i = 0; i < datos.Length; i += 8)
                {
                    if (datos[i].Substring(0, 2).Equals("ID"))
                    {
                        if (datos[i].Trim().Substring(15).Equals(id))
                        {
                            encontradoId = true;
                            pos = i;
                            break;
                        }
                        else
                        {
                            encontradoId = false;
                        }
                    }
                }

                // Search by Date
                for (int i = 1; i < datos.Length; i += 8)
                {
                    if (datos[i].Substring(0, 4).Equals("DATE"))
                    {
                        if (datos[i].Trim().Substring(15).Equals(date))
                        {
                            encontradoDate = true;
                            pos = i;
                            break;
                        }
                        else
                        {
                            encontradoDate = false;
                        }
                    }
                }

                if (encontradoId)
                {
                    pos += 2;
                }
                else if (encontradoDate)
                {
                    pos += 1;
                }

                datos[pos] = "PRECIPITACION: " + newData[0];
                pos++;
                datos[pos] = "EVAPORACION:   " + newData[1];
                pos++;
                datos[pos] = "TEMP-MA:       " + newData[2];
                pos++;
                datos[pos] = "TEMP-MI:       " + newData[3];

                writer.Close();
                writer = new StreamWriter(path);
                writer.Flush();
                for (int i = 0; i < datos.Length; i++)
                {
                    if (i == datos.Length - 1)
                    {
                        writer.Write(datos[i]);
                    }
                    else
                    {
                        writer.Write(datos[i] + "\n");
                    }
                }
                writer.Close();


                // Comprobamos si se editó correctamente el archivo
                StreamReader r = File.OpenText(path);
                contenido = r.ReadToEnd();
                reader.Close();

                Array.Clear(datos, 0, datos.Length);
                datos = contenido.Split('\n');

                pos -= 3;

                if (datos[pos].Trim().Substring(15) == newData[0])
                {
                    pos++;
                    if (datos[pos].Trim().Substring(15) == newData[1])
                    {
                        pos++;
                        if (datos[pos].Trim().Substring(15) == newData[2])
                        {
                            pos++;
                            if (datos[pos].Trim().Substring(15) == newData[3])
                            {
                                lbl_notifications.Text = "Archivo editado correctamente.\n";
                            }
                            else
                            {
                                lbl_notifications.Text = "El archivo no pudo ser editado correctamente.\n";
                            }
                        }
                        else
                        {
                            lbl_notifications.Text = "El archivo no pudo ser editado correctamente.\n";
                        }
                    }
                    else
                    {
                        lbl_notifications.Text = "El archivo no pudo ser editado correctamente.\n";
                    }
                }
                else
                {
                    lbl_notifications.Text = "El archivo no pudo ser editado correctamente.\n";
                }
            }

            //Habilitamos la búsqueda
            lbl_id.ForeColor = Color.White;
            input_id.Text = "";
            input_id.Enabled = true;

            lbl_date.ForeColor = Color.White;
            input_date.Enabled = true;
            input_date.Text = "";

            btn_search_file.Enabled = true;

            // Desahabilitamos la sección editar
            input_precipitation.Enabled = false;
            input_precipitation.PlaceholderText = "";
            input_precipitation.Text = "";
            lbl_precipitation.ForeColor = Color.FromArgb(66, 66, 66);

            input_evaporation.Enabled = false;
            input_evaporation.PlaceholderText = "";
            input_evaporation.Text = "";
            lbl_evaporation.ForeColor = Color.FromArgb(66, 66, 66);

            input_maximum_temperature.Enabled = false;
            input_maximum_temperature.PlaceholderText = "";
            input_maximum_temperature.Text = "";
            lbl_maximum_temperature.ForeColor = Color.FromArgb(66, 66, 66);

            input_minimum_temperature.Enabled = false;
            input_minimum_temperature.PlaceholderText = "";
            input_minimum_temperature.Text = "";
            lbl_minimum_temperature.ForeColor = Color.FromArgb(66, 66, 66);

            btn_save.Enabled = false;
            btn_delete_file.Enabled = false;
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
