namespace WatchTester
{
    partial class WatchTester
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WatchTester));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cms_Settings = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.видToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_MostTopChange = new System.Windows.Forms.ToolStripMenuItem();
            this.прозрачностьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_Opacity25 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_Opacity50 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_Opacity75 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_Opacity100 = new System.Windows.Forms.ToolStripMenuItem();
            this.закрепитьВиджетToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_AddToAutoRun = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_ChangeAlarmSound = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.cms_NotifyIcon = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsm_HideOnMouseCursor = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nud_Hours = new System.Windows.Forms.NumericUpDown();
            this.nud_Minutes = new System.Windows.Forms.NumericUpDown();
            this.nud_Seconds = new System.Windows.Forms.NumericUpDown();
            this.pcb_Alarm = new System.Windows.Forms.PictureBox();
            this.pcb_OnOff = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pcb_CloseWidget = new System.Windows.Forms.PictureBox();
            this.digitalWatch1 = new Watch.DigitalWatch();
            this.tsm_ShowSeconds = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cms_Settings.SuspendLayout();
            this.cms_NotifyIcon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Hours)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Minutes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Seconds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_Alarm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_OnOff)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_CloseWidget)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(1, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Created by Medoed";
            this.label2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.WatchTester_MouseMove);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 7F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(2, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "ON/OFF";
            // 
            // cms_Settings
            // 
            this.cms_Settings.Font = new System.Drawing.Font("Century", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cms_Settings.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.видToolStripMenuItem,
            this.закрепитьВиджетToolStripMenuItem,
            this.tsm_AddToAutoRun,
            this.tsm_ChangeAlarmSound});
            this.cms_Settings.Name = "cms_Settings";
            this.cms_Settings.Size = new System.Drawing.Size(248, 92);
            // 
            // видToolStripMenuItem
            // 
            this.видToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.видToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsm_MostTopChange,
            this.прозрачностьToolStripMenuItem,
            this.tsm_ShowSeconds});
            this.видToolStripMenuItem.Font = new System.Drawing.Font("Century", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.видToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.видToolStripMenuItem.Name = "видToolStripMenuItem";
            this.видToolStripMenuItem.Size = new System.Drawing.Size(247, 22);
            this.видToolStripMenuItem.Text = "Вид";
            // 
            // tsm_MostTopChange
            // 
            this.tsm_MostTopChange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.tsm_MostTopChange.Checked = true;
            this.tsm_MostTopChange.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsm_MostTopChange.ForeColor = System.Drawing.Color.White;
            this.tsm_MostTopChange.Name = "tsm_MostTopChange";
            this.tsm_MostTopChange.Size = new System.Drawing.Size(186, 22);
            this.tsm_MostTopChange.Text = "Поверх других окон";
            this.tsm_MostTopChange.Click += new System.EventHandler(this.tsm_MostTopChange_Click);
            // 
            // прозрачностьToolStripMenuItem
            // 
            this.прозрачностьToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.прозрачностьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsm_Opacity25,
            this.tsm_Opacity50,
            this.tsm_Opacity75,
            this.tsm_Opacity100});
            this.прозрачностьToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.прозрачностьToolStripMenuItem.Name = "прозрачностьToolStripMenuItem";
            this.прозрачностьToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.прозрачностьToolStripMenuItem.Text = "Прозрачность";
            // 
            // tsm_Opacity25
            // 
            this.tsm_Opacity25.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.tsm_Opacity25.ForeColor = System.Drawing.Color.White;
            this.tsm_Opacity25.Name = "tsm_Opacity25";
            this.tsm_Opacity25.Size = new System.Drawing.Size(101, 22);
            this.tsm_Opacity25.Text = "25%";
            this.tsm_Opacity25.Click += new System.EventHandler(this.tsm_Opacity25_Click);
            // 
            // tsm_Opacity50
            // 
            this.tsm_Opacity50.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.tsm_Opacity50.ForeColor = System.Drawing.Color.White;
            this.tsm_Opacity50.Name = "tsm_Opacity50";
            this.tsm_Opacity50.Size = new System.Drawing.Size(101, 22);
            this.tsm_Opacity50.Text = "50%";
            this.tsm_Opacity50.Click += new System.EventHandler(this.tsm_Opacity50_Click);
            // 
            // tsm_Opacity75
            // 
            this.tsm_Opacity75.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.tsm_Opacity75.ForeColor = System.Drawing.Color.White;
            this.tsm_Opacity75.Name = "tsm_Opacity75";
            this.tsm_Opacity75.Size = new System.Drawing.Size(101, 22);
            this.tsm_Opacity75.Text = "75%";
            this.tsm_Opacity75.Click += new System.EventHandler(this.tsm_Opacity75_Click);
            // 
            // tsm_Opacity100
            // 
            this.tsm_Opacity100.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.tsm_Opacity100.ForeColor = System.Drawing.Color.White;
            this.tsm_Opacity100.Name = "tsm_Opacity100";
            this.tsm_Opacity100.Size = new System.Drawing.Size(101, 22);
            this.tsm_Opacity100.Text = "100%";
            this.tsm_Opacity100.Click += new System.EventHandler(this.tsm_Opacity100_Click);
            // 
            // закрепитьВиджетToolStripMenuItem
            // 
            this.закрепитьВиджетToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.закрепитьВиджетToolStripMenuItem.Font = new System.Drawing.Font("Century", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.закрепитьВиджетToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.закрепитьВиджетToolStripMenuItem.Name = "закрепитьВиджетToolStripMenuItem";
            this.закрепитьВиджетToolStripMenuItem.Size = new System.Drawing.Size(247, 22);
            this.закрепитьВиджетToolStripMenuItem.Text = "Закрепить виджет";
            this.закрепитьВиджетToolStripMenuItem.Click += new System.EventHandler(this.закрепитьВиджетToolStripMenuItem_Click);
            // 
            // tsm_AddToAutoRun
            // 
            this.tsm_AddToAutoRun.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.tsm_AddToAutoRun.ForeColor = System.Drawing.Color.White;
            this.tsm_AddToAutoRun.Name = "tsm_AddToAutoRun";
            this.tsm_AddToAutoRun.Size = new System.Drawing.Size(247, 22);
            this.tsm_AddToAutoRun.Text = "Добавить виджет в автозагрузку";
            this.tsm_AddToAutoRun.Click += new System.EventHandler(this.tsm_AddToAutoRun_Click);
            // 
            // tsm_ChangeAlarmSound
            // 
            this.tsm_ChangeAlarmSound.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.tsm_ChangeAlarmSound.ForeColor = System.Drawing.Color.White;
            this.tsm_ChangeAlarmSound.Name = "tsm_ChangeAlarmSound";
            this.tsm_ChangeAlarmSound.Size = new System.Drawing.Size(247, 22);
            this.tsm_ChangeAlarmSound.Text = "Изменить мелодию будильника";
            this.tsm_ChangeAlarmSound.Click += new System.EventHandler(this.tsm_ChangeAlarmSound_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.cms_NotifyIcon;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "DigitalWatch";
            this.notifyIcon1.Visible = true;
            // 
            // cms_NotifyIcon
            // 
            this.cms_NotifyIcon.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsm_HideOnMouseCursor,
            this.справкаToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.cms_NotifyIcon.Name = "cms_NotifyIcon";
            this.cms_NotifyIcon.Size = new System.Drawing.Size(210, 92);
            // 
            // tsm_HideOnMouseCursor
            // 
            this.tsm_HideOnMouseCursor.Name = "tsm_HideOnMouseCursor";
            this.tsm_HideOnMouseCursor.Size = new System.Drawing.Size(209, 22);
            this.tsm_HideOnMouseCursor.Text = "Исчезать при наведении";
            this.tsm_HideOnMouseCursor.CheckedChanged += new System.EventHandler(this.tsm_HideOnMouseCursor_CheckedChanged);
            this.tsm_HideOnMouseCursor.Click += new System.EventHandler(this.tsm_HideOnMouseCursor_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // nud_Hours
            // 
            this.nud_Hours.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.nud_Hours.ForeColor = System.Drawing.Color.White;
            this.nud_Hours.Location = new System.Drawing.Point(102, 102);
            this.nud_Hours.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.nud_Hours.Name = "nud_Hours";
            this.nud_Hours.Size = new System.Drawing.Size(37, 20);
            this.nud_Hours.TabIndex = 6;
            // 
            // nud_Minutes
            // 
            this.nud_Minutes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.nud_Minutes.ForeColor = System.Drawing.Color.White;
            this.nud_Minutes.Location = new System.Drawing.Point(145, 102);
            this.nud_Minutes.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.nud_Minutes.Name = "nud_Minutes";
            this.nud_Minutes.Size = new System.Drawing.Size(37, 20);
            this.nud_Minutes.TabIndex = 6;
            // 
            // nud_Seconds
            // 
            this.nud_Seconds.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.nud_Seconds.ForeColor = System.Drawing.Color.White;
            this.nud_Seconds.Location = new System.Drawing.Point(188, 102);
            this.nud_Seconds.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.nud_Seconds.Name = "nud_Seconds";
            this.nud_Seconds.Size = new System.Drawing.Size(37, 20);
            this.nud_Seconds.TabIndex = 6;
            // 
            // pcb_Alarm
            // 
            this.pcb_Alarm.Image = global::WatchTester.Properties.Resources.unpressedButton;
            this.pcb_Alarm.Location = new System.Drawing.Point(60, 98);
            this.pcb_Alarm.Name = "pcb_Alarm";
            this.pcb_Alarm.Size = new System.Drawing.Size(25, 25);
            this.pcb_Alarm.TabIndex = 4;
            this.pcb_Alarm.TabStop = false;
            this.pcb_Alarm.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pcb_Alarm_MouseDown);
            this.pcb_Alarm.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pcb_Alarm_MouseUp);
            // 
            // pcb_OnOff
            // 
            this.pcb_OnOff.Image = global::WatchTester.Properties.Resources.unpressedButton;
            this.pcb_OnOff.Location = new System.Drawing.Point(12, 98);
            this.pcb_OnOff.Name = "pcb_OnOff";
            this.pcb_OnOff.Size = new System.Drawing.Size(25, 25);
            this.pcb_OnOff.TabIndex = 4;
            this.pcb_OnOff.TabStop = false;
            this.pcb_OnOff.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pcb_OnOff_MouseDown);
            this.pcb_OnOff.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pcb_OnOff_MouseUp);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century", 7F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(53, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "ALARM";
            // 
            // pcb_CloseWidget
            // 
            this.pcb_CloseWidget.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pcb_CloseWidget.Image = global::WatchTester.Properties.Resources.uncheckedClose;
            this.pcb_CloseWidget.Location = new System.Drawing.Point(343, 0);
            this.pcb_CloseWidget.Name = "pcb_CloseWidget";
            this.pcb_CloseWidget.Size = new System.Drawing.Size(15, 15);
            this.pcb_CloseWidget.TabIndex = 7;
            this.pcb_CloseWidget.TabStop = false;
            this.pcb_CloseWidget.Click += new System.EventHandler(this.pcb_CloseWidget_Click);
            this.pcb_CloseWidget.MouseEnter += new System.EventHandler(this.pcb_CloseWidget_MouseEnter);
            this.pcb_CloseWidget.MouseLeave += new System.EventHandler(this.pcb_CloseWidget_MouseLeave);
            // 
            // digitalWatch1
            // 
            this.digitalWatch1.Alarm = false;
            this.digitalWatch1.AlarmStarted = false;
            this.digitalWatch1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.digitalWatch1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.digitalWatch1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.digitalWatch1.DisplayColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.digitalWatch1.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.digitalWatch1.Location = new System.Drawing.Point(2, 16);
            this.digitalWatch1.Margin = new System.Windows.Forms.Padding(4);
            this.digitalWatch1.Name = "digitalWatch1";
            this.digitalWatch1.OffColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(207)))), ((int)(((byte)(207)))), ((int)(((byte)(207)))));
            this.digitalWatch1.OnColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(187)))), ((int)(((byte)(199)))));
            this.digitalWatch1.Size = new System.Drawing.Size(356, 80);
            this.digitalWatch1.TabIndex = 2;
            // 
            // tsm_ShowSeconds
            // 
            this.tsm_ShowSeconds.Checked = true;
            this.tsm_ShowSeconds.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsm_ShowSeconds.Name = "tsm_ShowSeconds";
            this.tsm_ShowSeconds.Size = new System.Drawing.Size(186, 22);
            this.tsm_ShowSeconds.Text = "Отображение секунд";
            this.tsm_ShowSeconds.CheckedChanged += new System.EventHandler(this.tsm_ShowSeconds_CheckedChanged);
            this.tsm_ShowSeconds.Click += new System.EventHandler(this.tsm_ShowSeconds_Click);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // WatchTester
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(361, 151);
            this.ContextMenuStrip = this.cms_Settings;
            this.Controls.Add(this.pcb_CloseWidget);
            this.Controls.Add(this.nud_Seconds);
            this.Controls.Add(this.nud_Minutes);
            this.Controls.Add(this.nud_Hours);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pcb_Alarm);
            this.Controls.Add(this.pcb_OnOff);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.digitalWatch1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(1280, 40);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "WatchTester";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "WatchTester";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.WatchTester_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.WatchTester_MouseClick);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.digitalWatch1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.WatchTester_MouseMove);
            this.cms_Settings.ResumeLayout(false);
            this.cms_NotifyIcon.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nud_Hours)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Minutes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Seconds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_Alarm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_OnOff)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_CloseWidget)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Watch.DigitalWatch digitalWatch1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pcb_OnOff;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip cms_Settings;
        private System.Windows.Forms.ToolStripMenuItem видToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsm_MostTopChange;
        private System.Windows.Forms.ToolStripMenuItem закрепитьВиджетToolStripMenuItem;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip cms_NotifyIcon;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsm_AddToAutoRun;
        private System.Windows.Forms.ToolStripMenuItem прозрачностьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsm_Opacity25;
        private System.Windows.Forms.ToolStripMenuItem tsm_Opacity50;
        private System.Windows.Forms.ToolStripMenuItem tsm_Opacity75;
        private System.Windows.Forms.ToolStripMenuItem tsm_Opacity100;
        private System.Windows.Forms.PictureBox pcb_Alarm;
        private System.Windows.Forms.NumericUpDown nud_Hours;
        private System.Windows.Forms.NumericUpDown nud_Minutes;
        private System.Windows.Forms.NumericUpDown nud_Seconds;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripMenuItem tsm_ChangeAlarmSound;
        private System.Windows.Forms.PictureBox pcb_CloseWidget;
        private System.Windows.Forms.ToolStripMenuItem tsm_HideOnMouseCursor;
        private System.Windows.Forms.ToolStripMenuItem tsm_ShowSeconds;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
    }
}

