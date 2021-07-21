namespace LoadPullChangeName
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.BrowsFolder = new System.Windows.Forms.TextBox();
            this.Brows = new System.Windows.Forms.Button();
            this.Import = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.CSVFilePath2 = new System.Windows.Forms.TextBox();
            this.Exit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CSVFilePath = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.OpenCSV = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // BrowsFolder
            // 
            this.BrowsFolder.AllowDrop = true;
            this.BrowsFolder.Location = new System.Drawing.Point(128, 11);
            this.BrowsFolder.Name = "BrowsFolder";
            this.BrowsFolder.Size = new System.Drawing.Size(313, 22);
            this.BrowsFolder.TabIndex = 0;
            this.BrowsFolder.DragDrop += new System.Windows.Forms.DragEventHandler(this.BrowsFolder_DragDrop);
            this.BrowsFolder.DragEnter += new System.Windows.Forms.DragEventHandler(this.BrowsFolder_DragEnter);
            // 
            // Brows
            // 
            this.Brows.Location = new System.Drawing.Point(447, 5);
            this.Brows.Name = "Brows";
            this.Brows.Size = new System.Drawing.Size(105, 44);
            this.Brows.TabIndex = 1;
            this.Brows.Text = "Brows Folder\r\nand Record name";
            this.Brows.UseVisualStyleBackColor = true;
            this.Brows.Click += new System.EventHandler(this.Brows_Click);
            // 
            // Import
            // 
            this.Import.Location = new System.Drawing.Point(447, 98);
            this.Import.Name = "Import";
            this.Import.Size = new System.Drawing.Size(105, 39);
            this.Import.TabIndex = 2;
            this.Import.Text = "Import CSV \r\nand Do it";
            this.Import.UseVisualStyleBackColor = true;
            this.Import.Click += new System.EventHandler(this.Import_Click);
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(447, 154);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(105, 28);
            this.Clear.TabIndex = 4;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // CSVFilePath2
            // 
            this.CSVFilePath2.AllowDrop = true;
            this.CSVFilePath2.Location = new System.Drawing.Point(128, 108);
            this.CSVFilePath2.Name = "CSVFilePath2";
            this.CSVFilePath2.Size = new System.Drawing.Size(313, 22);
            this.CSVFilePath2.TabIndex = 5;
            this.CSVFilePath2.DragDrop += new System.Windows.Forms.DragEventHandler(this.CSVFilePath2_DragDrop);
            this.CSVFilePath2.DragEnter += new System.Windows.Forms.DragEventHandler(this.CSVFilePath2_DragEnter);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(191, 154);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(143, 28);
            this.Exit.TabIndex = 6;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 12);
            this.label1.TabIndex = 7;
            this.label1.Text = "1.Brows Picture Folder:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 12);
            this.label2.TabIndex = 8;
            this.label2.Text = "3.Import CSV and Do it:";
            // 
            // CSVFilePath
            // 
            this.CSVFilePath.AutoSize = true;
            this.CSVFilePath.Location = new System.Drawing.Point(126, 67);
            this.CSVFilePath.Name = "CSVFilePath";
            this.CSVFilePath.Size = new System.Drawing.Size(68, 12);
            this.CSVFilePath.TabIndex = 9;
            this.CSVFilePath.Text = "CSV file path";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 12);
            this.label4.TabIndex = 10;
            this.label4.Text = "2.Open  and modify:";
            // 
            // OpenCSV
            // 
            this.OpenCSV.Location = new System.Drawing.Point(447, 55);
            this.OpenCSV.Name = "OpenCSV";
            this.OpenCSV.Size = new System.Drawing.Size(105, 37);
            this.OpenCSV.TabIndex = 11;
            this.OpenCSV.Text = "Open and modify";
            this.OpenCSV.UseVisualStyleBackColor = true;
            this.OpenCSV.Click += new System.EventHandler(this.OpenCSV_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 194);
            this.Controls.Add(this.OpenCSV);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CSVFilePath);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.CSVFilePath2);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.Import);
            this.Controls.Add(this.Brows);
            this.Controls.Add(this.BrowsFolder);
            this.Name = "Form1";
            this.Text = "LoadPull_Change_Name";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox BrowsFolder;
        private System.Windows.Forms.Button Brows;
        private System.Windows.Forms.Button Import;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.TextBox CSVFilePath2;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label CSVFilePath;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button OpenCSV;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

