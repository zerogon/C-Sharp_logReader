namespace logReader
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.searchList = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.jcodeBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.keywordBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.startDate = new System.Windows.Forms.DateTimePicker();
            this.endDate = new System.Windows.Forms.DateTimePicker();
            this.startDateLabel = new System.Windows.Forms.Label();
            this.endDateLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dateRange = new System.Windows.Forms.TrackBar();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.date1 = new System.Windows.Forms.Label();
            this.date2 = new System.Windows.Forms.Label();
            this.date3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.pnumber = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dateRange)).BeginInit();
            this.SuspendLayout();
            // 
            // searchList
            // 
            this.searchList.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.searchList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.searchList.GridLines = true;
            this.searchList.HideSelection = false;
            this.searchList.Location = new System.Drawing.Point(11, 116);
            this.searchList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchList.Name = "searchList";
            this.searchList.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.searchList.Size = new System.Drawing.Size(806, 415);
            this.searchList.TabIndex = 0;
            this.searchList.UseCompatibleStateImageBehavior = false;
            this.searchList.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "No.";
            this.columnHeader1.Width = 40;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "날짜";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 120;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "코드";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 70;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "이름";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "땡떙번호";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader5.Width = 80;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "내용";
            this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader6.Width = 230;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "발생횟수";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(280, 59);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(173, 29);
            this.progressBar1.TabIndex = 3;
            // 
            // jcodeBox
            // 
            this.jcodeBox.FormattingEnabled = true;
            this.jcodeBox.IntegralHeight = false;
            this.jcodeBox.ItemHeight = 15;
            this.jcodeBox.Location = new System.Drawing.Point(94, 25);
            this.jcodeBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.jcodeBox.Name = "jcodeBox";
            this.jcodeBox.Size = new System.Drawing.Size(101, 23);
            this.jcodeBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "코드 : ";
            // 
            // keywordBox
            // 
            this.keywordBox.FormattingEnabled = true;
            this.keywordBox.IntegralHeight = false;
            this.keywordBox.ItemHeight = 15;
            this.keywordBox.Location = new System.Drawing.Point(280, 26);
            this.keywordBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.keywordBox.Name = "keywordBox";
            this.keywordBox.Size = new System.Drawing.Size(172, 23);
            this.keywordBox.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(217, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "검색명 :";
            // 
            // startDate
            // 
            this.startDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.startDate.Location = new System.Drawing.Point(559, 44);
            this.startDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.startDate.Name = "startDate";
            this.startDate.Size = new System.Drawing.Size(119, 25);
            this.startDate.TabIndex = 8;
            this.startDate.Visible = false;
            // 
            // endDate
            // 
            this.endDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.endDate.Location = new System.Drawing.Point(559, 78);
            this.endDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.endDate.Name = "endDate";
            this.endDate.Size = new System.Drawing.Size(119, 25);
            this.endDate.TabIndex = 9;
            this.endDate.Visible = false;
            // 
            // startDateLabel
            // 
            this.startDateLabel.AutoSize = true;
            this.startDateLabel.Location = new System.Drawing.Point(501, 51);
            this.startDateLabel.Name = "startDateLabel";
            this.startDateLabel.Size = new System.Drawing.Size(57, 15);
            this.startDateLabel.TabIndex = 10;
            this.startDateLabel.Text = "시작일:";
            this.startDateLabel.Visible = false;
            // 
            // endDateLabel
            // 
            this.endDateLabel.AutoSize = true;
            this.endDateLabel.Location = new System.Drawing.Point(501, 84);
            this.endDateLabel.Name = "endDateLabel";
            this.endDateLabel.Size = new System.Drawing.Size(57, 15);
            this.endDateLabel.TabIndex = 11;
            this.endDateLabel.Text = "종료일:";
            this.endDateLabel.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(722, 22);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(74, 46);
            this.button1.TabIndex = 12;
            this.button1.Text = "검색";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dateRange
            // 
            this.dateRange.LargeChange = 1;
            this.dateRange.Location = new System.Drawing.Point(501, 41);
            this.dateRange.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateRange.Maximum = 2;
            this.dateRange.Name = "dateRange";
            this.dateRange.Size = new System.Drawing.Size(186, 56);
            this.dateRange.TabIndex = 13;
            this.dateRange.Scroll += new System.EventHandler(this.dateRange_Scroll);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(490, 14);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(124, 19);
            this.checkBox1.TabIndex = 14;
            this.checkBox1.Text = "특정 기간선택";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // date1
            // 
            this.date1.AutoSize = true;
            this.date1.Location = new System.Drawing.Point(498, 82);
            this.date1.Name = "date1";
            this.date1.Size = new System.Drawing.Size(37, 15);
            this.date1.TabIndex = 15;
            this.date1.Text = "오늘";
            // 
            // date2
            // 
            this.date2.AutoSize = true;
            this.date2.Location = new System.Drawing.Point(571, 82);
            this.date2.Name = "date2";
            this.date2.Size = new System.Drawing.Size(52, 15);
            this.date2.TabIndex = 16;
            this.date2.Text = "일주일";
            // 
            // date3
            // 
            this.date3.AutoSize = true;
            this.date3.Location = new System.Drawing.Point(657, 84);
            this.date3.Name = "date3";
            this.date3.Size = new System.Drawing.Size(37, 15);
            this.date3.TabIndex = 17;
            this.date3.Text = "한달";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(709, 74);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(99, 35);
            this.button2.TabIndex = 18;
            this.button2.Text = "엑셀로 저장";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 15);
            this.label3.TabIndex = 19;
            this.label3.Text = "땡땡번호 :";
            // 
            // pnumber
            // 
            this.pnumber.Location = new System.Drawing.Point(94, 64);
            this.pnumber.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnumber.Name = "pnumber";
            this.pnumber.Size = new System.Drawing.Size(101, 25);
            this.pnumber.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(217, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 15);
            this.label4.TabIndex = 21;
            this.label4.Text = "진행도 :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 542);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pnumber);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.date3);
            this.Controls.Add(this.date2);
            this.Controls.Add(this.date1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.dateRange);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.endDateLabel);
            this.Controls.Add(this.startDateLabel);
            this.Controls.Add(this.endDate);
            this.Controls.Add(this.startDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.keywordBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.jcodeBox);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.searchList);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "logReader";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dateRange)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView searchList;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ComboBox jcodeBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox keywordBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker startDate;
        private System.Windows.Forms.DateTimePicker endDate;
        private System.Windows.Forms.Label startDateLabel;
        private System.Windows.Forms.Label endDateLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TrackBar dateRange;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label date1;
        private System.Windows.Forms.Label date2;
        private System.Windows.Forms.Label date3;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox pnumber;
        private System.Windows.Forms.Label label4;
    }
}

