using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace contruccion_de_interfaces
{
    public partial class SignUp : Form
    {
        private Dropshadow shadow;
        // Ruta donde se encuentra o donde se encontrará el archivo de la base de datos
        private string path = @"C:\Users\jocel\source\repos\Construccion-de-interfaces\contruccion de interfaces\Data\users.txt";
        private bool passOk = false, userOk = false;

        private int id = 0;

        // Función que inicializa el formulario por defecto
        public SignUp()
        {
            InitializeComponent();

            // Sí el botón registrarse está desactivado
            if (!btn_sign_up.Enabled)
            {
                // Color del borde del botón a un gris más claro que el del fondo para parcer deshabilitado
                btn_sign_up.FlatAppearance.BorderColor = Color.FromArgb(66, 66, 66);
                // Color del texto del botón a un gris más claro que el del fondo para parcer deshabilitado
                btn_sign_up.ForeColor = Color.FromArgb(66, 66, 66);
            }
        }

        // Se ejecuta al terminar de cargar el formulario
        private void signUp_Load(object sender, EventArgs e)
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

            // Quita el foco de los inputs y lo pone en el botón
            this.ActiveControl = btn_sign_up;

            // Sí existe el archivo de la ruta 'path'
            if (File.Exists(path))
            {
                // Creo un StreamReader para poder leer el contenido del archivo
                StreamReader reader = File.OpenText(path);
                // Guardo el contenido del archi en la variable contenido;
                string contenido = reader.ReadToEnd();
                // Cierro el reader por seguridad de los datos
                reader.Close();

                // Separo cada salto de linea como item en el siguiente array
                string[] users = contenido.Split('\n');

                // Obntengo el último id
                for (int i = 0; i < users.Length - 3; i += 5)
                {
                    id = int.Parse(users[i].Trim().Substring(10));
                }

                // Sumo 1 al ultimo id, para el nuevo usuario
                id++;
            }
            // Sí no existe el archivo
            else
            {
                // Sumo 1 al id que por defecto estaba en 0 pues aún no existen usuarios
                id++;
            }
        }

        /* -------------------- Arrastre del formulario -------------------------------- */
        int ex, ey;
        bool arrastre;

        // Función que se ejecuta cuando el botón es presionado 
        private void signUp_MouseDown(MouseEventArgs e)
        {
            // Guarda la posicion en x del mouse en donde se presionó
            ex = e.X;
            // Guarda la posicion en y del mouse en donde se presionó
            ey = e.Y;
            // Establece la variable de arrastre en verdadero
            arrastre = true;
        }

        // Función que se ejcuta cuando suelta el mouse
        private void signUp_MouseUp()
        {
            // Establece el arrastre en falso
            arrastre = false;
        }

        // Función que se ejecuta cuando el mouse se esta moviendo
        private void signUp_MouseMove()
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
            signUp_MouseDown(e);
        }

        // Ejecuta la función 'EditDelete_MouseMove' cuando el mouse se esta moviendo por la barra de menú
        private void menuBar_MouseMove(object sender, MouseEventArgs e)
        {
            signUp_MouseMove();
        }

        // Ejecuta la función 'EditDelete_MouseUp' cuando el mouse se esta moviendo por la barra de menú
        private void menuBar_MouseUp(object sender, MouseEventArgs e)
        {
            signUp_MouseUp();
        }

        // Ejecuta la función 'EditDelete_MouseDown' cuando el mouse se esta moviendo por el título de la ventana
        private void lbl_window_title_MouseDown(object sender, MouseEventArgs e)
        {
            signUp_MouseDown(e);
        }

        // Ejecuta la función 'EditDelete_MouseMove' cuando el mouse se esta moviendo por el título de la ventana
        private void lbl_window_title_MouseMove(object sender, MouseEventArgs e)
        {
            signUp_MouseMove();
        }

        // Ejecuta la función 'EditDelete_MouseUp' cuando el mouse se esta moviendo por el título de la ventana
        private void lbl_window_title_MouseUp(object sender, MouseEventArgs e)
        {
            signUp_MouseUp();
        }

        // Se ejecuta cuando presionan el botón de cerrar
        private void btn_close_Click(object sender, EventArgs e)
        {
            // Cierra la aplicación
            Environment.Exit(0);
        }

        // Se ejecuta cuando se presiona el botón de minimizar
        private void btn_minimize_Click(object sender, EventArgs e)
        {
            // Minimiza el formulario activo
            this.WindowState = FormWindowState.Minimized;
        }

        // Se ejecuta cuando se presiona el link de iniciar sesión
        private void lnk_lbl_login_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Cierra el formulario actual
            this.Dispose();
        }

        // Se ejecuta cuando presionas el botón de registrarse
        private void btn_sign_up_Click(object sender, EventArgs e)
        {
            // Variables donde se almacenan los datos de cada uno de los inputs en el formulario
            string username = input_username.Text, pass = input_pass.Text, confirm_pass = input_confirm_pass.Text, status = "1", symbolsPass = " !\"#$%&'()*+,-./:;<=>?@[\\]^_`{|}~", uppercase = "ABCDEFGHYJKLMNÑOPQRSTUVWXYZ", lowercase = "abcdefghijklmnñopqrstuvwxyz", numbers = "0123456789";
            // variables que se utilizarán para la validación del formulario
            bool existUsername = false, cSymbols = false, cUppercase = false, cLowercase = false, cNumbers = false;

            // Creo un objeto de mi clase Alert
            Alert alert;

            // Sí los comapos están llenos
            if (username != "" && pass != "" && confirm_pass != "")
            {
                // Sí el archivo de la ruta 'path' existe
                if (File.Exists(path))
                {
                    // Creo un reader para leer el archivo
                    StreamReader reader = File.OpenText(path);
                    // Guarda el contenido en la varibable contenido
                    string contenido = reader.ReadToEnd();
                    // Cierro el reader
                    reader.Close();

                    // Se paro el contenido por líneas
                    string[] users = contenido.Split('\n');

                    // Ciclo para recorrer cada uno de los usernames del archivo usuarios
                    for (int i = 1; i < users.Length; i += 5)
                    {
                        // Sí el nombre de usuario en la posición 'i' es igual al que el usuario escribió
                        if (users[i].Trim().Substring(10).Equals(username))
                        {
                            // Establece que existe el usuario
                            existUsername = true;
                            // Termina el ciclo
                            break;
                        }
                        // Sí el username en la posición 'i' no es igual al que el usuario escribió
                        else
                        {
                            // Establece que no encontró ningun usuario
                            existUsername = false;
                        }
                    }
                }
                // Sí no existe el archivo en la ruta 'path'
                else
                {
                    // Establece que no hay ningun usuario
                    existUsername = false;
                }

                // Sí no existe el nombre de usuario que el usuario escribió
                if (!existUsername)
                {
                    // Sí la contraseña tiene 8 o más caracteres
                    if (pass.Length >= 8)
                    {
                        // Ciclo para recorrer cada uno de los caracteres de la contraseña
                        for (int i = 0; i < pass.Length; i++)
                        {
                            // Ciclo para recorrer los symbolos que puede usar el usuario para su contraseña
                            for (int o = 0; o < symbolsPass.Length; o++)
                            {
                                // Si la contraseña contiene algún símbolo
                                if (pass[i].ToString().Contains(symbolsPass[o]))
                                {
                                    // Establece que si contiene símbolos
                                    cSymbols = true;
                                    // Termina el ciclo
                                    break;
                                }
                            }
                        }

                        // Ciclo para recorrer cada uno de los caracteres de la contraseña
                        for (int i = 0; i < pass.Length; i++)
                        {
                            // Ciclo para recorrer cada una de las letras en mayúscula
                            for (int o = 0; o < uppercase.Length; o++)
                            {
                                // Sí la contraseña contiene una mayúscula
                                if (pass[i].ToString().Contains(uppercase[o]))
                                {
                                    // Establece que contiene una mayúscula
                                    cUppercase = true;
                                    // Termina el ciclo
                                    break;
                                }
                            }
                        }

                        // Ciclo para recorrer cada uno de los caracteres de la contraseña
                        for (int i = 0; i < pass.Length; i++)
                        {
                            // Ciclo para recorrer cada uno de las letras minúsculas
                            for (int o = 0; o < lowercase.Length; o++)
                            {
                                // Sí la contraseña contiene una minúscula
                                if (pass[i].ToString().Contains(lowercase[o]))
                                {
                                    // Establece que contiene una minúscula
                                    cLowercase = true;
                                    // Termina el ciclo
                                    break;
                                }
                            }
                        }

                        // Ciclo para recorrer cada uno de los caracteres de la contraseña
                        for (int i = 0; i < pass.Length; i++)
                        {
                            // Ciclo para recorrer cada uno de los números
                            for (int o = 0; o < numbers.Length; o++)
                            {
                                // Sí la contraseña contiene un número
                                if (pass[i].ToString().Contains(numbers[o]))
                                {
                                    // Establece que la contraseña contiene un número
                                    cNumbers = true;
                                    // Termina el ciclo
                                    break;
                                }
                            }
                        }

                        // Sí la contraseña contiene almenos un símbolo
                        if (cSymbols)
                        {
                            // Sí la contraseña contiene al menos una mayúscula
                            if (cUppercase)
                            {
                                // Sí la contraseña contiene al menos una mínuscula
                                if (cLowercase)
                                {
                                    // Sí la contraseña contiene al menos un número
                                    if (cNumbers)
                                    {
                                        // Sí la contraseña es igual a la que confirmó
                                        if (pass == confirm_pass)
                                        {

                                            // Creo un array con los datos de un nuevo usuario
                                            string[] user = { "ID:       " + id.ToString(),
                                                          "USERNAME: " + username,
                                                          "PASSWORD: " + pass,
                                                          "STATUS:   " + status,
                                                          "--------------------------------------------"};

                                            // Sí el archivo en la ruta 'path' existe
                                            if (File.Exists(path))
                                            {
                                                // Creo un reader para leer el archivo en la ruta 'path'
                                                StreamReader reader = File.OpenText(path);
                                                // Guardo el contenido del archivo en la variable contenido
                                                string contenido = reader.ReadToEnd();
                                                // Cierro el reader
                                                reader.Close();

                                                // Agrego el nuevo usuario los datos del archivo
                                                for (int o = 0; o < user.Length; o++)
                                                {
                                                    contenido += "\n" + user[o];
                                                }

                                                // Separo los datos del contenido línea por línea
                                                string[] users = contenido.Split('\n');

                                                // Creo un writer para escribir los nuevos datos al nuevo archivo
                                                StreamWriter writer = new StreamWriter(path);
                                                // Ciclo para escribir los datos con el nuevo usuario
                                                for (int i = 0; i < users.Length; i++)
                                                {
                                                    // Compruebo si 'i' esta en la penultima posicon del array users para no agregar 
                                                    // el último espacio.
                                                    if (i == users.Length - 1)
                                                    {
                                                        writer.Write(users[i].Trim());
                                                    }
                                                    else
                                                    {
                                                        writer.Write(users[i].Trim() + "\n");
                                                    }
                                                }
                                                // Cierro el writer
                                                writer.Close();
                                            }
                                            // Sí no existe el archivo
                                            else
                                            {
                                                // Creo el archivo y lo lleno con el primer usuario
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

                                            // Cierro el formulario una vez registrado el usuario para que pueda iniciar sesión
                                            this.Dispose();
                                        }
                                        // Sí las contraseñas no coinciden
                                        else
                                        {
                                            // Establece que hay un problema con las contraseñas
                                            passOk = false;
                                            // Colorea el label y los bordes de los inputs afectados de color rojo para resaltar el error
                                            input_pass.ForeColor = Color.FromArgb(255, 0, 0);
                                            input_confirm_pass.ForeColor = Color.FromArgb(255, 0, 0);
                                            lbl_pass.ForeColor = Color.FromArgb(255, 0, 0);
                                            lbl_confirm_pass.ForeColor = Color.FromArgb(255, 0, 0);
                                            // Envía el mensaje del error
                                            alert = new Alert("Las contraseñas deben ser iguales.", "Error en las contraseñas");
                                            alert.ShowDialog();
                                        }
                                    }
                                    // Sí la contraseña no tiene un número
                                    else
                                    {
                                        // Establece que hay un problema con la contraseña
                                        passOk = false;
                                        // Colorea el label y los bordes de los inputs afectados de color rojo para resaltar el error
                                        input_pass.ForeColor = Color.FromArgb(255, 0, 0);
                                        lbl_pass.ForeColor = Color.FromArgb(255, 0, 0);
                                        // Envía el mensaje del error
                                        alert = new Alert("La contraseña debe contener almenos 1 número.", "Contraseña no segura");
                                        alert.ShowDialog();
                                    }
                                }
                                // Sí la contraseña no tiene una minúscula
                                else
                                {
                                    // Establece que hay un problema con la contraseña
                                    passOk = false;
                                    // Colorea el label y los bordes de los inputs afectados de color rojo para resaltar el error
                                    input_pass.ForeColor = Color.FromArgb(255, 0, 0);
                                    lbl_pass.ForeColor = Color.FromArgb(255, 0, 0);
                                    // Envía el mensaje del error
                                    alert = new Alert("La contraseña debe contener 1 letra minúscula.", "Contraseña no segura");
                                    alert.ShowDialog();
                                }
                            }
                            // Sí la contraseña no contiene una mayúscula
                            else
                            {
                                // Establece que hay un problema con la contraseña
                                passOk = false;
                                // Colorea el label y los bordes de los inputs afectados de color rojo para resaltar el error
                                input_pass.ForeColor = Color.FromArgb(255, 0, 0);
                                lbl_pass.ForeColor = Color.FromArgb(255, 0, 0);
                                // Envía el mensaje del error
                                alert = new Alert("La contraseña debe de contener 1 letra mayúscula.", "Contraseña no segura");
                                alert.ShowDialog();
                            }
                        }
                        // Sí la contraseña no contiene un símbolo
                        else
                        {
                            // Establece que hay un problema con la contraseña
                            passOk = false;
                            // Colorea el label y los bordes de los inputs afectados de color rojo para resaltar el error
                            input_pass.ForeColor = Color.FromArgb(255, 0, 0);
                            lbl_pass.ForeColor = Color.FromArgb(255, 0, 0);
                            // Envía el mensaje del error
                            alert = new Alert("La contraseña debe contener almenos un símbolo.", "Contraseña no segura");
                            alert.ShowDialog();
                        }
                    }
                    // Sí la contraseña no es igual a 8 o más caracteres
                    else
                    {
                        // Establece que hay un problema con la contraseña
                        passOk = false;
                        // Colorea el label y los bordes de los inputs afectados de color rojo para resaltar el error
                        input_pass.ForeColor = Color.FromArgb(255, 0, 0);
                        lbl_pass.ForeColor = Color.FromArgb(255, 0, 0);
                        // Envía el mensaje del error
                        alert = new Alert("La contraseña debe tener mínimo 8 caracteres.", "Contraseña no segura");
                        alert.ShowDialog();
                    }
                }
                // Sí el nombre de usuario ya existe
                else
                {
                    // Establece que hay un problema con el nombre de usuario
                    userOk = false;
                    // Colorea el label y los bordes de los inputs afectados de color rojo para resaltar el error
                    input_username.ForeColor = Color.FromArgb(255, 0, 0);
                    lbl_username.ForeColor = Color.FromArgb(255, 0, 0);
                    // Envía el mensaje del error
                    alert = new Alert("El usuario ya existe, elige otro.", "Usuario existente");
                    alert.ShowDialog();
                }
            }
        }

        // Se ejecuta cunado el mouse hace pasa por ensima de el botón de regisrarse
        private void btn_sign_up_MouseEnter(object sender, System.EventArgs e)
        {
            // cambia el color de texto del botón al del fondo
            btn_sign_up.ForeColor = Color.FromArgb(17, 17, 17);
        }

        // Se ejecuta cuando el mouse sale de el botón iniciar sesión
        private void btn_sign_up_MouseLeave(object sender, System.EventArgs e)
        {
            // Cambia el color del texto del botón a amarillo
            btn_sign_up.ForeColor = Color.FromArgb(255, 193, 7);
        }

        // Se ejecuta cada que el texto del input username cambia 
        private void input_username_TextChange(object sender, System.EventArgs e)
        {
            // Sí están llenos todos los campos
            if (input_username.Text != "" && input_pass.Text != "" && input_confirm_pass.Text != "")
            {
                // activa el botón registrarse
                btn_sign_up.Enabled = true;
            }
            // Si no estan llenos los campos
            else
            {
                // El botón se desactiva
                btn_sign_up.Enabled = false;
            }
        }

        // Se ejecuta cada vez que el input username gana el focus
        private void input_username_GotFocus(object sender, System.EventArgs e)
        {
            // Sí hay un problema con el usuario
            if (!userOk)
            {
                // Establece que ya no hay problemas con el usuario
                passOk = true;
                // Cambia los colores del texto del label y del borde del input para que el usuario vea que ya no hay problemas
                input_username.ForeColor = Color.White;
                lbl_username.ForeColor = Color.White;
            }
        }

        // Se ejecuta cada que el texto del input pass cambia
        private void input_pass_TextChange(object sender, System.EventArgs e)
        {
            // Sí todos los campos están llenos
            if (input_username.Text != "" && input_pass.Text != "" && input_confirm_pass.Text != "")
            {
                // El boton registrarse se activa
                btn_sign_up.Enabled = true;
            }
            // Si todos los campos no estan llenos
            else
            {
                // El botón registrarse se desactiva
                btn_sign_up.Enabled = false;
            }
        }

        // Se ejecuta cuando el input pass gana el foco
        private void input_pass_GotFocus(object sender, System.EventArgs e)
        {
            // Sí hay algún problema con la contraseña
            if (!passOk)
            {
                // Establece que no hay ningun problema con la contraseña
                passOk = true;
                // Cambia los colores de los bordes de los inputs y sus labels al de por defecto para que el usuario vea que 
                // ya no hay problemas con la contrseña
                input_pass.ForeColor = Color.White;
                input_confirm_pass.ForeColor = Color.White;
                lbl_pass.ForeColor = Color.White;
                lbl_confirm_pass.ForeColor = Color.White;
            }
        }
        
        // Se ejecuta cada que el texto del input confirmar contraseña cambia
        private void input_confirm_pass_TextChange(object sender, System.EventArgs e)
        {
            // Sí todos los campos están llenos
            if (input_username.Text != "" && input_pass.Text != "" && input_confirm_pass.Text != "")
            {
                // Se activa el botón de registrarse
                btn_sign_up.Enabled = true;
            }
            // Sí no todos los campos estan llenos
            else
            {
                // EL botón de registrarse se desactiva
                btn_sign_up.Enabled = false;
            }
        }

        // Se ejecuta cada que input confirm pass gana el focus
        private void input_confirm_pass_GotFocus(object sender, System.EventArgs e)
        {
            // Si hay algún problema con la contraseña
           if (!passOk)
            {
                // Establece que no hay ningún problema con la contraseña
                passOk = true;
                // Cambia los colores de los bordes de los inputs y sus labels al de por defecto para que el usuario vea que 
                // ya no hay problemas con la contrseña
                input_pass.ForeColor = Color.White;
                input_confirm_pass.ForeColor = Color.White;
                lbl_pass.ForeColor = Color.White;
                lbl_confirm_pass.ForeColor = Color.White;
            }
        }

        // Se ejecuta cada que el estado del botón registrarse cabia para verse habilitado o deshabilitado 
        // según el estado en el que se encuentre.
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
