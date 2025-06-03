namespace Laboratory
{
    partial class frmSwichBoard
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
            this.components = new System.ComponentModel.Container();
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.مدیریتآزمایشToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.آزمایشToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ثبتآزمایشToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.رنجبندیآزمایشاتToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.گروهآزمایشاتToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.واحدآزمایشاتToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.بیمهToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.مدیریتبیمهToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.مدیریتفرانشیزToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.مدیریتکاربرانToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.مدیریتبیمارToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.مدیریتکارمندانToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ثبتآزمایشToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.نتایجآزمایشToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ثبتنتیجهToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ویرایشنتیجهToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.گزارشToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.گزارشجامعToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStrip = new System.Windows.Forms.ToolStrip();
            this.lblUserName = new System.Windows.Forms.ToolStripLabel();
            this.lblDateTime = new System.Windows.Forms.ToolStripLabel();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.MenuStrip.SuspendLayout();
            this.ToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuStrip
            // 
            this.MenuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(239)))), ((int)(((byte)(250)))));
            this.MenuStrip.Font = new System.Drawing.Font("B Titr", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.مدیریتآزمایشToolStripMenuItem,
            this.بیمهToolStripMenuItem,
            this.مدیریتکاربرانToolStripMenuItem,
            this.ثبتآزمایشToolStripMenuItem1,
            this.نتایجآزمایشToolStripMenuItem,
            this.گزارشToolStripMenuItem});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(1244, 34);
            this.MenuStrip.TabIndex = 1;
            this.MenuStrip.Text = "menuStrip1";
            // 
            // مدیریتآزمایشToolStripMenuItem
            // 
            this.مدیریتآزمایشToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.آزمایشToolStripMenuItem});
            this.مدیریتآزمایشToolStripMenuItem.Name = "مدیریتآزمایشToolStripMenuItem";
            this.مدیریتآزمایشToolStripMenuItem.Size = new System.Drawing.Size(68, 30);
            this.مدیریتآزمایشToolStripMenuItem.Text = "آزمایش";
            // 
            // آزمایشToolStripMenuItem
            // 
            this.آزمایشToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ثبتآزمایشToolStripMenuItem,
            this.رنجبندیآزمایشاتToolStripMenuItem,
            this.گروهآزمایشاتToolStripMenuItem,
            this.واحدآزمایشاتToolStripMenuItem});
            this.آزمایشToolStripMenuItem.Name = "آزمایشToolStripMenuItem";
            this.آزمایشToolStripMenuItem.Size = new System.Drawing.Size(183, 30);
            this.آزمایشToolStripMenuItem.Text = "مدیریت آزمایشات";
            this.آزمایشToolStripMenuItem.Click += new System.EventHandler(this.آزمایشToolStripMenuItem_Click);
            // 
            // ثبتآزمایشToolStripMenuItem
            // 
            this.ثبتآزمایشToolStripMenuItem.Name = "ثبتآزمایشToolStripMenuItem";
            this.ثبتآزمایشToolStripMenuItem.Size = new System.Drawing.Size(191, 30);
            this.ثبتآزمایشToolStripMenuItem.Text = "ثبت آزمایش";
            this.ثبتآزمایشToolStripMenuItem.Click += new System.EventHandler(this.ثبتآزمایشToolStripMenuItem_Click);
            // 
            // رنجبندیآزمایشاتToolStripMenuItem
            // 
            this.رنجبندیآزمایشاتToolStripMenuItem.Name = "رنجبندیآزمایشاتToolStripMenuItem";
            this.رنجبندیآزمایشاتToolStripMenuItem.Size = new System.Drawing.Size(191, 30);
            this.رنجبندیآزمایشاتToolStripMenuItem.Text = "رنج بندی آزمایشات";
            this.رنجبندیآزمایشاتToolStripMenuItem.Click += new System.EventHandler(this.رنجبندیآزمایشاتToolStripMenuItem_Click);
            // 
            // گروهآزمایشاتToolStripMenuItem
            // 
            this.گروهآزمایشاتToolStripMenuItem.Name = "گروهآزمایشاتToolStripMenuItem";
            this.گروهآزمایشاتToolStripMenuItem.Size = new System.Drawing.Size(191, 30);
            this.گروهآزمایشاتToolStripMenuItem.Text = "گروه آزمایشات";
            this.گروهآزمایشاتToolStripMenuItem.Click += new System.EventHandler(this.گروهآزمایشاتToolStripMenuItem_Click);
            // 
            // واحدآزمایشاتToolStripMenuItem
            // 
            this.واحدآزمایشاتToolStripMenuItem.Name = "واحدآزمایشاتToolStripMenuItem";
            this.واحدآزمایشاتToolStripMenuItem.Size = new System.Drawing.Size(191, 30);
            this.واحدآزمایشاتToolStripMenuItem.Text = "واحد آزمایشات";
            this.واحدآزمایشاتToolStripMenuItem.Click += new System.EventHandler(this.واحدآزمایشاتToolStripMenuItem_Click);
            // 
            // بیمهToolStripMenuItem
            // 
            this.بیمهToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.مدیریتبیمهToolStripMenuItem,
            this.مدیریتفرانشیزToolStripMenuItem});
            this.بیمهToolStripMenuItem.Name = "بیمهToolStripMenuItem";
            this.بیمهToolStripMenuItem.Size = new System.Drawing.Size(45, 30);
            this.بیمهToolStripMenuItem.Text = "بیمه";
            // 
            // مدیریتبیمهToolStripMenuItem
            // 
            this.مدیریتبیمهToolStripMenuItem.Name = "مدیریتبیمهToolStripMenuItem";
            this.مدیریتبیمهToolStripMenuItem.Size = new System.Drawing.Size(168, 30);
            this.مدیریتبیمهToolStripMenuItem.Text = "مدیریت بیمه";
            this.مدیریتبیمهToolStripMenuItem.Click += new System.EventHandler(this.مدیریتبیمهToolStripMenuItem_Click);
            // 
            // مدیریتفرانشیزToolStripMenuItem
            // 
            this.مدیریتفرانشیزToolStripMenuItem.Name = "مدیریتفرانشیزToolStripMenuItem";
            this.مدیریتفرانشیزToolStripMenuItem.Size = new System.Drawing.Size(168, 30);
            this.مدیریتفرانشیزToolStripMenuItem.Text = "مدیریت فرانشیز";
            this.مدیریتفرانشیزToolStripMenuItem.Click += new System.EventHandler(this.مدیریتفرانشیزToolStripMenuItem_Click);
            // 
            // مدیریتکاربرانToolStripMenuItem
            // 
            this.مدیریتکاربرانToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.مدیریتبیمارToolStripMenuItem,
            this.مدیریتکارمندانToolStripMenuItem});
            this.مدیریتکاربرانToolStripMenuItem.Name = "مدیریتکاربرانToolStripMenuItem";
            this.مدیریتکاربرانToolStripMenuItem.Size = new System.Drawing.Size(67, 30);
            this.مدیریتکاربرانToolStripMenuItem.Text = "کاربران";
            // 
            // مدیریتبیمارToolStripMenuItem
            // 
            this.مدیریتبیمارToolStripMenuItem.Name = "مدیریتبیمارToolStripMenuItem";
            this.مدیریتبیمارToolStripMenuItem.Size = new System.Drawing.Size(181, 30);
            this.مدیریتبیمارToolStripMenuItem.Text = "مدیریت بیماران";
            this.مدیریتبیمارToolStripMenuItem.Click += new System.EventHandler(this.مدیریتبیمارToolStripMenuItem_Click_1);
            // 
            // مدیریتکارمندانToolStripMenuItem
            // 
            this.مدیریتکارمندانToolStripMenuItem.Name = "مدیریتکارمندانToolStripMenuItem";
            this.مدیریتکارمندانToolStripMenuItem.Size = new System.Drawing.Size(181, 30);
            this.مدیریتکارمندانToolStripMenuItem.Text = "مدیریت کارمندان";
            this.مدیریتکارمندانToolStripMenuItem.Click += new System.EventHandler(this.مدیریتکارمندانToolStripMenuItem_Click);
            // 
            // ثبتآزمایشToolStripMenuItem1
            // 
            this.ثبتآزمایشToolStripMenuItem1.Name = "ثبتآزمایشToolStripMenuItem1";
            this.ثبتآزمایشToolStripMenuItem1.Size = new System.Drawing.Size(57, 30);
            this.ثبتآزمایشToolStripMenuItem1.Text = "ویزیت";
            this.ثبتآزمایشToolStripMenuItem1.Click += new System.EventHandler(this.ثبتآزمایشToolStripMenuItem1_Click);
            // 
            // نتایجآزمایشToolStripMenuItem
            // 
            this.نتایجآزمایشToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ثبتنتیجهToolStripMenuItem,
            this.ویرایشنتیجهToolStripMenuItem});
            this.نتایجآزمایشToolStripMenuItem.Name = "نتایجآزمایشToolStripMenuItem";
            this.نتایجآزمایشToolStripMenuItem.Size = new System.Drawing.Size(97, 30);
            this.نتایجآزمایشToolStripMenuItem.Text = "نتایج آزمایش";
            // 
            // ثبتنتیجهToolStripMenuItem
            // 
            this.ثبتنتیجهToolStripMenuItem.Name = "ثبتنتیجهToolStripMenuItem";
            this.ثبتنتیجهToolStripMenuItem.Size = new System.Drawing.Size(154, 30);
            this.ثبتنتیجهToolStripMenuItem.Text = "ثبت نتیجه";
            this.ثبتنتیجهToolStripMenuItem.Click += new System.EventHandler(this.ثبتنتیجهToolStripMenuItem_Click);
            // 
            // ویرایشنتیجهToolStripMenuItem
            // 
            this.ویرایشنتیجهToolStripMenuItem.Name = "ویرایشنتیجهToolStripMenuItem";
            this.ویرایشنتیجهToolStripMenuItem.Size = new System.Drawing.Size(154, 30);
            this.ویرایشنتیجهToolStripMenuItem.Text = "ویرایش نتیجه";
            this.ویرایشنتیجهToolStripMenuItem.Click += new System.EventHandler(this.ویرایشنتیجهToolStripMenuItem_Click);
            // 
            // گزارشToolStripMenuItem
            // 
            this.گزارشToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.گزارشجامعToolStripMenuItem});
            this.گزارشToolStripMenuItem.Name = "گزارشToolStripMenuItem";
            this.گزارشToolStripMenuItem.Size = new System.Drawing.Size(63, 30);
            this.گزارشToolStripMenuItem.Text = "گزارش";
            // 
            // گزارشجامعToolStripMenuItem
            // 
            this.گزارشجامعToolStripMenuItem.Name = "گزارشجامعToolStripMenuItem";
            this.گزارشجامعToolStripMenuItem.Size = new System.Drawing.Size(155, 30);
            this.گزارشجامعToolStripMenuItem.Text = "گزارش جامع";
            this.گزارشجامعToolStripMenuItem.Click += new System.EventHandler(this.گزارشجامعToolStripMenuItem_Click);
            // 
            // ToolStrip
            // 
            this.ToolStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(203)))), ((int)(((byte)(210)))));
            this.ToolStrip.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblUserName,
            this.lblDateTime});
            this.ToolStrip.Location = new System.Drawing.Point(0, 700);
            this.ToolStrip.Name = "ToolStrip";
            this.ToolStrip.Size = new System.Drawing.Size(1244, 25);
            this.ToolStrip.TabIndex = 2;
            this.ToolStrip.Text = "toolStrip1";
            // 
            // lblUserName
            // 
            this.lblUserName.Font = new System.Drawing.Font("B Titr", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblUserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(132)))), ((int)(((byte)(219)))));
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.RightToLeftAutoMirrorImage = true;
            this.lblUserName.Size = new System.Drawing.Size(102, 22);
            this.lblUserName.Text = "lblUserName";
            // 
            // lblDateTime
            // 
            this.lblDateTime.Font = new System.Drawing.Font("B Titr", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(79, 22);
            this.lblDateTime.Text = "DateTime";
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // frmSwichBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1244, 725);
            this.Controls.Add(this.ToolStrip);
            this.Controls.Add(this.MenuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.MenuStrip;
            this.Name = "frmSwichBoard";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "مدیریت پنل";
            this.Load += new System.EventHandler(this.frmSwichBoard_Load);
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.ToolStrip.ResumeLayout(false);
            this.ToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.ToolStrip ToolStrip;
        private System.Windows.Forms.ToolStripLabel lblUserName;
        private System.Windows.Forms.ToolStripLabel lblDateTime;
        private System.Windows.Forms.ToolStripMenuItem مدیریتآزمایشToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem آزمایشToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ثبتآزمایشToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem رنجبندیآزمایشاتToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem گروهآزمایشاتToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem واحدآزمایشاتToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem بیمهToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem مدیریتبیمهToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem مدیریتفرانشیزToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem مدیریتکاربرانToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem مدیریتبیمارToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem مدیریتکارمندانToolStripMenuItem;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.ToolStripMenuItem ثبتآزمایشToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem نتایجآزمایشToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ثبتنتیجهToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ویرایشنتیجهToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem گزارشToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem گزارشجامعToolStripMenuItem;
    }
}