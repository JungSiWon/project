namespace ERP_Programming
{
    partial class FormAttendance
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
            this.listViewAtlog = new System.Windows.Forms.ListView();
            this.날짜 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.출근시간 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.퇴근시간 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dateTimePickerDateIn = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerTimeIn = new System.Windows.Forms.DateTimePicker();
            this.buttonIn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dateTimePickerDateOut = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerTimeOut = new System.Windows.Forms.DateTimePicker();
            this.buttonOut = new System.Windows.Forms.Button();
            this.dateTimePickerMonth = new System.Windows.Forms.DateTimePicker();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // listViewAtlog
            // 
            this.listViewAtlog.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.날짜,
            this.출근시간,
            this.퇴근시간});
            this.listViewAtlog.FullRowSelect = true;
            this.listViewAtlog.GridLines = true;
            this.listViewAtlog.HideSelection = false;
            this.listViewAtlog.Location = new System.Drawing.Point(30, 52);
            this.listViewAtlog.MultiSelect = false;
            this.listViewAtlog.Name = "listViewAtlog";
            this.listViewAtlog.Size = new System.Drawing.Size(559, 386);
            this.listViewAtlog.TabIndex = 0;
            this.listViewAtlog.UseCompatibleStateImageBehavior = false;
            this.listViewAtlog.View = System.Windows.Forms.View.Details;
            this.listViewAtlog.DoubleClick += new System.EventHandler(this.listViewAtlog_DoubleClick);
            // 
            // 날짜
            // 
            this.날짜.Text = "날짜";
            this.날짜.Width = 148;
            // 
            // 출근시간
            // 
            this.출근시간.Text = "출근시간";
            this.출근시간.Width = 126;
            // 
            // 퇴근시간
            // 
            this.퇴근시간.Text = "퇴근시간";
            this.퇴근시간.Width = 134;
            // 
            // dateTimePickerDateIn
            // 
            this.dateTimePickerDateIn.Location = new System.Drawing.Point(6, 24);
            this.dateTimePickerDateIn.Name = "dateTimePickerDateIn";
            this.dateTimePickerDateIn.Size = new System.Drawing.Size(197, 25);
            this.dateTimePickerDateIn.TabIndex = 1;
            // 
            // dateTimePickerTimeIn
            // 
            this.dateTimePickerTimeIn.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePickerTimeIn.Location = new System.Drawing.Point(209, 24);
            this.dateTimePickerTimeIn.Name = "dateTimePickerTimeIn";
            this.dateTimePickerTimeIn.ShowUpDown = true;
            this.dateTimePickerTimeIn.Size = new System.Drawing.Size(200, 25);
            this.dateTimePickerTimeIn.TabIndex = 2;
            // 
            // buttonIn
            // 
            this.buttonIn.Location = new System.Drawing.Point(430, 27);
            this.buttonIn.Name = "buttonIn";
            this.buttonIn.Size = new System.Drawing.Size(75, 23);
            this.buttonIn.TabIndex = 3;
            this.buttonIn.Text = "변경";
            this.buttonIn.UseVisualStyleBackColor = true;
            this.buttonIn.Click += new System.EventHandler(this.buttonIn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimePickerDateIn);
            this.groupBox1.Controls.Add(this.dateTimePickerTimeIn);
            this.groupBox1.Controls.Add(this.buttonIn);
            this.groupBox1.Location = new System.Drawing.Point(36, 444);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(540, 61);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "출근시간";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dateTimePickerDateOut);
            this.groupBox2.Controls.Add(this.dateTimePickerTimeOut);
            this.groupBox2.Controls.Add(this.buttonOut);
            this.groupBox2.Location = new System.Drawing.Point(36, 511);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(540, 62);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "퇴근시간";
            // 
            // dateTimePickerDateOut
            // 
            this.dateTimePickerDateOut.Location = new System.Drawing.Point(6, 24);
            this.dateTimePickerDateOut.Name = "dateTimePickerDateOut";
            this.dateTimePickerDateOut.Size = new System.Drawing.Size(197, 25);
            this.dateTimePickerDateOut.TabIndex = 1;
            // 
            // dateTimePickerTimeOut
            // 
            this.dateTimePickerTimeOut.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePickerTimeOut.Location = new System.Drawing.Point(209, 24);
            this.dateTimePickerTimeOut.Name = "dateTimePickerTimeOut";
            this.dateTimePickerTimeOut.ShowUpDown = true;
            this.dateTimePickerTimeOut.Size = new System.Drawing.Size(200, 25);
            this.dateTimePickerTimeOut.TabIndex = 2;
            // 
            // buttonOut
            // 
            this.buttonOut.Location = new System.Drawing.Point(430, 27);
            this.buttonOut.Name = "buttonOut";
            this.buttonOut.Size = new System.Drawing.Size(75, 23);
            this.buttonOut.TabIndex = 3;
            this.buttonOut.Text = "변경";
            this.buttonOut.UseVisualStyleBackColor = true;
            this.buttonOut.Click += new System.EventHandler(this.buttonOut_Click);
            // 
            // dateTimePickerMonth
            // 
            this.dateTimePickerMonth.Location = new System.Drawing.Point(30, 21);
            this.dateTimePickerMonth.Name = "dateTimePickerMonth";
            this.dateTimePickerMonth.Size = new System.Drawing.Size(200, 25);
            this.dateTimePickerMonth.TabIndex = 5;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(514, 21);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(75, 23);
            this.buttonSearch.TabIndex = 6;
            this.buttonSearch.Text = "검색";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // FormAttendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 602);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.dateTimePickerMonth);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listViewAtlog);
            this.Name = "FormAttendance";
            this.Text = "출근기록부";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewAtlog;
        private System.Windows.Forms.ColumnHeader 날짜;
        private System.Windows.Forms.ColumnHeader 출근시간;
        private System.Windows.Forms.ColumnHeader 퇴근시간;
        private System.Windows.Forms.DateTimePicker dateTimePickerDateIn;
        private System.Windows.Forms.DateTimePicker dateTimePickerTimeIn;
        private System.Windows.Forms.Button buttonIn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dateTimePickerDateOut;
        private System.Windows.Forms.DateTimePicker dateTimePickerTimeOut;
        private System.Windows.Forms.Button buttonOut;
        private System.Windows.Forms.DateTimePicker dateTimePickerMonth;
        private System.Windows.Forms.Button buttonSearch;
    }
}