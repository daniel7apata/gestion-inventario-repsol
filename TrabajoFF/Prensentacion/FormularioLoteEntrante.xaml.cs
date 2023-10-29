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
        bool estaEnRango;
        int numero;
        bool esEntero;
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
            eLoteentrante entrante = new eLoteentrante();

            entrante.Fecha = Convert.ToInt32(txtfecha.Text);

            int valorFecha = entrante.Fecha; // Reemplaza con tu valor de fecha en formato YYYYMMDD

            DateTime fechaLimite = new DateTime(1987, 10, 1);
            DateTime fechaHoy = DateTime.Now;

            DateTime fechaConvertida;

            int cantidadalamacenes = datosn.ListarAlmacenes().Count;

            if (int.TryParse(valorFecha.ToString(), out int parsedDate) &&
                DateTime.TryParseExact(parsedDate.ToString(), "yyyyMMdd", null, System.Globalization.DateTimeStyles.None, out fechaConvertida))
            {
                if (fechaConvertida >= fechaLimite && fechaConvertida <= fechaHoy)
                    estaEnRango = true;
                
                else
                    estaEnRango = false;
                
            }
            else
            {
                Console.WriteLine("El valor no es una fecha válida.");
            }

            if (int.TryParse(txtID_amacen.Text, out int numero))
            {
                // La conversión a entero fue exitosa, y el valor se almacena en la variable 'numero'.
                Console.WriteLine("El valor ingresado es un número entero: " + numero);
                esEntero = true;
            }
            else
            {
                // La conversión falló, lo que significa que el valor ingresado no es un número entero.
                Console.WriteLine("El valor ingresado no es un número entero.");
                esEntero = false;
            }

            if (estaEnRango == true)
            {
                if (txtcontenido.Text != "" || txtfecha.Text != "" || txtcontenido.Text != "" || txtID_amacen.Text != "")
                {
                    if (Convert.ToDouble(txtcontenido.Text) > 0 && Convert.ToDouble(txtcontenido.Text) <= 1000000)
                    {
                        entrante.Combustible = txttipo.Text;

                        if (entrante.Combustible == "gasolina" || entrante.Combustible == "petroleo")
                        {
                            if (esEntero == true && Convert.ToDouble(txtID_amacen.Text) > 0 && Convert.ToDouble(txtID_amacen.Text) <= cantidadalamacenes)
                            {

                                entrante.Cantidad = Convert.ToInt32(txtcontenido.Text);
                                entrante.Fecha = Convert.ToInt32(txtfecha.Text);

                                entrante.Almacen = Convert.ToInt32(txtID_amacen.Text);
                                datosn.RegistrarLoteEntrante(entrante);
                                MessageBox.Show("Lote entrante registrado");
                            }
                            else MessageBox.Show("El ID ingresado no existe");
                        }
                        else MessageBox.Show("Tipo de combustible incorrecto");
                    }
                    else MessageBox.Show("Cantidad incorrecta");
                    Mostrar();
                }
                else
                { MessageBox.Show("Ingrese todos los datos"); }
            }
            else { MessageBox.Show("La fecha no está dentro del rango entre el 1 de octubre de 1987 y hoy."); }



        }

        private void txtcontenido_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
