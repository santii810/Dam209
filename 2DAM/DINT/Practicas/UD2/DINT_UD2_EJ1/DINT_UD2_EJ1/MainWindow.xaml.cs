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

namespace DINT_UD2_EJ1
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private List<Usuario> usuarios = new List<Usuario>();


      public void addItem(Usuario user)
        {
            this.usuarios.Add(user);
        }
        public MainWindow()
        {
            InitializeComponent();
            this.usuarios.Add(new Usuario("Juan", "Jose", "abc123.", "juan@hotmail.com", "Direccion"));
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
        private bool autenticar()
        {
            foreach (Usuario item in usuarios)
            {
                if (item.email == textBoxEmail.Text.Trim())
                {
                    if (item.password == passwordBox.Password)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
  


        //Autogenerados

        private void buttonLogin_Click(object sender, RoutedEventArgs e)
        {
            if (!comprobarEmail())
            {
                MessageBox.Show("Formato de email incorrecto");
            }
            else
            {
                if (autenticar())
                {
                    Saludo saludo = new Saludo(textBoxEmail.Text);
                    saludo.Show();
                }
            }
        }


        private void botonRegistro()
        {

        }

        private void Hyperlink_Click(object sender, RoutedEventArgs e)
        {
            Registro reg = new Registro();
            reg.Show();
        }
    }
}
