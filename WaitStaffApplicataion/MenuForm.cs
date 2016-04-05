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
    public partial class MenuForm : Form
    {
        private NumericUpDown numericUpDown1;
        private NumericUpDown numericUpDown2;
        private NumericUpDown numericUpDown3;
        private NumericUpDown numericUpDown4;
        private NumericUpDown numericUpDown5;
        private NumericUpDown numericUpDown6;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox7;
        private NumericUpDown numericUpDown7;
        private TextBox textBox11;
        private TextBox textBox12;
        private TextBox textBox13;
        private TextBox textBox14;
        private NumericUpDown numericUpDown11;
        private NumericUpDown numericUpDown12;
        private NumericUpDown numericUpDown13;
        private NumericUpDown numericUpDown14;
        private NumericUpDown numericUpDown15;
        private TextBox textBox15;
        private TextBox textBox16;
        private TextBox textBox17;
        private TextBox textBox18;
        private TextBox textBox19;
        private TextBox textBox20;
        private TextBox textBox21;
        private NumericUpDown numericUpDown16;
        private NumericUpDown numericUpDown17;
        private NumericUpDown numericUpDown18;
        private NumericUpDown numericUpDown19;
        private NumericUpDown numericUpDown20;
        private NumericUpDown numericUpDown21;
        private TextBox textBox8;
        private TextBox textBox9;
        private TextBox textBox10;
        private TextBox textBox22;
        private TextBox textBox23;
        private TextBox textBox24;
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
        //===================================================
        int[] menuValues = new int[15];



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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.numericUpDown7 = new System.Windows.Forms.NumericUpDown();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.numericUpDown11 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown12 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown13 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown14 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown15 = new System.Windows.Forms.NumericUpDown();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.textBox16 = new System.Windows.Forms.TextBox();
            this.textBox17 = new System.Windows.Forms.TextBox();
            this.textBox18 = new System.Windows.Forms.TextBox();
            this.textBox19 = new System.Windows.Forms.TextBox();
            this.textBox20 = new System.Windows.Forms.TextBox();
            this.textBox21 = new System.Windows.Forms.TextBox();
            this.numericUpDown16 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown17 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown18 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown19 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown20 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown21 = new System.Windows.Forms.NumericUpDown();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox22 = new System.Windows.Forms.TextBox();
            this.textBox23 = new System.Windows.Forms.TextBox();
            this.textBox24 = new System.Windows.Forms.TextBox();
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
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Location = new System.Drawing.Point(133, 91);
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(44, 20);
            this.numericUpDown3.TabIndex = 4;
            // 
            // numericUpDown4
            // 
            this.numericUpDown4.Location = new System.Drawing.Point(133, 213);
            this.numericUpDown4.Name = "numericUpDown4";
            this.numericUpDown4.Size = new System.Drawing.Size(44, 20);
            this.numericUpDown4.TabIndex = 5;
            // 
            // numericUpDown5
            // 
            this.numericUpDown5.Location = new System.Drawing.Point(132, 240);
            this.numericUpDown5.Name = "numericUpDown5";
            this.numericUpDown5.Size = new System.Drawing.Size(44, 20);
            this.numericUpDown5.TabIndex = 6;
            // 
            // numericUpDown6
            // 
            this.numericUpDown6.Location = new System.Drawing.Point(132, 264);
            this.numericUpDown6.Name = "numericUpDown6";
            this.numericUpDown6.Size = new System.Drawing.Size(44, 20);
            this.numericUpDown6.TabIndex = 7;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 38);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(116, 20);
            this.textBox1.TabIndex = 8;
            this.textBox1.Text = "Chicken Nachos";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(11, 65);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(116, 20);
            this.textBox2.TabIndex = 9;
            this.textBox2.Text = "Deep Fried Mozarella";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(11, 91);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(116, 20);
            this.textBox3.TabIndex = 10;
            this.textBox3.Text = "Spam Musubi";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(11, 212);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(116, 20);
            this.textBox4.TabIndex = 11;
            this.textBox4.Text = "Caesar Salad";
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(11, 238);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(116, 20);
            this.textBox5.TabIndex = 12;
            this.textBox5.Text = "Mac Salad";
            this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(11, 264);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(116, 20);
            this.textBox6.TabIndex = 13;
            this.textBox6.Text = "Miso Soup";
            this.textBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(11, 373);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(116, 20);
            this.textBox7.TabIndex = 14;
            this.textBox7.Text = "Loco Moco";
            this.textBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // numericUpDown7
            // 
            this.numericUpDown7.Location = new System.Drawing.Point(132, 374);
            this.numericUpDown7.Name = "numericUpDown7";
            this.numericUpDown7.Size = new System.Drawing.Size(44, 20);
            this.numericUpDown7.TabIndex = 15;
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(467, 425);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(116, 20);
            this.textBox11.TabIndex = 25;
            this.textBox11.Text = "Vodka Tonic";
            this.textBox11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox12
            // 
            this.textBox12.Location = new System.Drawing.Point(467, 399);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(116, 20);
            this.textBox12.TabIndex = 24;
            this.textBox12.Text = "Jaeger";
            this.textBox12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox13
            // 
            this.textBox13.Location = new System.Drawing.Point(467, 373);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(116, 20);
            this.textBox13.TabIndex = 23;
            this.textBox13.Text = "Jack and Coke";
            this.textBox13.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox14
            // 
            this.textBox14.Location = new System.Drawing.Point(467, 264);
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(116, 20);
            this.textBox14.TabIndex = 22;
            this.textBox14.Text = "Bottled Water";
            this.textBox14.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // numericUpDown11
            // 
            this.numericUpDown11.Location = new System.Drawing.Point(589, 426);
            this.numericUpDown11.Name = "numericUpDown11";
            this.numericUpDown11.Size = new System.Drawing.Size(44, 20);
            this.numericUpDown11.TabIndex = 19;
            // 
            // numericUpDown12
            // 
            this.numericUpDown12.Location = new System.Drawing.Point(589, 399);
            this.numericUpDown12.Name = "numericUpDown12";
            this.numericUpDown12.Size = new System.Drawing.Size(44, 20);
            this.numericUpDown12.TabIndex = 18;
            // 
            // numericUpDown13
            // 
            this.numericUpDown13.Location = new System.Drawing.Point(590, 373);
            this.numericUpDown13.Name = "numericUpDown13";
            this.numericUpDown13.Size = new System.Drawing.Size(42, 20);
            this.numericUpDown13.TabIndex = 17;
            // 
            // numericUpDown14
            // 
            this.numericUpDown14.Location = new System.Drawing.Point(589, 264);
            this.numericUpDown14.Name = "numericUpDown14";
            this.numericUpDown14.Size = new System.Drawing.Size(42, 20);
            this.numericUpDown14.TabIndex = 16;
            // 
            // numericUpDown15
            // 
            this.numericUpDown15.Location = new System.Drawing.Point(588, 239);
            this.numericUpDown15.Name = "numericUpDown15";
            this.numericUpDown15.Size = new System.Drawing.Size(44, 20);
            this.numericUpDown15.TabIndex = 43;
            // 
            // textBox15
            // 
            this.textBox15.Location = new System.Drawing.Point(467, 238);
            this.textBox15.Name = "textBox15";
            this.textBox15.Size = new System.Drawing.Size(116, 20);
            this.textBox15.TabIndex = 42;
            this.textBox15.Text = "Root Beer";
            this.textBox15.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox16
            // 
            this.textBox16.Location = new System.Drawing.Point(467, 212);
            this.textBox16.Name = "textBox16";
            this.textBox16.Size = new System.Drawing.Size(116, 20);
            this.textBox16.TabIndex = 41;
            this.textBox16.Text = "Coke";
            this.textBox16.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox17
            // 
            this.textBox17.Location = new System.Drawing.Point(467, 90);
            this.textBox17.Name = "textBox17";
            this.textBox17.Size = new System.Drawing.Size(116, 20);
            this.textBox17.TabIndex = 40;
            this.textBox17.Text = "The Tim Special";
            this.textBox17.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox18
            // 
            this.textBox18.Location = new System.Drawing.Point(467, 64);
            this.textBox18.Name = "textBox18";
            this.textBox18.Size = new System.Drawing.Size(116, 20);
            this.textBox18.TabIndex = 39;
            this.textBox18.Text = "Mochi Ice Cream";
            this.textBox18.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox19
            // 
            this.textBox19.Location = new System.Drawing.Point(467, 38);
            this.textBox19.Name = "textBox19";
            this.textBox19.Size = new System.Drawing.Size(116, 20);
            this.textBox19.TabIndex = 38;
            this.textBox19.Text = "Deep Fried Oreos";
            this.textBox19.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox20
            // 
            this.textBox20.Location = new System.Drawing.Point(11, 426);
            this.textBox20.Name = "textBox20";
            this.textBox20.Size = new System.Drawing.Size(116, 20);
            this.textBox20.TabIndex = 37;
            this.textBox20.Text = "Cheeseburger";
            this.textBox20.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox21
            // 
            this.textBox21.Location = new System.Drawing.Point(12, 399);
            this.textBox21.Name = "textBox21";
            this.textBox21.Size = new System.Drawing.Size(116, 20);
            this.textBox21.TabIndex = 36;
            this.textBox21.Text = "Garlic Chicken";
            this.textBox21.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // numericUpDown16
            // 
            this.numericUpDown16.Location = new System.Drawing.Point(588, 212);
            this.numericUpDown16.Name = "numericUpDown16";
            this.numericUpDown16.Size = new System.Drawing.Size(44, 20);
            this.numericUpDown16.TabIndex = 35;
            // 
            // numericUpDown17
            // 
            this.numericUpDown17.Location = new System.Drawing.Point(588, 92);
            this.numericUpDown17.Name = "numericUpDown17";
            this.numericUpDown17.Size = new System.Drawing.Size(44, 20);
            this.numericUpDown17.TabIndex = 34;
            // 
            // numericUpDown18
            // 
            this.numericUpDown18.Location = new System.Drawing.Point(589, 65);
            this.numericUpDown18.Name = "numericUpDown18";
            this.numericUpDown18.Size = new System.Drawing.Size(44, 20);
            this.numericUpDown18.TabIndex = 33;
            // 
            // numericUpDown19
            // 
            this.numericUpDown19.Location = new System.Drawing.Point(589, 38);
            this.numericUpDown19.Name = "numericUpDown19";
            this.numericUpDown19.Size = new System.Drawing.Size(44, 20);
            this.numericUpDown19.TabIndex = 32;
            // 
            // numericUpDown20
            // 
            this.numericUpDown20.Location = new System.Drawing.Point(134, 426);
            this.numericUpDown20.Name = "numericUpDown20";
            this.numericUpDown20.Size = new System.Drawing.Size(42, 20);
            this.numericUpDown20.TabIndex = 31;
            // 
            // numericUpDown21
            // 
            this.numericUpDown21.Location = new System.Drawing.Point(134, 399);
            this.numericUpDown21.Name = "numericUpDown21";
            this.numericUpDown21.Size = new System.Drawing.Size(42, 20);
            this.numericUpDown21.TabIndex = 30;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(467, 347);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(116, 20);
            this.textBox8.TabIndex = 44;
            this.textBox8.Text = "Drinks for Adults ";
            this.textBox8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(12, 347);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(116, 20);
            this.textBox9.TabIndex = 45;
            this.textBox9.Text = "Entrees";
            this.textBox9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(467, 186);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(116, 20);
            this.textBox10.TabIndex = 46;
            this.textBox10.Text = "Drinks for Kiddies";
            this.textBox10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox22
            // 
            this.textBox22.Location = new System.Drawing.Point(12, 186);
            this.textBox22.Name = "textBox22";
            this.textBox22.Size = new System.Drawing.Size(116, 20);
            this.textBox22.TabIndex = 47;
            this.textBox22.Text = "Soups and Salads";
            this.textBox22.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox23
            // 
            this.textBox23.Location = new System.Drawing.Point(467, 12);
            this.textBox23.Name = "textBox23";
            this.textBox23.Size = new System.Drawing.Size(116, 20);
            this.textBox23.TabIndex = 48;
            this.textBox23.Text = "Desserts";
            this.textBox23.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox24
            // 
            this.textBox24.Location = new System.Drawing.Point(11, 12);
            this.textBox24.Name = "textBox24";
            this.textBox24.Size = new System.Drawing.Size(116, 20);
            this.textBox24.TabIndex = 49;
            this.textBox24.Text = "Appetizers";
            this.textBox24.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox27
            // 
            this.textBox27.Location = new System.Drawing.Point(183, 237);
            this.textBox27.Name = "textBox27";
            this.textBox27.Size = new System.Drawing.Size(56, 20);
            this.textBox27.TabIndex = 58;
            this.textBox27.Text = "6";
            this.textBox27.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox28
            // 
            this.textBox28.Location = new System.Drawing.Point(183, 211);
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
            this.textBox32.Location = new System.Drawing.Point(183, 424);
            this.textBox32.Name = "textBox32";
            this.textBox32.Size = new System.Drawing.Size(56, 20);
            this.textBox32.TabIndex = 53;
            this.textBox32.Text = "12";
            this.textBox32.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox33
            // 
            this.textBox33.Location = new System.Drawing.Point(183, 398);
            this.textBox33.Name = "textBox33";
            this.textBox33.Size = new System.Drawing.Size(56, 20);
            this.textBox33.TabIndex = 52;
            this.textBox33.Text = "8";
            this.textBox33.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox34
            // 
            this.textBox34.Location = new System.Drawing.Point(183, 372);
            this.textBox34.Name = "textBox34";
            this.textBox34.Size = new System.Drawing.Size(56, 20);
            this.textBox34.TabIndex = 51;
            this.textBox34.Text = "10";
            this.textBox34.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox35
            // 
            this.textBox35.Location = new System.Drawing.Point(183, 263);
            this.textBox35.Name = "textBox35";
            this.textBox35.Size = new System.Drawing.Size(56, 20);
            this.textBox35.TabIndex = 50;
            this.textBox35.Text = "3";
            this.textBox35.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox25
            // 
            this.textBox25.Location = new System.Drawing.Point(639, 237);
            this.textBox25.Name = "textBox25";
            this.textBox25.Size = new System.Drawing.Size(56, 20);
            this.textBox25.TabIndex = 67;
            this.textBox25.Text = "2";
            // 
            // textBox26
            // 
            this.textBox26.Location = new System.Drawing.Point(639, 211);
            this.textBox26.Name = "textBox26";
            this.textBox26.Size = new System.Drawing.Size(56, 20);
            this.textBox26.TabIndex = 66;
            this.textBox26.Text = "2";
            // 
            // textBox36
            // 
            this.textBox36.Location = new System.Drawing.Point(639, 89);
            this.textBox36.Name = "textBox36";
            this.textBox36.Size = new System.Drawing.Size(56, 20);
            this.textBox36.TabIndex = 65;
            this.textBox36.Text = "200";
            // 
            // textBox37
            // 
            this.textBox37.Location = new System.Drawing.Point(639, 63);
            this.textBox37.Name = "textBox37";
            this.textBox37.Size = new System.Drawing.Size(56, 20);
            this.textBox37.TabIndex = 64;
            this.textBox37.Text = "3";
            // 
            // textBox38
            // 
            this.textBox38.Location = new System.Drawing.Point(639, 37);
            this.textBox38.Name = "textBox38";
            this.textBox38.Size = new System.Drawing.Size(56, 20);
            this.textBox38.TabIndex = 63;
            this.textBox38.Text = "5";
            // 
            // textBox39
            // 
            this.textBox39.Location = new System.Drawing.Point(639, 424);
            this.textBox39.Name = "textBox39";
            this.textBox39.Size = new System.Drawing.Size(56, 20);
            this.textBox39.TabIndex = 62;
            this.textBox39.Text = "9";
            // 
            // textBox40
            // 
            this.textBox40.Location = new System.Drawing.Point(639, 398);
            this.textBox40.Name = "textBox40";
            this.textBox40.Size = new System.Drawing.Size(56, 20);
            this.textBox40.TabIndex = 61;
            this.textBox40.Text = "10";
            // 
            // textBox41
            // 
            this.textBox41.Location = new System.Drawing.Point(639, 372);
            this.textBox41.Name = "textBox41";
            this.textBox41.Size = new System.Drawing.Size(56, 20);
            this.textBox41.TabIndex = 60;
            this.textBox41.Text = "10";
            // 
            // textBox42
            // 
            this.textBox42.Location = new System.Drawing.Point(639, 263);
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
            this.textBox44.Location = new System.Drawing.Point(639, 347);
            this.textBox44.Name = "textBox44";
            this.textBox44.Size = new System.Drawing.Size(56, 20);
            this.textBox44.TabIndex = 70;
            this.textBox44.Text = "Price";
            this.textBox44.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox45
            // 
            this.textBox45.Location = new System.Drawing.Point(639, 186);
            this.textBox45.Name = "textBox45";
            this.textBox45.Size = new System.Drawing.Size(56, 20);
            this.textBox45.TabIndex = 71;
            this.textBox45.Text = "Price";
            this.textBox45.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox46
            // 
            this.textBox46.Location = new System.Drawing.Point(639, 12);
            this.textBox46.Name = "textBox46";
            this.textBox46.Size = new System.Drawing.Size(56, 20);
            this.textBox46.TabIndex = 72;
            this.textBox46.Text = "Price";
            this.textBox46.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox47
            // 
            this.textBox47.Location = new System.Drawing.Point(183, 346);
            this.textBox47.Name = "textBox47";
            this.textBox47.Size = new System.Drawing.Size(56, 20);
            this.textBox47.TabIndex = 73;
            this.textBox47.Text = "Price";
            this.textBox47.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox48
            // 
            this.textBox48.Location = new System.Drawing.Point(183, 185);
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
            // MenuForm
            // 
            this.ClientSize = new System.Drawing.Size(873, 510);
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
            this.Controls.Add(this.textBox24);
            this.Controls.Add(this.textBox23);
            this.Controls.Add(this.textBox22);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.numericUpDown15);
            this.Controls.Add(this.textBox15);
            this.Controls.Add(this.textBox16);
            this.Controls.Add(this.textBox17);
            this.Controls.Add(this.textBox18);
            this.Controls.Add(this.textBox19);
            this.Controls.Add(this.textBox20);
            this.Controls.Add(this.textBox21);
            this.Controls.Add(this.numericUpDown16);
            this.Controls.Add(this.numericUpDown17);
            this.Controls.Add(this.numericUpDown18);
            this.Controls.Add(this.numericUpDown19);
            this.Controls.Add(this.numericUpDown20);
            this.Controls.Add(this.numericUpDown21);
            this.Controls.Add(this.textBox11);
            this.Controls.Add(this.textBox12);
            this.Controls.Add(this.textBox13);
            this.Controls.Add(this.textBox14);
            this.Controls.Add(this.numericUpDown11);
            this.Controls.Add(this.numericUpDown12);
            this.Controls.Add(this.numericUpDown13);
            this.Controls.Add(this.numericUpDown14);
            this.Controls.Add(this.numericUpDown7);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.numericUpDown6);
            this.Controls.Add(this.numericUpDown5);
            this.Controls.Add(this.numericUpDown4);
            this.Controls.Add(this.numericUpDown3);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.numericUpDown1);
            this.Name = "MenuForm";
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

            //==============================================================================
          

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.Text = "Schmittyz Chicken";
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        //First up/down
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            menuValues[0] = (int)numericUpDown1.Value;
        }

        private void textBox43_TextChanged(object sender, EventArgs e)
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

            
        
             
            

            //System.IO.File.AppendAllText(@"C:\waitData\MenuItemOrdered.txt", "\r\n");

            //System.IO.File.WriteAllLines(@"C:\waitData\MenuItemOrdered.txt", new string[] { "" });
        }
    }
}