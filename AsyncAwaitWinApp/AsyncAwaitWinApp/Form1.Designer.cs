namespace AsyncAwaitWinApp
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
            this.MyBtn = new System.Windows.Forms.Button();
            this.MyLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // MyBtn
            // 
            this.MyBtn.Location = new System.Drawing.Point(273, 105);
            this.MyBtn.Name = "MyBtn";
            this.MyBtn.Size = new System.Drawing.Size(168, 23);
            this.MyBtn.TabIndex = 0;
            this.MyBtn.Text = "Count File Char";
            this.MyBtn.UseVisualStyleBackColor = true;
            this.MyBtn.Click += new System.EventHandler(this.MyBtn_Click);
            // 
            // MyLbl
            // 
            this.MyLbl.AutoSize = true;
            this.MyLbl.Location = new System.Drawing.Point(326, 171);
            this.MyLbl.Name = "MyLbl";
            this.MyLbl.Size = new System.Drawing.Size(0, 17);
            this.MyLbl.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MyLbl);
            this.Controls.Add(this.MyBtn);
            this.Name = "Form1";
            this.Text = "No of chars in file";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button MyBtn;
        private System.Windows.Forms.Label MyLbl;
    }
}

