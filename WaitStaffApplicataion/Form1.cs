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
    public partial class Sections : Form
    {
        Table[] tables = new Table[15];
        Button[] buttons;
        public Sections()
        {
            InitializeComponent();
            buttons = new Button[15]{tableButton1, tableButton2, tableButton3, tableButton4, tableButton5, tableButton6,  tableButton7,
                    tableButton8, tableButton9, tableButton10, tableButton11, tableButton12,  tableButton13, tableButton14,
                    tableButton15};

            for(int i = 0; i < buttons.Length;i++)
            {
                buttons[i].Text = "Table " + (i+1);
                buttons[i].BackColor = Color.Green;
            }

            for(int i = 0; i < tables.Length; i++)
            {
                tables[i] = new Table();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

     

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void tableClick(object sender, EventArgs e)
        {

            int indexSelected = -1;
           for( int i = 0; i < buttons.Length;i++)
            {
                if(sender == buttons[i])
                {
                    indexSelected = i;
                }
            }

           if(indexSelected == -1)
            {
                return;
            }

            TableForm2 tableForm = new TableForm2(tables[indexSelected]);
            tableForm.Visible = true;
        }
    }
}
