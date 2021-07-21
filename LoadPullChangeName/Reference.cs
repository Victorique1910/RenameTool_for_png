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

namespace LoadPullChangeName
{
    public partial class Form1 : Form
    {

        public bool SaveCSV(string filepath, DataTable table)
        {
            FileStream fs = new FileStream(filepath, System.IO.FileMode.Create, System.IO.FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs, System.Text.Encoding.Default);
            int rowCount = 0;
            bool isFirst = true;                    //這筆資料的第一行        

            while (rowCount < table.Rows.Count)
            {

                string temp = "";

                if (isFirst)
                {
                    for (int i = 0; i < table.Columns.Count; i++)
                    {
                        temp += table.Columns[i].ColumnName.ToString();

                        if (i < table.Columns.Count - 1)
                        {
                            temp += ",";
                        }
                    }
                    isFirst = false;
                    rowCount = rowCount - 1;       //技術使標題加入
                }
                else
                {
                    for (int i = 0; i < table.Columns.Count; i++)
                    {
                        temp += table.Rows[rowCount][i].ToString();

                        if (i < table.Columns.Count - 1)
                        {
                            temp += ",";
                        }
                    }
                }
                sw.WriteLine(temp);
                rowCount = rowCount + 1;
            }

            sw.Close();
            fs.Close();

            return true;
        }
    }
}