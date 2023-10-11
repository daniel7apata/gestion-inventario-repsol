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
    /// Lógica de interacción para Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        nDatos datosn;
        public int intentos = 3;
        public Login()
        {
            datosn = new nDatos();
            InitializeComponent();
 
        }



        private void Button_Click(object sender, RoutedEventArgs e)
        {
            List<eUsuario> usuarios = datosn.ListarUsuarios();
            
            bool existeUsuario = usuarios.Any(usuario =>
                usuario.usuario == txtUsuario.Text && usuario.contrasenia == txtContrasenia.Text && usuario.contrasenia.Length>=4 && usuario.contrasenia.Length <= 20);

            if (existeUsuario)
            {
              if (intentos > 0)
              {
                    MainWindow f = new MainWindow();
                    f.ShowDialog();
              }
              else 
                    MessageBox.Show("La cuenta ha sido bloqueada/suspendida debido a la superación de intentos fallidos\"");
            }
            else
            {
               
                if (intentos <= 0)
                    MessageBox.Show("La cuenta ha sido bloqueada/suspendida debido a la superación de intentos fallidos\"");
                
                else
                {
                    intentos--;
                    MessageBox.Show("Usuario inexistente, quedan " + intentos + " intentos.");
                }
                    
            }


        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Registro f = new Registro();
            f.ShowDialog();
        }

        private void txtUsuario_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
