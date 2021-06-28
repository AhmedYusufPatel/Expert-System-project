using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Mommosoft.ExpertSystem;
using System.IO;

namespace MathTutoringExpertSystem
{
    public partial class Form1 : Form
    {
        private Mommosoft.ExpertSystem.Environment environment;
        Form2 f2_Open;
        private string path = Directory.GetCurrentDirectory() + "/Backgrounds";
        private string clipsFile = Directory.GetCurrentDirectory() + "/Question/MathTutor.clp";
        string operators = "";
        string nofNum = "";
        string quesNum = "";
        string difficulty = "";
        private string fName;

        // Read function implemented in CLIPS 


        public Form1()
        {

            InitializeComponent();
            Invisible();
            f2_Open = new Form2();
            environment = new Mommosoft.ExpertSystem.Environment();
            environment.Load(clipsFile);
            //environment.Watch(WatchItem.Facts);
            environment.Reset();

            GeneratorClass myGC = new GeneratorClass();
            myGC.CallAllMethods();

           
        }

        public void clipsPart()
        {
            try
            {
                environment.Reset();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            //enviroment.AssertString();
        }
        
        public void Invisible()
        {
            try
            {
                gBxOperators.Visible = true;
                gBxNumber.Visible = false;
                gBxQuestions.Visible = false;
                gBxDifficulty.Visible = false;
                btnProceed.Visible = false;
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

     


        private void rBtnAdd_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (rBtnAdd.Checked)
                {
                    Invisible();
                    gBxNumber.Visible = true;
                    //f2_Open.BackgroundImage = Image.FromFile(path + "/addition.png");
                    operators = "Add";
                }
                else
                {
                    Invisible();
                    gBxNumber.Visible = false;
                }
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void rBtnSubt_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (rBtnSubt.Checked)
                {
                    Invisible();
                    gBxNumber.Visible = true;
                    //f2_Open.BackgroundImage = Image.FromFile(path + "/subtraction.png");
                    operators = "Sub";
                }
                else
                {
                    Invisible();
                    gBxNumber.Visible = false;
                }
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void rBtnDivi_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (rBtnDivi.Checked)
                {
                    Invisible();
                    gBxNumber.Visible = true;
                    //f2_Open.BackgroundImage = Image.FromFile(path + "/Division.png");
                    operators = "Div";
                }
                else
                {
                    Invisible();
                    gBxNumber.Visible = false;
                }
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void rBtnMulti_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (rBtnMulti.Checked)
                {
                    Invisible();
                    gBxNumber.Visible = true;
                    //f2_Open.BackgroundImage = Image.FromFile(path + "/multiplication.png");
                    operators = "Multi";
                }
                else
                {
                    Invisible();
                    gBxNumber.Visible = false;
                }
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

   




        private void tBtnTwo_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (tBtnTwo.Checked)
                {
                    gBxQuestions.Visible = true;
                    nofNum = "2";
                }
                else
                {
                    gBxQuestions.Visible = true;
                }
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void rBtnThree_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (rBtnThree.Checked)
                {
                    gBxQuestions.Visible = true;
                    nofNum = "3";
                }
                else
                {
                    gBxQuestions.Visible = true;
                }
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void rBtnFour_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (rBtnFour.Checked)
                {
                    gBxQuestions.Visible = true;
                    nofNum = "4";
                }
                else
                {
                    gBxQuestions.Visible = true;
                }
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        


        private void RBtnQ10_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (RBtnQ10.Checked)
                {
                    gBxDifficulty.Visible = true;
                    quesNum = "10";
                }
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void rBtnQ25_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (rBtnQ25.Checked)
                {
                    gBxDifficulty.Visible = true;
                    quesNum = "25";
                }
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

     

        private void rBtnEasy_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (rBtnEasy.Checked)
                {
                    btnProceed.Visible = true;
                    difficulty = "Easy";
                }
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

       

        private void rBtnHard_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (rBtnHard.Checked)
                {
                    btnProceed.Visible = true;
                    difficulty = "Hard";
                }
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

     



        private void btnProceed_Click_1(object sender, EventArgs e)
        {
            try
            {
                testClips();
                FileName();
                f2_Open.Show();

                Visible = false;
                /*if (rBtnAdd.Checked)
                {



                    f2_Open.Show();

                    f2_Open.BackgroundImage = pictureBox4.Image;

                    Visible = false;

                }

                if(rBtnSubt.Checked)
                {

                    Form2 f2_Open = new Form2();

                    f2_Open.Show();

                    f2_Open.BackgroundImage = pictureBox3.Image;

                    Visible = false;

                }

                if (rBtnDivi.Checked)
                {

                    Form2 f2_Open = new Form2();

                    f2_Open.Show();

                    f2_Open.BackgroundImage = pictureBox5.Image;

                    Visible = false;

                }

                if (rBtnMulti.Checked)
                {

                    Form2 f2_Open = new Form2();

                    f2_Open.Show();

                    f2_Open.BackgroundImage = pictureBox6.Image;

                    Visible = false;

                }


                // opens the new form and closes the current form(Form1) according to the: 

                // arithmetic operator selected

                if(rBtnOther.Checked)
                {
                    Form2 f2_Open = new Form2();

                    f2_Open.Show();

                    f2_Open.BackgroundImage = pictureBox7.Image;

                    Visible = false;

                }

                // opens the new form and closes the current form(Form1) according to the: 

                // other radio button being selected 

        */
                /* string operators = "";
                 string nofNum = "";
                 string quesNum = "";
                 string difficulty = "";*/


                //fileName();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /*public string fileName()
        {
            return fName;
        }*/
        //working
        public void FileName()
        {
            try
            {
                string path = Directory.GetCurrentDirectory() + "/fileName.mte";
                StreamWriter myW = new StreamWriter(path);
                myW.WriteLine(fName);
                myW.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        public void testClips()
        {
            try
            {
                environment.Run();
                //****************************ADDITION**********************************************************
                //string filename = "";

                if (operators == "Add" && nofNum == "2" && quesNum == "10" && difficulty == "Easy")
                {
                    environment.AssertString("(mathTutor (operatorAddition Add) (numbers2 2) (questions10 10) (difficultyEasy Easy))");
                    fName = "A210QE.txt";

                }

                if (operators == "Add" && nofNum == "3" && quesNum == "10" && difficulty == "Easy")
                {
                    environment.AssertString("(mathTutor (operatorAddition Add) (numbers3 3) (questions10 10) (difficultyEasy Easy))");
                    fName = "A310QE.txt";

                }
                if (operators == "Add" && nofNum == "4" && quesNum == "10" && difficulty == "Easy")
                {
                    environment.AssertString("(mathTutor (operatorAddition Add) (numbers4 4) (questions10 10) (difficultyEasy Easy))");
                    fName = "A410QE.txt";

                }


                if (operators == "Add" && nofNum == "2" && quesNum == "25" && difficulty == "Easy")
                {
                    environment.AssertString("(mathTutor (operatorAddition Add) (numbers2 2) (questions25 25) (difficultyEasy Easy))");
                    fName = "A225QE.txt";

                }
                if (operators == "Add" && nofNum == "3" && quesNum == "25" && difficulty == "Easy")
                {
                    environment.AssertString("(mathTutor (operatorAddition Add) (numbers3 2) (questions25 25) (difficultyEasy Easy))");
                    fName = "A325QE.txt";

                }
                if (operators == "Add" && nofNum == "4" && quesNum == "25" && difficulty == "Easy")
                {
                    environment.AssertString("(mathTutor (operatorAddition Add) (numbers4 4) (questions25 25) (difficultyEasy Easy))");
                    fName = "A425QE.txt";


                }

                if (operators == "Add" && nofNum == "2" && quesNum == "10" && difficulty == "Hard")
                {
                    environment.AssertString("(mathTutor (operatorAddition Add) (numbers2 2) (questions10 10) (difficultyHard Hard))");
                    fName = "A210QH.txt";

                }
                if (operators == "Add" && nofNum == "3" && quesNum == "10" && difficulty == "Hard")
                {
                    environment.AssertString("(mathTutor (operatorAddition Add) (numbers3 3) (questions10 10) (difficultyHard Hard))");
                    fName = "A310QH.txt";

                }
                if (operators == "Add" && nofNum == "4" && quesNum == "10" && difficulty == "Hard")
                {
                    environment.AssertString("(mathTutor (operatorAddition Add) (numbers4 4) (questions10 10) (difficultyHard Hard))");
                    fName = "A410QH.txt";

                }



                if (operators == "Add" && nofNum == "2" && quesNum == "25" && difficulty == "Hard")
                {
                    environment.AssertString("(mathTutor (operatorAddition Add) (numbers2 2) (questions25 25) (difficultyHard Hard))");
                    fName = "A225QH.txt";

                }
                if (operators == "Add" && nofNum == "3" && quesNum == "25" && difficulty == "Hard")
                {
                    environment.AssertString("(mathTutor (operatorAddition Add) (numbers3 3) (questions25 25) (difficultyHard Hard))");
                    fName = "A325QH.txt";

                }
                if (operators == "Add" && nofNum == "4" && quesNum == "25" && difficulty == "Hard")
                {
                    environment.AssertString("(mathTutor (operatorAddition Add) (numbers4 4) (questions25 25) (difficultyHard Hard))");
                    fName = "A425QH.txt";

                }

                //*********************************************END ADDITION*********************************************************


                //***********************************************SUBTRACTION********************************************************
                if (operators == "Sub" && nofNum == "2" && quesNum == "10" && difficulty == "Easy")
                {
                    environment.AssertString("(mathTutor(operatorSubtraction Sub) (numbers2 2) (questions10 10) (difficultyEasy Easy))");
                    fName = "S210QE.txt";
                }

                if (operators == "Sub" && nofNum == "3" && quesNum == "10" && difficulty == "Easy")
                {
                    environment.AssertString("(mathTutor(operatorSubtraction Sub) (numbers3 3) (questions10 10) (difficultyEasy Easy))");
                    fName = "S310QE.txt";
                }

                if (operators == "Sub" && nofNum == "4" && quesNum == "10" && difficulty == "Easy")
                {
                    environment.AssertString("(mathTutor (operatorSubtraction Sub) (numbers4 4) (questions10 10) (difficultyEasy Easy))");
                    fName = "S410QE.txt";
                }


                if (operators == "Sub" && nofNum == "2" && quesNum == "25" && difficulty == "Easy")
                {
                    environment.AssertString("(mathTutor (operatorSubtraction Sub) (numbers2 2) (questions25 25) (difficultyEasy Easy))");
                    fName = "S225QE.txt";
                }

                if (operators == "Sub" && nofNum == "3" && quesNum == "25" && difficulty == "Easy")
                {
                    environment.AssertString("(mathTutor (operatorSubtraction Sub) (numbers3 2) (questions25 25) (difficultyEasy Easy))");
                    fName = "S325QE.txt";
                }

                if (operators == "Sub" && nofNum == "4" && quesNum == "25" && difficulty == "Easy")
                {
                    environment.AssertString("(mathTutor (operatorAddition Sub) (numbers4 4) (questions25 25) (difficultyEasy Easy))");
                    fName = "S425QE.txt";
                }



                if (operators == "Sub" && nofNum == "2" && quesNum == "10" && difficulty == "Hard")
                {
                    environment.AssertString("(mathTutor (operatorSubtraction Sub) (numbers2 2) (questions10 10) (difficultyHard Hard))");
                    fName = "S210QH.txt";
                }
                if (operators == "Sub" && nofNum == "3" && quesNum == "10" && difficulty == "Hard")
                {
                    environment.AssertString("(mathTutor (operatorSubtraction Sub) (numbers3 3) (questions10 10) (difficultyHard Hard))");
                    fName = "S310QH.txt";
                }
                if (operators == "Sub" && nofNum == "4" && quesNum == "10" && difficulty == "Hard")
                {
                    environment.AssertString("(mathTutor (operatorSubtraction Sub) (numbers4 4) (questions10 10) (difficultyHard Hard))");
                    fName = "S410QH.txt";
                }



                if (operators == "Sub" && nofNum == "2" && quesNum == "25" && difficulty == "Hard")
                {
                    environment.AssertString("(mathTutor (operatorSubtraction Sub) (numbers2 2) (questions25 25) (difficultyHard Hard))");
                    fName = "S225QH.txt";
                }
                if (operators == "Sub" && nofNum == "3" && quesNum == "25" && difficulty == "Hard")
                {
                    environment.AssertString("(mathTutor (operatorSubtraction Sub) (numbers3 3) (questions25 25) (difficultyHard Hard))");
                    fName = "S325QH.txt";
                }
                if (operators == "Sub" && nofNum == "4" && quesNum == "25" && difficulty == "Hard")
                {
                    environment.AssertString("(mathTutor (operatorSubtraction Sub) (numbers4 4) (questions25 25) (difficultyHard Hard))");
                    fName = "S425QH.txt";
                }


                //**********************************************MULTIPLICATION*************************************************************
                if (operators == "Multi" && nofNum == "2" && quesNum == "10" && difficulty == "Easy")
                {
                    environment.AssertString("(mathTutor (operatorMultiplication Multi) (numbers2 2) (questions10 10) (difficultyEasy Easy))");
                    fName = "M210QE.txt";
                }

                if (operators == "Multi" && nofNum == "3" && quesNum == "10" && difficulty == "Easy")
                {
                    environment.AssertString("(mathTutor (operatorMultiplication Multi) (numbers3 3) (questions10 10) (difficultyEasy Easy))");
                    fName = "M310QE.txt";
                }
                if (operators == "Multi" && nofNum == "4" && quesNum == "10" && difficulty == "Easy")
                {
                    environment.AssertString("(mathTutor (operatorMultiplication Multi) (numbers4 4) (questions10 10) (difficultyEasy Easy))");
                    fName = "M410QE.txt";

                }


                if (operators == "Multi" && nofNum == "2" && quesNum == "25" && difficulty == "Easy")
                {
                    environment.AssertString("(mathTutor (operatorMultiplication Multi) (numbers2 2) (questions25 25) (difficultyEasy Easy))");
                    fName = "M225QE.txt";
                }
                if (operators == "Multi" && nofNum == "3" && quesNum == "25" && difficulty == "Easy")
                {
                    environment.AssertString("(mathTutor (operatorMultiplication Multi) (numbers3 2) (questions25 25) (difficultyEasy Easy))");
                    fName = "M325QE.txt";
                }
                if (operators == "Multi" && nofNum == "4" && quesNum == "25" && difficulty == "Easy")
                {
                    environment.AssertString("(mathTutor (operatorMultiplication Multi) (numbers4 4) (questions25 25) (difficultyEasy Easy))");
                    fName = "M425QE.txt";
                }



                if (operators == "Multi" && nofNum == "2" && quesNum == "10" && difficulty == "Hard")
                {
                    environment.AssertString("(mathTutor (operatorMultiplication Multi) (numbers2 2) (questions10 10) (difficultyHard Hard))");
                    fName = "M210QH.txt";
                }
                if (operators == "Multi" && nofNum == "3" && quesNum == "10" && difficulty == "Hard")
                {
                    environment.AssertString("(mathTutor (operatorMultiplication Multi) (numbers3 3) (questions10 10) (difficultyHard Hard))");
                    fName = "M310QH.txt";

                }
                if (operators == "Multi" && nofNum == "4" && quesNum == "10" && difficulty == "Hard")
                {
                    environment.AssertString("(mathTutor (operatorMultiplication Multi) (numbers4 4) (questions10 10) (difficultyHard Hard))");
                    fName = "M410QH.txt";
                }



                if (operators == "Multi" && nofNum == "2" && quesNum == "25" && difficulty == "Hard")
                {
                    environment.AssertString("(mathTutor (operatorMultiplication Multi) (numbers2 2) (questions25 25) (difficultyHard Hard))");
                    fName = "M225QH.txt";
                }
                if (operators == "Multi" && nofNum == "3" && quesNum == "25" && difficulty == "Hard")
                {
                    environment.AssertString("(mathTutor (operatorMultiplication Multi) (numbers3 3) (questions25 25) (difficultyHard Hard))");
                    fName = "M325QH.txt";
                }
                if (operators == "Multi" && nofNum == "4" && quesNum == "25" && difficulty == "Hard")
                {
                    environment.AssertString("(mathTutor (operatorMultiplication Muti) (numbers4 4) (questions25 25) (difficultyHard Hard))");
                    fName = "M425QH.txt";
                }

                //**********************************************DIVISION*************************************************************

                if (operators == "Div" && nofNum == "2" && quesNum == "10" && difficulty == "Easy")
                {
                    environment.AssertString("(mathTutor (operatorDivision Div) (numbers2 2) (questions10 10) (difficultyEasy Easy))");
                    fName = "D210QE.txt";
                }

                if (operators == "Div" && nofNum == "3" && quesNum == "10" && difficulty == "Easy")
                {
                    environment.AssertString("(mathTutor (operatorDivision Div) (numbers3 3) (questions10 10) (difficultyEasy Easy))");
                    fName = "D310QE.txt";
                }
                if (operators == "Div" && nofNum == "4" && quesNum == "10" && difficulty == "Easy")
                {
                    environment.AssertString("(mathTutor (operatorDivision Div) (numbers4 4) (questions10 10) (difficultyEasy Easy))");
                    fName = "D410QE.txt";
                }


                if (operators == "Div" && nofNum == "2" && quesNum == "25" && difficulty == "Easy")
                {
                    environment.AssertString("(mathTutor (operatorDivision Div) (numbers2 2) (questions25 25) (difficultyEasy Easy))");
                    fName = "D425QE.txt";
                }
                if (operators == "Div" && nofNum == "3" && quesNum == "25" && difficulty == "Easy")
                {
                    environment.AssertString("(mathTutor (operatorDivision Div) (numbers3 2) (questions25 25) (difficultyEasy Easy))");
                    fName = "D325QE.txt";
                }
                if (operators == "Div" && nofNum == "4" && quesNum == "25" && difficulty == "Easy")
                {
                    environment.AssertString("(mathTutor (operatorDivision Div) (numbers4 4) (questions25 25) (difficultyEasy Easy))");
                    fName = "D425QE.txt";

                }



                if (operators == "Div" && nofNum == "2" && quesNum == "10" && difficulty == "Hard")
                {
                    environment.AssertString("(mathTutor (operatorDivision Div) (numbers2 2) (questions10 10) (difficultyHard Hard))");
                    fName = "D210QH.txt";
                }
                if (operators == "Div" && nofNum == "3" && quesNum == "10" && difficulty == "Hard")
                {
                    environment.AssertString("(mathTutor (operatorDivision Div) (numbers3 3) (questions10 10) (difficultyHard Hard))");
                    fName = "D310QH.txt";
                }
                if (operators == "Div" && nofNum == "4" && quesNum == "10" && difficulty == "Hard")
                {
                    environment.AssertString("(mathTutor (operatorDivision Div) (numbers4 4) (questions10 10) (difficultyHard Hard))");
                    fName = "D410QH.txt";
                }

                if (operators == "Div" && nofNum == "2" && quesNum == "25" && difficulty == "Hard")
                {
                    environment.AssertString("(mathTutor (operatorDivision Div) (numbers2 2) (questions25 25) (difficultyHard Hard))");
                    fName = "D225QH.txt";
                }
                if (operators == "Div" && nofNum == "3" && quesNum == "25" && difficulty == "Hard")
                {
                    environment.AssertString("(mathTutor (operatorDivision Div) (numbers3 3) (questions25 25) (difficultyHard Hard))");
                    fName = "D325QH.txt";
                }
                if (operators == "Div" && nofNum == "4" && quesNum == "25" && difficulty == "Hard")
                {
                    environment.AssertString("(mathTutor (operatorDivision Div) (numbers4 4) (questions25 25) (difficultyHard Hard))");
                    fName = "D425QH.txt";
                }
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GeneratorClass myG = new GeneratorClass();
            myG.deleteFiles();
            Application.Exit();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Developer's information\n\nAhmed Yusuf Patel\n27342514\n\nArno Pretorius\n26056569", "Developer's information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
