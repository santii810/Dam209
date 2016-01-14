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
    /// Lógica de interacción para Saludo.xaml
    /// </summary>
    public partial class Saludo : Window
    {
        public Saludo(string correo)
        {
            InitializeComponent();
            label.Content = "Saludos " + correo;
        }

        private void Grid_DataContextChanged(object sender, DependencyPropertyChangedEventArgs e)
        {

        }

        private void Window_Activated(object sender, EventArgs e)
        {

        }
    }
}
