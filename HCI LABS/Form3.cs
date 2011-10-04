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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            textBox1.Focus();
            textBox2.Focus();
            button1.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "your_user_name" && textBox2.Text == "your_password")
            {
                Form4 f = new Form4();
                f.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("The user name or password you enter is incorrect , try again");
                this.clear();
            }
           
        }
        private void clear()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox1.Focus();
        }
        private void label3_Click(object sender, EventArgs e)
        {
            this.clear();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }
    }
}
