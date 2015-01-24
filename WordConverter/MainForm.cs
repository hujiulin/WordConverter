/*
 * Author: Jiulin Hu
 * Mail: tohujiulin@126.com
 * Description: Convert word to specified ext file
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace ConvertWordToHTML
{
    public partial class MainForm : Form
    {
        #region Paramters
        /// <summary>
        /// Input folder
        /// </summary>
        private static string _inputFolder = string.Empty;

        /// <summary>
        /// Output folder
        /// </summary>
        private static string _outputFolder = string.Empty;

        /// <summary>
        /// Target file ext
        /// </summary>
        private WordOperation.enumEXT _targetExt = WordOperation.enumEXT.html;

        /// <summary>
        /// Word operation instance
        /// </summary>
        private static WordOperation _wordOperation = null;

        /// <summary>
        /// Html files
        /// </summary>
        private static List<string> _htmlFiles = null;

        /// <summary>
        /// Process time
        /// </summary>
        private double _processTime = 0;

        /// <summary>
        /// Process thread
        /// </summary>
        System.Threading.Thread _processThread = null;

        /// <summary>
        /// Each file status enum
        /// </summary>
        private enum Status { NoProcessed, Processing, Finished, Error, Exist, Stop };
        #endregion

        #region Constructor
        /// <summary>
        /// Constructor function
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            
            // Initial list view
            InitialListView();

            // Set label value
            SetLabelValue(toolStripStatusLabelStatusValue, Status.NoProcessed.ToString());
        }
        #endregion

        #region ListView
        /// <summary>
        /// Initial MainForm ListView
        /// </summary>
        private void InitialListView()
        {
            // Initial column headers
            this.listView.Columns.Add("ID", 100, HorizontalAlignment.Left);
            this.listView.Columns.Add("Status", 100, HorizontalAlignment.Left);
            this.listView.Columns.Add("Word Path", 300, HorizontalAlignment.Left);
            this.listView.Columns.Add("HTML Path", 300, HorizontalAlignment.Left);
        }
        
        /// <summary>
        /// Fill ListView
        /// </summary>
        private void FillListViewWordPath()
        {
            string[] exts = { ".doc", ".docx" };
            _htmlFiles = GetAllFilesInFoldersWithExtension(_inputFolder, exts);
            for (int id = 0; id < _htmlFiles.Count; id++ )
            {
                ListViewItem listViewItem = new ListViewItem((id).ToString());
                listViewItem.SubItems.Add(Status.NoProcessed.ToString());
                listViewItem.SubItems.Add(_htmlFiles[id]);
                listViewItem.SubItems.Add(string.Empty);
                this.listView.Items.Add(listViewItem);
            }
            SetLabelValue(toolStripStatusLabelFileNumber, _htmlFiles.Count.ToString());
        }

        /// <summary>
        /// Get all files with specified extensions in folder and sub folder
        /// </summary>
        /// <param name="ext"></param>
        /// <returns></returns>
        private List<string> GetAllFilesInFoldersWithExtension(string folderName, string[] exts)
        {
            List<string> filesList = GetAllFilesInFolder(folderName);
            for (int i = filesList.Count - 1; i >= 0; i--)
            {
                string file = filesList[i];
                if (!ValidateFileExts(file, exts))
                {
                    filesList.Remove(file);
                }
            }
            return filesList;
        }

        /// <summary>
        /// Vaildate file's ext
        /// </summary>
        /// <param name="filename"></param>
        /// <param name="exts"></param>
        /// <returns></returns>
        private bool ValidateFileExts(string filename, string[] exts)
        {
            foreach (var ext in exts)
            {
                if (Path.GetExtension(filename).Equals(ext, StringComparison.OrdinalIgnoreCase))
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Get all files in input folder
        /// </summary>
        /// <returns></returns>
        private List<string> GetAllFilesInFolder(string folderName)
        {
            List<string> filesList = new List<string>();
            DirectoryInfo dirInfo = new DirectoryInfo(folderName);
            Queue<DirectoryInfo> dirsQueue = new Queue<DirectoryInfo>();
            dirsQueue.Enqueue(dirInfo);
            while (0 != dirsQueue.Count)
            {
                DirectoryInfo dirInfoTmp = dirsQueue.Dequeue();
                foreach (FileInfo fileInfoObj in dirInfoTmp.GetFiles())
                {
                    if ((FileAttributes.Hidden & fileInfoObj.Attributes) != FileAttributes.Hidden)
                    {
                        filesList.Add(fileInfoObj.FullName);
                    }
                }
                foreach (DirectoryInfo dirInfoObj in dirInfoTmp.GetDirectories())
                {
                    dirsQueue.Enqueue(dirInfoObj);
                }
            }
            return filesList;
        }
        #endregion

        #region UI operator
        /// <summary>
        /// Set static label value
        /// </summary>
        /// <param name="label"></param>
        /// <param name="value"></param>
        private void SetLabelValue(ToolStripStatusLabel label, string value)
        {
            label.Text = value;
        }

        /// <summary>
        /// Select input folder by FolderBrowserDialog
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowerDialog = new FolderBrowserDialog();
            if (DialogResult.OK == folderBrowerDialog.ShowDialog())
            {
                _inputFolder = folderBrowerDialog.SelectedPath;
                if (!Directory.Exists(_inputFolder))
                {
                    MessageBox.Show("Error: " + _inputFolder + "doesnot exist.");
                }
                else
                {
                    FillListViewWordPath();
                }
            }
        }

        private void SetMenuState(ToolStripMenuItem selectMenuItem)
        {
            this.HTMLToolStripMenuItem.Checked = false;
            this.PDFToolStripMenuItem.Checked = false;

            selectMenuItem.Checked = true;
        }

        /// <summary>
        /// Select HTML ext
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HTMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _targetExt = WordOperation.enumEXT.html;
            SetMenuState(this.HTMLToolStripMenuItem);
        }

        /// <summary>
        /// Select PDF ext
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PDFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _targetExt = WordOperation.enumEXT.pdf;
            SetMenuState(this.PDFToolStripMenuItem);
        }

        /// <summary>
        /// Select output folder by FolderBrowserDialog
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveToToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (null != _htmlFiles && _htmlFiles.Count > 0)
            {
                FolderBrowserDialog folderBrowerDialog = new FolderBrowserDialog();
                if (DialogResult.OK == folderBrowerDialog.ShowDialog())
                {
                    _outputFolder = folderBrowerDialog.SelectedPath;
                    if (!Directory.Exists(_inputFolder))
                    {
                        Directory.CreateDirectory(_inputFolder);
                    }
                    SetLabelValue(toolStripStatusLabelStatusValue, Status.Processing.ToString());
                    _processThread = new System.Threading.Thread(new System.Threading.ThreadStart(this.WordToFile));
                    timer.Start();
                    _processThread.Start();
                }
            }
            else
            {
                MessageBox.Show("Please Open input folder containing HTML files.");
            }
        }

        /// <summary>
        /// Stop progress
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _processThread.Abort();
            if (null != _wordOperation)
            {
                _wordOperation.ReleaseDoc();
                _wordOperation.Release();
                _wordOperation = null;
            }
            SetLabelValue(toolStripStatusLabelStatusValue, Status.Stop.ToString());
        }

        /// <summary>
        /// Update process time
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer_Tick(object sender, EventArgs e)
        {
            _processTime += timer.Interval / 1000.0;
            SetLabelValue(this.toolStripStatusLabelTimeValue, string.Format("{0:0.00} s", _processTime));
        }
        #endregion

        #region Word to specified ext file
        /// <summary>
        /// Convert HTML to file
        /// </summary>
        private void WordToFile()
        {
            if (null != _htmlFiles && _htmlFiles.Count > 0)
            {
                int id = 0;
                this.toolStripProgressBar.Maximum = _htmlFiles.Count;
                foreach (var file in _htmlFiles)
                {
                    this.listView.Items[id].SubItems[1].Text = Status.Processing.ToString();
                    try
                    {
                        string filename = Path.GetFileNameWithoutExtension(file);
                        // Generate output filename
                        string outputFilename = Path.Combine(_outputFolder, filename + "." + _targetExt.ToString());
                        if (!File.Exists(outputFilename))
                        {
                            // Initialize word
                            _wordOperation = new WordOperation(file);
                            // Generate HTML
                            _wordOperation.WordToFile(outputFilename, _targetExt);
                            // Close word
                            _wordOperation.ReleaseDoc();
                            this.listView.Items[id].SubItems[1].Text = Status.Finished.ToString();
                        }
                        else
                        {
                            this.listView.Items[id].SubItems[1].Text = Status.Exist.ToString();
                        }
                        this.listView.Items[id].SubItems[3].Text = outputFilename;
                    }
                    catch (Exception ex)
                    {
                        //TODO exception
                        if (null != _wordOperation)
                        {
                            _wordOperation.Release();
                        }
                        this.listView.Items[id].SubItems[1].Text = Status.Error.ToString();
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        id++;
                        this.toolStripProgressBar.Value++;
                    }
                }
            }
            else 
            {
                MessageBox.Show("Please Open input folder containing HTML files.");
            }

            if (null != _wordOperation)
            {
                _wordOperation.Release();
            }
            GC.Collect();
            GC.WaitForPendingFinalizers();
            timer.Stop();
        }
        #endregion

    }
}
