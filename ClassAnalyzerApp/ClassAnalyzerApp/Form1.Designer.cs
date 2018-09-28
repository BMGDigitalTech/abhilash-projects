namespace ClassAnalyzerApp
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
            this.typeNameTxtBox = new System.Windows.Forms.TextBox();
            this.getInfoBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.MethodsLstBox = new System.Windows.Forms.ListBox();
            this.PropertiesLstBox = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ConstructorsLstBox = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Type Name";
            // 
            // typeNameTxtBox
            // 
            this.typeNameTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typeNameTxtBox.Location = new System.Drawing.Point(149, 27);
            this.typeNameTxtBox.Name = "typeNameTxtBox";
            this.typeNameTxtBox.Size = new System.Drawing.Size(270, 34);
            this.typeNameTxtBox.TabIndex = 1;
            // 
            // getInfoBtn
            // 
            this.getInfoBtn.Location = new System.Drawing.Point(446, 25);
            this.getInfoBtn.Name = "getInfoBtn";
            this.getInfoBtn.Size = new System.Drawing.Size(289, 39);
            this.getInfoBtn.TabIndex = 2;
            this.getInfoBtn.Text = "Discover Type Information";
            this.getInfoBtn.UseVisualStyleBackColor = true;
            this.getInfoBtn.Click += new System.EventHandler(this.getInfoBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Methods List";
            // 
            // MethodsLstBox
            // 
            this.MethodsLstBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MethodsLstBox.FormattingEnabled = true;
            this.MethodsLstBox.ItemHeight = 25;
            this.MethodsLstBox.Location = new System.Drawing.Point(37, 137);
            this.MethodsLstBox.Name = "MethodsLstBox";
            this.MethodsLstBox.Size = new System.Drawing.Size(251, 379);
            this.MethodsLstBox.TabIndex = 4;
            // 
            // PropertiesLstBox
            // 
            this.PropertiesLstBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PropertiesLstBox.FormattingEnabled = true;
            this.PropertiesLstBox.ItemHeight = 25;
            this.PropertiesLstBox.Location = new System.Drawing.Point(341, 137);
            this.PropertiesLstBox.Name = "PropertiesLstBox";
            this.PropertiesLstBox.Size = new System.Drawing.Size(251, 379);
            this.PropertiesLstBox.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(338, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Properties List";
            // 
            // ConstructorsLstBox
            // 
            this.ConstructorsLstBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConstructorsLstBox.FormattingEnabled = true;
            this.ConstructorsLstBox.ItemHeight = 25;
            this.ConstructorsLstBox.Location = new System.Drawing.Point(650, 137);
            this.ConstructorsLstBox.Name = "ConstructorsLstBox";
            this.ConstructorsLstBox.Size = new System.Drawing.Size(251, 379);
            this.ConstructorsLstBox.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(647, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Constructors List";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 525);
            this.Controls.Add(this.ConstructorsLstBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PropertiesLstBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.MethodsLstBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.getInfoBtn);
            this.Controls.Add(this.typeNameTxtBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox typeNameTxtBox;
        private System.Windows.Forms.Button getInfoBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox MethodsLstBox;
        private System.Windows.Forms.ListBox PropertiesLstBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox ConstructorsLstBox;
        private System.Windows.Forms.Label label4;
    }
}

