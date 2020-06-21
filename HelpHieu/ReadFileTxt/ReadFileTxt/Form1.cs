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

namespace ReadFileTxt
{
    public partial class Form1 : Form
    {
        DataTable dt = new DataTable();
        OpenFileDialog openFile = new OpenFileDialog();
        FileStream fs;
        StreamReader tr;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                #region code cu
                //// Doc ghi het toi thoi diem hien tai
                //StreamReader sr = new StreamReader(openFile.FileName);
                //while (line != null)
                //{
                //    line = sr.ReadLine();
                //    if (line != null)
                //    {
                //        // chia line thanh 3 gia tri
                //        string[] words = line.Split(' ');

                //        // khoi tao row moi
                //        var row = dt.NewRow();
                //        row["Value"] = words[0];
                //        row["Time"] = words[1];
                //        row["Date"] = words[2];

                //        // add row to top table
                //        dt.Rows.InsertAt(row, 0);
                //    }

                //}
                //sr.Close();
                #endregion

                fileSystemWatcher1.Path = Path.GetDirectoryName(openFile.FileName);
                fs = new FileStream(openFile.FileName, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
                tr = new StreamReader(fs);
                string line;
                while ((line = tr.ReadLine()) != null)
                {
                    // chia line thanh 3 gia tri
                    string[] words = line.Split(' ');

                    // khoi tao row moi
                    var row = dt.NewRow();
                    row["Value"] = words[0];
                    row["Time"] = words[1];
                    row["Date"] = words[2];

                    // add row to top table
                    dt.Rows.InsertAt(row, 0);
                }

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Khoi tao bang
            dt.Columns.Add("Value");
            dt.Columns.Add("Time");
            dt.Columns.Add("Date");
            dataGridView1.DataSource = dt;

            openFile.Filter = "Text Files (.txt) | *.txt";
        }

        private void fileSystemWatcher1_Changed(object sender, FileSystemEventArgs e)
        {
            string line;
            line = tr.ReadLine();
            if (!String.IsNullOrEmpty(line))
            {

                // chia line thanh 3 gia tri
                string[] words = line.Split(' ');

                // khoi tao row moi
                var row = dt.NewRow();
                row["Value"] = words[0];
                row["Time"] = words[1];
                row["Date"] = words[2];

                // add row to top table
                dt.Rows.InsertAt(row, 0);
            }

        }
    }
}
