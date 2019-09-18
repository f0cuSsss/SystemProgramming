namespace ExamSystemProgramming
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.Keyboard = new System.Windows.Forms.TabPage();
            this.btnChangeFileKB = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.cbKeyboardActive = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.keyboardMincb = new System.Windows.Forms.ComboBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.LogList = new System.Windows.Forms.ListBox();
            this.mousePage = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.cbMouseActive = new System.Windows.Forms.CheckBox();
            this.btnChangeFileMouse = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.mouseMincb = new System.Windows.Forms.ComboBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.pictureMouseLog = new System.Windows.Forms.PictureBox();
            this.wordsPage = new System.Windows.Forms.TabPage();
            this.btnAddWord = new System.Windows.Forms.Button();
            this.wordsList = new System.Windows.Forms.ListBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.wordsLog = new System.Windows.Forms.ListBox();
            this.cbWordsActive = new System.Windows.Forms.CheckBox();
            this.processesPage = new System.Windows.Forms.TabPage();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnStartStop = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.activeLabel_K = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.activeLabel_M = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.activeLabel_W = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.WordsPathLabel = new System.Windows.Forms.Label();
            this.MousePathLabel = new System.Windows.Forms.Label();
            this.keyboardPathLabel = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.btnChangeFileWords = new System.Windows.Forms.Button();
            this.btnShowProceses = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.Keyboard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.mousePage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureMouseLog)).BeginInit();
            this.wordsPage.SuspendLayout();
            this.processesPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnStartStop)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.Keyboard);
            this.tabControl.Controls.Add(this.mousePage);
            this.tabControl.Controls.Add(this.wordsPage);
            this.tabControl.Controls.Add(this.processesPage);
            this.tabControl.Location = new System.Drawing.Point(25, 37);
            this.tabControl.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(325, 178);
            this.tabControl.TabIndex = 0;
            // 
            // Keyboard
            // 
            this.Keyboard.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Keyboard.BackgroundImage")));
            this.Keyboard.Controls.Add(this.btnChangeFileKB);
            this.Keyboard.Controls.Add(this.label6);
            this.Keyboard.Controls.Add(this.cbKeyboardActive);
            this.Keyboard.Controls.Add(this.pictureBox1);
            this.Keyboard.Controls.Add(this.label3);
            this.Keyboard.Controls.Add(this.label2);
            this.Keyboard.Controls.Add(this.keyboardMincb);
            this.Keyboard.Controls.Add(this.checkBox1);
            this.Keyboard.Controls.Add(this.LogList);
            this.Keyboard.Location = new System.Drawing.Point(4, 22);
            this.Keyboard.Margin = new System.Windows.Forms.Padding(2);
            this.Keyboard.Name = "Keyboard";
            this.Keyboard.Padding = new System.Windows.Forms.Padding(2);
            this.Keyboard.Size = new System.Drawing.Size(317, 152);
            this.Keyboard.TabIndex = 0;
            this.Keyboard.Text = "Keyboard";
            this.Keyboard.UseVisualStyleBackColor = true;
            // 
            // btnChangeFileKB
            // 
            this.btnChangeFileKB.Enabled = false;
            this.btnChangeFileKB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangeFileKB.Location = new System.Drawing.Point(124, 74);
            this.btnChangeFileKB.Margin = new System.Windows.Forms.Padding(2);
            this.btnChangeFileKB.Name = "btnChangeFileKB";
            this.btnChangeFileKB.Size = new System.Drawing.Size(81, 24);
            this.btnChangeFileKB.TabIndex = 9;
            this.btnChangeFileKB.Text = "Change file";
            this.btnChangeFileKB.UseVisualStyleBackColor = true;
            this.btnChangeFileKB.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(240, 0);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "Log list";
            // 
            // cbKeyboardActive
            // 
            this.cbKeyboardActive.AutoSize = true;
            this.cbKeyboardActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.cbKeyboardActive.ForeColor = System.Drawing.Color.White;
            this.cbKeyboardActive.Location = new System.Drawing.Point(4, 76);
            this.cbKeyboardActive.Margin = new System.Windows.Forms.Padding(2);
            this.cbKeyboardActive.Name = "cbKeyboardActive";
            this.cbKeyboardActive.Size = new System.Drawing.Size(65, 21);
            this.cbKeyboardActive.TabIndex = 7;
            this.cbKeyboardActive.Text = "Active";
            this.cbKeyboardActive.UseVisualStyleBackColor = true;
            this.cbKeyboardActive.CheckedChanged += new System.EventHandler(this.cbKeyboardActive_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(4, 5);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(201, 67);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(159, 127);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "min(s)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(95, 104);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "every";
            // 
            // keyboardMincb
            // 
            this.keyboardMincb.FormattingEnabled = true;
            this.keyboardMincb.Location = new System.Drawing.Point(143, 104);
            this.keyboardMincb.Margin = new System.Windows.Forms.Padding(2);
            this.keyboardMincb.Name = "keyboardMincb";
            this.keyboardMincb.Size = new System.Drawing.Size(46, 21);
            this.keyboardMincb.TabIndex = 4;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.ForeColor = System.Drawing.Color.White;
            this.checkBox1.Location = new System.Drawing.Point(4, 103);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(97, 21);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "Save to file";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // LogList
            // 
            this.LogList.BackColor = System.Drawing.Color.White;
            this.LogList.FormattingEnabled = true;
            this.LogList.Location = new System.Drawing.Point(210, 18);
            this.LogList.Margin = new System.Windows.Forms.Padding(2);
            this.LogList.Name = "LogList";
            this.LogList.Size = new System.Drawing.Size(105, 134);
            this.LogList.TabIndex = 0;
            // 
            // mousePage
            // 
            this.mousePage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mousePage.BackgroundImage")));
            this.mousePage.Controls.Add(this.label7);
            this.mousePage.Controls.Add(this.cbMouseActive);
            this.mousePage.Controls.Add(this.btnChangeFileMouse);
            this.mousePage.Controls.Add(this.label4);
            this.mousePage.Controls.Add(this.label5);
            this.mousePage.Controls.Add(this.mouseMincb);
            this.mousePage.Controls.Add(this.checkBox2);
            this.mousePage.Controls.Add(this.pictureMouseLog);
            this.mousePage.Location = new System.Drawing.Point(4, 22);
            this.mousePage.Margin = new System.Windows.Forms.Padding(2);
            this.mousePage.Name = "mousePage";
            this.mousePage.Padding = new System.Windows.Forms.Padding(2);
            this.mousePage.Size = new System.Drawing.Size(317, 152);
            this.mousePage.TabIndex = 1;
            this.mousePage.Text = "Mouse";
            this.mousePage.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(214, 2);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "Mouse log";
            // 
            // cbMouseActive
            // 
            this.cbMouseActive.AutoSize = true;
            this.cbMouseActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.cbMouseActive.ForeColor = System.Drawing.Color.White;
            this.cbMouseActive.Location = new System.Drawing.Point(6, 6);
            this.cbMouseActive.Margin = new System.Windows.Forms.Padding(2);
            this.cbMouseActive.Name = "cbMouseActive";
            this.cbMouseActive.Size = new System.Drawing.Size(65, 21);
            this.cbMouseActive.TabIndex = 11;
            this.cbMouseActive.Text = "Active";
            this.cbMouseActive.UseVisualStyleBackColor = true;
            this.cbMouseActive.CheckedChanged += new System.EventHandler(this.cbMouseActive_CheckedChanged);
            // 
            // btnChangeFileMouse
            // 
            this.btnChangeFileMouse.Enabled = false;
            this.btnChangeFileMouse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnChangeFileMouse.Location = new System.Drawing.Point(6, 78);
            this.btnChangeFileMouse.Margin = new System.Windows.Forms.Padding(2);
            this.btnChangeFileMouse.Name = "btnChangeFileMouse";
            this.btnChangeFileMouse.Size = new System.Drawing.Size(181, 25);
            this.btnChangeFileMouse.TabIndex = 10;
            this.btnChangeFileMouse.Text = "Change file";
            this.btnChangeFileMouse.UseVisualStyleBackColor = true;
            this.btnChangeFileMouse.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(146, 52);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "min(s)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(98, 31);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "every";
            // 
            // mouseMincb
            // 
            this.mouseMincb.FormattingEnabled = true;
            this.mouseMincb.Location = new System.Drawing.Point(142, 30);
            this.mouseMincb.Margin = new System.Windows.Forms.Padding(2);
            this.mouseMincb.Name = "mouseMincb";
            this.mouseMincb.Size = new System.Drawing.Size(37, 21);
            this.mouseMincb.TabIndex = 7;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox2.ForeColor = System.Drawing.Color.White;
            this.checkBox2.Location = new System.Drawing.Point(6, 30);
            this.checkBox2.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(97, 21);
            this.checkBox2.TabIndex = 6;
            this.checkBox2.Text = "Save to file";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // pictureMouseLog
            // 
            this.pictureMouseLog.BackColor = System.Drawing.Color.White;
            this.pictureMouseLog.Location = new System.Drawing.Point(194, 19);
            this.pictureMouseLog.Margin = new System.Windows.Forms.Padding(2);
            this.pictureMouseLog.Name = "pictureMouseLog";
            this.pictureMouseLog.Size = new System.Drawing.Size(121, 131);
            this.pictureMouseLog.TabIndex = 0;
            this.pictureMouseLog.TabStop = false;
            // 
            // wordsPage
            // 
            this.wordsPage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("wordsPage.BackgroundImage")));
            this.wordsPage.Controls.Add(this.btnChangeFileWords);
            this.wordsPage.Controls.Add(this.label14);
            this.wordsPage.Controls.Add(this.label16);
            this.wordsPage.Controls.Add(this.comboBox1);
            this.wordsPage.Controls.Add(this.checkBox3);
            this.wordsPage.Controls.Add(this.btnAddWord);
            this.wordsPage.Controls.Add(this.wordsList);
            this.wordsPage.Controls.Add(this.label15);
            this.wordsPage.Controls.Add(this.label8);
            this.wordsPage.Controls.Add(this.wordsLog);
            this.wordsPage.Controls.Add(this.cbWordsActive);
            this.wordsPage.Location = new System.Drawing.Point(4, 22);
            this.wordsPage.Margin = new System.Windows.Forms.Padding(2);
            this.wordsPage.Name = "wordsPage";
            this.wordsPage.Padding = new System.Windows.Forms.Padding(2);
            this.wordsPage.Size = new System.Drawing.Size(317, 152);
            this.wordsPage.TabIndex = 2;
            this.wordsPage.Text = "Words";
            this.wordsPage.UseVisualStyleBackColor = true;
            // 
            // btnAddWord
            // 
            this.btnAddWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddWord.Location = new System.Drawing.Point(141, 20);
            this.btnAddWord.Name = "btnAddWord";
            this.btnAddWord.Size = new System.Drawing.Size(56, 48);
            this.btnAddWord.TabIndex = 18;
            this.btnAddWord.Text = "Add word";
            this.btnAddWord.UseVisualStyleBackColor = true;
            // 
            // wordsList
            // 
            this.wordsList.FormattingEnabled = true;
            this.wordsList.Location = new System.Drawing.Point(5, 16);
            this.wordsList.Name = "wordsList";
            this.wordsList.Size = new System.Drawing.Size(135, 56);
            this.wordsList.TabIndex = 16;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(10, 1);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(102, 15);
            this.label15.TabIndex = 15;
            this.label15.Text = "Monitoring words";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(226, 0);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 15);
            this.label8.TabIndex = 13;
            this.label8.Text = "Words log";
            // 
            // wordsLog
            // 
            this.wordsLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wordsLog.FormattingEnabled = true;
            this.wordsLog.ItemHeight = 16;
            this.wordsLog.Location = new System.Drawing.Point(199, 16);
            this.wordsLog.Margin = new System.Windows.Forms.Padding(2);
            this.wordsLog.Name = "wordsLog";
            this.wordsLog.Size = new System.Drawing.Size(116, 132);
            this.wordsLog.TabIndex = 1;
            // 
            // cbWordsActive
            // 
            this.cbWordsActive.AutoSize = true;
            this.cbWordsActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbWordsActive.ForeColor = System.Drawing.Color.White;
            this.cbWordsActive.Location = new System.Drawing.Point(5, 81);
            this.cbWordsActive.Name = "cbWordsActive";
            this.cbWordsActive.Size = new System.Drawing.Size(64, 20);
            this.cbWordsActive.TabIndex = 0;
            this.cbWordsActive.Text = "Active";
            this.cbWordsActive.UseVisualStyleBackColor = true;
            this.cbWordsActive.CheckedChanged += new System.EventHandler(this.cbWordsActive_CheckedChanged);
            // 
            // processesPage
            // 
            this.processesPage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("processesPage.BackgroundImage")));
            this.processesPage.Controls.Add(this.btnShowProceses);
            this.processesPage.Controls.Add(this.listBox1);
            this.processesPage.Location = new System.Drawing.Point(4, 22);
            this.processesPage.Margin = new System.Windows.Forms.Padding(2);
            this.processesPage.Name = "processesPage";
            this.processesPage.Padding = new System.Windows.Forms.Padding(2);
            this.processesPage.Size = new System.Drawing.Size(317, 152);
            this.processesPage.TabIndex = 3;
            this.processesPage.Text = "Processes";
            this.processesPage.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(5, 2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(307, 116);
            this.listBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(9, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Monitoring";
            // 
            // btnStartStop
            // 
            this.btnStartStop.BackColor = System.Drawing.Color.Transparent;
            this.btnStartStop.Image = ((System.Drawing.Image)(resources.GetObject("btnStartStop.Image")));
            this.btnStartStop.ImageActive = null;
            this.btnStartStop.Location = new System.Drawing.Point(358, 86);
            this.btnStartStop.Margin = new System.Windows.Forms.Padding(2);
            this.btnStartStop.Name = "btnStartStop";
            this.btnStartStop.Size = new System.Drawing.Size(98, 106);
            this.btnStartStop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnStartStop.TabIndex = 2;
            this.btnStartStop.TabStop = false;
            this.btnStartStop.Zoom = 10;
            this.btnStartStop.Click += new System.EventHandler(this.btnStartStop_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Location = new System.Drawing.Point(0, 305);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(473, 8);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel2.Location = new System.Drawing.Point(465, 1);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 313);
            this.panel2.TabIndex = 4;
            // 
            // activeLabel_K
            // 
            this.activeLabel_K.AutoSize = true;
            this.activeLabel_K.BackColor = System.Drawing.Color.Transparent;
            this.activeLabel_K.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.activeLabel_K.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activeLabel_K.ForeColor = System.Drawing.Color.Red;
            this.activeLabel_K.Location = new System.Drawing.Point(3, 5);
            this.activeLabel_K.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.activeLabel_K.Name = "activeLabel_K";
            this.activeLabel_K.Size = new System.Drawing.Size(22, 22);
            this.activeLabel_K.TabIndex = 5;
            this.activeLabel_K.Text = "K\r\n";
            // 
            // activeLabel_M
            // 
            this.activeLabel_M.AutoSize = true;
            this.activeLabel_M.BackColor = System.Drawing.Color.Transparent;
            this.activeLabel_M.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.activeLabel_M.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activeLabel_M.ForeColor = System.Drawing.Color.Red;
            this.activeLabel_M.Location = new System.Drawing.Point(27, 5);
            this.activeLabel_M.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.activeLabel_M.Name = "activeLabel_M";
            this.activeLabel_M.Size = new System.Drawing.Size(25, 22);
            this.activeLabel_M.TabIndex = 5;
            this.activeLabel_M.Text = "M";
            // 
            // activeLabel_W
            // 
            this.activeLabel_W.AutoSize = true;
            this.activeLabel_W.BackColor = System.Drawing.Color.Transparent;
            this.activeLabel_W.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.activeLabel_W.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activeLabel_W.ForeColor = System.Drawing.Color.Red;
            this.activeLabel_W.Location = new System.Drawing.Point(54, 5);
            this.activeLabel_W.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.activeLabel_W.Name = "activeLabel_W";
            this.activeLabel_W.Size = new System.Drawing.Size(27, 22);
            this.activeLabel_W.TabIndex = 5;
            this.activeLabel_W.Text = "W";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.activeLabel_K);
            this.panel3.Controls.Add(this.activeLabel_M);
            this.panel3.Controls.Add(this.activeLabel_W);
            this.panel3.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel3.Location = new System.Drawing.Point(376, 4);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(85, 31);
            this.panel3.TabIndex = 6;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.WordsPathLabel);
            this.panel4.Controls.Add(this.MousePathLabel);
            this.panel4.Controls.Add(this.keyboardPathLabel);
            this.panel4.Controls.Add(this.label12);
            this.panel4.Controls.Add(this.label11);
            this.panel4.Controls.Add(this.label10);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Location = new System.Drawing.Point(80, 198);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(377, 98);
            this.panel4.TabIndex = 7;
            // 
            // WordsPathLabel
            // 
            this.WordsPathLabel.AutoSize = true;
            this.WordsPathLabel.Font = new System.Drawing.Font("Yu Gothic UI Light", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WordsPathLabel.ForeColor = System.Drawing.Color.White;
            this.WordsPathLabel.Location = new System.Drawing.Point(86, 74);
            this.WordsPathLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.WordsPathLabel.Name = "WordsPathLabel";
            this.WordsPathLabel.Size = new System.Drawing.Size(35, 15);
            this.WordsPathLabel.TabIndex = 3;
            this.WordsPathLabel.Text = "None";
            // 
            // MousePathLabel
            // 
            this.MousePathLabel.AutoSize = true;
            this.MousePathLabel.Font = new System.Drawing.Font("Yu Gothic UI Light", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MousePathLabel.ForeColor = System.Drawing.Color.White;
            this.MousePathLabel.Location = new System.Drawing.Point(86, 56);
            this.MousePathLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.MousePathLabel.Name = "MousePathLabel";
            this.MousePathLabel.Size = new System.Drawing.Size(35, 15);
            this.MousePathLabel.TabIndex = 2;
            this.MousePathLabel.Text = "None";
            // 
            // keyboardPathLabel
            // 
            this.keyboardPathLabel.AutoSize = true;
            this.keyboardPathLabel.Font = new System.Drawing.Font("Yu Gothic UI Light", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.keyboardPathLabel.ForeColor = System.Drawing.Color.White;
            this.keyboardPathLabel.Location = new System.Drawing.Point(86, 38);
            this.keyboardPathLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.keyboardPathLabel.Name = "keyboardPathLabel";
            this.keyboardPathLabel.Size = new System.Drawing.Size(35, 15);
            this.keyboardPathLabel.TabIndex = 1;
            this.keyboardPathLabel.Text = "None";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(8, 72);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 17);
            this.label12.TabIndex = 0;
            this.label12.Text = "Words:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(8, 54);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 17);
            this.label11.TabIndex = 0;
            this.label11.Text = "Mouse:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(8, 36);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 17);
            this.label10.TabIndex = 0;
            this.label10.Text = "Keyboard:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(20, 20);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 17);
            this.label9.TabIndex = 0;
            this.label9.Text = "Files path";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(152, 128);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(47, 17);
            this.label14.TabIndex = 21;
            this.label14.Text = "min(s)";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(97, 106);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(43, 17);
            this.label16.TabIndex = 22;
            this.label16.Text = "every";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(142, 105);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(37, 21);
            this.comboBox1.TabIndex = 20;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox3.ForeColor = System.Drawing.Color.White;
            this.checkBox3.Location = new System.Drawing.Point(5, 105);
            this.checkBox3.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(97, 21);
            this.checkBox3.TabIndex = 19;
            this.checkBox3.Text = "Save to file";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // btnChangeFileWords
            // 
            this.btnChangeFileWords.Enabled = false;
            this.btnChangeFileWords.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnChangeFileWords.Location = new System.Drawing.Point(100, 77);
            this.btnChangeFileWords.Name = "btnChangeFileWords";
            this.btnChangeFileWords.Size = new System.Drawing.Size(94, 23);
            this.btnChangeFileWords.TabIndex = 23;
            this.btnChangeFileWords.Text = "Change file";
            this.btnChangeFileWords.UseVisualStyleBackColor = true;
            this.btnChangeFileWords.Visible = false;
            // 
            // btnShowProceses
            // 
            this.btnShowProceses.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowProceses.Location = new System.Drawing.Point(27, 120);
            this.btnShowProceses.Name = "btnShowProceses";
            this.btnShowProceses.Size = new System.Drawing.Size(265, 29);
            this.btnShowProceses.TabIndex = 2;
            this.btnShowProceses.Text = "View processes";
            this.btnShowProceses.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(473, 313);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnStartStop);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.panel4);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(489, 352);
            this.MinimumSize = new System.Drawing.Size(489, 352);
            this.Name = "Form1";
            this.Text = "Monitoring";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl.ResumeLayout(false);
            this.Keyboard.ResumeLayout(false);
            this.Keyboard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.mousePage.ResumeLayout(false);
            this.mousePage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureMouseLog)).EndInit();
            this.wordsPage.ResumeLayout(false);
            this.wordsPage.PerformLayout();
            this.processesPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnStartStop)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage Keyboard;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ListBox LogList;
        private System.Windows.Forms.TabPage mousePage;
        private System.Windows.Forms.TabPage wordsPage;
        private System.Windows.Forms.TabPage processesPage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox keyboardMincb;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureMouseLog;
        private Bunifu.Framework.UI.BunifuImageButton btnStartStop;
        private System.Windows.Forms.Button btnChangeFileMouse;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox mouseMincb;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox cbKeyboardActive;
        private System.Windows.Forms.CheckBox cbMouseActive;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnChangeFileKB;
        private Bunifu.Framework.UI.BunifuCustomLabel activeLabel_K;
        private Bunifu.Framework.UI.BunifuCustomLabel activeLabel_M;
        private Bunifu.Framework.UI.BunifuCustomLabel activeLabel_W;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.CheckBox cbWordsActive;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label WordsPathLabel;
        private System.Windows.Forms.Label MousePathLabel;
        private System.Windows.Forms.Label keyboardPathLabel;
        private System.Windows.Forms.ListBox wordsLog;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnAddWord;
        private System.Windows.Forms.ListBox wordsList;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.Button btnChangeFileWords;
        private System.Windows.Forms.Button btnShowProceses;
    }
}

