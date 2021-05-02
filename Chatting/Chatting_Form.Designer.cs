
namespace ERP_Programming.Chatting
{
    partial class Chatting_Form
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
            this.textBox_Log = new System.Windows.Forms.TextBox();
            this.textBox_Send_Message = new System.Windows.Forms.TextBox();
            this.button_Send = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_Log
            // 
            this.textBox_Log.Location = new System.Drawing.Point(17, 12);
            this.textBox_Log.Multiline = true;
            this.textBox_Log.Name = "textBox_Log";
            this.textBox_Log.Size = new System.Drawing.Size(343, 389);
            this.textBox_Log.TabIndex = 0;
            // 
            // textBox_Send_Message
            // 
            this.textBox_Send_Message.Location = new System.Drawing.Point(12, 413);
            this.textBox_Send_Message.Name = "textBox_Send_Message";
            this.textBox_Send_Message.Size = new System.Drawing.Size(261, 25);
            this.textBox_Send_Message.TabIndex = 1;
            // 
            // button_Send
            // 
            this.button_Send.Location = new System.Drawing.Point(285, 413);
            this.button_Send.Name = "button_Send";
            this.button_Send.Size = new System.Drawing.Size(75, 23);
            this.button_Send.TabIndex = 2;
            this.button_Send.Text = "보내기";
            this.button_Send.UseVisualStyleBackColor = true;
            this.button_Send.Click += new System.EventHandler(this.button_Send_Click);
            // 
            // Chatting_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 450);
            this.Controls.Add(this.button_Send);
            this.Controls.Add(this.textBox_Send_Message);
            this.Controls.Add(this.textBox_Log);
            this.Name = "Chatting_Form";
            this.Text = "Chatting_Form";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Chatting_Form_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_Log;
        private System.Windows.Forms.TextBox textBox_Send_Message;
        private System.Windows.Forms.Button button_Send;
    }
}