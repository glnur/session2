using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
          
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            bool f = true;
            string users=" ";
            if (textBox1.Text != textBox4.Text) label5.Text = "Не совпадает";
            else
            {
                    if (textBox2.Text + textBox4.Text == users ) f = false;
                    else users = textBox2.Text + textBox4.Text;
                if (f)
                {
                    Form3 frm3 = new WindowsFormsApplication3.Form3();
                    frm3.Show();
                    this.Close();
                }
                else MessageBox.Show("Такой пользователь уже существует");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
           
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           
        }
    }
}
