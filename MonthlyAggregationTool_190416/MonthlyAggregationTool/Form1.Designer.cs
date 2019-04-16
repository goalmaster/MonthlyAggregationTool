namespace MonthlyAggregationTool
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
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
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
            this.buttonSelect = new System.Windows.Forms.Button();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.buttonClearFile = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonMake = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonSelectDirectory = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDirectory = new System.Windows.Forms.TextBox();
            this.buttonClearDirectory = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonSelect
            // 
            this.buttonSelect.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSelect.Location = new System.Drawing.Point(57, 38);
            this.buttonSelect.Name = "buttonSelect";
            this.buttonSelect.Size = new System.Drawing.Size(420, 50);
            this.buttonSelect.TabIndex = 0;
            this.buttonSelect.Text = "ファイルを選択";
            this.buttonSelect.UseVisualStyleBackColor = true;
            this.buttonSelect.Click += new System.EventHandler(this.buttonSelect_Click);
            // 
            // txtPath
            // 
            this.txtPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPath.Enabled = false;
            this.txtPath.Location = new System.Drawing.Point(57, 122);
            this.txtPath.Multiline = true;
            this.txtPath.Name = "txtPath";
            this.txtPath.ReadOnly = true;
            this.txtPath.Size = new System.Drawing.Size(420, 50);
            this.txtPath.TabIndex = 1;
            // 
            // buttonClearFile
            // 
            this.buttonClearFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClearFile.Location = new System.Drawing.Point(337, 186);
            this.buttonClearFile.Name = "buttonClearFile";
            this.buttonClearFile.Size = new System.Drawing.Size(140, 50);
            this.buttonClearFile.TabIndex = 2;
            this.buttonClearFile.Text = "選択したファイルを\r\nクリア";
            this.buttonClearFile.UseVisualStyleBackColor = true;
            this.buttonClearFile.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "選択したファイル";
            // 
            // buttonMake
            // 
            this.buttonMake.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonMake.Location = new System.Drawing.Point(57, 279);
            this.buttonMake.Name = "buttonMake";
            this.buttonMake.Size = new System.Drawing.Size(902, 78);
            this.buttonMake.TabIndex = 4;
            this.buttonMake.Text = "集計表を作成";
            this.buttonMake.UseVisualStyleBackColor = true;
            this.buttonMake.Click += new System.EventHandler(this.buttonMake_Click);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Enabled = false;
            this.textBox1.HideSelection = false;
            this.textBox1.Location = new System.Drawing.Point(57, 383);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(900, 74);
            this.textBox1.TabIndex = 5;
            this.textBox1.Text = "【使用前にご確認ください】\r\n・エクセルファイルを読み込む前に、不要な行・列を削除してください。ツールがうまく作動しない場合があります。";
            // 
            // buttonSelectDirectory
            // 
            this.buttonSelectDirectory.Location = new System.Drawing.Point(537, 38);
            this.buttonSelectDirectory.Name = "buttonSelectDirectory";
            this.buttonSelectDirectory.Size = new System.Drawing.Size(420, 50);
            this.buttonSelectDirectory.TabIndex = 6;
            this.buttonSelectDirectory.Text = "保存先を指定";
            this.buttonSelectDirectory.UseVisualStyleBackColor = true;
            this.buttonSelectDirectory.Click += new System.EventHandler(this.buttonSelectDirectory_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(535, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "指定した保存先";
            // 
            // txtDirectory
            // 
            this.txtDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDirectory.Enabled = false;
            this.txtDirectory.Location = new System.Drawing.Point(538, 122);
            this.txtDirectory.Multiline = true;
            this.txtDirectory.Name = "txtDirectory";
            this.txtDirectory.ReadOnly = true;
            this.txtDirectory.Size = new System.Drawing.Size(420, 50);
            this.txtDirectory.TabIndex = 7;
            // 
            // buttonClearDirectory
            // 
            this.buttonClearDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClearDirectory.Location = new System.Drawing.Point(817, 186);
            this.buttonClearDirectory.Name = "buttonClearDirectory";
            this.buttonClearDirectory.Size = new System.Drawing.Size(140, 50);
            this.buttonClearDirectory.TabIndex = 9;
            this.buttonClearDirectory.Text = "選択した保存先を\r\nクリア";
            this.buttonClearDirectory.UseVisualStyleBackColor = true;
            this.buttonClearDirectory.Click += new System.EventHandler(this.buttonClearDirectory_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 501);
            this.Controls.Add(this.buttonClearDirectory);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDirectory);
            this.Controls.Add(this.buttonSelectDirectory);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonMake);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonClearFile);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.buttonSelect);
            this.Name = "Form1";
            this.Text = "MonthlyAggregationTool";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSelect;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Button buttonClearFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonMake;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonSelectDirectory;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDirectory;
        private System.Windows.Forms.Button buttonClearDirectory;
    }
}

