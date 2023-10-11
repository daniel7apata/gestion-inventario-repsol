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
using System.Windows.Navigation;
using System.Windows.Shapes;
using Negocio;
using Entidades;

namespace Prensentacion
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnAlmacen_Click(object sender, RoutedEventArgs e)
        {
            FormularioAlmacen f = new FormularioAlmacen();
            f.ShowDialog();
        }

        private void btnLoteentrante_Click(object sender, RoutedEventArgs e)
        {
            FormularioLoteEntrante f = new FormularioLoteEntrante();
            f.ShowDialog();
        }

        private void btnlotesaliente_Click(object sender, RoutedEventArgs e)
        {
            FormularioLoteSaliente f = new FormularioLoteSaliente();
            f.ShowDialog();
        }

        private void btnciudad_Click(object sender, RoutedEventArgs e)
        {
            FormularioCiudad f = new FormularioCiudad();
            f.ShowDialog();
        }

        private void btnreportes_Click(object sender, RoutedEventArgs e)
        {
            Reportes f = new Reportes();
            f.ShowDialog();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Eliminar_usuarios f = new Eliminar_usuarios();
            f.ShowDialog();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            ModificarContrasenia f = new ModificarContrasenia();
            f.ShowDialog();
        }
    }
}
