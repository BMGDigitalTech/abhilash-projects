namespace Jsondotnet_newtonsoft
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.jsonTxt = new System.Windows.Forms.TextBox();
            this.firstNameLbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.firstNameTxt = new System.Windows.Forms.TextBox();
            this.lastNameTxt = new System.Windows.Forms.TextBox();
            this.emailTxt = new System.Windows.Forms.TextBox();
            this.phoneTxt = new System.Windows.Forms.TextBox();
            this.FriendsLstbox = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.decodeJsonBtn = new System.Windows.Forms.Button();
            this.createJsonBtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.friendNameTxt = new System.Windows.Forms.TextBox();
            this.addFriendBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "JSON:";
            // 
            // jsonTxt
            // 
            this.jsonTxt.Location = new System.Drawing.Point(132, 39);
            this.jsonTxt.Name = "jsonTxt";
            this.jsonTxt.Size = new System.Drawing.Size(587, 22);
            this.jsonTxt.TabIndex = 1;
            // 
            // firstNameLbl
            // 
            this.firstNameLbl.AutoSize = true;
            this.firstNameLbl.Location = new System.Drawing.Point(56, 117);
            this.firstNameLbl.Name = "firstNameLbl";
            this.firstNameLbl.Size = new System.Drawing.Size(80, 17);
            this.firstNameLbl.TabIndex = 2;
            this.firstNameLbl.Text = "First Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Last Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 240);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Email:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 303);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Phone";
            // 
            // firstNameTxt
            // 
            this.firstNameTxt.Location = new System.Drawing.Point(163, 111);
            this.firstNameTxt.Name = "firstNameTxt";
            this.firstNameTxt.Size = new System.Drawing.Size(189, 22);
            this.firstNameTxt.TabIndex = 6;
            // 
            // lastNameTxt
            // 
            this.lastNameTxt.Location = new System.Drawing.Point(163, 174);
            this.lastNameTxt.Name = "lastNameTxt";
            this.lastNameTxt.Size = new System.Drawing.Size(189, 22);
            this.lastNameTxt.TabIndex = 7;
            // 
            // emailTxt
            // 
            this.emailTxt.Location = new System.Drawing.Point(163, 235);
            this.emailTxt.Name = "emailTxt";
            this.emailTxt.Size = new System.Drawing.Size(189, 22);
            this.emailTxt.TabIndex = 8;
            // 
            // phoneTxt
            // 
            this.phoneTxt.Location = new System.Drawing.Point(163, 298);
            this.phoneTxt.Name = "phoneTxt";
            this.phoneTxt.Size = new System.Drawing.Size(189, 22);
            this.phoneTxt.TabIndex = 9;
            // 
            // FriendsLstbox
            // 
            this.FriendsLstbox.FormattingEnabled = true;
            this.FriendsLstbox.ItemHeight = 16;
            this.FriendsLstbox.Location = new System.Drawing.Point(468, 204);
            this.FriendsLstbox.Name = "FriendsLstbox";
            this.FriendsLstbox.Size = new System.Drawing.Size(251, 116);
            this.FriendsLstbox.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(465, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Friends";
            // 
            // decodeJsonBtn
            // 
            this.decodeJsonBtn.Location = new System.Drawing.Point(228, 376);
            this.decodeJsonBtn.Name = "decodeJsonBtn";
            this.decodeJsonBtn.Size = new System.Drawing.Size(125, 32);
            this.decodeJsonBtn.TabIndex = 12;
            this.decodeJsonBtn.Text = "Decode JSON";
            this.decodeJsonBtn.UseVisualStyleBackColor = true;
            this.decodeJsonBtn.Click += new System.EventHandler(this.decodeJsonBtn_Click);
            // 
            // createJsonBtn
            // 
            this.createJsonBtn.Location = new System.Drawing.Point(411, 376);
            this.createJsonBtn.Name = "createJsonBtn";
            this.createJsonBtn.Size = new System.Drawing.Size(125, 32);
            this.createJsonBtn.TabIndex = 13;
            this.createJsonBtn.Text = "Create JSON";
            this.createJsonBtn.UseVisualStyleBackColor = true;
            this.createJsonBtn.Click += new System.EventHandler(this.createJsonBtn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(465, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "Add Friends";
            // 
            // friendNameTxt
            // 
            this.friendNameTxt.Location = new System.Drawing.Point(468, 138);
            this.friendNameTxt.Name = "friendNameTxt";
            this.friendNameTxt.Size = new System.Drawing.Size(162, 22);
            this.friendNameTxt.TabIndex = 15;
            // 
            // addFriendBtn
            // 
            this.addFriendBtn.Location = new System.Drawing.Point(636, 134);
            this.addFriendBtn.Name = "addFriendBtn";
            this.addFriendBtn.Size = new System.Drawing.Size(75, 31);
            this.addFriendBtn.TabIndex = 16;
            this.addFriendBtn.Text = "Add";
            this.addFriendBtn.UseVisualStyleBackColor = true;
            this.addFriendBtn.Click += new System.EventHandler(this.addFriendBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 450);
            this.Controls.Add(this.addFriendBtn);
            this.Controls.Add(this.friendNameTxt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.createJsonBtn);
            this.Controls.Add(this.decodeJsonBtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.FriendsLstbox);
            this.Controls.Add(this.phoneTxt);
            this.Controls.Add(this.emailTxt);
            this.Controls.Add(this.lastNameTxt);
            this.Controls.Add(this.firstNameTxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.firstNameLbl);
            this.Controls.Add(this.jsonTxt);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox jsonTxt;
        private System.Windows.Forms.Label firstNameLbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox firstNameTxt;
        private System.Windows.Forms.TextBox lastNameTxt;
        private System.Windows.Forms.TextBox emailTxt;
        private System.Windows.Forms.TextBox phoneTxt;
        private System.Windows.Forms.ListBox FriendsLstbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button decodeJsonBtn;
        private System.Windows.Forms.Button createJsonBtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox friendNameTxt;
        private System.Windows.Forms.Button addFriendBtn;
    }
}

