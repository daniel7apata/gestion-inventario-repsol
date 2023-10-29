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
    /// Lógica de interacción para FormularioLoteSaliente.xaml
    /// </summary>
    public partial class FormularioLoteSaliente : Window
    {
        nDatos datosn;
        eLoteSalida salida;
        bool estaEnRango;
        int numero;
        bool esEntero;
        bool esNumero;
        public FormularioLoteSaliente()
        {
            datosn = new nDatos();
            InitializeComponent();
            Mostrar();
            salida = new eLoteSalida();
        }
        private void Mostrar()
        {

            dgEsaliente.ItemsSource = datosn.ListarSalientes();
            dgCiudades.ItemsSource = datosn.ListarCiudad();
            dgalmacen.ItemsSource = datosn.ListarAlmacenes();
        }

        private void btnRegistrar_Click(object sender, RoutedEventArgs e)
        {

            salida.Fecha = Convert.ToInt32(txtfecha_salida.Text);

            int valorFecha = salida.Fecha; // Reemplaza con tu valor de fecha en formato YYYYMMDD

            DateTime fechaLimite = new DateTime(1987, 10, 1);
            DateTime fechaHoy = DateTime.Now;

            DateTime fechaConvertida;

            int cantidadalamacenes = datosn.ListarAlmacenes().Count;

            if (int.TryParse(valorFecha.ToString(), out int parsedDate) &&
                DateTime.TryParseExact(parsedDate.ToString(), "yyyyMMdd", null, System.Globalization.DateTimeStyles.None, out fechaConvertida))
            {
                if (fechaConvertida >= fechaLimite && fechaConvertida <= fechaHoy)
                {
                    estaEnRango = true;
                }
                else
                {
                    estaEnRango = false;
                }
            } else Console.WriteLine("El valor no es una fecha válida.");
            

            if (double.TryParse(txtcontenido.ToString(), out double parsedDouble))
            {
                esNumero = true;
            }

            else { esNumero = false; }


            if (int.TryParse(txtalmacen.Text, out int numero))
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
            

            if (estaEnRango == true) {
                if (txtalmacen.Text != "" || txtciudad.Text != "" || txttipo.Text != "" || txtfecha_salida.Text != "")
                {
                    salida.Combustible = txttipo.Text;
                    if (salida.Combustible == "gasolina" || salida.Combustible == "petroleo")
                    {

                        salida.Fecha = Convert.ToInt32(txtfecha_salida.Text);
                        salida.Ciudad = txtciudad.Text;

                        if (salida.Ciudad.Length >= 3 && salida.Ciudad.Length <= 20)
                        {
                            if (Convert.ToDouble(txtcontenido.Text) > 0 && Convert.ToDouble(txtcontenido.Text) <= 1000000)
                            {
                                if (esEntero == true && Convert.ToDouble(txtalmacen.Text) > 0 && Convert.ToDouble(txtalmacen.Text)<=cantidadalamacenes) { 
                                salida.Almacen = Convert.ToInt32(txtalmacen.Text);
                                salida.Cantidad = Convert.ToInt32(txtcontenido.Text);
                                datosn.RegistrarLoteSSaliente(salida);
                                MessageBox.Show("Lote saliente registrado");
                                Mostrar();
                                }
                                else MessageBox.Show("El ID ingresado no existe");
                            }
                            else MessageBox.Show("Cantidad incorrecta");
                        }
                        else MessageBox.Show("Nombre incorrecto");
                    }
                    else MessageBox.Show("Tipo de combustible incorrecto");
                }
            }
            else { MessageBox.Show("La fecha no está dentro del rango entre el 1 de octubre de 1987 y hoy."); }

            

        }

        private void txtalmacen_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void cmbciudad_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
        }

        private void txttipo_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void dgalmacen_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
