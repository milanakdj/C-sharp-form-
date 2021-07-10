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
    public partial class Take_out : Form
    {
        Form4 selectionForm;
        List<FoodItem> foodItems,filteredItems;

        public Take_out(Form4 form)
        {
            InitializeComponent();
            selectionForm = form;//the instance of the form that is passed into this form i.e the old form is loaded

        }


        private void Take_out_Load(object sender, EventArgs e)
        {
            //loadItems();
            //loadData();

            loadItems();
            //filteredItems = foodItems;// this assigns pointer to the fooditem doesn't copies the data items refrence is copied
            
            filteredItems = foodItems.ToList();
            //foodItems.CopyTo(filteredItems);
            loadData();
        }

        void loadData()//food items in datagriditem
        {
            dgItems.Rows.Clear();//clears the list from last instance
            for(int i=0; i< filteredItems.Count; i++)
            {
                //DataRow newRow = dgItems.Rows.Add();
                int index=dgItems.Rows.Add();
                dgItems.Rows[index].Cells["itemCode"].Value = filteredItems[i].getItemCode();
                dgItems.Rows[index].Cells["itemName"].Value = filteredItems[i].getItemName();
                dgItems.Rows[index].Cells["itemPrice"].Value = filteredItems[i].getPrice();
                
            }
        }
        void loadItems()
        {
            foodItems = new List<FoodItem>();
            foodItems.Add(new FoodItem("100", "momo", 120, "Speical momo"));
            foodItems.Add(new FoodItem("101", "c momo", 120, "Speical momo 2"));
            foodItems.Add(new FoodItem("102", "s momo", 120, "Speical momo 3"));
            foodItems.Add(new FoodItem("103", "g momo", 120, "Speical momo 4"));
            foodItems.Add(new FoodItem("104", "gg momo", 120, "Speical momo 5"));

            
        }

        private void Take_out_FormClosing(object sender, FormClosingEventArgs e)
        {
            selectionForm.Show();
            this.Hide();
        }

        private void dgItems_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgItems_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            }

        private void dgItems_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            //since only one can edit so 

            //two arguments in this function 
            //      the second argument is more necessary
            //      "e" this gives which row which column as been changed
            // get the index of row
            int index = e.RowIndex;

            //get the entered in quantity
            //also need to check whether the input is number or not
            int qty = 0;
            if (dgItems.Rows[index].Cells["itemQuantity"].Value != null)
                int.TryParse(dgItems.Rows[index].Cells["itemQuantity"].Value.ToString(), out qty);
            //this first converts the value of quantity to string and then extrast the int and outs it in qty variable
            //conversion to the intger from string buffer
            //could do convert.toint32(), but this gives error when the input is not integer


            //get the final amount by multiplying 
            if (qty > 0)
            {
                float price = Convert.ToInt32(dgItems.Rows[index].Cells["itemPrice"].Value.ToString());
                // used convert because we know that the user has to give the value of itemPrice as float
                //set the value in total
                dgItems.Rows[index].Cells["itemAmount"].Value = qty * price;
            }
    }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            filteredItems.Clear();

            if (txtSearch.Text == null)
            {
                filteredItems = foodItems;//displays the whole thing when null in search
            }
            else 
            { 
                foreach(FoodItem item in foodItems)// class item in object
                {
                    string search_item = txtSearch.Text.ToLower();
                    if(item.getItemCode().ToLower().Contains(txtSearch.Text) || item.getItemName().ToLower().Contains(txtSearch.Text) || item.getPrice().ToString().Contains(txtSearch.Text))
                            {
                        filteredItems.Add(item);
                    }
                    /*
                     * for(int i=0;i <foodItems.count;i++)
                     * {
                     * FoodItem item=foodItems[i];
                     * }
                     * 
                     */
                }
            }

            //load data into dgItems
            loadData();
        }
    }
}
