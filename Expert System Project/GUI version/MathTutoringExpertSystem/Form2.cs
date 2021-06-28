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
    public partial class Form2 : Form
    {
        string[] val;
        int gCounter = 0;
        string[] question;
        string[] answer;
        int c = 0;
        int correct = 0;
        string prevVal = null;
        int globalvalue = 0;
        

        public Form2()
        {
            InitializeComponent();
            //myF = new Form1();
            val = new string[500];
            question = new string[500];
            answer = new string[500];
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            rBtnAns1.Visible = false;
            rBtnAns2.Visible = false;
            rBtnAns3.Visible = false;
            btnFinish.Visible = false;

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            try
            {
                retrieveFile();
            }
            catch(Exception ec)
            {
                MessageBox.Show(ec.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            try
            {
                Form1 f1_Open = new Form1();
                f1_Open.Show();
                Visible = false;
                GeneratorClass myG = new GeneratorClass();
                myG.CallAllMethods();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            // opens the previous form and closes the current form(Form2)

        }
        

        public void retrieveFile()
        {
            try
            {
                string pathToFileName = Directory.GetCurrentDirectory() + "/fileName.mte";
                string newpathfiename = pathToFileName.Replace(@"\", @"/");
                StreamReader myR = new StreamReader(newpathfiename);
                string value = myR.ReadLine();
                myR.Close();



                string path = @Directory.GetCurrentDirectory();
                string newpath = path.Replace(@"\", @"/");
                string pathToFile = newpath + @"/" + @"Question" + @"/" + @value;
                //MessageBox.Show(pathToFile);
                StreamReader myReader = new StreamReader(pathToFile);

                int c = 0;
                while (!myReader.EndOfStream)
                {
                    string info = myReader.ReadLine();
                    val[c] = info;
                    string[] quesAndAns = val[c].Split('=');
                    question[c] = quesAndAns[0];
                    answer[c] = quesAndAns[1];
                    //MessageBox.Show("Question " + question[c] + "\nAnswer " + answer[c] + "\nCounter " + c);
                    c++;
                    gCounter++;
                }
                myReader.Close();
                //delete the textfiles here after 
                deleteFiles();
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
                GeneratorClass myG = new GeneratorClass();
                myG.deleteFiles();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       

        private void rBtnAns1_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                prevVal = rBtnAns1.Text;
                labeldisplay();
                rBtnAns1.Enabled = false;
                rBtnAns2.Enabled = false;
                rBtnAns3.Enabled = false;
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void rBtnAns2_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                prevVal = rBtnAns2.Text;
                labeldisplay();
                rBtnAns1.Enabled = false;
                rBtnAns2.Enabled = false;
                rBtnAns3.Enabled = false;
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void rBtnAns3_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                prevVal = rBtnAns3.Text;
                labeldisplay();
                rBtnAns1.Enabled = false;
                rBtnAns2.Enabled = false;
                rBtnAns3.Enabled = false;
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnFinish_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("Congratulations, you got " + correct + " out of " + gCounter, "Feedback", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (MessageBox.Show("Would you like to replay again?", "Request", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    this.Close();
                    Form1 myForm = new Form1();
                    myForm.Show();
                }
                else
                {
                    MessageBox.Show("Thank you for playing.", "Gratitude", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Application.Exit();
                }
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lblQ_Click(object sender, EventArgs e)
        {

        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            //// opens a new form to assist users with how to use the system on that specific part

            //// will be numbered accordingly - in simple steps of understanding 
            try
            {
                Help h1_Open = new Help();

                h1_Open.ShowDialog();

                
                //Visible = false;
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        private void btnNext_Click(object sender, EventArgs e)
        {
            try
            {
                btnHelp.Visible = false;
                rBtnAns1.Visible = true;
                rBtnAns2.Visible = true;
                rBtnAns3.Visible = true;

                label1.Visible = false;
                label2.Visible = false;
                label3.Visible = false;
                rBtnAns1.Checked = false;
                rBtnAns2.Checked = false;
                rBtnAns3.Checked = false;
                rBtnAns1.Enabled = true;
                rBtnAns2.Enabled = true;
                rBtnAns3.Enabled = true;
                //------------------------------------Show question in label and answers in radioButtons for as long as there are still questions in the array-------------------------------
                if (c < gCounter)
                {
                    lblQ.Text = "Question " + Convert.ToString(c + 1) + "\n" + question[c];
                    Random myRandom = new Random();
                    int rbv = myRandom.Next(1, 3);
                    int otherval = myRandom.Next(1, 25);

                    if (rbv == 1)
                    {
                        rBtnAns1.Text = answer[c];
                        rBtnAns2.Text = Convert.ToString(int.Parse(answer[c]) + rbv);
                        rBtnAns3.Text = Convert.ToString(int.Parse(answer[c]) + rbv + otherval);
                        globalvalue = 1;
                    }
                    else if (rbv == 2)
                    {
                        rBtnAns2.Text = answer[c];
                        rBtnAns1.Text = Convert.ToString(int.Parse(answer[c]) + rbv);
                        rBtnAns3.Text = Convert.ToString(int.Parse(answer[c]) + rbv + otherval);
                        globalvalue = 2;
                    }
                    else if (rbv == 3)
                    {
                        rBtnAns3.Text = answer[c];
                        rBtnAns3.Text = Convert.ToString(int.Parse(answer[c]) + rbv);
                        rBtnAns2.Text = Convert.ToString(int.Parse(answer[c]) + rbv + otherval);

                        globalvalue = 3;
                    }
                    else
                    {
                        MessageBox.Show("Please select a valid answer", "Select answer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        globalvalue = 4;
                    }
                    c++;
                }
                else
                {
                    label1.Visible = false;
                    label2.Visible = false;
                    label3.Visible = false;
                    MessageBox.Show("Congratulations, you got " + correct + " out of " + gCounter, "Feedback", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    rBtnAns1.Visible = false;
                    rBtnAns2.Visible = false;
                    rBtnAns3.Visible = false;
                    lblQ.Text = "Click Finish to complete";
                    btnBack.Visible = false;
                    btnNext.Visible = false;
                    btnFinish.Visible = true;
                }

                //-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
                label1.Visible = false;
                label2.Visible = false;
                label3.Visible = false;
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void labeldisplay()
        {
            try
            {
                /*rBtnAns1.Text = "";
                rBtnAns2.Text = "";
                rBtnAns3.Text = "";*/
                label1.Visible = false;
                label2.Visible = false;
                label3.Visible = false;


                if (globalvalue == 1)
                {
                    if (rBtnAns1.Checked)
                    {
                        label1.Visible = true;
                        label2.Visible = false;
                        label3.Visible = true;
                        label3.Text = "The answer of " + question[c - 1] + " is " + answer[c - 1];
                        correct++;
                    }
                    else
                    {
                        label2.Visible = true;
                        label3.Visible = true;
                        label3.Text = "The correct answer of " + question[c - 1] + " is " + answer[c - 1];
                    }
                }
                else if (globalvalue == 2)
                {
                    if (rBtnAns2.Checked)
                    {
                        label1.Visible = true;
                        label2.Visible = false;
                        label3.Visible = true;
                        label3.Text = "The answer of " + question[c - 1] + " is " + answer[c - 1];
                        correct++;
                    }
                    else
                    {
                        label2.Visible = true;
                        label3.Visible = true;
                        label3.Text = "The correct answer of " + question[c - 1] + " is " + answer[c - 1];
                    }
                }
                else if (globalvalue == 3)
                {
                    if (rBtnAns3.Checked)
                    {
                        label1.Visible = true;
                        label2.Visible = false;
                        label3.Visible = true;
                        label3.Text = "The answer of " + question[c - 1] + " is " + answer[c - 1];
                        correct++;
                    }
                    else
                    {
                        label2.Visible = true;
                        label3.Visible = true;
                        label3.Text = "The correct answer of " + question[c - 1] + " is " + answer[c - 1];
                    }
                }
                else if (globalvalue == 4)
                {
                    label2.Visible = true;
                    label3.Visible = true;
                    label3.Text = "The correct answer of " + question[c - 1] + " is " + answer[c - 1];
                }
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
    }
}
