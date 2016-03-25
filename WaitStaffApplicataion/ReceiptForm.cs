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
        private Receipt     rCurrentReceipt  = null;
        private Employee    eCurrentEmployee = null;

        public ReceiptForm()
        {
            InitializeComponent();
        }
        public ReceiptForm(Receipt newReceipt, Employee newEmployee)
        {
            InitializeComponent();
            rCurrentReceipt = newReceipt;
            eCurrentEmployee = newEmployee;

            ReceiptView.Text = rCurrentReceipt.printReceipt();
        }


        private void ReceiptForm_Load(object sender, EventArgs e)
        {

        }

        private void Card_Click(object sender, EventArgs e)
        {
            ReceiptView.Text += "\r\n\r\nTip $" + TipView.Text + "\r\n\r\nCard Number ##########\r\n\r\n\r\nPayed with Card";

            FinReciept.Visible = true;
            rCurrentReceipt.setPaymentType(true);

            if (Double.TryParse(TipView.Text, out rCurrentReceipt.fTip)) { }
            else
            {
                TipView.Text = "Please Enter A Number";
            }
        }

        private void Cash_Click(object sender, EventArgs e)
        {
            ReceiptView.Text += "\r\n\r\nTip $" + TipView.Text + "\r\n\r\nPayed with Cash";

            FinReciept.Visible = true;
            rCurrentReceipt.setPaymentType(false);

            if (Double.TryParse(TipView.Text, out rCurrentReceipt.fTip)) { }
            else
            {
                TipView.Text = "Please Enter A Number";
            }
        }

        private void FinReciept_Click(object sender, EventArgs e)
        {
            rCurrentReceipt.setDesc(ReceiptView.Text);
            if(eCurrentEmployee != null)
                eCurrentEmployee.updateTips(rCurrentReceipt.getTip());
            Close();
        }
    }
}
