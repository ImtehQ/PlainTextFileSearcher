
namespace PlainTextFileSearcher.Winforms
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
            this.tbxSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.tbxSearchResults = new System.Windows.Forms.TextBox();
            this.btnOpenFolder = new System.Windows.Forms.Button();
            this.lblOpenedFolder = new System.Windows.Forms.Label();
            this.lblTimePassedMs = new System.Windows.Forms.Label();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.lblMatchesInFiles = new System.Windows.Forms.Label();
            this.lblTotalMatches = new System.Windows.Forms.Label();
            this.LblTotaalFolderAndFiles = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbxSearch
            // 
            this.tbxSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxSearch.Location = new System.Drawing.Point(13, 44);
            this.tbxSearch.Name = "tbxSearch";
            this.tbxSearch.Size = new System.Drawing.Size(416, 23);
            this.tbxSearch.TabIndex = 0;
            this.tbxSearch.Text = "Windmolen";
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.Enabled = false;
            this.btnSearch.Location = new System.Drawing.Point(435, 44);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_ClickAsync);
            // 
            // tbxSearchResults
            // 
            this.tbxSearchResults.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxSearchResults.Location = new System.Drawing.Point(12, 73);
            this.tbxSearchResults.Multiline = true;
            this.tbxSearchResults.Name = "tbxSearchResults";
            this.tbxSearchResults.ReadOnly = true;
            this.tbxSearchResults.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbxSearchResults.Size = new System.Drawing.Size(498, 375);
            this.tbxSearchResults.TabIndex = 2;
            this.tbxSearchResults.WordWrap = false;
            // 
            // btnOpenFolder
            // 
            this.btnOpenFolder.Location = new System.Drawing.Point(13, 13);
            this.btnOpenFolder.Name = "btnOpenFolder";
            this.btnOpenFolder.Size = new System.Drawing.Size(96, 23);
            this.btnOpenFolder.TabIndex = 3;
            this.btnOpenFolder.Text = "Open Folder";
            this.btnOpenFolder.UseVisualStyleBackColor = true;
            this.btnOpenFolder.Click += new System.EventHandler(this.btnOpenFolder_Click);
            // 
            // lblOpenedFolder
            // 
            this.lblOpenedFolder.AutoSize = true;
            this.lblOpenedFolder.Location = new System.Drawing.Point(115, 17);
            this.lblOpenedFolder.Name = "lblOpenedFolder";
            this.lblOpenedFolder.Size = new System.Drawing.Size(139, 15);
            this.lblOpenedFolder.TabIndex = 4;
            this.lblOpenedFolder.Text = "choose a folder to search";
            // 
            // lblTimePassedMs
            // 
            this.lblTimePassedMs.AutoSize = true;
            this.lblTimePassedMs.Location = new System.Drawing.Point(12, 455);
            this.lblTimePassedMs.Name = "lblTimePassedMs";
            this.lblTimePassedMs.Size = new System.Drawing.Size(32, 15);
            this.lblTimePassedMs.TabIndex = 5;
            this.lblTimePassedMs.Text = "0 ms";
            // 
            // folderBrowserDialog
            // 
            this.folderBrowserDialog.ShowNewFolderButton = false;
            // 
            // lblMatchesInFiles
            // 
            this.lblMatchesInFiles.AutoSize = true;
            this.lblMatchesInFiles.Location = new System.Drawing.Point(50, 455);
            this.lblMatchesInFiles.Name = "lblMatchesInFiles";
            this.lblMatchesInFiles.Size = new System.Drawing.Size(114, 15);
            this.lblMatchesInFiles.TabIndex = 6;
            this.lblMatchesInFiles.Text = "files with matches: 0";
            // 
            // lblTotalMatches
            // 
            this.lblTotalMatches.AutoSize = true;
            this.lblTotalMatches.Location = new System.Drawing.Point(170, 455);
            this.lblTotalMatches.Name = "lblTotalMatches";
            this.lblTotalMatches.Size = new System.Drawing.Size(91, 15);
            this.lblTotalMatches.TabIndex = 7;
            this.lblTotalMatches.Text = "total matches: 0";
            // 
            // LblTotaalFolderAndFiles
            // 
            this.LblTotaalFolderAndFiles.AutoSize = true;
            this.LblTotaalFolderAndFiles.Location = new System.Drawing.Point(267, 455);
            this.LblTotaalFolderAndFiles.Name = "LblTotaalFolderAndFiles";
            this.LblTotaalFolderAndFiles.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LblTotaalFolderAndFiles.Size = new System.Drawing.Size(98, 15);
            this.LblTotaalFolderAndFiles.TabIndex = 8;
            this.LblTotaalFolderAndFiles.Text = "Folders: 0, Files: 0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 478);
            this.Controls.Add(this.LblTotaalFolderAndFiles);
            this.Controls.Add(this.lblTotalMatches);
            this.Controls.Add(this.lblMatchesInFiles);
            this.Controls.Add(this.lblTimePassedMs);
            this.Controls.Add(this.lblOpenedFolder);
            this.Controls.Add(this.btnOpenFolder);
            this.Controls.Add(this.tbxSearchResults);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.tbxSearch);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox tbxSearchResults;
        private System.Windows.Forms.Button btnOpenFolder;
        private System.Windows.Forms.Label lblOpenedFolder;
        private System.Windows.Forms.Label lblTimePassedMs;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.Label lblMatchesInFiles;
        private System.Windows.Forms.Label lblTotalMatches;
        private System.Windows.Forms.Label LblTotaalFolderAndFiles;
    }
}

