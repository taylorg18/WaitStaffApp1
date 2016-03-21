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
        private Receipt rCurrentReceipt = null;

        public ReceiptForm()
        {
            InitializeComponent();
        }
        public ReceiptForm(Receipt newReceipt)
        {
            InitializeComponent();
            rCurrentReceipt = newReceipt;

            ReceiptView.Text = rCurrentReceipt.printReceipt();
        }


        private void ReceiptForm_Load(object sender, EventArgs e)
        {

        }

        private void Card_Click(object sender, EventArgs e)
        {
            ReceiptView.Text += "\n\nTip $" + TipView.Text + "\n\nCard Number ##########\n\n\nPayed with Cash";

            FinReciept.Visible = true;
            rCurrentReceipt.setPaymentType(true);
        }

        private void Cash_Click(object sender, EventArgs e)
        {
            ReceiptView.Text += "\n\nTip $" + TipView.Text + "\n\nPayed with Cash";

            FinReciept.Visible = true;
            rCurrentReceipt.setPaymentType(false);
        }

        private void FinReciept_Click(object sender, EventArgs e)
        {
            rCurrentReceipt.setDesc(ReceiptView.Text);
        }
    }
}
