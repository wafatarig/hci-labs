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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (ColorDialog c = new ColorDialog())
            {
                if (c.ShowDialog() == DialogResult.OK)
                    richTextBox1.BackColor = c.Color;
            }
        }

        private void foregroundToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (ColorDialog c = new ColorDialog())
            {
                if (c.ShowDialog() == DialogResult.OK)
                    richTextBox1.ForeColor = c.Color;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {



        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
      
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog d = new OpenFileDialog();
            d.Title = "Open ";
            d.Filter = "Text Document(*.txt)|*.txt|All Files(*.*)|*.*";
            if (d.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.LoadFile(d.FileName, RichTextBoxStreamType.PlainText);
                this.Text = d.FileName;

            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog s = new SaveFileDialog();
            s.Title = "Save ";
            s.Filter = "Text Document(*.txt)|*.txt|All Files(*.*)|*.*";
            if (s.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SaveFile(s.FileName, RichTextBoxStreamType.PlainText);
                this.Text = s.FileName;
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            OpenFileDialog d = new OpenFileDialog();
            d.Title = "Open ";
            d.Filter = "Text Document(*.txt)|*.txt|All Files(*.*)|*.*";
            if (d.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.LoadFile(d.FileName, RichTextBoxStreamType.PlainText);
                this.Text = d.FileName;

            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            SaveFileDialog s = new SaveFileDialog();
            s.Title = "Save ";
            s.Filter = "Text Document(*.txt)|*.txt|All Files(*.*)|*.*";
            if (s.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SaveFile(s.FileName, RichTextBoxStreamType.PlainText);
                this.Text = s.FileName;
            }
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            Font f = richTextBox1.SelectionFont;
            if (f!= null){
                richTextBox1.SelectionFont = new Font(richTextBox1.Font ,f.Style ^ FontStyle.Bold);
            }
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            Font f = richTextBox1.SelectionFont;
           
            richTextBox1.SelectionFont = new Font(richTextBox1.Font, f.Style ^ FontStyle.Underline);
            
        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            Font f = richTextBox1.SelectionFont;

            richTextBox1.SelectionFont = new Font(richTextBox1.Font, f.Style ^ FontStyle.Italic);
            

        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Right;
        }
    }
}
