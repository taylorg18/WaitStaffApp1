﻿using System;
using System.Collections;
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

        FoodMenu menu;
        Table[] tables = new Table[16]; //an array representing the table objects for the restaurant 
        Button[] buttons; //the buttons for the tables on the form
        Employee[] staff = new Employee[5]; //an array representing the Waitstaff of the restaurant
        PictureBox[] tableBoxes;
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

            tableBoxes = new PictureBox[16]{pictureBox1,pictureBox2,pictureBox3,pictureBox4,pictureBox5,pictureBox6,pictureBox7,
                        pictureBox8,pictureBox9,pictureBox10,pictureBox11,pictureBox12,pictureBox13,pictureBox14,pictureBox15,pictureBox16};
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


            string userName = Environment.UserName;
            Console.WriteLine(userName);
            string[] menuFile = System.IO.File.ReadAllLines(@"C:\Users\" + userName + @"\Dropbox\CS 341\Waitstaff\menu.txt");
            menu = new FoodMenu(19);
            FoodItem temp;
            for(int i = 0; i < menuFile.Length; i+=4)
            {
                try
                {
                    Console.WriteLine("" + menuFile[i] + " "+ Int32.Parse(menuFile[i + 1]) + " " +Int32.Parse(menuFile[i + 2]));
                    temp = new FoodItem(menuFile[i], Int32.Parse(menuFile[i + 1]), Int32.Parse(menuFile[i + 2]));
                    menu.addItem(temp);
                   
                }
                catch(Exception e)
                {
                    break;
                }
            }

            for(int i = 0; i < 19; i++)
            {
                if(menu.getFoodItem(i) == null)
                {
                    temp = new FoodItem("0", 0, 0);
                    menu.addItem(temp);
                    
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

            tableBoxes[indexSelected].BackColor = Color.Silver;
            //creates form based on which table was clicked
            TableForm2 tableForm = new TableForm2(tables[indexSelected], buttons[indexSelected], menu);
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
            String toGo = "";
            //parses the file from reception
            foreach (string tableInfo in recInput)
            {
                Console.WriteLine("\t" + tableInfo);
                //goes through and gets the required information from each line
               
                if (tableInfo == "" && temp != null) 
                {
                    //check if its a toGo order
                    if(temp == tables[15])
                    {
                        temp.setSpecial(toGo);
                    }
                    //set to the table being occupied
                    buttons[temp.getTableNum()-1].BackColor = Color.Red;
                    buttons[temp.getTableNum() - 1].Text = "" + temp.getNumPeople();
                    counter = 0;
                    continue;
                }
                if (counter == 0)
                {
                    //look for empty table
                    if (tableInfo == "" || Int32.Parse(tableInfo) > 17)
                    {
                        break;
                    }

                    //check for togo order
                    if(Int32.Parse(tableInfo) == 17)
                    {
                        temp = tables[15];

                    }
                    else
                    {
                        //get the table
                        temp = tables[Int32.Parse(tableInfo) - 1];
                    }
                    temp.updateTableStatus();

                }
                else if (counter == 1)
                {
                    //check for a togo order
                    if (temp == tables[15])
                    {
                        toGo += tableInfo;
                    }
                    else
                    {
                        //set the number of people at the table
                        temp.setNumPeople(Int32.Parse(tableInfo));
                    }
                }
                else if (counter == 2)
                {
                    //check for togo order
                    if(temp == tables[15])
                    {
                        toGo += tableInfo + "\r\n";
                    }
                    else
                    {
                        //set the special requests
                        temp.setSpecial(tableInfo);
                    }
                    
                }
                else
                {
                    //once again check for togo order
                    if(temp == tables[15])
                    {
                        toGo += tableInfo + "\r\n";
                    }
                    else
                    {
                        //check for any merged tables
                        tables[Int32.Parse(tableInfo) - 1].setMerged();
                        tables[Int32.Parse(tableInfo) - 1].setTableMerged(temp.getTableNum());
                        buttons[Int32.Parse(tableInfo) - 1].BackColor = Color.DarkGray;
                    }
                }
                counter++;          
            }
            System.IO.File.Delete((@"C:\Users\" + userName + @"\Dropbox\CS 341\Waitstaff\recWait.txt"));
        }

        /*
            Updates all the orders to see if any of the orders caused errors and cannot be fulfilled.
        */
        private void updateRec_Click(object sender, EventArgs e)
        {
            string userName = Environment.UserName;
            string[] cookInput = System.IO.File.ReadAllLines(@"C:\Users\" + userName + @"\Dropbox\CS 341\Waitstaff\CookWait.txt");
            int tableNum = -1;
            string itemOrdered;
            string canMake;
            int commaIndex;
           
            foreach(string input in cookInput)
            {
                try
                {
                    //check if the line is a number
                    tableNum = Int32.Parse(input);
                    continue;
                }
                catch(Exception error)
                {
                    
                }
                try
                {
                    //split the item between the namem and whether or not it was fulfilled
                    commaIndex = input.IndexOf(",");
                    itemOrdered = input.Substring(0, commaIndex);
                    Console.WriteLine(itemOrdered);
                    canMake = input.Substring(commaIndex + 1);

                    if (canMake == "y")
                    {
                        //do nothing
                    }
                    else
                    {

                        tableBoxes[tableNum - 1].BackColor = Color.Red;

                        if (tables[tableNum - 1].getReceipt().getItem(itemOrdered) != null)
                        {
                            menu.undoBuy(tables[tableNum - 1].getReceipt().getItem(itemOrdered),
                                tables[tableNum - 1].getReceipt().getItem(itemOrdered).getSold() - 1);

                            tables[tableNum - 1].getReceipt().removeAllItem(menu.getFoodItem(itemOrdered));
                        }
                        menu.outOfStock(itemOrdered);

                    }

                }
                catch(Exception excep)
                {

                }

            }
            //clear file
            System.IO.File.Delete(@"C:\Users\" + userName + @"\Dropbox\CS 341\Waitstaff\CookWait.txt");

        }

        /*
            Sends our outputs to Management.
            This will include order information and tips.
        */
        private void updateMan_Click(object sender, EventArgs e)
        {
            string userName = Environment.UserName;
           
            string dayOweek = DateTime.Now.DayOfWeek.ToString();
            dayOweek = dayOweek.ToUpper().Substring(0,3);

            int totalTips = 0;
            //get all the tips from the employees
            foreach( Employee emp in staff)
            {
                totalTips += (int)emp.getTips();
            }


            string empLine;
            for (int i = 0; i < menu.getNumItems(); i++)
            {
                if(menu.getFoodItem(i).getName() == "0")
                {
                    continue;
                }

                if(menu.getFoodItem(i).getSold() < 0)
                {
                    menu.getFoodItem(i).setAmountSold(0);
                }
                empLine = dayOweek + "," + menu.getFoodItem(i).getName() +","+ menu.getFoodItem(i).getPrice() +","+menu.getFoodItem(i).getSold() + "," + totalTips + "\r\n";
                totalTips = 0;
                System.IO.File.AppendAllText((@"C:\Users\" + userName + @"\Dropbox\CS 341\Management\WaitStaffManagement.txt"), empLine);

            }

            


        }
    }
}
