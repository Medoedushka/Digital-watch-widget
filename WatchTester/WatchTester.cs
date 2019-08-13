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
        Color Background { get; set; }

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
            if (!tsm_MostTopChange.Checked)
            {
                this.TopMost = true;
                configControler.SetConfig("TopMost=true");
            }
            else
            {
                this.TopMost = false;
                configControler.SetConfig("TopMost=false");
            }
            tsm_MostTopChange.Checked = !tsm_MostTopChange.Checked;
            
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void WatchTester_Load(object sender, EventArgs e)
        {
            
            InitConfig();
            digitalWatch1.WatchOn();
        }

        private void закрепитьВиджетToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string newPos = this.Location.X + "X" + this.Location.Y;
            configControler.SetConfig("WatchLocation=" + newPos);
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

        // Инициализация начальных настроек.
        private void InitConfig()
        {
            string answer;
            // Настройка координат расположения формы при старте.
            string[] el = configControler.GetConfig("WatchLocation").Split('X');
            this.Location = new Point(int.Parse(el[0]), int.Parse(el[1]));

            // Настройках расположения окна поверх других окон.
            answer = configControler.GetConfig("TopMost");
            if (answer == "true")
            {
                this.TopMost = true;
                tsm_MostTopChange.Checked = true;
            }
            else
            {
                this.TopMost = false;
                tsm_MostTopChange.Checked = false;
            }

            // Настройка автозагрузки приложения.
            answer = configControler.GetConfig("AutoRun");
            if (answer == "true") tsm_AddToAutoRun.Checked = true;
            else tsm_AddToAutoRun.Checked = false;
        }

        private void tsm_AddToAutoRun_Click(object sender, EventArgs e)
        {
            if (!tsm_AddToAutoRun.Checked)
            {
                SetAutoRunValue(true, Assembly.GetExecutingAssembly().Location);
                configControler.SetConfig("AutoRun=true");
            }
            else
            {
                SetAutoRunValue(false, Assembly.GetExecutingAssembly().Location);
                configControler.SetConfig("AutoRun=false");
            }
            tsm_AddToAutoRun.Checked = !tsm_AddToAutoRun.Checked;
        }
    }
}
