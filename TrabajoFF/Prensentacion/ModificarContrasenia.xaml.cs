using Entidades;
using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Prensentacion
{
    /// <summary>
    /// Lógica de interacción para ModificarContrasenia.xaml
    /// </summary>
    public partial class ModificarContrasenia : Window
    {
        nDatos datosn;
        public ModificarContrasenia()
        {
            datosn = new nDatos();
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            if (txtContrasenia.Text.Length >= 4 && txtContrasenia.Text.Length <= 20)
            {
                if (txtContrasenia.Text.Contains(" "))
                    MessageBox.Show("Contraseña incorrecta");
                else
                {
                    datosn.CambiarContrasenia(txtContrasenia.Text, txtContraseniaAntigua.Text);
                    MessageBox.Show("Contraseña actualizada");
                }

            }
            else MessageBox.Show("Contraseña incorrecta");
        }
    }
}
