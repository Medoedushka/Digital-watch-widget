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
            this.digitalWatch1 = new Watch.DigitalWatch();
            this.label2 = new System.Windows.Forms.Label();
            this.pcb_OnOff = new System.Windows.Forms.PictureBox();
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
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.cms_NotifyIcon = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_OnOff)).BeginInit();
            this.cms_Settings.SuspendLayout();
            this.cms_NotifyIcon.SuspendLayout();
            this.SuspendLayout();
            // 
            // digitalWatch1
            // 
            this.digitalWatch1.Alarm = false;
            this.digitalWatch1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.digitalWatch1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.digitalWatch1.DisplayColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.digitalWatch1.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.digitalWatch1.Location = new System.Drawing.Point(2, 9);
            this.digitalWatch1.Margin = new System.Windows.Forms.Padding(4);
            this.digitalWatch1.Name = "digitalWatch1";
            this.digitalWatch1.OffColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(207)))), ((int)(((byte)(207)))), ((int)(((byte)(207)))));
            this.digitalWatch1.OnColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(187)))), ((int)(((byte)(199)))));
            this.digitalWatch1.Size = new System.Drawing.Size(225, 80);
            this.digitalWatch1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(122, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Created by Medoed";
            // 
            // pcb_OnOff
            // 
            this.pcb_OnOff.Image = global::WatchTester.Properties.Resources.unpressedButton;
            this.pcb_OnOff.Location = new System.Drawing.Point(12, 92);
            this.pcb_OnOff.Name = "pcb_OnOff";
            this.pcb_OnOff.Size = new System.Drawing.Size(25, 25);
            this.pcb_OnOff.TabIndex = 4;
            this.pcb_OnOff.TabStop = false;
            this.pcb_OnOff.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pcb_OnOff.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "ON/OFF";
            // 
            // cms_Settings
            // 
            this.cms_Settings.Font = new System.Drawing.Font("Century", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cms_Settings.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.видToolStripMenuItem,
            this.закрепитьВиджетToolStripMenuItem,
            this.tsm_AddToAutoRun});
            this.cms_Settings.Name = "cms_Settings";
            this.cms_Settings.Size = new System.Drawing.Size(248, 70);
            // 
            // видToolStripMenuItem
            // 
            this.видToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.видToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsm_MostTopChange,
            this.прозрачностьToolStripMenuItem});
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
            this.tsm_MostTopChange.Size = new System.Drawing.Size(180, 22);
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
            this.прозрачностьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
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
            this.выходToolStripMenuItem});
            this.cms_NotifyIcon.Name = "cms_NotifyIcon";
            this.cms_NotifyIcon.Size = new System.Drawing.Size(109, 26);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // WatchTester
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(231, 137);
            this.ContextMenuStrip = this.cms_Settings;
            this.Controls.Add(this.label1);
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
            ((System.ComponentModel.ISupportInitialize)(this.pcb_OnOff)).EndInit();
            this.cms_Settings.ResumeLayout(false);
            this.cms_NotifyIcon.ResumeLayout(false);
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
    }
}

