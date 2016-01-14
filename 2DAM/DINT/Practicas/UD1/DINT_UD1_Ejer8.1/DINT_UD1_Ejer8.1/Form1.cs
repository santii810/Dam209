using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DINT_UD1_Ejer8._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Click");
        }

        private void label1_DoubleClick(object sender, EventArgs e)
        {
            listBox1.Items.Add("Double Click");
        }

        private void label1_MouseClick(object sender, MouseEventArgs e)
        {
            listBox1.Items.Add("Mouse Click");

        }

        private void label1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            listBox1.Items.Add("Mouse Double Click");

        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            listBox1.Items.Add("Mouse Down");

        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            listBox1.Items.Add("Mouse Enter");

        }

        private void label1_MouseHover(object sender, EventArgs e)
        {
            listBox1.Items.Add("Mouse Hover");

        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            listBox1.Items.Add("Mouse Leave");

        }

        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            listBox1.Items.Add("Mouse Move");

        }

        private void label1_MouseUp(object sender, MouseEventArgs e)
        {
            listBox1.Items.Add("Mouse Up");

        }
    }
}
