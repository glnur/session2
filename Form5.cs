using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form5 : Form
    {
        internal static string s1;
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            s1 = textBox1.Text;
            Form5 frm5 = new WindowsFormsApplication3.Form5();
            Form6 frm6 = new Form6();
            frm6.Show();
            frm5.Close();
        }

        public void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
