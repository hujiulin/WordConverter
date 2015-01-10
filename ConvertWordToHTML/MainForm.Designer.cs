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
            this.StopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripMain.SuspendLayout();
            this.statusStripMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripMain
            // 
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenToolStripMenuItem,
            this.SaveToToolStripMenuItem,
            this.StopToolStripMenuItem});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Size = new System.Drawing.Size(784, 25);
            this.menuStripMain.TabIndex = 0;
            this.menuStripMain.Text = "menuStripMain";
            // 
            // OpenToolStripMenuItem
            // 
            this.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem";
            this.OpenToolStripMenuItem.Size = new System.Drawing.Size(52, 21);
            this.OpenToolStripMenuItem.Text = "Open";
            this.OpenToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItem_Click);
            // 
            // SaveToToolStripMenuItem
            // 
            this.SaveToToolStripMenuItem.Name = "SaveToToolStripMenuItem";
            this.SaveToToolStripMenuItem.Size = new System.Drawing.Size(62, 21);
            this.SaveToToolStripMenuItem.Text = "SaveTo";
            this.SaveToToolStripMenuItem.Click += new System.EventHandler(this.SaveToToolStripMenuItem_Click);
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
            this.toolStripStatusLabelTime.Size = new System.Drawing.Size(43, 17);
            this.toolStripStatusLabelTime.Text = "Time: ";
            // 
            // toolStripStatusLabelTimeValue
            // 
            this.toolStripStatusLabelTimeValue.Name = "toolStripStatusLabelTimeValue";
            this.toolStripStatusLabelTimeValue.Size = new System.Drawing.Size(15, 17);
            this.toolStripStatusLabelTimeValue.Text = "0";
            // 
            // toolStripStatusLabelFiles
            // 
            this.toolStripStatusLabelFiles.Name = "toolStripStatusLabelFiles";
            this.toolStripStatusLabelFiles.Size = new System.Drawing.Size(40, 17);
            this.toolStripStatusLabelFiles.Text = "Files: ";
            // 
            // toolStripStatusLabelFileNumber
            // 
            this.toolStripStatusLabelFileNumber.Name = "toolStripStatusLabelFileNumber";
            this.toolStripStatusLabelFileNumber.Size = new System.Drawing.Size(15, 17);
            this.toolStripStatusLabelFileNumber.Text = "0";
            // 
            // toolStripStatusLabelStatus
            // 
            this.toolStripStatusLabelStatus.Name = "toolStripStatusLabelStatus";
            this.toolStripStatusLabelStatus.Size = new System.Drawing.Size(50, 17);
            this.toolStripStatusLabelStatus.Text = "Status: ";
            // 
            // toolStripStatusLabelStatusValue
            // 
            this.toolStripStatusLabelStatusValue.Name = "toolStripStatusLabelStatusValue";
            this.toolStripStatusLabelStatusValue.Size = new System.Drawing.Size(86, 17);
            this.toolStripStatusLabelStatusValue.Text = "NoProcessed";
            // 
            // toolStripStatusLabelProcess
            // 
            this.toolStripStatusLabelProcess.Name = "toolStripStatusLabelProcess";
            this.toolStripStatusLabelProcess.Size = new System.Drawing.Size(80, 17);
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
            this.listView.Location = new System.Drawing.Point(0, 25);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(784, 515);
            this.listView.TabIndex = 2;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // StopToolStripMenuItem
            // 
            this.StopToolStripMenuItem.Name = "StopToolStripMenuItem";
            this.StopToolStripMenuItem.Size = new System.Drawing.Size(47, 21);
            this.StopToolStripMenuItem.Text = "Stop";
            this.StopToolStripMenuItem.Click += new System.EventHandler(this.StopToolStripMenuItem_Click);
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
            this.Text = "ConvertWordToHTML";
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
    }
}

