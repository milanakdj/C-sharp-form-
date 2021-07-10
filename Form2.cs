using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{
    
    public partial class Form2 : Form
    {
        int progress = 0;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progress++;
            this.progressBar1.Increment(1);//progressBar1.value=progress;
            label1.Text = "loading..." + progress + " % loaded";
            if (progress >= 100)
            {
                timer1.Stop();
                Form3 form3 = new Form3();
                form3.Show();
                this.Hide();
            }
            /*if(this.progressBar1.Value==100)
            {
                Form1 form = new Form1();
                form.Show();
                this.Hide();
            }*/
        }
    }
}
