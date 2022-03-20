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
            string[] fileList = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            foreach(string File in fileList)
            {
                string FileNamewithoutExtension = Path.GetFileNameWithoutExtension(File);
                int FirstHyphen = FileNamewithoutExtension.IndexOf('-');
                string Product = FileNamewithoutExtension.Remove(FirstHyphen, FileNamewithoutExtension.Length-FirstHyphen);
                string PartNumber = 
                    FileNamewithoutExtension.Substring(FileNamewithoutExtension.LastIndexOf('-')+1,FileNamewithoutExtension.Length - FileNamewithoutExtension.IndexOf('.'));
                string Revision = FileNamewithoutExtension.Substring(FileNamewithoutExtension.LastIndexOf('.') + 1);
                //MessageBox.Show("File name : " + FileNamewithoutExtension + Environment.NewLine +
                //                "Product : " + Product + Environment.NewLine +
                //                "Part Number : " + PartNumber + Environment.NewLine +
                //                "Revision : " + Revision);
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
    }
}
