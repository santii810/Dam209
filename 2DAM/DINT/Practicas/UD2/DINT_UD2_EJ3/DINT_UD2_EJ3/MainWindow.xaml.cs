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
using Microsoft.Win32;


namespace DINT_UD2_EJ3
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            mediaElement.Play();
        }

        private void button_Copy_Click(object sender, RoutedEventArgs e)
        {
            mediaElement.Pause();
        }

        private void button_Copy1_Click(object sender, RoutedEventArgs e)
        {
            mediaElement.Stop();
        }

        private void button_Copy2_Click(object sender, RoutedEventArgs e)
        {

            if (mediaElement.IsMuted)
            {
                mediaElement.Volume = 0.5;
            }
            else
            {
                mediaElement.Volume = 0;

            }

        }

        private void slider_DragLeave(object sender, DragEventArgs e)
        {
            mediaElement.Volume-=0.1;
        }

        private void slider_DragOver(object sender, DragEventArgs e)
        {
            mediaElement.Volume += 0.1;

        }

        private void slider_Copy_DragLeave(object sender, DragEventArgs e)
        {
            mediaElement.Balance -= 0.1;
        }

        private void slider_Copy_DragOver(object sender, DragEventArgs e)
        {
            mediaElement.Balance += 0.1;
        }

        private void slider_Copy1_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            
        }

        private void slider_Copy1_DragLeave(object sender, DragEventArgs e)
        {
            mediaElement.SpeedRatio--;
        }

        private void slider_Copy1_DragOver(object sender, DragEventArgs e)
        {
            mediaElement.SpeedRatio++;
        }

        private void button_Copy3_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.FileName = "Videos";  
            dialog.DefaultExt = ".WMV"; 
            dialog.Filter = "archivo mp4|*.mp4|arvhivo.avi|*.avi";//"WMV file (.wm)|*.wmv"; // Filter files by extension

            if (dialog.ShowDialog() == true)
            {

                // Open document  
                mediaElement.Source = new Uri(dialog.FileName);
                

                
            }
        }
    }
}
