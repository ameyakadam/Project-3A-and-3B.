using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string a = s1.Text;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string a = s1.Text;
            for (int i = 0; i <= a.Length; i++)
            {
                a = a.Replace("{", "");
                a = a.Replace("}", "");
                a = a.Replace("#", "");
                a = a.Replace("%", "");
                a = a.Replace("[", "");
                a = a.Replace("]", "");
                a = a.Replace("*", "");
            }
            s1.Text = a;
            string b = s2.Text;
            if (b.StartsWith("[") || b.StartsWith("(") || b.StartsWith("@") || b.StartsWith("%") || b.StartsWith("]") || b.StartsWith(")")) ;
            {
                MessageBox.Show("The Character 2 cannot start with [ or ] or @ or % or ( or )");
                s2.Clear();
                s2.Focus();
            }
            string c = s3.Text;
            if (c.EndsWith(" ") || c.EndsWith("$") || c.EndsWith("@") || c.EndsWith("%") || c.EndsWith("#"))
            {
                MessageBox.Show("The Character 3 cannot End with a space or $ or @ or % or #");
                s3.Clear();
                s3.Focus();

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void s1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            
        }
    }
}
