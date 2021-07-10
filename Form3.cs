using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            label4.Text = "enter the id here to get other datas";

            //if(data on the id is found in the database then show the other 2 fields
            //textBox3.Text found in database
        }
        bool isLoginValid(String user_name, String password)
        {
            String user = "hello";
            String pwd = "hello";
            if (user_name == user && pwd == password)
                return true;
            else
                return false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (isLoginValid(nameTextBox.Text, textBox2.Text))
            {
                label5.Visible = false;
                Form4 foo = new Form4();
                foo.Show();
                this.Hide();
            }
            else
                label5.Visible = true;

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
