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

        public TableForm2()
        {
            InitializeComponent();
        }

        public TableForm2(Table newTable)
        {
            InitializeComponent();
            tCurrentTable = newTable;
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
    }
}
