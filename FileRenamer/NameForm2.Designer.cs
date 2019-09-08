namespace FileRenamer
{
    partial class NameForm2
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
            this.nameFrm2BtnOK = new System.Windows.Forms.Button();
            this.nameFrmBtn2Cancel = new System.Windows.Forms.Button();
            this.nameFrm2LblContext1 = new System.Windows.Forms.Label();
            this.nameFrm2Edit1 = new System.Windows.Forms.TextBox();
            this.nameFrm2LblContext2 = new System.Windows.Forms.Label();
            this.nameFrm2Edit2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // nameFrm2BtnOK
            // 
            this.nameFrm2BtnOK.Location = new System.Drawing.Point(206, 151);
            this.nameFrm2BtnOK.Name = "nameFrm2BtnOK";
            this.nameFrm2BtnOK.Size = new System.Drawing.Size(86, 33);
            this.nameFrm2BtnOK.TabIndex = 3;
            this.nameFrm2BtnOK.Text = "확인";
            this.nameFrm2BtnOK.UseVisualStyleBackColor = true;
            this.nameFrm2BtnOK.Click += new System.EventHandler(this.NameFrm2BtnOK_Click);
            // 
            // nameFrmBtn2Cancel
            // 
            this.nameFrmBtn2Cancel.Location = new System.Drawing.Point(298, 151);
            this.nameFrmBtn2Cancel.Name = "nameFrmBtn2Cancel";
            this.nameFrmBtn2Cancel.Size = new System.Drawing.Size(86, 33);
            this.nameFrmBtn2Cancel.TabIndex = 4;
            this.nameFrmBtn2Cancel.Text = "취소";
            this.nameFrmBtn2Cancel.UseVisualStyleBackColor = true;
            this.nameFrmBtn2Cancel.Click += new System.EventHandler(this.NameFrmBtn2Cancel_Click);
            // 
            // nameFrm2LblContext1
            // 
            this.nameFrm2LblContext1.AutoSize = true;
            this.nameFrm2LblContext1.Location = new System.Drawing.Point(13, 22);
            this.nameFrm2LblContext1.Name = "nameFrm2LblContext1";
            this.nameFrm2LblContext1.Size = new System.Drawing.Size(30, 12);
            this.nameFrm2LblContext1.TabIndex = 5;
            this.nameFrm2LblContext1.Text = "Test";
            // 
            // nameFrm2Edit1
            // 
            this.nameFrm2Edit1.Location = new System.Drawing.Point(12, 48);
            this.nameFrm2Edit1.Name = "nameFrm2Edit1";
            this.nameFrm2Edit1.Size = new System.Drawing.Size(372, 21);
            this.nameFrm2Edit1.TabIndex = 1;
            // 
            // nameFrm2LblContext2
            // 
            this.nameFrm2LblContext2.AutoSize = true;
            this.nameFrm2LblContext2.Location = new System.Drawing.Point(13, 86);
            this.nameFrm2LblContext2.Name = "nameFrm2LblContext2";
            this.nameFrm2LblContext2.Size = new System.Drawing.Size(30, 12);
            this.nameFrm2LblContext2.TabIndex = 9;
            this.nameFrm2LblContext2.Text = "Test";
            // 
            // nameFrm2Edit2
            // 
            this.nameFrm2Edit2.Location = new System.Drawing.Point(12, 112);
            this.nameFrm2Edit2.Name = "nameFrm2Edit2";
            this.nameFrm2Edit2.Size = new System.Drawing.Size(372, 21);
            this.nameFrm2Edit2.TabIndex = 2;
            // 
            // NameForm2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 196);
            this.Controls.Add(this.nameFrm2LblContext2);
            this.Controls.Add(this.nameFrm2Edit2);
            this.Controls.Add(this.nameFrm2BtnOK);
            this.Controls.Add(this.nameFrmBtn2Cancel);
            this.Controls.Add(this.nameFrm2LblContext1);
            this.Controls.Add(this.nameFrm2Edit1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "NameForm2";
            this.Text = "NameForm2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button nameFrm2BtnOK;
        private System.Windows.Forms.Button nameFrmBtn2Cancel;
        private System.Windows.Forms.Label nameFrm2LblContext1;
        private System.Windows.Forms.TextBox nameFrm2Edit1;
        private System.Windows.Forms.Label nameFrm2LblContext2;
        private System.Windows.Forms.TextBox nameFrm2Edit2;
    }
}