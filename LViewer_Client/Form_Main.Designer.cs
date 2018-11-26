namespace LViewer_Client
{
    partial class Form_Main
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
            this.textBox_Status = new System.Windows.Forms.TextBox();
            this.listBox_Online = new System.Windows.Forms.ListBox();
            this.textBox_Input = new System.Windows.Forms.TextBox();
            this.button_Send = new System.Windows.Forms.Button();
            this.button_UpdateList = new System.Windows.Forms.Button();
            this.button_PublicChat = new System.Windows.Forms.Button();
            this.label_Username = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox_Status
            // 
            this.textBox_Status.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.textBox_Status.AllowDrop = true;
            this.textBox_Status.Location = new System.Drawing.Point(37, 64);
            this.textBox_Status.Multiline = true;
            this.textBox_Status.Name = "textBox_Status";
            this.textBox_Status.Size = new System.Drawing.Size(388, 242);
            this.textBox_Status.TabIndex = 0;
            // 
            // listBox_Online
            // 
            this.listBox_Online.FormattingEnabled = true;
            this.listBox_Online.ItemHeight = 16;
            this.listBox_Online.Location = new System.Drawing.Point(517, 39);
            this.listBox_Online.Name = "listBox_Online";
            this.listBox_Online.Size = new System.Drawing.Size(250, 260);
            this.listBox_Online.TabIndex = 1;
            // 
            // textBox_Input
            // 
            this.textBox_Input.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Input.Location = new System.Drawing.Point(36, 347);
            this.textBox_Input.Name = "textBox_Input";
            this.textBox_Input.Size = new System.Drawing.Size(312, 27);
            this.textBox_Input.TabIndex = 2;
            // 
            // button_Send
            // 
            this.button_Send.Location = new System.Drawing.Point(363, 344);
            this.button_Send.Name = "button_Send";
            this.button_Send.Size = new System.Drawing.Size(84, 32);
            this.button_Send.TabIndex = 3;
            this.button_Send.Text = "Gửi";
            this.button_Send.UseVisualStyleBackColor = true;
            this.button_Send.Click += new System.EventHandler(this.button_Send_Click);
            // 
            // button_UpdateList
            // 
            this.button_UpdateList.Location = new System.Drawing.Point(517, 321);
            this.button_UpdateList.Name = "button_UpdateList";
            this.button_UpdateList.Size = new System.Drawing.Size(185, 28);
            this.button_UpdateList.TabIndex = 4;
            this.button_UpdateList.Text = "Refresh";
            this.button_UpdateList.UseVisualStyleBackColor = true;
            this.button_UpdateList.Click += new System.EventHandler(this.button_UpdateList_Click);
            // 
            // button_PublicChat
            // 
            this.button_PublicChat.Location = new System.Drawing.Point(517, 377);
            this.button_PublicChat.Name = "button_PublicChat";
            this.button_PublicChat.Size = new System.Drawing.Size(185, 29);
            this.button_PublicChat.TabIndex = 5;
            this.button_PublicChat.Text = "Public Chat";
            this.button_PublicChat.UseVisualStyleBackColor = true;
            this.button_PublicChat.Click += new System.EventHandler(this.button_PublicChat_Click);
            // 
            // label_Username
            // 
            this.label_Username.AutoSize = true;
            this.label_Username.Location = new System.Drawing.Point(37, 13);
            this.label_Username.Name = "label_Username";
            this.label_Username.Size = new System.Drawing.Size(46, 17);
            this.label_Username.TabIndex = 6;
            this.label_Username.Text = "label1";
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label_Username);
            this.Controls.Add(this.button_PublicChat);
            this.Controls.Add(this.button_UpdateList);
            this.Controls.Add(this.button_Send);
            this.Controls.Add(this.textBox_Input);
            this.Controls.Add(this.listBox_Online);
            this.Controls.Add(this.textBox_Status);
            this.Name = "Form_Main";
            this.Text = "LViewer";
            this.Load += new System.EventHandler(this.Form_Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_Status;
        private System.Windows.Forms.ListBox listBox_Online;
        private System.Windows.Forms.TextBox textBox_Input;
        private System.Windows.Forms.Button button_Send;
        private System.Windows.Forms.Button button_UpdateList;
        private System.Windows.Forms.Button button_PublicChat;
        private System.Windows.Forms.Label label_Username;
    }
}