using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace logReader
{
    public partial class Form1 : Form
    {
        public IFormatProvider KR_Format { get; private set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] jcode = { "1234", "0001" };
            string[] ecode = { "Ping fail!", "Target server change" };
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

        private string setRangeDate()
        {
            DateTime rangeDate = new DateTime();
            // 0 : 오늘 , 1: 일주일 , 2: 한달
            switch (dateRange.Value)
            {
                case 0:
                    rangeDate = DateTime.Now;
                    break;
                case 1:
                    rangeDate = DateTime.Now.AddDays(-7);
                    break;
                case 2:
                    rangeDate = DateTime.Now.AddDays(-30);
                    break;
            }
            return rangeDate.ToString("yyyyMMdd");
        }
        private void itemAdd(FileInfo logFile, string date, string pnum, ref int no)
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
            DateTime parseDate = DateTime.ParseExact(date, "yyyyMMdd", KR_Format);
            string transDate = parseDate.ToShortDateString();
            ListViewItem lvi = new ListViewItem(no.ToString());
            lvi.SubItems.Add(transDate);
            lvi.SubItems.Add(jcodeBox.Text);
            lvi.SubItems.Add("본점");
            lvi.SubItems.Add(pnum);
            lvi.SubItems.Add(keywordBox.Text);
            lvi.SubItems.Add(searchCount.ToString());
            searchList.Items.Add(lvi);
            no++;
        }


        private void ReadLogFile(DirectoryInfo di, string pnum, ref int no)
        {

            /*
             *  >String -> Datetime -> 2019-12-21
             *  DateTime parseDate = DateTime.ParseExact("2019-12-21", "yyyyMMdd", KR_Format);
             *  transDate = parseDate.ToShortDateString();
             *  
             *  >DateTime -> yyyyMMdd > int 
             *   DateTime rangeDate = new DateTime();
             *   rangeDate.ToString("yyyyMMdd");
             *   int rDate = Convert.ToInt32(rangeDate);
             *   
             */
            string date = string.Empty;
            string rangeDate = setRangeDate();
            Regex regex = new Regex(@"^PosLog_20[0-9]{6}.log");
            
            int rDate = Convert.ToInt32(rangeDate);
            int tDate = Convert.ToInt32(DateTime.Now.ToString("yyyyMMdd"));

            ArrayList logFileList = new ArrayList();


            //땡땡번호(폴더)안에 있는 모든 파일 읽을때까지 반복
            foreach (var logFile in di.GetFiles())
            {
                if (regex.IsMatch(logFile.Name))
                {
                    date = logFile.Name.Substring(7, 8);
                    int lDate = Convert.ToInt32(date);
                    if (rDate == lDate && lDate == tDate)
                    {
                        itemAdd(logFile, date, pnum, ref no);
                    }else if ((tDate - rDate == 7) && rDate <= lDate )
                    {
                        itemAdd(logFile, date, pnum, ref no);
                    }else if ((tDate-rDate == 100) && rDate <= lDate )
                    {
                        Console.WriteLine("30일");
                        itemAdd(logFile, date, pnum, ref no);
                    }
                }
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
                    ReadLogFile(di, pFolder.Name, ref no);
                }
            }
            //땡땡번호가 입력된 경우
            else
            {
                int pnum;
                if (!int.TryParse(pnumber.Text, out pnum))
                {
                    MessageBox.Show("숫자만 입력가능합니다.");
                    return;
                }
                else
                {
                    string dirPath = @"C:\winformTest\" + jcodeBox.Text + @"\assemble\" + pnumber.Text;
                    if (Directory.Exists(dirPath)) {
                        DirectoryInfo di = new DirectoryInfo(dirPath); //pFolder 안에있는 경로로 재설정
                        int no = 1; //검색건수 넘버링 cf)전체폴더의 파일넘버링
                        ReadLogFile(di, pnumber.Text,ref no);
                    }
                    else
                    {
                        MessageBox.Show("해당 땡땡번호가 없습니다.");
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
