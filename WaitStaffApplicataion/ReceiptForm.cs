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

            ReceiptView.Text = rCurrentReceipt.getDesc();
        }


        private void ReceiptForm_Load(object sender, EventArgs e)
        {

        }


    }
}
