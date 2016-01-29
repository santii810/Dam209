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

namespace ADAT_UD3_EJ3
{
    /// <summary>
    /// Lógica de interacción para Window_Usuarios.xaml
    /// </summary>
    public partial class Window_Usuarios : Window
    {
        GenericRepository<Usuarios> gestorUsuarios = new GenericRepository<Usuarios>();
        public Window_Usuarios()
        {
            InitializeComponent();
            this.dataGrid.ItemsSource = gestorUsuarios.GetAll();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            Usuarios user = new Usuarios();
            user.NssUsuario = textBoxNss.Text;
            user.nombre = textBox_Nombre.Text;
            user.apellidos = textBox_Apellidos.Text;
            user.direccion = textBox_Direccion.Text;
            user.contrasena = textBox_Contraseña.Text;
            user.dni = textBox_DNI.Text;
            user.email = textBox_Email.Text;
            user.localidad = textBox_Localidad.Text;
            user.telefono = textBox_Telefono.Text;
            gestorUsuarios.Add(user);
            this.dataGrid.ItemsSource = gestorUsuarios.GetAll();
            dataGrid.Items.Refresh();

            ClearTextBoxes(this);
        }

        void ClearTextBoxes(DependencyObject obj)
        {
            TextBox tb = obj as TextBox;
            if (tb != null)
                tb.Text = "";

            for (int i = 0; i < VisualTreeHelper.GetChildrenCount(obj as DependencyObject); i++)
                ClearTextBoxes(VisualTreeHelper.GetChild(obj, i));
        }

        private void DataGrid_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            //add
            Usuarios tmp = this.dataGrid.SelectedItem as Usuarios;
            this.textBoxNss.Text = tmp.NssUsuario;
            this.textBox_Apellidos.Text = tmp.apellidos;
            this.textBox_Contraseña.Text = tmp.contrasena;
            this.textBox_Direccion.Text = tmp.direccion;
            this.textBox_DNI.Text = tmp.dni;
            this.textBox_Email.Text = tmp.email;
            this.textBox_Localidad.Text = tmp.localidad;
            this.textBox_Nombre.Text = tmp.nombre;
            this.textBox_Telefono.Text = tmp.telefono;

        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            //remove
            Usuarios tmp = this.dataGrid.SelectedItem as Usuarios;
            gestorUsuarios.Delete(gestorUsuarios.Single(i => i.NssUsuario == tmp.NssUsuario));
            this.dataGrid.ItemsSource = gestorUsuarios.GetAll();
            dataGrid.Items.Refresh();
            ClearTextBoxes(this);
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            //update
            Usuarios tmp = this.dataGrid.SelectedItem as Usuarios;
            tmp.NssUsuario = textBoxNss.Text;
            tmp.nombre = textBox_Nombre.Text;
            tmp.apellidos = textBox_Apellidos.Text;
            tmp.direccion = textBox_Direccion.Text;
            tmp.contrasena = textBox_Contraseña.Text;
            tmp.dni = textBox_DNI.Text;
            tmp.email = textBox_Email.Text;
            tmp.localidad = textBox_Localidad.Text;
            tmp.telefono = textBox_Telefono.Text;
            gestorUsuarios.Update(tmp);
            this.dataGrid.ItemsSource = gestorUsuarios.GetAll();
            dataGrid.Items.Refresh();

            ClearTextBoxes(this);
        }
    }
}
