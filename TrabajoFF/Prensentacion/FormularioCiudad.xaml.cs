using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Entidades;
using Negocio;
using System.Text.RegularExpressions;
namespace Prensentacion
{
    /// <summary>
    /// Lógica de interacción para FormularioCiudad.xaml
    /// </summary>
    public partial class FormularioCiudad : Window
    {
        nDatos datosn;
        public FormularioCiudad()
        {
            datosn = new nDatos();
            InitializeComponent();
            Mostrar();
        }
        private void Mostrar()
        {


            DgCiudad.ItemsSource = datosn.ListarCiudad();
           

        }
        private void btnciudad_Clicks(object sender, RoutedEventArgs e)
        {

        }

        private void btnciudad_Click_1(object sender, RoutedEventArgs e)
        {
            eCiudad ciud = new eCiudad();
            ciud.Ciudad = txtNombreciudad.Text;


            string patron = "^[a-zA-Z ]+$";
            Regex regex = new Regex(patron);


            if (ciud.Ciudad.Length >= 3 && ciud.Ciudad.Length <= 20 && regex.IsMatch(ciud.Ciudad))
            {
                ciud.Precio = Convert.ToDecimal(txtprecio.Text);
                if (ciud.Precio > 0 && ciud.Precio <= 100000)
                {
                    datosn.RegistrarCiudad(ciud);
                    MessageBox.Show("Ciudad registrada");
                    Mostrar();
                }
                else MessageBox.Show("Monto incorrecto");
            } else MessageBox.Show("Nombre incorrecto");
        }

        private void txtNombreciudad_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void DgCiudad_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void DgCiudad_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
