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
    /// Lógica de interacción para Registro.xaml
    /// </summary>
    public partial class Registro : Window
    {
        nDatos datosn;
        public Registro()
        {
            datosn = new nDatos();
            InitializeComponent();
        }


        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            List<eUsuario> usuarios = datosn.ListarUsuarios();

            eUsuario nuevousuario = new eUsuario();

            bool existeUsuario = usuarios.Any(usuario =>
                usuario.usuario == txtUsuario.Text);

            if (existeUsuario)
                MessageBox.Show("Usuario ya existente");
            else
            {
                if (txtContrasenia.Text.Length >= 4 && txtContrasenia.Text.Length <= 20)
                {
                    if (txtContrasenia.Text.Contains(" "))
                        MessageBox.Show("Contraseña incorrecta");
                    else
                    {
                        if(txtUsuario.Text.Length <4 || txtUsuario.Text.Length > 16 || txtUsuario.Text.Contains("#") || txtUsuario.Text.Contains("$") || txtUsuario.Text.Contains("%") || txtUsuario.Text.Contains("&") || txtUsuario.Text.Contains("=") || txtUsuario.Text.Contains("?") || txtUsuario.Text.Contains("¡"))
                            MessageBox.Show("Nombre de usuario incorrecto");
                        else
                        {
                            nuevousuario.usuario = txtUsuario.Text;
                            nuevousuario.contrasenia = txtContrasenia.Text;

                            MessageBox.Show(datosn.RegistrarUsuario(nuevousuario));
                        }

                    }

                } else MessageBox.Show("Contraseña incorrecta");
            }
        }
    }
}
