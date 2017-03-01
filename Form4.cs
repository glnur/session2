using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form4 : Form
    {
        internal static int i=2;
         internal static string s;

        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            if (i == 6) label6.Text = s;
            else if (i == 10) label10.Text = s;       
            else if (i == 14) label14.Text = s;
            else if (i == 18) label18.Text = s;
            else if (i == 22) label22.Text = s;
            Form3 frm3 = new Form3();
            frm3.Close();
        }

        public void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        public void tableLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        public void label5_Click(object sender, EventArgs e)
        {

        }

        public void label8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            Form5 frm5 = new WindowsFormsApplication3.Form5();
     
            frm5.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form8 frm8 = new WindowsFormsApplication3.Form8();
            Form4 frm4 = new Form4();
            frm8.Show();
            frm4.Close();
        }

        private void tableLayoutPanel1_Paint_2(object sender, PaintEventArgs e)
        {

        }

        public void label6_Click(object sender, EventArgs e)
        {

        }

        public void label10_Click(object sender, EventArgs e)
        {

        }

        public void label14_Click(object sender, EventArgs e)
        {

        }

        public void label18_Click(object sender, EventArgs e)
        {

        }

        public void label22_Click(object sender, EventArgs e)
        {

        }
    }
}
