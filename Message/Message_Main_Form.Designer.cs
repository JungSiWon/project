namespace ERP_Programming
{
    partial class Message_Main_Form
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
            this.listViewMessageList = new System.Windows.Forms.ListView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.textBoxSearchBar = new System.Windows.Forms.TextBox();
            this.comboBoxSearchMenu = new System.Windows.Forms.ComboBox();
            this.buttonMessageWrite = new System.Windows.Forms.Button();
            this.buttonMessageRead = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listViewMessageList
            // 
            this.listViewMessageList.HideSelection = false;
            this.listViewMessageList.Location = new System.Drawing.Point(6, 65);
            this.listViewMessageList.Name = "listViewMessageList";
            this.listViewMessageList.Size = new System.Drawing.Size(737, 361);
            this.listViewMessageList.TabIndex = 0;
            this.listViewMessageList.UseCompatibleStateImageBehavior = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonSearch);
            this.groupBox1.Controls.Add(this.textBoxSearchBar);
            this.groupBox1.Controls.Add(this.comboBoxSearchMenu);
            this.groupBox1.Controls.Add(this.listViewMessageList);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(749, 434);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "메일 함";
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(660, 30);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(67, 23);
            this.buttonSearch.TabIndex = 5;
            this.buttonSearch.Text = "검색";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // textBoxSearchBar
            // 
            this.textBoxSearchBar.Location = new System.Drawing.Point(108, 30);
            this.textBoxSearchBar.Name = "textBoxSearchBar";
            this.textBoxSearchBar.Size = new System.Drawing.Size(123, 25);
            this.textBoxSearchBar.TabIndex = 2;
            // 
            // comboBoxSearchMenu
            // 
            this.comboBoxSearchMenu.FormattingEnabled = true;
            this.comboBoxSearchMenu.Location = new System.Drawing.Point(7, 31);
            this.comboBoxSearchMenu.Name = "comboBoxSearchMenu";
            this.comboBoxSearchMenu.Size = new System.Drawing.Size(95, 23);
            this.comboBoxSearchMenu.TabIndex = 1;
            // 
            // buttonMessageWrite
            // 
            this.buttonMessageWrite.Location = new System.Drawing.Point(616, 471);
            this.buttonMessageWrite.Name = "buttonMessageWrite";
            this.buttonMessageWrite.Size = new System.Drawing.Size(139, 53);
            this.buttonMessageWrite.TabIndex = 5;
            this.buttonMessageWrite.Text = "메시지 보내기";
            this.buttonMessageWrite.UseVisualStyleBackColor = true;
            this.buttonMessageWrite.Click += new System.EventHandler(this.buttonMessageWrite_Click);
            // 
            // buttonMessageRead
            // 
            this.buttonMessageRead.Location = new System.Drawing.Point(19, 471);
            this.buttonMessageRead.Name = "buttonMessageRead";
            this.buttonMessageRead.Size = new System.Drawing.Size(137, 53);
            this.buttonMessageRead.TabIndex = 6;
            this.buttonMessageRead.Text = "메시지 읽기";
            this.buttonMessageRead.UseVisualStyleBackColor = true;
            this.buttonMessageRead.Click += new System.EventHandler(this.buttonMessageRead_Click);
            // 
            // Message_Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 536);
            this.Controls.Add(this.buttonMessageRead);
            this.Controls.Add(this.buttonMessageWrite);
            this.Controls.Add(this.groupBox1);
            this.Name = "Message_Main_Form";
            this.Text = "Note_Main_Form";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewMessageList;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TextBox textBoxSearchBar;
        private System.Windows.Forms.ComboBox comboBoxSearchMenu;
        private System.Windows.Forms.Button buttonMessageWrite;
        private System.Windows.Forms.Button buttonMessageRead;
    }
}