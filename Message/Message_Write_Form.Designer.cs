namespace ERP_Programming
{
    partial class Message_Write_Form
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
            this.comboBoxDepartment = new System.Windows.Forms.ComboBox();
            this.comboBoxEmployee = new System.Windows.Forms.ComboBox();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxContents = new System.Windows.Forms.TextBox();
            this.buttonSend = new System.Windows.Forms.Button();
            this.labelSender = new System.Windows.Forms.Label();
            this.labelReciver = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBoxDepartment
            // 
            this.comboBoxDepartment.FormattingEnabled = true;
            this.comboBoxDepartment.Location = new System.Drawing.Point(232, 12);
            this.comboBoxDepartment.Name = "comboBoxDepartment";
            this.comboBoxDepartment.Size = new System.Drawing.Size(121, 23);
            this.comboBoxDepartment.TabIndex = 0;
            this.comboBoxDepartment.SelectedIndexChanged += new System.EventHandler(this.comboBoxDepartment_SelectedIndexChanged);
            // 
            // comboBoxEmployee
            // 
            this.comboBoxEmployee.FormattingEnabled = true;
            this.comboBoxEmployee.Location = new System.Drawing.Point(559, 12);
            this.comboBoxEmployee.Name = "comboBoxEmployee";
            this.comboBoxEmployee.Size = new System.Drawing.Size(121, 23);
            this.comboBoxEmployee.TabIndex = 1;
            this.comboBoxEmployee.SelectedIndexChanged += new System.EventHandler(this.comboBoxEmployee_SelectedIndexChanged);
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Location = new System.Drawing.Point(32, 77);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(668, 25);
            this.textBoxTitle.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(167, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "부서 : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(491, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "회원 : ";
            // 
            // textBoxContents
            // 
            this.textBoxContents.Location = new System.Drawing.Point(32, 118);
            this.textBoxContents.Multiline = true;
            this.textBoxContents.Name = "textBoxContents";
            this.textBoxContents.Size = new System.Drawing.Size(667, 351);
            this.textBoxContents.TabIndex = 5;
            // 
            // buttonSend
            // 
            this.buttonSend.Location = new System.Drawing.Point(571, 484);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(128, 23);
            this.buttonSend.TabIndex = 6;
            this.buttonSend.Text = "보내기";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelSender
            // 
            this.labelSender.AutoSize = true;
            this.labelSender.Location = new System.Drawing.Point(29, 49);
            this.labelSender.Name = "labelSender";
            this.labelSender.Size = new System.Drawing.Size(45, 15);
            this.labelSender.TabIndex = 7;
            this.labelSender.Text = "label3";
            // 
            // labelReciver
            // 
            this.labelReciver.AutoSize = true;
            this.labelReciver.Location = new System.Drawing.Point(511, 49);
            this.labelReciver.Name = "labelReciver";
            this.labelReciver.Size = new System.Drawing.Size(45, 15);
            this.labelReciver.TabIndex = 8;
            this.labelReciver.Text = "label3";
            // 
            // Message_Write_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 519);
            this.Controls.Add(this.labelReciver);
            this.Controls.Add(this.labelSender);
            this.Controls.Add(this.buttonSend);
            this.Controls.Add(this.textBoxContents);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxTitle);
            this.Controls.Add(this.comboBoxEmployee);
            this.Controls.Add(this.comboBoxDepartment);
            this.Name = "Message_Write_Form";
            this.Text = "Message_Write_Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxDepartment;
        private System.Windows.Forms.ComboBox comboBoxEmployee;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxContents;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.Label labelSender;
        private System.Windows.Forms.Label labelReciver;
    }
}