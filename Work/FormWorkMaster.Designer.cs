namespace ERP_Programming
{
    partial class FormWorkMaster
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
            this.listViewCategory = new System.Windows.Forms.ListView();
            this.comboBoxCTGRLocation = new System.Windows.Forms.ComboBox();
            this.comboBoxLC = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxMC = new System.Windows.Forms.ComboBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonModify = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listViewCategory
            // 
            this.listViewCategory.FullRowSelect = true;
            this.listViewCategory.HideSelection = false;
            this.listViewCategory.Location = new System.Drawing.Point(12, 38);
            this.listViewCategory.Name = "listViewCategory";
            this.listViewCategory.Size = new System.Drawing.Size(404, 280);
            this.listViewCategory.TabIndex = 21;
            this.listViewCategory.UseCompatibleStateImageBehavior = false;
            this.listViewCategory.SelectedIndexChanged += new System.EventHandler(this.listViewCategory_SelectedIndexChanged);
            // 
            // comboBoxCTGRLocation
            // 
            this.comboBoxCTGRLocation.FormattingEnabled = true;
            this.comboBoxCTGRLocation.Location = new System.Drawing.Point(87, 43);
            this.comboBoxCTGRLocation.Name = "comboBoxCTGRLocation";
            this.comboBoxCTGRLocation.Size = new System.Drawing.Size(113, 20);
            this.comboBoxCTGRLocation.TabIndex = 11;
            this.comboBoxCTGRLocation.SelectedIndexChanged += new System.EventHandler(this.comboBoxCTGRLocation_SelectedIndexChanged);
            // 
            // comboBoxLC
            // 
            this.comboBoxLC.FormattingEnabled = true;
            this.comboBoxLC.Location = new System.Drawing.Point(87, 98);
            this.comboBoxLC.Name = "comboBoxLC";
            this.comboBoxLC.Size = new System.Drawing.Size(113, 20);
            this.comboBoxLC.TabIndex = 14;
            this.comboBoxLC.SelectedIndexChanged += new System.EventHandler(this.comboBoxLC_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 22;
            this.label1.Text = "추가위치";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 23;
            this.label2.Text = "상위항목";
            // 
            // comboBoxMC
            // 
            this.comboBoxMC.FormattingEnabled = true;
            this.comboBoxMC.Location = new System.Drawing.Point(87, 133);
            this.comboBoxMC.Name = "comboBoxMC";
            this.comboBoxMC.Size = new System.Drawing.Size(113, 20);
            this.comboBoxMC.TabIndex = 24;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(87, 185);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(113, 21);
            this.textBoxName.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 26;
            this.label3.Text = "이름";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(10, 236);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(58, 26);
            this.buttonAdd.TabIndex = 8;
            this.buttonAdd.Text = "등록";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBoxCTGRLocation);
            this.groupBox1.Controls.Add(this.comboBoxLC);
            this.groupBox1.Controls.Add(this.buttonAdd);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.buttonDelete);
            this.groupBox1.Controls.Add(this.buttonModify);
            this.groupBox1.Controls.Add(this.textBoxName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.comboBoxMC);
            this.groupBox1.Location = new System.Drawing.Point(431, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(219, 280);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "업무마스터";
            // 
            // buttonModify
            // 
            this.buttonModify.Location = new System.Drawing.Point(83, 236);
            this.buttonModify.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonModify.Name = "buttonModify";
            this.buttonModify.Size = new System.Drawing.Size(58, 26);
            this.buttonModify.TabIndex = 28;
            this.buttonModify.Text = "수정";
            this.buttonModify.UseVisualStyleBackColor = true;
            this.buttonModify.Click += new System.EventHandler(this.buttonModify_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(155, 236);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(58, 26);
            this.buttonDelete.TabIndex = 27;
            this.buttonDelete.Text = "삭제";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // FormWorkMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 352);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listViewCategory);
            this.Name = "FormWorkMaster";
            this.Text = "FormWorkMaster";
            this.Load += new System.EventHandler(this.FormWorkMaster_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewCategory;
        private System.Windows.Forms.ComboBox comboBoxCTGRLocation;
        private System.Windows.Forms.ComboBox comboBoxLC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxMC;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonModify;
        private System.Windows.Forms.Button buttonDelete;
    }
}