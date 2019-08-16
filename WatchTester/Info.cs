using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WatchTester
{
    public partial class Info : Form
    {
        public Info()
        {
            InitializeComponent();
            pcb_Close.Click += (s, e) => { this.Close(); };
            pcb_Close.MouseEnter += (s, e) => { pcb_Close.Image = Properties.Resources.checked36px; };
            pcb_Close.MouseLeave += (s, e) => { pcb_Close.Image = Properties.Resources.unchecked36px; };
        }

        private void Info_Load(object sender, EventArgs e)
        {
            
            string[] el = Assembly.GetExecutingAssembly().FullName.Split(',');
            lbl_Name.Text = el[0];
            lbl_Version.Text = el[1].Split('=')[1];
            string desc = "Цифровые часы, реализованные на 20-ти сегментных" +
                "\nиндикаторах. Содержат будильник.\n" +
                "Нововведения и исправления текущей версии: \n" +
                "• Добавлена возможность самостоятельно выбрать мелодию будильника.\n" +
                "• Добавлена настройка исчезновения формы при наведении курсора мыши. Данная настройка включается автоматически при установлении прозрачности 25%.\n" +
                "• Добавлено отображение секунд на дисплее и возможность регулировать их отображение.\n" +
                "• По просьбе трудящихся был добавлен крестик на главной форме виджета.\n" +
                "• Исправлены баги с отображением цифер на сегментах\n" +
                "• Исправлены прочие мелкие баги.";
                rtb_Description.Text = desc;
        }
    }
}
