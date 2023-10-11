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
    /// Lógica de interacción para Eliminar_usuarios.xaml
    /// </summary>
    public partial class Eliminar_usuarios : Window
    {
        nDatos datosn;
        public Eliminar_usuarios()
        {
            datosn = new nDatos();
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            List<eUsuario> usuarios = datosn.ListarUsuarios();

            bool existeUsuario = usuarios.Any(usuario =>
                usuario.usuario == txtUsuario.Text);

            if (existeUsuario)
            {
                datosn.EliminarUsuario(txtUsuario.Text);
                MessageBox.Show("Usuario eliminado");
            }
            else
                MessageBox.Show("El usuario ingresado no existe");
        }

        private void txtUsuario_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
