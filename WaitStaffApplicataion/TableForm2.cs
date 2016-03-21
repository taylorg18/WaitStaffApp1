using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WaitStaffApplicataion
{
    public partial class TableForm2 : Form
    {
        private Table tCurrentTable = null;
        private Button tCurrentButton = null;

        public TableForm2()
        {
            InitializeComponent();
           
        }

        public TableForm2(Table newTable, Button inButton)
        {


            InitializeComponent();
            tCurrentTable = newTable;
            tCurrentButton = inButton; 

            if (tCurrentTable.getTableMerged() > 0)
            {
                textBox1.Text = "Table Number: " + tCurrentTable.getTableNum() + "\r\n Number of People: " + tCurrentTable.getNumPeople()
                    + " \r\n" + tCurrentTable.getSpecial() + "Table Merged with: Table " + tCurrentTable.getTableMerged();
            }
            else
            {
                textBox1.Text = "Table Number: " + tCurrentTable.getTableNum() + "\r\n Number of People: " + tCurrentTable.getNumPeople()
                    + " \r\n" + tCurrentTable.getSpecial();
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Receipt rReceipt = tCurrentTable.getReceipt();
            ReceiptForm frm = new ReceiptForm(rReceipt);
            frm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }
        private void TableForm2_Load(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void Clean_Click(object sender, EventArgs e)
        {
            tCurrentTable.updateTableStatus();
            tCurrentTable.setTableMerged(-1);
            tCurrentButton.BackColor=Color.Green;
            tCurrentButton.Text = "Table: " + tCurrentTable.getTableNum();

            textBox1.Text = "Table Number: " + tCurrentTable.getTableNum() + "\r\n Number of People: " + tCurrentTable.getNumPeople()
                   + " \r\n" + tCurrentTable.getSpecial();

        }
    }
}
