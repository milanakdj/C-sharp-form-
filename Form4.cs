using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Take_out tt = new Take_out(this);
            this.Hide();
            tt.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dine dineForm = new dine(this);
            this.Hide();
            dineForm.Show();
        }
    }
}
