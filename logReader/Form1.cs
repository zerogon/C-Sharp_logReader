using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
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
            string[] ecode = { "fail", "1차->2차,2차->1차" };
            //콤보박스에 데이터 삽입 후, 1번째 값이 default
            jcodeBox.Items.AddRange(jcode);
            jcodeBox.SelectedIndex = 0;
            keywordBox.Items.AddRange(ecode);
            keywordBox.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            searchList.Items.Clear();
            ReadLog();
        }

        private void ReadLogFile(DirectoryInfo di, int no)
        {
            foreach (var logFile in di.GetFiles())
            {
                string[] lines = File.ReadAllLines(logFile.FullName, Encoding.UTF8);
                int searchCount = 0;
                //해당로그에 검색키워드가 포함되어있는지 반복
                foreach (string line in lines)
                {
                    if (line.Contains(keywordBox.Text))
                    {
                        searchCount++;
                    }
                }
                ListViewItem lvi = new ListViewItem(no.ToString());
                lvi.SubItems.Add("20191009");
                lvi.SubItems.Add(jcodeBox.Text);
                lvi.SubItems.Add("본점");
                lvi.SubItems.Add("땡땡번호");
                lvi.SubItems.Add(keywordBox.Text);
                lvi.SubItems.Add(searchCount.ToString());
                searchList.Items.Add(lvi);
                no++;
            }
        }

        private void ReadLog()
        {
            //숫자아닌 빈값을 넣을경우 -> 전체검색
            if(String.IsNullOrEmpty(pnumber.Text)){
                int no = 1; //검색건수 넘버링
                List<string> arr = new List<string>();
                string dirPath = @"C:\winformTest\" + jcodeBox.Text + @"\assemble\";
                DirectoryInfo di = new DirectoryInfo(dirPath);
                //모든 땡땡번호(폴더) 읽을때까지 반복
                foreach (var pFolder in di.GetDirectories()) //pFolder 하나의 땡떙번호
                {
                    di = new DirectoryInfo(pFolder.FullName); //pFolder 안에있는 경로로 재설정
                    //땡땡번호(폴더)안에 있는 모든 파일 읽을때까지 반복
                    foreach (var logFile in di.GetFiles())
                    {
                        string[] lines = File.ReadAllLines(logFile.FullName, Encoding.UTF8);
                        int searchCount = 0;
                        //해당로그에 검색키워드가 포함되어있는지 반복
                        foreach (string line in lines)
                        {
                            if (line.Contains(keywordBox.Text))
                            {
                                searchCount++;
                            }
                        }
                        ListViewItem lvi = new ListViewItem(no.ToString());
                        lvi.SubItems.Add("20191009");
                        lvi.SubItems.Add(jcodeBox.Text);
                        lvi.SubItems.Add("본점");
                        lvi.SubItems.Add("땡땡번호");
                        lvi.SubItems.Add(keywordBox.Text);
                        lvi.SubItems.Add(searchCount.ToString());
                        searchList.Items.Add(lvi);
                        no++;
                    }
                }
            }
            //땡땡번호가 입력된 경우
            else
            {
                int pnum;
                //숫자가 아닌값이 들어온 경우 return
                if (!int.TryParse(pnumber.Text, out pnum))
                {
                    MessageBox.Show("땡땡번호를 확인하세요.");
                    return;
                }
                else
                {
                    string dirPath = @"C:\winformTest\" + jcodeBox.Text + @"\assemble\" + pnumber.Text;
                    DirectoryInfo di = new DirectoryInfo(dirPath); //pFolder 안에있는 경로로 재설정
                    foreach (var logFile in di.GetFiles())
                    {
                        string[] lines = File.ReadAllLines(logFile.FullName, Encoding.UTF8);
                        int searchCount = 0;
                        //해당로그에 검색키워드가 포함되어있는지 반복
                        foreach (string line in lines)
                        {
                            if (line.Contains(keywordBox.Text))
                            {
                                searchCount++;
                            }
                        }
                        ListViewItem lvi = new ListViewItem(no.ToString());
                        lvi.SubItems.Add("20191009");
                        lvi.SubItems.Add(jcodeBox.Text);
                        lvi.SubItems.Add("본점");
                        lvi.SubItems.Add("땡땡번호");
                        lvi.SubItems.Add(keywordBox.Text);
                        lvi.SubItems.Add(searchCount.ToString());
                        searchList.Items.Add(lvi);
                        no++;
                    }
                }
            }
           
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
