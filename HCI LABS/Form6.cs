using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HCI_LABS
{
    public partial class Form6 : Form
    {
        int index = 0;
        public Form6()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_MouseDown(object sender, MouseEventArgs e)
        {
            ListBox listbox = sender as ListBox;
            index = listbox.IndexFromPoint(e.X, e.Y);
            if (index >= 0 & e.Button == MouseButtons.Left)
            {
                listbox.DoDragDrop(listbox.Items[index].ToString(), DragDropEffects.Move);
            }

        }

        private void listBox2_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(System.String)))
            {
                e.Effect = DragDropEffects.Move;
            }
            else {

                e.Effect = DragDropEffects.None;
            }

        }

        private void listBox1_DragDrop(object sender, DragEventArgs e)
        {
            
        }

        private void listBox2_DragDrop(object sender, DragEventArgs e)
        {
            ListBox listboxx = sender as ListBox;
            listboxx.Items.Add(e.Data.GetData(typeof(System.String)).ToString());
            listBox1.Items.RemoveAt(index);
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
