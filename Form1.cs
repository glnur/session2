using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int[,] users = new int[10,10];
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new WindowsFormsApplication3.Form3();
            Form1 frm = new Form1();
            frm3.Show();
            frm.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            Form2 frm2 = new Form2();
            frm2.Show();
            frm.Hide();
        }
    }
}
