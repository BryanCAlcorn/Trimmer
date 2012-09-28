using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.Collections.ObjectModel;
using System.Reflection;
using System.Configuration;
using System.IO;
using System.Diagnostics;

namespace TrimmerForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            lblCompleted.Visible = false;
            lblFolderPath.Text = "Folder Path: ";
            DialogResult result = folderBrowserDialog1.ShowDialog();
            lblFolderPath.Text += folderBrowserDialog1.SelectedPath;
        }

        private void btnTrimFiles_Click(object sender, EventArgs e)
        {
            Collection<string> fileTypesToTrim = new Collection<string>();
            if (cbAspx.Checked)
            {
                fileTypesToTrim.Add(".aspx");
            }
            if (cbconfig.Checked)
            {
                fileTypesToTrim.Add(".config");
            }
            if (cbCs.Checked)
            {
                fileTypesToTrim.Add(".cs");
            }
            if (cbTxt.Checked)
            {
                fileTypesToTrim.Add(".txt");
            }
            if (cbXml.Checked)
            {
                fileTypesToTrim.Add(".xml");
            }
            string[] inputFileTypes = txtFileTypeInputs.Text.ToLower().Trim().Split(',');
            foreach (string type in inputFileTypes)
            {
                if (type.StartsWith("."))
                {
                    fileTypesToTrim.Add(type);
                }
            }

            char[] trimmers = { ' ', '\t', '\n' };
            SearchOption option = (cbTrimSubFolders.Checked ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly);
            
            string[] allFiles = Directory.GetFiles(lblFolderPath.Text, "*", option);

            foreach (string filePath in allFiles)
            {
                FileInfo fileInfo = new FileInfo(filePath);
                if (fileInfo.Exists && fileTypesToTrim.Contains(fileInfo.Extension.ToLower()))
                {
                    //Get All lines for the file and trim off spaces and tabs, replace new-line character if it was there.
                    string[] allLines = File.ReadAllLines(filePath);
                    for (int i = 0; i < allLines.Length;i++ )
                    {
                        if (allLines[i].EndsWith("\n"))
                        {
                            allLines[i] = allLines[i].TrimEnd(trimmers) + "\n";
                        }
                        else
                        {
                            allLines[i] = allLines[i].TrimEnd(trimmers);
                        }
                    }
                    File.WriteAllLines(filePath, allLines);
                }
            }
            lblCompleted.Visible = true;
        }
    }
}
