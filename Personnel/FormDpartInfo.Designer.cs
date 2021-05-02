namespace ERP_Programming
{
    partial class FormDpartInfo
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
            this.buttonDptAdd = new System.Windows.Forms.Button();
            this.textBoxDptHead = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxDptName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelDptNum = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.listViewSearchHead = new System.Windows.Forms.ListView();
            this.사원번호 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxHeadNumber = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxDepartmentList = new System.Windows.Forms.ComboBox();
            this.comboBoxPositionList = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonDptSearch = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonDptAdd
            // 
            this.buttonDptAdd.Location = new System.Drawing.Point(12, 173);
            this.buttonDptAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonDptAdd.Name = "buttonDptAdd";
            this.buttonDptAdd.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.buttonDptAdd.Size = new System.Drawing.Size(293, 38);
            this.buttonDptAdd.TabIndex = 17;
            this.buttonDptAdd.Text = "추가 및 변경";
            this.buttonDptAdd.UseVisualStyleBackColor = true;
            this.buttonDptAdd.Click += new System.EventHandler(this.buttonDptAdd_Click);
            // 
            // textBoxDptHead
            // 
            this.textBoxDptHead.Location = new System.Drawing.Point(114, 98);
            this.textBoxDptHead.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxDptHead.Name = "textBoxDptHead";
            this.textBoxDptHead.ReadOnly = true;
            this.textBoxDptHead.Size = new System.Drawing.Size(132, 25);
            this.textBoxDptHead.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 20;
            this.label2.Text = "부서장";
            // 
            // textBoxDptName
            // 
            this.textBoxDptName.Location = new System.Drawing.Point(114, 67);
            this.textBoxDptName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxDptName.Name = "textBoxDptName";
            this.textBoxDptName.Size = new System.Drawing.Size(132, 25);
            this.textBoxDptName.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 18;
            this.label1.Text = "부서명";
            // 
            // labelDptNum
            // 
            this.labelDptNum.AutoSize = true;
            this.labelDptNum.Location = new System.Drawing.Point(111, 43);
            this.labelDptNum.Name = "labelDptNum";
            this.labelDptNum.Size = new System.Drawing.Size(23, 15);
            this.labelDptNum.TabIndex = 23;
            this.labelDptNum.Text = "00";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(38, 43);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 15);
            this.label9.TabIndex = 22;
            this.label9.Text = "부서번호";
            // 
            // listViewSearchHead
            // 
            this.listViewSearchHead.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.사원번호,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listViewSearchHead.FullRowSelect = true;
            this.listViewSearchHead.HideSelection = false;
            this.listViewSearchHead.Location = new System.Drawing.Point(19, 83);
            this.listViewSearchHead.MultiSelect = false;
            this.listViewSearchHead.Name = "listViewSearchHead";
            this.listViewSearchHead.Size = new System.Drawing.Size(439, 135);
            this.listViewSearchHead.TabIndex = 24;
            this.listViewSearchHead.UseCompatibleStateImageBehavior = false;
            this.listViewSearchHead.View = System.Windows.Forms.View.Details;
            this.listViewSearchHead.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listViewSearchHead_MouseDoubleClick);
            // 
            // 사원번호
            // 
            this.사원번호.Text = "사원번호";
            this.사원번호.Width = 89;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "이름";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "부서";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "직책";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 15);
            this.label3.TabIndex = 20;
            this.label3.Text = "부서장번호";
            // 
            // textBoxHeadNumber
            // 
            this.textBoxHeadNumber.Location = new System.Drawing.Point(114, 127);
            this.textBoxHeadNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxHeadNumber.Name = "textBoxHeadNumber";
            this.textBoxHeadNumber.ReadOnly = true;
            this.textBoxHeadNumber.Size = new System.Drawing.Size(132, 25);
            this.textBoxHeadNumber.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 15);
            this.label4.TabIndex = 25;
            this.label4.Text = "부서";
            // 
            // comboBoxDepartmentList
            // 
            this.comboBoxDepartmentList.FormattingEnabled = true;
            this.comboBoxDepartmentList.Location = new System.Drawing.Point(19, 48);
            this.comboBoxDepartmentList.Name = "comboBoxDepartmentList";
            this.comboBoxDepartmentList.Size = new System.Drawing.Size(121, 23);
            this.comboBoxDepartmentList.TabIndex = 26;
            // 
            // comboBoxPositionList
            // 
            this.comboBoxPositionList.FormattingEnabled = true;
            this.comboBoxPositionList.Items.AddRange(new object[] {
            "",
            "부장",
            "차장",
            "대리",
            "주임"});
            this.comboBoxPositionList.Location = new System.Drawing.Point(146, 48);
            this.comboBoxPositionList.Name = "comboBoxPositionList";
            this.comboBoxPositionList.Size = new System.Drawing.Size(121, 23);
            this.comboBoxPositionList.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(187, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 15);
            this.label5.TabIndex = 25;
            this.label5.Text = "직책";
            // 
            // buttonDptSearch
            // 
            this.buttonDptSearch.Location = new System.Drawing.Point(355, 48);
            this.buttonDptSearch.Name = "buttonDptSearch";
            this.buttonDptSearch.Size = new System.Drawing.Size(103, 23);
            this.buttonDptSearch.TabIndex = 27;
            this.buttonDptSearch.Text = "검    색";
            this.buttonDptSearch.UseVisualStyleBackColor = true;
            this.buttonDptSearch.Click += new System.EventHandler(this.buttonDptSearch_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBoxDepartmentList);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.buttonDptSearch);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.comboBoxPositionList);
            this.groupBox1.Controls.Add(this.listViewSearchHead);
            this.groupBox1.Location = new System.Drawing.Point(351, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(474, 227);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "부서장 검색";
            // 
            // FormDpartInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 242);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labelDptNum);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBoxHeadNumber);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxDptHead);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxDptName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonDptAdd);
            this.Name = "FormDpartInfo";
            this.Text = "부서";
            this.Load += new System.EventHandler(this.FormDpartInfo_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonDptAdd;
        private System.Windows.Forms.TextBox textBoxDptHead;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxDptName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelDptNum;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListView listViewSearchHead;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxHeadNumber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxDepartmentList;
        private System.Windows.Forms.ComboBox comboBoxPositionList;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonDptSearch;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ColumnHeader 사원번호;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
    }
}