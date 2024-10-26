using System.Data.Common;
using Sylvan.Data.Excel;
using Sylvan.Data;

namespace DirCompare
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCompare_Click(object sender, EventArgs e)
        {
            ListCurBothDir(txtLeftDir.Text, txtRightDir.Text);
        }

        private void ListCurBothDir(string leftDir, string rightDir)
        {
            lblLeftCurDir.Text = leftDir;
            lblRightCurDir.Text = rightDir;

            lstLeft.SuspendLayout();
            lstRight.SuspendLayout();

            try
            {
                lstLeft.Items.Clear();
                lstRight.Items.Clear();

                List<string> subLeftDirs = new List<string>(Directory.GetDirectories(leftDir));
                List<string> subRightDirs = new List<string>(Directory.GetDirectories(rightDir));

                subLeftDirs.Sort();
                subRightDirs.Sort();
                string tmp = string.Empty;
                string tmpPath = string.Empty;

                foreach (string dir in subLeftDirs)
                {
                    tmp = Path.GetFileName(dir);

                    ListViewItem listViewItem = new ListViewItem("文件夹");
                    listViewItem.Tag = dir;
                    listViewItem.SubItems.Add(tmp);

                    if (!subRightDirs.Contains(Path.Combine(rightDir, tmp)))
                    {
                        listViewItem.BackColor = Color.LightBlue;
                    }

                    lstLeft.Items.Add(listViewItem);
                }

                foreach (string dir in subRightDirs)
                {
                    tmp = Path.GetFileName(dir);

                    ListViewItem listViewItem = new ListViewItem("文件夹");
                    listViewItem.Tag = dir;
                    listViewItem.SubItems.Add(tmp);

                    if (!subLeftDirs.Contains(Path.Combine(leftDir, tmp)))
                    {
                        listViewItem.BackColor = Color.LightYellow;
                    }

                    lstRight.Items.Add(listViewItem);
                }

                List<string> subLeftFiles = new List<string>(Directory.GetFiles(leftDir));
                List<string> subRightFiles = new List<string>(Directory.GetFiles(rightDir));
                Color bgColor;

                subLeftFiles.Sort();
                subRightFiles.Sort();

                foreach (string file in subLeftFiles)
                {
                    tmp = Path.GetFileName(file);
                    tmpPath = Path.Combine(rightDir, tmp);
                    bgColor = Color.White;

                    if (!subRightFiles.Contains(tmpPath))
                    {
                        bgColor = Color.LightBlue;
                    }
                    else
                    {
                        if (new FileInfo(file).LastWriteTime != new FileInfo(tmpPath).LastWriteTime)
                        {
                            bgColor = Color.LightPink;
                        }
                        else if (cbHideSameFile.Checked)
                        {
                            continue;
                        }
                    }

                    ListViewItem listViewItem = new ListViewItem("文件");
                    listViewItem.Tag = file;
                    listViewItem.SubItems.Add(Path.GetFileName(tmp));
                    listViewItem.BackColor = bgColor;

                    lstLeft.Items.Add(listViewItem);
                }

                foreach (string file in subRightFiles)
                {
                    tmp = Path.GetFileName(file);
                    tmpPath = Path.Combine(leftDir, tmp);
                    bgColor = Color.White;

                    if (!subLeftFiles.Contains(tmpPath))
                    {
                        bgColor = Color.LightYellow;
                    }
                    else
                    {
                        if (new FileInfo(file).LastWriteTime != new FileInfo(tmpPath).LastWriteTime)
                        {
                            bgColor = Color.LightPink;
                        }
                        else if (cbHideSameFile.Checked)
                        {
                            continue;
                        }
                    }

                    ListViewItem listViewItem = new ListViewItem("文件");
                    listViewItem.Tag = file;
                    listViewItem.SubItems.Add(tmp);
                    listViewItem.BackColor = bgColor;

                    lstRight.Items.Add(listViewItem);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                lstLeft.ResumeLayout();
                lstRight.ResumeLayout();

                GC.Collect();
            }
        }

        private void lstLeft_MouseClick(object sender, MouseEventArgs e)
        {
            FindSameName(lstLeft, lstRight, e);
        }

        private void FindSameName(ListView srcLst, ListView dstLst, MouseEventArgs e)
        {
            ListViewItem listViewItem = srcLst.GetItemAt(e.X, e.Y);
            if (listViewItem != null)
            {
                if (dstLst.SelectedItems.Count > 0)
                {
                    dstLst.SelectedItems[0].Selected = false;
                }

                foreach (ListViewItem lvi in dstLst.Items)
                {
                    if (lvi.SubItems[0].Text == listViewItem.SubItems[0].Text &&
                        lvi.SubItems[1].Text == listViewItem.SubItems[1].Text)
                    {
                        lvi.Selected = true;
                        break;
                    }
                }

            }
        }

        private void lstRight_MouseClick(object sender, MouseEventArgs e)
        {
            FindSameName(lstRight, lstLeft, e);
        }

        private void cbHideSameFile_CheckedChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(lblLeftCurDir.Text))
            {
                return;
            }

            ListCurBothDir(lblLeftCurDir.Text, lblRightCurDir.Text);
        }

        private void EnterSameDir(ListView srcLst, ListView destLst, MouseEventArgs e, bool isLeft)
        {
            ListViewItem listViewItem = srcLst.GetItemAt(e.X, e.Y);
            if (listViewItem != null && listViewItem.SubItems[0].Text == "文件夹")
            {
                bool hasSameDir = false;
                ListViewItem lstDest = null;

                foreach (ListViewItem lvi in destLst.Items)
                {
                    if (lvi.SubItems[0].Text == listViewItem.SubItems[0].Text &&
                        lvi.SubItems[1].Text == listViewItem.SubItems[1].Text)
                    {
                        lstDest = lvi;
                        hasSameDir = true;
                        break;
                    }
                }

                if (!hasSameDir)
                {
                    MessageBox.Show("双击选中的文件夹在对面没有相同文件夹，不需要双击进入文件夹内");
                }
                else
                {
                    if (isLeft)
                    {
                        ListCurBothDir(listViewItem.Tag.ToString(), lstDest.Tag.ToString());
                    }
                    else
                    {
                        ListCurBothDir(lstDest.Tag.ToString(), listViewItem.Tag.ToString());
                    }
                }
            }
            else
            {
                MessageBox.Show("鼠标双击处非文件夹，无法双击进入");
            }
        }

        private void lstLeft_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            EnterSameDir(lstLeft, lstRight, e, true);
        }

        private void lstRight_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            EnterSameDir(lstRight, lstLeft, e, false);
        }

        private void btnBack2Upper_Click(object sender, EventArgs e)
        {
            if (lblLeftCurDir.Text == txtLeftDir.Text)
            {
                MessageBox.Show("已经是最上层目录了");
                return;
            }

            string dirName = Path.GetFileName(lblLeftCurDir.Text);
            ListCurBothDir(lblLeftCurDir.Text.Substring(0, lblLeftCurDir.Text.Length - dirName.Length - 1),
                           lblRightCurDir.Text.Substring(0, lblRightCurDir.Text.Length - dirName.Length - 1));
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            List<DirectoryCompareRecord> results= new List<DirectoryCompareRecord>();

            Queue<string> subDirs= new Queue<string>();

            string leftDir=txtLeftDir.Text.TrimEnd('\\');
            string rightDir=txtRightDir.Text.TrimEnd('\\');
            string curLeftDir = leftDir;
            string curRightDir = rightDir;

            List<string> subLeftDirs = new List<string>();
            List<string> subRightDirs = new List<string>();
            List<string> subLeftFiles = new List<string>();
            List<string> subRightFiles = new List<string>();

            string tmpFileName = string.Empty;
            string tmpDirName = string.Empty;
            string tmp = string.Empty;

            FileInfo leftFile = null;
            FileInfo rightFile = null;

            do
            {                
                curLeftDir = Path.Combine(leftDir, tmp);
                curRightDir = Path.Combine(rightDir, tmp);

                subLeftDirs.Clear();
                subRightDirs.Clear();
                subLeftFiles.Clear();
                subRightFiles.Clear();
                

                subLeftFiles.AddRange(Directory.GetFiles(curLeftDir));
                subRightFiles.AddRange(Directory.GetFiles(curRightDir));

                subLeftFiles.Sort();
                subRightFiles.Sort();

                foreach (string file in subLeftFiles)
                {
                    tmpFileName = Path.GetFileName(file);
                    tmpDirName = Path.Combine(curRightDir, tmpFileName);

                    if (!subRightFiles.Contains(tmpDirName))
                    {
                        DirectoryCompareRecord record = new DirectoryCompareRecord();
                        record.ObjectType = "文件";
                        record.ResultType = "文件缺失";
                        record.LeftDirectory = curLeftDir;
                        record.LeftFile = tmpFileName;

                        results.Add(record);
                    }
                    else
                    {
                        leftFile=new FileInfo(file);
                        rightFile=new FileInfo(tmpDirName);

                        if (leftFile.LastWriteTime != rightFile.LastWriteTime)
                        {
                            DirectoryCompareRecord record = new DirectoryCompareRecord();
                            record.ObjectType = "文件";
                            record.ResultType = "文件有差异";
                            record.LeftDirectory = curLeftDir;
                            record.LeftFile = tmpFileName;
                            record.LeftFileLastModifyDate = leftFile.LastWriteTime.ToString();
                            record.RightDirectory = curRightDir;
                            record.RightFile = tmpFileName;
                            record.RightFileLastModifyDate = rightFile.LastWriteTime.ToString();

                            results.Add(record);
                        }
                        else
                        {
                            subRightFiles.Remove(tmpDirName);
                        }                        
                    }
                }

                foreach (string file in subRightFiles)
                {
                    tmpFileName = Path.GetFileName(file);
                    tmpDirName = Path.Combine(curLeftDir, tmpFileName);

                    if (!subLeftFiles.Contains(tmpDirName))
                    {
                        DirectoryCompareRecord record = new DirectoryCompareRecord();
                        record.ObjectType = "文件";
                        record.ResultType = "文件缺失";
                        record.RightDirectory = curRightDir;
                        record.RightFile = tmpFileName;

                        results.Add(record);
                    }
                }

                subLeftDirs.AddRange(Directory.GetDirectories(curLeftDir));
                subRightDirs.AddRange(Directory.GetDirectories(curRightDir));

                subLeftDirs.Sort();
                subRightDirs.Sort();

                foreach (string dir in subLeftDirs)
                {
                    tmpFileName = Path.GetFileName(dir);
                    tmpDirName = Path.Combine(curRightDir, tmpFileName);

                    if (!subRightDirs.Contains(tmpDirName))
                    {
                        DirectoryCompareRecord record = new DirectoryCompareRecord();
                        record.ObjectType = "文件夹";
                        record.ResultType = "文件夹缺失";
                        record.LeftDirectory = curLeftDir;
                        record.LeftFile = tmpFileName;

                        results.Add(record);
                    }
                    else
                    {
                        subDirs.Enqueue(dir.Substring(leftDir.Length+1));
                        subRightFiles.Remove(tmpDirName);                        
                    }
                }

                foreach (string file in subRightDirs)
                {
                    tmpFileName = Path.GetFileName(file);
                    tmpDirName = Path.Combine(curLeftDir, tmpFileName);

                    if (!subLeftDirs.Contains(tmpDirName))
                    {
                        DirectoryCompareRecord record = new DirectoryCompareRecord();
                        record.ObjectType = "文件夹";
                        record.ResultType = "文件夹缺失";
                        record.RightDirectory = curRightDir;
                        record.RightFile = tmpFileName;

                        results.Add(record);
                    }
                }

                if(subDirs.Count>0)
                {
                    tmp=subDirs.Dequeue();
                }
                
            } while (subDirs.Count >0);

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "XLSX|*.xlsx";
            if (saveFileDialog.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            DbDataReader reader = ObjectDataReader.Create(results);
            using (var w = ExcelDataWriter.Create(saveFileDialog.FileName))
            {
                w.Write(reader);
            }
        }
    }
}
