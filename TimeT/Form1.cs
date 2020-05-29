using System;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;


namespace TimeT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            this.Size = Screen.PrimaryScreen.WorkingArea.Size;

            int counter = 0;
            string line; 
            //Read file and display
            StreamReader file = new StreamReader("Dsale.txt");
            while ((line = file.ReadLine()) != null) {

                listBox11.Items.Add(line);
                counter++; 
            }
            file.Close(); 
        }

        static double fSale = 0;
        //Implemnetaiton of Total sale
        private void finalSale()
        {
            string dt = DateTime.Now.ToString();
            fSale += total + total1 + total2 + total4 + total5 + total6 + total7 + total8 + total9 + total10;
          
            listBox10.Items.Add(dt);
            listBox10.Items.Add(fSale.ToString());
             
        }
        //Clear listbox
        private void clrListBox() {

            listBox10.Items.Clear(); 
        }
        //To save daily sale
        private void button41_Click(object sender, EventArgs e)
        {
            if (listBox10.Items.Count > 0)
            {
                
                using (TextWriter TW = new StreamWriter("Dsale.txt", true))
                {
                      
                    foreach (string itemText in listBox10.Items)
                    {

                        TW.WriteLine(itemText);
                    }

                }
                listBox10.Items.Clear(); 
                Process.Start("Dsale.txt");
            }
        }

        int hour, min, sec, ms = 0;
        int hour1, min1, sec1, ms1 = 0; //#2
        int hour2, min2, sec2, ms2 = 0; //#3
        int hour4, min4, sec4, ms4 = 0; //#4
        int hour5, min5, sec5, ms5 = 0; //#5
        int hour6, min6, sec6, ms6 = 0; //#6
        int hour7, min7, sec7, ms7 = 0; //#7
        int hour8, min8, sec8, ms8 = 0; //#8
        int hour9, min9, sec9, ms9 = 0; //#9
        int hour10, min10, sec10, ms10 = 0; //#10

        private void timer1_Tick(object sender, EventArgs e)
        {
            label3.Text = hour + ":" + min + ":" + sec + ":" + ms.ToString();
            ms++;
            if (ms > 15)
            {
                sec++;
                ms = 0;
            }

            else
            {
                ms++;
            }

            if (sec > 60)
            {
                min++;
                sec = 0;

            }

            if (min > 60)
            {
                hour++;
                min = 0;
            }

            //calling Duration Method
            Duration();
        }
        //Timer2
        private void timer2_Tick(object sender, EventArgs e)
        {
            label9.Text = hour1 + ":" + min1 + ":" + sec1 + ":" + ms1.ToString();
            ms1++;
            if (ms1 > 15)
            {
                sec1++;
                ms1 = 0;
            }

            else
            {
                ms1++;
            }

            if (sec1 > 60)
            {
                min1++;
                sec1 = 0;

            }

            if (min1 > 60)
            {
                hour1++;
                min1 = 0;
            }

            //calling Duration Method
            Duration1();
        }
        //Timer3
        private void timer3_Tick(object sender, EventArgs e)
        {
            label13.Text = hour2 + ":" + min2 + ":" + sec2 + ":" + ms2.ToString();
            ms2++;
            if (ms2 > 15)
            {
                sec2++;
                ms2 = 0;
            }

            else
            {
                ms2++;
            }

            if (sec2 > 60)
            {
                min2++;
                sec2 = 0;

            }

            if (min2 > 60)
            {
                hour2++;
                min2 = 0;
            }

            //calling Duration Method
            Duration2();
        }
        //timer4     
//LabelChange
        private void timer4_Tick(object sender, EventArgs e)
        {
            label18.Text = hour4 + ":" + min4 + ":" + sec4 + ":" + ms4.ToString();
            ms4++;
            if (ms4 > 15)
            {
                sec4++;
                ms4 = 0;
            }

            else
            {
                ms4++;
            }

            if (sec4 > 60)
            {
                min4++;
                sec4 = 0;

            }

            if (min4 > 60)
            {
                hour4++;
                min4 = 0;
            }

            //calling Duration Method
            Duration4();
        }
        //timer 5
        private void timer5_Tick_1(object sender, EventArgs e)
        {
            label22.Text = hour5 + ":" + min5 + ":" + sec5 + ":" + ms5.ToString();
            ms5++;
            if (ms5 > 15)
            {
                sec5++;
                ms5 = 0;
            }

            else
            {
                ms5++;
            }

            if (sec5 > 60)
            {
                min5++;
                sec5 = 0;

            }

            if (min5 > 60)
            {
                hour5++;
                min5 = 0;
            }

            //calling Duration Method
            Duration5();
        }
        //timer 6
        private void timer6_Tick_1(object sender, EventArgs e)
        {
            label26.Text = hour6 + ":" + min6 + ":" + sec6 + ":" + ms6.ToString();
            ms6++;
            if (ms6 > 15)
            {
                sec6++;
                ms6 = 0;
            }

            else
            {
                ms6++;
            }

            if (sec6 > 60)
            {
                min6++;
                sec6 = 0;

            }

            if (min6 > 60)
            {
                hour6++;
                min6 = 0;
            }

            //calling Duration Method
            Duration6();
        }
        //timer 7
        private void timer7_Tick_1(object sender, EventArgs e)
        {

            label30.Text = hour7 + ":" + min7 + ":" + sec7 + ":" + ms7.ToString();
            ms7++;
            if (ms7 > 15)
            {
                sec7++;
                ms7 = 0;
            }

            else
            {
                ms7++;
            }

            if (sec7 > 60)
            {
                min7++;
                sec7 = 0;

            }

            if (min7 > 60)
            {
                hour7++;
                min7 = 0;
            }

            //calling Duration Method
            Duration7();
        }
        //timer8
        private void timer8_Tick(object sender, EventArgs e)
        {
            label34.Text = hour8 + ":" + min8 + ":" + sec8 + ":" + ms8.ToString();
            ms8++;
            if (ms8 > 15)
            {
                sec8++;
                ms8 = 0;
            }

            else
            {
                ms8++;
            }

            if (sec8 > 60)
            {
                min8++;
                sec8 = 0;

            }

            if (min8 > 60)
            {
                hour8++;
                min8 = 0;
            }

            //calling Duration Method
            Duration8();
        }
        //timer9
        private void timer9_Tick(object sender, EventArgs e)
        {
            label38.Text = hour9 + ":" + min9 + ":" + sec9 + ":" + ms9.ToString();
            ms9++;
            if (ms9 > 15)
            {
                sec9++;
                ms9 = 0;
            }

            else
            {
                ms9++;
            }

            if (sec9 > 60)
            {
                min9++;
                sec9 = 0;

            }

            if (min9 > 60)
            {
                hour9++;
                min9 = 0;
            }

            //calling Duration Method
            Duration9();
        }
        //timer10
        private void timer10_Tick(object sender, EventArgs e)
        {
            label42.Text = hour10 + ":" + min10 + ":" + sec10 + ":" + ms10.ToString();
            ms10++;
            if (ms10 > 15)
            {
                sec10++;
                ms10 = 0;
            }

            else
            {
                ms10++;
            }

            if (sec10 > 60)
            {
                min10++;
                sec10 = 0;

            }

            if (min10 > 60)
            {
                hour10++;
                min10 = 0;
            }

            //calling Duration Method
            Duration10();
        }

        //method to save in text file
        private void saveInfile()
        {

            if (Bill.Items.Count > 0)
            {

                using (TextWriter TW = new StreamWriter("list.txt", true))
                {
                    TW.WriteLine(label2.Text);
                    TW.WriteLine(label4.Text);
                    foreach (string itemText in Bill.Items)
                    {

                        TW.WriteLine(itemText);
                    }

                }
                Process.Start("list.txt");
            }

        }
        //#2
        private void saveInfile1()
        {

            if (listBox1.Items.Count > 0)
            {

                using (TextWriter TW = new StreamWriter("list1.txt", true))
                {
                    TW.WriteLine(label7.Text);
                    TW.WriteLine(label8.Text);
                    foreach (string itemText in listBox1.Items)
                    {

                        TW.WriteLine(itemText);
                    }

                }
                Process.Start("list1.txt");
            }
        }
        //#3
        private void saveInfile2()
        {

            if (listBox2.Items.Count > 0)
            {

                using (TextWriter TW = new StreamWriter("list2.txt", true))
                {
                    TW.WriteLine(label11.Text);
                    TW.WriteLine(label12.Text);
                    foreach (string itemText in listBox2.Items)
                    {

                        TW.WriteLine(itemText);
                    }

                }
                Process.Start("list2.txt");
            }
        }
//labelChange
        //#4
        private void saveInfile4()
        {

            if (listBox3.Items.Count > 0)
            {

                using (TextWriter TW = new StreamWriter("list4.txt", true))
                {
                    TW.WriteLine(label16.Text);
                    TW.WriteLine(label17.Text);
                    foreach (string itemText in listBox3.Items)
                    {

                        TW.WriteLine(itemText);
                    }

                }
                Process.Start("list4.txt");
            }
        }
        //#5
        private void saveInfile5()
        {

            if (listBox4.Items.Count > 0)
            {

                using (TextWriter TW = new StreamWriter("list5.txt", true))
                {
                    TW.WriteLine(label20.Text);
                    TW.WriteLine(label21.Text);
                    foreach (string itemText in listBox4.Items)
                    {

                        TW.WriteLine(itemText);
                    }

                }
                Process.Start("list5.txt");
            }
        }
        //#6
        private void saveInfile6()
        {

            if (listBox5.Items.Count > 0)
            {

                using (TextWriter TW = new StreamWriter("list6.txt", true))
                {
                    TW.WriteLine(label24.Text);
                    TW.WriteLine(label25.Text);
                    foreach (string itemText in listBox5.Items)
                    {

                        TW.WriteLine(itemText);
                    }

                }
                Process.Start("list6.txt");
            }
        }
        //#7
        private void saveInfile7()
        {

            if (listBox6.Items.Count > 0)
            {

                using (TextWriter TW = new StreamWriter("list7.txt", true))
                {
                    TW.WriteLine(label28.Text);
                    TW.WriteLine(label29.Text);
                    foreach (string itemText in listBox6.Items)
                    {

                        TW.WriteLine(itemText);
                    }

                }
                Process.Start("list7.txt");
            }
        }
        //#8
        private void saveInfile8()
        {

            if (listBox7.Items.Count > 0)
            {

                using (TextWriter TW = new StreamWriter("list8.txt", true))
                {
                    TW.WriteLine(label32.Text);
                    TW.WriteLine(label33.Text);
                    foreach (string itemText in listBox7.Items)
                    {

                        TW.WriteLine(itemText);
                    }

                }
                Process.Start("list8.txt");
            }
        }
        //#9
        private void saveInfile9()
        {

            if (listBox8.Items.Count > 0)
            {

                using (TextWriter TW = new StreamWriter("list9.txt", true))
                {
                    TW.WriteLine(label36.Text);
                    TW.WriteLine(label37.Text);
                    foreach (string itemText in listBox8.Items)
                    {

                        TW.WriteLine(itemText);
                    }

                }
                Process.Start("list9.txt");
            }
        }
        //#10
        private void saveInfile10()
        {

            if (listBox9.Items.Count > 0)
            {

                using (TextWriter TW = new StreamWriter("list10.txt", true))
                {
                    TW.WriteLine(label40.Text);
                    TW.WriteLine(label41.Text);
                    foreach (string itemText in listBox9.Items)
                    {

                        TW.WriteLine(itemText);
                    }

                }
                Process.Start("list10.txt");
            }
        }

        //Calculate Duration
        public void Duration()
        {
            double y = (min * 16.67);
            double z = (hour * 1000);

            double x = (y + z);
            label5.Text = x.ToString();
        }
        //#2
        public void Duration1()
        {
            double y1 = (min1 * 16.67);
            double z1 = (hour1 * 1000);

            double x1 = (y1 + z1);
            label6.Text = x1.ToString();
        }
        //#3
        public void Duration2()
        {
            double y2 = (min2 * 16.67);
            double z2 = (hour2 * 1000);

            double x2 = (y2 + z2);
            label10.Text = x2.ToString();
        }
        //#4
        public void Duration4()
        {
            double y4 = (min4 * 16.67);
            double z4 = (hour4 * 1000);

            double x4 = (y4 + z4);
            label15.Text = x4.ToString();
        }
        //#5
        public void Duration5()
        {
            double y5 = (min5 * 16.67);
            double z5 = (hour5 * 1000);

            double x5 = (y5 + z5);
            label19.Text = x5.ToString();
        }
        //#6
        public void Duration6()
        {
            double y6 = (min6 * 16.67);
            double z6 = (hour6 * 1000);

            double x6 = (y6 + z6);
            label23.Text = x6.ToString();
        }
        //#7
        public void Duration7()
        {
            double y7 = (min7 * 16.67);
            double z7 = (hour7 * 1000);

            double x7 = (y7 + z7);
            label27.Text = x7.ToString();
        }
        //#8
        public void Duration8()
        {
            double y8 = (min8 * 16.67);
            double z8 = (hour8 * 1000);

            double x8 = (y8 + z8);
            label31.Text = x8.ToString();
        }
        //#9
        public void Duration9()
        {
            double y9 = (min9 * 16.67);
            double z9 = (hour9 * 1000);

            double x9 = (y9 + z9);
            label35.Text = x9.ToString();
        }
        //#10
        public void Duration10()
        {
            double y10 = (min10 * 16.67);
            double z10 = (hour10 * 1000);

            double x10 = (y10 + z10);
            label39.Text = x10.ToString();
        }


        //Testing Bill
        static double subtotal = 0;
        static double total = 0;
        static double subtotal1 = 0; //for #2
        static double total1 = 0;
        static double subtotal2 = 0; //for #3
        static double total2 = 0;
        static double subtotal4 = 0; //for #4
        static double total4 = 0;
        static double subtotal5 = 0; //for #5
        static double total5 = 0;
        static double subtotal6 = 0; //for #6
        static double total6 = 0;
        static double subtotal7 = 0; //for #7
        static double total7 = 0;
        static double subtotal8 = 0; //for #8
        static double total8 = 0;
        static double subtotal9 = 0; //for #9
        static double total9 = 0;
        static double subtotal10 = 0; //for #10
        static double total10 = 0;


        string finalBill = "";
        string finalBill1 = ""; //for #2
        string finalBill2 = ""; //for #3
        string finalBill4 = ""; //for #4 
        string finalBill5 = ""; //for #5 
        string finalBill6 = ""; //for #6 
        string finalBill7 = ""; //for #7
        string finalBill8 = ""; //for #8
        string finalBill9 = ""; //for #9
        string finalBill10 = ""; //for #10

        //Calculate Hours 
        static double x, y, z;
        static double x1, y1, z1; //for #2
        static double x2, y2, z2; //for #3
        static double x4, y4, z4; //for #4
        static double x5, y5, z5; //for #5
        static double x6, y6, z6; //for #6
        static double x7, y7, z7; //for #7
        static double x8, y8, z8; //for #8
        static double x9, y9, z9; //for #9
        static double x10, y10, z10; //for #10

        //Struct Orders
        public struct Orders
        {
            public string item;
            public double price;
            public double x;

        }
        //#2 
        public struct Orders1
        {
            public string item1;
            public double price1;
            public double x1;
        }
        //#3 
        public struct Orders2
        {
            public string item2;
            public double price2;
            public double x2;
        }
        //#4 
        public struct Orders4
        {
            public string item4;
            public double price4;
            public double x4;
        }
        //#5 
        public struct Orders5
        {
            public string item5;
            public double price5;
            public double x5;
        }
        //#6 
        public struct Orders6
        {
            public string item6;
            public double price6;
            public double x6;
        }
        //#7 
        public struct Orders7
        {
            public string item7;
            public double price7;
            public double x7;
        }
        //#8
        public struct Orders8
        {
            public string item8;
            public double price8;
            public double x8;
        }
        //#9 
        public struct Orders9
        {
            public string item9;
            public double price9;
            public double x9;
        }
        //#10 
        public struct Orders10
        {
            public string item10;
            public double price10;
            public double x10;
        }


        Orders order = new Orders();
        Orders1 order1 = new Orders1(); //for #2
        Orders2 order2 = new Orders2(); //for #3
        Orders4 order4 = new Orders4(); //for #4
        Orders5 order5 = new Orders5(); //for #5
        Orders6 order6 = new Orders6(); //for #6
        Orders7 order7 = new Orders7(); //for #7
        Orders8 order8 = new Orders8(); //for #8
        Orders9 order9 = new Orders9(); //for #9
        Orders10 order10 = new Orders10(); //for #10

        private void getValues(string custOrder)
        {

            order.item = custOrder.Split('K')[0];
            order.price = Convert.ToDouble(custOrder.Split('K')[1]);
            finalBill += "Food: " + order.item + "\nPrice: " + order.price.ToString("C2") + "\n";
            updateBill();

        }
        //#2
        private void getValues1(string custOrder)
        {

            order1.item1 = custOrder.Split('K')[0];
            order1.price1 = Convert.ToDouble(custOrder.Split('K')[1]);
            finalBill1 += "Food: " + order1.item1 + "\nPrice: " + order1.price1.ToString("C2") + "\n";
            updateBill1();

        }
        //#3
        private void getValues2(string custOrder)
        {

            order2.item2 = custOrder.Split('K')[0];
            order2.price2 = Convert.ToDouble(custOrder.Split('K')[1]);
            finalBill2 += "Food: " + order2.item2 + "\nPrice: " + order2.price2.ToString("C2") + "\n";
            updateBill2();

        }
        //#4
        private void getValues4(string custOrder)
        {

            order4.item4 = custOrder.Split('K')[0];
            order4.price4 = Convert.ToDouble(custOrder.Split('K')[1]);
            finalBill4 += "Food: " + order4.item4 + "\nPrice: " + order4.price4.ToString("C2") + "\n";
            updateBill4();

        }
        //#5
        private void getValues5(string custOrder)
        {

            order5.item5 = custOrder.Split('K')[0];
            order5.price5 = Convert.ToDouble(custOrder.Split('K')[1]);
            finalBill5 += "Food: " + order5.item5 + "\nPrice: " + order5.price5.ToString("C2") + "\n";
            updateBill5();

        }
        //#6
        private void getValues6(string custOrder)
        {

            order6.item6 = custOrder.Split('K')[0];
            order6.price6 = Convert.ToDouble(custOrder.Split('K')[1]);
            finalBill6 += "Food: " + order6.item6 + "\nPrice: " + order6.price6.ToString("C2") + "\n";
            updateBill6();

        }
        //#7
        private void getValues7(string custOrder)
        {

            order7.item7 = custOrder.Split('K')[0];
            order7.price7 = Convert.ToDouble(custOrder.Split('K')[1]);
            finalBill7 += "Food: " + order7.item7 + "\nPrice: " + order7.price7.ToString("C2") + "\n";
            updateBill7();

        }
        //#8
        private void getValues8(string custOrder)
        {

            order8.item8 = custOrder.Split('K')[0];
            order8.price8 = Convert.ToDouble(custOrder.Split('K')[1]);
            finalBill8 += "Food: " + order8.item8 + "\nPrice: " + order8.price8.ToString("C2") + "\n";
            updateBill8();

        }
        //#9
        private void getValues9(string custOrder)
        {

            order9.item9 = custOrder.Split('K')[0];
            order9.price9 = Convert.ToDouble(custOrder.Split('K')[1]);
            finalBill9 += "Food: " + order9.item9 + "\nPrice: " + order9.price9.ToString("C2") + "\n";
            updateBill9();

        }
        //#10
        private void getValues10(string custOrder)
        {

            order10.item10 = custOrder.Split('K')[0];
            order10.price10 = Convert.ToDouble(custOrder.Split('K')[1]);
            finalBill10 += "Food: " + order10.item10 + "\nPrice: " + order10.price10.ToString("C2") + "\n";
            updateBill10();

        }

        private void updateBill()
        {
            //To calculate Total 
            y = (min * 16.67);
            z = (hour * 1000);
            x = y + z;

            //To calculate food
            subtotal += order.price;
            total = subtotal + x;
            //  totalTaxes += order.price;

            Bill.Items.Clear();
            Bill.Items.Add("No." + comboBox3.SelectedItem);
            Bill.Items.AddRange(finalBill.Split('\n'));
            Bill.Items.Add("Food Total: " + subtotal.ToString("C2"));
            Bill.Items.Add("Game Play: " + x.ToString());
            Bill.Items.Add("Total: " + total.ToString("C2"));
            Bill.Items.Add("***********");

        }
        //#2
        private void updateBill1()
        {
            //To calculate Total 
            y1 = (min1 * 16.67);
            z1 = (hour1 * 1000);
            x1 = y1 + z1;

            //To calculate food
            subtotal1 += order1.price1;
            total1 = subtotal1 + x1;
            //  totalTaxes += order.price;

            listBox1.Items.Clear();
            listBox1.Items.Add("No." + comboBox4.SelectedItem);
            listBox1.Items.AddRange(finalBill1.Split('\n'));
            listBox1.Items.Add("Food Total: " + subtotal1.ToString("C2"));
            listBox1.Items.Add("Game Play: " + x1.ToString());
            listBox1.Items.Add("Total: " + total1.ToString("C2"));
            listBox1.Items.Add("***********");

        }
        //#3
        private void updateBill2()
        {
            //To calculate Total 
            y2 = (min2 * 16.67);
            z2 = (hour2 * 1000);
            x2 = y2 + z2;

            //To calculate food
            subtotal2 += order2.price2;
            total2 = subtotal2 + x2;


            listBox2.Items.Clear();
            listBox2.Items.Add("No." + comboBox7.SelectedItem);
            listBox2.Items.AddRange(finalBill2.Split('\n'));
            listBox2.Items.Add("Food Total: " + subtotal2.ToString("C2"));
            listBox2.Items.Add("Game Play: " + x2.ToString());
            listBox2.Items.Add("Total: " + total2.ToString("C2"));
            listBox2.Items.Add("***********");

        }
        //#4
        private void updateBill4()
        {
            //To calculate Total 
            y4 = (min4 * 16.67);
            z4 = (hour4 * 1000);
            x4 = y4 + z4;

            //To calculate food
            subtotal4 += order4.price4;
            total4 = subtotal4 + x4;


            listBox3.Items.Clear();
            listBox3.Items.Add("No." + comboBox10.SelectedItem);
            listBox3.Items.AddRange(finalBill4.Split('\n'));
            listBox3.Items.Add("Food Total: " + subtotal4.ToString("C2"));
            listBox3.Items.Add("Game Play: " + x4.ToString());
            listBox3.Items.Add("Total: " + total4.ToString("C2"));
            listBox3.Items.Add("***********");

        }
        //#5
        private void updateBill5()
        {
            //To calculate Total 
            y5 = (min5 * 16.67);
            z5 = (hour5 * 1000);
            x5 = y5 + z5;

            //To calculate food
            subtotal5 += order5.price5;
            total5 = subtotal5 + x5;


            listBox4.Items.Clear();
            listBox4.Items.Add("No." + comboBox13.SelectedItem);
            listBox4.Items.AddRange(finalBill5.Split('\n'));
            listBox4.Items.Add("Food Total: " + subtotal5.ToString("C2"));
            listBox4.Items.Add("Game Play: " + x5.ToString());
            listBox4.Items.Add("Total: " + total5.ToString("C2"));
            listBox4.Items.Add("***********");

        }
        //#6
        private void updateBill6()
        {
            //To calculate Total 
            y6 = (min6 * 16.67);
            z6 = (hour6 * 1000);
            x6 = y6 + z6;

            //To calculate food
            subtotal6 += order6.price6;
            total6 = subtotal6 + x6;


            listBox5.Items.Clear();
            listBox5.Items.Add("No." + comboBox16.SelectedItem);
            listBox5.Items.AddRange(finalBill6.Split('\n'));
            listBox5.Items.Add("Food Total: " + subtotal6.ToString("C2"));
            listBox5.Items.Add("Game Play: " + x6.ToString());
            listBox5.Items.Add("Total: " + total6.ToString("C2"));
            listBox5.Items.Add("***********");

        }
        //#7
        private void updateBill7()
        {
            //To calculate Total 
            y7 = (min7 * 16.67);
            z7 = (hour7 * 1000);
            x7 = y7 + z7;

            //To calculate food
            subtotal7 += order7.price7;
            total7 = subtotal7 + x7;


            listBox6.Items.Clear();
            listBox6.Items.Add("No." + comboBox19.SelectedItem);
            listBox6.Items.AddRange(finalBill7.Split('\n'));
            listBox6.Items.Add("Food Total: " + subtotal7.ToString("C2"));
            listBox6.Items.Add("Game Play: " + x7.ToString());
            listBox6.Items.Add("Total: " + total7.ToString("C2"));
            listBox6.Items.Add("***********");

        }
        //#8
        private void updateBill8()
        {
            //To calculate Total 
            y8 = (min8 * 16.67);
            z8 = (hour8 * 1000);
            x8 = y8 + z8;

            //To calculate food
            subtotal8 += order8.price8;
            total8 = subtotal8 + x8;


            listBox7.Items.Clear();
            listBox7.Items.Add("No." + comboBox22.SelectedItem);
            listBox7.Items.AddRange(finalBill8.Split('\n'));
            listBox7.Items.Add("Food Total: " + subtotal8.ToString("C2"));
            listBox7.Items.Add("Game Play: " + x8.ToString());
            listBox7.Items.Add("Total: " + total8.ToString("C2"));
            listBox7.Items.Add("***********");

        }
        //#9
        private void updateBill9()
        {
            //To calculate Total 
            y9 = (min9 * 16.67);
            z9 = (hour9 * 1000);
            x9 = y9 + z9;

            //To calculate food
            subtotal9 += order9.price9;
            total9 = subtotal9 + x9;


            listBox8.Items.Clear();
            listBox8.Items.Add("No." + comboBox25.SelectedItem);
            listBox8.Items.AddRange(finalBill9.Split('\n'));
            listBox8.Items.Add("Food Total: " + subtotal9.ToString("C2"));
            listBox8.Items.Add("Game Play: " + x9.ToString());
            listBox8.Items.Add("Total: " + total9.ToString("C2"));
            listBox8.Items.Add("***********");

        }
        //#10
        private void updateBill10()
        {
            //To calculate Total 
            y10 = (min10 * 16.67);
            z10 = (hour10 * 1000);
            x10 = y10 + z10;

            //To calculate food
            subtotal10 += order10.price10;
            total10 = subtotal10 + x10;


            listBox9.Items.Clear();
            listBox9.Items.Add("No." + comboBox28.SelectedItem);
            listBox9.Items.AddRange(finalBill10.Split('\n'));
            listBox9.Items.Add("Food Total: " + subtotal10.ToString("C2"));
            listBox9.Items.Add("Game Play: " + x10.ToString());
            listBox9.Items.Add("Total: " + total10.ToString("C2"));
            listBox9.Items.Add("***********");

        }


        // To Impliment on Tab
        //Implementation for the machine #1
        //start
        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            label2.Text = DateTime.Now.ToString();
        }
        //stop
        private void button2_Click_1(object sender, EventArgs e)
        {
            timer1.Stop();
            label4.Text = DateTime.Now.ToString();
        }
        //Save 
        private void button3_Click_1(object sender, EventArgs e)
        {
            finalSale();
            //To Save in Text file
            saveInfile();

            //To restart
            ms = 0;
            sec = 0;
            min = 0;
            hour = 0;
            label3.Text = 0 + ":" + 0 + ":" + 0 + ":" + 0.ToString();
            label2.Text = "TimeStart";
            label4.Text = "TimeStop";
            label5.Text = "GamePlay";

            subtotal = 0;
            total = 0;
            finalBill = " ";
            Bill.Items.Clear();
        }
        //Clear Data
        private void button4_Click(object sender, EventArgs e)
        {
            finalSale();
            //To restart
            ms = 0;
            sec = 0;
            min = 0;
            hour = 0;
            label3.Text = 0 + ":" + 0 + ":" + 0 + ":" + 0.ToString();
            label2.Text = "TimeStart";
            label4.Text = "TimeStop";
            label5.Text = "GamePlay";

            subtotal = 0;
            total = 0;
            finalBill = "";
            Bill.Items.Clear();
        }
        //Click to dropDown and display in ListBox
        private void dropdownSelection(object sender, EventArgs e)
        {
            if (sender == comboBox1)
                getValues(comboBox1.SelectedItem.ToString());
            else if (sender == comboBox2)
                getValues(comboBox2.SelectedItem.ToString());
        }
        //Select Machine Number 
        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            Bill.Items.Add(comboBox3.SelectedItem);
        }


        //Implementation for the machine #2


        //Start button
        private void button8_Click(object sender, EventArgs e)
        {
            timer2.Start();
            label7.Text = DateTime.Now.ToString();
        }
        //Stop Button
        private void button7_Click(object sender, EventArgs e)
        {
            timer2.Stop();
            label8.Text = DateTime.Now.ToString();
        }
        //Clear button
        private void button5_Click(object sender, EventArgs e)
        {
            finalSale();
            //To restart
            ms1 = 0;
            sec1 = 0;
            min1 = 0;
            hour1 = 0;
            label9.Text = 0 + ":" + 0 + ":" + 0 + ":" + 0.ToString();
            label7.Text = "TimeStart";
            label8.Text = "TimeStop";
            label6.Text = "GamePlay";

            subtotal1 = 0;
            total1 = 0;
            finalBill1 = "";
            listBox1.Items.Clear();
        }
        //Save button 
        private void button6_Click(object sender, EventArgs e)
        {
            finalSale();
            //To Save in Text file
            saveInfile1();

            //To restart
            ms1 = 0;
            sec1 = 0;
            min1 = 0;
            hour1 = 0;
            label9.Text = 0 + ":" + 0 + ":" + 0 + ":" + 0.ToString();
            label7.Text = "TimeStart";
            label8.Text = "TimeStop";
            label6.Text = "GamePlay";

            subtotal1 = 0;
            total1 = 0;
            finalBill1 = "";
            listBox1.Items.Clear();
        }

        private void dropdownSelection1(object sender, EventArgs e)
        {

            if (sender == comboBox6)
                getValues1(comboBox6.SelectedItem.ToString());
            else if (sender == comboBox5)
                getValues1(comboBox5.SelectedItem.ToString());
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.Items.Add(comboBox4.SelectedItem);
        }


        //Implementatino for the machine #3

        //Start button
        private void button12_Click(object sender, EventArgs e)
        {
            timer3.Start();
            label11.Text = DateTime.Now.ToString();
        }
        //Stop button
        private void button11_Click(object sender, EventArgs e)
        {
            timer3.Stop();
            label12.Text = DateTime.Now.ToString();
        }
        //clear button
        private void button9_Click(object sender, EventArgs e)
        {
            finalSale();
            //To restart
            ms2 = 0;
            sec2 = 0;
            min2 = 0;
            hour2 = 0;
            label13.Text = 0 + ":" + 0 + ":" + 0 + ":" + 0.ToString();
            label11.Text = "TimeStart";
            label12.Text = "TimeStop";
            label10.Text = "GamePlay";

            subtotal2 = 0;
            total2 = 0;
            finalBill2 = "";
            listBox2.Items.Clear();
        }
        //save 
        private void button10_Click(object sender, EventArgs e)
        {
            finalSale();
            //To Save in Text file
            saveInfile2();

            //To restart
            ms2 = 0;
            sec2 = 0;
            min2 = 0;
            hour2 = 0;
            label13.Text = 0 + ":" + 0 + ":" + 0 + ":" + 0.ToString();
            label11.Text = "TimeStart";
            label12.Text = "TimeStop";
            label10.Text = "GamePlay";

            subtotal2 = 0;
            total2 = 0;
            finalBill2 = "";
            listBox2.Items.Clear();
        }

        private void dds2(object sender, EventArgs e)
        {
            if (sender == comboBox9)
                getValues2(comboBox9.SelectedItem.ToString());
            else if (sender == comboBox8)
                getValues2(comboBox8.SelectedItem.ToString());
        }

        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox2.Items.Add(comboBox7.SelectedItem);
        }

        //Implementation for the machine #4

        //start 
        private void button16_Click(object sender, EventArgs e)
        {
            timer4.Start();
            label16.Text = DateTime.Now.ToString();
        }
        //Stop
        private void button15_Click(object sender, EventArgs e)
        {
            timer4.Stop();
            label17.Text = DateTime.Now.ToString();
        }
        //clear
        private void button13_Click(object sender, EventArgs e)
        {
            finalSale();
            //To restart
            ms4 = 0;
            sec4 = 0;
            min4 = 0;
            hour4 = 0;
            label18.Text = 0 + ":" + 0 + ":" + 0 + ":" + 0.ToString();
            label16.Text = "TimeStart";
            label17.Text = "TimeStop";
            label15.Text = "GamePlay";

            subtotal4 = 0;
            total4 = 0;
            finalBill4 = "";
            listBox3.Items.Clear();
        }
        //Save
        private void button14_Click(object sender, EventArgs e)
        {
            finalSale();
            //To Save in Text file
            saveInfile4();
            //To restart
            ms4 = 0;
            sec4 = 0;
            min4 = 0;
            hour4 = 0;
            label18.Text = 0 + ":" + 0 + ":" + 0 + ":" + 0.ToString();
            label16.Text = "TimeStart";
            label17.Text = "TimeStop";
            label15.Text = "GamePlay";

            subtotal4 = 0;
            total4 = 0;
            finalBill4 = "";
            listBox3.Items.Clear();
        }

        private void dds4(object sender, EventArgs e)
        {
            if (sender == comboBox12)
                getValues4(comboBox12.SelectedItem.ToString());
            else if (sender == comboBox11)
                getValues4(comboBox11.SelectedItem.ToString());
        }

        private void comboBox10_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox3.Items.Add(comboBox10.SelectedItem);
        }

        //Implementation for machine #5

        //Start
        private void button20_Click(object sender, EventArgs e)
        {
            timer5.Start();
            label20.Text = DateTime.Now.ToString();
        }
        //Stop
        private void button19_Click(object sender, EventArgs e)
        {
            timer5.Stop();
            label21.Text = DateTime.Now.ToString();
        }
        //clear
        private void button17_Click(object sender, EventArgs e)
        {
            finalSale();
            //To restart
            ms4 = 0;
            sec4 = 0;
            min4 = 0;
            hour4 = 0;
            label22.Text = 0 + ":" + 0 + ":" + 0 + ":" + 0.ToString();
            label20.Text = "TimeStart";
            label21.Text = "TimeStop";
            label19.Text = "GamePlay";

            subtotal5 = 0;
            total5 = 0;
            finalBill5 = "";
            listBox4.Items.Clear();
        }
        //save
        private void button18_Click(object sender, EventArgs e)
        {
            finalSale();
            //To Save in Text file
            saveInfile5();
            //To restart
            ms4 = 0;
            sec4 = 0;
            min4 = 0;
            hour4 = 0;
            label22.Text = 0 + ":" + 0 + ":" + 0 + ":" + 0.ToString();
            label20.Text = "TimeStart";
            label21.Text = "TimeStop";
            label19.Text = "GamePlay";

            subtotal5 = 0;
            total5 = 0;
            finalBill5 = "";
            listBox4.Items.Clear();
        }

        private void dds5(object sender, EventArgs e)
        {
            if (sender == comboBox15)
                getValues5(comboBox15.SelectedItem.ToString());
            else if (sender == comboBox14)
                getValues5(comboBox14.SelectedItem.ToString());
        }

        private void comboBox13_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox4.Items.Add(comboBox13.SelectedItem);
        }

        //Implementation for machine #6
        //start
        private void button24_Click(object sender, EventArgs e)
        {
            timer6.Start();
            label24.Text = DateTime.Now.ToString();
        }
        //stop
        private void button23_Click(object sender, EventArgs e)
        {
            timer6.Stop();
            label25.Text = DateTime.Now.ToString();
        }
        //clear
        private void button21_Click(object sender, EventArgs e)
        {
            finalSale();
            //To restart
            ms6 = 0;
            sec6 = 0;
            min6 = 0;
            hour6 = 0;
            label26.Text = 0 + ":" + 0 + ":" + 0 + ":" + 0.ToString();
            label24.Text = "TimeStart";
            label25.Text = "TimeStop";
            label23.Text = "GamePlay";

            subtotal6 = 0;
            total6 = 0;
            finalBill6 = "";
            listBox5.Items.Clear();
        }
        //save
        private void button22_Click(object sender, EventArgs e)
        {
            finalSale();
            //To Save in Text file
            saveInfile6();
            //To restart
            ms6 = 0;
            sec6 = 0;
            min6 = 0;
            hour6 = 0;
            label26.Text = 0 + ":" + 0 + ":" + 0 + ":" + 0.ToString();
            label24.Text = "TimeStart";
            label25.Text = "TimeStop";
            label23.Text = "GamePlay";

            subtotal6 = 0;
            total6 = 0;
            finalBill6 = "";
            listBox5.Items.Clear();
        }

        private void dds6(object sender, EventArgs e)
        {
            if (sender == comboBox18)
                getValues6(comboBox18.SelectedItem.ToString());
            else if (sender == comboBox17)
                getValues6(comboBox17.SelectedItem.ToString());
        }

        private void comboBox16_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox5.Items.Add(comboBox16.SelectedItem);
        }

        //Implementation for machine #7
        //start
        private void button28_Click(object sender, EventArgs e)
        {
            timer7.Start();
            label28.Text = DateTime.Now.ToString();
        }
        //stop
        private void button27_Click(object sender, EventArgs e)
        {
            timer7.Stop();
            label29.Text = DateTime.Now.ToString();
        }
        //clear
        private void button25_Click(object sender, EventArgs e)
        {
            finalSale();
            //To restart
            ms7 = 0;
            sec7 = 0;
            min7 = 0;
            hour7 = 0;
            label30.Text = 0 + ":" + 0 + ":" + 0 + ":" + 0.ToString();
            label28.Text = "TimeStart";
            label29.Text = "TimeStop";
            label27.Text = "GamePlay";

            subtotal7 = 0;
            total7 = 0;
            finalBill7 = "";
            listBox6.Items.Clear();
        }
        //save
        private void button26_Click(object sender, EventArgs e)
        {
            finalSale();
            //To Save in Text file
            saveInfile7();
            //To restart
            ms7 = 0;
            sec7 = 0;
            min7 = 0;
            hour7 = 0;
            label30.Text = 0 + ":" + 0 + ":" + 0 + ":" + 0.ToString();
            label28.Text = "TimeStart";
            label29.Text = "TimeStop";
            label27.Text = "GamePlay";

            subtotal7 = 0;
            total7 = 0;
            finalBill7 = "";
            listBox6.Items.Clear();
        }

        private void dds7(object sender, EventArgs e)
        {
            if (sender == comboBox21)
                getValues7(comboBox21.SelectedItem.ToString());
            else if (sender == comboBox20)
                getValues7(comboBox20.SelectedItem.ToString());
        }

        private void comboBox19_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox6.Items.Add(comboBox19.SelectedItem);
        }

        //Implementation for machine #8
        //Start
        private void button32_Click(object sender, EventArgs e)
        {
            timer8.Start();
            label32.Text = DateTime.Now.ToString();
        }
        //stop
        private void button31_Click(object sender, EventArgs e)
        {
            timer8.Stop();
            label33.Text = DateTime.Now.ToString();
        }
        //Clear
        private void button29_Click(object sender, EventArgs e)
        {
            finalSale();
            //To restart
            ms8 = 0;
            sec8 = 0;
            min8 = 0;
            hour8 = 0;
            label34.Text = 0 + ":" + 0 + ":" + 0 + ":" + 0.ToString();
            label32.Text = "TimeStart";
            label33.Text = "TimeStop";
            label31.Text = "GamePlay";

            subtotal8 = 0;
            total8 = 0;
            finalBill8 = "";
            listBox7.Items.Clear();
        }
        //save
        private void button30_Click(object sender, EventArgs e)
        {
            finalSale();
            //To Save in Text file
            saveInfile8();
            //To restart
            ms8 = 0;
            sec8 = 0;
            min8 = 0;
            hour8 = 0;
            label34.Text = 0 + ":" + 0 + ":" + 0 + ":" + 0.ToString();
            label32.Text = "TimeStart";
            label33.Text = "TimeStop";
            label31.Text = "GamePlay";

            subtotal8 = 0;
            total8 = 0;
            finalBill8 = "";
            listBox7.Items.Clear();
        }

        private void dds8(object sender, EventArgs e)
        {
            if (sender == comboBox24)
                getValues8(comboBox24.SelectedItem.ToString());
            else if (sender == comboBox23)
                getValues8(comboBox23.SelectedItem.ToString());
        }

        private void comboBox22_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox7.Items.Add(comboBox22.SelectedItem);
        }

        //Implementation for machine #9
        //start
        private void button36_Click(object sender, EventArgs e)
        {
            timer9.Start();
            label36.Text = DateTime.Now.ToString();
        }
        //stop
        private void button35_Click(object sender, EventArgs e)
        {
            timer9.Stop();
            label37.Text = DateTime.Now.ToString();
        }
        //clear
        private void button33_Click(object sender, EventArgs e)
        {
            finalSale();
            //To restart
            ms9 = 0;
            sec9 = 0;
            min9 = 0;
            hour9 = 0;
            label38.Text = 0 + ":" + 0 + ":" + 0 + ":" + 0.ToString();
            label36.Text = "TimeStart";
            label37.Text = "TimeStop";
            label35.Text = "GamePlay";

            subtotal9 = 0;
            total9 = 0;
            finalBill9 = "";
            listBox8.Items.Clear();
        }
        //save
        private void button34_Click(object sender, EventArgs e)
        {
            finalSale();
            //To Save in Text file
            saveInfile9();
            //To restart
            ms9 = 0;
            sec9 = 0;
            min9 = 0;
            hour9 = 0;
            label38.Text = 0 + ":" + 0 + ":" + 0 + ":" + 0.ToString();
            label36.Text = "TimeStart";
            label37.Text = "TimeStop";
            label35.Text = "GamePlay";

            subtotal9 = 0;
            total9 = 0;
            finalBill9 = "";
            listBox8.Items.Clear();
        }

        private void dds9(object sender, EventArgs e)
        {
            if (sender == comboBox27)
                getValues9(comboBox27.SelectedItem.ToString());
            else if (sender == comboBox26)
                getValues9(comboBox26.SelectedItem.ToString());
        }

        private void comboBox25_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox8.Items.Add(comboBox25.SelectedItem);
        }

        //Implementation for machine 10
        //start
        private void button40_Click(object sender, EventArgs e)
        {
            timer10.Start();
            label40.Text = DateTime.Now.ToString();
        }
        //stop
        private void button39_Click(object sender, EventArgs e)
        {
            timer10.Stop();
            label41.Text = DateTime.Now.ToString();
        }
        //clear
        private void button37_Click(object sender, EventArgs e)
        {
            finalSale();
            //To restart
            ms10 = 0;
            sec10 = 0;
            min10 = 0;
            hour10 = 0;
            label42.Text = 0 + ":" + 0 + ":" + 0 + ":" + 0.ToString();
            label40.Text = "TimeStart";
            label41.Text = "TimeStop";
            label39.Text = "GamePlay";

            subtotal10 = 0;
            total10 = 0;
            finalBill10 = "";
            listBox9.Items.Clear();
        }

        private void button38_Click(object sender, EventArgs e)
        {
            finalSale();
            //To Save in Text file
            saveInfile10();
            //To restart
            ms10 = 0;
            sec10 = 0;
            min10 = 0;
            hour10 = 0;
            label42.Text = 0 + ":" + 0 + ":" + 0 + ":" + 0.ToString();
            label40.Text = "TimeStart";
            label41.Text = "TimeStop";
            label39.Text = "GamePlay";

            subtotal10 = 0;
            total10 = 0;
            finalBill10 = "";
            listBox9.Items.Clear();
        }

        private void dds10(object sender, EventArgs e)
        {
            if (sender == comboBox30)
                getValues10(comboBox30.SelectedItem.ToString());
            else if (sender == comboBox29)
                getValues10(comboBox29.SelectedItem.ToString());
        }

        private void comboBox28_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox9.Items.Add(comboBox28.SelectedItem);
        }

            
        
    }
}