using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace contruccion_de_interfaces
{
    public partial class DataRegister : Form
    {
        private Dropshadow shadow;
        // Ruta donde se encuentra o donde se encontrará el archivo de la base de datos
        private string path = @"C:\Users\jocel\source\repos\Construccion-de-interfaces\contruccion de interfaces\Data\database.txt";
        private int id = 0;

        // Función que inicializa el formulario por defecto
        public DataRegister()
        {
            InitializeComponent();

            // Sí el botón guardar está desactivado
            if (!btn_save.Enabled)
            {
                // Color del borde del botón a un gris más claro que el del fondo para parcer deshabilitado
                btn_save.FlatAppearance.BorderColor = Color.FromArgb(66, 66, 66);
                // Color del texto del botón a un gris más claro que el del fondo para parcer deshabilitado
                btn_save.ForeColor = Color.FromArgb(66, 66, 66);
            }
        }

        // Cuando carga por completo el formulario
        private void DataRegister_Load(object sender, EventArgs e)
        {
            // Obtiene la fecha actual
            DateTime today = DateTime.Today;

            // Configuración del tamoaño y de la sombra del formulario
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

            // Escribe la fecha actual en el campo fecha
            input_date.Text = today.ToString("dd/MM/yyyy");

            // Busca el ultimo id para saber que id se le asignará, es decir, el ultimo id + 1, 
            // en caso de que no exista ningún id, se le asignará el 1.
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

            // Escribe el id que se le asignará a ese nuevo clima en el input correspondiente
            input_id.Text = id.ToString();
        }

        /* --------------------- Configuración del arrastre del formulario ---------------- */
        /*
         * Nota: Todo este código ya fué exlicado en el código de los formularios EditDelete y SignUp
         */
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
        /* --------------------- Fin de la configuración del arrastre del formulario ---------------- */

        // Al presionar el botón cerrar
        private void btn_close_Click(object sender, EventArgs e)
        {
            // Termina la aplicación
            Environment.Exit(0);
        }

        // Al presionar el botón de minizar
        private void btn_minimize_Click(object sender, EventArgs e)
        {
            // Minimiza el formulario actual
            this.WindowState = FormWindowState.Minimized;
        }

        // Al presionar el botón regresar
        private void btn_back_Click(object sender, EventArgs e)
        {
            // Cierra el formulario actual
            this.Dispose();
        }

        /* ---------------------- Efectos hover de los botones ---------------------- */
        private void btn_back_MouseEnter(object sender, EventArgs e)
        {
            btn_back.ForeColor = Color.FromArgb(17, 17, 17);
        }

        private void btn_back_MouseLeave(object sender, EventArgs e)
        {
            btn_back.ForeColor = Color.FromArgb(255, 193, 7);
        }

        private void btn_save_MouseEnter(object sender, EventArgs e)
        {
            btn_save.ForeColor = Color.FromArgb(17, 17, 17);
        }

        private void btn_save_MouseLeave(object sender, EventArgs e)
        {
            btn_save.ForeColor = Color.FromArgb(255, 193, 7);
        }
        /* ---------------------- Fin de los efectos hover de los botones ---------------------- */

        // Evento que se ejecuta cuando se hace clic en el botón de guardar
        private void btn_save_Click(object sender, EventArgs e)
        {
            // Guardo cada uno de los datos escritos en los inputs en las siguientes variables
            string ID = input_id.Text.Trim(), date = input_date.Text.Trim(), precipitation = input_precipitation.Text.Trim(), evaporation = input_evaporation.Text.Trim(), max_temp = input_maximum_temperature.Text.Trim(), min_temp = input_minimum_temperature.Text.Trim();

            // Creo un objeto de tipo alerta para mostrar alertas
            Alert alert;

            // Sí todos los campos están llenos
            if (ID != "" && date != "" && precipitation != "" && evaporation != "" && max_temp != "" && min_temp != "")
            {
                // Creo un nuevo clima con los datos proporcinados
                string[] clima = { "ID:            " + ID,
                                   "DATE:          " + date,
                                   "PRECIPITACION: " + precipitation,
                                   "EVAPORACION:   " + evaporation,
                                   "TEMP-MA:       " + max_temp,
                                   "TEMP-MI:       " + min_temp,
                                   "STATUS:        1",
                                   "--------------------------------------------"};

                // Si el archivo en la ruta 'path' existe
                if (File.Exists(path))
                {
                    // Creo un reader para leer el archivo
                    StreamReader reader = File.OpenText(path);
                    // Guardo el contenido en la variable contenido
                    string contenido = reader.ReadToEnd();
                    // Cierro el reader
                    reader.Close();

                    // Inserto el nuevo clima en el contenido recién obtenido del archivo
                    for (int o = 0; o < clima.Length; o++)
                    {
                        contenido += "\n" + clima[o];
                    }

                    // Separo el contenido ya con el nuevo clima para poder ingrsarlo después linea por linea
                    string[] climas = contenido.Split('\n');

                    // Creo un writer para escribir en el archivo de la ruta 'path'
                    StreamWriter writer = new StreamWriter(path);
                    // Escribo linea por linea y al final no agregara un salto de linea
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
                    // Cierro el writer
                    writer.Close();

                    // Vacío los campos
                    input_precipitation.Text = "";
                    input_evaporation.Text = "";
                    input_maximum_temperature.Text = "";
                    input_minimum_temperature.Text = "";
                    // Vuelvo a cargar el formulario
                    DataRegister_Load(sender, e);
                }
                // Sí el archivo no existe
                else
                {
                    // Escribo el primer clima
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
            // Si los campos no estan todos llenos
            else
            {
                // Envía un mensaje
                alert = new Alert("Todos los campos deben de estar llenos.", "Campos vacíos");
                alert.ShowDialog();
            }
        }

        /* ------------------------ Validación del formulario --------------------------- */
        // Nota: este fragmento de código también ya fué explicado en los dos forms mencionados anteriormente
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
        /* ------------------------ Fin de la validación del formulario --------------------------- */
    }
}
