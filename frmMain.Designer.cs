namespace ConvertPDF
{
    partial class ConvertPDF
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
            this.btnPdfFile = new System.Windows.Forms.Button();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.txtBoxOutputPath = new System.Windows.Forms.TextBox();
            this.txtBoxOutputFile = new System.Windows.Forms.ComboBox();
            this.labelOuput = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnConvert = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPdfFile
            // 
            this.btnPdfFile.Location = new System.Drawing.Point(54, 25);
            this.btnPdfFile.Name = "btnPdfFile";
            this.btnPdfFile.Size = new System.Drawing.Size(106, 26);
            this.btnPdfFile.TabIndex = 0;
            this.btnPdfFile.Text = "Choose PDF file";
            this.btnPdfFile.UseVisualStyleBackColor = true;
            this.btnPdfFile.Click += new System.EventHandler(this.btnPdfFile_Click);
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(571, 28);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(56, 23);
            this.btnBrowse.TabIndex = 2;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(43, 75);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(718, 327);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            // 
            // txtBoxOutputPath
            // 
            this.txtBoxOutputPath.Location = new System.Drawing.Point(465, 30);
            this.txtBoxOutputPath.Name = "txtBoxOutputPath";
            this.txtBoxOutputPath.Size = new System.Drawing.Size(100, 20);
            this.txtBoxOutputPath.TabIndex = 4;
            this.txtBoxOutputPath.Text = "C:\\Output";
            // 
            // txtBoxOutputFile
            // 
            this.txtBoxOutputFile.FormattingEnabled = true;
            this.txtBoxOutputFile.Items.AddRange(new object[] {
            ".docx",
            ".txt",
            ".html"});
            this.txtBoxOutputFile.Location = new System.Drawing.Point(266, 27);
            this.txtBoxOutputFile.Name = "txtBoxOutputFile";
            this.txtBoxOutputFile.Size = new System.Drawing.Size(121, 21);
            this.txtBoxOutputFile.TabIndex = 5;
            this.txtBoxOutputFile.Text = ".docx";
            // 
            // labelOuput
            // 
            this.labelOuput.AutoSize = true;
            this.labelOuput.Location = new System.Drawing.Point(185, 30);
            this.labelOuput.Name = "labelOuput";
            this.labelOuput.Size = new System.Drawing.Size(75, 13);
            this.labelOuput.TabIndex = 6;
            this.labelOuput.Text = "Ouput file type";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(409, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Save to: ";
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(652, 16);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(109, 41);
            this.btnConvert.TabIndex = 8;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // ConvertPDF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelOuput);
            this.Controls.Add(this.txtBoxOutputFile);
            this.Controls.Add(this.txtBoxOutputPath);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.btnPdfFile);
            this.Name = "ConvertPDF";
            this.Text = "Convert PDF Files";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPdfFile;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox txtBoxOutputPath;
        private System.Windows.Forms.ComboBox txtBoxOutputFile;
        private System.Windows.Forms.Label labelOuput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnConvert;
    }
}

