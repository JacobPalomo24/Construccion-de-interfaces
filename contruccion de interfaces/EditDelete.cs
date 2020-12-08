using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace contruccion_de_interfaces
{
    public partial class EditDelete : Form
    {
        private Dropshadow shadow;
        // Ruta donde se encuentra o donde se encontrará el archivo de la base de datos
        private string path = @"C:\Users\jocel\source\repos\Construccion-de-interfaces\contruccion de interfaces\Data\database.txt";
        
        // Función que inicializa el formulario por defecto
        public EditDelete()
        {
            InitializeComponent();

            // Sí el botón guardar está desactivado
            if (!btn_save.Enabled)
            {
                // Color del borde del botón a un gris más claro que el del fondo
                btn_save.FlatAppearance.BorderColor = Color.FromArgb(66, 66, 66);
                // Color del texto del botón a un gris más claro que el del fondo
                btn_save.ForeColor = Color.FromArgb(66, 66, 66);
            }

            // Sí el botón de buscar esta desactivado
            if (!btn_search_file.Enabled)
            {
                // Color del borde del botón a un gris más claro que el del fondo
                btn_search_file.FlatAppearance.BorderColor = Color.FromArgb(66, 66, 66);
                // Color del texto del botón a un gris más claro que el del fondo
                btn_search_file.ForeColor = Color.FromArgb(66, 66, 66);
            }

            // Sí el botón de buscar esta desactivado
            if (!btn_delete_file.Enabled)
            {
                // Color del borde del botón a un gris más claro que el del fondo
                btn_delete_file.FlatAppearance.BorderColor = Color.FromArgb(66, 66, 66);
                // Color del texto del botón a un gris más claro que el del fondo
                btn_delete_file.ForeColor = Color.FromArgb(66, 66, 66);
            }

            // Sí el botón de buscar esta desactivado
            if (!btn_delete_file.Enabled)
            {
                // Color del borde del botón = rgb(66, 66, 66)
                btn_delete_file.FlatAppearance.BorderColor = Color.FromArgb(66, 66, 66);
                // Color del texto del botón = rgb(66, 66, 66)
                btn_delete_file.ForeColor = Color.FromArgb(66, 66, 66);
            }
        }

        // Se ejecuta al terminar de cargar el formulario
        private void EditDelete_Load(object sender, EventArgs e)
        {
            // Estable del ancho del formulario en 800px
            Width = 800;
            // Establece el alto del formulario en 450px
            Height = 450;

            // If el formulario no está en modo diseño
            if (!DesignMode)
            {
                // Creo la sombra del formulario
                shadow = new Dropshadow(this)
                {
                    // Establezco la posición de la sombra verticalmente
                    ShadowV = 5,
                    // Establezco la posición de la sombra horizontalmente
                    ShadowH = 5,
                    // Establezco el desvanecido de la sombra
                    ShadowBlur = 10,
                    // Establezco el área de la sombra
                    ShadowSpread = -5,
                    // Establezco el color de la sombra
                    ShadowColor = Color.FromArgb(150, 0, 0, 0)
                };
                // Vuelve a cargar la sombra para que se cargue con las configuraciones previas
                shadow.RefreshShadow();
            }
        }

        /* -------------------- Arrastre del formulario -------------------------------- */
        int ex, ey;
        bool arrastre;

        // Función que se ejecuta cuando el botón es presionado 
        private void EditDelete_MouseDown(MouseEventArgs e)
        {
            // Guarda la posicion en x del mouse en donde se presionó
            ex = e.X;
            // Guarda la posicion en y del mouse en donde se presionó
            ey = e.Y;
            // Establece la variable de arrastre en verdadero
            arrastre = true;
        }

        // Función que se ejcuta cuando suelta el mouse
        private void EditDelete_MouseUp()
        {
            // Establece el arrastre en falso
            arrastre = false;
        }

        // Función que se ejecuta cuando el mouse se esta moviendo
        private void EditDelete_MouseMove()
        {
            // Sí el mouse está arrastrando algo
            if (arrastre)
            {
                /* 
                 * Encuentra y guarda en la variable 'p' la posicion de ese algo a la misma que la del mouse mientras 
                 * este se va moviendo
                 */
                Point p = new Point(MousePosition.X - this.Location.X - ex, MousePosition.Y - this.Location.Y - ey);
                // Cambia la posicion de ese algo a la misma que la del mouse mientras este se va moviendo
                this.Location = this.PointToScreen(p);
            }
        }

        // Ejecuta la función 'EditDelete_MouseDown' cuando el mouse se presiona dentro de la barra de menú
        private void menuBar_MouseDown(object sender, MouseEventArgs e)
        {
            EditDelete_MouseDown(e);
        }

        // Ejecuta la función 'EditDelete_MouseMove' cuando el mouse se esta moviendo por la barra de menú
        private void menuBar_MouseMove(object sender, MouseEventArgs e)
        {
            EditDelete_MouseMove();
        }

        // Ejecuta la función 'EditDelete_MouseUp' cuando suelta la barra del menú
        private void menuBar_MouseUp(object sender, MouseEventArgs e)
        {
            EditDelete_MouseUp();
        }

        // Ejecuta la función 'EditDelete_MouseDown' cuando el mouse se presiona dentro del nombre de la ventana
        private void lbl_window_title_MouseDown(object sender, MouseEventArgs e)
        {
            EditDelete_MouseDown(e);
        }

        // Ejecuta la función 'EditDelete_MouseMove' cuando el mouse se esta moviendo por el nombre de la ventana
        private void lbl_window_title_MouseMove(object sender, MouseEventArgs e)
        {
            EditDelete_MouseMove();
        }

        // Ejecuta la función 'EditDelete_MouseUp' cuando suelta el nombre de la ventana
        private void lbl_window_title_MouseUp(object sender, MouseEventArgs e)
        {
            EditDelete_MouseUp();
        }

        // Se ejecuta cuando se presióna el boton de cerrar
        private void btn_close_Click(object sender, EventArgs e)
        {
            // Termina la ejecución de la aplicación
            Environment.Exit(0);
        }

        // Se ejecuta cuando se presiona el botón minimzar
        private void btn_minimize_Click(object sender, EventArgs e)
        {
            // Minimiza el formulario
            this.WindowState = FormWindowState.Minimized;
        }

        // Se ejecuta cuando se presiona el botón de cancelar
        private void btn_cancel_Click(object sender, EventArgs e)
        {
            // Cierra el formulario actual
            this.Dispose();
        }

        // Se ejcuta cuando el mouse pasa por ensima del botón cancelar
        private void btn_cancel_MouseEnter(object sender, EventArgs e)
        {
            // Cambia el color del texto del botón al color del fondo
            btn_cancel.ForeColor = Color.FromArgb(17, 17, 17);
        }

        // Se ejecuta cuando el mouse sale del botón cancelar
        private void btn_cancel_MouseLeave(object sender, EventArgs e)
        {
            // Cambia el color del texto del botón a un amarillo
            btn_cancel.ForeColor = Color.FromArgb(255, 193, 7);
        }

        // Se ejecuta cuando el mouse pasa por ensima del botón guardar
        private void btn_save_MouseEnter(object sender, EventArgs e)
        {
            // Cambia el color del texto del botón al color del fondo
            btn_save.ForeColor = Color.FromArgb(17, 17, 17);
        }

        // Se ejecuta cuando el mouse sale del botón guardar
        private void btn_save_MouseLeave(object sender, EventArgs e)
        {
            // Cambia el color del texto del botón a un amarillo
            btn_save.ForeColor = Color.FromArgb(255, 193, 7);
        }

        // Se ejecuta cuando el mouse pasa por ensima del botón buscar
        private void btn_search_file_MouseEnter(object sender, EventArgs e)
        {
            // Cambia el color del texto del botón al color del fondo
            btn_search_file.ForeColor = Color.FromArgb(17, 17, 17);
        }

        // Se ejecuta cuando el mouse sale del botón buscar
        private void btn_search_file_MouseLeave(object sender, EventArgs e)
        {
            // Cambia el color del texto del botón a un amarillo
            btn_search_file.ForeColor = Color.FromArgb(255, 193, 7);
        }

        // Se ejecuta cuando el mouse pasa por ensima del botón borrar
        private void btn_delete_file_MouseEnter(object sender, EventArgs e)
        {
            // Cambia el color del texto del botón al color del fondo
            btn_delete_file.ForeColor = Color.FromArgb(17, 17, 17);
        }

        // Se ejecuta cuando el mouse sale del botón borrar
        private void btn_delete_file_MouseLeave(object sender, EventArgs e)
        {
            // Cambia el color del texto del botón a un amarillo
            btn_delete_file.ForeColor = Color.FromArgb(255, 193, 7);
        }

        // Se ejecuta cada que el texto del input precipitación cambia
        private void input_precipitation_TextChange(object sender, System.EventArgs e)
        {
            // Sí todos los inputs estan llenos
            if (input_precipitation.Text != "" && input_evaporation.Text != "" && input_maximum_temperature.Text != "" && input_minimum_temperature.Text != "")
            {
                // Activa el botón guardar
                btn_save.Enabled = true;
            }
            // Sí están vacíos
            else
            {
                // Desactiva el botón guardar
                btn_save.Enabled = false;
            }
        }

        // Se ejecuta cada que el texto del input evaporación cambia
        private void input_evaporation_TextChange(object sender, System.EventArgs e)
        {
            // Sí todos los inputs estan llenos
            if (input_precipitation.Text != "" && input_evaporation.Text != "" && input_maximum_temperature.Text != "" && input_minimum_temperature.Text != "")
            {
                // Activa el botón guardar
                btn_save.Enabled = true;
            }
            // Sí están vacíos
            else
            {
                // Desactiva el botón guardar
                btn_save.Enabled = false;
            }
        }

        // Se ejecuta cada que el texto del input temperatura máxima cambia
        private void input_maximum_temperature_TextChange(object sender, System.EventArgs e)
        {
            // Sí todos los inputs estan llenos
            if (input_precipitation.Text != "" && input_evaporation.Text != "" && input_maximum_temperature.Text != "" && input_minimum_temperature.Text != "")
            {
                // Activa el botón guardar
                btn_save.Enabled = true;
            }
            // Sí están vacíos
            else
            {
                // Desactiva el botón guardar
                btn_save.Enabled = false;
            }
        }

        // Se ejecuta cada que el texto del input temperatura mínima cambia
        private void input_minimum_temperature_TextChange(object sender, System.EventArgs e)
        {
            // Sí todos los inputs estan llenos
            if (input_precipitation.Text != "" && input_evaporation.Text != "" && input_maximum_temperature.Text != "" && input_minimum_temperature.Text != "")
            {
                // Activa el botón guardar
                btn_save.Enabled = true;
            }
            // Sí están vacíos
            else
            {
                // Desactiva el botón guardar
                btn_save.Enabled = false;
            }
        }

        // Se ejecuta cuando se presiona el botón buscar
        private void btn_search_file_Click(object sender, EventArgs e)
        {
            // Guardo el texto del input id que corresponde al iden la variable 'id'
            string id = input_id.Text;
            // Guardo el texto del input date que corresponde a la fecha en la variable 'date'
            string date = input_date.Text;

            // Creo un objeto de tipo StremaReader para poder leer el archivo de la ruta 'path'
            StreamReader reader = File.OpenText(path);
            // Leo todo el archivo hasta el final y el contenido de la ruta path lo guardo en la veriable contenido
            string contenido = reader.ReadToEnd();
            // Cierro el StreamReader
            reader.Close();

            // Cada línea del archivo que leí lo guardo como un item en el seguiente array
            string[] climas = contenido.Split('\n');

            bool encontradoId = false, encontradoDate = false;
            int pos = 0;

            // Busca por ID
            for (int i = 0; i < climas.Length; i += 8)
            {
                // Sí en la linea 'i' de la letra 0 a la 2 es igual a 'ID'
                if (climas[i].Trim().Substring(0, 2).Equals("ID"))
                {
                    // Sí en la linea 'i', a partir de la letra 15 en adelante, es igual al contenido de la variable 'id'
                    if (climas[i].Trim().Substring(15).Equals(id))
                    {
                        // Establece que se encontró el id que se busca
                        encontradoId = true;
                        // Guarda la posición
                        pos = i;
                        // Termina el ciclo
                        break;
                    }
                    // Sí no
                    else
                    {
                        // Establece que no se encontró el id que busca
                        encontradoId = false;
                    }
                }
            }

            // Busca por Date
            for (int i = 1; i < climas.Length; i += 8)
            {
                // Sí en la línea 'i', a partir de la letra 0 a la 4, es igual a la pabra 'DATE'
                if (climas[i].Trim().Substring(0, 4).Equals("DATE"))
                {
                    // Sí en la línea 'i', a partir de la letra 15 eb adelante, es igual al contenido de la variable date
                    if (climas[i].Trim().Substring(15).Equals(date))
                    {
                        // Establece que se encontró la fecha que se busca
                        encontradoDate = true;
                        // Guarda la posición
                        pos = i;
                        // Termina el ciclo
                        break;
                    }
                    // sí no
                    else
                    {
                        // Establece que no se encontró la fecha que busca
                        encontradoDate = false;
                    }
                }
            }


            // Sí encontro el clima por id o por fecha
            if (encontradoId || encontradoDate)
            {
                /* 
                 * La siguiente comprobación es para establecer la posición en la lína del status 
                 * para comprobar que esté activo y de esta forma poder editarlo o borrarlo
                 */

                // Sí lo encontró por id
                if (encontradoId)
                {
                    // A la posicón se le suma 6
                    pos += 6;
                }
                // Sí lo encontró por fecha
                else if (encontradoDate)
                {
                    // A la posición se le suma 5
                    pos += 5;
                }

                // Sí el clima que busca está activo
                if (climas[pos].Trim().Substring(15) != "0")
                {
                    /*
                     * La siguiente línea es para regresar a la línea inicial, 
                     * dependiendo si se encontró por id o por fecha.
                     */

                    pos -= 4;

                    /* ---------------------- Deshabilita la sección de buscar ------------------------------ */

                    // Establece el color del label id a un color gris para parecer desabilitado
                    lbl_id.ForeColor = Color.FromArgb(66, 66, 66);
                    // Deshabilita el input id
                    input_id.Enabled = false;
                    // Establece el color del label Fecha a un color gris para parecer desabilitado
                    lbl_date.ForeColor = Color.FromArgb(66, 66, 66);
                    // Deshabilita el input fecha
                    input_date.Enabled = false;
                    // Deshabilita el botón de buscar
                    btn_search_file.Enabled = false;



                    /* ---------------------- Habilita la sección de editar --------------------------------- */

                    // Habilita el input precipitación
                    input_precipitation.Enabled = true;
                    // Pone como placeholder el valor de la precipitación actual
                    input_precipitation.PlaceholderText = climas[pos].Trim().Substring(15);
                    // Cambia el color del label Precipitación a color blanco para parecer habilitado
                    lbl_precipitation.ForeColor = Color.White;

                    // Aumenta en 1 la posicón para saltar a la siguiente línea
                    pos++;

                    // Habilita el input evaporación
                    input_evaporation.Enabled = true;
                    // Pone como placeholder el valor de la evaporación actual
                    input_evaporation.PlaceholderText = climas[pos].Trim().Substring(15);
                    // Cambia el color del label Evaporación a color blanco para parecer habilitado
                    lbl_evaporation.ForeColor = Color.White;

                    // Aumenta en 1 la posicón para saltar a la siguiente línea
                    pos++;

                    // Habilita el input temperatura máxima
                    input_maximum_temperature.Enabled = true;
                    // Pone como placeholder el valor de la temperatura máxima actual
                    input_maximum_temperature.PlaceholderText = climas[pos].Trim().Substring(15);
                    // Cambia el color del label Temperatura máxima a color blanco para parecer habilitado
                    lbl_maximum_temperature.ForeColor = Color.White;

                    // Aumenta en 1 la posicón para saltar a la siguiente línea
                    pos++;

                    // Habilita el input temperatura mínima
                    input_minimum_temperature.Enabled = true;
                    // Pone como placeholder el valor de la temperatura mínima actual
                    input_minimum_temperature.PlaceholderText = climas[pos].Trim().Substring(15);
                    // Cambia el color del label Temperatura mínima a color blanco para parecer habilitado
                    lbl_minimum_temperature.ForeColor = Color.White;

                    // Hábilita el botón de borrar
                    btn_delete_file.Enabled = true;

                    // Muestra una notificación para que el usuario sepa que pasó
                    lbl_notifications.Text = "¡Archivo encontrado correctamente!";
                }
                // Sí el clima que busca no está activo
                else
                {
                    // Muestra el siguiente mensaje en una ventana nueva
                    lbl_notifications.Text = "El archivo que buscas ha sido eliminado.";
                }
            }
            // Si no encontró el clima ni por id, ni por fecha
            else
            {
                // Muestra el siguiente mensaje en una ventana nueva
                lbl_notifications.Text = "¡Archivo no encontrado!";
            }
        }

        // Evento que se ejecuta cada que el estado (habilitado o deshabilitado) del botón guardar cambia
        private void btn_save_EnabledChanged(object sender, System.EventArgs e)
        {
            // Sí el botón está deshabilitado
            if (!btn_save.Enabled)
            {
                // Cambia el color del borde del botón a un gris para parecer dehabilitado
                btn_save.FlatAppearance.BorderColor = Color.FromArgb(66, 66, 66);
                // Cambia el color del texto del botón para parecer deshabilitado
                btn_save.ForeColor = Color.FromArgb(66, 66, 66);
            }
            // Sí el boton está habilitado
            else
            {
                // Cambia el color del borde del botón a un amarillo para parecer habilitado
                btn_save.FlatAppearance.BorderColor = Color.FromArgb(255, 193, 7);
                // Cambia el color del texto del botón para parecer habilitado
                btn_save.ForeColor = Color.FromArgb(255, 193, 7);
            }
        }

        private StreamWriter writer;
        private StreamReader reader;

        // Se ejcuta cuando el botón de borrar es presionado
        private void btn_delete_file_Click(object sender, EventArgs e)
        {
            // Guardo el texto del input id que corresponde al iden la variable 'id'
            string id = input_id.Text;
            // Guardo el texto del input date que corresponde a la fecha en la variable 'date'
            string date = input_date.Text;

            // Creo un objeto de tipo StremaReader para poder leer el archivo de la ruta 'path'
            reader = File.OpenText(path);
            // Leo todo el archivo hasta el final y el contenido de la ruta path lo guardo en la veriable contenido
            string contenido = reader.ReadToEnd();
            // Cierro el StreamReader
            reader.Close();

            // Cada línea del archivo que leí lo guardo como un item en el seguiente array
            string[] datos = contenido.Split('\n');

            bool encontradoId = false, encontradoDate = false;
            int pos = 0;

            // Busca por ID
            for (int i = 0; i < datos.Length; i += 8)
            {
                // Sí en la linea 'i' de la letra 0 a la 2 es igual a 'ID'
                if (datos[i].Trim().Substring(0, 2).Equals("ID"))
                {
                    // Sí en la linea 'i', a partir de la letra 15 en adelante, es igual al contenido de la variable 'id'
                    if (datos[i].Trim().Substring(15).Equals(id))
                    {
                        // Establece que se encontró el id que se busca
                        encontradoId = true;
                        // Guarda la posición
                        pos = i;
                        // Termina el ciclo
                        break;
                    }
                    // Sí no
                    else
                    {
                        // Establece que no se encontró el id que busca
                        encontradoId = false;
                    }
                }
            }

            // Busca por Date
            for (int i = 1; i < datos.Length; i += 8)
            {
                // Sí en la línea 'i', a partir de la letra 0 a la 4, es igual a la pabra 'DATE'
                if (datos[i].Trim().Substring(0, 4).Equals("DATE"))
                {
                    // Sí en la línea 'i', a partir de la letra 15 eb adelante, es igual al contenido de la variable date
                    if (datos[i].Trim().Substring(15).Equals(date))
                    {
                        // Establece que se encontró la fecha que se busca
                        encontradoDate = true;
                        // Guarda la posición
                        pos = i;
                        // Termina el ciclo
                        break;
                    }
                    // sí no
                    else
                    {
                        // Establece que no se encontró la fecha que busca
                        encontradoDate = false;
                    }
                }
            }

            // Sí encontro el clima por id o por fecha
            if (encontradoId || encontradoDate)
            {
                /* 
                 * La siguiente comprobación es para establecer la posición en la lína del status 
                 * para establecer que esté desactivado o borrado y de esta forma no poder acceder a él para nada
                 */

                // Sí lo encontró por id
                if (encontradoId)
                {
                    // A la posicón se le suma 6
                    pos += 6;
                }
                // Sí lo encontró por fecha
                else if (encontradoDate)
                {
                    // A la posición se le suma 5
                    pos += 5;
                }

                // Establece el estado del clima a desactivado o borrado
                datos[pos] = "STATUS:        0";

                // Creo un objeto de tipo StremaWriter para poder escribir en el archivo de la ruta 'path'
                writer = new StreamWriter(path);
                // Vacío todo el archivo (lo dejo en blanco para poder escribir de nuevo en él)
                writer.Flush();

                // Escribo línea por línea lo que tengo en mi array datos, incluyendo la nueva línea que modifiqué
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

                // Cierro el StreamWriter
                writer.Close();

                /* ------------------- Compruebo si se escribieron los datos correctamente ----------------- */

                // Vuelvo a leer el arhivo
                reader = File.OpenText(path);
                contenido = reader.ReadToEnd();
                // Cierro el StreamReader
                reader.Close();

                // Limpio mi array datos
                Array.Clear(datos, 0, datos.Length);
                // Vuelvo a escrbir en el los datos separados por saltos de linea
                datos = contenido.Split('\n');

                // Compruebo si en la lína que modifiqué se encuentra el valor que había puesto
                if (datos[pos].Trim().Substring(15) == "0")
                {
                    // De ser así, muestro la siguiente notificación
                    lbl_notifications.Text = "El archivo fue eliminado correctamente.";
                }
                else
                {
                    // En caso de que no, muestro esta otra
                    lbl_notifications.Text = "El archivo no pudo ser eliminado.";
                }
            }

            //Habilitamos la sección búsqueda
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

        // Evento que se ejecuta cuando el estado del botón buscar cambia
        private void btn_search_file_EnabledChanged(object sender, System.EventArgs e)
        {
            // Sí el boton buscar está deshabilitado
            if (!btn_search_file.Enabled)
            {
                // Cambia el color del borde del botón a un gris para parecer dehabilitado
                btn_search_file.FlatAppearance.BorderColor = Color.FromArgb(66, 66, 66);
                // Cambia el color del texto del botón para parecer deshabilitado
                btn_search_file.ForeColor = Color.FromArgb(66, 66, 66);
            }
            // Sí el botón está habilitado
            else
            {
                // Cambia el color del borde del botón a un amarillo para parecer habilitado
                btn_search_file.FlatAppearance.BorderColor = Color.FromArgb(255, 193, 7);
                // Cambia el color del texto del botón para parecer habilitado
                btn_search_file.ForeColor = Color.FromArgb(255, 193, 7);
            }
        }

        // Evento que se ejecuta cuando el boton de guardar es presionado
        private void btn_save_Click(object sender, EventArgs e)
        {
            // Sí todos los inputs de la sección editar estan llenos
            if (input_precipitation.Text.Trim() != "" && input_evaporation.Text.Trim() != "" && input_maximum_temperature.Text.Trim() != "" && input_minimum_temperature.Text.Trim() != "")
            {
                // Guardo los contenidos de los inputs id y fecha para utilizarlos después.
                string id = input_id.Text,
                       date = input_date.Text;

                // Creo un arreglo con los datos de los inputs para después escribir esa información
                string[] newData = { input_precipitation.Text.Trim(), input_evaporation.Text.Trim(), input_maximum_temperature.Text.Trim(), input_minimum_temperature.Text.Trim() };

                bool encontradoId = false, encontradoDate = false;
                int pos = 0;

                // Leo mi archivo de texto
                StreamReader reader = File.OpenText(path);
                string contenido = reader.ReadToEnd();
                reader.Close();

                // Guardo los datos separados por saltos de linea en un array
                string[] datos = contenido.Split('\n');

                // Busca por ID
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

                // Busca por Fecha
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

                // Verifica por cuál de los dos métodos (id o fecha) fué encontrado
                if (encontradoId)
                {
                    // Si es por id, suma 2 a la posición
                    pos += 2;
                }
                else if (encontradoDate)
                {
                    // Si fue por fecha, suma 1 a la posicón
                    pos += 1;
                }

                // Reescribe las lineas correspondientes con los datos correspondientes.
                datos[pos] = "PRECIPITACION: " + newData[0];
                pos++;
                datos[pos] = "EVAPORACION:   " + newData[1];
                pos++;
                datos[pos] = "TEMP-MA:       " + newData[2];
                pos++;
                datos[pos] = "TEMP-MI:       " + newData[3];

                // Cierra cualquier otro writer antes de crear otro
                writer.Close();

                // Creo un nuevo writer en la ruta 'path'
                writer = new StreamWriter(path);
                // Limpio el archivo de la ruta
                writer.Flush();
                //Ecribo línea por línea del array con la nueva información
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
                // Cierro mi writer
                writer.Close();


                /* -------------------- Comprobamos si se editó correctamente el archivo ---------------------- */

                // Creo un nuevo reader en la ruta 'path'
                StreamReader r = File.OpenText(path);
                contenido = r.ReadToEnd();
                reader.Close();

                // Limpio mi array para poner los nuevos datos
                Array.Clear(datos, 0, datos.Length);
                // Guardo los datos del reader
                datos = contenido.Split('\n');

                // La posición la regreso tres valores para posicionarme de nuevo en precipitación
                pos -= 3;

                // Compruebo si cada una de las líneas fue editada correctamente
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
                                // Si no se edito correctamente manda estos mensajes
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

        // Evento que se ejecuta cuando el estado del botón buscar cambia
        private void btn_delete_file_EnabledChanged(object sender, System.EventArgs e)
        {
            // Sí está deshabilitado
            if (!btn_delete_file.Enabled)
            {
                // Cambia el color del borde a uno gris para parecer deshabilitado
                btn_delete_file.FlatAppearance.BorderColor = Color.FromArgb(66, 66, 66);
                // Cambia el color del texto del boton a un gris para paracer deshabilitado
                btn_delete_file.ForeColor = Color.FromArgb(66, 66, 66);
            }
            // Sí está habilitado
            else
            {
                // Cambia el colo del borde a un color amarillo para parecer habilitado
                btn_delete_file.FlatAppearance.BorderColor = Color.FromArgb(255, 193, 7);
                // Cambia el color del texto del botón a un amarillo para parecer habilitado
                btn_delete_file.ForeColor = Color.FromArgb(255, 193, 7);
            }
        }

    }
}