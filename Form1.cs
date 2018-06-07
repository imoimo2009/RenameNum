using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
using static RenameNum.Constants;

namespace RenameNum
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Btn_FolderOpen_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog()
            {
                ShowNewFolderButton = false,
                Description = FOLDERDLG_DESCRIPTION
            };
            fbd.ShowDialog();
            Tb_Path.Text = fbd.SelectedPath;
            FileInfo[] files = GetFileInfos(Tb_Path.Text,"*");
            InitCmbExtention(files);
        }

        private void Btn_Close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Cmb_Extention_SelectedIndexChanged(object sender, EventArgs e)
        {
            FileInfo[] files = GetFileInfos(Tb_Path.Text, "*"+Cmb_Extention.Text);
            InitLvPreview(files);
        }

        private FileInfo[] GetFileInfos(string dirpath,string filter)
        {
            DirectoryInfo di = new DirectoryInfo(dirpath);
            FileInfo[] files = di.GetFiles(filter);
            return files;
        }

        private void InitCmbExtention(FileInfo[] files)
        {
            Cmb_Extention.Items.Clear();
            foreach (FileInfo f in files)
            {
                int sc = 0;
                foreach (string i in Cmb_Extention.Items)
                {
                    if (i.Equals(f.Extension)) sc++;
                }
                if (sc == 0) Cmb_Extention.Items.Add(f.Extension);
            }
            Cmb_Extention.Sorted = true;
            Cmb_Extention.Focus();
        }

        private void InitLvPreview(FileInfo[] files)
        {
            Lv_Preview1.Items.Clear();
            Array.Sort<FileInfo>(files,delegate(FileInfo a,FileInfo b){
                return a.Name.CompareTo(b.Name);
            });
            foreach (FileInfo f in files)
            {
                Lv_Preview1.Items.Add(f.Name);
            }
        }
    }
}

