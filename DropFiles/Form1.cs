using System;
using System.Windows.Forms;
using System.IO;

namespace DropFiles
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            this.AllowDrop = true;
            this.DragEnter += new DragEventHandler(Form1_DragEnter);
            this.DragDrop += new DragEventHandler(Form1_DragDrop);
            LBL_DropFiles.AllowDrop = true;
            LBL_DropFiles.DragEnter += new DragEventHandler(Form1_DragEnter);
            LBL_DropFiles.DragDrop += new DragEventHandler(Form1_DragDrop);
        }

        private void LBL_DropFiles_DragDrop(object sender, DragEventArgs e)
        {
            TB_Log.Clear();
            int i = 1;
            string[] fileList = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            int FileCount = fileList.Length;
            foreach(string FileWithFullPath in fileList)
            {
                string FileNamewithoutExtension = Path.GetFileNameWithoutExtension(FileWithFullPath);
                int FirstHyphen = FileNamewithoutExtension.IndexOf('-');
                string Product = FileNamewithoutExtension.Remove(FirstHyphen, FileNamewithoutExtension.Length-FirstHyphen);
                string PartNumber = 
                    FileNamewithoutExtension.Substring(FileNamewithoutExtension.LastIndexOf('-')+1,FileNamewithoutExtension.Length - FileNamewithoutExtension.IndexOf('.'));
                string Revision = FileNamewithoutExtension.Substring(FileNamewithoutExtension.LastIndexOf('.') + 1);
                CheckandCreateFolder(Product);
                CheckandCreateFolder(Product + @"\" + PartNumber);
                CheckandCreateFolder(Product + @"\" + PartNumber + @"\" + Revision);
                string NewFileName = string.Concat(Path.GetFileNameWithoutExtension(FileWithFullPath), "_" , DateTime.Now.ToString("dd-MMM-yyyy_HHmmss"), Path.GetExtension(FileWithFullPath));
                File.Copy(FileWithFullPath, LBL_SelectedFolder.Text.ToString() + @"\" + Product + @"\" + PartNumber + @"\" + Revision + @"\" + NewFileName);
                TB_Log.ScrollToCaret();
                TB_Log.AppendText("File #" + i + " of " + FileCount + " : " + NewFileName + " Copied!." + Environment.NewLine);
                i++;
            }
        }

        void Form1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Copy;
        }

        void Form1_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            foreach (string file in files) Console.WriteLine(file);
        }

        private void BTN_SelectFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog FBD_SelectFolder = new FolderBrowserDialog();
            if (FBD_SelectFolder.ShowDialog() == DialogResult.OK)
            {
                LBL_SelectedFolder.Text = FBD_SelectFolder.SelectedPath;
            }
            else
            {
                LBL_SelectedFolder.Text = @"C:\";
            }
        }

        void CheckandCreateFolder(string FolderName)
        {
            string InitialPath = LBL_SelectedFolder.Text.ToString();
            if (!Directory.Exists(InitialPath + FolderName))
            {
                Directory.CreateDirectory(InitialPath + @"\" + FolderName);
            }
        }
    }
}
