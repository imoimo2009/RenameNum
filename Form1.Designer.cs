namespace RenameNum
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.label4 = new System.Windows.Forms.Label();
            this.Btn_Close = new System.Windows.Forms.Button();
            this.Cmb_Extention = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Tb_Path = new System.Windows.Forms.TextBox();
            this.Num_Start = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.Num_Digits = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.Btn_Rename = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.Tb_Prefix = new System.Windows.Forms.TextBox();
            this.Lv_Preview1 = new System.Windows.Forms.ListView();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Tb_Suffix = new System.Windows.Forms.TextBox();
            this.Btn_FolderOpen = new System.Windows.Forms.Button();
            this.Lv_Preview2 = new System.Windows.Forms.ListView();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Num_Start)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Num_Digits)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.Location = new System.Drawing.Point(274, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Extention:";
            // 
            // Btn_Close
            // 
            this.Btn_Close.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Btn_Close.Location = new System.Drawing.Point(373, 378);
            this.Btn_Close.Name = "Btn_Close";
            this.Btn_Close.Size = new System.Drawing.Size(79, 23);
            this.Btn_Close.TabIndex = 9;
            this.Btn_Close.Text = "Close";
            this.Btn_Close.UseVisualStyleBackColor = true;
            this.Btn_Close.Click += new System.EventHandler(this.Btn_Close_Click);
            // 
            // Cmb_Extention
            // 
            this.Cmb_Extention.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cmb_Extention.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Cmb_Extention.FormattingEnabled = true;
            this.Cmb_Extention.Location = new System.Drawing.Point(360, 64);
            this.Cmb_Extention.Name = "Cmb_Extention";
            this.Cmb_Extention.Size = new System.Drawing.Size(91, 21);
            this.Cmb_Extention.TabIndex = 8;
            this.Cmb_Extention.SelectedIndexChanged += new System.EventHandler(this.Cmb_Extention_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(27, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Path:";
            // 
            // Tb_Path
            // 
            this.Tb_Path.Location = new System.Drawing.Point(77, 18);
            this.Tb_Path.Name = "Tb_Path";
            this.Tb_Path.ReadOnly = true;
            this.Tb_Path.Size = new System.Drawing.Size(345, 19);
            this.Tb_Path.TabIndex = 0;
            // 
            // Num_Start
            // 
            this.Num_Start.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Num_Start.Location = new System.Drawing.Point(77, 65);
            this.Num_Start.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.Num_Start.Name = "Num_Start";
            this.Num_Start.Size = new System.Drawing.Size(52, 20);
            this.Num_Start.TabIndex = 4;
            this.Num_Start.ValueChanged += new System.EventHandler(this.Num_Start_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(27, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Start:";
            // 
            // Num_Digits
            // 
            this.Num_Digits.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Num_Digits.Location = new System.Drawing.Point(202, 65);
            this.Num_Digits.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.Num_Digits.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Num_Digits.Name = "Num_Digits";
            this.Num_Digits.Size = new System.Drawing.Size(52, 20);
            this.Num_Digits.TabIndex = 6;
            this.Num_Digits.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Num_Digits.ValueChanged += new System.EventHandler(this.Num_Digits_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(144, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Digits:";
            // 
            // Btn_Rename
            // 
            this.Btn_Rename.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Btn_Rename.Location = new System.Drawing.Point(288, 378);
            this.Btn_Rename.Name = "Btn_Rename";
            this.Btn_Rename.Size = new System.Drawing.Size(79, 23);
            this.Btn_Rename.TabIndex = 10;
            this.Btn_Rename.Text = "Rename";
            this.Btn_Rename.UseVisualStyleBackColor = true;
            this.Btn_Rename.Click += new System.EventHandler(this.Btn_Rename_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label5.Location = new System.Drawing.Point(17, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "Prefix:";
            // 
            // Tb_Prefix
            // 
            this.Tb_Prefix.Location = new System.Drawing.Point(77, 41);
            this.Tb_Prefix.Name = "Tb_Prefix";
            this.Tb_Prefix.Size = new System.Drawing.Size(142, 19);
            this.Tb_Prefix.TabIndex = 12;
            this.Tb_Prefix.TextChanged += new System.EventHandler(this.Tb_Prefix_TextChanged);
            // 
            // Lv_Preview1
            // 
            this.Lv_Preview1.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Lv_Preview1.FullRowSelect = true;
            this.Lv_Preview1.Location = new System.Drawing.Point(77, 91);
            this.Lv_Preview1.Name = "Lv_Preview1";
            this.Lv_Preview1.Size = new System.Drawing.Size(166, 281);
            this.Lv_Preview1.TabIndex = 13;
            this.Lv_Preview1.UseCompatibleStateImageBehavior = false;
            this.Lv_Preview1.View = System.Windows.Forms.View.List;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label6.Location = new System.Drawing.Point(3, 223);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 15);
            this.label6.TabIndex = 14;
            this.label6.Text = "Preview:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label7.Location = new System.Drawing.Point(248, 41);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 15);
            this.label7.TabIndex = 15;
            this.label7.Text = "Suffix:";
            // 
            // Tb_Suffix
            // 
            this.Tb_Suffix.Location = new System.Drawing.Point(308, 41);
            this.Tb_Suffix.Name = "Tb_Suffix";
            this.Tb_Suffix.Size = new System.Drawing.Size(142, 19);
            this.Tb_Suffix.TabIndex = 16;
            this.Tb_Suffix.TextChanged += new System.EventHandler(this.Tb_Suffix_TextChanged);
            // 
            // Btn_FolderOpen
            // 
            this.Btn_FolderOpen.Location = new System.Drawing.Point(428, 18);
            this.Btn_FolderOpen.Name = "Btn_FolderOpen";
            this.Btn_FolderOpen.Size = new System.Drawing.Size(23, 18);
            this.Btn_FolderOpen.TabIndex = 2;
            this.Btn_FolderOpen.Text = "...";
            this.Btn_FolderOpen.UseVisualStyleBackColor = true;
            this.Btn_FolderOpen.Click += new System.EventHandler(this.Btn_FolderOpen_Click);
            // 
            // Lv_Preview2
            // 
            this.Lv_Preview2.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Lv_Preview2.FullRowSelect = true;
            this.Lv_Preview2.Location = new System.Drawing.Point(277, 91);
            this.Lv_Preview2.Name = "Lv_Preview2";
            this.Lv_Preview2.Size = new System.Drawing.Size(174, 281);
            this.Lv_Preview2.TabIndex = 17;
            this.Lv_Preview2.UseCompatibleStateImageBehavior = false;
            this.Lv_Preview2.View = System.Windows.Forms.View.List;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(249, 223);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(22, 21);
            this.label8.TabIndex = 18;
            this.label8.Text = "⏩";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 403);
            this.ControlBox = false;
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Lv_Preview2);
            this.Controls.Add(this.Tb_Suffix);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Lv_Preview1);
            this.Controls.Add(this.Tb_Prefix);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Btn_Rename);
            this.Controls.Add(this.Btn_Close);
            this.Controls.Add(this.Cmb_Extention);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Num_Digits);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Num_Start);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Btn_FolderOpen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Tb_Path);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "連番リネームくん";
            ((System.ComponentModel.ISupportInitialize)(this.Num_Start)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Num_Digits)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Btn_Close;
        private System.Windows.Forms.ComboBox Cmb_Extention;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Tb_Path;
        private System.Windows.Forms.NumericUpDown Num_Start;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown Num_Digits;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Btn_Rename;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Tb_Prefix;
        private System.Windows.Forms.ListView Lv_Preview1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Tb_Suffix;
        private System.Windows.Forms.Button Btn_FolderOpen;
        private System.Windows.Forms.ListView Lv_Preview2;
        private System.Windows.Forms.Label label8;
    }
}

