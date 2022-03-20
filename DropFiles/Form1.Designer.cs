
namespace DropFiles
{
    partial class Main
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
            this.TLP_DropZone = new System.Windows.Forms.TableLayoutPanel();
            this.LBL_DropFiles = new System.Windows.Forms.Label();
            this.LBL_1 = new System.Windows.Forms.Label();
            this.BTN_SelectFolder = new System.Windows.Forms.Button();
            this.LBL_SelectedFolder = new System.Windows.Forms.Label();
            this.TB_Log = new System.Windows.Forms.TextBox();
            this.TLP_DropZone.SuspendLayout();
            this.SuspendLayout();
            // 
            // TLP_DropZone
            // 
            this.TLP_DropZone.ColumnCount = 3;
            this.TLP_DropZone.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.TLP_DropZone.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.TLP_DropZone.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.TLP_DropZone.Controls.Add(this.LBL_DropFiles, 0, 1);
            this.TLP_DropZone.Controls.Add(this.LBL_1, 0, 0);
            this.TLP_DropZone.Controls.Add(this.BTN_SelectFolder, 2, 0);
            this.TLP_DropZone.Controls.Add(this.LBL_SelectedFolder, 1, 0);
            this.TLP_DropZone.Controls.Add(this.TB_Log, 0, 2);
            this.TLP_DropZone.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TLP_DropZone.Location = new System.Drawing.Point(0, 0);
            this.TLP_DropZone.Name = "TLP_DropZone";
            this.TLP_DropZone.RowCount = 3;
            this.TLP_DropZone.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.TLP_DropZone.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.TLP_DropZone.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.TLP_DropZone.Size = new System.Drawing.Size(794, 557);
            this.TLP_DropZone.TabIndex = 0;
            // 
            // LBL_DropFiles
            // 
            this.LBL_DropFiles.AllowDrop = true;
            this.LBL_DropFiles.AutoSize = true;
            this.LBL_DropFiles.BackColor = System.Drawing.Color.White;
            this.TLP_DropZone.SetColumnSpan(this.LBL_DropFiles, 3);
            this.LBL_DropFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LBL_DropFiles.Font = new System.Drawing.Font("Poppins SemiBold", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_DropFiles.ForeColor = System.Drawing.Color.Black;
            this.LBL_DropFiles.Location = new System.Drawing.Point(3, 55);
            this.LBL_DropFiles.Name = "LBL_DropFiles";
            this.LBL_DropFiles.Size = new System.Drawing.Size(788, 417);
            this.LBL_DropFiles.TabIndex = 0;
            this.LBL_DropFiles.Text = "Drop Files Here";
            this.LBL_DropFiles.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LBL_DropFiles.DragDrop += new System.Windows.Forms.DragEventHandler(this.LBL_DropFiles_DragDrop);
            // 
            // LBL_1
            // 
            this.LBL_1.AutoSize = true;
            this.LBL_1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LBL_1.Font = new System.Drawing.Font("Poppins SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_1.Location = new System.Drawing.Point(3, 0);
            this.LBL_1.Name = "LBL_1";
            this.LBL_1.Size = new System.Drawing.Size(113, 55);
            this.LBL_1.TabIndex = 1;
            this.LBL_1.Text = "Folder Location";
            this.LBL_1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BTN_SelectFolder
            // 
            this.BTN_SelectFolder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BTN_SelectFolder.Font = new System.Drawing.Font("Poppins SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_SelectFolder.Location = new System.Drawing.Point(638, 3);
            this.BTN_SelectFolder.Name = "BTN_SelectFolder";
            this.BTN_SelectFolder.Size = new System.Drawing.Size(153, 49);
            this.BTN_SelectFolder.TabIndex = 2;
            this.BTN_SelectFolder.Text = "Select Folder";
            this.BTN_SelectFolder.UseVisualStyleBackColor = true;
            this.BTN_SelectFolder.Click += new System.EventHandler(this.BTN_SelectFolder_Click);
            // 
            // LBL_SelectedFolder
            // 
            this.LBL_SelectedFolder.AutoSize = true;
            this.LBL_SelectedFolder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LBL_SelectedFolder.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_SelectedFolder.Location = new System.Drawing.Point(122, 0);
            this.LBL_SelectedFolder.Name = "LBL_SelectedFolder";
            this.LBL_SelectedFolder.Size = new System.Drawing.Size(510, 55);
            this.LBL_SelectedFolder.TabIndex = 3;
            this.LBL_SelectedFolder.Text = "C:\\";
            this.LBL_SelectedFolder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TB_Log
            // 
            this.TB_Log.BackColor = System.Drawing.Color.White;
            this.TLP_DropZone.SetColumnSpan(this.TB_Log, 3);
            this.TB_Log.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TB_Log.Enabled = false;
            this.TB_Log.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_Log.ForeColor = System.Drawing.Color.Black;
            this.TB_Log.Location = new System.Drawing.Point(3, 475);
            this.TB_Log.Multiline = true;
            this.TB_Log.Name = "TB_Log";
            this.TB_Log.ReadOnly = true;
            this.TB_Log.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TB_Log.Size = new System.Drawing.Size(788, 79);
            this.TB_Log.TabIndex = 4;
            // 
            // Main
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(794, 557);
            this.Controls.Add(this.TLP_DropZone);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Drop Files";
            this.TopMost = true;
            this.TLP_DropZone.ResumeLayout(false);
            this.TLP_DropZone.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TLP_DropZone;
        private System.Windows.Forms.Label LBL_DropFiles;
        private System.Windows.Forms.Label LBL_1;
        private System.Windows.Forms.Button BTN_SelectFolder;
        private System.Windows.Forms.Label LBL_SelectedFolder;
        private System.Windows.Forms.TextBox TB_Log;
    }
}

