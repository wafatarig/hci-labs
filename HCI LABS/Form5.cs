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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("" , "Question", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("", "Stop", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("" ,"Error",  MessageBoxButtons.OK, MessageBoxIcon.Error);
            

            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("" ,"Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
           
        }
    }
}
