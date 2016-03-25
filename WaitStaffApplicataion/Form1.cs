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
        Employee[] staff = new Employee[5];
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

          
            
            for(int i = 0; i < staff.Length; i++)
            {
                staff[i] = new Employee("Employee " + (i + 1));
            }


            for (int i = 0; i < tables.Length; i++)
            {
                tables[i] = new Table();
                tables[i].setTableNum(i + 1);
                
                if(i < 3)
                {
                    tables[i].setEmployee(staff[0]);
                }
                else if( i < 6 )
                {
                    tables[i].setEmployee(staff[1]);
                }
                else if( i < 9)
                {
                    tables[i].setEmployee(staff[2]);
                }
                else if( i < 12)
                {
                    tables[i].setEmployee(staff[3]);
                }
                else if( i < 15)
                {
                    tables[i].setEmployee(staff[4]);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

 
        //comemnt
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

            TableForm2 tableForm = new TableForm2(tables[indexSelected], buttons[indexSelected]);
            tableForm.Visible = true;
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            string[] recInput = System.IO.File.ReadAllLines(@"C:\waitData\recwait.txt");
            Table temp = null;
            int counter = 0;
            foreach (string tableInfo in recInput)
            {
                Console.WriteLine("\t" + tableInfo);
                if (tableInfo == "" && temp != null) 
                {
                    buttons[temp.getTableNum()-1].BackColor = Color.Red;
                    buttons[temp.getTableNum() - 1].Text = "" + temp.getNumPeople();
                    counter = 0;
                    continue;
                }
                if(counter == 0)
                {
                    if(tableInfo == "" || Int32.Parse(tableInfo) > 15) 
                    {
                        break;
                    }

                    temp = tables[Int32.Parse(tableInfo)-1];
                    temp.updateTableStatus();
                    
                }
                else if(counter == 1)
                {
                    temp.setNumPeople(Int32.Parse(tableInfo));
                }
                else if(counter == 2)
                {
                    temp.setSpecial(tableInfo);
                }
                else
                {
                    tables[Int32.Parse(tableInfo)-1].setMerged();
                    tables[Int32.Parse(tableInfo)-1].setTableMerged(temp.getTableNum());
                    buttons[Int32.Parse(tableInfo)-1].BackColor = Color.DarkGray;
                }
                counter++;          
            }
            System.IO.File.WriteAllLines(@"C:\waitData\recwait.txt", new string[]{""});
        }

        private void updateRec_Click(object sender, EventArgs e)
        {
            System.IO.File.WriteAllText(@"C:\waitData\tablesOpen.txt", "");

            foreach (Table holderTable in tables)
            {
                if (holderTable.getTableStatus() == 0)
                {
                    string holderAddedLine = holderTable.getTableNum() + "\r\n";
                    System.IO.File.AppendAllText(@"C:\waitData\tablesOpen.txt", holderAddedLine);
                }
            }

            System.IO.File.AppendAllText(@"C:\waitData\tablesOpen.txt", "\r\n");


        }

        private void updateMan_Click(object sender, EventArgs e)
        {
            System.IO.File.WriteAllText(@"C:\waitData\waitMan.txt", "");
            string dayOweek = DateTime.Now.DayOfWeek.ToString();
            dayOweek = dayOweek.ToUpper().Substring(0,3);
            foreach( Employee emp in staff)
            {
                string empLine = dayOweek + "," + emp.getName() + "," + emp.getTips() + "\r\n";
                System.IO.File.AppendAllText(@"C:\waitData\waitMan.txt", empLine);
            }

            
        }
    }
}
