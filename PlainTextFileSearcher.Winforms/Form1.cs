using PlainTextFileSearcher.Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlainTextFileSearcher.Winforms
{
    public partial class Form1 : Form
    {
        private const string SEARCH = "Search";
        private const string CANCEL = "Cancel";

        public Form1()
        {
            InitializeComponent();
        }

        private List<Tuple<int, int, string>> searchResults = new List<Tuple<int, int, string>>();
        private string TextBoxResult = "";
        private Stopwatch sw = new Stopwatch();

        private async void btnSearch_ClickAsync(object sender, EventArgs e)
        {
            if (btnSearch.Text == SEARCH)
            {
                btnSearch.Text = CANCEL;
                SearchService ss = new SearchService();
                //===============================================================================

                sw.Start();
                ss.IndexFolders(lblOpenedFolder.Text);
                sw.Stop();
                Debug.WriteLine($"IndexFolders took: {sw.ElapsedMilliseconds} ms");
                sw.Reset();

                //===============================================================================

                sw.Start();
                var results = await ss.FindInAllFiles(tbxSearch.Text);
                sw.Stop();
                Debug.WriteLine($"FindInFile took: {sw.ElapsedMilliseconds} ms, {results.Count} matches found!");
                sw.Reset();

                //===============================================================================

                sw.Start();
                
                tbxSearchResults.Text = TextBoxResult;

                //lblTimePassedMs.Text = $"{ss.sw.ElapsedMilliseconds.ToString()} ms";
                LblTotaalFolderAndFiles.Text = $"Folders: {ss.folderPaths.Count()} & Files: {ss.filePaths.Count()}"; sw.Stop();

                sw.Stop();
                Debug.WriteLine($"Preparing results took: {sw.ElapsedMilliseconds} ms");
                sw.Reset();
                //===============================================================================
            }
            else
            {
                btnSearch.Text = SEARCH;

                //TODO cancelation
            }
        }

        private void btnOpenFolder_Click(object sender, EventArgs e)
        {
            folderBrowserDialog.ShowDialog();
            lblOpenedFolder.Text = folderBrowserDialog.SelectedPath;
            btnSearch.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblOpenedFolder.Text = @"D:\Itvitea\articles";
            btnSearch.Enabled = true;
        }
    }
}
