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
        private NumericUpDown selectAppetizer1;
        private NumericUpDown selectAppetizer2;
        private NumericUpDown selectAppetizer3;
        private NumericUpDown selectSoupSalad1;
        private NumericUpDown selectSoupSalad2;
        private NumericUpDown selectSoupSalad3;
        private TextBox appetizer1;
        private TextBox appetizer2;
        private TextBox appetizer3;
        private TextBox soupSalad1;
        private TextBox soupSalad2;
        private TextBox soupSalad3;
        private TextBox entree1;
        private NumericUpDown selectEntree1;
        private TextBox drinkAdult3;
        private TextBox drinkAdult2;
        private TextBox drinkAdult1;
        private TextBox drinkKid3;
        private NumericUpDown selectDrinkAdult3;
        private NumericUpDown selectDrinkAdult2;
        private NumericUpDown selectDrinkAdult1;
        private NumericUpDown selectDrinkKid3;
        private NumericUpDown selectDrinkKid2;
        private TextBox drinkKid2;
        private TextBox drinkKid1;
        private TextBox dessert3;
        private TextBox desserts2;
        private TextBox desserts1;
        private TextBox entree3;
        private TextBox entree2;
        private NumericUpDown selectDrinkKid1;
        private NumericUpDown selectDesserts3;
        private NumericUpDown selectDesserts2;
        private NumericUpDown selectDesserts1;
        private NumericUpDown selectEntree3;
        private NumericUpDown selectEntree2;
        private TextBox drinkAdultName;
        private TextBox entreeName;
        private TextBox drinkKidName;
        private TextBox soupSaladName;
        private TextBox dessertsName;
        private TextBox appetizersName;
        private TextBox priceSoupSalad2;
        private TextBox priceSoupSalad1;
        private TextBox priceAppetizer3;
        private TextBox priceAppetizer2;
        private TextBox priceAppetizer1;
        private TextBox priceEntree3;
        private TextBox priceEntree2;
        private TextBox priceEntree1;
        private TextBox priceSoupSalad3;
        private TextBox priceDrinkKid2;
        private TextBox priceDrinkKid1;
        private TextBox priceDesserts3;
        private TextBox priceDesserts2;
        private TextBox priceDesserts1;
        private TextBox priceDrinkAdult3;
        private TextBox priceDrinkAdult2;
        private TextBox priceDrinkAdult1;
        private TextBox priceDrinkKid3;
        private Button button1;
        private TextBox priceAppetizersName;
        private TextBox priceDrinkAdultName;
        private TextBox priceDrinkKidName;
        private TextBox priceDessertsName;
        private TextBox priceEntreeName;
        private TextBox priceSoupSaladName;
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

        TextBox[] tbFoodNames = new TextBox[18];

        TextBox[] FoodPrices = new TextBox[18];

        public MenuForm()
        {
            InitializeComponent();

            //array of food prices
            TextBox[] FoodPrices = new TextBox[18]{priceAppetizer1, priceAppetizer2, priceAppetizer3,priceSoupSalad1, priceSoupSalad2, priceSoupSalad3,
            priceEntree1, priceEntree2, priceEntree3, priceDesserts1, priceDesserts2, priceDesserts3,  priceDrinkKid1, priceDrinkKid2, priceDrinkKid3,
            priceDrinkAdult1, priceDrinkAdult2, priceDrinkAdult3 };

            /*For initializing the prices later
            for (int i= 0; i< FoodPrices.Length; i++){




            }
            */


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
            this.selectAppetizer1 = new System.Windows.Forms.NumericUpDown();
            this.selectAppetizer2 = new System.Windows.Forms.NumericUpDown();
            this.selectAppetizer3 = new System.Windows.Forms.NumericUpDown();
            this.selectSoupSalad1 = new System.Windows.Forms.NumericUpDown();
            this.selectSoupSalad2 = new System.Windows.Forms.NumericUpDown();
            this.selectSoupSalad3 = new System.Windows.Forms.NumericUpDown();
            this.appetizer1 = new System.Windows.Forms.TextBox();
            this.appetizer2 = new System.Windows.Forms.TextBox();
            this.appetizer3 = new System.Windows.Forms.TextBox();
            this.soupSalad1 = new System.Windows.Forms.TextBox();
            this.soupSalad2 = new System.Windows.Forms.TextBox();
            this.soupSalad3 = new System.Windows.Forms.TextBox();
            this.entree1 = new System.Windows.Forms.TextBox();
            this.selectEntree1 = new System.Windows.Forms.NumericUpDown();
            this.drinkAdult3 = new System.Windows.Forms.TextBox();
            this.drinkAdult2 = new System.Windows.Forms.TextBox();
            this.drinkAdult1 = new System.Windows.Forms.TextBox();
            this.drinkKid3 = new System.Windows.Forms.TextBox();
            this.selectDrinkAdult3 = new System.Windows.Forms.NumericUpDown();
            this.selectDrinkAdult2 = new System.Windows.Forms.NumericUpDown();
            this.selectDrinkAdult1 = new System.Windows.Forms.NumericUpDown();
            this.selectDrinkKid3 = new System.Windows.Forms.NumericUpDown();
            this.selectDrinkKid2 = new System.Windows.Forms.NumericUpDown();
            this.drinkKid2 = new System.Windows.Forms.TextBox();
            this.drinkKid1 = new System.Windows.Forms.TextBox();
            this.dessert3 = new System.Windows.Forms.TextBox();
            this.desserts2 = new System.Windows.Forms.TextBox();
            this.desserts1 = new System.Windows.Forms.TextBox();
            this.entree3 = new System.Windows.Forms.TextBox();
            this.entree2 = new System.Windows.Forms.TextBox();
            this.selectDrinkKid1 = new System.Windows.Forms.NumericUpDown();
            this.selectDesserts3 = new System.Windows.Forms.NumericUpDown();
            this.selectDesserts2 = new System.Windows.Forms.NumericUpDown();
            this.selectDesserts1 = new System.Windows.Forms.NumericUpDown();
            this.selectEntree3 = new System.Windows.Forms.NumericUpDown();
            this.selectEntree2 = new System.Windows.Forms.NumericUpDown();
            this.drinkAdultName = new System.Windows.Forms.TextBox();
            this.entreeName = new System.Windows.Forms.TextBox();
            this.drinkKidName = new System.Windows.Forms.TextBox();
            this.soupSaladName = new System.Windows.Forms.TextBox();
            this.dessertsName = new System.Windows.Forms.TextBox();
            this.appetizersName = new System.Windows.Forms.TextBox();
            this.priceSoupSalad2 = new System.Windows.Forms.TextBox();
            this.priceSoupSalad1 = new System.Windows.Forms.TextBox();
            this.priceAppetizer3 = new System.Windows.Forms.TextBox();
            this.priceAppetizer2 = new System.Windows.Forms.TextBox();
            this.priceAppetizer1 = new System.Windows.Forms.TextBox();
            this.priceEntree3 = new System.Windows.Forms.TextBox();
            this.priceEntree2 = new System.Windows.Forms.TextBox();
            this.priceEntree1 = new System.Windows.Forms.TextBox();
            this.priceSoupSalad3 = new System.Windows.Forms.TextBox();
            this.priceDrinkKid2 = new System.Windows.Forms.TextBox();
            this.priceDrinkKid1 = new System.Windows.Forms.TextBox();
            this.priceDesserts3 = new System.Windows.Forms.TextBox();
            this.priceDesserts2 = new System.Windows.Forms.TextBox();
            this.priceDesserts1 = new System.Windows.Forms.TextBox();
            this.priceDrinkAdult3 = new System.Windows.Forms.TextBox();
            this.priceDrinkAdult2 = new System.Windows.Forms.TextBox();
            this.priceDrinkAdult1 = new System.Windows.Forms.TextBox();
            this.priceDrinkKid3 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.priceAppetizersName = new System.Windows.Forms.TextBox();
            this.priceDrinkAdultName = new System.Windows.Forms.TextBox();
            this.priceDrinkKidName = new System.Windows.Forms.TextBox();
            this.priceDessertsName = new System.Windows.Forms.TextBox();
            this.priceEntreeName = new System.Windows.Forms.TextBox();
            this.priceSoupSaladName = new System.Windows.Forms.TextBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.selectAppetizer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectAppetizer2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectAppetizer3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectSoupSalad1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectSoupSalad2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectSoupSalad3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectEntree1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectDrinkAdult3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectDrinkAdult2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectDrinkAdult1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectDrinkKid3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectDrinkKid2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectDrinkKid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectDesserts3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectDesserts2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectDesserts1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectEntree3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectEntree2)).BeginInit();
            this.SuspendLayout();
            // 
            // selectAppetizer1
            // 
            this.selectAppetizer1.Location = new System.Drawing.Point(134, 38);
            this.selectAppetizer1.Name = "selectAppetizer1";
            this.selectAppetizer1.Size = new System.Drawing.Size(43, 20);
            this.selectAppetizer1.TabIndex = 2;
            this.selectAppetizer1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // selectAppetizer2
            // 
            this.selectAppetizer2.Location = new System.Drawing.Point(134, 65);
            this.selectAppetizer2.Name = "selectAppetizer2";
            this.selectAppetizer2.Size = new System.Drawing.Size(42, 20);
            this.selectAppetizer2.TabIndex = 3;
            this.selectAppetizer2.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // selectAppetizer3
            // 
            this.selectAppetizer3.Location = new System.Drawing.Point(133, 91);
            this.selectAppetizer3.Name = "selectAppetizer3";
            this.selectAppetizer3.Size = new System.Drawing.Size(44, 20);
            this.selectAppetizer3.TabIndex = 4;
            this.selectAppetizer3.ValueChanged += new System.EventHandler(this.numericUpDown3_ValueChanged);
            // 
            // selectSoupSalad1
            // 
            this.selectSoupSalad1.Location = new System.Drawing.Point(132, 162);
            this.selectSoupSalad1.Name = "selectSoupSalad1";
            this.selectSoupSalad1.Size = new System.Drawing.Size(44, 20);
            this.selectSoupSalad1.TabIndex = 5;
            this.selectSoupSalad1.ValueChanged += new System.EventHandler(this.numericUpDown4_ValueChanged);
            // 
            // selectSoupSalad2
            // 
            this.selectSoupSalad2.Location = new System.Drawing.Point(131, 188);
            this.selectSoupSalad2.Name = "selectSoupSalad2";
            this.selectSoupSalad2.Size = new System.Drawing.Size(44, 20);
            this.selectSoupSalad2.TabIndex = 6;
            this.selectSoupSalad2.ValueChanged += new System.EventHandler(this.numericUpDown5_ValueChanged);
            // 
            // selectSoupSalad3
            // 
            this.selectSoupSalad3.Location = new System.Drawing.Point(131, 213);
            this.selectSoupSalad3.Name = "selectSoupSalad3";
            this.selectSoupSalad3.Size = new System.Drawing.Size(44, 20);
            this.selectSoupSalad3.TabIndex = 7;
            this.selectSoupSalad3.ValueChanged += new System.EventHandler(this.numericUpDown6_ValueChanged);
            // 
            // appetizer1
            // 
            this.appetizer1.Location = new System.Drawing.Point(12, 38);
            this.appetizer1.Name = "appetizer1";
            this.appetizer1.ReadOnly = true;
            this.appetizer1.Size = new System.Drawing.Size(116, 20);
            this.appetizer1.TabIndex = 8;
            this.appetizer1.Text = "Chicken Nachos";
            this.appetizer1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.appetizer1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // appetizer2
            // 
            this.appetizer2.Location = new System.Drawing.Point(11, 65);
            this.appetizer2.Name = "appetizer2";
            this.appetizer2.ReadOnly = true;
            this.appetizer2.Size = new System.Drawing.Size(116, 20);
            this.appetizer2.TabIndex = 9;
            this.appetizer2.Text = "Deep Fried Mozarella";
            this.appetizer2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // appetizer3
            // 
            this.appetizer3.Location = new System.Drawing.Point(11, 91);
            this.appetizer3.Name = "appetizer3";
            this.appetizer3.ReadOnly = true;
            this.appetizer3.Size = new System.Drawing.Size(116, 20);
            this.appetizer3.TabIndex = 10;
            this.appetizer3.Text = "Spam Musubi";
            this.appetizer3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // soupSalad1
            // 
            this.soupSalad1.Location = new System.Drawing.Point(10, 161);
            this.soupSalad1.Name = "soupSalad1";
            this.soupSalad1.ReadOnly = true;
            this.soupSalad1.Size = new System.Drawing.Size(116, 20);
            this.soupSalad1.TabIndex = 11;
            this.soupSalad1.Text = "Caesar Salad";
            this.soupSalad1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // soupSalad2
            // 
            this.soupSalad2.Location = new System.Drawing.Point(10, 187);
            this.soupSalad2.Name = "soupSalad2";
            this.soupSalad2.ReadOnly = true;
            this.soupSalad2.Size = new System.Drawing.Size(116, 20);
            this.soupSalad2.TabIndex = 12;
            this.soupSalad2.Text = "Mac Salad";
            this.soupSalad2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // soupSalad3
            // 
            this.soupSalad3.Location = new System.Drawing.Point(10, 213);
            this.soupSalad3.Name = "soupSalad3";
            this.soupSalad3.ReadOnly = true;
            this.soupSalad3.Size = new System.Drawing.Size(116, 20);
            this.soupSalad3.TabIndex = 13;
            this.soupSalad3.Text = "Miso Soup";
            this.soupSalad3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // entree1
            // 
            this.entree1.Location = new System.Drawing.Point(11, 278);
            this.entree1.Name = "entree1";
            this.entree1.ReadOnly = true;
            this.entree1.Size = new System.Drawing.Size(116, 20);
            this.entree1.TabIndex = 14;
            this.entree1.Text = "Loco Moco";
            this.entree1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // selectEntree1
            // 
            this.selectEntree1.Location = new System.Drawing.Point(132, 279);
            this.selectEntree1.Name = "selectEntree1";
            this.selectEntree1.Size = new System.Drawing.Size(44, 20);
            this.selectEntree1.TabIndex = 15;
            this.selectEntree1.ValueChanged += new System.EventHandler(this.numericUpDown7_ValueChanged);
            // 
            // drinkAdult3
            // 
            this.drinkAdult3.Location = new System.Drawing.Point(443, 213);
            this.drinkAdult3.Name = "drinkAdult3";
            this.drinkAdult3.ReadOnly = true;
            this.drinkAdult3.Size = new System.Drawing.Size(116, 20);
            this.drinkAdult3.TabIndex = 25;
            this.drinkAdult3.Text = "Vodka Tonic";
            this.drinkAdult3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // drinkAdult2
            // 
            this.drinkAdult2.Location = new System.Drawing.Point(443, 187);
            this.drinkAdult2.Name = "drinkAdult2";
            this.drinkAdult2.ReadOnly = true;
            this.drinkAdult2.Size = new System.Drawing.Size(116, 20);
            this.drinkAdult2.TabIndex = 24;
            this.drinkAdult2.Text = "Jaeger";
            this.drinkAdult2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // drinkAdult1
            // 
            this.drinkAdult1.Location = new System.Drawing.Point(443, 161);
            this.drinkAdult1.Name = "drinkAdult1";
            this.drinkAdult1.ReadOnly = true;
            this.drinkAdult1.Size = new System.Drawing.Size(116, 20);
            this.drinkAdult1.TabIndex = 23;
            this.drinkAdult1.Text = "Jack and Coke";
            this.drinkAdult1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // drinkKid3
            // 
            this.drinkKid3.Location = new System.Drawing.Point(443, 90);
            this.drinkKid3.Name = "drinkKid3";
            this.drinkKid3.ReadOnly = true;
            this.drinkKid3.Size = new System.Drawing.Size(116, 20);
            this.drinkKid3.TabIndex = 22;
            this.drinkKid3.Text = "Bottled Water";
            this.drinkKid3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // selectDrinkAdult3
            // 
            this.selectDrinkAdult3.Location = new System.Drawing.Point(565, 214);
            this.selectDrinkAdult3.Name = "selectDrinkAdult3";
            this.selectDrinkAdult3.Size = new System.Drawing.Size(44, 20);
            this.selectDrinkAdult3.TabIndex = 19;
            this.selectDrinkAdult3.ValueChanged += new System.EventHandler(this.numericUpDown11_ValueChanged);
            // 
            // selectDrinkAdult2
            // 
            this.selectDrinkAdult2.Location = new System.Drawing.Point(565, 187);
            this.selectDrinkAdult2.Name = "selectDrinkAdult2";
            this.selectDrinkAdult2.Size = new System.Drawing.Size(44, 20);
            this.selectDrinkAdult2.TabIndex = 18;
            this.selectDrinkAdult2.ValueChanged += new System.EventHandler(this.numericUpDown12_ValueChanged);
            // 
            // selectDrinkAdult1
            // 
            this.selectDrinkAdult1.Location = new System.Drawing.Point(566, 161);
            this.selectDrinkAdult1.Name = "selectDrinkAdult1";
            this.selectDrinkAdult1.Size = new System.Drawing.Size(42, 20);
            this.selectDrinkAdult1.TabIndex = 17;
            this.selectDrinkAdult1.ValueChanged += new System.EventHandler(this.numericUpDown13_ValueChanged);
            // 
            // selectDrinkKid3
            // 
            this.selectDrinkKid3.Location = new System.Drawing.Point(565, 90);
            this.selectDrinkKid3.Name = "selectDrinkKid3";
            this.selectDrinkKid3.Size = new System.Drawing.Size(42, 20);
            this.selectDrinkKid3.TabIndex = 16;
            this.selectDrinkKid3.ValueChanged += new System.EventHandler(this.numericUpDown14_ValueChanged);
            // 
            // selectDrinkKid2
            // 
            this.selectDrinkKid2.Location = new System.Drawing.Point(564, 65);
            this.selectDrinkKid2.Name = "selectDrinkKid2";
            this.selectDrinkKid2.Size = new System.Drawing.Size(44, 20);
            this.selectDrinkKid2.TabIndex = 43;
            this.selectDrinkKid2.ValueChanged += new System.EventHandler(this.numericUpDown15_ValueChanged);
            // 
            // drinkKid2
            // 
            this.drinkKid2.Location = new System.Drawing.Point(443, 64);
            this.drinkKid2.Name = "drinkKid2";
            this.drinkKid2.ReadOnly = true;
            this.drinkKid2.Size = new System.Drawing.Size(116, 20);
            this.drinkKid2.TabIndex = 42;
            this.drinkKid2.Text = "Root Beer";
            this.drinkKid2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // drinkKid1
            // 
            this.drinkKid1.Location = new System.Drawing.Point(443, 38);
            this.drinkKid1.Name = "drinkKid1";
            this.drinkKid1.ReadOnly = true;
            this.drinkKid1.Size = new System.Drawing.Size(116, 20);
            this.drinkKid1.TabIndex = 41;
            this.drinkKid1.Text = "Coke";
            this.drinkKid1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dessert3
            // 
            this.dessert3.Location = new System.Drawing.Point(11, 451);
            this.dessert3.Name = "dessert3";
            this.dessert3.ReadOnly = true;
            this.dessert3.Size = new System.Drawing.Size(116, 20);
            this.dessert3.TabIndex = 40;
            this.dessert3.Text = "The Tim Special";
            this.dessert3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // desserts2
            // 
            this.desserts2.Location = new System.Drawing.Point(11, 425);
            this.desserts2.Name = "desserts2";
            this.desserts2.ReadOnly = true;
            this.desserts2.Size = new System.Drawing.Size(116, 20);
            this.desserts2.TabIndex = 39;
            this.desserts2.Text = "Mochi Ice Cream";
            this.desserts2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // desserts1
            // 
            this.desserts1.Location = new System.Drawing.Point(11, 399);
            this.desserts1.Name = "desserts1";
            this.desserts1.ReadOnly = true;
            this.desserts1.Size = new System.Drawing.Size(116, 20);
            this.desserts1.TabIndex = 38;
            this.desserts1.Text = "Deep Fried Oreos";
            this.desserts1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // entree3
            // 
            this.entree3.Location = new System.Drawing.Point(11, 331);
            this.entree3.Name = "entree3";
            this.entree3.ReadOnly = true;
            this.entree3.Size = new System.Drawing.Size(116, 20);
            this.entree3.TabIndex = 37;
            this.entree3.Text = "Cheeseburger";
            this.entree3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // entree2
            // 
            this.entree2.Location = new System.Drawing.Point(12, 304);
            this.entree2.Name = "entree2";
            this.entree2.ReadOnly = true;
            this.entree2.Size = new System.Drawing.Size(116, 20);
            this.entree2.TabIndex = 36;
            this.entree2.Text = "Garlic Chicken";
            this.entree2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // selectDrinkKid1
            // 
            this.selectDrinkKid1.Location = new System.Drawing.Point(564, 38);
            this.selectDrinkKid1.Name = "selectDrinkKid1";
            this.selectDrinkKid1.Size = new System.Drawing.Size(44, 20);
            this.selectDrinkKid1.TabIndex = 35;
            this.selectDrinkKid1.ValueChanged += new System.EventHandler(this.numericUpDown16_ValueChanged);
            // 
            // selectDesserts3
            // 
            this.selectDesserts3.Location = new System.Drawing.Point(132, 453);
            this.selectDesserts3.Name = "selectDesserts3";
            this.selectDesserts3.Size = new System.Drawing.Size(44, 20);
            this.selectDesserts3.TabIndex = 34;
            this.selectDesserts3.ValueChanged += new System.EventHandler(this.numericUpDown17_ValueChanged);
            // 
            // selectDesserts2
            // 
            this.selectDesserts2.Location = new System.Drawing.Point(133, 426);
            this.selectDesserts2.Name = "selectDesserts2";
            this.selectDesserts2.Size = new System.Drawing.Size(44, 20);
            this.selectDesserts2.TabIndex = 33;
            this.selectDesserts2.ValueChanged += new System.EventHandler(this.numericUpDown18_ValueChanged);
            // 
            // selectDesserts1
            // 
            this.selectDesserts1.Location = new System.Drawing.Point(133, 399);
            this.selectDesserts1.Name = "selectDesserts1";
            this.selectDesserts1.Size = new System.Drawing.Size(44, 20);
            this.selectDesserts1.TabIndex = 32;
            this.selectDesserts1.ValueChanged += new System.EventHandler(this.numericUpDown19_ValueChanged);
            // 
            // selectEntree3
            // 
            this.selectEntree3.Location = new System.Drawing.Point(134, 331);
            this.selectEntree3.Name = "selectEntree3";
            this.selectEntree3.Size = new System.Drawing.Size(42, 20);
            this.selectEntree3.TabIndex = 31;
            this.selectEntree3.ValueChanged += new System.EventHandler(this.numericUpDown20_ValueChanged);
            // 
            // selectEntree2
            // 
            this.selectEntree2.Location = new System.Drawing.Point(134, 304);
            this.selectEntree2.Name = "selectEntree2";
            this.selectEntree2.Size = new System.Drawing.Size(42, 20);
            this.selectEntree2.TabIndex = 30;
            this.selectEntree2.ValueChanged += new System.EventHandler(this.numericUpDown21_ValueChanged);
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
            // priceSoupSalad2
            // 
            this.priceSoupSalad2.Location = new System.Drawing.Point(182, 186);
            this.priceSoupSalad2.Name = "priceSoupSalad2";
            this.priceSoupSalad2.Size = new System.Drawing.Size(56, 20);
            this.priceSoupSalad2.TabIndex = 58;
            this.priceSoupSalad2.Text = "6";
            this.priceSoupSalad2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // priceSoupSalad1
            // 
            this.priceSoupSalad1.Location = new System.Drawing.Point(182, 160);
            this.priceSoupSalad1.Name = "priceSoupSalad1";
            this.priceSoupSalad1.Size = new System.Drawing.Size(56, 20);
            this.priceSoupSalad1.TabIndex = 57;
            this.priceSoupSalad1.Text = "8";
            this.priceSoupSalad1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // priceAppetizer3
            // 
            this.priceAppetizer3.Location = new System.Drawing.Point(183, 89);
            this.priceAppetizer3.Name = "priceAppetizer3";
            this.priceAppetizer3.Size = new System.Drawing.Size(56, 20);
            this.priceAppetizer3.TabIndex = 56;
            this.priceAppetizer3.Text = "4";
            this.priceAppetizer3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // priceAppetizer2
            // 
            this.priceAppetizer2.Location = new System.Drawing.Point(183, 63);
            this.priceAppetizer2.Name = "priceAppetizer2";
            this.priceAppetizer2.Size = new System.Drawing.Size(56, 20);
            this.priceAppetizer2.TabIndex = 55;
            this.priceAppetizer2.Text = "6";
            this.priceAppetizer2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // priceAppetizer1
            // 
            this.priceAppetizer1.Location = new System.Drawing.Point(183, 37);
            this.priceAppetizer1.Name = "priceAppetizer1";
            this.priceAppetizer1.Size = new System.Drawing.Size(56, 20);
            this.priceAppetizer1.TabIndex = 54;
            this.priceAppetizer1.Text = "5";
            this.priceAppetizer1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // priceEntree3
            // 
            this.priceEntree3.Location = new System.Drawing.Point(183, 329);
            this.priceEntree3.Name = "priceEntree3";
            this.priceEntree3.Size = new System.Drawing.Size(56, 20);
            this.priceEntree3.TabIndex = 53;
            this.priceEntree3.Text = "12";
            this.priceEntree3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // priceEntree2
            // 
            this.priceEntree2.Location = new System.Drawing.Point(183, 303);
            this.priceEntree2.Name = "priceEntree2";
            this.priceEntree2.Size = new System.Drawing.Size(56, 20);
            this.priceEntree2.TabIndex = 52;
            this.priceEntree2.Text = "8";
            this.priceEntree2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // priceEntree1
            // 
            this.priceEntree1.Location = new System.Drawing.Point(183, 277);
            this.priceEntree1.Name = "priceEntree1";
            this.priceEntree1.Size = new System.Drawing.Size(56, 20);
            this.priceEntree1.TabIndex = 51;
            this.priceEntree1.Text = "10";
            this.priceEntree1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.priceEntree1.TextChanged += new System.EventHandler(this.textBox34_TextChanged);
            // 
            // priceSoupSalad3
            // 
            this.priceSoupSalad3.Location = new System.Drawing.Point(182, 212);
            this.priceSoupSalad3.Name = "priceSoupSalad3";
            this.priceSoupSalad3.Size = new System.Drawing.Size(56, 20);
            this.priceSoupSalad3.TabIndex = 50;
            this.priceSoupSalad3.Text = "3";
            this.priceSoupSalad3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // priceDrinkKid2
            // 
            this.priceDrinkKid2.Location = new System.Drawing.Point(615, 63);
            this.priceDrinkKid2.Name = "priceDrinkKid2";
            this.priceDrinkKid2.Size = new System.Drawing.Size(56, 20);
            this.priceDrinkKid2.TabIndex = 67;
            this.priceDrinkKid2.Text = "2";
            // 
            // priceDrinkKid1
            // 
            this.priceDrinkKid1.Location = new System.Drawing.Point(615, 37);
            this.priceDrinkKid1.Name = "priceDrinkKid1";
            this.priceDrinkKid1.Size = new System.Drawing.Size(56, 20);
            this.priceDrinkKid1.TabIndex = 66;
            this.priceDrinkKid1.Text = "2";
            // 
            // priceDesserts3
            // 
            this.priceDesserts3.Location = new System.Drawing.Point(183, 450);
            this.priceDesserts3.Name = "priceDesserts3";
            this.priceDesserts3.Size = new System.Drawing.Size(56, 20);
            this.priceDesserts3.TabIndex = 65;
            this.priceDesserts3.Text = "200";
            // 
            // priceDesserts2
            // 
            this.priceDesserts2.Location = new System.Drawing.Point(183, 424);
            this.priceDesserts2.Name = "priceDesserts2";
            this.priceDesserts2.Size = new System.Drawing.Size(56, 20);
            this.priceDesserts2.TabIndex = 64;
            this.priceDesserts2.Text = "3";
            // 
            // priceDesserts1
            // 
            this.priceDesserts1.Location = new System.Drawing.Point(183, 398);
            this.priceDesserts1.Name = "priceDesserts1";
            this.priceDesserts1.Size = new System.Drawing.Size(56, 20);
            this.priceDesserts1.TabIndex = 63;
            this.priceDesserts1.Text = "5";
            // 
            // priceDrinkAdult3
            // 
            this.priceDrinkAdult3.Location = new System.Drawing.Point(615, 212);
            this.priceDrinkAdult3.Name = "priceDrinkAdult3";
            this.priceDrinkAdult3.Size = new System.Drawing.Size(56, 20);
            this.priceDrinkAdult3.TabIndex = 62;
            this.priceDrinkAdult3.Text = "9";
            // 
            // priceDrinkAdult2
            // 
            this.priceDrinkAdult2.Location = new System.Drawing.Point(615, 186);
            this.priceDrinkAdult2.Name = "priceDrinkAdult2";
            this.priceDrinkAdult2.Size = new System.Drawing.Size(56, 20);
            this.priceDrinkAdult2.TabIndex = 61;
            this.priceDrinkAdult2.Text = "10";
            // 
            // priceDrinkAdult1
            // 
            this.priceDrinkAdult1.Location = new System.Drawing.Point(615, 160);
            this.priceDrinkAdult1.Name = "priceDrinkAdult1";
            this.priceDrinkAdult1.Size = new System.Drawing.Size(56, 20);
            this.priceDrinkAdult1.TabIndex = 60;
            this.priceDrinkAdult1.Text = "10";
            // 
            // priceDrinkKid3
            // 
            this.priceDrinkKid3.Location = new System.Drawing.Point(615, 89);
            this.priceDrinkKid3.Name = "priceDrinkKid3";
            this.priceDrinkKid3.Size = new System.Drawing.Size(56, 20);
            this.priceDrinkKid3.TabIndex = 59;
            this.priceDrinkKid3.Text = "1";
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
            // priceAppetizersName
            // 
            this.priceAppetizersName.Location = new System.Drawing.Point(183, 11);
            this.priceAppetizersName.Name = "priceAppetizersName";
            this.priceAppetizersName.Size = new System.Drawing.Size(56, 20);
            this.priceAppetizersName.TabIndex = 69;
            this.priceAppetizersName.Text = "Price";
            this.priceAppetizersName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.priceAppetizersName.TextChanged += new System.EventHandler(this.textBox43_TextChanged);
            // 
            // priceDrinkAdultName
            // 
            this.priceDrinkAdultName.Location = new System.Drawing.Point(615, 135);
            this.priceDrinkAdultName.Name = "priceDrinkAdultName";
            this.priceDrinkAdultName.Size = new System.Drawing.Size(56, 20);
            this.priceDrinkAdultName.TabIndex = 70;
            this.priceDrinkAdultName.Text = "Price";
            this.priceDrinkAdultName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // priceDrinkKidName
            // 
            this.priceDrinkKidName.Location = new System.Drawing.Point(615, 12);
            this.priceDrinkKidName.Name = "priceDrinkKidName";
            this.priceDrinkKidName.Size = new System.Drawing.Size(56, 20);
            this.priceDrinkKidName.TabIndex = 71;
            this.priceDrinkKidName.Text = "Price";
            this.priceDrinkKidName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // priceDessertsName
            // 
            this.priceDessertsName.Location = new System.Drawing.Point(183, 373);
            this.priceDessertsName.Name = "priceDessertsName";
            this.priceDessertsName.Size = new System.Drawing.Size(56, 20);
            this.priceDessertsName.TabIndex = 72;
            this.priceDessertsName.Text = "Price";
            this.priceDessertsName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // priceEntreeName
            // 
            this.priceEntreeName.Location = new System.Drawing.Point(183, 251);
            this.priceEntreeName.Name = "priceEntreeName";
            this.priceEntreeName.Size = new System.Drawing.Size(56, 20);
            this.priceEntreeName.TabIndex = 73;
            this.priceEntreeName.Text = "Price";
            this.priceEntreeName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // priceSoupSaladName
            // 
            this.priceSoupSaladName.Location = new System.Drawing.Point(182, 134);
            this.priceSoupSaladName.Name = "priceSoupSaladName";
            this.priceSoupSaladName.Size = new System.Drawing.Size(56, 20);
            this.priceSoupSaladName.TabIndex = 74;
            this.priceSoupSaladName.Text = "Price";
            this.priceSoupSaladName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.checkBox1.Size = new System.Drawing.Size(80, 17);
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
            this.checkBox2.Size = new System.Drawing.Size(80, 17);
            this.checkBox2.TabIndex = 77;
            this.checkBox2.Text = "checkBox2";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(257, 89);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(80, 17);
            this.checkBox3.TabIndex = 78;
            this.checkBox3.Text = "checkBox3";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(256, 160);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(80, 17);
            this.checkBox4.TabIndex = 81;
            this.checkBox4.Text = "checkBox4";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(256, 184);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(80, 17);
            this.checkBox5.TabIndex = 80;
            this.checkBox5.Text = "checkBox5";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Location = new System.Drawing.Point(256, 207);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(80, 17);
            this.checkBox6.TabIndex = 79;
            this.checkBox6.Text = "checkBox6";
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox7
            // 
            this.checkBox7.AutoSize = true;
            this.checkBox7.Location = new System.Drawing.Point(257, 278);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(80, 17);
            this.checkBox7.TabIndex = 84;
            this.checkBox7.Text = "checkBox7";
            this.checkBox7.UseVisualStyleBackColor = true;
            // 
            // checkBox8
            // 
            this.checkBox8.AutoSize = true;
            this.checkBox8.Location = new System.Drawing.Point(257, 303);
            this.checkBox8.Name = "checkBox8";
            this.checkBox8.Size = new System.Drawing.Size(80, 17);
            this.checkBox8.TabIndex = 83;
            this.checkBox8.Text = "checkBox8";
            this.checkBox8.UseVisualStyleBackColor = true;
            // 
            // checkBox9
            // 
            this.checkBox9.AutoSize = true;
            this.checkBox9.Location = new System.Drawing.Point(257, 326);
            this.checkBox9.Name = "checkBox9";
            this.checkBox9.Size = new System.Drawing.Size(80, 17);
            this.checkBox9.TabIndex = 82;
            this.checkBox9.Text = "checkBox9";
            this.checkBox9.UseVisualStyleBackColor = true;
            // 
            // checkBox10
            // 
            this.checkBox10.AutoSize = true;
            this.checkBox10.Location = new System.Drawing.Point(257, 398);
            this.checkBox10.Name = "checkBox10";
            this.checkBox10.Size = new System.Drawing.Size(86, 17);
            this.checkBox10.TabIndex = 87;
            this.checkBox10.Text = "checkBox10";
            this.checkBox10.UseVisualStyleBackColor = true;
            // 
            // checkBox11
            // 
            this.checkBox11.AutoSize = true;
            this.checkBox11.Location = new System.Drawing.Point(257, 421);
            this.checkBox11.Name = "checkBox11";
            this.checkBox11.Size = new System.Drawing.Size(86, 17);
            this.checkBox11.TabIndex = 86;
            this.checkBox11.Text = "checkBox11";
            this.checkBox11.UseVisualStyleBackColor = true;
            // 
            // checkBox12
            // 
            this.checkBox12.AutoSize = true;
            this.checkBox12.Location = new System.Drawing.Point(257, 450);
            this.checkBox12.Name = "checkBox12";
            this.checkBox12.Size = new System.Drawing.Size(86, 17);
            this.checkBox12.TabIndex = 85;
            this.checkBox12.Text = "checkBox12";
            this.checkBox12.UseVisualStyleBackColor = true;
            // 
            // checkBox13
            // 
            this.checkBox13.AutoSize = true;
            this.checkBox13.Location = new System.Drawing.Point(694, 37);
            this.checkBox13.Name = "checkBox13";
            this.checkBox13.Size = new System.Drawing.Size(86, 17);
            this.checkBox13.TabIndex = 90;
            this.checkBox13.Text = "checkBox13";
            this.checkBox13.UseVisualStyleBackColor = true;
            // 
            // checkBox14
            // 
            this.checkBox14.AutoSize = true;
            this.checkBox14.Location = new System.Drawing.Point(694, 63);
            this.checkBox14.Name = "checkBox14";
            this.checkBox14.Size = new System.Drawing.Size(86, 17);
            this.checkBox14.TabIndex = 89;
            this.checkBox14.Text = "checkBox14";
            this.checkBox14.UseVisualStyleBackColor = true;
            // 
            // checkBox15
            // 
            this.checkBox15.AutoSize = true;
            this.checkBox15.Location = new System.Drawing.Point(694, 90);
            this.checkBox15.Name = "checkBox15";
            this.checkBox15.Size = new System.Drawing.Size(86, 17);
            this.checkBox15.TabIndex = 88;
            this.checkBox15.Text = "checkBox15";
            this.checkBox15.UseVisualStyleBackColor = true;
            // 
            // checkBox16
            // 
            this.checkBox16.AutoSize = true;
            this.checkBox16.Location = new System.Drawing.Point(694, 161);
            this.checkBox16.Name = "checkBox16";
            this.checkBox16.Size = new System.Drawing.Size(86, 17);
            this.checkBox16.TabIndex = 93;
            this.checkBox16.Text = "checkBox16";
            this.checkBox16.UseVisualStyleBackColor = true;
            // 
            // checkBox17
            // 
            this.checkBox17.AutoSize = true;
            this.checkBox17.Location = new System.Drawing.Point(694, 185);
            this.checkBox17.Name = "checkBox17";
            this.checkBox17.Size = new System.Drawing.Size(86, 17);
            this.checkBox17.TabIndex = 92;
            this.checkBox17.Text = "checkBox17";
            this.checkBox17.UseVisualStyleBackColor = true;
            // 
            // checkBox18
            // 
            this.checkBox18.AutoSize = true;
            this.checkBox18.Location = new System.Drawing.Point(694, 208);
            this.checkBox18.Name = "checkBox18";
            this.checkBox18.Size = new System.Drawing.Size(86, 17);
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
            this.Controls.Add(this.priceSoupSaladName);
            this.Controls.Add(this.priceEntreeName);
            this.Controls.Add(this.priceDessertsName);
            this.Controls.Add(this.priceDrinkKidName);
            this.Controls.Add(this.priceDrinkAdultName);
            this.Controls.Add(this.priceAppetizersName);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.priceDrinkKid2);
            this.Controls.Add(this.priceDrinkKid1);
            this.Controls.Add(this.priceDesserts3);
            this.Controls.Add(this.priceDesserts2);
            this.Controls.Add(this.priceDesserts1);
            this.Controls.Add(this.priceDrinkAdult3);
            this.Controls.Add(this.priceDrinkAdult2);
            this.Controls.Add(this.priceDrinkAdult1);
            this.Controls.Add(this.priceDrinkKid3);
            this.Controls.Add(this.priceSoupSalad2);
            this.Controls.Add(this.priceSoupSalad1);
            this.Controls.Add(this.priceAppetizer3);
            this.Controls.Add(this.priceAppetizer2);
            this.Controls.Add(this.priceAppetizer1);
            this.Controls.Add(this.priceEntree3);
            this.Controls.Add(this.priceEntree2);
            this.Controls.Add(this.priceEntree1);
            this.Controls.Add(this.priceSoupSalad3);
            this.Controls.Add(this.appetizersName);
            this.Controls.Add(this.dessertsName);
            this.Controls.Add(this.soupSaladName);
            this.Controls.Add(this.drinkKidName);
            this.Controls.Add(this.entreeName);
            this.Controls.Add(this.drinkAdultName);
            this.Controls.Add(this.selectDrinkKid2);
            this.Controls.Add(this.drinkKid2);
            this.Controls.Add(this.drinkKid1);
            this.Controls.Add(this.dessert3);
            this.Controls.Add(this.desserts2);
            this.Controls.Add(this.desserts1);
            this.Controls.Add(this.entree3);
            this.Controls.Add(this.entree2);
            this.Controls.Add(this.selectDrinkKid1);
            this.Controls.Add(this.selectDesserts3);
            this.Controls.Add(this.selectDesserts2);
            this.Controls.Add(this.selectDesserts1);
            this.Controls.Add(this.selectEntree3);
            this.Controls.Add(this.selectEntree2);
            this.Controls.Add(this.drinkAdult3);
            this.Controls.Add(this.drinkAdult2);
            this.Controls.Add(this.drinkAdult1);
            this.Controls.Add(this.drinkKid3);
            this.Controls.Add(this.selectDrinkAdult3);
            this.Controls.Add(this.selectDrinkAdult2);
            this.Controls.Add(this.selectDrinkAdult1);
            this.Controls.Add(this.selectDrinkKid3);
            this.Controls.Add(this.selectEntree1);
            this.Controls.Add(this.entree1);
            this.Controls.Add(this.soupSalad3);
            this.Controls.Add(this.soupSalad2);
            this.Controls.Add(this.soupSalad1);
            this.Controls.Add(this.appetizer3);
            this.Controls.Add(this.appetizer2);
            this.Controls.Add(this.appetizer1);
            this.Controls.Add(this.selectSoupSalad3);
            this.Controls.Add(this.selectSoupSalad2);
            this.Controls.Add(this.selectSoupSalad1);
            this.Controls.Add(this.selectAppetizer3);
            this.Controls.Add(this.selectAppetizer2);
            this.Controls.Add(this.selectAppetizer1);
            this.Name = "MenuForm";
            this.Load += new System.EventHandler(this.MenuForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.selectAppetizer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectAppetizer2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectAppetizer3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectSoupSalad1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectSoupSalad2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectSoupSalad3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectEntree1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectDrinkAdult3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectDrinkAdult2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectDrinkAdult1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectDrinkKid3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectDrinkKid2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectDrinkKid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectDesserts3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectDesserts2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectDesserts1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectEntree3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectEntree2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            appetizer1.Text = "Schmittyz Chicken";
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
                menuValues[0] = (int)selectAppetizer1.Value;
            }
            else
            {
                selectAppetizer1.Value = 0;
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
                menuValues[1] = (int)selectAppetizer2.Value;
            }
            else
            {
                selectAppetizer2.Value = 0;
                menuValues[1] = 0;

            }
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            if (checkBox3.CheckState != CheckState.Checked)
            {
                menuValues[2] = (int)selectAppetizer3.Value;
            }
            else
            {
                selectAppetizer3.Value = 0;
                menuValues[2] = 0;
            }
        }


        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {
            if (checkBox4.CheckState != CheckState.Checked)
            {
                menuValues[3] = (int)selectSoupSalad1.Value;
            }
            else
            {
                selectSoupSalad1.Value = 0;
                menuValues[3] = 0;
            }
        }

        private void numericUpDown5_ValueChanged(object sender, EventArgs e)
        {
            if (checkBox5.CheckState != CheckState.Checked)
            {
                menuValues[4] = (int)selectSoupSalad2.Value;
            }
            else
            {
                selectSoupSalad2.Value = 0;
                menuValues[4] = 0;
            }
        }

        private void numericUpDown6_ValueChanged(object sender, EventArgs e)
        {
            if (checkBox6.CheckState != CheckState.Checked)
            {
                menuValues[5] = (int)selectSoupSalad3.Value;
            }
            else
            {
                selectSoupSalad3.Value = 0;
                menuValues[5] = 0;

            }
        }

        private void numericUpDown7_ValueChanged(object sender, EventArgs e)
        {
            if (checkBox7.CheckState != CheckState.Checked)
            {
                menuValues[6] = (int)selectEntree1.Value;
            }
            else
            {
                selectEntree1.Value = 0;
                menuValues[6] = 0;

            }
        }
       
        //The eighth one... Not sure how it became 21
        private void numericUpDown21_ValueChanged(object sender, EventArgs e)
        {
            if (checkBox8.CheckState != CheckState.Checked)
            {
                menuValues[7] = (int)selectEntree2.Value;
            }
            else
            {
                selectEntree2.Value = 0;
                menuValues[7] = 0;
            }
        }


        //The ninth one
        private void numericUpDown20_ValueChanged(object sender, EventArgs e)
        {
            if (checkBox9.CheckState != CheckState.Checked)
            {
                menuValues[8] = (int)selectEntree3.Value;
            }
            else
            {
                selectEntree3.Value = 0;
                menuValues[8] = 0;
            }
        }
        //The tenth one
        private void numericUpDown19_ValueChanged(object sender, EventArgs e)
        {
            if (checkBox10.CheckState != CheckState.Checked)
            {
                menuValues[9] = (int)selectDesserts1.Value;
            }
            else
            {
                selectDesserts1.Value = 0;
                menuValues[9] = 0;
            }
        }
        //11
        private void numericUpDown18_ValueChanged(object sender, EventArgs e)
        {
            if (checkBox11.CheckState != CheckState.Checked)
            {
                menuValues[10] = (int)selectDesserts2.Value;
            }
            else
            {
                selectDesserts2.Value = 0;
                menuValues[10] = 0;
            }
        }
        //12
        private void numericUpDown17_ValueChanged(object sender, EventArgs e)
        {
            if (checkBox12.CheckState != CheckState.Checked)
            {
                menuValues[11] = (int)selectDesserts3.Value;
            }
            else
            {
                selectDesserts3.Value = 0;
                menuValues[11] = 0;
            }
        }
        //13
        private void numericUpDown16_ValueChanged(object sender, EventArgs e)
        {
            if (checkBox13.CheckState != CheckState.Checked)
            {
                menuValues[12] = (int)selectDrinkKid1.Value;
            }
            else
            {
                selectDrinkKid1.Value = 0;
                menuValues[12] = 0;
            }
        }
        //14
        private void numericUpDown15_ValueChanged(object sender, EventArgs e)
        {
            if (checkBox14.CheckState != CheckState.Checked)
            {
                menuValues[13] = (int)selectDrinkKid2.Value;
            }
            else
            {
                selectDrinkKid2.Value = 0;
                menuValues[13] = 0;
            }
        }
        //15
        private void numericUpDown14_ValueChanged(object sender, EventArgs e)
        {
            if (checkBox15.CheckState != CheckState.Checked)
            {
                menuValues[14] = (int)selectDrinkKid3.Value;
            }
            else
            {
                selectDrinkKid3.Value = 0;
                menuValues[14] = 0;
            }
        }
        //16
        private void numericUpDown13_ValueChanged(object sender, EventArgs e)
        {
            if (checkBox16.CheckState != CheckState.Checked)
            {
                menuValues[15] = (int)selectDrinkAdult1.Value;
            }
            else
            {
                selectDrinkAdult1.Value = 0;
                menuValues[15] = 0;
            }
        }

      
        //17
        private void numericUpDown12_ValueChanged(object sender, EventArgs e)
        {
            if (checkBox17.CheckState != CheckState.Checked)
            {
                menuValues[16] = (int)selectDrinkAdult2.Value;
            }
            else
            {
                selectDrinkAdult2.Value = 0;
                menuValues[16] = 0;
            }
        }

        //18
        private void numericUpDown11_ValueChanged(object sender, EventArgs e)
        {
            if (checkBox18.CheckState != CheckState.Checked)
            {
                menuValues[17] = (int)selectDrinkAdult3.Value;
            }
            else
            {
                selectDrinkAdult3.Value = 0;
                menuValues[17] = 0;
            }
        }










    }
}