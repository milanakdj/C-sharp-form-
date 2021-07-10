using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class dine : Form
    {
        Form4 selectionForm;
        List<int> tableList, filteredList;
        public dine(Form4 selectionForm)
        {
            InitializeComponent();
            this.selectionForm = selectionForm;
        }

        private void dine_Load(object sender, EventArgs e)
        {
            //load the table
            //sometimes due to covid we may need to operate at half capacity
            //tables are dynamic
            loadTableFromDB();
            loadTablesIntoPanel();
        }
        //load table into float label panel
        private void loadTablesIntoPanel()
        {
            panelTable.Controls.Clear();//removes everything from table
            foreach(int item in filteredList)
            {
                //replacing the buttons with control
                TableControl table = new TableControl();
                panelTable.Controls.Add(table);


                /*Button btn = new Button();
                btn.Text = "table" + item;
                panelTable.Controls.Add(btn);//controls is a building list*/
            }
        }
        //load tables from database- function created
        private void loadTableFromDB()
        {
            tableList = new List<int>();
            for (int i = 0; i < 30; i++)//flow label panel makes it so that the btn don't overlap and are properly arranged
                //also when the screen is rearranged and stuff the controls are dynamically changed to match the window
                tableList.Add(i);
            filteredList = tableList.ToList();// needs using System.Linq;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string text = txtSearch.Text;
            filteredList.Clear();
            if (text != null && text != "")//at first it is null, then when we enter a number and then remove it text become ""
            {
                foreach(int item in tableList)
                {
                    if(item.ToString().Contains(text))//text == item.ToString() for just the exact number
                    {
                        filteredList.Add(item); 
                    }
                }
            }
            else//when no text
            {
                filteredList = tableList.ToList();
            }
            loadTablesIntoPanel();
        }

        private void dine_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            this.selectionForm.Show();
        }
    }
}
