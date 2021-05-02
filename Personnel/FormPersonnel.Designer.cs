namespace ERP_Programming
{
    partial class FormPersonnel
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
            this.components = new System.ComponentModel.Container();
            this.comboBoxEmpSearch = new System.Windows.Forms.ComboBox();
            this.textBoxEmpSearch = new System.Windows.Forms.TextBox();
            this.buttonEmpSearch = new System.Windows.Forms.Button();
            this.listViewEmp = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStripEmp = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.수정ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.삭제ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.출근기록보기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.급여내역ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.buttonDptAdd = new System.Windows.Forms.Button();
            this.listViewDpt = new System.Windows.Forms.ListView();
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStripDpt = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.수정ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.삭제ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonEmpReset = new System.Windows.Forms.Button();
            this.textBoxEmpZoneCode = new System.Windows.Forms.TextBox();
            this.textBoxEmpDetailAdr = new System.Windows.Forms.TextBox();
            this.buttonAdrSearch = new System.Windows.Forms.Button();
            this.comboBoxEmpGender = new System.Windows.Forms.ComboBox();
            this.labelEmpNum = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBoxEmpPos = new System.Windows.Forms.ComboBox();
            this.comboBoxEmpDpt = new System.Windows.Forms.ComboBox();
            this.dateTimePickerEmpJoin = new System.Windows.Forms.DateTimePicker();
            this.buttonEmpAdd = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxEmpPhone = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxEmpAdr = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxEmpAge = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxEmpName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.contextMenuStripEmp.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.contextMenuStripDpt.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxEmpSearch
            // 
            this.comboBoxEmpSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEmpSearch.FormattingEnabled = true;
            this.comboBoxEmpSearch.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.comboBoxEmpSearch.Items.AddRange(new object[] {
            "사원번호",
            "이름",
            "나이",
            "주소",
            "성별",
            "부서",
            "직책"});
            this.comboBoxEmpSearch.Location = new System.Drawing.Point(25, 34);
            this.comboBoxEmpSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxEmpSearch.Name = "comboBoxEmpSearch";
            this.comboBoxEmpSearch.Size = new System.Drawing.Size(95, 23);
            this.comboBoxEmpSearch.TabIndex = 15;
            // 
            // textBoxEmpSearch
            // 
            this.textBoxEmpSearch.Location = new System.Drawing.Point(126, 34);
            this.textBoxEmpSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxEmpSearch.Name = "textBoxEmpSearch";
            this.textBoxEmpSearch.Size = new System.Drawing.Size(123, 25);
            this.textBoxEmpSearch.TabIndex = 16;
            // 
            // buttonEmpSearch
            // 
            this.buttonEmpSearch.Location = new System.Drawing.Point(255, 34);
            this.buttonEmpSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonEmpSearch.Name = "buttonEmpSearch";
            this.buttonEmpSearch.Size = new System.Drawing.Size(67, 25);
            this.buttonEmpSearch.TabIndex = 17;
            this.buttonEmpSearch.Text = "검색";
            this.buttonEmpSearch.UseVisualStyleBackColor = true;
            this.buttonEmpSearch.Click += new System.EventHandler(this.buttonEmpSearch_Click);
            // 
            // listViewEmp
            // 
            this.listViewEmp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listViewEmp.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9});
            this.listViewEmp.ContextMenuStrip = this.contextMenuStripEmp;
            this.listViewEmp.FullRowSelect = true;
            this.listViewEmp.HideSelection = false;
            this.listViewEmp.Location = new System.Drawing.Point(25, 65);
            this.listViewEmp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listViewEmp.MultiSelect = false;
            this.listViewEmp.Name = "listViewEmp";
            this.listViewEmp.Size = new System.Drawing.Size(861, 573);
            this.listViewEmp.TabIndex = 18;
            this.listViewEmp.UseCompatibleStateImageBehavior = false;
            this.listViewEmp.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "사원번호";
            this.columnHeader1.Width = 74;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "이름";
            this.columnHeader2.Width = 55;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "나이";
            this.columnHeader3.Width = 45;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "주소";
            this.columnHeader4.Width = 230;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "성별";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "부서";
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "직책";
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "휴대전화";
            this.columnHeader8.Width = 90;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "입사일";
            this.columnHeader9.Width = 80;
            // 
            // contextMenuStripEmp
            // 
            this.contextMenuStripEmp.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStripEmp.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.수정ToolStripMenuItem,
            this.삭제ToolStripMenuItem,
            this.출근기록보기ToolStripMenuItem,
            this.급여내역ToolStripMenuItem});
            this.contextMenuStripEmp.Name = "contextMenuStrip1";
            this.contextMenuStripEmp.Size = new System.Drawing.Size(139, 100);
            // 
            // 수정ToolStripMenuItem
            // 
            this.수정ToolStripMenuItem.Name = "수정ToolStripMenuItem";
            this.수정ToolStripMenuItem.Size = new System.Drawing.Size(138, 24);
            this.수정ToolStripMenuItem.Text = "수정";
            this.수정ToolStripMenuItem.Click += new System.EventHandler(this.수정ToolStripMenuItem_Click);
            // 
            // 삭제ToolStripMenuItem
            // 
            this.삭제ToolStripMenuItem.Name = "삭제ToolStripMenuItem";
            this.삭제ToolStripMenuItem.Size = new System.Drawing.Size(138, 24);
            this.삭제ToolStripMenuItem.Text = "삭제";
            this.삭제ToolStripMenuItem.Click += new System.EventHandler(this.삭제ToolStripMenuItem_Click);
            // 
            // 출근기록보기ToolStripMenuItem
            // 
            this.출근기록보기ToolStripMenuItem.Name = "출근기록보기ToolStripMenuItem";
            this.출근기록보기ToolStripMenuItem.Size = new System.Drawing.Size(138, 24);
            this.출근기록보기ToolStripMenuItem.Text = "출근기록";
            this.출근기록보기ToolStripMenuItem.Click += new System.EventHandler(this.출근기록보기ToolStripMenuItem_Click);
            // 
            // 급여내역ToolStripMenuItem
            // 
            this.급여내역ToolStripMenuItem.Name = "급여내역ToolStripMenuItem";
            this.급여내역ToolStripMenuItem.Size = new System.Drawing.Size(138, 24);
            this.급여내역ToolStripMenuItem.Text = "급여내역";
            this.급여내역ToolStripMenuItem.Click += new System.EventHandler(this.급여내역ToolStripMenuItem_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.comboBoxEmpSearch);
            this.groupBox3.Controls.Add(this.listViewEmp);
            this.groupBox3.Controls.Add(this.textBoxEmpSearch);
            this.groupBox3.Controls.Add(this.buttonEmpSearch);
            this.groupBox3.Location = new System.Drawing.Point(363, 19);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(907, 654);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "사원 목록";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.buttonDptAdd);
            this.groupBox4.Controls.Add(this.listViewDpt);
            this.groupBox4.Location = new System.Drawing.Point(14, 19);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Size = new System.Drawing.Size(343, 252);
            this.groupBox4.TabIndex = 21;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "부서 목록";
            // 
            // buttonDptAdd
            // 
            this.buttonDptAdd.Location = new System.Drawing.Point(25, 192);
            this.buttonDptAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonDptAdd.Name = "buttonDptAdd";
            this.buttonDptAdd.Size = new System.Drawing.Size(293, 38);
            this.buttonDptAdd.TabIndex = 24;
            this.buttonDptAdd.Text = "추가";
            this.buttonDptAdd.UseVisualStyleBackColor = true;
            this.buttonDptAdd.Click += new System.EventHandler(this.buttonDptAdd_Click);
            // 
            // listViewDpt
            // 
            this.listViewDpt.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12,
            this.columnHeader13});
            this.listViewDpt.ContextMenuStrip = this.contextMenuStripDpt;
            this.listViewDpt.FullRowSelect = true;
            this.listViewDpt.HideSelection = false;
            this.listViewDpt.Location = new System.Drawing.Point(25, 34);
            this.listViewDpt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listViewDpt.MultiSelect = false;
            this.listViewDpt.Name = "listViewDpt";
            this.listViewDpt.Size = new System.Drawing.Size(292, 152);
            this.listViewDpt.TabIndex = 23;
            this.listViewDpt.UseCompatibleStateImageBehavior = false;
            this.listViewDpt.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "순번";
            this.columnHeader10.Width = 50;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "부서명";
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "부서장";
            this.columnHeader12.Width = 65;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "부서장번호";
            this.columnHeader13.Width = 75;
            // 
            // contextMenuStripDpt
            // 
            this.contextMenuStripDpt.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStripDpt.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.수정ToolStripMenuItem1,
            this.삭제ToolStripMenuItem1});
            this.contextMenuStripDpt.Name = "contextMenuStripDpt";
            this.contextMenuStripDpt.Size = new System.Drawing.Size(109, 52);
            // 
            // 수정ToolStripMenuItem1
            // 
            this.수정ToolStripMenuItem1.Name = "수정ToolStripMenuItem1";
            this.수정ToolStripMenuItem1.Size = new System.Drawing.Size(108, 24);
            this.수정ToolStripMenuItem1.Text = "수정";
            this.수정ToolStripMenuItem1.Click += new System.EventHandler(this.수정ToolStripMenuItem1_Click);
            // 
            // 삭제ToolStripMenuItem1
            // 
            this.삭제ToolStripMenuItem1.Name = "삭제ToolStripMenuItem1";
            this.삭제ToolStripMenuItem1.Size = new System.Drawing.Size(108, 24);
            this.삭제ToolStripMenuItem1.Text = "삭제";
            this.삭제ToolStripMenuItem1.Click += new System.EventHandler(this.삭제ToolStripMenuItem1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonEmpReset);
            this.groupBox1.Controls.Add(this.textBoxEmpZoneCode);
            this.groupBox1.Controls.Add(this.textBoxEmpDetailAdr);
            this.groupBox1.Controls.Add(this.buttonAdrSearch);
            this.groupBox1.Controls.Add(this.comboBoxEmpGender);
            this.groupBox1.Controls.Add(this.labelEmpNum);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.comboBoxEmpPos);
            this.groupBox1.Controls.Add(this.comboBoxEmpDpt);
            this.groupBox1.Controls.Add(this.dateTimePickerEmpJoin);
            this.groupBox1.Controls.Add(this.buttonEmpAdd);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.textBoxEmpPhone);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBoxEmpAdr);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBoxEmpAge);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBoxEmpName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(14, 276);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(343, 396);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "사원 등록";
            // 
            // buttonEmpReset
            // 
            this.buttonEmpReset.Location = new System.Drawing.Point(232, 27);
            this.buttonEmpReset.Name = "buttonEmpReset";
            this.buttonEmpReset.Size = new System.Drawing.Size(86, 29);
            this.buttonEmpReset.TabIndex = 19;
            this.buttonEmpReset.Text = "초기화";
            this.buttonEmpReset.UseVisualStyleBackColor = true;
            this.buttonEmpReset.Click += new System.EventHandler(this.buttonEmpReset_Click);
            // 
            // textBoxEmpZoneCode
            // 
            this.textBoxEmpZoneCode.Location = new System.Drawing.Point(232, 152);
            this.textBoxEmpZoneCode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxEmpZoneCode.Name = "textBoxEmpZoneCode";
            this.textBoxEmpZoneCode.Size = new System.Drawing.Size(86, 25);
            this.textBoxEmpZoneCode.TabIndex = 25;
            this.textBoxEmpZoneCode.Text = "우편번호";
            // 
            // textBoxEmpDetailAdr
            // 
            this.textBoxEmpDetailAdr.Location = new System.Drawing.Point(93, 152);
            this.textBoxEmpDetailAdr.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxEmpDetailAdr.Name = "textBoxEmpDetailAdr";
            this.textBoxEmpDetailAdr.Size = new System.Drawing.Size(132, 25);
            this.textBoxEmpDetailAdr.TabIndex = 24;
            this.textBoxEmpDetailAdr.Text = "상세주소";
            // 
            // buttonAdrSearch
            // 
            this.buttonAdrSearch.Location = new System.Drawing.Point(232, 121);
            this.buttonAdrSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonAdrSearch.Name = "buttonAdrSearch";
            this.buttonAdrSearch.Size = new System.Drawing.Size(86, 29);
            this.buttonAdrSearch.TabIndex = 23;
            this.buttonAdrSearch.Text = "검색";
            this.buttonAdrSearch.UseVisualStyleBackColor = true;
            this.buttonAdrSearch.Click += new System.EventHandler(this.buttonAdrSearch_Click);
            // 
            // comboBoxEmpGender
            // 
            this.comboBoxEmpGender.FormattingEnabled = true;
            this.comboBoxEmpGender.Items.AddRange(new object[] {
            "남자",
            "여자"});
            this.comboBoxEmpGender.Location = new System.Drawing.Point(93, 184);
            this.comboBoxEmpGender.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxEmpGender.Name = "comboBoxEmpGender";
            this.comboBoxEmpGender.Size = new System.Drawing.Size(132, 23);
            this.comboBoxEmpGender.TabIndex = 22;
            // 
            // labelEmpNum
            // 
            this.labelEmpNum.AutoSize = true;
            this.labelEmpNum.Location = new System.Drawing.Point(90, 34);
            this.labelEmpNum.Name = "labelEmpNum";
            this.labelEmpNum.Size = new System.Drawing.Size(63, 15);
            this.labelEmpNum.TabIndex = 21;
            this.labelEmpNum.Text = "0000000";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(23, 34);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 15);
            this.label9.TabIndex = 20;
            this.label9.Text = "사원번호";
            // 
            // comboBoxEmpPos
            // 
            this.comboBoxEmpPos.FormattingEnabled = true;
            this.comboBoxEmpPos.Location = new System.Drawing.Point(93, 244);
            this.comboBoxEmpPos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxEmpPos.Name = "comboBoxEmpPos";
            this.comboBoxEmpPos.Size = new System.Drawing.Size(132, 23);
            this.comboBoxEmpPos.TabIndex = 19;
            // 
            // comboBoxEmpDpt
            // 
            this.comboBoxEmpDpt.FormattingEnabled = true;
            this.comboBoxEmpDpt.Location = new System.Drawing.Point(93, 214);
            this.comboBoxEmpDpt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxEmpDpt.Name = "comboBoxEmpDpt";
            this.comboBoxEmpDpt.Size = new System.Drawing.Size(132, 23);
            this.comboBoxEmpDpt.TabIndex = 18;
            // 
            // dateTimePickerEmpJoin
            // 
            this.dateTimePickerEmpJoin.Location = new System.Drawing.Point(93, 304);
            this.dateTimePickerEmpJoin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePickerEmpJoin.Name = "dateTimePickerEmpJoin";
            this.dateTimePickerEmpJoin.Size = new System.Drawing.Size(225, 25);
            this.dateTimePickerEmpJoin.TabIndex = 17;
            // 
            // buttonEmpAdd
            // 
            this.buttonEmpAdd.Location = new System.Drawing.Point(25, 346);
            this.buttonEmpAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonEmpAdd.Name = "buttonEmpAdd";
            this.buttonEmpAdd.Size = new System.Drawing.Size(293, 38);
            this.buttonEmpAdd.TabIndex = 16;
            this.buttonEmpAdd.Text = "추가";
            this.buttonEmpAdd.UseVisualStyleBackColor = true;
            this.buttonEmpAdd.Click += new System.EventHandler(this.buttonEmpAdd_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 309);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 15);
            this.label8.TabIndex = 14;
            this.label8.Text = "입사일";
            // 
            // textBoxEmpPhone
            // 
            this.textBoxEmpPhone.Location = new System.Drawing.Point(93, 274);
            this.textBoxEmpPhone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxEmpPhone.Name = "textBoxEmpPhone";
            this.textBoxEmpPhone.Size = new System.Drawing.Size(132, 25);
            this.textBoxEmpPhone.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 278);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 15);
            this.label7.TabIndex = 12;
            this.label7.Text = "휴대전화";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 248);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "직책";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 218);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "부서";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "성별";
            // 
            // textBoxEmpAdr
            // 
            this.textBoxEmpAdr.Location = new System.Drawing.Point(93, 121);
            this.textBoxEmpAdr.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxEmpAdr.Name = "textBoxEmpAdr";
            this.textBoxEmpAdr.Size = new System.Drawing.Size(132, 25);
            this.textBoxEmpAdr.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "주소";
            // 
            // textBoxEmpAge
            // 
            this.textBoxEmpAge.Location = new System.Drawing.Point(93, 91);
            this.textBoxEmpAge.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxEmpAge.Name = "textBoxEmpAge";
            this.textBoxEmpAge.Size = new System.Drawing.Size(132, 25);
            this.textBoxEmpAge.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "나이";
            // 
            // textBoxEmpName
            // 
            this.textBoxEmpName.Location = new System.Drawing.Point(93, 60);
            this.textBoxEmpName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxEmpName.Name = "textBoxEmpName";
            this.textBoxEmpName.Size = new System.Drawing.Size(132, 25);
            this.textBoxEmpName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "이름";
            // 
            // FormPersonnel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1288, 682);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormPersonnel";
            this.Text = "인사";
            this.contextMenuStripEmp.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.contextMenuStripDpt.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBoxEmpSearch;
        private System.Windows.Forms.TextBox textBoxEmpSearch;
        private System.Windows.Forms.Button buttonEmpSearch;
        private System.Windows.Forms.ListView listViewEmp;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripEmp;
        private System.Windows.Forms.ToolStripMenuItem 수정ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 출근기록보기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 급여내역ToolStripMenuItem;
        private System.Windows.Forms.ListView listViewDpt;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.Button buttonDptAdd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonAdrSearch;
        private System.Windows.Forms.ComboBox comboBoxEmpGender;
        private System.Windows.Forms.Label labelEmpNum;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBoxEmpPos;
        private System.Windows.Forms.ComboBox comboBoxEmpDpt;
        private System.Windows.Forms.DateTimePicker dateTimePickerEmpJoin;
        private System.Windows.Forms.Button buttonEmpAdd;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxEmpPhone;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxEmpAdr;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxEmpAge;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxEmpName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxEmpDetailAdr;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripDpt;
        private System.Windows.Forms.ToolStripMenuItem 수정ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 삭제ToolStripMenuItem1;
        private System.Windows.Forms.TextBox textBoxEmpZoneCode;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.Button buttonEmpReset;
        private System.Windows.Forms.ToolStripMenuItem 삭제ToolStripMenuItem;
    }
}

