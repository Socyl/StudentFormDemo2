
namespace StudentFormDemo2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.studentIDLabel = new System.Windows.Forms.Label();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.studentIDTextBox = new System.Windows.Forms.TextBox();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.itRadioButton = new System.Windows.Forms.RadioButton();
            this.webDesignRadioButton = new System.Windows.Forms.RadioButton();
            this.programmingRadioButton = new System.Windows.Forms.RadioButton();
            this.coursesLabel = new System.Windows.Forms.Label();
            this.scoresLabel = new System.Windows.Forms.Label();
            this.cis101CheckBox = new System.Windows.Forms.CheckBox();
            this.cis102CheckBox = new System.Windows.Forms.CheckBox();
            this.cis103CheckBox = new System.Windows.Forms.CheckBox();
            this.cis104CheckBox = new System.Windows.Forms.CheckBox();
            this.score1TextBox = new System.Windows.Forms.TextBox();
            this.score2TextBox = new System.Windows.Forms.TextBox();
            this.score3TextBox = new System.Windows.Forms.TextBox();
            this.score4TextBox = new System.Windows.Forms.TextBox();
            this.submitButton = new System.Windows.Forms.Button();
            this.resultTextBox = new System.Windows.Forms.TextBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // studentIDLabel
            // 
            this.studentIDLabel.AutoSize = true;
            this.studentIDLabel.Location = new System.Drawing.Point(16, 29);
            this.studentIDLabel.Name = "studentIDLabel";
            this.studentIDLabel.Size = new System.Drawing.Size(96, 25);
            this.studentIDLabel.TabIndex = 0;
            this.studentIDLabel.Text = "Student ID";
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(16, 85);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(97, 25);
            this.firstNameLabel.TabIndex = 1;
            this.firstNameLabel.Text = "First Name";
            this.firstNameLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(16, 141);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(95, 25);
            this.lastNameLabel.TabIndex = 2;
            this.lastNameLabel.Text = "Last Name";
            // 
            // studentIDTextBox
            // 
            this.studentIDTextBox.Location = new System.Drawing.Point(118, 23);
            this.studentIDTextBox.Name = "studentIDTextBox";
            this.studentIDTextBox.Size = new System.Drawing.Size(150, 31);
            this.studentIDTextBox.TabIndex = 3;
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(118, 79);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(150, 31);
            this.firstNameTextBox.TabIndex = 4;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(118, 135);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(150, 31);
            this.lastNameTextBox.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.itRadioButton);
            this.groupBox1.Controls.Add(this.webDesignRadioButton);
            this.groupBox1.Controls.Add(this.programmingRadioButton);
            this.groupBox1.Location = new System.Drawing.Point(16, 232);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(300, 150);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Major";
            // 
            // itRadioButton
            // 
            this.itRadioButton.AutoSize = true;
            this.itRadioButton.Location = new System.Drawing.Point(7, 103);
            this.itRadioButton.Name = "itRadioButton";
            this.itRadioButton.Size = new System.Drawing.Size(51, 29);
            this.itRadioButton.TabIndex = 2;
            this.itRadioButton.TabStop = true;
            this.itRadioButton.Text = "IT";
            this.itRadioButton.UseVisualStyleBackColor = true;
            // 
            // webDesignRadioButton
            // 
            this.webDesignRadioButton.AutoSize = true;
            this.webDesignRadioButton.Location = new System.Drawing.Point(7, 67);
            this.webDesignRadioButton.Name = "webDesignRadioButton";
            this.webDesignRadioButton.Size = new System.Drawing.Size(133, 29);
            this.webDesignRadioButton.TabIndex = 1;
            this.webDesignRadioButton.TabStop = true;
            this.webDesignRadioButton.Text = "Web Design";
            this.webDesignRadioButton.UseVisualStyleBackColor = true;
            // 
            // programmingRadioButton
            // 
            this.programmingRadioButton.AutoSize = true;
            this.programmingRadioButton.Location = new System.Drawing.Point(7, 31);
            this.programmingRadioButton.Name = "programmingRadioButton";
            this.programmingRadioButton.Size = new System.Drawing.Size(147, 29);
            this.programmingRadioButton.TabIndex = 0;
            this.programmingRadioButton.TabStop = true;
            this.programmingRadioButton.Text = "Programming";
            this.programmingRadioButton.UseVisualStyleBackColor = true;
            this.programmingRadioButton.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // coursesLabel
            // 
            this.coursesLabel.AutoSize = true;
            this.coursesLabel.Location = new System.Drawing.Point(363, 29);
            this.coursesLabel.Name = "coursesLabel";
            this.coursesLabel.Size = new System.Drawing.Size(75, 25);
            this.coursesLabel.TabIndex = 7;
            this.coursesLabel.Text = "Courses";
            // 
            // scoresLabel
            // 
            this.scoresLabel.AutoSize = true;
            this.scoresLabel.Location = new System.Drawing.Point(552, 26);
            this.scoresLabel.Name = "scoresLabel";
            this.scoresLabel.Size = new System.Drawing.Size(64, 25);
            this.scoresLabel.TabIndex = 8;
            this.scoresLabel.Text = "Scores";
            // 
            // cis101CheckBox
            // 
            this.cis101CheckBox.AutoSize = true;
            this.cis101CheckBox.Location = new System.Drawing.Point(363, 67);
            this.cis101CheckBox.Name = "cis101CheckBox";
            this.cis101CheckBox.Size = new System.Drawing.Size(99, 29);
            this.cis101CheckBox.TabIndex = 9;
            this.cis101CheckBox.Text = "CIS 101";
            this.cis101CheckBox.UseVisualStyleBackColor = true;
            // 
            // cis102CheckBox
            // 
            this.cis102CheckBox.AutoSize = true;
            this.cis102CheckBox.Location = new System.Drawing.Point(363, 103);
            this.cis102CheckBox.Name = "cis102CheckBox";
            this.cis102CheckBox.Size = new System.Drawing.Size(99, 29);
            this.cis102CheckBox.TabIndex = 10;
            this.cis102CheckBox.Text = "CIS 102";
            this.cis102CheckBox.UseVisualStyleBackColor = true;
            this.cis102CheckBox.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // cis103CheckBox
            // 
            this.cis103CheckBox.AutoSize = true;
            this.cis103CheckBox.Location = new System.Drawing.Point(363, 139);
            this.cis103CheckBox.Name = "cis103CheckBox";
            this.cis103CheckBox.Size = new System.Drawing.Size(99, 29);
            this.cis103CheckBox.TabIndex = 11;
            this.cis103CheckBox.Text = "CIS 103";
            this.cis103CheckBox.UseVisualStyleBackColor = true;
            this.cis103CheckBox.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // cis104CheckBox
            // 
            this.cis104CheckBox.AutoSize = true;
            this.cis104CheckBox.Location = new System.Drawing.Point(363, 175);
            this.cis104CheckBox.Name = "cis104CheckBox";
            this.cis104CheckBox.Size = new System.Drawing.Size(94, 29);
            this.cis104CheckBox.TabIndex = 12;
            this.cis104CheckBox.Text = "CIS104";
            this.cis104CheckBox.UseVisualStyleBackColor = true;
            // 
            // score1TextBox
            // 
            this.score1TextBox.Location = new System.Drawing.Point(552, 65);
            this.score1TextBox.Name = "score1TextBox";
            this.score1TextBox.Size = new System.Drawing.Size(150, 31);
            this.score1TextBox.TabIndex = 13;
            // 
            // score2TextBox
            // 
            this.score2TextBox.Location = new System.Drawing.Point(552, 102);
            this.score2TextBox.Name = "score2TextBox";
            this.score2TextBox.Size = new System.Drawing.Size(150, 31);
            this.score2TextBox.TabIndex = 14;
            // 
            // score3TextBox
            // 
            this.score3TextBox.Location = new System.Drawing.Point(552, 139);
            this.score3TextBox.Name = "score3TextBox";
            this.score3TextBox.Size = new System.Drawing.Size(150, 31);
            this.score3TextBox.TabIndex = 15;
            // 
            // score4TextBox
            // 
            this.score4TextBox.Location = new System.Drawing.Point(552, 179);
            this.score4TextBox.Name = "score4TextBox";
            this.score4TextBox.Size = new System.Drawing.Size(150, 31);
            this.score4TextBox.TabIndex = 16;
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(363, 232);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(112, 34);
            this.submitButton.TabIndex = 17;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // resultTextBox
            // 
            this.resultTextBox.BackColor = System.Drawing.SystemColors.ControlDark;
            this.resultTextBox.Location = new System.Drawing.Point(248, 272);
            this.resultTextBox.Multiline = true;
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.ReadOnly = true;
            this.resultTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.resultTextBox.Size = new System.Drawing.Size(540, 166);
            this.resultTextBox.TabIndex = 3;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(23, 399);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(179, 25);
            this.linkLabel1.TabIndex = 18;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Cengage Home Page";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 456);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(231, 106);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(962, 819);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.resultTextBox);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.score4TextBox);
            this.Controls.Add(this.score3TextBox);
            this.Controls.Add(this.score2TextBox);
            this.Controls.Add(this.score1TextBox);
            this.Controls.Add(this.cis104CheckBox);
            this.Controls.Add(this.cis103CheckBox);
            this.Controls.Add(this.cis102CheckBox);
            this.Controls.Add(this.cis101CheckBox);
            this.Controls.Add(this.scoresLabel);
            this.Controls.Add(this.coursesLabel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(this.studentIDTextBox);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.firstNameLabel);
            this.Controls.Add(this.studentIDLabel);
            this.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Name = "Form1";
            this.Text = "Student Information";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label studentIDLabel;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.TextBox studentIDTextBox;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton itRadioButton;
        private System.Windows.Forms.RadioButton webDesignRadioButton;
        private System.Windows.Forms.RadioButton programmingRadioButton;
        private System.Windows.Forms.Label coursesLabel;
        private System.Windows.Forms.Label scoresLabel;
        private System.Windows.Forms.CheckBox cis101CheckBox;
        private System.Windows.Forms.CheckBox cis102CheckBox;
        private System.Windows.Forms.CheckBox cis103CheckBox;
        private System.Windows.Forms.CheckBox cis104CheckBox;
        private System.Windows.Forms.TextBox score1TextBox;
        private System.Windows.Forms.TextBox score2TextBox;
        private System.Windows.Forms.TextBox score3TextBox;
        private System.Windows.Forms.TextBox score4TextBox;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.TextBox resultTextBox;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

