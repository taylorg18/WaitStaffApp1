using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



/*
    Form1 - This is the main/initial Form that handles the update of the tables and handles our outputs to various groups.

    Created By: Grayson Taylor, Michael Larios, Alex Reinemann, Michael Liao

    */
namespace WaitStaffApplicataion
{
    public partial class Sections : Form
    {
        
        Table[] tables = new Table[16]; //an array representing the table objects for the restaurant 
        Button[] buttons; //the buttons for the tables on the form
        Employee[] staff = new Employee[5]; //an array representing the Waitstaff of the restaurant

        /*
            Constructor
            Initializes the buttons and creates all objects necessary for the program
        */
        public Sections()
        {
            InitializeComponent();
            buttons = new Button[16]{tableButton1, tableButton2, tableButton3, tableButton4, tableButton5, tableButton6,  tableButton7,
                    tableButton8, tableButton9, tableButton10, tableButton11, tableButton12,  tableButton13, tableButton14,
                    tableButton15, toGoTable};

            //update button names
            for(int i = 0; i < buttons.Length;i++)
            {
                buttons[i].Text = "Table " + (i+1);
                buttons[i].BackColor = Color.Green;
            }
            buttons[15].Text = "TOGO";

            //initialize the staff members            
            for(int i = 0; i < staff.Length; i++)
            {
                staff[i] = new Employee("Employee " + (i + 1));
            }

            //initialize the table objects
            for (int i = 0; i < tables.Length; i++)
            {
                tables[i] = new Table();
                tables[i].setTableNum(i + 1);
                
                //set certain employees to their corresponding tables
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

        //N/A
        private void Form1_Load(object sender, EventArgs e)
        {

        }

 
        //N/A
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        /*
            Handles a click for one of the buttons that represents the tables

            It sends the user to the table information form
        */
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
            //creates form based on which table was clicked
            TableForm2 tableForm = new TableForm2(tables[indexSelected], buttons[indexSelected]);
            tableForm.Visible = true;
        }

        /*
            Handles refreshing the table information has recieved by the reception
        */
        private void refreshButton_Click(object sender, EventArgs e)
        {
            string userName = Environment.UserName;
            Console.WriteLine(userName);
            string[] recInput = System.IO.File.ReadAllLines(@"C:\Users\" + userName + @"\Dropbox\CS 341\Waitstaff\recWait.txt");
            Table temp = null;
            int counter = 0;
            //parses the file from reception
            foreach (string tableInfo in recInput)
            {
                Console.WriteLine("\t" + tableInfo);
                //goes through and gets the required information from each line
               
                if (tableInfo == "" && temp != null) 
                {
                    buttons[temp.getTableNum()-1].BackColor = Color.Red;
                    buttons[temp.getTableNum() - 1].Text = "" + temp.getNumPeople();
                    counter = 0;
                    continue;
                }
                if(counter == 0)
                {
                    if(tableInfo == "" || Int32.Parse(tableInfo) > 17) 
                    {
                        break;
                    }

                    if(Int32.Parse(tableInfo) == 17)
                    {
                        temp = tables[15];
                    }
                    else
                    {
                        temp = tables[Int32.Parse(tableInfo) - 1];
                    }
                    temp.updateTableStatus();
                    
                }
                else if(temp == tables[15])
                {

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
            System.IO.File.WriteAllLines((@"C:\Users\" + userName + @"\Dropbox\CS 341\Waitstaff\recWait.txt"), new string[]{""});
        }

        /*
            Sends our current tables statuses to Reception
        */
        private void updateRec_Click(object sender, EventArgs e)
        {
            string userName = Environment.UserName;
            System.IO.File.WriteAllText((@"C:\Users\" + userName + @"\Dropbox\CS 341\Reception\waitRec.txt"), "");

            //if a table is open put in file
            foreach (Table holderTable in tables)
            {
                if (holderTable.getTableStatus() == 0)
                {
                    string holderAddedLine = holderTable.getTableNum() + "\r\n";
                    System.IO.File.AppendAllText((@"C:\Users\" + userName + @"\Dropbox\CS 341\Reception\waitRec.txt"), holderAddedLine);
                }
            }

            System.IO.File.AppendAllText((@"C:\Users\" + userName + @"\Dropbox\CS 341\Reception\waitRec.txt"), "\r\n");


        }

        /*
            Sends our outputs to Management.
            This will include order information and tips.
        */
        private void updateMan_Click(object sender, EventArgs e)
        {
            string userName = Environment.UserName;
            //System.IO.File.WriteAllText((@"C:\Users\" + userName + @"\Dropbox\CS 341\Management\waitMan.txt"), "");
            string dayOweek = DateTime.Now.DayOfWeek.ToString();
            dayOweek = dayOweek.ToUpper().Substring(0,3);

            Double totalTips = 0;
            //
            foreach( Employee emp in staff)
            {
                totalTips += emp.getTips();
            }


            string empLine = dayOweek + "," + "," + "totaltips" + "\r\n";
           // System.IO.File.AppendAllText((@"C:\Users\" + userName + @"\Dropbox\CS 341\Management\waitMan.txt"), empLine);



        }
    }
}
