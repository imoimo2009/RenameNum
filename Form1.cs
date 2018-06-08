using System;
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

        // 各種メンバ関数

        private void OpenFolderDlg()
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog()
            {
                ShowNewFolderButton = false,
                Description = FOLDERDLG_DESCRIPTION
            };
            fbd.ShowDialog();
            if (fbd.SelectedPath != "")
            {
                Tb_Path.Text = fbd.SelectedPath;
                InitCmbExtention();
                Lv_Preview1.Items.Clear();
                Lv_Preview2.Items.Clear();
            }
        }

        private FileInfo[] GetFileInfos(string dirpath, string filter)
        {
            DirectoryInfo di = new DirectoryInfo(dirpath);
            FileInfo[] files = di.GetFiles(filter);
            return files;
        }

        private void InitCmbExtention()
        {
            FileInfo[] files = GetFileInfos(Tb_Path.Text, "*");
            Cmb_Extention.Items.Clear();
            foreach (FileInfo f in files)
            {
                int sc = 0;
                foreach (string i in Cmb_Extention.Items)
                {
                    if (i.Equals(f.Extension)) sc++;
                }
                if (f.Extension == "") sc = 1;
                if (sc == 0) Cmb_Extention.Items.Add(f.Extension);
            }
            Cmb_Extention.Sorted = true;
            Cmb_Extention.Focus();
        }

        private void InitLvPreview()
        {
            if (Cmb_Extention.Text == "") return;
            FileInfo[] files = GetFileInfos(Tb_Path.Text, "*" + Cmb_Extention.Text);
            Lv_Preview1.Items.Clear();
            Lv_Preview2.Items.Clear();
            Array.Sort<FileInfo>(files, delegate (FileInfo a, FileInfo b) { return a.Name.CompareTo(b.Name); });
            int digit = (int)Num_Digits.Value;
            decimal num = Num_Start.Value;
            string prefix = Tb_Prefix.Text;
            string suffix = Tb_Suffix.Text;
            foreach (FileInfo f in files)
            {
                Lv_Preview1.Items.Add(f.Name);
                Lv_Preview2.Items.Add(prefix + num.ToString().PadLeft(digit, '0') + suffix + Cmb_Extention.Text);
                num++;
            }
        }

        private void Exec_Rename()
        {
            if (MessageBox.Show(MSG_EXEC_CONFIRM, "確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int i;

                for (i = 0; i < Lv_Preview1.Items.Count; i++)
                {
                    try
                    {
                        string path1 = Tb_Path.Text + "\\" + Lv_Preview1.Items[i].Text;
                        string path2 = Tb_Path.Text + "\\" + Lv_Preview2.Items[i].Text;
                        File.Move(path1, path2);
                    }
                    catch(IOException e)
                    {
                        MessageBox.Show(e.Message);
                        MessageBox.Show(MSG_EXEC_ERROR);
                        break;
                    }
                }
                if (i <= Lv_Preview1.Items.Count)
                {
                    for (int j = 0; j < i; j++)
                    {
                        string path1 = Tb_Path.Text + "\\" + Lv_Preview1.Items[j].Text;
                        string path2 = Tb_Path.Text + "\\" + Lv_Preview2.Items[j].Text;
                        File.Move(path2, path1);
                    }
                }
                else
                {
                    MessageBox.Show(MSG_EXEC_COMPLETE);
                    InitLvPreview();
                }
            }
        }

        // イベント処理

        private void Btn_FolderOpen_Click(object sender, EventArgs e)
        {
            OpenFolderDlg();
        }

        private void Cmb_Extention_SelectedIndexChanged(object sender, EventArgs e)
        {
            InitLvPreview();
        }

        private void Tb_Prefix_TextChanged(object sender, EventArgs e)
        {
            InitLvPreview();
        }

        private void Tb_Suffix_TextChanged(object sender, EventArgs e)
        {
            InitLvPreview();
        }

        private void Num_Start_ValueChanged(object sender, EventArgs e)
        {
            InitLvPreview();
        }

        private void Num_Digits_ValueChanged(object sender, EventArgs e)
        {
            InitLvPreview();
        }

        private void Btn_Rename_Click(object sender, EventArgs e)
        {
            Exec_Rename();
        }

        private void Btn_Close_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}

