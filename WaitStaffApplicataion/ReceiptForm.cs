using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WaitStaffApplicataion
{
    public partial class ReceiptForm : Form
    {
        public ReceiptForm()
        {
            InitializeComponent();
            Table[] tables = new Table[5];
            FoodItem[] foodsOrders = new FoodItem[12];
            ArrayList list = new ArrayList();//list of food orders and yeah
            
            

        }

        private void ReceiptForm_Load(object sender, EventArgs e)
        {

        }


    }
}
