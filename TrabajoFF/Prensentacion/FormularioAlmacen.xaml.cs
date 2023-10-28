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
    /// Lógica de interacción para FormularioAlmacen.xaml
    /// </summary>
    public partial class FormularioAlmacen : Window
    {
        nDatos datosn;

        public FormularioAlmacen()
        {
            datosn = new nDatos();
          InitializeComponent();
           Mostrar();
        }
        private void Mostrar()
        {

        dgalmacen.ItemsSource = datosn.ListarAlmacenes();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
          eAlmacen almacen = new eAlmacen();
          datosn.RegistrarAlmacen(almacen);
          MessageBox.Show("Almacén registrado");
          Mostrar();
        }

        private void dgalmacen_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
