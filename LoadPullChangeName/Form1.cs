using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Collections;
namespace LoadPullChangeName
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Brows_Click(object sender, EventArgs e)
        {
            //0.定義參數
            string folderName = null;                                 //圖片資料夾名稱
            List<string> pictureName = new List<string>();            //紀錄原始圖片名稱
            DataTable table = new DataTable();                        //合併原始圖片名稱及路徑成Table

            //1.取得圖片資料夾位置            
            if(BrowsFolder.Text == "")                              //判斷是否有位置
            {
                FolderBrowserDialog fbd = new FolderBrowserDialog();
                fbd.ShowDialog();

                BrowsFolder.Text = fbd.SelectedPath;               
            }
            folderName = BrowsFolder.Text;
            //2.取得圖片檔名
            if (Directory.Exists(folderName))                                                   //判斷是否存在資料夾
            {
                DirectoryInfo di = new DirectoryInfo(folderName);                               //定義所有子資料夾
                foreach (FileInfo nextFile in di.GetFiles("*.*", SearchOption.AllDirectories))  //收尋所有子資料夾
                {                   
                    if (Path.GetExtension(nextFile.Name) == ".PNG" || Path.GetExtension(nextFile.Name) == ".png")  //判斷副檔名是否為.png
                    {  
                        pictureName.Add(Path.GetFileNameWithoutExtension(nextFile.Name));       //紀錄原始圖片名稱                       
                    }
                }
            }
            //3.存成table
            bool isFirst = true;          //判斷這筆資料是否為第一行
            int tableCount = 0;           //計數第幾列
            List<string> headLine = new List<string>() { "Name", "ChangeName" };  //設定標頭

            while (tableCount < pictureName.Count)                    //判斷是否超過資料上限
            {
                if (isFirst)                                          //紀錄DataColumn
                {
                    for (int q = 0; q < headLine.Count; q++)
                    {
                        DataColumn dc = new DataColumn(headLine[q]);

                        table.Columns.Add(dc);
                    }
                    isFirst = false;
                }
                else
                {
                    DataRow dr = table.NewRow();                     //紀錄DataRow
                    for (int j = 0; j < headLine.Count; j++) 
                    {
                        dr["Name"] = pictureName[tableCount];                                            
                    }
                    table.Rows.Add(dr);
                    tableCount += 1;
                }
            }
            //4.存成CSV黨
            SaveCSV(Path.Combine(folderName,"test.csv"),table);      //存成CSV黨
            //5.將BrowsFolder.Text=CSVFilePath
            if(folderName != "")
            {
                CSVFilePath.Text = Path.Combine(folderName, "test.csv");
            }            
        }

        private void OpenCSV_Click(object sender, EventArgs e)
        {
            //1.Open CSVFile(打開CSV檔)
            string myPath = CSVFilePath.Text;
            System.Diagnostics.Process prc = new System.Diagnostics.Process();
            prc.StartInfo.FileName = myPath;
            prc.Start();
            //2.將CSVFilePath2=CSVFilePath
            CSVFilePath2.Text = CSVFilePath.Text;
        }

        private void Import_Click(object sender, EventArgs e)
        {
            //0.定義參數
            List<string> pictureName = new List<string>();    //紀錄原始圖片名稱           
            List<string> changeName = new List<string>();     //紀錄修改後名稱
            //1.Open CSV(CSVFilePath2=null)
            if (CSVFilePath2.Text == "")                      //如果沒有檔案則開啟檔案
            {
                 OpenFileDialog ofd = new OpenFileDialog();
                 ofd.Filter = "csv files (*.csv)|*.csv";
                 ofd.ShowDialog();
                 CSVFilePath2.Text = ofd.FileName;
            }
            //2.讀CSV黨
            string CSVName = CSVFilePath2.Text;              //CSV檔位置
            string read;                                     //紀錄讀檔資料
            int count = 0;                                   //紀錄行數
            FileStream fs = new FileStream(CSVName, System.IO.FileMode.Open, System.IO.FileAccess.Read);  //使用文件
            StreamReader sr = new StreamReader(fs, System.Text.Encoding.Default);                         //匯入資料

            while((read = sr.ReadLine()) != null)
            {
                string[] temp;
                temp = read.Split(',');

                if(count>0)                                 //第一排忽略標頭
                {
                    pictureName.Add(temp[0]);                   
                    changeName.Add(temp[1]);
                }                
                count += 1;
            }

            //3.檢查是否有重複
            bool repeat = false;
            
            if (changeName.Distinct<string>().Count() < changeName.Count())
            {
                MessageBox.Show("ChangeName Repeat, Please check again.");
                repeat = true;
            }
            
            if (!repeat)                                                                                 //出現重複項結束
            {
                //4.新增資料夾
                string folderName = BrowsFolder.Text;
                Directory.CreateDirectory(Path.Combine(folderName, "new"));

                //5.移動檔案
                if (Directory.Exists(folderName))                                                      //判斷是否存在資料夾
                {
                    DirectoryInfo di = new DirectoryInfo(folderName);                                  //定義所有子資料夾
                    foreach (FileInfo nextFile in di.GetFiles("*.*", SearchOption.AllDirectories))     //收尋所有子資料夾
                    {
                        if (Path.GetExtension(nextFile.Name) == ".PNG" || Path.GetExtension(nextFile.Name) == ".png")  //判斷副檔名是否為.png
                        {
                            for (int i = 0; i < pictureName.Count; i++)                                                         //比對是否為
                            {
                                if (Path.GetFileNameWithoutExtension(nextFile.Name) == pictureName[i])
                                {
                                    File.Move(nextFile.FullName, Path.Combine(folderName, "new", changeName[i] + @".png"));//移動檔案到new
                                    break;
                                }
                            }
                        }
                    }
                }

                MessageBox.Show("Done");
            }
            fs.Close();
            sr.Close();
        }

        private void Clear_Click(object sender, EventArgs e)
        {           
            CSVFilePath.Text = "CSV file path";
            CSVFilePath2.Text = "";
        }

        private void BrowsFolder_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.All;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void BrowsFolder_DragDrop(object sender, DragEventArgs e)
        {
            BrowsFolder.Text = ((string[])e.Data.GetData(DataFormats.FileDrop)).GetValue(0).ToString();
            if (!Directory.Exists(BrowsFolder.Text))
            {
                MessageBox.Show("It is wrong formet. Please input file.");
                BrowsFolder.Text = "";
            }
        }

        private void CSVFilePath2_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.All;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void CSVFilePath2_DragDrop(object sender, DragEventArgs e)
        {
            CSVFilePath2.Text = ((string[])e.Data.GetData(DataFormats.FileDrop)).GetValue(0).ToString();
            if (!File.Exists(CSVFilePath2.Text))
            {
                MessageBox.Show("It is wrong formet. Please input file.");
                CSVFilePath2.Text = "";
            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(System.Environment.ExitCode);
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Environment.Exit(System.Environment.ExitCode);
        }
    }
}
