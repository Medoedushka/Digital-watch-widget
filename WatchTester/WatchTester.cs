using System;
using Microsoft.Win32;
using System.Reflection;
using System.Drawing;
using System.Windows.Forms;
using MyClassLibrary;
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace WatchTester
{
    public partial class WatchTester : Form
    {
        bool ActiveWatch = true;
        string configFile = @"..\..\Resources\Config.txt";
        ConfigControler configControler;

        private const int WM_NCHITTEST = 0x84;
        private const int HT_CLIENT = 0x1;
        private const int HT_CAPTION = 0x2;
        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == WM_NCHITTEST) m.Result = (IntPtr)(HT_CAPTION);
        }
        

        public WatchTester()
        {
            InitializeComponent();
            configControler = new ConfigControler(configFile);
            
        }
        
        // Включение/выключение часов.
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            pcb_OnOff.Image = Properties.Resources.pressedButton;
        }
        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            pcb_OnOff.Image = Properties.Resources.unpressedButton;
            if (!ActiveWatch)
                digitalWatch1.WatchOn();
            else digitalWatch1.WatchOff();
            ActiveWatch = !ActiveWatch;
        }

        private void WatchTester_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right) cms_Settings.Show();
        }

        private void tsm_MostTopChange_Click(object sender, EventArgs e)
        {
            if (!tsm_MostTopChange.Checked) this.TopMost = true;
            else this.TopMost = false;
            tsm_MostTopChange.Checked = !tsm_MostTopChange.Checked;
            
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void WatchTester_Load(object sender, EventArgs e)
        {
            SetAutoRunValue(true, Assembly.GetExecutingAssembly().Location);
            string[] el = configControler.GetConfig("Watch Location").Split('X');
            this.Location = new Point(int.Parse(el[0]), int.Parse(el[1]));
            digitalWatch1.WatchOn();
        }

        private void закрепитьВиджетToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string newPos = this.Location.X + "X" + this.Location.Y;
            configControler.SetConfig("Watch Location=" + newPos);
        }


        // Работа с реестром для добавления приложения в автозагрузку.
        private bool SetAutoRunValue(bool autorun, string path)
        {
            const string name = "DigitalWatch";
            string exePath = path;
            RegistryKey reg;

            reg = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run");
            try
            {
                if (autorun)
                {
                    reg.SetValue(name, exePath);
                }
                else
                {
                    reg.DeleteValue(name);
                }
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                reg.Flush();
                reg.Close();
            }
            return true;
        }
    }
}
