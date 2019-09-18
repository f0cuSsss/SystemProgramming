using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bunifu.Framework.UI;

namespace ExamSystemProgramming
{
    public partial class Form1 : Form
    {
        private bool isDisable { get; set; }

        public Form1()
        {
            InitializeComponent();
            isDisable = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void cbKeyboardActive_CheckedChanged(object sender, EventArgs e)
        {
            changeColor(cbKeyboardActive, activeLabel_K);
        }

        private void cbMouseActive_CheckedChanged(object sender, EventArgs e)
        {
            changeColor(cbMouseActive, activeLabel_M);
        }

        private void cbWordsActive_CheckedChanged(object sender, EventArgs e)
        {
            changeColor(cbWordsActive, activeLabel_W);
        }

        private void changeColor(object cb, object lb)
        {
            CheckBox lcb = cb as CheckBox;
            BunifuCustomLabel bcl = lb as BunifuCustomLabel;
            bcl.ForeColor = lcb.Checked == true ? Color.Chartreuse : Color.Red;
        }

        private void btnStartStop_Click(object sender, EventArgs e)
        {
            isDisable = !isDisable;
            btnStartStop.Image = isDisable == false ? Image.FromFile("...\\...\\Resources\\stop.jpg") : Image.FromFile("...\\...\\Resources\\start.jpg");
        }
    }
}
