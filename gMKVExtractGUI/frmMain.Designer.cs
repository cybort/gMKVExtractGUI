﻿namespace gMKVToolnix
{
    partial class frmMain
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
            this.btnTest = new System.Windows.Forms.Button();
            this.txtInputFile = new gMKVToolnix.gTextBox();
            this.btnBrowseInputFile = new System.Windows.Forms.Button();
            this.grpInputFile = new System.Windows.Forms.GroupBox();
            this.grpOutputDirectory = new System.Windows.Forms.GroupBox();
            this.btnBrowseOutputDirectory = new System.Windows.Forms.Button();
            this.txtOutputDirectory = new gMKVToolnix.gTextBox();
            this.grpInputFileInfo = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.chkLstInputFileTracks = new gMKVToolnix.gCheckedListBox();
            this.txtSegmentInfo = new gMKVToolnix.gTextBox();
            this.grpActions = new System.Windows.Forms.GroupBox();
            this.btnExtractTracks = new System.Windows.Forms.Button();
            this.grpConfig = new System.Windows.Forms.GroupBox();
            this.btnBrowseMKVToolnixPath = new System.Windows.Forms.Button();
            this.txtMKVToolnixPath = new gMKVToolnix.gTextBox();
            this.grpLog = new System.Windows.Forms.GroupBox();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.prgBrStatus = new System.Windows.Forms.ToolStripProgressBar();
            this.grpInputFile.SuspendLayout();
            this.grpOutputDirectory.SuspendLayout();
            this.grpInputFileInfo.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.grpActions.SuspendLayout();
            this.grpConfig.SuspendLayout();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.tlpMain.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTest
            // 
            this.btnTest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTest.Location = new System.Drawing.Point(505, 18);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(80, 30);
            this.btnTest.TabIndex = 0;
            this.btnTest.Text = "Test";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtInputFile
            // 
            this.txtInputFile.AllowDrop = true;
            this.txtInputFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtInputFile.Location = new System.Drawing.Point(6, 22);
            this.txtInputFile.Name = "txtInputFile";
            this.txtInputFile.ReadOnly = true;
            this.txtInputFile.Size = new System.Drawing.Size(493, 23);
            this.txtInputFile.TabIndex = 1;
            this.txtInputFile.TextChanged += new System.EventHandler(this.txtInputFile_TextChanged);
            this.txtInputFile.DragDrop += new System.Windows.Forms.DragEventHandler(this.txt_DragDrop);
            this.txtInputFile.DragEnter += new System.Windows.Forms.DragEventHandler(this.txt_DragEnter);
            // 
            // btnBrowseInputFile
            // 
            this.btnBrowseInputFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowseInputFile.Location = new System.Drawing.Point(505, 17);
            this.btnBrowseInputFile.Name = "btnBrowseInputFile";
            this.btnBrowseInputFile.Size = new System.Drawing.Size(80, 30);
            this.btnBrowseInputFile.TabIndex = 2;
            this.btnBrowseInputFile.Text = "Browse...";
            this.btnBrowseInputFile.UseVisualStyleBackColor = true;
            this.btnBrowseInputFile.Click += new System.EventHandler(this.btnBrowseInputFile_Click);
            // 
            // grpInputFile
            // 
            this.grpInputFile.Controls.Add(this.txtInputFile);
            this.grpInputFile.Controls.Add(this.btnBrowseInputFile);
            this.grpInputFile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpInputFile.Location = new System.Drawing.Point(3, 3);
            this.grpInputFile.Name = "grpInputFile";
            this.grpInputFile.Size = new System.Drawing.Size(592, 54);
            this.grpInputFile.TabIndex = 3;
            this.grpInputFile.TabStop = false;
            this.grpInputFile.Text = "Input file (you can drag and drop the file)";
            // 
            // grpOutputDirectory
            // 
            this.grpOutputDirectory.Controls.Add(this.btnBrowseOutputDirectory);
            this.grpOutputDirectory.Controls.Add(this.txtOutputDirectory);
            this.grpOutputDirectory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpOutputDirectory.Location = new System.Drawing.Point(3, 63);
            this.grpOutputDirectory.Name = "grpOutputDirectory";
            this.grpOutputDirectory.Size = new System.Drawing.Size(592, 54);
            this.grpOutputDirectory.TabIndex = 4;
            this.grpOutputDirectory.TabStop = false;
            this.grpOutputDirectory.Text = "Output Directory";
            // 
            // btnBrowseOutputDirectory
            // 
            this.btnBrowseOutputDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowseOutputDirectory.Location = new System.Drawing.Point(505, 18);
            this.btnBrowseOutputDirectory.Name = "btnBrowseOutputDirectory";
            this.btnBrowseOutputDirectory.Size = new System.Drawing.Size(80, 30);
            this.btnBrowseOutputDirectory.TabIndex = 3;
            this.btnBrowseOutputDirectory.Text = "Browse...";
            this.btnBrowseOutputDirectory.UseVisualStyleBackColor = true;
            this.btnBrowseOutputDirectory.Click += new System.EventHandler(this.btnBrowseOutputDirectory_Click);
            // 
            // txtOutputDirectory
            // 
            this.txtOutputDirectory.AllowDrop = true;
            this.txtOutputDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOutputDirectory.Location = new System.Drawing.Point(6, 22);
            this.txtOutputDirectory.Name = "txtOutputDirectory";
            this.txtOutputDirectory.Size = new System.Drawing.Size(493, 23);
            this.txtOutputDirectory.TabIndex = 2;
            this.txtOutputDirectory.DragDrop += new System.Windows.Forms.DragEventHandler(this.txt_DragDrop);
            this.txtOutputDirectory.DragEnter += new System.Windows.Forms.DragEventHandler(this.txt_DragEnter);
            // 
            // grpInputFileInfo
            // 
            this.grpInputFileInfo.Controls.Add(this.tableLayoutPanel1);
            this.grpInputFileInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpInputFileInfo.Location = new System.Drawing.Point(3, 183);
            this.grpInputFileInfo.Name = "grpInputFileInfo";
            this.grpInputFileInfo.Size = new System.Drawing.Size(592, 285);
            this.grpInputFileInfo.TabIndex = 5;
            this.grpInputFileInfo.TabStop = false;
            this.grpInputFileInfo.Text = "Input File Information";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.chkLstInputFileTracks, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtSegmentInfo, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 19);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(586, 263);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // chkLstInputFileTracks
            // 
            this.chkLstInputFileTracks.CheckOnClick = true;
            this.chkLstInputFileTracks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkLstInputFileTracks.FormattingEnabled = true;
            this.chkLstInputFileTracks.Location = new System.Drawing.Point(3, 83);
            this.chkLstInputFileTracks.Name = "chkLstInputFileTracks";
            this.chkLstInputFileTracks.Size = new System.Drawing.Size(580, 177);
            this.chkLstInputFileTracks.TabIndex = 0;
            // 
            // txtSegmentInfo
            // 
            this.txtSegmentInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSegmentInfo.Location = new System.Drawing.Point(3, 3);
            this.txtSegmentInfo.Multiline = true;
            this.txtSegmentInfo.Name = "txtSegmentInfo";
            this.txtSegmentInfo.ReadOnly = true;
            this.txtSegmentInfo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtSegmentInfo.Size = new System.Drawing.Size(580, 74);
            this.txtSegmentInfo.TabIndex = 1;
            // 
            // grpActions
            // 
            this.grpActions.Controls.Add(this.btnExtractTracks);
            this.grpActions.Controls.Add(this.btnTest);
            this.grpActions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpActions.Location = new System.Drawing.Point(3, 474);
            this.grpActions.Name = "grpActions";
            this.grpActions.Size = new System.Drawing.Size(592, 54);
            this.grpActions.TabIndex = 6;
            this.grpActions.TabStop = false;
            this.grpActions.Text = "Actions";
            // 
            // btnExtractTracks
            // 
            this.btnExtractTracks.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExtractTracks.Location = new System.Drawing.Point(409, 18);
            this.btnExtractTracks.Name = "btnExtractTracks";
            this.btnExtractTracks.Size = new System.Drawing.Size(90, 30);
            this.btnExtractTracks.TabIndex = 1;
            this.btnExtractTracks.Text = "Extract Tracks";
            this.btnExtractTracks.UseVisualStyleBackColor = true;
            this.btnExtractTracks.Click += new System.EventHandler(this.btnExtractTracks_Click);
            // 
            // grpConfig
            // 
            this.grpConfig.Controls.Add(this.btnBrowseMKVToolnixPath);
            this.grpConfig.Controls.Add(this.txtMKVToolnixPath);
            this.grpConfig.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpConfig.Location = new System.Drawing.Point(3, 123);
            this.grpConfig.Name = "grpConfig";
            this.grpConfig.Size = new System.Drawing.Size(592, 54);
            this.grpConfig.TabIndex = 7;
            this.grpConfig.TabStop = false;
            this.grpConfig.Text = "MKVToolnix Directory (you can drag and drop the directory)";
            // 
            // btnBrowseMKVToolnixPath
            // 
            this.btnBrowseMKVToolnixPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowseMKVToolnixPath.Location = new System.Drawing.Point(505, 18);
            this.btnBrowseMKVToolnixPath.Name = "btnBrowseMKVToolnixPath";
            this.btnBrowseMKVToolnixPath.Size = new System.Drawing.Size(80, 30);
            this.btnBrowseMKVToolnixPath.TabIndex = 5;
            this.btnBrowseMKVToolnixPath.Text = "Browse...";
            this.btnBrowseMKVToolnixPath.UseVisualStyleBackColor = true;
            this.btnBrowseMKVToolnixPath.Click += new System.EventHandler(this.btnBrowseMKVToolnixPath_Click);
            // 
            // txtMKVToolnixPath
            // 
            this.txtMKVToolnixPath.AllowDrop = true;
            this.txtMKVToolnixPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMKVToolnixPath.Location = new System.Drawing.Point(6, 22);
            this.txtMKVToolnixPath.Name = "txtMKVToolnixPath";
            this.txtMKVToolnixPath.ReadOnly = true;
            this.txtMKVToolnixPath.Size = new System.Drawing.Size(493, 23);
            this.txtMKVToolnixPath.TabIndex = 3;
            this.txtMKVToolnixPath.DragDrop += new System.Windows.Forms.DragEventHandler(this.txt_DragDrop);
            this.txtMKVToolnixPath.DragEnter += new System.Windows.Forms.DragEventHandler(this.txt_DragEnter);
            // 
            // grpLog
            // 
            this.grpLog.Location = new System.Drawing.Point(14, 606);
            this.grpLog.Name = "grpLog";
            this.grpLog.Size = new System.Drawing.Size(755, 106);
            this.grpLog.TabIndex = 8;
            this.grpLog.TabStop = false;
            this.grpLog.Text = "Log";
            // 
            // toolStripContainer1
            // 
            this.toolStripContainer1.BottomToolStripPanelVisible = false;
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.tlpMain);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.statusStrip1);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(598, 553);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.LeftToolStripPanelVisible = false;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.RightToolStripPanelVisible = false;
            this.toolStripContainer1.Size = new System.Drawing.Size(598, 553);
            this.toolStripContainer1.TabIndex = 9;
            this.toolStripContainer1.Text = "toolStripContainer1";
            this.toolStripContainer1.TopToolStripPanelVisible = false;
            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 1;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.Controls.Add(this.grpInputFile, 0, 0);
            this.tlpMain.Controls.Add(this.grpOutputDirectory, 0, 1);
            this.tlpMain.Controls.Add(this.grpActions, 0, 4);
            this.tlpMain.Controls.Add(this.grpConfig, 0, 2);
            this.tlpMain.Controls.Add(this.grpInputFileInfo, 0, 3);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 5;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tlpMain.Size = new System.Drawing.Size(598, 531);
            this.tlpMain.TabIndex = 1;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus,
            this.prgBrStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 531);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(598, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 17);
            // 
            // prgBrStatus
            // 
            this.prgBrStatus.Name = "prgBrStatus";
            this.prgBrStatus.Size = new System.Drawing.Size(300, 16);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 553);
            this.Controls.Add(this.toolStripContainer1);
            this.Controls.Add(this.grpLog);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.Name = "frmMain";
            this.Text = "gMKVExtractGUI";
            this.grpInputFile.ResumeLayout(false);
            this.grpInputFile.PerformLayout();
            this.grpOutputDirectory.ResumeLayout(false);
            this.grpOutputDirectory.PerformLayout();
            this.grpInputFileInfo.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.grpActions.ResumeLayout(false);
            this.grpConfig.ResumeLayout(false);
            this.grpConfig.PerformLayout();
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.ContentPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.tlpMain.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTest;
        private gTextBox txtInputFile;
        private System.Windows.Forms.Button btnBrowseInputFile;
        private System.Windows.Forms.GroupBox grpInputFile;
        private System.Windows.Forms.GroupBox grpOutputDirectory;
        private System.Windows.Forms.Button btnBrowseOutputDirectory;
        private gTextBox txtOutputDirectory;
        private System.Windows.Forms.GroupBox grpInputFileInfo;
        private gCheckedListBox chkLstInputFileTracks;
        private System.Windows.Forms.GroupBox grpActions;
        private System.Windows.Forms.Button btnExtractTracks;
        private System.Windows.Forms.GroupBox grpConfig;
        private System.Windows.Forms.Button btnBrowseMKVToolnixPath;
        private gTextBox txtMKVToolnixPath;
        private System.Windows.Forms.GroupBox grpLog;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.ToolStripProgressBar prgBrStatus;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private gTextBox txtSegmentInfo;
    }
}
