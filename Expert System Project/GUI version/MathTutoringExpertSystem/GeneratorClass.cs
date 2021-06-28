using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MathTutoringExpertSystem
{
    public partial class GeneratorClass : Form
    {
        public GeneratorClass()
        {
            InitializeComponent();
        }

        public void CallAllMethods()
        {
            try
            {
                //***********Generate Addition files******************
                A210QE();
                A225QE();
                A210QH();
                A225QH();


                A310QE();
                A310QH();
                A325QE();
                A325QH();

                A410QE();
                A425QE();
                A410QH();
                A425QH();

                //***********Generate subtraction files******************
                S210QE();
                S225QE();
                S210QH();
                S225QH();

                S310QE();
                S325QE();
                S310QH();
                S325QH();


                S410QE();
                S410QH();
                S425QE();
                S425QH();


                //***********Generate multiplication files******************
                M210QE();
                M225QE();
                M210QH();
                M225QH();


                M310QE();
                M310QH();
                M325QE();
                M325QH();

                M410QE();
                M425QE();
                M410QH();
                M425QH();

                //***********Generate Division files******************
                D210QE();
                D225QE();
                D210QH();
                D225QH();


                D310QE();
                D310QH();
                D325QE();
                D325QH();

                D410QE();
                D425QE();
                D410QH();
                D425QH();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public void A210QE()
        {
            try
            {
                Random myRand = new Random();

                string iFile = @Directory.GetCurrentDirectory() + @"/Question" + @"/A210QE.txt";

                for (int i = 0; i < 10; i++)
                {



                    StreamWriter myW = new StreamWriter(iFile, true);

                    int num1 = myRand.Next(0, 10);
                    int num2 = myRand.Next(0, 10);

                    int value = num1 + num2;

                    string write = Convert.ToString(num1) + " + " + Convert.ToString(num2) + "=" + Convert.ToString(value);
                    myW.WriteLine(write);
                    myW.Close();

                }
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public void A225QE()
        {
            try
            {
                Random myRand = new Random();


                string iFile = @Directory.GetCurrentDirectory() + @"/Question" + @"/A225QE.txt";

                for (int i = 0; i < 25; i++)
                {
                    StreamWriter myW = new StreamWriter(iFile, true);
                    int num1 = myRand.Next(0, 10);
                    int num2 = myRand.Next(0, 10);

                    int value = num1 + num2;

                    string write = Convert.ToString(num1) + "+" + Convert.ToString(num2) + "=" + Convert.ToString(value);
                    myW.WriteLine(write);
                    myW.Close();

                }
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //MessageBox.Show("Done");
        }

        public void A310QE()
        {
            try
            {
                Random myRand = new Random();

                string iFile = @Directory.GetCurrentDirectory() + @"/Question" + @"/A310QE.txt";

                for (int i = 0; i < 10; i++)
                {
                    StreamWriter myW = new StreamWriter(iFile, true);
                    int num1 = myRand.Next(0, 10);
                    int num2 = myRand.Next(0, 10);
                    int num3 = myRand.Next(0, 10);
                    int value = num1 + num2 + num3;

                    string write = Convert.ToString(num1) + "+" + Convert.ToString(num2) + "+" + Convert.ToString(num3) + "=" + Convert.ToString(value);
                    myW.WriteLine(write);
                    myW.Close();

                }
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //MessageBox.Show("Done");
        }

        public void A325QE()
        {
            try
            {
                Random myRand = new Random();

                string iFile = @Directory.GetCurrentDirectory() + @"/Question" + @"/A325QE.txt";

                for (int i = 0; i < 25; i++)
                {
                    StreamWriter myW = new StreamWriter(iFile, true);
                    int num1 = myRand.Next(0, 10);
                    int num2 = myRand.Next(0, 10);
                    int num3 = myRand.Next(0, 10);
                    int value = num1 + num2 + num3;

                    string write = Convert.ToString(num1) + "+" + Convert.ToString(num2) + "+" + Convert.ToString(num3) + "=" + Convert.ToString(value);
                    myW.WriteLine(write);
                    myW.Close();

                }
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //MessageBox.Show("Done");
        }

        public void A410QE()
        {
            try
            {
                Random myRand = new Random();

                string iFile = @Directory.GetCurrentDirectory() + @"/Question" + @"/A410QE.txt";

                for (int i = 0; i < 10; i++)
                {
                    StreamWriter myW = new StreamWriter(iFile, true);
                    int num1 = myRand.Next(0, 10);
                    int num2 = myRand.Next(0, 10);
                    int num3 = myRand.Next(0, 10);
                    int num4 = myRand.Next(0, 10);
                    int value = num1 + num2 + num3 + num4;

                    string write = Convert.ToString(num1) + "+" + Convert.ToString(num2) + "+" + Convert.ToString(num3) + "+" + Convert.ToString(num4) + "=" + Convert.ToString(value);
                    myW.WriteLine(write);
                    myW.Close();

                }
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void A425QE()
        {
            try
            {
                Random myRand = new Random();

                string iFile = @Directory.GetCurrentDirectory() + @"/Question" + @"/A425QE.txt";

                for (int i = 0; i < 25; i++)
                {
                    StreamWriter myW = new StreamWriter(iFile, true);
                    int num1 = myRand.Next(0, 10);
                    int num2 = myRand.Next(0, 10);
                    int num3 = myRand.Next(0, 10);
                    int num4 = myRand.Next(0, 10);
                    int value = num1 + num2 + num3 + num4;

                    string write = Convert.ToString(num1) + "+" + Convert.ToString(num2) + "+" + Convert.ToString(num3) + "+" + Convert.ToString(num4) + "=" + Convert.ToString(value);
                    myW.WriteLine(write);
                    myW.Close();

                }
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void A210QH()
        {
            try
            {
                Random myRand = new Random();

                string iFile = @Directory.GetCurrentDirectory() + @"/Question" + @"/A210QH.txt";

                for (int i = 0; i < 10; i++)
                {
                    StreamWriter myW = new StreamWriter(iFile, true);
                    int num1 = myRand.Next(10, 100);
                    int num2 = myRand.Next(10, 100);

                    int value = num1 + num2;

                    string write = Convert.ToString(num1) + "+" + Convert.ToString(num2) + "=" + Convert.ToString(value);
                    myW.WriteLine(write);
                    myW.Close();

                }
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public void A225QH()
        {
            try
            {
                Random myRand = new Random();

                string iFile = @Directory.GetCurrentDirectory() + @"/Question" + @"/A225QH.txt";

                for (int i = 0; i < 25; i++)
                {
                    StreamWriter myW = new StreamWriter(iFile, true);
                    int num1 = myRand.Next(10, 100);
                    int num2 = myRand.Next(10, 100);

                    int value = num1 + num2;

                    string write = Convert.ToString(num1) + "+" + Convert.ToString(num2) + "=" + Convert.ToString(value);
                    myW.WriteLine(write);
                    myW.Close();

                }
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            // MessageBox.Show("Done");
        }

        public void A310QH()
        {
            try
            {
                Random myRand = new Random();

                string iFile = @Directory.GetCurrentDirectory() + @"/Question" + @"/A310QH.txt";

                for (int i = 0; i < 10; i++)
                {
                    StreamWriter myW = new StreamWriter(iFile, true);
                    int num1 = myRand.Next(10, 100);
                    int num2 = myRand.Next(10, 100);
                    int num3 = myRand.Next(10, 100);
                    int value = num1 + num2 + num3;

                    string write = Convert.ToString(num1) + "+" + Convert.ToString(num2) + "+" + Convert.ToString(num3) + "=" + Convert.ToString(value);
                    myW.WriteLine(write);
                    myW.Close();

                }
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void A325QH()
        {
            try
            {
                Random myRand = new Random();

                string iFile = @Directory.GetCurrentDirectory() + @"/Question" + @"/A325QH.txt";

                for (int i = 0; i < 25; i++)
                {
                    StreamWriter myW = new StreamWriter(iFile, true);
                    int num1 = myRand.Next(10, 100);
                    int num2 = myRand.Next(10, 100);
                    int num3 = myRand.Next(10, 100);
                    int value = num1 + num2 + num3;

                    string write = Convert.ToString(num1) + "+" + Convert.ToString(num2) + "+" + Convert.ToString(num3) + "=" + Convert.ToString(value);
                    myW.WriteLine(write);
                    myW.Close();

                }
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void A410QH()
        {
            try
            {
                Random myRand = new Random();

                string iFile = @Directory.GetCurrentDirectory() + @"/Question" + @"/A410QH.txt";

                for (int i = 0; i < 10; i++)
                {
                    StreamWriter myW = new StreamWriter(iFile, true);
                    int num1 = myRand.Next(10, 100);
                    int num2 = myRand.Next(10, 10);
                    int num3 = myRand.Next(10, 10);
                    int num4 = myRand.Next(10, 10);
                    int value = num1 + num2 + num3 + num4;

                    string write = Convert.ToString(num1) + "+" + Convert.ToString(num2) + "+" + Convert.ToString(num3) + "+" + Convert.ToString(num4) + "=" + Convert.ToString(value);
                    myW.WriteLine(write);
                    myW.Close();

                }
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void A425QH()
        {
            try
            {
                Random myRand = new Random();

                string iFile = @Directory.GetCurrentDirectory() + @"/Question" + @"/A425QH.txt";

                for (int i = 0; i < 25; i++)
                {
                    StreamWriter myW = new StreamWriter(iFile, true);
                    int num1 = myRand.Next(10, 100);
                    int num2 = myRand.Next(10, 100);
                    int num3 = myRand.Next(10, 100);
                    int num4 = myRand.Next(10, 100);
                    int value = num1 + num2 + num3 + num4;

                    string write = Convert.ToString(num1) + "+" + Convert.ToString(num2) + "+" + Convert.ToString(num3) + "+" + Convert.ToString(num4) + "=" + Convert.ToString(value);
                    myW.WriteLine(write);
                    myW.Close();

                }
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void S210QE()
        {
            try
            {
                Random myRand = new Random();

                string iFile = @Directory.GetCurrentDirectory() + @"/Question" + @"/S210QE.txt";

                for (int i = 0; i < 10; i++)
                {
                    StreamWriter myW = new StreamWriter(iFile, true);
                    int num1 = myRand.Next(0, 10);
                    int num2 = myRand.Next(0, 10);

                    int value = num1 - num2;

                    string write = Convert.ToString(num1) + "-" + Convert.ToString(num2) + "=" + Convert.ToString(value);
                    myW.WriteLine(write);
                    myW.Close();

                }
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //MessageBox.Show("Done");
        }

        public void S225QE()
        {
            try
            {
                Random myRand = new Random();

                string iFile = @Directory.GetCurrentDirectory() + @"/Question" + @"/S225QE.txt";

                for (int i = 0; i < 25; i++)
                {
                    StreamWriter myW = new StreamWriter(iFile, true);
                    int num1 = myRand.Next(0, 10);
                    int num2 = myRand.Next(0, 10);

                    int value = num1 - num2;

                    string write = Convert.ToString(num1) + "-" + Convert.ToString(num2) + "=" + Convert.ToString(value);
                    myW.WriteLine(write);
                    myW.Close();

                }
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //MessageBox.Show("Done");
        }

        public void S310QE()
        {
            try
            {
                Random myRand = new Random();

                string iFile = @Directory.GetCurrentDirectory() + @"/Question" + @"/S310QE.txt";

                for (int i = 0; i < 10; i++)
                {
                    StreamWriter myW = new StreamWriter(iFile, true);
                    int num1 = myRand.Next(0, 10);
                    int num2 = myRand.Next(0, 10);
                    int num3 = myRand.Next(0, 10);
                    int value = num1 - num2 - num3;

                    string write = Convert.ToString(num1) + "-" + Convert.ToString(num2) + "-" + Convert.ToString(num3) + "=" + Convert.ToString(value);
                    myW.WriteLine(write);
                    myW.Close();

                }
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void S325QE()
        {
            try
            {
                Random myRand = new Random();

                string iFile = @Directory.GetCurrentDirectory() + @"/Question" + @"/S325QE.txt";

                for (int i = 0; i < 25; i++)
                {
                    StreamWriter myW = new StreamWriter(iFile, true);
                    int num1 = myRand.Next(0, 10);
                    int num2 = myRand.Next(0, 10);
                    int num3 = myRand.Next(0, 10);
                    int value = num1 - num2 - num3;

                    string write = Convert.ToString(num1) + "-" + Convert.ToString(num2) + "-" + Convert.ToString(num3) + "=" + Convert.ToString(value);
                    myW.WriteLine(write);
                    myW.Close();

                }
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void S410QE()
        {
            try
            {
                Random myRand = new Random();

                string iFile = @Directory.GetCurrentDirectory() + @"/Question" + @"/S410QE.txt";

                for (int i = 0; i < 10; i++)
                {
                    StreamWriter myW = new StreamWriter(iFile, true);
                    int num1 = myRand.Next(0, 10);
                    int num2 = myRand.Next(0, 10);
                    int num3 = myRand.Next(0, 10);
                    int num4 = myRand.Next(0, 10);
                    int value = num1 - num2 - num3 - num4;

                    string write = Convert.ToString(num1) + "-" + Convert.ToString(num2) + "-" + Convert.ToString(num3) + "-" + Convert.ToString(num4) + "=" + Convert.ToString(value);
                    myW.WriteLine(write);
                    myW.Close();

                }
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void S425QE()
        {
            try
            {
                Random myRand = new Random();

                string iFile = @Directory.GetCurrentDirectory() + @"/Question" + @"/S425QE.txt";

                for (int i = 0; i < 25; i++)
                {
                    StreamWriter myW = new StreamWriter(iFile, true);
                    int num1 = myRand.Next(0, 10);
                    int num2 = myRand.Next(0, 10);
                    int num3 = myRand.Next(0, 10);
                    int num4 = myRand.Next(0, 10);
                    int value = num1 - num2 - num3 - num4;

                    string write = Convert.ToString(num1) + "-" + Convert.ToString(num2) + "-" + Convert.ToString(num3) + "-" + Convert.ToString(num4) + "=" + Convert.ToString(value);
                    myW.WriteLine(write);
                    myW.Close();

                }
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void S210QH()
        {
            try
            {
                Random myRand = new Random();

                string iFile = @Directory.GetCurrentDirectory() + @"/Question" + @"/S210QH.txt";

                for (int i = 0; i < 10; i++)
                {
                    StreamWriter myW = new StreamWriter(iFile, true);
                    int num1 = myRand.Next(10, 100);
                    int num2 = myRand.Next(10, 100);

                    int value = num1 - num2;

                    string write = Convert.ToString(num1) + "-" + Convert.ToString(num2) + "=" + Convert.ToString(value);
                    myW.WriteLine(write);
                    myW.Close();

                }
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //MessageBox.Show("Done");
        }

        public void S225QH()
        {
            try
            {
                Random myRand = new Random();

                string iFile = @Directory.GetCurrentDirectory() + @"/Question" + @"/S225QH.txt";

                for (int i = 0; i < 25; i++)
                {
                    StreamWriter myW = new StreamWriter(iFile, true);
                    int num1 = myRand.Next(10, 100);
                    int num2 = myRand.Next(10, 100);

                    int value = num1 - num2;

                    string write = Convert.ToString(num1) + "-" + Convert.ToString(num2) + "=" + Convert.ToString(value);
                    myW.WriteLine(write);
                    myW.Close();

                }
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //MessageBox.Show("Done");
        }

        public void S310QH()
        {
            try
            {
                Random myRand = new Random();

                string iFile = @Directory.GetCurrentDirectory() + @"/Question" + @"/S310QH.txt";

                for (int i = 0; i < 10; i++)
                {
                    StreamWriter myW = new StreamWriter(iFile, true);
                    int num1 = myRand.Next(10, 100);
                    int num2 = myRand.Next(10, 100);
                    int num3 = myRand.Next(10, 100);
                    int value = num1 - num2 - num3;

                    string write = Convert.ToString(num1) + "-" + Convert.ToString(num2) + "-" + Convert.ToString(num3) + "=" + Convert.ToString(value);
                    myW.WriteLine(write);
                    myW.Close();

                }
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void S325QH()
        {
            try
            {
                Random myRand = new Random();

                string iFile = @Directory.GetCurrentDirectory() + @"/Question" + @"/S325QH.txt";

                for (int i = 0; i < 25; i++)
                {
                    StreamWriter myW = new StreamWriter(iFile, true);
                    int num1 = myRand.Next(10, 100);
                    int num2 = myRand.Next(10, 100);
                    int num3 = myRand.Next(10, 100);
                    int value = num1 - num2 - num3;

                    string write = Convert.ToString(num1) + "-" + Convert.ToString(num2) + "-" + Convert.ToString(num3) + "=" + Convert.ToString(value);
                    myW.WriteLine(write);
                    myW.Close();

                }
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void S410QH()
        {
            try
            {
                Random myRand = new Random();

                string iFile = @Directory.GetCurrentDirectory() + @"/Question" + @"/S410QH.txt";

                for (int i = 0; i < 10; i++)
                {
                    StreamWriter myW = new StreamWriter(iFile, true);
                    int num1 = myRand.Next(10, 100);
                    int num2 = myRand.Next(10, 100);
                    int num3 = myRand.Next(10, 100);
                    int num4 = myRand.Next(10, 100);
                    int value = num1 - num2 - num3 - num4;

                    string write = Convert.ToString(num1) + "-" + Convert.ToString(num2) + "-" + Convert.ToString(num3) + "-" + Convert.ToString(num4) + "=" + Convert.ToString(value);
                    myW.WriteLine(write);
                    myW.Close();

                }
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void S425QH()
        {
            try
            {
                Random myRand = new Random();

                string iFile = @Directory.GetCurrentDirectory() + @"/Question" + @"/S425QH.txt";

                for (int i = 0; i < 25; i++)
                {
                    StreamWriter myW = new StreamWriter(iFile, true);
                    int num1 = myRand.Next(10, 100);
                    int num2 = myRand.Next(10, 100);
                    int num3 = myRand.Next(10, 100);
                    int num4 = myRand.Next(10, 100);
                    int value = num1 - num2 - num3 - num4;

                    string write = Convert.ToString(num1) + "-" + Convert.ToString(num2) + "-" + Convert.ToString(num3) + "-" + Convert.ToString(num4) + "=" + Convert.ToString(value);
                    myW.WriteLine(write);
                    myW.Close();

                }
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }





        public void M210QE()
        {
            try
            {
                Random myRand = new Random();

                string iFile = @Directory.GetCurrentDirectory() + @"/Question" + @"/M210QE.txt";


                for (int i = 0; i < 10; i++)
                {
                    StreamWriter myW = new StreamWriter(iFile, true);
                    int num1 = myRand.Next(0, 10);
                    int num2 = myRand.Next(0, 10);


                    int value = num1 * num2;


                    string write = Convert.ToString(num1) + "*" + Convert.ToString(num2) + "=" + Convert.ToString(value);
                    myW.WriteLine(write);
                    myW.Close();


                }
                // MessageBox.Show("Done");
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        public void M225QE()
        {
            try
            {
                Random myRand = new Random();


                string iFile = @Directory.GetCurrentDirectory() + @"/Question" + @"/M225QE.txt";

                for (int i = 0; i < 25; i++)
                {
                    StreamWriter myW = new StreamWriter(iFile, true);
                    int num1 = myRand.Next(0, 10);
                    int num2 = myRand.Next(0, 10);


                    int value = num1 * num2;


                    string write = Convert.ToString(num1) + "*" + Convert.ToString(num2) + "=" + Convert.ToString(value);
                    myW.WriteLine(write);
                    myW.Close();


                }
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            // MessageBox.Show("Done");




        }


        public void M310QE()
        {
            try
            {
                Random myRand = new Random();

                string iFile = @Directory.GetCurrentDirectory() + @"/Question" + @"/M310QE.txt";


                for (int i = 0; i < 10; i++)
                {
                    StreamWriter myW = new StreamWriter(iFile, true);
                    int num1 = myRand.Next(0, 10);
                    int num2 = myRand.Next(0, 10);
                    int num3 = myRand.Next(0, 10);


                    int value = num1 * num2 * num3;


                    string write = Convert.ToString(num1) + "*" + Convert.ToString(num2) + "*" + Convert.ToString(num3) + "=" + Convert.ToString(value);
                    myW.WriteLine(write);
                    myW.Close();


                }
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        public void M325QE()
        {
            try
            {
                Random myRand = new Random();


                string iFile = @Directory.GetCurrentDirectory() + @"/Question" + @"/M325QE.txt";

                for (int i = 0; i < 25; i++)
                {
                    StreamWriter myW = new StreamWriter(iFile, true);
                    int num1 = myRand.Next(0, 10);
                    int num2 = myRand.Next(0, 10);
                    int num3 = myRand.Next(0, 10);


                    int value = num1 * num2 * num3;


                    string write = Convert.ToString(num1) + "*" + Convert.ToString(num2) + "*" + Convert.ToString(num3) + "=" + Convert.ToString(value);
                    myW.WriteLine(write);
                    myW.Close();


                }
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        public void M410QE()
        {
            try
            {
                Random myRand = new Random();

                string iFile = @Directory.GetCurrentDirectory() + @"/Question" + @"/M410QE.txt";


                for (int i = 0; i < 25; i++)
                {
                    StreamWriter myW = new StreamWriter(iFile, true);
                    int num1 = myRand.Next(0, 10);
                    int num2 = myRand.Next(0, 10);
                    int num3 = myRand.Next(0, 10);
                    int num4 = myRand.Next(0, 10);


                    int value = num1 * num2 * num3 * num4;


                    string write = Convert.ToString(num1) + "*" + Convert.ToString(num2) + "*" + Convert.ToString(num3) + "*" + Convert.ToString(num4) + "=" + Convert.ToString(value);
                    myW.WriteLine(write);
                    myW.Close();


                }
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //MessageBox.Show("Done");


        }


        public void M425QE()
        {
            try
            {
                Random myRand = new Random();

                string iFile = @Directory.GetCurrentDirectory() + @"/Question" + @"/M425QE.txt";


                for (int i = 0; i < 25; i++)
                {
                    StreamWriter myW = new StreamWriter(iFile, true);
                    int num1 = myRand.Next(0, 10);
                    int num2 = myRand.Next(0, 10);
                    int num3 = myRand.Next(0, 10);
                    int num4 = myRand.Next(0, 10);


                    int value = num1 * num2 * num3 * num4;


                    string write = Convert.ToString(num1) + "*" + Convert.ToString(num2) + "*" + Convert.ToString(num3) + "*" + Convert.ToString(num4) + "=" + Convert.ToString(value);
                    myW.WriteLine(write);
                    myW.Close();


                }
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //MessageBox.Show("Done");
            
        }


        public void M210QH()
        {
            try
            {
                Random myRand = new Random();

                string iFile = @Directory.GetCurrentDirectory() + @"/Question" + @"/M210QH.txt";

                for (int i = 0; i < 10; i++)
                {
                    StreamWriter myW = new StreamWriter(iFile, true);
                    int num1 = myRand.Next(10, 100);
                    int num2 = myRand.Next(10, 100);


                    int value = num1 * num2;


                    string write = Convert.ToString(num1) + "*" + Convert.ToString(num2) + "=" + Convert.ToString(value);
                    myW.WriteLine(write);
                    myW.Close();


                }
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            // MessageBox.Show("Done");


        }




        public void M225QH()
        {

            try
            {
                Random myRand = new Random();

                string iFile = @Directory.GetCurrentDirectory() + @"/Question" + @"/M225QH.txt";


                for (int i = 0; i < 25; i++)
                {
                    StreamWriter myW = new StreamWriter(iFile, true);
                    int num1 = myRand.Next(10, 100);
                    int num2 = myRand.Next(10, 100);


                    int value = num1 * num2;


                    string write = Convert.ToString(num1) + "*" + Convert.ToString(num2) + "=" + Convert.ToString(value);
                    myW.WriteLine(write);
                    myW.Close();


                }
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //MessageBox.Show("Done");
            

        }


        public void M310QH()
        {

            try
            {
                Random myRand = new Random();


                string iFile = @Directory.GetCurrentDirectory() + @"/Question" + @"/M310QH.txt";

                for (int i = 0; i < 10; i++)
                {
                    StreamWriter myW = new StreamWriter(iFile, true);
                    int num1 = myRand.Next(10, 100);
                    int num2 = myRand.Next(10, 100);
                    int num3 = myRand.Next(10, 100);


                    int value = num1 * num2 * num3;


                    string write = Convert.ToString(num1) + "*" + Convert.ToString(num2) + "*" + Convert.ToString(num3) + "=" + Convert.ToString(value);
                    myW.WriteLine(write);
                    myW.Close();


                }
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            // MessageBox.Show("Done");




        }


        public void M325QH()
        {
            try
            {
                Random myRand = new Random();

                string iFile = @Directory.GetCurrentDirectory() + @"/Question" + @"/M325QH.txt";


                for (int i = 0; i < 25; i++)
                {
                    StreamWriter myW = new StreamWriter(iFile, true);
                    int num1 = myRand.Next(10, 100);
                    int num2 = myRand.Next(10, 100);
                    int num3 = myRand.Next(10, 100);


                    int value = num1 * num2 * num3;


                    string write = Convert.ToString(num1) + "*" + Convert.ToString(num2) + "*" + Convert.ToString(num3) + "=" + Convert.ToString(value);
                    myW.WriteLine(write);
                    myW.Close();


                }
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //MessageBox.Show("Done");


        }




        public void M410QH()
        {
            try
            {
                Random myRand = new Random();


                string iFile = @Directory.GetCurrentDirectory() + @"/Question" + @"/M410QH.txt";

                for (int i = 0; i < 10; i++)
                {
                    StreamWriter myW = new StreamWriter(iFile, true);
                    int num1 = myRand.Next(10, 100);
                    int num2 = myRand.Next(10, 100);
                    int num3 = myRand.Next(10, 100);
                    int num4 = myRand.Next(10, 100);



                    int value = num1 * num2 * num3 * num4;


                    string write = Convert.ToString(num1) + "*" + Convert.ToString(num2) + "*" + Convert.ToString(num3) + "*" + Convert.ToString(num4) + "=" + Convert.ToString(value);
                    myW.WriteLine(write);
                    myW.Close();


                }
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //MessageBox.Show("Done");


        }


        public void M425QH()
        {
            try
            {
                Random myRand = new Random();


                string iFile = @Directory.GetCurrentDirectory() + @"/Question" + @"/M425QH.txt";

                for (int i = 0; i < 25; i++)
                {
                    StreamWriter myW = new StreamWriter(iFile, true);
                    int num1 = myRand.Next(10, 100);
                    int num2 = myRand.Next(10, 100);
                    int num3 = myRand.Next(10, 100);
                    int num4 = myRand.Next(10, 100);


                    int value = num1 * num2 * num3 * num4;


                    string write = Convert.ToString(num1) + "*" + Convert.ToString(num2) + "*" + Convert.ToString(num3) + "*" + Convert.ToString(num4) + "=" + Convert.ToString(value);
                    myW.WriteLine(write);
                    myW.Close();


                }
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }




        public void D210QE()
        {
            try
            {
                Random myRand = new Random();

                string iFile = @Directory.GetCurrentDirectory() + @"/Question" + @"/D210QE.txt";


                for (int i = 0; i < 10; i++)
                {
                    StreamWriter myW = new StreamWriter(iFile, true);
                    int num1 = myRand.Next(1, 10);
                    int num2 = myRand.Next(1, 10);


                    int value = num1 / num2;


                    string write = Convert.ToString(num1) + "/" + Convert.ToString(num2) + "=" + Convert.ToString(value);
                    myW.WriteLine(write);
                    myW.Close();


                }
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        public void D225QE()
        {
            try
            {
                Random myRand = new Random();


                string iFile = @Directory.GetCurrentDirectory() + @"/Question" + @"/D225QE.txt";

                for (int i = 0; i < 25; i++)
                {
                    StreamWriter myW = new StreamWriter(iFile, true);
                    int num1 = myRand.Next(1, 10);
                    int num2 = myRand.Next(1, 10);


                    int value = num1 / num2;


                    string write = Convert.ToString(num1) + "/" + Convert.ToString(num2) + "=" + Convert.ToString(value);
                    myW.WriteLine(write);
                    myW.Close();


                }
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }




        }


        public void D310QE()
        {
            try
            {
                Random myRand = new Random();


                string iFile = @Directory.GetCurrentDirectory() + @"/Question" + @"/D310QE.txt";

                for (int i = 0; i < 10; i++)
                {
                    StreamWriter myW = new StreamWriter(iFile, true);
                    int num1 = myRand.Next(1, 10);
                    int num2 = myRand.Next(1, 10);
                    int num3 = myRand.Next(1, 10);


                    int value = num1 / num2 / num3;


                    string write = Convert.ToString(num1) + "/" + Convert.ToString(num2) + "/" + Convert.ToString(num3) + "=" + Convert.ToString(value);
                    myW.WriteLine(write);
                    myW.Close();


                }
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        public void D325QE()
        {
            try
            {
                Random myRand = new Random();


                string iFile = @Directory.GetCurrentDirectory() + @"/Question" + @"/D325QE.txt";

                for (int i = 0; i < 25; i++)
                {
                    StreamWriter myW = new StreamWriter(iFile, true);
                    int num1 = myRand.Next(1, 10);
                    int num2 = myRand.Next(1, 10);
                    int num3 = myRand.Next(1, 10);


                    int value = num1 / num2 / num3;


                    string write = Convert.ToString(num1) + "/" + Convert.ToString(num2) + "/" + Convert.ToString(num3) + "=" + Convert.ToString(value);
                    myW.WriteLine(write);
                    myW.Close();


                }
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        public void D410QE()
        {
            try
            {
                Random myRand = new Random();


                string iFile = @Directory.GetCurrentDirectory() + @"/Question" + @"/D410QE.txt";

                for (int i = 0; i < 25; i++)
                {
                    StreamWriter myW = new StreamWriter(iFile, true);
                    int num1 = myRand.Next(1, 10);
                    int num2 = myRand.Next(1, 10);
                    int num3 = myRand.Next(1, 10);
                    int num4 = myRand.Next(1, 10);


                    int value = num1 / num2 / num3 / num4;


                    string write = Convert.ToString(num1) + "/" + Convert.ToString(num2) + "/" + Convert.ToString(num3) + "/" + Convert.ToString(num4) + "=" + Convert.ToString(value);
                    myW.WriteLine(write);
                    myW.Close();


                }
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }


        public void D425QE()
        {
            try
            {
                Random myRand = new Random();


                string iFile = @Directory.GetCurrentDirectory() + @"/Question" + @"/D425QE.txt";

                for (int i = 0; i < 25; i++)
                {
                    StreamWriter myW = new StreamWriter(iFile, true);
                    int num1 = myRand.Next(1, 10);
                    int num2 = myRand.Next(1, 10);
                    int num3 = myRand.Next(1, 10);
                    int num4 = myRand.Next(1, 10);


                    int value = num1 / num2 / num3 / num4;


                    string write = Convert.ToString(num1) + "/" + Convert.ToString(num2) + "/" + Convert.ToString(num3) + "/" + Convert.ToString(num4) + "=" + Convert.ToString(value);
                    myW.WriteLine(write);
                    myW.Close();


                }
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }


        public void D210QH()
        {
            try
            {
                Random myRand = new Random();

                string iFile = @Directory.GetCurrentDirectory() + @"/Question" + @"/D210QH.txt";

                for (int i = 0; i < 10; i++)
                {
                    StreamWriter myW = new StreamWriter(iFile, true);
                    int num1 = myRand.Next(10, 100);
                    int num2 = myRand.Next(10, 100);


                    int value = num1 / num2;


                    string write = Convert.ToString(num1) + "/" + Convert.ToString(num2) + "=" + Convert.ToString(value);
                    myW.WriteLine(write);
                    myW.Close();


                }
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //MessageBox.Show("Done");


        }




        public void D225QH()
        {
            try
            {
                Random myRand = new Random();


                string iFile = @Directory.GetCurrentDirectory() + @"/Question" + @"/D225QH.txt";

                for (int i = 0; i < 25; i++)
                {
                    StreamWriter myW = new StreamWriter(iFile, true);
                    int num1 = myRand.Next(10, 100);
                    int num2 = myRand.Next(10, 100);


                    int value = num1 / num2;


                    string write = Convert.ToString(num1) + "/" + Convert.ToString(num2) + "=" + Convert.ToString(value);
                    myW.WriteLine(write);
                    myW.Close();


                }
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            // MessageBox.Show("Done");



        }


        public void D310QH()
        {
            try
            {
                Random myRand = new Random();

                string iFile = @Directory.GetCurrentDirectory() + @"/Question" + @"/D310QH.txt";


                for (int i = 0; i < 10; i++)
                {
                    StreamWriter myW = new StreamWriter(iFile, true);
                    int num1 = myRand.Next(10, 100);
                    int num2 = myRand.Next(10, 100);
                    int num3 = myRand.Next(10, 100);


                    int value = num1 / num2 / num3;


                    string write = Convert.ToString(num1) + "/" + Convert.ToString(num2) + "/" + Convert.ToString(num3) + "=" + Convert.ToString(value);
                    myW.WriteLine(write);
                    myW.Close();


                }
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public void D325QH()
        {
            try
            {
                Random myRand = new Random();

                string iFile = @Directory.GetCurrentDirectory() + @"/Question" + @"/D325QH.txt";


                for (int i = 0; i < 25; i++)
                {
                    StreamWriter myW = new StreamWriter(iFile, true);
                    int num1 = myRand.Next(10, 100);
                    int num2 = myRand.Next(10, 100);
                    int num3 = myRand.Next(10, 100);


                    int value = num1 / num2 / num3;


                    string write = Convert.ToString(num1) + "/" + Convert.ToString(num2) + "/" + Convert.ToString(num3) + "=" + Convert.ToString(value);
                    myW.WriteLine(write);
                    myW.Close();


                }
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }




        public void D410QH()
        {
            try
            {
                Random myRand = new Random();

                string iFile = @Directory.GetCurrentDirectory() + @"/Question" + @"/D410QH.txt";


                for (int i = 0; i < 10; i++)
                {
                    StreamWriter myW = new StreamWriter(iFile, true);
                    int num1 = myRand.Next(10, 100);
                    int num2 = myRand.Next(10, 100);
                    int num3 = myRand.Next(10, 100);
                    int num4 = myRand.Next(10, 100);



                    int value = num1 / num2 / num3 / num4;


                    string write = Convert.ToString(num1) + "/" + Convert.ToString(num2) + "/" + Convert.ToString(num3) + "/" + Convert.ToString(num4) + "=" + Convert.ToString(value);
                    myW.WriteLine(write);
                    myW.Close();


                }
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            // MessageBox.Show("Done");


        }


        public void D425QH()
        {
            try
            {
                Random myRand = new Random();

                string iFile = @Directory.GetCurrentDirectory() + @"/Question" + @"/D425QH.txt";


                for (int i = 0; i < 25; i++)
                {
                    StreamWriter myW = new StreamWriter(iFile, true);
                    int num1 = myRand.Next(10, 100);
                    int num2 = myRand.Next(10, 100);
                    int num3 = myRand.Next(10, 100);
                    int num4 = myRand.Next(10, 100);


                    int value = num1 / num2 / num3 / num4;


                    string write = Convert.ToString(num1) + "/" + Convert.ToString(num2) + "/" + Convert.ToString(num3) + "/" + Convert.ToString(num4) + "=" + Convert.ToString(value);
                    myW.WriteLine(write);
                    myW.Close();


                }
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }




        public void deleteFiles()
        {
            try
            {
                string path = Directory.GetCurrentDirectory() + @"/Question";


                /**************** Addition *********/

                File.Delete(path + @"/A210QE.txt");
                File.Delete(path + @"/A225QE.txt");
                File.Delete(path + @"/A310QE.txt");
                File.Delete(path + @"/A325QE.txt");
                File.Delete(path + @"/A410QE.txt");
                File.Delete(path + @"/A425QE.txt");

                File.Delete(path + @"/A210QH.txt");
                File.Delete(path + @"/A225QH.txt");
                File.Delete(path + @"/A310QH.txt");
                File.Delete(path + @"/A325QH.txt");
                File.Delete(path + @"/A410QH.txt");
                File.Delete(path + @"/A425QH.txt");


                /****************** Subtraction ******/

                File.Delete(path + @"/S210QE.txt");
                File.Delete(path + @"/S225QE.txt");
                File.Delete(path + @"/S310QE.txt");
                File.Delete(path + @"/S325QE.txt");
                File.Delete(path + @"/S410QE.txt");
                File.Delete(path + @"/S425QE.txt");

                File.Delete(path + @"/S210QH.txt");
                File.Delete(path + @"/S225QH.txt");
                File.Delete(path + @"/S310QH.txt");
                File.Delete(path + @"/S325QH.txt");
                File.Delete(path + @"/S410QH.txt");
                File.Delete(path + @"/S425QH.txt");

                /****************** Multiplication  ******/

                File.Delete(path + @"/M210QE.txt");
                File.Delete(path + @"/M225QE.txt");
                File.Delete(path + @"/M310QE.txt");
                File.Delete(path + @"/M325QE.txt");
                File.Delete(path + @"/M410QE.txt");
                File.Delete(path + @"/M425QE.txt");

                File.Delete(path + @"/M210QH.txt");
                File.Delete(path + @"/M225QH.txt");
                File.Delete(path + @"/M310QH.txt");
                File.Delete(path + @"/M325QH.txt");
                File.Delete(path + @"/M410QH.txt");
                File.Delete(path + @"/M425QH.txt");

                /****************** Division ******/

                File.Delete(path + @"/D210QE.txt");
                File.Delete(path + @"/D225QE.txt");
                File.Delete(path + @"/D310QE.txt");
                File.Delete(path + @"/D325QE.txt");
                File.Delete(path + @"/D410QE.txt");
                File.Delete(path + @"/D425QE.txt");

                File.Delete(path + @"/D210QH.txt");
                File.Delete(path + @"/D225QH.txt");
                File.Delete(path + @"/D310QH.txt");
                File.Delete(path + @"/D325QH.txt");
                File.Delete(path + @"/D410QH.txt");
                File.Delete(path + @"/D425QH.txt");
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // delete method 


        }
    }
}
