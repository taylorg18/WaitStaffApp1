﻿using System;
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
    public partial class MenuForm : Form
    {
        private NumericUpDown numericUpDown1;
        private NumericUpDown numericUpDown2;
        private NumericUpDown numericUpDown3;
        private NumericUpDown numericUpDown4;
        private NumericUpDown numericUpDown5;
        private NumericUpDown numericUpDown6;
        private NumericUpDown numericUpDown7;
        private NumericUpDown numericUpDown11;
        private NumericUpDown numericUpDown12;
        private NumericUpDown numericUpDown13;
        private NumericUpDown numericUpDown14;
        private NumericUpDown numericUpDown15;
        private NumericUpDown numericUpDown16;
        private NumericUpDown numericUpDown17;
        private NumericUpDown numericUpDown18;
        private NumericUpDown numericUpDown19;
        private NumericUpDown numericUpDown20;
        private NumericUpDown numericUpDown21;
        private TextBox drinkAdultName;
        private TextBox entreeName;
        private TextBox drinkKidName;
        private TextBox soupSaladName;
        private TextBox dessertsName;
        private TextBox appetizersName;
        private TextBox textBox27;
        private TextBox textBox28;
        private TextBox textBox29;
        private TextBox textBox30;
        private TextBox textBox31;
        private TextBox textBox32;
        private TextBox textBox33;
        private TextBox textBox34;
        private TextBox textBox35;
        private TextBox textBox25;
        private TextBox textBox26;
        private TextBox textBox36;
        private TextBox textBox37;
        private TextBox textBox38;
        private TextBox textBox39;
        private TextBox textBox40;
        private TextBox textBox41;
        private TextBox textBox42;
        private Button button1;
        private TextBox textBox43;
        private TextBox textBox44;
        private TextBox textBox45;
        private TextBox textBox46;
        private TextBox textBox47;
        private TextBox textBox48;
        private Button button2;
        private MenuForm tCurrentTable = null;
       
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
        private CheckBox checkBox4;
        private CheckBox checkBox5;
        private CheckBox checkBox6;
        private CheckBox checkBox7;
        private CheckBox checkBox8;
        private CheckBox checkBox9;
        private CheckBox checkBox10;
        private CheckBox checkBox11;
        private CheckBox checkBox12;
        private CheckBox checkBox13;
        private CheckBox checkBox14;
        private CheckBox checkBox15;
        private CheckBox checkBox16;
        private CheckBox checkBox17;
        private CheckBox checkBox18;

        //===================================================
        int[] menuValues = new int[18];

        private System.Windows.Forms.TextBox[] tbFoodNames = new System.Windows.Forms.TextBox[18];



        public MenuForm()
        {
            InitializeComponent();


            //Changes all the values of the int array to 0. Used for storing the amount of orders for each item
            for (int i = 0; i < menuValues.Length; i++)
            {
                menuValues[i] = 0;
        }
        }

      

        private void button1_Click(object sender, EventArgs e)
        {

        }

      
        private void TableForm2_Load(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void InitializeComponent()
        {

            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown4 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown5 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown6 = new System.Windows.Forms.NumericUpDown();
            this.tbFoodNames[0] = new System.Windows.Forms.TextBox();
            this.tbFoodNames[1] = new System.Windows.Forms.TextBox();
            this.tbFoodNames[2] = new System.Windows.Forms.TextBox();
            this.tbFoodNames[3] = new System.Windows.Forms.TextBox();
            this.tbFoodNames[4] = new System.Windows.Forms.TextBox();
            this.tbFoodNames[5] = new System.Windows.Forms.TextBox();
            this.tbFoodNames[6] = new System.Windows.Forms.TextBox();
            this.tbFoodNames[7] = new System.Windows.Forms.TextBox();
            this.tbFoodNames[8] = new System.Windows.Forms.TextBox();
            this.tbFoodNames[9] = new System.Windows.Forms.TextBox();
            this.tbFoodNames[10] = new System.Windows.Forms.TextBox();
            this.tbFoodNames[11] = new System.Windows.Forms.TextBox();
            this.tbFoodNames[12] = new System.Windows.Forms.TextBox();
            this.tbFoodNames[13] = new System.Windows.Forms.TextBox();
            this.tbFoodNames[14] = new System.Windows.Forms.TextBox();
            this.tbFoodNames[15] = new System.Windows.Forms.TextBox();
            this.tbFoodNames[16] = new System.Windows.Forms.TextBox();
            this.tbFoodNames[17] = new System.Windows.Forms.TextBox();
            this.numericUpDown7 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown11 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown12 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown13 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown14 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown15 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown16 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown17 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown18 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown19 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown20 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown21 = new System.Windows.Forms.NumericUpDown();
            this.drinkAdultName = new System.Windows.Forms.TextBox();
            this.entreeName = new System.Windows.Forms.TextBox();
            this.drinkKidName = new System.Windows.Forms.TextBox();
            this.soupSaladName = new System.Windows.Forms.TextBox();
            this.dessertsName = new System.Windows.Forms.TextBox();
            this.appetizersName = new System.Windows.Forms.TextBox();
            this.textBox27 = new System.Windows.Forms.TextBox();
            this.textBox28 = new System.Windows.Forms.TextBox();
            this.textBox29 = new System.Windows.Forms.TextBox();
            this.textBox30 = new System.Windows.Forms.TextBox();
            this.textBox31 = new System.Windows.Forms.TextBox();
            this.textBox32 = new System.Windows.Forms.TextBox();
            this.textBox33 = new System.Windows.Forms.TextBox();
            this.textBox34 = new System.Windows.Forms.TextBox();
            this.textBox35 = new System.Windows.Forms.TextBox();
            this.textBox25 = new System.Windows.Forms.TextBox();
            this.textBox26 = new System.Windows.Forms.TextBox();
            this.textBox36 = new System.Windows.Forms.TextBox();
            this.textBox37 = new System.Windows.Forms.TextBox();
            this.textBox38 = new System.Windows.Forms.TextBox();
            this.textBox39 = new System.Windows.Forms.TextBox();
            this.textBox40 = new System.Windows.Forms.TextBox();
            this.textBox41 = new System.Windows.Forms.TextBox();
            this.textBox42 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox43 = new System.Windows.Forms.TextBox();
            this.textBox44 = new System.Windows.Forms.TextBox();
            this.textBox45 = new System.Windows.Forms.TextBox();
            this.textBox46 = new System.Windows.Forms.TextBox();
            this.textBox47 = new System.Windows.Forms.TextBox();
            this.textBox48 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.checkBox8 = new System.Windows.Forms.CheckBox();
            this.checkBox9 = new System.Windows.Forms.CheckBox();
            this.checkBox10 = new System.Windows.Forms.CheckBox();
            this.checkBox11 = new System.Windows.Forms.CheckBox();
            this.checkBox12 = new System.Windows.Forms.CheckBox();
            this.checkBox13 = new System.Windows.Forms.CheckBox();
            this.checkBox14 = new System.Windows.Forms.CheckBox();
            this.checkBox15 = new System.Windows.Forms.CheckBox();
            this.checkBox16 = new System.Windows.Forms.CheckBox();
            this.checkBox17 = new System.Windows.Forms.CheckBox();
            this.checkBox18 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown19)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown21)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(134, 38);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(43, 20);
            this.numericUpDown1.TabIndex = 2;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(134, 65);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(42, 20);
            this.numericUpDown2.TabIndex = 3;
            this.numericUpDown2.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Location = new System.Drawing.Point(133, 91);
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(44, 20);
            this.numericUpDown3.TabIndex = 4;
            this.numericUpDown3.ValueChanged += new System.EventHandler(this.numericUpDown3_ValueChanged);
            // 
            // numericUpDown4
            // 
            this.numericUpDown4.Location = new System.Drawing.Point(132, 162);
            this.numericUpDown4.Name = "numericUpDown4";
            this.numericUpDown4.Size = new System.Drawing.Size(44, 20);
            this.numericUpDown4.TabIndex = 5;
            this.numericUpDown4.ValueChanged += new System.EventHandler(this.numericUpDown4_ValueChanged);
            // 
            // numericUpDown5
            // 
            this.numericUpDown5.Location = new System.Drawing.Point(131, 189);
            this.numericUpDown5.Name = "numericUpDown5";
            this.numericUpDown5.Size = new System.Drawing.Size(44, 20);
            this.numericUpDown5.TabIndex = 6;
            this.numericUpDown5.ValueChanged += new System.EventHandler(this.numericUpDown5_ValueChanged);
            // 
            // numericUpDown6
            // 
            this.numericUpDown6.Location = new System.Drawing.Point(131, 213);
            this.numericUpDown6.Name = "numericUpDown6";
            this.numericUpDown6.Size = new System.Drawing.Size(44, 20);
            this.numericUpDown6.TabIndex = 7;
            this.numericUpDown6.ValueChanged += new System.EventHandler(this.numericUpDown6_ValueChanged);
            // 
            // appetizer1
            // 
            this.tbFoodNames[0].Location = new System.Drawing.Point(12, 38);
            this.tbFoodNames[0].Name = "appetizer1";
            this.tbFoodNames[0].ReadOnly = true;
            this.tbFoodNames[0].Size = new System.Drawing.Size(116, 20);
            this.tbFoodNames[0].TabIndex = 8;
            this.tbFoodNames[0].Text = "Chicken Nachos";
            this.tbFoodNames[0].TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbFoodNames[0].TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // appetizer2
            // 
            this.tbFoodNames[1].Location = new System.Drawing.Point(11, 65);
            this.tbFoodNames[1].Name = "appetizer2";
            this.tbFoodNames[1].ReadOnly = true;
            this.tbFoodNames[1].Size = new System.Drawing.Size(116, 20);
            this.tbFoodNames[1].TabIndex = 9;
            this.tbFoodNames[1].Text = "Deep Fried Mozarella";
            this.tbFoodNames[1].TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // appetizer3
            // 
            this.tbFoodNames[2].Location = new System.Drawing.Point(11, 91);
            this.tbFoodNames[2].Name = "appetizer3";
            this.tbFoodNames[2].ReadOnly = true;
            this.tbFoodNames[2].Size = new System.Drawing.Size(116, 20);
            this.tbFoodNames[2].TabIndex = 10;
            this.tbFoodNames[2].Text = "Spam Musubi";
            this.tbFoodNames[2].TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // soupSalad1
            // 
            this.tbFoodNames[3].Location = new System.Drawing.Point(10, 161);
            this.tbFoodNames[3].Name = "soupSalad1";
            this.tbFoodNames[3].ReadOnly = true;
            this.tbFoodNames[3].Size = new System.Drawing.Size(116, 20);
            this.tbFoodNames[3].TabIndex = 11;
            this.tbFoodNames[3].Text = "Caesar Salad";
            this.tbFoodNames[3].TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // soupSalad2
            // 
            this.tbFoodNames[4].Location = new System.Drawing.Point(10, 187);
            this.tbFoodNames[4].Name = "soupSalad2";
            this.tbFoodNames[4].ReadOnly = true;
            this.tbFoodNames[4].Size = new System.Drawing.Size(116, 20);
            this.tbFoodNames[4].TabIndex = 12;
            this.tbFoodNames[4].Text = "Mac Salad";
            this.tbFoodNames[4].TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // soupSalad3
            // 
            this.tbFoodNames[5].Location = new System.Drawing.Point(10, 213);
            this.tbFoodNames[5].Name = "soupSalad3";
            this.tbFoodNames[5].ReadOnly = true;
            this.tbFoodNames[5].Size = new System.Drawing.Size(116, 20);
            this.tbFoodNames[5].TabIndex = 13;
            this.tbFoodNames[5].Text = "Miso Soup";
            this.tbFoodNames[5].TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // entree1
            // 
            this.tbFoodNames[6].Location = new System.Drawing.Point(11, 278);
            this.tbFoodNames[6].Name = "entree1";
            this.tbFoodNames[6].ReadOnly = true;
            this.tbFoodNames[6].Size = new System.Drawing.Size(116, 20);
            this.tbFoodNames[6].TabIndex = 14;
            this.tbFoodNames[6].Text = "Loco Moco";
            this.tbFoodNames[6].TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // entree2
            // 
            this.tbFoodNames[7].Location = new System.Drawing.Point(12, 304);
            this.tbFoodNames[7].Name = "entree2";
            this.tbFoodNames[7].ReadOnly = true;
            this.tbFoodNames[7].Size = new System.Drawing.Size(116, 20);
            this.tbFoodNames[7].TabIndex = 36;
            this.tbFoodNames[7].Text = "Garlic Chicken";
            this.tbFoodNames[7].TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // entree3
            // 
            this.tbFoodNames[8].Location = new System.Drawing.Point(11, 331);
            this.tbFoodNames[8].Name = "entree3";
            this.tbFoodNames[8].ReadOnly = true;
            this.tbFoodNames[8].Size = new System.Drawing.Size(116, 20);
            this.tbFoodNames[8].TabIndex = 37;
            this.tbFoodNames[8].Text = "Cheeseburger";
            this.tbFoodNames[8].TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // desserts1
            // 
            this.tbFoodNames[9].Location = new System.Drawing.Point(11, 399);
            this.tbFoodNames[9].Name = "desserts1";
            this.tbFoodNames[9].ReadOnly = true;
            this.tbFoodNames[9].Size = new System.Drawing.Size(116, 20);
            this.tbFoodNames[9].TabIndex = 38;
            this.tbFoodNames[9].Text = "Deep Fried Oreos";
            this.tbFoodNames[9].TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // desserts2
            // 
            this.tbFoodNames[10].Location = new System.Drawing.Point(11, 425);
            this.tbFoodNames[10].Name = "desserts2";
            this.tbFoodNames[10].ReadOnly = true;
            this.tbFoodNames[10].Size = new System.Drawing.Size(116, 20);
            this.tbFoodNames[10].TabIndex = 39;
            this.tbFoodNames[10].Text = "Mochi Ice Cream";
            this.tbFoodNames[10].TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dessert3
            // 
            this.tbFoodNames[11].Location = new System.Drawing.Point(11, 451);
            this.tbFoodNames[11].Name = "dessert3";
            this.tbFoodNames[11].ReadOnly = true;
            this.tbFoodNames[11].Size = new System.Drawing.Size(116, 20);
            this.tbFoodNames[11].TabIndex = 40;
            this.tbFoodNames[11].Text = "The Tim Special";
            this.tbFoodNames[11].TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // drinkKid1
            // 
            this.tbFoodNames[12].Location = new System.Drawing.Point(443, 38);
            this.tbFoodNames[12].Name = "drinkKid1";
            this.tbFoodNames[12].ReadOnly = true;
            this.tbFoodNames[12].Size = new System.Drawing.Size(116, 20);
            this.tbFoodNames[12].TabIndex = 41;
            this.tbFoodNames[12].Text = "Coke";
            this.tbFoodNames[12].TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // drinkKid2
            // 
            this.tbFoodNames[13].Location = new System.Drawing.Point(443, 64);
            this.tbFoodNames[13].Name = "drinkKid2";
            this.tbFoodNames[13].ReadOnly = true;
            this.tbFoodNames[13].Size = new System.Drawing.Size(116, 20);
            this.tbFoodNames[13].TabIndex = 42;
            this.tbFoodNames[13].Text = "Root Beer";
            this.tbFoodNames[13].TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // drinkKid3
            // 
            this.tbFoodNames[14].Location = new System.Drawing.Point(443, 90);
            this.tbFoodNames[14].Name = "drinkKid3";
            this.tbFoodNames[14].ReadOnly = true;
            this.tbFoodNames[14].Size = new System.Drawing.Size(116, 20);
            this.tbFoodNames[14].TabIndex = 22;
            this.tbFoodNames[14].Text = "Bottled Water";
            this.tbFoodNames[14].TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // drinkAdult1
            // 
            this.tbFoodNames[15].Location = new System.Drawing.Point(443, 161);
            this.tbFoodNames[15].Name = "drinkAdult1";
            this.tbFoodNames[15].ReadOnly = true;
            this.tbFoodNames[15].Size = new System.Drawing.Size(116, 20);
            this.tbFoodNames[15].TabIndex = 23;
            this.tbFoodNames[15].Text = "Jack and Coke";
            this.tbFoodNames[15].TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // drinkAdult2
            // 
            this.tbFoodNames[16].Location = new System.Drawing.Point(443, 187);
            this.tbFoodNames[16].Name = "drinkAdult2";
            this.tbFoodNames[16].ReadOnly = true;
            this.tbFoodNames[16].Size = new System.Drawing.Size(116, 20);
            this.tbFoodNames[16].TabIndex = 24;
            this.tbFoodNames[16].Text = "Jaeger";
            this.tbFoodNames[16].TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // drinkAdult3
            // 
            this.tbFoodNames[17].Location = new System.Drawing.Point(443, 213);
            this.tbFoodNames[17].Name = "drinkAdult3";
            this.tbFoodNames[17].ReadOnly = true;
            this.tbFoodNames[17].Size = new System.Drawing.Size(116, 20);
            this.tbFoodNames[17].TabIndex = 25;
            this.tbFoodNames[17].Text = "Vodka Tonic";
            this.tbFoodNames[17].TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // numericUpDown7
            // 
            this.numericUpDown7.Location = new System.Drawing.Point(132, 279);
            this.numericUpDown7.Name = "numericUpDown7";
            this.numericUpDown7.Size = new System.Drawing.Size(44, 20);
            this.numericUpDown7.TabIndex = 15;
            this.numericUpDown7.ValueChanged += new System.EventHandler(this.numericUpDown7_ValueChanged);
            // 
            // numericUpDown11
            // 
            this.numericUpDown11.Location = new System.Drawing.Point(565, 214);
            this.numericUpDown11.Name = "numericUpDown11";
            this.numericUpDown11.Size = new System.Drawing.Size(44, 20);
            this.numericUpDown11.TabIndex = 19;
            this.numericUpDown11.ValueChanged += new System.EventHandler(this.numericUpDown11_ValueChanged);
            // 
            // numericUpDown12
            // 
            this.numericUpDown12.Location = new System.Drawing.Point(565, 187);
            this.numericUpDown12.Name = "numericUpDown12";
            this.numericUpDown12.Size = new System.Drawing.Size(44, 20);
            this.numericUpDown12.TabIndex = 18;
            this.numericUpDown12.ValueChanged += new System.EventHandler(this.numericUpDown12_ValueChanged);
            // 
            // numericUpDown13
            // 
            this.numericUpDown13.Location = new System.Drawing.Point(566, 161);
            this.numericUpDown13.Name = "numericUpDown13";
            this.numericUpDown13.Size = new System.Drawing.Size(42, 20);
            this.numericUpDown13.TabIndex = 17;
            this.numericUpDown13.ValueChanged += new System.EventHandler(this.numericUpDown13_ValueChanged);
            // 
            // numericUpDown14
            // 
            this.numericUpDown14.Location = new System.Drawing.Point(565, 90);
            this.numericUpDown14.Name = "numericUpDown14";
            this.numericUpDown14.Size = new System.Drawing.Size(42, 20);
            this.numericUpDown14.TabIndex = 16;
            this.numericUpDown14.ValueChanged += new System.EventHandler(this.numericUpDown14_ValueChanged);
            // 
            // numericUpDown15
            // 
            this.numericUpDown15.Location = new System.Drawing.Point(564, 65);
            this.numericUpDown15.Name = "numericUpDown15";
            this.numericUpDown15.Size = new System.Drawing.Size(44, 20);
            this.numericUpDown15.TabIndex = 43;
            this.numericUpDown15.ValueChanged += new System.EventHandler(this.numericUpDown15_ValueChanged);
            // 
            // numericUpDown16
            // 
            this.numericUpDown16.Location = new System.Drawing.Point(564, 38);
            this.numericUpDown16.Name = "numericUpDown16";
            this.numericUpDown16.Size = new System.Drawing.Size(44, 20);
            this.numericUpDown16.TabIndex = 35;
            this.numericUpDown16.ValueChanged += new System.EventHandler(this.numericUpDown16_ValueChanged);
            // 
            // numericUpDown17
            // 
            this.numericUpDown17.Location = new System.Drawing.Point(132, 453);
            this.numericUpDown17.Name = "numericUpDown17";
            this.numericUpDown17.Size = new System.Drawing.Size(44, 20);
            this.numericUpDown17.TabIndex = 34;
            this.numericUpDown17.ValueChanged += new System.EventHandler(this.numericUpDown17_ValueChanged);
            // 
            // numericUpDown18
            // 
            this.numericUpDown18.Location = new System.Drawing.Point(133, 426);
            this.numericUpDown18.Name = "numericUpDown18";
            this.numericUpDown18.Size = new System.Drawing.Size(44, 20);
            this.numericUpDown18.TabIndex = 33;
            this.numericUpDown18.ValueChanged += new System.EventHandler(this.numericUpDown18_ValueChanged);
            // 
            // numericUpDown19
            // 
            this.numericUpDown19.Location = new System.Drawing.Point(133, 399);
            this.numericUpDown19.Name = "numericUpDown19";
            this.numericUpDown19.Size = new System.Drawing.Size(44, 20);
            this.numericUpDown19.TabIndex = 32;
            this.numericUpDown19.ValueChanged += new System.EventHandler(this.numericUpDown19_ValueChanged);
            // 
            // numericUpDown20
            // 
            this.numericUpDown20.Location = new System.Drawing.Point(134, 331);
            this.numericUpDown20.Name = "numericUpDown20";
            this.numericUpDown20.Size = new System.Drawing.Size(42, 20);
            this.numericUpDown20.TabIndex = 31;
            this.numericUpDown20.ValueChanged += new System.EventHandler(this.numericUpDown20_ValueChanged);
            // 
            // numericUpDown21
            // 
            this.numericUpDown21.Location = new System.Drawing.Point(134, 304);
            this.numericUpDown21.Name = "numericUpDown21";
            this.numericUpDown21.Size = new System.Drawing.Size(42, 20);
            this.numericUpDown21.TabIndex = 30;
            this.numericUpDown21.ValueChanged += new System.EventHandler(this.numericUpDown21_ValueChanged);
            // 
            // drinkAdultName
            // 
            this.drinkAdultName.Location = new System.Drawing.Point(443, 135);
            this.drinkAdultName.Name = "drinkAdultName";
            this.drinkAdultName.ReadOnly = true;
            this.drinkAdultName.Size = new System.Drawing.Size(116, 20);
            this.drinkAdultName.TabIndex = 44;
            this.drinkAdultName.Text = "Drinks for Adults ";
            this.drinkAdultName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // entreeName
            // 
            this.entreeName.Location = new System.Drawing.Point(12, 252);
            this.entreeName.Name = "entreeName";
            this.entreeName.ReadOnly = true;
            this.entreeName.Size = new System.Drawing.Size(116, 20);
            this.entreeName.TabIndex = 45;
            this.entreeName.Text = "Entrees";
            this.entreeName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // drinkKidName
            // 
            this.drinkKidName.Location = new System.Drawing.Point(443, 12);
            this.drinkKidName.Name = "drinkKidName";
            this.drinkKidName.ReadOnly = true;
            this.drinkKidName.Size = new System.Drawing.Size(116, 20);
            this.drinkKidName.TabIndex = 46;
            this.drinkKidName.Text = "Drinks for Kiddies";
            this.drinkKidName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // soupSaladName
            // 
            this.soupSaladName.Location = new System.Drawing.Point(11, 135);
            this.soupSaladName.Name = "soupSaladName";
            this.soupSaladName.ReadOnly = true;
            this.soupSaladName.Size = new System.Drawing.Size(116, 20);
            this.soupSaladName.TabIndex = 47;
            this.soupSaladName.Text = "Soups and Salads";
            this.soupSaladName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dessertsName
            // 
            this.dessertsName.Location = new System.Drawing.Point(11, 373);
            this.dessertsName.Name = "dessertsName";
            this.dessertsName.ReadOnly = true;
            this.dessertsName.Size = new System.Drawing.Size(116, 20);
            this.dessertsName.TabIndex = 48;
            this.dessertsName.Text = "Desserts";
            this.dessertsName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // appetizersName
            // 
            this.appetizersName.Location = new System.Drawing.Point(11, 12);
            this.appetizersName.Name = "appetizersName";
            this.appetizersName.ReadOnly = true;
            this.appetizersName.Size = new System.Drawing.Size(116, 20);
            this.appetizersName.TabIndex = 49;
            this.appetizersName.Text = "Appetizers";
            this.appetizersName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox27
            // 
            this.textBox27.Location = new System.Drawing.Point(182, 186);
            this.textBox27.Name = "textBox27";
            this.textBox27.Size = new System.Drawing.Size(56, 20);
            this.textBox27.TabIndex = 58;
            this.textBox27.Text = "6";
            this.textBox27.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox28
            // 
            this.textBox28.Location = new System.Drawing.Point(182, 160);
            this.textBox28.Name = "textBox28";
            this.textBox28.Size = new System.Drawing.Size(56, 20);
            this.textBox28.TabIndex = 57;
            this.textBox28.Text = "8";
            this.textBox28.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox29
            // 
            this.textBox29.Location = new System.Drawing.Point(183, 89);
            this.textBox29.Name = "textBox29";
            this.textBox29.Size = new System.Drawing.Size(56, 20);
            this.textBox29.TabIndex = 56;
            this.textBox29.Text = "4";
            this.textBox29.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox30
            // 
            this.textBox30.Location = new System.Drawing.Point(183, 63);
            this.textBox30.Name = "textBox30";
            this.textBox30.Size = new System.Drawing.Size(56, 20);
            this.textBox30.TabIndex = 55;
            this.textBox30.Text = "6";
            this.textBox30.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox31
            // 
            this.textBox31.Location = new System.Drawing.Point(183, 37);
            this.textBox31.Name = "textBox31";
            this.textBox31.Size = new System.Drawing.Size(56, 20);
            this.textBox31.TabIndex = 54;
            this.textBox31.Text = "5";
            this.textBox31.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox32
            // 
            this.textBox32.Location = new System.Drawing.Point(183, 329);
            this.textBox32.Name = "textBox32";
            this.textBox32.Size = new System.Drawing.Size(56, 20);
            this.textBox32.TabIndex = 53;
            this.textBox32.Text = "12";
            this.textBox32.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox33
            // 
            this.textBox33.Location = new System.Drawing.Point(183, 303);
            this.textBox33.Name = "textBox33";
            this.textBox33.Size = new System.Drawing.Size(56, 20);
            this.textBox33.TabIndex = 52;
            this.textBox33.Text = "8";
            this.textBox33.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox34
            // 
            this.textBox34.Location = new System.Drawing.Point(183, 277);
            this.textBox34.Name = "textBox34";
            this.textBox34.Size = new System.Drawing.Size(56, 20);
            this.textBox34.TabIndex = 51;
            this.textBox34.Text = "10";
            this.textBox34.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox34.TextChanged += new System.EventHandler(this.textBox34_TextChanged);
            // 
            // textBox35
            // 
            this.textBox35.Location = new System.Drawing.Point(182, 212);
            this.textBox35.Name = "textBox35";
            this.textBox35.Size = new System.Drawing.Size(56, 20);
            this.textBox35.TabIndex = 50;
            this.textBox35.Text = "3";
            this.textBox35.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox25
            // 
            this.textBox25.Location = new System.Drawing.Point(615, 63);
            this.textBox25.Name = "textBox25";
            this.textBox25.Size = new System.Drawing.Size(56, 20);
            this.textBox25.TabIndex = 67;
            this.textBox25.Text = "2";
            // 
            // textBox26
            // 
            this.textBox26.Location = new System.Drawing.Point(615, 37);
            this.textBox26.Name = "textBox26";
            this.textBox26.Size = new System.Drawing.Size(56, 20);
            this.textBox26.TabIndex = 66;
            this.textBox26.Text = "2";
            // 
            // textBox36
            // 
            this.textBox36.Location = new System.Drawing.Point(183, 450);
            this.textBox36.Name = "textBox36";
            this.textBox36.Size = new System.Drawing.Size(56, 20);
            this.textBox36.TabIndex = 65;
            this.textBox36.Text = "200";
            // 
            // textBox37
            // 
            this.textBox37.Location = new System.Drawing.Point(183, 424);
            this.textBox37.Name = "textBox37";
            this.textBox37.Size = new System.Drawing.Size(56, 20);
            this.textBox37.TabIndex = 64;
            this.textBox37.Text = "3";
            // 
            // textBox38
            // 
            this.textBox38.Location = new System.Drawing.Point(183, 398);
            this.textBox38.Name = "textBox38";
            this.textBox38.Size = new System.Drawing.Size(56, 20);
            this.textBox38.TabIndex = 63;
            this.textBox38.Text = "5";
            // 
            // textBox39
            // 
            this.textBox39.Location = new System.Drawing.Point(615, 212);
            this.textBox39.Name = "textBox39";
            this.textBox39.Size = new System.Drawing.Size(56, 20);
            this.textBox39.TabIndex = 62;
            this.textBox39.Text = "9";
            // 
            // textBox40
            // 
            this.textBox40.Location = new System.Drawing.Point(615, 186);
            this.textBox40.Name = "textBox40";
            this.textBox40.Size = new System.Drawing.Size(56, 20);
            this.textBox40.TabIndex = 61;
            this.textBox40.Text = "10";
            // 
            // textBox41
            // 
            this.textBox41.Location = new System.Drawing.Point(615, 160);
            this.textBox41.Name = "textBox41";
            this.textBox41.Size = new System.Drawing.Size(56, 20);
            this.textBox41.TabIndex = 60;
            this.textBox41.Text = "10";
            // 
            // textBox42
            // 
            this.textBox42.Location = new System.Drawing.Point(615, 89);
            this.textBox42.Name = "textBox42";
            this.textBox42.Size = new System.Drawing.Size(56, 20);
            this.textBox42.TabIndex = 59;
            this.textBox42.Text = "1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(755, 459);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 68;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // textBox43
            // 
            this.textBox43.Location = new System.Drawing.Point(183, 11);
            this.textBox43.Name = "textBox43";
            this.textBox43.Size = new System.Drawing.Size(56, 20);
            this.textBox43.TabIndex = 69;
            this.textBox43.Text = "Price";
            this.textBox43.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox43.TextChanged += new System.EventHandler(this.textBox43_TextChanged);
            // 
            // textBox44
            // 
            this.textBox44.Location = new System.Drawing.Point(615, 135);
            this.textBox44.Name = "textBox44";
            this.textBox44.Size = new System.Drawing.Size(56, 20);
            this.textBox44.TabIndex = 70;
            this.textBox44.Text = "Price";
            this.textBox44.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox45
            // 
            this.textBox45.Location = new System.Drawing.Point(615, 12);
            this.textBox45.Name = "textBox45";
            this.textBox45.Size = new System.Drawing.Size(56, 20);
            this.textBox45.TabIndex = 71;
            this.textBox45.Text = "Price";
            this.textBox45.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox46
            // 
            this.textBox46.Location = new System.Drawing.Point(183, 373);
            this.textBox46.Name = "textBox46";
            this.textBox46.Size = new System.Drawing.Size(56, 20);
            this.textBox46.TabIndex = 72;
            this.textBox46.Text = "Price";
            this.textBox46.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox47
            // 
            this.textBox47.Location = new System.Drawing.Point(183, 251);
            this.textBox47.Name = "textBox47";
            this.textBox47.Size = new System.Drawing.Size(56, 20);
            this.textBox47.TabIndex = 73;
            this.textBox47.Text = "Price";
            this.textBox47.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox48
            // 
            this.textBox48.Location = new System.Drawing.Point(182, 134);
            this.textBox48.Name = "textBox48";
            this.textBox48.Size = new System.Drawing.Size(56, 20);
            this.textBox48.TabIndex = 74;
            this.textBox48.Text = "Price";
            this.textBox48.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(755, 426);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 75;
            this.button2.Text = "Send Order";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(257, 40);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(89, 19);
            this.checkBox1.TabIndex = 76;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(257, 63);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(89, 19);
            this.checkBox2.TabIndex = 77;
            this.checkBox2.Text = "checkBox2";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(257, 89);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(89, 19);
            this.checkBox3.TabIndex = 78;
            this.checkBox3.Text = "checkBox3";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(256, 160);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(89, 19);
            this.checkBox4.TabIndex = 81;
            this.checkBox4.Text = "checkBox4";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(256, 184);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(89, 19);
            this.checkBox5.TabIndex = 80;
            this.checkBox5.Text = "checkBox5";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Location = new System.Drawing.Point(256, 207);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(89, 19);
            this.checkBox6.TabIndex = 79;
            this.checkBox6.Text = "checkBox6";
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox7
            // 
            this.checkBox7.AutoSize = true;
            this.checkBox7.Location = new System.Drawing.Point(257, 278);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(89, 19);
            this.checkBox7.TabIndex = 84;
            this.checkBox7.Text = "checkBox7";
            this.checkBox7.UseVisualStyleBackColor = true;
            // 
            // checkBox8
            // 
            this.checkBox8.AutoSize = true;
            this.checkBox8.Location = new System.Drawing.Point(257, 303);
            this.checkBox8.Name = "checkBox8";
            this.checkBox8.Size = new System.Drawing.Size(89, 19);
            this.checkBox8.TabIndex = 83;
            this.checkBox8.Text = "checkBox8";
            this.checkBox8.UseVisualStyleBackColor = true;
            // 
            // checkBox9
            // 
            this.checkBox9.AutoSize = true;
            this.checkBox9.Location = new System.Drawing.Point(257, 326);
            this.checkBox9.Name = "checkBox9";
            this.checkBox9.Size = new System.Drawing.Size(89, 19);
            this.checkBox9.TabIndex = 82;
            this.checkBox9.Text = "checkBox9";
            this.checkBox9.UseVisualStyleBackColor = true;
            // 
            // checkBox10
            // 
            this.checkBox10.AutoSize = true;
            this.checkBox10.Location = new System.Drawing.Point(257, 398);
            this.checkBox10.Name = "checkBox10";
            this.checkBox10.Size = new System.Drawing.Size(96, 19);
            this.checkBox10.TabIndex = 87;
            this.checkBox10.Text = "checkBox10";
            this.checkBox10.UseVisualStyleBackColor = true;
            // 
            // checkBox11
            // 
            this.checkBox11.AutoSize = true;
            this.checkBox11.Location = new System.Drawing.Point(257, 421);
            this.checkBox11.Name = "checkBox11";
            this.checkBox11.Size = new System.Drawing.Size(96, 19);
            this.checkBox11.TabIndex = 86;
            this.checkBox11.Text = "checkBox11";
            this.checkBox11.UseVisualStyleBackColor = true;
            // 
            // checkBox12
            // 
            this.checkBox12.AutoSize = true;
            this.checkBox12.Location = new System.Drawing.Point(257, 450);
            this.checkBox12.Name = "checkBox12";
            this.checkBox12.Size = new System.Drawing.Size(96, 19);
            this.checkBox12.TabIndex = 85;
            this.checkBox12.Text = "checkBox12";
            this.checkBox12.UseVisualStyleBackColor = true;
            // 
            // checkBox13
            // 
            this.checkBox13.AutoSize = true;
            this.checkBox13.Location = new System.Drawing.Point(694, 37);
            this.checkBox13.Name = "checkBox13";
            this.checkBox13.Size = new System.Drawing.Size(96, 19);
            this.checkBox13.TabIndex = 90;
            this.checkBox13.Text = "checkBox13";
            this.checkBox13.UseVisualStyleBackColor = true;
            // 
            // checkBox14
            // 
            this.checkBox14.AutoSize = true;
            this.checkBox14.Location = new System.Drawing.Point(694, 63);
            this.checkBox14.Name = "checkBox14";
            this.checkBox14.Size = new System.Drawing.Size(96, 19);
            this.checkBox14.TabIndex = 89;
            this.checkBox14.Text = "checkBox14";
            this.checkBox14.UseVisualStyleBackColor = true;
            // 
            // checkBox15
            // 
            this.checkBox15.AutoSize = true;
            this.checkBox15.Location = new System.Drawing.Point(694, 90);
            this.checkBox15.Name = "checkBox15";
            this.checkBox15.Size = new System.Drawing.Size(96, 19);
            this.checkBox15.TabIndex = 88;
            this.checkBox15.Text = "checkBox15";
            this.checkBox15.UseVisualStyleBackColor = true;
            // 
            // checkBox16
            // 
            this.checkBox16.AutoSize = true;
            this.checkBox16.Location = new System.Drawing.Point(694, 161);
            this.checkBox16.Name = "checkBox16";
            this.checkBox16.Size = new System.Drawing.Size(96, 19);
            this.checkBox16.TabIndex = 93;
            this.checkBox16.Text = "checkBox16";
            this.checkBox16.UseVisualStyleBackColor = true;
            // 
            // checkBox17
            // 
            this.checkBox17.AutoSize = true;
            this.checkBox17.Location = new System.Drawing.Point(694, 185);
            this.checkBox17.Name = "checkBox17";
            this.checkBox17.Size = new System.Drawing.Size(96, 19);
            this.checkBox17.TabIndex = 92;
            this.checkBox17.Text = "checkBox17";
            this.checkBox17.UseVisualStyleBackColor = true;
            // 
            // checkBox18
            // 
            this.checkBox18.AutoSize = true;
            this.checkBox18.Location = new System.Drawing.Point(694, 208);
            this.checkBox18.Name = "checkBox18";
            this.checkBox18.Size = new System.Drawing.Size(96, 19);
            this.checkBox18.TabIndex = 91;
            this.checkBox18.Text = "checkBox18";
            this.checkBox18.UseVisualStyleBackColor = true;
            // 
            // MenuForm
            // 
            this.ClientSize = new System.Drawing.Size(873, 510);
            this.Controls.Add(this.checkBox16);
            this.Controls.Add(this.checkBox17);
            this.Controls.Add(this.checkBox18);
            this.Controls.Add(this.checkBox13);
            this.Controls.Add(this.checkBox14);
            this.Controls.Add(this.checkBox15);
            this.Controls.Add(this.checkBox10);
            this.Controls.Add(this.checkBox11);
            this.Controls.Add(this.checkBox12);
            this.Controls.Add(this.checkBox7);
            this.Controls.Add(this.checkBox8);
            this.Controls.Add(this.checkBox9);
            this.Controls.Add(this.checkBox4);
            this.Controls.Add(this.checkBox5);
            this.Controls.Add(this.checkBox6);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox48);
            this.Controls.Add(this.textBox47);
            this.Controls.Add(this.textBox46);
            this.Controls.Add(this.textBox45);
            this.Controls.Add(this.textBox44);
            this.Controls.Add(this.textBox43);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox25);
            this.Controls.Add(this.textBox26);
            this.Controls.Add(this.textBox36);
            this.Controls.Add(this.textBox37);
            this.Controls.Add(this.textBox38);
            this.Controls.Add(this.textBox39);
            this.Controls.Add(this.textBox40);
            this.Controls.Add(this.textBox41);
            this.Controls.Add(this.textBox42);
            this.Controls.Add(this.textBox27);
            this.Controls.Add(this.textBox28);
            this.Controls.Add(this.textBox29);
            this.Controls.Add(this.textBox30);
            this.Controls.Add(this.textBox31);
            this.Controls.Add(this.textBox32);
            this.Controls.Add(this.textBox33);
            this.Controls.Add(this.textBox34);
            this.Controls.Add(this.textBox35);
            this.Controls.Add(this.appetizersName);
            this.Controls.Add(this.dessertsName);
            this.Controls.Add(this.soupSaladName);
            this.Controls.Add(this.drinkKidName);
            this.Controls.Add(this.entreeName);
            this.Controls.Add(this.drinkAdultName);
            this.Controls.Add(this.numericUpDown15);
            this.Controls.Add(this.tbFoodNames[13]);
            this.Controls.Add(this.tbFoodNames[12]);
            this.Controls.Add(this.tbFoodNames[11]);
            this.Controls.Add(this.tbFoodNames[10]);
            this.Controls.Add(this.tbFoodNames[9]);
            this.Controls.Add(this.tbFoodNames[8]);
            this.Controls.Add(this.tbFoodNames[7]);
            this.Controls.Add(this.numericUpDown16);
            this.Controls.Add(this.numericUpDown17);
            this.Controls.Add(this.numericUpDown18);
            this.Controls.Add(this.numericUpDown19);
            this.Controls.Add(this.numericUpDown20);
            this.Controls.Add(this.numericUpDown21);
            this.Controls.Add(this.tbFoodNames[17]);
            this.Controls.Add(this.tbFoodNames[16]);
            this.Controls.Add(this.tbFoodNames[15]);
            this.Controls.Add(this.tbFoodNames[14]);
            this.Controls.Add(this.numericUpDown11);
            this.Controls.Add(this.numericUpDown12);
            this.Controls.Add(this.numericUpDown13);
            this.Controls.Add(this.numericUpDown14);
            this.Controls.Add(this.numericUpDown7);
            this.Controls.Add(this.tbFoodNames[6]);
            this.Controls.Add(this.tbFoodNames[5]);
            this.Controls.Add(this.tbFoodNames[4]);
            this.Controls.Add(this.tbFoodNames[3]);
            this.Controls.Add(this.tbFoodNames[2]);
            this.Controls.Add(this.tbFoodNames[1]);
            this.Controls.Add(this.tbFoodNames[0]);
            this.Controls.Add(this.numericUpDown6);
            this.Controls.Add(this.numericUpDown5);
            this.Controls.Add(this.numericUpDown4);
            this.Controls.Add(this.numericUpDown3);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.numericUpDown1);
            this.Name = "MenuForm";
            this.Load += new System.EventHandler(this.MenuForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown19)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown21)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            tbFoodNames[0].Text = "Schmittyz Chicken";
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox43_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox34_TextChanged(object sender, EventArgs e)
        {

        }


        //send order button
        private void button2_Click(object sender, EventArgs e)
        {
            System.IO.File.WriteAllText(@"C:\waitData\MenuItemOrdered.txt", "");

            for (int i = 0; i < menuValues.Length; i++)
            {
                if ( menuValues[i] != 0 && menuValues[i] >0)
                {   

                    {
                        //gonna decide how to get the names in there later when I do the importing of menuItems from the txt file
                        string Orders = "chickenFingers," + menuValues[i] + "\r\n";
                        System.IO.File.AppendAllText(@"C:\waitData\MenuItemOrdered.txt", Orders);
                    }

                }
            }

        }

        //Button for closing the order screen
        private void button1_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        //==================================================================================Numeric up/downs===========================
        //Numeric up/down for the first menu item
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
           // if (item1Available == true)
           if (checkBox1.CheckState != CheckState.Checked)
            {
                menuValues[0] = (int)numericUpDown1.Value;
            }
            else
            {
                numericUpDown1.Value = 0;
                menuValues[0] = 0;

            }

        }
        //Not sure how these got here=========================

        private void MenuForm_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
        //=================================================

        //Numeric up/down for the second menu item
        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            if (checkBox2.CheckState != CheckState.Checked)
            {
                menuValues[1] = (int)numericUpDown2.Value;
            }
            else
            {
                numericUpDown2.Value = 0;
                menuValues[1] = 0;

            }
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            if (checkBox3.CheckState != CheckState.Checked)
            {
                menuValues[2] = (int)numericUpDown3.Value;
            }
            else
            {
                numericUpDown3.Value = 0;
                menuValues[2] = 0;
            }
        }


        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {
            if (checkBox4.CheckState != CheckState.Checked)
            {
                menuValues[3] = (int)numericUpDown4.Value;
            }
            else
            {
                numericUpDown4.Value = 0;
                menuValues[3] = 0;
            }
        }

        private void numericUpDown5_ValueChanged(object sender, EventArgs e)
        {
            if (checkBox5.CheckState != CheckState.Checked)
            {
                menuValues[4] = (int)numericUpDown5.Value;
            }
            else
            {
                numericUpDown5.Value = 0;
                menuValues[4] = 0;
            }
        }

        private void numericUpDown6_ValueChanged(object sender, EventArgs e)
        {
            if (checkBox6.CheckState != CheckState.Checked)
            {
                menuValues[5] = (int)numericUpDown6.Value;
            }
            else
            {
                numericUpDown6.Value = 0;
                menuValues[5] = 0;

            }
        }

        private void numericUpDown7_ValueChanged(object sender, EventArgs e)
        {
            if (checkBox7.CheckState != CheckState.Checked)
            {
                menuValues[6] = (int)numericUpDown7.Value;
            }
            else
            {
                numericUpDown7.Value = 0;
                menuValues[6] = 0;

            }
        }
       
        //The eighth one... Not sure how it became 21
        private void numericUpDown21_ValueChanged(object sender, EventArgs e)
        {
            if (checkBox8.CheckState != CheckState.Checked)
            {
                menuValues[7] = (int)numericUpDown21.Value;
            }
            else
            {
                numericUpDown21.Value = 0;
                menuValues[7] = 0;
            }
        }


        //The ninth one
        private void numericUpDown20_ValueChanged(object sender, EventArgs e)
        {
            if (checkBox9.CheckState != CheckState.Checked)
            {
                menuValues[8] = (int)numericUpDown20.Value;
            }
            else
            {
                numericUpDown20.Value = 0;
                menuValues[8] = 0;
            }
        }
        //The tenth one
        private void numericUpDown19_ValueChanged(object sender, EventArgs e)
        {
            if (checkBox10.CheckState != CheckState.Checked)
            {
                menuValues[9] = (int)numericUpDown19.Value;
            }
            else
            {
                numericUpDown19.Value = 0;
                menuValues[9] = 0;
            }
        }
        //11
        private void numericUpDown18_ValueChanged(object sender, EventArgs e)
        {
            if (checkBox11.CheckState != CheckState.Checked)
            {
                menuValues[10] = (int)numericUpDown18.Value;
            }
            else
            {
                numericUpDown18.Value = 0;
                menuValues[10] = 0;
            }
        }
        //12
        private void numericUpDown17_ValueChanged(object sender, EventArgs e)
        {
            if (checkBox12.CheckState != CheckState.Checked)
            {
                menuValues[11] = (int)numericUpDown17.Value;
            }
            else
            {
                numericUpDown17.Value = 0;
                menuValues[11] = 0;
            }
        }
        //13
        private void numericUpDown16_ValueChanged(object sender, EventArgs e)
        {
            if (checkBox13.CheckState != CheckState.Checked)
            {
                menuValues[12] = (int)numericUpDown16.Value;
            }
            else
            {
                numericUpDown16.Value = 0;
                menuValues[12] = 0;
            }
        }
        //14
        private void numericUpDown15_ValueChanged(object sender, EventArgs e)
        {
            if (checkBox14.CheckState != CheckState.Checked)
            {
                menuValues[13] = (int)numericUpDown15.Value;
            }
            else
            {
                numericUpDown15.Value = 0;
                menuValues[13] = 0;
            }
        }
        //15
        private void numericUpDown14_ValueChanged(object sender, EventArgs e)
        {
            if (checkBox15.CheckState != CheckState.Checked)
            {
                menuValues[14] = (int)numericUpDown14.Value;
            }
            else
            {
                numericUpDown14.Value = 0;
                menuValues[14] = 0;
            }
        }
        //16
        private void numericUpDown13_ValueChanged(object sender, EventArgs e)
        {
            if (checkBox16.CheckState != CheckState.Checked)
            {
                menuValues[15] = (int)numericUpDown13.Value;
            }
            else
            {
                numericUpDown13.Value = 0;
                menuValues[15] = 0;
            }
        }

      
        //17
        private void numericUpDown12_ValueChanged(object sender, EventArgs e)
        {
            if (checkBox17.CheckState != CheckState.Checked)
            {
                menuValues[16] = (int)numericUpDown12.Value;
            }
            else
            {
                numericUpDown12.Value = 0;
                menuValues[16] = 0;
            }
        }

        //18
        private void numericUpDown11_ValueChanged(object sender, EventArgs e)
        {
            if (checkBox18.CheckState != CheckState.Checked)
            {
                menuValues[17] = (int)numericUpDown11.Value;
            }
            else
            {
                numericUpDown11.Value = 0;
                menuValues[17] = 0;
            }
        }










    }
}