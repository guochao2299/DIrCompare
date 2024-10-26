namespace DirCompare
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            toolStripContainer1 = new ToolStripContainer();
            statusStrip1 = new StatusStrip();
            lblLeftCurDir = new ToolStripStatusLabel();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            lblRightCurDir = new ToolStripStatusLabel();
            splitContainer1 = new SplitContainer();
            btnExport = new Button();
            btnBack2Upper = new Button();
            cbHideSameFile = new CheckBox();
            btnCompare = new Button();
            txtRightDir = new TextBox();
            label2 = new Label();
            txtLeftDir = new TextBox();
            label1 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            lstRight = new ListView();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            lstLeft = new ListView();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            toolStripContainer1.BottomToolStripPanel.SuspendLayout();
            toolStripContainer1.ContentPanel.SuspendLayout();
            toolStripContainer1.SuspendLayout();
            statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.BottomToolStripPanel
            // 
            toolStripContainer1.BottomToolStripPanel.Controls.Add(statusStrip1);
            // 
            // toolStripContainer1.ContentPanel
            // 
            toolStripContainer1.ContentPanel.Controls.Add(splitContainer1);
            toolStripContainer1.ContentPanel.Size = new Size(997, 628);
            toolStripContainer1.Dock = DockStyle.Fill;
            toolStripContainer1.LeftToolStripPanelVisible = false;
            toolStripContainer1.Location = new Point(0, 0);
            toolStripContainer1.Name = "toolStripContainer1";
            toolStripContainer1.RightToolStripPanelVisible = false;
            toolStripContainer1.Size = new Size(997, 650);
            toolStripContainer1.TabIndex = 0;
            toolStripContainer1.Text = "toolStripContainer1";
            toolStripContainer1.TopToolStripPanelVisible = false;
            // 
            // statusStrip1
            // 
            statusStrip1.Dock = DockStyle.None;
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { lblLeftCurDir, toolStripStatusLabel1, lblRightCurDir });
            statusStrip1.Location = new Point(0, 0);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(997, 22);
            statusStrip1.TabIndex = 0;
            // 
            // lblLeftCurDir
            // 
            lblLeftCurDir.Name = "lblLeftCurDir";
            lblLeftCurDir.Size = new Size(0, 16);
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.RightToLeft = RightToLeft.No;
            toolStripStatusLabel1.Size = new Size(982, 16);
            toolStripStatusLabel1.Spring = true;
            // 
            // lblRightCurDir
            // 
            lblRightCurDir.Name = "lblRightCurDir";
            lblRightCurDir.Size = new Size(0, 16);
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.FixedPanel = FixedPanel.Panel1;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(btnExport);
            splitContainer1.Panel1.Controls.Add(btnBack2Upper);
            splitContainer1.Panel1.Controls.Add(cbHideSameFile);
            splitContainer1.Panel1.Controls.Add(btnCompare);
            splitContainer1.Panel1.Controls.Add(txtRightDir);
            splitContainer1.Panel1.Controls.Add(label2);
            splitContainer1.Panel1.Controls.Add(txtLeftDir);
            splitContainer1.Panel1.Controls.Add(label1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(tableLayoutPanel1);
            splitContainer1.Size = new Size(997, 628);
            splitContainer1.SplitterDistance = 127;
            splitContainer1.TabIndex = 1;
            // 
            // btnExport
            // 
            btnExport.Location = new Point(755, 83);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(133, 29);
            btnExport.TabIndex = 7;
            btnExport.Text = "生成报表";
            btnExport.UseVisualStyleBackColor = true;
            btnExport.Click += btnExport_Click;
            // 
            // btnBack2Upper
            // 
            btnBack2Upper.Location = new Point(166, 80);
            btnBack2Upper.Name = "btnBack2Upper";
            btnBack2Upper.Size = new Size(133, 29);
            btnBack2Upper.TabIndex = 6;
            btnBack2Upper.Text = "返回上级文件夹";
            btnBack2Upper.UseVisualStyleBackColor = true;
            btnBack2Upper.Click += btnBack2Upper_Click;
            // 
            // cbHideSameFile
            // 
            cbHideSameFile.AutoSize = true;
            cbHideSameFile.Location = new Point(24, 83);
            cbHideSameFile.Name = "cbHideSameFile";
            cbHideSameFile.Size = new Size(136, 24);
            cbHideSameFile.TabIndex = 5;
            cbHideSameFile.Text = "隐藏相同的文件";
            cbHideSameFile.UseVisualStyleBackColor = true;
            cbHideSameFile.CheckedChanged += cbHideSameFile_CheckedChanged;
            // 
            // btnCompare
            // 
            btnCompare.Location = new Point(894, 13);
            btnCompare.Name = "btnCompare";
            btnCompare.Size = new Size(94, 61);
            btnCompare.TabIndex = 4;
            btnCompare.Text = "对  比";
            btnCompare.UseVisualStyleBackColor = true;
            btnCompare.Click += btnCompare_Click;
            // 
            // txtRightDir
            // 
            txtRightDir.Location = new Point(116, 47);
            txtRightDir.Name = "txtRightDir";
            txtRightDir.Size = new Size(772, 27);
            txtRightDir.TabIndex = 3;
            txtRightDir.Text = "E:\\MyPrograms\\PythonTest";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 50);
            label2.Name = "label2";
            label2.Size = new Size(99, 20);
            label2.TabIndex = 2;
            label2.Text = "右侧文件夹：";
            // 
            // txtLeftDir
            // 
            txtLeftDir.Location = new Point(116, 14);
            txtLeftDir.Name = "txtLeftDir";
            txtLeftDir.Size = new Size(772, 27);
            txtLeftDir.TabIndex = 1;
            txtLeftDir.Text = "E:\\MyPrograms\\Python";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 17);
            label1.Name = "label1";
            label1.Size = new Size(99, 20);
            label1.TabIndex = 0;
            label1.Text = "左侧文件夹：";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(lstRight, 1, 0);
            tableLayoutPanel1.Controls.Add(lstLeft, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(997, 497);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // lstRight
            // 
            lstRight.Columns.AddRange(new ColumnHeader[] { columnHeader3, columnHeader4 });
            lstRight.Dock = DockStyle.Fill;
            lstRight.FullRowSelect = true;
            lstRight.Location = new Point(501, 3);
            lstRight.MultiSelect = false;
            lstRight.Name = "lstRight";
            lstRight.Size = new Size(493, 491);
            lstRight.TabIndex = 1;
            lstRight.UseCompatibleStateImageBehavior = false;
            lstRight.View = View.Details;
            lstRight.MouseClick += lstRight_MouseClick;
            lstRight.MouseDoubleClick += lstRight_MouseDoubleClick;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "类型";
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "名称";
            columnHeader4.Width = 300;
            // 
            // lstLeft
            // 
            lstLeft.Columns.AddRange(new ColumnHeader[] { columnHeader5, columnHeader6 });
            lstLeft.Dock = DockStyle.Fill;
            lstLeft.FullRowSelect = true;
            lstLeft.Location = new Point(3, 3);
            lstLeft.MultiSelect = false;
            lstLeft.Name = "lstLeft";
            lstLeft.Size = new Size(492, 491);
            lstLeft.TabIndex = 0;
            lstLeft.UseCompatibleStateImageBehavior = false;
            lstLeft.View = View.Details;
            lstLeft.MouseClick += lstLeft_MouseClick;
            lstLeft.MouseDoubleClick += lstLeft_MouseDoubleClick;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "类型";
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "名称";
            columnHeader6.Width = 300;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(997, 650);
            Controls.Add(toolStripContainer1);
            Name = "Form1";
            Text = "文件夹对比";
            toolStripContainer1.BottomToolStripPanel.ResumeLayout(false);
            toolStripContainer1.BottomToolStripPanel.PerformLayout();
            toolStripContainer1.ContentPanel.ResumeLayout(false);
            toolStripContainer1.ResumeLayout(false);
            toolStripContainer1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ToolStripContainer toolStripContainer1;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel lblLeftCurDir;
        private SplitContainer splitContainer1;
        private Button btnCompare;
        private TextBox txtRightDir;
        private Label label2;
        private TextBox txtLeftDir;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel1;
        private ListView lstRight;
        private ListView lstLeft;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel lblRightCurDir;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private CheckBox cbHideSameFile;
        private Button btnBack2Upper;
        private Button btnExport;
    }
}
