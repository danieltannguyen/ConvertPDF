using org.apache.pdfbox.pdmodel;
using org.apache.pdfbox.util;
using System;
using System.Diagnostics;
using System.Windows.Forms;
using Xceed.Words.NET;
using System.IO;

namespace ConvertPDF
{
    public partial class ConvertPDF : Form
    {
        private string path = "";
        public ConvertPDF()
        {
            InitializeComponent();
        }

        private void btnPdfFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.InitialDirectory = @"C:\";
            file.Filter = "PDF file only (*.pdf)|*.pdf";
            file.FilterIndex = 1;
            file.Multiselect = false;
            if(file.ShowDialog() == DialogResult.OK)
            {
                string fileName = file.FileName;
                FileInfo f = new FileInfo(fileName);
                path = f.DirectoryName;
                //set output path
                txtBoxOutputPath.Text = path;
            }
        }
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderDlg = new FolderBrowserDialog();
            folderDlg.ShowNewFolderButton = true;
            // Show the FolderBrowserDialog.  
            DialogResult result = folderDlg.ShowDialog();
            if (result == DialogResult.OK)
            {
                txtBoxOutputPath.Text = folderDlg.SelectedPath;
                Environment.SpecialFolder root = folderDlg.RootFolder;
            }
        }
        private void Convert()
        {
            PDDocument doc = null;
            doc = PDDocument.load(@"C:\test\test.pdf");
            PDFTextStripper textStrip = new PDFTextStripper();
            string strPDFText = textStrip.getText(doc);
            doc.close();

            //define the path where you want to save the doc file
            string fn = @"C:\test\test.docx";
            var wordDoc = DocX.Create(fn);

            //insert data in it
            wordDoc.InsertParagraph(strPDFText);

            //save the word file
            wordDoc.Save();

            //open the word file
            Process.Start("WINWORD.EXE", fn);
        }
        private void btnConvert_Click(object sender, EventArgs e)
        {
            Convert();
        }

        
    }
}
