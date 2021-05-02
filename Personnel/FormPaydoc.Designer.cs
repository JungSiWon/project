namespace ERP_Programming
{
    partial class FormPaydoc
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
            this.listViewPay = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewPay1 = new System.Windows.Forms.ListView();
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewDeduct = new System.Windows.Forms.ListView();
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBoxTotal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxTax = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxReal = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.dateTimePickerMonth = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // listViewPay
            // 
            this.listViewPay.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.listViewPay.FullRowSelect = true;
            this.listViewPay.GridLines = true;
            this.listViewPay.HideSelection = false;
            this.listViewPay.Location = new System.Drawing.Point(39, 40);
            this.listViewPay.MultiSelect = false;
            this.listViewPay.Name = "listViewPay";
            this.listViewPay.Size = new System.Drawing.Size(564, 324);
            this.listViewPay.TabIndex = 0;
            this.listViewPay.UseCompatibleStateImageBehavior = false;
            this.listViewPay.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "날짜";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "정기근무";
            this.columnHeader2.Width = 75;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "연장근무";
            this.columnHeader3.Width = 78;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "야간근무";
            this.columnHeader4.Width = 76;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "휴일근무";
            this.columnHeader5.Width = 78;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "총근무시간";
            this.columnHeader6.Width = 90;
            // 
            // listViewPay1
            // 
            this.listViewPay1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader7,
            this.columnHeader8});
            this.listViewPay1.FullRowSelect = true;
            this.listViewPay1.HideSelection = false;
            this.listViewPay1.Location = new System.Drawing.Point(39, 370);
            this.listViewPay1.MultiSelect = false;
            this.listViewPay1.Name = "listViewPay1";
            this.listViewPay1.Size = new System.Drawing.Size(187, 179);
            this.listViewPay1.TabIndex = 1;
            this.listViewPay1.UseCompatibleStateImageBehavior = false;
            this.listViewPay1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "지급내역";
            this.columnHeader7.Width = 81;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "지급액";
            // 
            // listViewDeduct
            // 
            this.listViewDeduct.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader9,
            this.columnHeader10});
            this.listViewDeduct.FullRowSelect = true;
            this.listViewDeduct.HideSelection = false;
            this.listViewDeduct.Location = new System.Drawing.Point(232, 370);
            this.listViewDeduct.MultiSelect = false;
            this.listViewDeduct.Name = "listViewDeduct";
            this.listViewDeduct.Size = new System.Drawing.Size(187, 179);
            this.listViewDeduct.TabIndex = 1;
            this.listViewDeduct.UseCompatibleStateImageBehavior = false;
            this.listViewDeduct.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "공제내역";
            this.columnHeader9.Width = 81;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "공제액";
            // 
            // textBoxTotal
            // 
            this.textBoxTotal.Location = new System.Drawing.Point(133, 555);
            this.textBoxTotal.Name = "textBoxTotal";
            this.textBoxTotal.ReadOnly = true;
            this.textBoxTotal.Size = new System.Drawing.Size(93, 25);
            this.textBoxTotal.TabIndex = 2;
            this.textBoxTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 558);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "총급여";
            // 
            // textBoxTax
            // 
            this.textBoxTax.Location = new System.Drawing.Point(326, 555);
            this.textBoxTax.Name = "textBoxTax";
            this.textBoxTax.ReadOnly = true;
            this.textBoxTax.Size = new System.Drawing.Size(93, 25);
            this.textBoxTax.TabIndex = 2;
            this.textBoxTax.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(229, 558);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "공제액계";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 596);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "실수령액";
            // 
            // textBoxReal
            // 
            this.textBoxReal.Location = new System.Drawing.Point(133, 593);
            this.textBoxReal.Name = "textBoxReal";
            this.textBoxReal.ReadOnly = true;
            this.textBoxReal.Size = new System.Drawing.Size(93, 25);
            this.textBoxReal.TabIndex = 5;
            this.textBoxReal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(528, 12);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(75, 23);
            this.buttonSearch.TabIndex = 6;
            this.buttonSearch.Text = "검색";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // dateTimePickerMonth
            // 
            this.dateTimePickerMonth.Location = new System.Drawing.Point(39, 9);
            this.dateTimePickerMonth.Name = "dateTimePickerMonth";
            this.dateTimePickerMonth.Size = new System.Drawing.Size(200, 25);
            this.dateTimePickerMonth.TabIndex = 7;
            // 
            // FormPaydoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 638);
            this.Controls.Add(this.dateTimePickerMonth);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.textBoxReal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxTax);
            this.Controls.Add(this.textBoxTotal);
            this.Controls.Add(this.listViewDeduct);
            this.Controls.Add(this.listViewPay1);
            this.Controls.Add(this.listViewPay);
            this.Name = "FormPaydoc";
            this.Text = "급여명세서";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewPay;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ListView listViewPay1;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ListView listViewDeduct;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.TextBox textBoxTotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxTax;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxReal;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.DateTimePicker dateTimePickerMonth;
    }
}