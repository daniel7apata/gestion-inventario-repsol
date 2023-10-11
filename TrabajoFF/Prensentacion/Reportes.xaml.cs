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
using Entidades;
using Negocio;
namespace Prensentacion
{
    /// <summary>
    /// Lógica de interacción para Reportes.xaml
    /// </summary>
    public partial class Reportes : Window
    {
        nDatos datosn;
        public Reportes()
        {
            datosn = new nDatos();
            InitializeComponent();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            dtmayorcombus.ItemsSource = datosn.Reportemayorcombustible();

        }

        private void btnciudadmasenvios_Click(object sender, RoutedEventArgs e)
        {
            dtciudadmasenvios.ItemsSource = datosn.Reporteciudadmasenvios();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            txtmayorcombustible.Text = datosn.Mayorcombustible();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            dtordenar.ItemsSource = datosn.Ordenardescen();
        }

        private void dtmayorcombus_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void dtordenar_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
