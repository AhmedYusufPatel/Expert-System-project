namespace MathTutoringExpertSystem
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.gBxOperators = new System.Windows.Forms.GroupBox();
            this.rBtnMulti = new System.Windows.Forms.RadioButton();
            this.rBtnDivi = new System.Windows.Forms.RadioButton();
            this.rBtnSubt = new System.Windows.Forms.RadioButton();
            this.rBtnAdd = new System.Windows.Forms.RadioButton();
            this.gBxNumber = new System.Windows.Forms.GroupBox();
            this.rBtnFour = new System.Windows.Forms.RadioButton();
            this.rBtnThree = new System.Windows.Forms.RadioButton();
            this.tBtnTwo = new System.Windows.Forms.RadioButton();
            this.gBxQuestions = new System.Windows.Forms.GroupBox();
            this.rBtnQ25 = new System.Windows.Forms.RadioButton();
            this.RBtnQ10 = new System.Windows.Forms.RadioButton();
            this.gBxDifficulty = new System.Windows.Forms.GroupBox();
            this.rBtnHard = new System.Windows.Forms.RadioButton();
            this.rBtnEasy = new System.Windows.Forms.RadioButton();
            this.btnProceed = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gBxOperators.SuspendLayout();
            this.gBxNumber.SuspendLayout();
            this.gBxQuestions.SuspendLayout();
            this.gBxDifficulty.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gBxOperators
            // 
            this.gBxOperators.Controls.Add(this.rBtnMulti);
            this.gBxOperators.Controls.Add(this.rBtnDivi);
            this.gBxOperators.Controls.Add(this.rBtnSubt);
            this.gBxOperators.Controls.Add(this.rBtnAdd);
            this.gBxOperators.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBxOperators.Location = new System.Drawing.Point(13, 30);
            this.gBxOperators.Name = "gBxOperators";
            this.gBxOperators.Size = new System.Drawing.Size(602, 94);
            this.gBxOperators.TabIndex = 0;
            this.gBxOperators.TabStop = false;
            this.gBxOperators.Text = "Operators:";
            // 
            // rBtnMulti
            // 
            this.rBtnMulti.AutoSize = true;
            this.rBtnMulti.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rBtnMulti.Location = new System.Drawing.Point(387, 40);
            this.rBtnMulti.Name = "rBtnMulti";
            this.rBtnMulti.Size = new System.Drawing.Size(121, 20);
            this.rBtnMulti.TabIndex = 3;
            this.rBtnMulti.TabStop = true;
            this.rBtnMulti.Text = "Multiplication (X)";
            this.rBtnMulti.UseVisualStyleBackColor = true;
            this.rBtnMulti.CheckedChanged += new System.EventHandler(this.rBtnMulti_CheckedChanged);
            // 
            // rBtnDivi
            // 
            this.rBtnDivi.AutoSize = true;
            this.rBtnDivi.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rBtnDivi.Location = new System.Drawing.Point(267, 40);
            this.rBtnDivi.Name = "rBtnDivi";
            this.rBtnDivi.Size = new System.Drawing.Size(89, 20);
            this.rBtnDivi.TabIndex = 2;
            this.rBtnDivi.TabStop = true;
            this.rBtnDivi.Text = "Division (÷)";
            this.rBtnDivi.UseVisualStyleBackColor = true;
            this.rBtnDivi.CheckedChanged += new System.EventHandler(this.rBtnDivi_CheckedChanged);
            // 
            // rBtnSubt
            // 
            this.rBtnSubt.AutoSize = true;
            this.rBtnSubt.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rBtnSubt.Location = new System.Drawing.Point(147, 40);
            this.rBtnSubt.Name = "rBtnSubt";
            this.rBtnSubt.Size = new System.Drawing.Size(108, 20);
            this.rBtnSubt.TabIndex = 1;
            this.rBtnSubt.TabStop = true;
            this.rBtnSubt.Text = "Subtraction (-)";
            this.rBtnSubt.UseVisualStyleBackColor = true;
            this.rBtnSubt.CheckedChanged += new System.EventHandler(this.rBtnSubt_CheckedChanged);
            // 
            // rBtnAdd
            // 
            this.rBtnAdd.AutoSize = true;
            this.rBtnAdd.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rBtnAdd.Location = new System.Drawing.Point(27, 40);
            this.rBtnAdd.Name = "rBtnAdd";
            this.rBtnAdd.Size = new System.Drawing.Size(93, 20);
            this.rBtnAdd.TabIndex = 0;
            this.rBtnAdd.TabStop = true;
            this.rBtnAdd.Text = "Addition (+)";
            this.rBtnAdd.UseVisualStyleBackColor = true;
            this.rBtnAdd.CheckedChanged += new System.EventHandler(this.rBtnAdd_CheckedChanged);
            // 
            // gBxNumber
            // 
            this.gBxNumber.Controls.Add(this.rBtnFour);
            this.gBxNumber.Controls.Add(this.rBtnThree);
            this.gBxNumber.Controls.Add(this.tBtnTwo);
            this.gBxNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBxNumber.Location = new System.Drawing.Point(13, 130);
            this.gBxNumber.Name = "gBxNumber";
            this.gBxNumber.Size = new System.Drawing.Size(729, 83);
            this.gBxNumber.TabIndex = 1;
            this.gBxNumber.TabStop = false;
            this.gBxNumber.Text = "Number of Numbers:";
            // 
            // rBtnFour
            // 
            this.rBtnFour.AutoSize = true;
            this.rBtnFour.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rBtnFour.Location = new System.Drawing.Point(436, 42);
            this.rBtnFour.Name = "rBtnFour";
            this.rBtnFour.Size = new System.Drawing.Size(33, 20);
            this.rBtnFour.TabIndex = 2;
            this.rBtnFour.TabStop = true;
            this.rBtnFour.Text = "4";
            this.rBtnFour.UseVisualStyleBackColor = true;
            this.rBtnFour.CheckedChanged += new System.EventHandler(this.rBtnFour_CheckedChanged);
            // 
            // rBtnThree
            // 
            this.rBtnThree.AutoSize = true;
            this.rBtnThree.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rBtnThree.Location = new System.Drawing.Point(236, 42);
            this.rBtnThree.Name = "rBtnThree";
            this.rBtnThree.Size = new System.Drawing.Size(33, 20);
            this.rBtnThree.TabIndex = 1;
            this.rBtnThree.TabStop = true;
            this.rBtnThree.Text = "3";
            this.rBtnThree.UseVisualStyleBackColor = true;
            this.rBtnThree.CheckedChanged += new System.EventHandler(this.rBtnThree_CheckedChanged);
            // 
            // tBtnTwo
            // 
            this.tBtnTwo.AutoSize = true;
            this.tBtnTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBtnTwo.Location = new System.Drawing.Point(26, 42);
            this.tBtnTwo.Name = "tBtnTwo";
            this.tBtnTwo.Size = new System.Drawing.Size(33, 20);
            this.tBtnTwo.TabIndex = 0;
            this.tBtnTwo.TabStop = true;
            this.tBtnTwo.Text = "2";
            this.tBtnTwo.UseVisualStyleBackColor = true;
            this.tBtnTwo.CheckedChanged += new System.EventHandler(this.tBtnTwo_CheckedChanged);
            // 
            // gBxQuestions
            // 
            this.gBxQuestions.Controls.Add(this.rBtnQ25);
            this.gBxQuestions.Controls.Add(this.RBtnQ10);
            this.gBxQuestions.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBxQuestions.Location = new System.Drawing.Point(12, 297);
            this.gBxQuestions.Name = "gBxQuestions";
            this.gBxQuestions.Size = new System.Drawing.Size(489, 88);
            this.gBxQuestions.TabIndex = 4;
            this.gBxQuestions.TabStop = false;
            this.gBxQuestions.Text = "Number of Questions:";
            // 
            // rBtnQ25
            // 
            this.rBtnQ25.AutoSize = true;
            this.rBtnQ25.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rBtnQ25.Location = new System.Drawing.Point(317, 38);
            this.rBtnQ25.Name = "rBtnQ25";
            this.rBtnQ25.Size = new System.Drawing.Size(40, 20);
            this.rBtnQ25.TabIndex = 1;
            this.rBtnQ25.TabStop = true;
            this.rBtnQ25.Text = "25";
            this.rBtnQ25.UseVisualStyleBackColor = true;
            this.rBtnQ25.CheckedChanged += new System.EventHandler(this.rBtnQ25_CheckedChanged);
            // 
            // RBtnQ10
            // 
            this.RBtnQ10.AutoSize = true;
            this.RBtnQ10.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBtnQ10.Location = new System.Drawing.Point(61, 34);
            this.RBtnQ10.Name = "RBtnQ10";
            this.RBtnQ10.Size = new System.Drawing.Size(40, 20);
            this.RBtnQ10.TabIndex = 0;
            this.RBtnQ10.TabStop = true;
            this.RBtnQ10.Text = "10";
            this.RBtnQ10.UseVisualStyleBackColor = true;
            this.RBtnQ10.CheckedChanged += new System.EventHandler(this.RBtnQ10_CheckedChanged);
            // 
            // gBxDifficulty
            // 
            this.gBxDifficulty.Controls.Add(this.rBtnHard);
            this.gBxDifficulty.Controls.Add(this.rBtnEasy);
            this.gBxDifficulty.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBxDifficulty.Location = new System.Drawing.Point(13, 418);
            this.gBxDifficulty.Name = "gBxDifficulty";
            this.gBxDifficulty.Size = new System.Drawing.Size(490, 87);
            this.gBxDifficulty.TabIndex = 5;
            this.gBxDifficulty.TabStop = false;
            this.gBxDifficulty.Text = "Difficulty:";
            // 
            // rBtnHard
            // 
            this.rBtnHard.AutoSize = true;
            this.rBtnHard.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rBtnHard.Location = new System.Drawing.Point(290, 41);
            this.rBtnHard.Name = "rBtnHard";
            this.rBtnHard.Size = new System.Drawing.Size(53, 20);
            this.rBtnHard.TabIndex = 2;
            this.rBtnHard.TabStop = true;
            this.rBtnHard.Text = "Hard";
            this.rBtnHard.UseVisualStyleBackColor = true;
            this.rBtnHard.CheckedChanged += new System.EventHandler(this.rBtnHard_CheckedChanged);
            // 
            // rBtnEasy
            // 
            this.rBtnEasy.AutoSize = true;
            this.rBtnEasy.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rBtnEasy.Location = new System.Drawing.Point(44, 41);
            this.rBtnEasy.Name = "rBtnEasy";
            this.rBtnEasy.Size = new System.Drawing.Size(56, 20);
            this.rBtnEasy.TabIndex = 0;
            this.rBtnEasy.TabStop = true;
            this.rBtnEasy.Text = "Easy";
            this.rBtnEasy.UseVisualStyleBackColor = true;
            this.rBtnEasy.CheckedChanged += new System.EventHandler(this.rBtnEasy_CheckedChanged);
            // 
            // btnProceed
            // 
            this.btnProceed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnProceed.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProceed.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnProceed.Location = new System.Drawing.Point(527, 470);
            this.btnProceed.Name = "btnProceed";
            this.btnProceed.Size = new System.Drawing.Size(253, 77);
            this.btnProceed.TabIndex = 6;
            this.btnProceed.Text = "Proceed";
            this.btnProceed.UseVisualStyleBackColor = false;
            this.btnProceed.Click += new System.EventHandler(this.btnProceed_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(520, 219);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(260, 115);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(520, 340);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(260, 124);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(792, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(792, 559);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnProceed);
            this.Controls.Add(this.gBxDifficulty);
            this.Controls.Add(this.gBxQuestions);
            this.Controls.Add(this.gBxOperators);
            this.Controls.Add(this.gBxNumber);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Math Tutor";
            this.gBxOperators.ResumeLayout(false);
            this.gBxOperators.PerformLayout();
            this.gBxNumber.ResumeLayout(false);
            this.gBxNumber.PerformLayout();
            this.gBxQuestions.ResumeLayout(false);
            this.gBxQuestions.PerformLayout();
            this.gBxDifficulty.ResumeLayout(false);
            this.gBxDifficulty.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gBxOperators;
        private System.Windows.Forms.RadioButton rBtnMulti;
        private System.Windows.Forms.RadioButton rBtnDivi;
        private System.Windows.Forms.RadioButton rBtnSubt;
        private System.Windows.Forms.RadioButton rBtnAdd;
        private System.Windows.Forms.GroupBox gBxNumber;
        private System.Windows.Forms.RadioButton rBtnFour;
        private System.Windows.Forms.RadioButton rBtnThree;
        private System.Windows.Forms.RadioButton tBtnTwo;
        private System.Windows.Forms.GroupBox gBxQuestions;
        private System.Windows.Forms.RadioButton rBtnQ25;
        private System.Windows.Forms.RadioButton RBtnQ10;
        private System.Windows.Forms.GroupBox gBxDifficulty;
        private System.Windows.Forms.RadioButton rBtnHard;
        private System.Windows.Forms.RadioButton rBtnEasy;
        private System.Windows.Forms.Button btnProceed;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
    }
}

