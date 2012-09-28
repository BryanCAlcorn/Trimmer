namespace TrimmerForms
{
    partial class Form1
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
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblFolderPath = new System.Windows.Forms.Label();
            this.cbTrimSubFolders = new System.Windows.Forms.CheckBox();
            this.btnTrimFiles = new System.Windows.Forms.Button();
            this.lblCompleted = new System.Windows.Forms.Label();
            this.cbAspx = new System.Windows.Forms.CheckBox();
            this.cbCs = new System.Windows.Forms.CheckBox();
            this.cbTxt = new System.Windows.Forms.CheckBox();
            this.cbXml = new System.Windows.Forms.CheckBox();
            this.cbconfig = new System.Windows.Forms.CheckBox();
            this.txtFileTypeInputs = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(12, 12);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "Find Folder";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblFolderPath
            // 
            this.lblFolderPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFolderPath.AutoEllipsis = true;
            this.lblFolderPath.AutoSize = true;
            this.lblFolderPath.Location = new System.Drawing.Point(10, 38);
            this.lblFolderPath.Name = "lblFolderPath";
            this.lblFolderPath.Size = new System.Drawing.Size(64, 13);
            this.lblFolderPath.TabIndex = 1;
            this.lblFolderPath.Text = "Folder Path:";
            // 
            // cbTrimSubFolders
            // 
            this.cbTrimSubFolders.AutoSize = true;
            this.cbTrimSubFolders.Location = new System.Drawing.Point(11, 193);
            this.cbTrimSubFolders.Name = "cbTrimSubFolders";
            this.cbTrimSubFolders.Size = new System.Drawing.Size(111, 17);
            this.cbTrimSubFolders.TabIndex = 2;
            this.cbTrimSubFolders.Text = "Trim Sub-Folders?";
            this.cbTrimSubFolders.UseVisualStyleBackColor = true;
            // 
            // btnTrimFiles
            // 
            this.btnTrimFiles.Location = new System.Drawing.Point(11, 216);
            this.btnTrimFiles.Name = "btnTrimFiles";
            this.btnTrimFiles.Size = new System.Drawing.Size(75, 23);
            this.btnTrimFiles.TabIndex = 3;
            this.btnTrimFiles.Text = "Trim Files";
            this.btnTrimFiles.UseVisualStyleBackColor = true;
            this.btnTrimFiles.Click += new System.EventHandler(this.btnTrimFiles_Click);
            // 
            // lblCompleted
            // 
            this.lblCompleted.AutoSize = true;
            this.lblCompleted.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompleted.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.lblCompleted.Location = new System.Drawing.Point(68, 254);
            this.lblCompleted.Name = "lblCompleted";
            this.lblCompleted.Size = new System.Drawing.Size(129, 20);
            this.lblCompleted.TabIndex = 4;
            this.lblCompleted.Text = "Trim Complete!";
            this.lblCompleted.Visible = false;
            // 
            // cbAspx
            // 
            this.cbAspx.AutoSize = true;
            this.cbAspx.Location = new System.Drawing.Point(11, 99);
            this.cbAspx.Name = "cbAspx";
            this.cbAspx.Size = new System.Drawing.Size(51, 17);
            this.cbAspx.TabIndex = 5;
            this.cbAspx.Text = ".aspx";
            this.cbAspx.UseVisualStyleBackColor = true;
            // 
            // cbCs
            // 
            this.cbCs.AutoSize = true;
            this.cbCs.Location = new System.Drawing.Point(65, 99);
            this.cbCs.Name = "cbCs";
            this.cbCs.Size = new System.Drawing.Size(40, 17);
            this.cbCs.TabIndex = 6;
            this.cbCs.Text = ".cs";
            this.cbCs.UseVisualStyleBackColor = true;
            // 
            // cbTxt
            // 
            this.cbTxt.AutoSize = true;
            this.cbTxt.Location = new System.Drawing.Point(108, 99);
            this.cbTxt.Name = "cbTxt";
            this.cbTxt.Size = new System.Drawing.Size(40, 17);
            this.cbTxt.TabIndex = 7;
            this.cbTxt.Text = ".txt";
            this.cbTxt.UseVisualStyleBackColor = true;
            // 
            // cbXml
            // 
            this.cbXml.AutoSize = true;
            this.cbXml.Location = new System.Drawing.Point(151, 99);
            this.cbXml.Name = "cbXml";
            this.cbXml.Size = new System.Drawing.Size(44, 17);
            this.cbXml.TabIndex = 8;
            this.cbXml.Text = ".xml";
            this.cbXml.UseVisualStyleBackColor = true;
            // 
            // cbconfig
            // 
            this.cbconfig.AutoSize = true;
            this.cbconfig.Location = new System.Drawing.Point(198, 99);
            this.cbconfig.Name = "cbconfig";
            this.cbconfig.Size = new System.Drawing.Size(58, 17);
            this.cbconfig.TabIndex = 9;
            this.cbconfig.Text = ".config";
            this.cbconfig.UseVisualStyleBackColor = true;
            // 
            // txtFileTypeInputs
            // 
            this.txtFileTypeInputs.Location = new System.Drawing.Point(12, 123);
            this.txtFileTypeInputs.Multiline = true;
            this.txtFileTypeInputs.Name = "txtFileTypeInputs";
            this.txtFileTypeInputs.Size = new System.Drawing.Size(299, 64);
            this.txtFileTypeInputs.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(304, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Select File Types to Trim, or Type in Comma Separated Values:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 285);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFileTypeInputs);
            this.Controls.Add(this.cbconfig);
            this.Controls.Add(this.cbXml);
            this.Controls.Add(this.cbTxt);
            this.Controls.Add(this.cbCs);
            this.Controls.Add(this.cbAspx);
            this.Controls.Add(this.lblCompleted);
            this.Controls.Add(this.btnTrimFiles);
            this.Controls.Add(this.cbTrimSubFolders);
            this.Controls.Add(this.lblFolderPath);
            this.Controls.Add(this.btnSearch);
            this.Name = "Form1";
            this.Text = "Trimmer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblFolderPath;
        private System.Windows.Forms.CheckBox cbTrimSubFolders;
        private System.Windows.Forms.Button btnTrimFiles;
        private System.Windows.Forms.Label lblCompleted;
        private System.Windows.Forms.CheckBox cbAspx;
        private System.Windows.Forms.CheckBox cbCs;
        private System.Windows.Forms.CheckBox cbTxt;
        private System.Windows.Forms.CheckBox cbXml;
        private System.Windows.Forms.CheckBox cbconfig;
        private System.Windows.Forms.TextBox txtFileTypeInputs;
        private System.Windows.Forms.Label label1;
    }
}

