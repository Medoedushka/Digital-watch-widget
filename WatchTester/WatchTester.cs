using System;
using Microsoft.Win32;
using System.Reflection;
using System.Drawing;
using System.Windows.Forms;
using MyClassLibrary;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace WatchTester
{
    public partial class WatchTester : Form
    {
        bool ActiveWatch = true;
        string configFile = @"D:\Проекты C#\Digital-watch-widget\WatchTester\bin\Debug\Config.txt";
        ConfigControler configControler;
        Color Background { get; set; }

        [DllImport("user32", CharSet = CharSet.Auto)]
        internal extern static bool PostMessage(IntPtr hWnd, uint Msg, uint WParam, uint LParam);
        [DllImport("user32", CharSet = CharSet.Auto)]
        internal extern static bool ReleaseCapture();

        const uint WM_SYSCOMMAND = 0x0112;
        const uint DOMOVE = 0xF012;
        const uint DOSIZE = 0xF008;

        private void digitalWatch1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                PostMessage(this.Handle, WM_SYSCOMMAND, DOMOVE, 0);
            }

        }

        public WatchTester()
        {
            InitializeComponent();

            string[] el = Assembly.GetExecutingAssembly().Location.Split('\\');
            string newStr = "";
            for (int i = 0; i < el.Length; i++)
            {
                
                if (i == el.Length - 1)
                {
                    newStr += "Config.txt";
                    configFile = newStr;
                    break;
                }
                newStr += el[i] + "\\";
            }

            configControler = new ConfigControler(configFile);
            
        }

        // Включение/выключение часов.
        private void pcb_OnOff_MouseDown(object sender, MouseEventArgs e)
        {
            pcb_OnOff.Image = Properties.Resources.pressedButton;
        }
        private void pcb_OnOff_MouseUp(object sender, MouseEventArgs e)
        {
            if (!digitalWatch1.Alarm)
            {
                
                if (!ActiveWatch)
                    digitalWatch1.WatchOn();
                else digitalWatch1.WatchOff();
                ActiveWatch = !ActiveWatch;
                digitalWatch1.StopAlarm();
            }
            else
            {
                string[] el = digitalWatch1.AlarmApply().Split(':');
                string msg = "До срабатывания будильника осталось " + el[0] + " часов, " + el[1] + " минут, " + el[2] + " секунд";
                notifyIcon1.ShowBalloonTip(5, "Будильник.", msg, ToolTipIcon.Info);
            }
            pcb_OnOff.Image = Properties.Resources.unpressedButton;
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

            // Настройка автозагрузки виджета.
            answer = configControler.GetConfig("AutoRun");
            if (answer == "true")
            {
                SetAutoRunValue(true, Assembly.GetExecutingAssembly().Location);
                tsm_AddToAutoRun.Checked = true;
            }
            else
            {
                SetAutoRunValue(false, Assembly.GetExecutingAssembly().Location);
                tsm_AddToAutoRun.Checked = false;
            }

            // Настройка прозрачности виджета.
            answer = configControler.GetConfig("Opacity");
            this.Opacity = double.Parse(answer.Replace('.', ','));
            if (answer == "0.25") tsm_Opacity25.Checked = true;
            else if (answer == "0.50") tsm_Opacity50.Checked = true;
            else if (answer == "0.75") tsm_Opacity75.Checked = true;
            else tsm_Opacity100.Checked = true;
        }

        // Настройка автозагрузки виджета.
        private void tsm_AddToAutoRun_Click(object sender, EventArgs e)
        {
            if (!tsm_AddToAutoRun.Checked) configControler.SetConfig("AutoRun=true");
            else configControler.SetConfig("AutoRun=false");
            tsm_AddToAutoRun.Checked = !tsm_AddToAutoRun.Checked;
            notifyIcon1.ShowBalloonTip(5000, "Изменение настроек.",
                "Для того, чтобы изменения пришли в силу, перезагрузите виджет.", ToolTipIcon.Info);
        }
        // Настройка прозрачности виджета.
        private void tsm_Opacity25_Click(object sender, EventArgs e)
        {
            this.Opacity = 0.25;
            configControler.SetConfig("Opacity=0.25");
            tsm_Opacity25.Checked = true;
            tsm_Opacity50.Checked = false;
            tsm_Opacity75.Checked = false;
            tsm_Opacity100.Checked = false;
        }
        private void tsm_Opacity50_Click(object sender, EventArgs e)
        {
            this.Opacity = 0.50;
            configControler.SetConfig("Opacity=0.50");
            tsm_Opacity25.Checked = false;
            tsm_Opacity50.Checked = true;
            tsm_Opacity75.Checked = false;
            tsm_Opacity100.Checked = false;
        }
        private void tsm_Opacity75_Click(object sender, EventArgs e)
        {
            this.Opacity = 0.75;
            configControler.SetConfig("Opacity=0.75");
            tsm_Opacity25.Checked = false;
            tsm_Opacity50.Checked = false;
            tsm_Opacity75.Checked = true;
            tsm_Opacity100.Checked = false;
        }
        private void tsm_Opacity100_Click(object sender, EventArgs e)
        {
            this.Opacity = 1;
            configControler.SetConfig("Opacity=1");
            tsm_Opacity25.Checked = false;
            tsm_Opacity50.Checked = false;
            tsm_Opacity75.Checked = false;
            tsm_Opacity100.Checked = true;
        }

        private void pcb_Alarm_MouseDown(object sender, MouseEventArgs e)
        {
            pcb_Alarm.Image = Properties.Resources.pressedButton;
            if (!digitalWatch1.Alarm)
            digitalWatch1.AlarmOn((int)nud_Hours.Value, (int)nud_Minutes.Value, (int)nud_Seconds.Value);
        }

        private void pcb_Alarm_MouseUp(object sender, MouseEventArgs e)
        {
           pcb_Alarm.Image = Properties.Resources.unpressedButton;
           if (digitalWatch1.AlarmStarted) digitalWatch1.AlarmOff();
        }
    }
}
