using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DINT_Ej1._3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            sortLstDestino();
            sortLstFuente();
        }

        private void btnAñadirF_Click(object sender, EventArgs e)
        {
            lstFuente.Items.Add(txtF.Text);
            sortLstDestino();
            sortLstFuente();
        }

        private void btnAñadirD_Click(object sender, EventArgs e)
        {
            lstDestino.Items.Add(txtD.Text);
            sortLstDestino();
            sortLstFuente();
        }

        private void btnEliminarF_Click(object sender, EventArgs e)
        {
            deleteFromListBox(lstFuente);
            sortLstDestino();
            sortLstFuente();
        }

        private void btnEliminarTodoF_Click(object sender, EventArgs e)
        {
            lstFuente.Items.Clear();
            sortLstDestino();
            sortLstFuente();
        }

        private void btnEliminarD_Click(object sender, EventArgs e)
        {
            deleteFromListBox(lstDestino);
            sortLstDestino();
            sortLstFuente();
        }


        private void deleteFromListBox(ListBox lst)
        {
            object[] itemsToRemove = new object[lst.SelectedItems.Count];
            lst.SelectedItems.CopyTo(itemsToRemove, 0);

            foreach (object item in itemsToRemove)
            {
                lst.Items.Remove(item);
            }
        }
        private void moveToListBox(ListBox lststOrigen, ListBox lstDestino)
        {
            object[] itemsToMove = new object[lststOrigen.SelectedItems.Count];
            lststOrigen.SelectedItems.CopyTo(itemsToMove, 0);

            foreach (object item in itemsToMove)
            {
                lststOrigen.Items.Remove(item);
                lstDestino.Items.Add(item);
            }
        }
        private void moveAllToListBox(ListBox lststOrigen, ListBox lstDestino)
        {
            object[] itemsToMove = new object[lststOrigen.Items.Count];
            lststOrigen.Items.CopyTo(itemsToMove, 0);

            foreach (object item in itemsToMove)
            {
                lststOrigen.Items.Remove(item);
                lstDestino.Items.Add(item);
            }
        }

        private void btnMoverTodoADestino_Click(object sender, EventArgs e)
        {
            moveAllToListBox(lstFuente, lstDestino);
            sortLstDestino();
            sortLstFuente();
        }

        private void btnMoverADestino_Click(object sender, EventArgs e)
        {
            moveToListBox(lstFuente, lstDestino);
            sortLstDestino();
            sortLstFuente();
        }

        private void btnMoverAFuente_Click(object sender, EventArgs e)
        {
            moveToListBox(lstDestino, lstFuente);
            sortLstDestino();
            sortLstFuente();
        }

        private void btnMoverTodoAFuente_Click(object sender, EventArgs e)
        {
            moveAllToListBox(lstDestino, lstFuente);
            sortLstDestino();
            sortLstFuente();
        }

        private void lstDestino_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void sortLstFuente()
        {
            object[] itemsToSort = new object[lstFuente.Items.Count];
            lstFuente.Items.CopyTo(itemsToSort, 0);
            Array.Sort(itemsToSort);
            foreach (object item in itemsToSort)
                lstFuente.Items.Remove(item);
            foreach (object item in itemsToSort)
                lstFuente.Items.Add(item);

        }
        private void sortLstDestino()
        {
            object[] itemsToSort = new object[lstDestino.Items.Count];
            lstDestino.Items.CopyTo(itemsToSort, 0);
            Array.Sort(itemsToSort);

            foreach (object item in itemsToSort)
                lstDestino.Items.Remove(item);
            foreach (object item in itemsToSort)
                lstDestino.Items.Add(item);

        }

        }
    
}
