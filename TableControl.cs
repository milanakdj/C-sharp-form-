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
    public partial class TableControl : UserControl
    {
        string table_no, floor_no, amount;
        public TableControl()
        { }
        public TableControl(string table, string floor, string amount)//we use parameterized constructor to pass the values
        {
            InitializeComponent();
            this.table_no = table;
            this.floor_no = floor;
            this.amount = amount;
        }

        private void TableControl_Load(object sender, EventArgs e)
        {
            lblTableNo.Text = "Table " + table_no;
            lblFloorNo.Text = "Floor "+ floor_no;
            lblTotalAmount.Text = "Bill "+ amount;
        }
    }
}
