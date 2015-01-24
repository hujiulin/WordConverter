namespace ConvertWordToHTML
{
    partial class MainForm
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
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.OpenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveToToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStripMain = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelTimeValue = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelFiles = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelFileNumber = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelStatusValue = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelProcess = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.listView = new System.Windows.Forms.ListView();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.ExtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HTMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PDFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripMain.SuspendLayout();
            this.statusStripMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripMain
            // 
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenToolStripMenuItem,
            this.ExtToolStripMenuItem,
            this.SaveToToolStripMenuItem,
            this.StopToolStripMenuItem});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Size = new System.Drawing.Size(784, 24);
            this.menuStripMain.TabIndex = 0;
            this.menuStripMain.Text = "menuStripMain";
            // 
            // OpenToolStripMenuItem
            // 
            this.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem";
            this.OpenToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.OpenToolStripMenuItem.Text = "Open";
            this.OpenToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItem_Click);
            // 
            // SaveToToolStripMenuItem
            // 
            this.SaveToToolStripMenuItem.Name = "SaveToToolStripMenuItem";
            this.SaveToToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.SaveToToolStripMenuItem.Text = "SaveTo";
            this.SaveToToolStripMenuItem.Click += new System.EventHandler(this.SaveToToolStripMenuItem_Click);
            // 
            // StopToolStripMenuItem
            // 
            this.StopToolStripMenuItem.Name = "StopToolStripMenuItem";
            this.StopToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.StopToolStripMenuItem.Text = "Stop";
            this.StopToolStripMenuItem.Click += new System.EventHandler(this.StopToolStripMenuItem_Click);
            // 
            // statusStripMain
            // 
            this.statusStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelTime,
            this.toolStripStatusLabelTimeValue,
            this.toolStripStatusLabelFiles,
            this.toolStripStatusLabelFileNumber,
            this.toolStripStatusLabelStatus,
            this.toolStripStatusLabelStatusValue,
            this.toolStripStatusLabelProcess,
            this.toolStripProgressBar});
            this.statusStripMain.Location = new System.Drawing.Point(0, 540);
            this.statusStripMain.Name = "statusStripMain";
            this.statusStripMain.Size = new System.Drawing.Size(784, 22);
            this.statusStripMain.TabIndex = 1;
            this.statusStripMain.Text = "statusStripMain";
            // 
            // toolStripStatusLabelTime
            // 
            this.toolStripStatusLabelTime.Name = "toolStripStatusLabelTime";
            this.toolStripStatusLabelTime.Size = new System.Drawing.Size(41, 17);
            this.toolStripStatusLabelTime.Text = "Time: ";
            // 
            // toolStripStatusLabelTimeValue
            // 
            this.toolStripStatusLabelTimeValue.Name = "toolStripStatusLabelTimeValue";
            this.toolStripStatusLabelTimeValue.Size = new System.Drawing.Size(11, 17);
            this.toolStripStatusLabelTimeValue.Text = "0";
            // 
            // toolStripStatusLabelFiles
            // 
            this.toolStripStatusLabelFiles.Name = "toolStripStatusLabelFiles";
            this.toolStripStatusLabelFiles.Size = new System.Drawing.Size(47, 17);
            this.toolStripStatusLabelFiles.Text = "Files: ";
            // 
            // toolStripStatusLabelFileNumber
            // 
            this.toolStripStatusLabelFileNumber.Name = "toolStripStatusLabelFileNumber";
            this.toolStripStatusLabelFileNumber.Size = new System.Drawing.Size(11, 17);
            this.toolStripStatusLabelFileNumber.Text = "0";
            // 
            // toolStripStatusLabelStatus
            // 
            this.toolStripStatusLabelStatus.Name = "toolStripStatusLabelStatus";
            this.toolStripStatusLabelStatus.Size = new System.Drawing.Size(53, 17);
            this.toolStripStatusLabelStatus.Text = "Status: ";
            // 
            // toolStripStatusLabelStatusValue
            // 
            this.toolStripStatusLabelStatusValue.Name = "toolStripStatusLabelStatusValue";
            this.toolStripStatusLabelStatusValue.Size = new System.Drawing.Size(71, 17);
            this.toolStripStatusLabelStatusValue.Text = "NoProcessed";
            // 
            // toolStripStatusLabelProcess
            // 
            this.toolStripStatusLabelProcess.Name = "toolStripStatusLabelProcess";
            this.toolStripStatusLabelProcess.Size = new System.Drawing.Size(77, 17);
            this.toolStripStatusLabelProcess.Text = "ProcessBar: ";
            // 
            // toolStripProgressBar
            // 
            this.toolStripProgressBar.Name = "toolStripProgressBar";
            this.toolStripProgressBar.Size = new System.Drawing.Size(100, 16);
            // 
            // listView
            // 
            this.listView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView.Location = new System.Drawing.Point(0, 24);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(784, 516);
            this.listView.TabIndex = 2;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // ExtToolStripMenuItem
            // 
            this.ExtToolStripMenuItem.Checked = true;
            this.ExtToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ExtToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ExtToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.HTMLToolStripMenuItem,
            this.PDFToolStripMenuItem});
            this.ExtToolStripMenuItem.Name = "ExtToolStripMenuItem";
            this.ExtToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.ExtToolStripMenuItem.Text = "Ext";
            // 
            // HTMLToolStripMenuItem
            // 
            this.HTMLToolStripMenuItem.Checked = true;
            this.HTMLToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.HTMLToolStripMenuItem.Name = "HTMLToolStripMenuItem";
            this.HTMLToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.HTMLToolStripMenuItem.Text = "HTML";
            this.HTMLToolStripMenuItem.Click += new System.EventHandler(this.HTMLToolStripMenuItem_Click);
            // 
            // PDFToolStripMenuItem
            // 
            this.PDFToolStripMenuItem.Name = "PDFToolStripMenuItem";
            this.PDFToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.PDFToolStripMenuItem.Text = "PDF";
            this.PDFToolStripMenuItem.Click += new System.EventHandler(this.PDFToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.statusStripMain);
            this.Controls.Add(this.menuStripMain);
            this.MainMenuStrip = this.menuStripMain;
            this.Name = "MainForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WordConverter";
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.statusStripMain.ResumeLayout(false);
            this.statusStripMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem OpenToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStripMain;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelFiles;
        public System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelFileNumber;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelStatus;
        private System.Windows.Forms.ToolStripMenuItem SaveToToolStripMenuItem;
        private System.Windows.Forms.ListView listView;
        public System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelStatusValue;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelProcess;
        public System.Windows.Forms.ToolStripProgressBar toolStripProgressBar;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelTime;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelTimeValue;
        public System.Windows.Forms.Timer timer;
        private System.Windows.Forms.ToolStripMenuItem StopToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExtToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem HTMLToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem PDFToolStripMenuItem;
    }
}

