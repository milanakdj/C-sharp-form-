using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*ProgressBar pBar = new ProgressBar();
            pBar.Location = new System.Drawing.Point(20, 20);
            pBar.Name = "progressBar1";
            pBar.Width = 200;
            pBar.Height = 30;
            pBar.Dock = DockStyle.Bottom;
            pBar.Minimum = 0;
            pBar.Maximum = 100;
            pBar.Value = 70;
            Controls.Add(pBar);*/

            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panel2.Width += 3;
            if (panel2.Width >= 700)
            {
                timer1.Stop();
                Form2 form2;
                form2 = new Form2();
                form2.Show();
                this.Hide();

            }
        }
    }
}
