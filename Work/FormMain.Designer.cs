namespace ERP_Programming
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBoxAccountInformation = new System.Windows.Forms.GroupBox();
            this.labelPos = new System.Windows.Forms.Label();
            this.labelDpt = new System.Windows.Forms.Label();
            this.labelAccountName = new System.Windows.Forms.Label();
            this.buttonMessage = new System.Windows.Forms.Button();
            this.groupBoxTaskRegistration = new System.Windows.Forms.GroupBox();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonModify = new System.Windows.Forms.Button();
            this.comboBoxEnd_m = new System.Windows.Forms.ComboBox();
            this.comboBoxEnd_h = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxStart_m = new System.Windows.Forms.ComboBox();
            this.comboBoxStart_h = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePickerWorkDate = new System.Windows.Forms.DateTimePicker();
            this.buttonRegister = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxTaskComment = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxSmallCategory = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxMediumCategory = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxLargeCategory = new System.Windows.Forms.ComboBox();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.comboBoxSearch = new System.Windows.Forms.ComboBox();
            this.listViewWork = new System.Windows.Forms.ListView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.이동ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.인사ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.결제ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.업무마스터ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.커뮤니티ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.사원채팅방ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.로그인ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.로그아웃ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.groupBoxAccountInformation.SuspendLayout();
            this.groupBoxTaskRegistration.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxAccountInformation
            // 
            this.groupBoxAccountInformation.Controls.Add(this.labelPos);
            this.groupBoxAccountInformation.Controls.Add(this.labelDpt);
            this.groupBoxAccountInformation.Controls.Add(this.labelAccountName);
            this.groupBoxAccountInformation.Controls.Add(this.buttonMessage);
            this.groupBoxAccountInformation.Location = new System.Drawing.Point(12, 46);
            this.groupBoxAccountInformation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxAccountInformation.Name = "groupBoxAccountInformation";
            this.groupBoxAccountInformation.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxAccountInformation.Size = new System.Drawing.Size(253, 128);
            this.groupBoxAccountInformation.TabIndex = 0;
            this.groupBoxAccountInformation.TabStop = false;
            this.groupBoxAccountInformation.Text = "내 정보";
            // 
            // labelPos
            // 
            this.labelPos.AutoSize = true;
            this.labelPos.Location = new System.Drawing.Point(22, 83);
            this.labelPos.Name = "labelPos";
            this.labelPos.Size = new System.Drawing.Size(41, 12);
            this.labelPos.TabIndex = 14;
            this.labelPos.Text = "직책 : ";
            // 
            // labelDpt
            // 
            this.labelDpt.AutoSize = true;
            this.labelDpt.Location = new System.Drawing.Point(22, 58);
            this.labelDpt.Name = "labelDpt";
            this.labelDpt.Size = new System.Drawing.Size(41, 12);
            this.labelDpt.TabIndex = 1;
            this.labelDpt.Text = "부서 : ";
            // 
            // labelAccountName
            // 
            this.labelAccountName.AutoSize = true;
            this.labelAccountName.Location = new System.Drawing.Point(22, 31);
            this.labelAccountName.Name = "labelAccountName";
            this.labelAccountName.Size = new System.Drawing.Size(41, 12);
            this.labelAccountName.TabIndex = 0;
            this.labelAccountName.Text = "이름 : ";
            // 
            // buttonMessage
            // 
            this.buttonMessage.Location = new System.Drawing.Point(181, 104);
            this.buttonMessage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonMessage.Name = "buttonMessage";
            this.buttonMessage.Size = new System.Drawing.Size(66, 20);
            this.buttonMessage.TabIndex = 13;
            this.buttonMessage.Text = "쪽지";
            this.buttonMessage.UseVisualStyleBackColor = true;
            this.buttonMessage.Click += new System.EventHandler(this.buttonMessage_Click);
            // 
            // groupBoxTaskRegistration
            // 
            this.groupBoxTaskRegistration.Controls.Add(this.buttonDelete);
            this.groupBoxTaskRegistration.Controls.Add(this.buttonModify);
            this.groupBoxTaskRegistration.Controls.Add(this.comboBoxEnd_m);
            this.groupBoxTaskRegistration.Controls.Add(this.comboBoxEnd_h);
            this.groupBoxTaskRegistration.Controls.Add(this.label6);
            this.groupBoxTaskRegistration.Controls.Add(this.comboBoxStart_m);
            this.groupBoxTaskRegistration.Controls.Add(this.comboBoxStart_h);
            this.groupBoxTaskRegistration.Controls.Add(this.label5);
            this.groupBoxTaskRegistration.Controls.Add(this.dateTimePickerWorkDate);
            this.groupBoxTaskRegistration.Controls.Add(this.buttonRegister);
            this.groupBoxTaskRegistration.Controls.Add(this.label3);
            this.groupBoxTaskRegistration.Controls.Add(this.textBoxTaskComment);
            this.groupBoxTaskRegistration.Controls.Add(this.label2);
            this.groupBoxTaskRegistration.Controls.Add(this.comboBoxSmallCategory);
            this.groupBoxTaskRegistration.Controls.Add(this.label1);
            this.groupBoxTaskRegistration.Controls.Add(this.comboBoxMediumCategory);
            this.groupBoxTaskRegistration.Controls.Add(this.label4);
            this.groupBoxTaskRegistration.Controls.Add(this.comboBoxLargeCategory);
            this.groupBoxTaskRegistration.Location = new System.Drawing.Point(12, 193);
            this.groupBoxTaskRegistration.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxTaskRegistration.Name = "groupBoxTaskRegistration";
            this.groupBoxTaskRegistration.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxTaskRegistration.Size = new System.Drawing.Size(253, 499);
            this.groupBoxTaskRegistration.TabIndex = 1;
            this.groupBoxTaskRegistration.TabStop = false;
            this.groupBoxTaskRegistration.Text = "업무등록";
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(166, 450);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(61, 32);
            this.buttonDelete.TabIndex = 17;
            this.buttonDelete.Text = "삭제";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonModify
            // 
            this.buttonModify.Location = new System.Drawing.Point(96, 450);
            this.buttonModify.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonModify.Name = "buttonModify";
            this.buttonModify.Size = new System.Drawing.Size(61, 32);
            this.buttonModify.TabIndex = 16;
            this.buttonModify.Text = "수정";
            this.buttonModify.UseVisualStyleBackColor = true;
            this.buttonModify.Click += new System.EventHandler(this.buttonModify_Click);
            // 
            // comboBoxEnd_m
            // 
            this.comboBoxEnd_m.FormattingEnabled = true;
            this.comboBoxEnd_m.Location = new System.Drawing.Point(162, 112);
            this.comboBoxEnd_m.Name = "comboBoxEnd_m";
            this.comboBoxEnd_m.Size = new System.Drawing.Size(65, 20);
            this.comboBoxEnd_m.TabIndex = 15;
            // 
            // comboBoxEnd_h
            // 
            this.comboBoxEnd_h.FormattingEnabled = true;
            this.comboBoxEnd_h.Location = new System.Drawing.Point(87, 112);
            this.comboBoxEnd_h.Name = "comboBoxEnd_h";
            this.comboBoxEnd_h.Size = new System.Drawing.Size(65, 20);
            this.comboBoxEnd_h.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 115);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 12);
            this.label6.TabIndex = 13;
            this.label6.Text = "종료 시간";
            // 
            // comboBoxStart_m
            // 
            this.comboBoxStart_m.FormattingEnabled = true;
            this.comboBoxStart_m.Location = new System.Drawing.Point(162, 75);
            this.comboBoxStart_m.Name = "comboBoxStart_m";
            this.comboBoxStart_m.Size = new System.Drawing.Size(65, 20);
            this.comboBoxStart_m.TabIndex = 12;
            // 
            // comboBoxStart_h
            // 
            this.comboBoxStart_h.FormattingEnabled = true;
            this.comboBoxStart_h.Location = new System.Drawing.Point(87, 75);
            this.comboBoxStart_h.Name = "comboBoxStart_h";
            this.comboBoxStart_h.Size = new System.Drawing.Size(65, 20);
            this.comboBoxStart_h.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 12);
            this.label5.TabIndex = 10;
            this.label5.Text = "시작 시간";
            // 
            // dateTimePickerWorkDate
            // 
            this.dateTimePickerWorkDate.CustomFormat = "yyyy-MM-dd";
            this.dateTimePickerWorkDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerWorkDate.Location = new System.Drawing.Point(26, 36);
            this.dateTimePickerWorkDate.Name = "dateTimePickerWorkDate";
            this.dateTimePickerWorkDate.Size = new System.Drawing.Size(201, 21);
            this.dateTimePickerWorkDate.TabIndex = 9;
            // 
            // buttonRegister
            // 
            this.buttonRegister.Location = new System.Drawing.Point(26, 450);
            this.buttonRegister.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Size = new System.Drawing.Size(61, 32);
            this.buttonRegister.TabIndex = 8;
            this.buttonRegister.Text = "등록";
            this.buttonRegister.UseVisualStyleBackColor = true;
            this.buttonRegister.Click += new System.EventHandler(this.buttonRegister_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 281);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "기록내용";
            // 
            // textBoxTaskComment
            // 
            this.textBoxTaskComment.Location = new System.Drawing.Point(24, 298);
            this.textBoxTaskComment.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxTaskComment.Multiline = true;
            this.textBoxTaskComment.Name = "textBoxTaskComment";
            this.textBoxTaskComment.Size = new System.Drawing.Size(203, 134);
            this.textBoxTaskComment.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 237);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "소분류";
            // 
            // comboBoxSmallCategory
            // 
            this.comboBoxSmallCategory.FormattingEnabled = true;
            this.comboBoxSmallCategory.Location = new System.Drawing.Point(87, 234);
            this.comboBoxSmallCategory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxSmallCategory.Name = "comboBoxSmallCategory";
            this.comboBoxSmallCategory.Size = new System.Drawing.Size(140, 20);
            this.comboBoxSmallCategory.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 197);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "중분류";
            // 
            // comboBoxMediumCategory
            // 
            this.comboBoxMediumCategory.FormattingEnabled = true;
            this.comboBoxMediumCategory.Location = new System.Drawing.Point(87, 195);
            this.comboBoxMediumCategory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxMediumCategory.Name = "comboBoxMediumCategory";
            this.comboBoxMediumCategory.Size = new System.Drawing.Size(140, 20);
            this.comboBoxMediumCategory.TabIndex = 2;
            this.comboBoxMediumCategory.SelectedIndexChanged += new System.EventHandler(this.comboBoxMiddleLCategory_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 1;
            this.label4.Text = "대분류";
            // 
            // comboBoxLargeCategory
            // 
            this.comboBoxLargeCategory.FormattingEnabled = true;
            this.comboBoxLargeCategory.Items.AddRange(new object[] {
            "인사",
            "기획",
            "영업"});
            this.comboBoxLargeCategory.Location = new System.Drawing.Point(87, 154);
            this.comboBoxLargeCategory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxLargeCategory.Name = "comboBoxLargeCategory";
            this.comboBoxLargeCategory.Size = new System.Drawing.Size(140, 20);
            this.comboBoxLargeCategory.TabIndex = 0;
            this.comboBoxLargeCategory.SelectedIndexChanged += new System.EventHandler(this.comboBoxLargeCategory_SelectedIndexChanged);
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Location = new System.Drawing.Point(911, 99);
            this.buttonRefresh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(81, 21);
            this.buttonRefresh.TabIndex = 9;
            this.buttonRefresh.Text = "새로고침";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(630, 99);
            this.buttonSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(45, 21);
            this.buttonSearch.TabIndex = 15;
            this.buttonSearch.Text = "검색";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(455, 100);
            this.textBoxSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(154, 21);
            this.textBoxSearch.TabIndex = 14;
            // 
            // comboBoxSearch
            // 
            this.comboBoxSearch.FormattingEnabled = true;
            this.comboBoxSearch.Items.AddRange(new object[] {
            "날짜",
            "키워드",
            "작성자"});
            this.comboBoxSearch.Location = new System.Drawing.Point(307, 101);
            this.comboBoxSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxSearch.Name = "comboBoxSearch";
            this.comboBoxSearch.Size = new System.Drawing.Size(106, 20);
            this.comboBoxSearch.TabIndex = 19;
            // 
            // listViewWork
            // 
            this.listViewWork.FullRowSelect = true;
            this.listViewWork.HideSelection = false;
            this.listViewWork.Location = new System.Drawing.Point(307, 129);
            this.listViewWork.Name = "listViewWork";
            this.listViewWork.Size = new System.Drawing.Size(685, 563);
            this.listViewWork.TabIndex = 20;
            this.listViewWork.UseCompatibleStateImageBehavior = false;
            this.listViewWork.SelectedIndexChanged += new System.EventHandler(this.listViewWork_SelectedIndexChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.이동ToolStripMenuItem,
            this.커뮤니티ToolStripMenuItem,
            this.로그인ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1012, 24);
            this.menuStrip1.TabIndex = 21;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 이동ToolStripMenuItem
            // 
            this.이동ToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.이동ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.인사ToolStripMenuItem,
            this.결제ToolStripMenuItem,
            this.업무마스터ToolStripMenuItem});
            this.이동ToolStripMenuItem.Name = "이동ToolStripMenuItem";
            this.이동ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.이동ToolStripMenuItem.Text = "이동";
            // 
            // 인사ToolStripMenuItem
            // 
            this.인사ToolStripMenuItem.Name = "인사ToolStripMenuItem";
            this.인사ToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.인사ToolStripMenuItem.Text = "인사";
            this.인사ToolStripMenuItem.Click += new System.EventHandler(this.인사ToolStripMenuItem_Click);
            // 
            // 결제ToolStripMenuItem
            // 
            this.결제ToolStripMenuItem.Name = "결제ToolStripMenuItem";
            this.결제ToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.결제ToolStripMenuItem.Text = "결제";
            this.결제ToolStripMenuItem.Click += new System.EventHandler(this.결제ToolStripMenuItem_Click);
            // 
            // 업무마스터ToolStripMenuItem
            // 
            this.업무마스터ToolStripMenuItem.Name = "업무마스터ToolStripMenuItem";
            this.업무마스터ToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.업무마스터ToolStripMenuItem.Text = "업무마스터";
            this.업무마스터ToolStripMenuItem.Click += new System.EventHandler(this.업무마스터ToolStripMenuItem_Click);
            // 
            // 커뮤니티ToolStripMenuItem
            // 
            this.커뮤니티ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.사원채팅방ToolStripMenuItem});
            this.커뮤니티ToolStripMenuItem.Name = "커뮤니티ToolStripMenuItem";
            this.커뮤니티ToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.커뮤니티ToolStripMenuItem.Text = "커뮤니티";
            // 
            // 사원채팅방ToolStripMenuItem
            // 
            this.사원채팅방ToolStripMenuItem.Name = "사원채팅방ToolStripMenuItem";
            this.사원채팅방ToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.사원채팅방ToolStripMenuItem.Text = "사원채팅방";
            this.사원채팅방ToolStripMenuItem.Click += new System.EventHandler(this.사원채팅방ToolStripMenuItem_Click);
            // 
            // 로그인ToolStripMenuItem
            // 
            this.로그인ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.로그아웃ToolStripMenuItem});
            this.로그인ToolStripMenuItem.Name = "로그인ToolStripMenuItem";
            this.로그인ToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.로그인ToolStripMenuItem.Text = "로그인";
            // 
            // 로그아웃ToolStripMenuItem
            // 
            this.로그아웃ToolStripMenuItem.Name = "로그아웃ToolStripMenuItem";
            this.로그아웃ToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.로그아웃ToolStripMenuItem.Text = "로그아웃";
            this.로그아웃ToolStripMenuItem.Click += new System.EventHandler(this.로그아웃ToolStripMenuItem_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1012, 762);
            this.Controls.Add(this.listViewWork);
            this.Controls.Add(this.comboBoxSearch);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.groupBoxTaskRegistration);
            this.Controls.Add(this.groupBoxAccountInformation);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormMain";
            this.Text = "메인화면";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMain_FormClosed);
            this.groupBoxAccountInformation.ResumeLayout(false);
            this.groupBoxAccountInformation.PerformLayout();
            this.groupBoxTaskRegistration.ResumeLayout(false);
            this.groupBoxTaskRegistration.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxAccountInformation;
        private System.Windows.Forms.Label labelDpt;
        private System.Windows.Forms.Label labelAccountName;
        private System.Windows.Forms.GroupBox groupBoxTaskRegistration;
        private System.Windows.Forms.ComboBox comboBoxLargeCategory;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonRegister;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxTaskComment;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxSmallCategory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxMediumCategory;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.Button buttonMessage;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.ComboBox comboBoxSearch;
        private System.Windows.Forms.ListView listViewWork;
        private System.Windows.Forms.DateTimePicker dateTimePickerWorkDate;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ComboBox comboBoxStart_h;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolStripMenuItem 이동ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 인사ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 결제ToolStripMenuItem;
        private System.Windows.Forms.ComboBox comboBoxStart_m;
        private System.Windows.Forms.ComboBox comboBoxEnd_m;
        private System.Windows.Forms.ComboBox comboBoxEnd_h;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ToolStripMenuItem 업무마스터ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 커뮤니티ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 사원채팅방ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 로그인ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 로그아웃ToolStripMenuItem;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonModify;
        private System.Windows.Forms.Label labelPos;
    }
}