using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4.i += 4;
            Form4.s = Form5.s1;
            Form4 frm4 = new Form4();
            frm4.Show();           
            Form6 frm6 = new WindowsFormsApplication3.Form6();
            Form7 frm7 = new Form7();
            frm7.Show();
            this.Close();
        }
    }
}
