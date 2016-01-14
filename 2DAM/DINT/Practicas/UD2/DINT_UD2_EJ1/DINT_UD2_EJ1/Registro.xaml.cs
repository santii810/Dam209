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

namespace DINT_UD2_EJ1
{
    /// <summary>
    /// Lógica de interacción para Window1.xaml
    /// </summary>
    public partial class Registro : Window
    {
        public Registro()
        {
            InitializeComponent();
        }


        private bool comprobarDatos()
        {
            if (!passwordBox.Password.Equals(passwordBoxRepetir.Password))
                return false;
            if (!comprobarEmail())
                return false;
            return true;
        }

        private bool comprobarEmail()
        {
            string[] partes = textBoxEmail.Text.Split('@');
            if (partes.Length != 2)
            {
                return false;
            }
            foreach (string item in partes)
            {
                if (string.IsNullOrEmpty(item))
                    return false;
            }
            return true;
        }
        private void button_Copy1_Click(object sender, RoutedEventArgs e)
        {
            this.textBoxApellido.Clear();
            this.textBoxDireccion.Clear();
            this.textBoxEmail.Clear();
            this.textBoxNombre.Clear();
            this.passwordBox.Clear();
            this.passwordBoxRepetir.Clear();

        }

        private void labelRegistro_ContextMenuOpening(object sender, ContextMenuEventArgs e)
        {

        }

        private void buttonEnviar_Click_1(object sender, RoutedEventArgs e)
        {
            if (comprobarDatos())
            {
                MainWindow ventana = new MainWindow();
                ventana.addItem(
                    new Usuario(this.textBoxNombre.Text,
                    this.textBoxApellido.Text,
                    this.textBoxEmail.Text,
                    this.passwordBox.Password,
                    this.textBoxDireccion.Text
                    ));
                this.Close();
            }
        }

        private void buttonCancelar_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
