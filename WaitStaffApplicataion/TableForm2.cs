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
        private FoodMenu curMenu = null;

        public TableForm2(Table newTable, Button inButton, FoodMenu menu)
        {
            InitializeComponent();
            tCurrentTable = newTable;
            tCurrentButton = inButton;
            curMenu = menu;
            int waitTime=0;
            if (tCurrentTable.getTableMerged() > 0)
            {
                if(this.tCurrentTable.getReceipt()!= null)
                {
                    waitTime = this.tCurrentTable.getReceipt().getWaitTime();
                }
                textBox1.Text = "Table Number: " + tCurrentTable.getTableNum() + "    " + waitTime + " Wait Time\r\n Number of People: " + tCurrentTable.getNumPeople()
                    + " \r\n" + tCurrentTable.getSpecial() + "Table Merged with: Table " + tCurrentTable.getTableMerged();
            }
            else
            {
                if (this.tCurrentTable.getReceipt() != null)
                {
                    waitTime = this.tCurrentTable.getReceipt().getWaitTime();
                }
                textBox1.Text = "Table Number: " + tCurrentTable.getTableNum() + "     " + waitTime + " Wait Time\r\n Number of People: " + tCurrentTable.getNumPeople()
                    + " \r\n" + tCurrentTable.getSpecial();
            }

            
        }


        private void button1_Click(object sender, EventArgs e)
        {
            MenuForm MenuForm = new MenuForm(tCurrentTable, curMenu);
            MenuForm.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Receipt rReceipt = tCurrentTable.getReceipt();
            ReceiptForm frm = new ReceiptForm(rReceipt, tCurrentTable.getEmployee());
            frm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void TableForm2_Load(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void Clean_Click(object sender, EventArgs e)
        {
            string userName = Environment.UserName;
            if (tCurrentTable.getTableNum() == 16)
            {
                System.IO.File.WriteAllText(@"C:\Users\" + userName + @"\Dropbox\CS 341\Reception\waitRecName.txt", tCurrentTable.getSpecial());
             }
            else
            {

                if (System.IO.File.Exists(@"C:\Users\" + userName + @"\Dropbox\CS 341\Reception\waitRecNumber.txt"))
                {
                    return;
                }
                else
                {
                    System.IO.File.WriteAllText(@"C:\Users\" + userName + @"\Dropbox\CS 341\Reception\waitRecNumber.txt", tCurrentTable.getTableNum() + "");
                }
            }
            tCurrentTable.updateTableStatus();
            tCurrentTable.setTableMerged(-1);
            tCurrentButton.BackColor=Color.Green;
            tCurrentButton.Text = "Table " + tCurrentTable.getTableNum();

            tCurrentTable.addNewReciept();

            textBox1.Text = "Table Number: " + tCurrentTable.getTableNum() + "\r\n Number of People: " + tCurrentTable.getNumPeople()
                   + " \r\n" + tCurrentTable.getSpecial();



        }
    }
}
