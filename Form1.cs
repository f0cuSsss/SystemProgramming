using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using Bunifu.Framework.UI;

namespace ExamSystemProgramming
{
    public partial class Form1 : Form
    {
        //===================================================================================
        private bool isDisable { get; set; } // Program
        List<String> logListKeyboard { get; set; }
        List<String> logListWords { get; set; }

        //===================================================================================
        /* saveFilePaths */
        private String keyboardFilePath { get; set; } = String.Empty;
        private String mouseFilePath { get; set; } = String.Empty;
        private String wordsFilePath { get; set; } = String.Empty;

        //===================================================================================
        /* Mouse Graphics */
        Pen penLKM, penRKM, penMove;
        Brush brushLDown, brushLUp;
        Graphics GDI;

        //===================================================================================
        /* Words */

        List<String> searchWords;
        private String userInput = String.Empty;

        //===================================================================================
        /* Processes */

        Process[] processes;
        private int selectedIndex;

        //===================================================================================

        public Form1()
        {
            InitializeComponent();
            isDisable = true;
            searchWords = new List<String>();
            logListKeyboard = new List<String>();
            logListWords = new List<String>();
            GDI = pictureMouseLog.CreateGraphics();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            penLKM = new Pen(Color.LimeGreen, 3);
            penRKM = new Pen(Color.HotPink, 3);
            penMove = new Pen(Color.BlueViolet, 1);
            brushLDown = new SolidBrush(Color.LimeGreen);
            brushLUp = new SolidBrush(Color.Pink);
            fillMinComboBoxs();
            keyboardMincb.SelectedIndex = 0;
            wordsMinsCB.SelectedIndex = 0;

            saveFDKeyboard.Filter = "All Files(*.*)|*.*|Text Files(*.txt) | *.txt || ";
            saveFDKeyboard.FilterIndex = 2;

            saveFDWords.Filter = "All Files(*.*)|*.*|Text Files(*.txt) | *.txt || ";
            saveFDWords.FilterIndex = 2;
        }

        //===================================================================================
        /* Hooks */
        #region Hooks
        // Номер клавиатурного хука
        private const int WH_KEYBOARD_LL = 13;
        // Виндовс смс поступают от клавиатуры
        private const int WM_KEYDOWN = 0X0100;

        private const int
            WH_MOUSE_LL = 14,
            WM_LBUTTONDOWN = 0x0201,
            WM_LBUTTONUP = 0x0202,
            WM_MOUSEMOVE = 0x0200,
            WM_MOUSEWHELL = 0x020A,
            WM_RBUTTONDOWN = 0x0204,
            WM_RBUTTONUP = 0x0205;

        #region KEYBOARDMOVE
        private delegate IntPtr HookProc(int nCode, IntPtr wParaw, IntPtr eParam);

        [DllImport("user32.dll", SetLastError = true)]
        private static extern uint SendInput(uint numberOfInputs, INPUT[] inputs, int sizeOfInputsStructure);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr SetWindowsHookEx(int idHook, HookProc lpfn, IntPtr hMod, uint dwThreadId);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern bool UnhookWindowsHookEx(IntPtr hhk);    // вернуть в старое состоянее

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr CallNextHookEx(IntPtr hhk, int nCode, IntPtr wParam, IntPtr lParam);//вызвать

        [DllImport("Kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr GetModuleHandle(string lpModuleName);   // получить адрес нашего модулю

        #endregion KEYBOARDMOVE

        private static HookProc kbProcWords = KbHookCallbackWords;    //новый адрес
        private static HookProc kbProcKeyboard = KbHookCallbackKeyboard;
        private static HookProc msProc = msHookCallMouse;

        private static IntPtr kbHookWords;   // для старого
        private static IntPtr kbHookKeyboard;
        private static IntPtr msHook;

        private static IntPtr KbHookCallbackWords(int nCode, IntPtr wParam, IntPtr lParam)
        {
            if (nCode >= 0 && wParam == (IntPtr)WM_KEYDOWN)
            {
                // Маршилиризация обработчика с неуправляемой памятью
                int keyCode = Marshal.ReadInt32(lParam);
                Keys keyEnum = (Keys)keyCode;
                Program.MainForm.userInput += keyEnum.ToString();
                if (keyEnum == Keys.Space) Program.MainForm.userInput = String.Empty;
                foreach (String w in Program.MainForm.searchWords)
                {
                    if (Program.MainForm.userInput.Contains(w))
                    {
                        Program.MainForm.wordsLog.Items.Add("Detected: " + w);
                        MessageBox.Show("Detected: " + w);
                        Program.MainForm.userInput = String.Empty;
                    }
                }

            }
            return CallNextHookEx(kbHookWords, nCode, wParam, lParam);    //запуск стандартного обработчика
        }
        private static IntPtr KbHookCallbackKeyboard(int nCode, IntPtr wParam, IntPtr lParam)
        {
            if (nCode >= 0 && wParam == (IntPtr)WM_KEYDOWN)
            {
                // Маршилиризация обработчика с неуправляемой памятью
                int keyCode = Marshal.ReadInt32(lParam);
                Keys keyEnum = (Keys)keyCode;
                Program.MainForm.kbLogList.Items.Add("Intercept: " + keyEnum);
                Program.MainForm.logListKeyboard.Add("Intercept: " + keyEnum);
                return (IntPtr)1;
            }
            return CallNextHookEx(kbHookWords, nCode, wParam, lParam);    //запуск стандартного обработчика
        }
        private static IntPtr msHookCallMouse(int nCode, IntPtr wParam, IntPtr lParam)
        {
            if (nCode >= 0)
            {
                MsHookStruct hookStruct = (MsHookStruct)Marshal.PtrToStructure(lParam, typeof(MsHookStruct));
                if (wParam == (IntPtr)WM_LBUTTONDOWN)
                    Program.MainForm.GDI.DrawEllipse(Program.MainForm.penLKM, hookStruct.point.x / 10f - 4, hookStruct.point.y / 10f - 4, 8, 8);
                else if (wParam == (IntPtr)WM_RBUTTONDOWN)
                    Program.MainForm.GDI.DrawEllipse(Program.MainForm.penRKM, hookStruct.point.x / 10f - 4, hookStruct.point.y / 10f - 4, 8, 8);
                else if (wParam == (IntPtr)WM_MOUSEMOVE)
                    Program.MainForm.GDI.DrawEllipse(Program.MainForm.penMove, hookStruct.point.x / 10f, hookStruct.point.y / 10f, 2, 2);
                else if (wParam == (IntPtr)WM_LBUTTONDOWN)
                    Program.MainForm.GDI.DrawEllipse(Program.MainForm.penRKM, hookStruct.point.x / 10f - 4, hookStruct.point.y / 10f - 4, 8, 8);
                else if (wParam == (IntPtr)WM_LBUTTONUP)
                    Program.MainForm.GDI.DrawEllipse(Program.MainForm.penMove, hookStruct.point.x / 10f - 4, hookStruct.point.y / 10f - 4, 4, 4);
            }
            return CallNextHookEx(msHook, nCode, wParam, lParam);
        }

        private static IntPtr SetKbHook(HookProc proc)
        {
            using (Process curProcess = Process.GetCurrentProcess())
            using (ProcessModule curModule = curProcess.MainModule)
            {
                return SetWindowsHookEx(WH_KEYBOARD_LL, proc, GetModuleHandle(curModule.ModuleName), 0);
            }
        }
        private static IntPtr SetMSHook(HookProc proc)
        {
            using (Process curProcess = Process.GetCurrentProcess())
            using (ProcessModule curModule = curProcess.MainModule)
            {
                return SetWindowsHookEx(WH_MOUSE_LL, proc, GetModuleHandle(curModule.ModuleName), 0);
            }
        }
        #endregion Hooks

        //===================================================================================

        private void keyboardSaveCB_ClickCheckedChanged(object sender, EventArgs e)
        {
            if (keyboardFilePath.Equals(String.Empty))
            {
                SaveFileDialog sfd = Program.MainForm.saveFDKeyboard;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    keyboardFilePath = Path.GetFullPath(sfd.FileName);
                    keyboardPathLabel.Text = keyboardFilePath.ToString();

                    timerKBsave.Interval = Convert.ToInt32(keyboardMincb.SelectedItem) * 60000;
                    timerKBsave.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Path not specified");
                    keyboardSaveCB.Checked = false;
                }
            }
        }

        //===================================================================================
        /* Save, timer tick */

        private void wordsSaveCB_ClickCheckedChanged(object sender, EventArgs e)
        {
            if (wordsFilePath.Equals(String.Empty))
            {
                SaveFileDialog sfd = Program.MainForm.saveFDWords;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    wordsFilePath = Path.GetFullPath(sfd.FileName);
                    WordsPathLabel.Text = wordsFilePath.ToString();

                    timerWsave.Interval = Convert.ToInt32(keyboardMincb.SelectedItem) * 60000;
                    timerWsave.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Path not specified");
                    wordsSaveCB.Checked = false;
                }
            }
        }

        private void timerKBsave_Tick(object sender, EventArgs e)
        {
            try
            {
                using (TextWriter writer = File.AppendText(keyboardFilePath))
                {
                    foreach (String str in Program.MainForm.logListKeyboard)
                    {
                        writer.WriteLine(str.ToString());
                    }
                }
                Program.MainForm.logListKeyboard?.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error!" + Environment.NewLine + ex.Message);
            }
        }

        private void timerWsave_Tick(object sender, EventArgs e)
        {
            try
            {
                using (TextWriter writer = File.AppendText(wordsFilePath))
                {
                    foreach (String str in Program.MainForm.wordsLog.Items)
                    {
                        writer.WriteLine(str.ToString());
                    }
                }
                Program.MainForm.logListWords?.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error!" + Environment.NewLine + ex.Message);

            }
        }

        private void wordsList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (wordsList.SelectedItem != null)
            {
                wordsList.Items.RemoveAt(wordsList.SelectedIndex);
            }
        }

        private void mouseSaveCB_ClickCheckedChanged(object sender, EventArgs e)
        {
            if (mouseFilePath.Equals(String.Empty))
            {
                SaveFileDialog sfd = Program.MainForm.saveFDMouse;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    mouseFilePath = Path.GetFullPath(sfd.FileName);
                    MousePathLabel.Text = mouseFilePath.ToString();
                }
                else
                {
                    MessageBox.Show("Path not specified");
                    mouseSaveCB.Checked = false;
                }
            }
        }

        private void saveMouseLogAsImage()
        {
            try
            {
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //===================================================================================
        /* Active indication */

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

        //===================================================================================
        /* Secondary functions */

        private void changeColor(object cb, object lb)
        {
            CheckBox lcb = cb as CheckBox;
            BunifuCustomLabel bcl = lb as BunifuCustomLabel;
            bcl.ForeColor = lcb.Checked == true ? Color.Chartreuse : Color.Red;
        }

        private void fillMinComboBoxs()
        {
            for (int i = 1; i <= 15; i++)
            {
                keyboardMincb.Items.Add(i);
                wordsMinsCB.Items.Add(i);
            }
        }

        //===================================================================================
        /* Button START-STOP */

        private void btnStartStop_Click(object sender, EventArgs e)
        {
            isDisable = !isDisable;
            if (isDisable == false) // Program is running
            {
                btnStartStop.Image = Image.FromFile("...\\...\\Resources\\stop.jpg");
                if (cbKeyboardActive.Checked == true)
                {
                    kbHookKeyboard = SetKbHook(kbProcKeyboard);
                    kbLogList.Items.Add("Keyboard hook activated");

                    if (keyboardSaveCB.Checked == true)
                    {
                        timerKBsave.Start();
                    }
                }

                if (cbMouseActive.Checked == true)
                {
                    msHook = SetMSHook(msProc);
                }

                if (cbWordsActive.Checked == true)
                {
                    kbHookWords = SetKbHook(kbProcWords);
                    wordsLog.Items.Add("Keyboard hook activated");

                    if (wordsSaveCB.Checked == true)
                    {
                        timerWsave.Start();
                    }
                }
            }
            else
            {
                btnStartStop.Image = Image.FromFile("...\\...\\Resources\\start.jpg");

                if (cbKeyboardActive.Checked == true)
                {
                    kbLogList.Items.Add("Deactivated");
                    UnhookWindowsHookEx(kbHookKeyboard);
                    if (timerKBsave.Enabled == true)
                    {
                        timerKBsave.Enabled = false;
                    }
                }

                if (cbMouseActive.Checked == true)
                {
                    UnhookWindowsHookEx(msHook);

                    if (mouseSaveCB.Checked == true)
                    {
                        saveMouseLogAsImage();
                    }
                }

                if (cbWordsActive.Checked == true)
                {
                    wordsLog.Items.Add("Deactivated");
                    UnhookWindowsHookEx(kbHookWords);

                    if (timerWsave.Enabled == true)
                    {
                        timerWsave.Enabled = false;
                    }
                }

            }
        }

        //===================================================================================
        /* Proceses */

        private void btnShowProceses_Click(object sender, EventArgs e)
        {
            selectedIndex = processesList.SelectedIndex;
            processesList.Items.Clear();
            processes = Process.GetProcesses();
            int countProcesses = 0;
            foreach (var process in processes)
            {
                processesList.Items.Add($"{countProcesses}: {process.Id} {process.ProcessName}");
                countProcesses++;
            }
            processesList.SelectedIndex = selectedIndex;
        }

        //===================================================================================
        /* Words page */

        private void btnAddWord_Click(object sender, EventArgs e)
        {
            if ("".Equals(wordAddTextbox.Text))
            {
                MessageBox.Show("Replace word is empty");
                return;
            }

            var sb = new StringBuilder();
            foreach (char c in wordAddTextbox.Text)
            {
                sb.Append(((Keys)char.ToUpper(c)).ToString());
            }
            searchWords.Add(sb.ToString());
            wordsList.Items.Add(wordAddTextbox.Text);

            wordAddTextbox.Clear();
        }

        //===================================================================================
    }
}
