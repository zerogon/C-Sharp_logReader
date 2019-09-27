using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace logReader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] jcode = { "1234", "0001" };
            string[] ecode = { "ping fail", "1차->2차,2차->1차" };
            jcodeBox.Items.AddRange(jcode);
            jcodeBox.SelectedIndex = 0;
            keywordBox.Items.AddRange(ecode);
            keywordBox.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            searchList.Items.Clear();
            ReadTxt();
        }
        private void ReadTxt()
        {
            List<string> arr = new List<string>();
         
            string dirPath = @"C:\winformTest\" + jcodeBox.Text + @"\assemble\";
                if (Directory.Exists(dirPath))
                {
                    DirectoryInfo di = new DirectoryInfo(dirPath);
                    foreach (var pFolder in di.GetDirectories())
                    {
                        di = new DirectoryInfo(pFolder.FullName);
                        foreach (var txtFile in di.GetFiles())
                        {
                            string[] lines = File.ReadAllLines(txtFile.FullName, Encoding.UTF8);
                            int searchCount = 0;
                            foreach (string line in lines)
                            {
                                if (line.Contains("fail"))
                                {
                                     searchCount++;
                                }
                            }
                            int no = 1;
                            arr.Add("1");
                            arr.Add("20190923");
                            arr.Add(jcodeBox.Text);
                            arr.Add(jcodeBox.Text + '점');
                            arr.Add(pnumber.Text);
                            arr.Add(keywordBox.Text);
                            arr.Add("100");
                        }
                    }
                }
            ListViewItem lvi = new ListViewItem(arr.ToArray());
            searchList.Items.Add(lvi);
        }
            private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (startDate.Visible == false)
            {
                startDate.Visible = true;
                endDate.Visible = true;
                startDateLabel.Visible = true;
                endDateLabel.Visible = true;
                dateRange.Visible = false;
                date1.Visible = false;
                date2.Visible = false;
                date3.Visible = false;
            }
            else
            {
                startDate.Visible = false;
                endDate.Visible = false;
                startDateLabel.Visible = false;
                endDateLabel.Visible = false;
                dateRange.Visible = true;
                date1.Visible = true;
                date2.Visible = true;
                date3.Visible = true;

            }

        }
    }
}
