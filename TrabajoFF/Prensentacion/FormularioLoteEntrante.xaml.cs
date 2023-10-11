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
    /// Lógica de interacción para FormularioLoteEntrante.xaml
    /// </summary>
    public partial class FormularioLoteEntrante : Window
    {
        nDatos datosn;
        public FormularioLoteEntrante()
        {
            datosn = new nDatos();
            InitializeComponent();
            Mostrar();
        }
        private void Mostrar()
        {

            dgentrante.ItemsSource = datosn.ListarEntrantes();
            dtalmacen.ItemsSource = datosn.ListarAlmacenes();
        }

        private void btnregistrar_Click(object sender, RoutedEventArgs e)
        {
            eAlmacen alm = new eAlmacen();
            if (txtcontenido.Text != "" || txtfecha.Text != "" || txtcontenido.Text != "" || txtID_amacen.Text != "")
            {
                eLoteentrante entrante = new eLoteentrante();



                entrante.contenido = Convert.ToInt32(txtcontenido.Text);
                if (entrante.contenido > 0 && entrante.contenido <= 1000000) {
                    entrante.fecha_entrada = Convert.ToInt32(txtfecha.Text);
                    
                    entrante.tipo = txttipo.Text;

                    if (entrante.tipo == "gasolina" || entrante.tipo == "petroleo")
                    {
                        entrante.almacen = Convert.ToInt32(txtID_amacen.Text);
                        MessageBox.Show(datosn.RegistrarLoteEntrante(entrante));
                    }
                    else MessageBox.Show("Tipo de combustible incorrecto");

                } else MessageBox.Show("Cantidad incorrecta");

               
                Mostrar();

            }
            else
            { MessageBox.Show("Ingrese todos los datos"); }



        }

        private void txtcontenido_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
