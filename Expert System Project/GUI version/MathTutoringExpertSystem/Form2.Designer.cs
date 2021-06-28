namespace MathTutoringExpertSystem
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.btnBack = new System.Windows.Forms.Button();
            this.lblQ = new System.Windows.Forms.Label();
            this.rBtnAns1 = new System.Windows.Forms.RadioButton();
            this.rBtnAns2 = new System.Windows.Forms.RadioButton();
            this.rBtnAns3 = new System.Windows.Forms.RadioButton();
            this.btnFinish = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnHelp = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.LightGreen;
            this.btnBack.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(12, 400);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(165, 77);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblQ
            // 
            this.lblQ.AutoSize = true;
            this.lblQ.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQ.Location = new System.Drawing.Point(225, 46);
            this.lblQ.Name = "lblQ";
            this.lblQ.Size = new System.Drawing.Size(240, 19);
            this.lblQ.TabIndex = 1;
            this.lblQ.Text = "Please Press Next to Continue";
            this.lblQ.Click += new System.EventHandler(this.lblQ_Click);
            // 
            // rBtnAns1
            // 
            this.rBtnAns1.AutoSize = true;
            this.rBtnAns1.Location = new System.Drawing.Point(138, 156);
            this.rBtnAns1.Name = "rBtnAns1";
            this.rBtnAns1.Size = new System.Drawing.Size(38, 17);
            this.rBtnAns1.TabIndex = 2;
            this.rBtnAns1.TabStop = true;
            this.rBtnAns1.Text = "A1";
            this.rBtnAns1.UseVisualStyleBackColor = true;
            this.rBtnAns1.CheckedChanged += new System.EventHandler(this.rBtnAns1_CheckedChanged);
            // 
            // rBtnAns2
            // 
            this.rBtnAns2.AutoSize = true;
            this.rBtnAns2.Location = new System.Drawing.Point(285, 156);
            this.rBtnAns2.Name = "rBtnAns2";
            this.rBtnAns2.Size = new System.Drawing.Size(38, 17);
            this.rBtnAns2.TabIndex = 3;
            this.rBtnAns2.TabStop = true;
            this.rBtnAns2.Text = "A2";
            this.rBtnAns2.UseVisualStyleBackColor = true;
            this.rBtnAns2.CheckedChanged += new System.EventHandler(this.rBtnAns2_CheckedChanged);
            // 
            // rBtnAns3
            // 
            this.rBtnAns3.AutoSize = true;
            this.rBtnAns3.Location = new System.Drawing.Point(489, 156);
            this.rBtnAns3.Name = "rBtnAns3";
            this.rBtnAns3.Size = new System.Drawing.Size(38, 17);
            this.rBtnAns3.TabIndex = 4;
            this.rBtnAns3.TabStop = true;
            this.rBtnAns3.Text = "A3";
            this.rBtnAns3.UseVisualStyleBackColor = true;
            this.rBtnAns3.CheckedChanged += new System.EventHandler(this.rBtnAns3_CheckedChanged);
            // 
            // btnFinish
            // 
            this.btnFinish.BackColor = System.Drawing.Color.LightGreen;
            this.btnFinish.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinish.Location = new System.Drawing.Point(564, 400);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(165, 77);
            this.btnFinish.TabIndex = 5;
            this.btnFinish.Text = "Finish";
            this.btnFinish.UseVisualStyleBackColor = false;
            this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(242, 272);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "Correct!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(242, 321);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 29);
            this.label2.TabIndex = 7;
            this.label2.Text = "In-Correct!";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(111, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(226, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Correct answer was:";
            // 
            // btnHelp
            // 
            this.btnHelp.BackColor = System.Drawing.Color.DarkViolet;
            this.btnHelp.Location = new System.Drawing.Point(602, 12);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(127, 88);
            this.btnHelp.TabIndex = 9;
            this.btnHelp.Text = "Help?";
            this.btnHelp.UseVisualStyleBackColor = false;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(253, 400);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Help function";
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnNext.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Location = new System.Drawing.Point(540, 256);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(128, 63);
            this.btnNext.TabIndex = 11;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(741, 489);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnFinish);
            this.Controls.Add(this.rBtnAns3);
            this.Controls.Add(this.rBtnAns2);
            this.Controls.Add(this.rBtnAns1);
            this.Controls.Add(this.lblQ);
            this.Controls.Add(this.btnBack);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "Math Tutor";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblQ;
        private System.Windows.Forms.RadioButton rBtnAns1;
        private System.Windows.Forms.RadioButton rBtnAns2;
        private System.Windows.Forms.RadioButton rBtnAns3;
        private System.Windows.Forms.Button btnFinish;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnNext;
    }
}