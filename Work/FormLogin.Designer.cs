namespace ERP_Programming
{
    partial class FormLogin
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
            this.buttonLogin = new System.Windows.Forms.Button();
            this.labelID = new System.Windows.Forms.Label();
            this.labelPW = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.textBoxPW = new System.Windows.Forms.TextBox();
            this.labelNotice = new System.Windows.Forms.Label();
            this.button_exit = new System.Windows.Forms.Button();
            this.checkBoxAutoLoadAccount = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(80, 170);
            this.buttonLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(88, 24);
            this.buttonLogin.TabIndex = 0;
            this.buttonLogin.Text = "로그인";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(57, 57);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(16, 12);
            this.labelID.TabIndex = 2;
            this.labelID.Text = "ID";
            // 
            // labelPW
            // 
            this.labelPW.AutoSize = true;
            this.labelPW.Location = new System.Drawing.Point(47, 87);
            this.labelPW.Name = "labelPW";
            this.labelPW.Size = new System.Drawing.Size(23, 12);
            this.labelPW.TabIndex = 3;
            this.labelPW.Text = "PW";
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(80, 54);
            this.textBoxID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(109, 21);
            this.textBoxID.TabIndex = 4;
            // 
            // textBoxPW
            // 
            this.textBoxPW.Location = new System.Drawing.Point(80, 85);
            this.textBoxPW.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxPW.Name = "textBoxPW";
            this.textBoxPW.Size = new System.Drawing.Size(109, 21);
            this.textBoxPW.TabIndex = 5;
            // 
            // labelNotice
            // 
            this.labelNotice.AutoSize = true;
            this.labelNotice.Location = new System.Drawing.Point(57, 155);
            this.labelNotice.Name = "labelNotice";
            this.labelNotice.Size = new System.Drawing.Size(13, 12);
            this.labelNotice.TabIndex = 6;
            this.labelNotice.Text = "  ";
            // 
            // button_exit
            // 
            this.button_exit.Location = new System.Drawing.Point(80, 206);
            this.button_exit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(88, 22);
            this.button_exit.TabIndex = 8;
            this.button_exit.Text = "종료";
            this.button_exit.UseVisualStyleBackColor = true;
            this.button_exit.Click += new System.EventHandler(this.button_exit_Click);
            // 
            // checkBoxAutoLoadAccount
            // 
            this.checkBoxAutoLoadAccount.AutoSize = true;
            this.checkBoxAutoLoadAccount.Location = new System.Drawing.Point(69, 121);
            this.checkBoxAutoLoadAccount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxAutoLoadAccount.Name = "checkBoxAutoLoadAccount";
            this.checkBoxAutoLoadAccount.Size = new System.Drawing.Size(116, 16);
            this.checkBoxAutoLoadAccount.TabIndex = 7;
            this.checkBoxAutoLoadAccount.Text = "로그인 정보 유지";
            this.checkBoxAutoLoadAccount.UseVisualStyleBackColor = true;
            this.checkBoxAutoLoadAccount.CheckedChanged += new System.EventHandler(this.checkBoxAutoLoadAccount_CheckedChanged);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(247, 242);
            this.Controls.Add(this.button_exit);
            this.Controls.Add(this.checkBoxAutoLoadAccount);
            this.Controls.Add(this.labelNotice);
            this.Controls.Add(this.textBoxPW);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.labelPW);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.buttonLogin);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormLogin";
            this.Text = "로그인";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Label labelPW;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.TextBox textBoxPW;
        private System.Windows.Forms.Label labelNotice;
        private System.Windows.Forms.Button button_exit;
        private System.Windows.Forms.CheckBox checkBoxAutoLoadAccount;
    }
}

