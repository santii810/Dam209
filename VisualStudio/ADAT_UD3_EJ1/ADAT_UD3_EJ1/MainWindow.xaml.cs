using ADAT_UD3_EJ1.LenguajeADAT;
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

namespace ADAT_UD3_EJ1
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        GestorBD gestor = new GestorBD();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            this.dataGrid.ItemsSource = gestor.obtenerCursosProfesor(5).Select(k => new { k.CourseId, k.CourseName, k.Teacher.TeacherName }).ToList();
            
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
             this.dataGrid.ItemsSource = gestor.obtenerEstudiantes().Where(k=> k.StudentID <=3).Select(k=> new { k.StudentID, k.StudentName, k.StudentAddress.Address1, k.StudentAddress.City }).ToList();
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            int estudiante = 1;
            dataGrid.ItemsSource = gestor.obtenerEstudiante(estudiante).Course.Select(i=> new { i.CourseId,i.CourseName,i.Teacher.TeacherName}).ToList();
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            AddAlumno addAlumno = new AddAlumno();
            addAlumno.Show();
        }
    }
}

