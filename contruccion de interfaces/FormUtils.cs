using System.Windows.Forms;

namespace contruccion_de_interfaces
{
    class FormUtils
    {
        public static bool findOpenForm(string nameForm)
        {
            bool open = false;

            if (Application.OpenForms[nameForm] != null)
            {
                open = true;
            }

            return open;
        }
    }
}
