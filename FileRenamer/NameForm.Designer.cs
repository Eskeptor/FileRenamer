namespace FileRenamer
{
    partial class NameForm
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
            this.nameFrmEdit = new System.Windows.Forms.TextBox();
            this.nameFrmLblContext = new System.Windows.Forms.Label();
            this.nameFrmBtnCancel = new System.Windows.Forms.Button();
            this.nameFrmBtnOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nameFrmEdit
            // 
            this.nameFrmEdit.Location = new System.Drawing.Point(12, 48);
            this.nameFrmEdit.Name = "nameFrmEdit";
            this.nameFrmEdit.Size = new System.Drawing.Size(371, 21);
            this.nameFrmEdit.TabIndex = 0;
            // 
            // nameFrmLblContext
            // 
            this.nameFrmLblContext.AutoSize = true;
            this.nameFrmLblContext.Location = new System.Drawing.Point(13, 22);
            this.nameFrmLblContext.Name = "nameFrmLblContext";
            this.nameFrmLblContext.Size = new System.Drawing.Size(30, 12);
            this.nameFrmLblContext.TabIndex = 1;
            this.nameFrmLblContext.Text = "Test";
            // 
            // nameFrmBtnCancel
            // 
            this.nameFrmBtnCancel.Location = new System.Drawing.Point(297, 87);
            this.nameFrmBtnCancel.Name = "nameFrmBtnCancel";
            this.nameFrmBtnCancel.Size = new System.Drawing.Size(86, 33);
            this.nameFrmBtnCancel.TabIndex = 2;
            this.nameFrmBtnCancel.Text = "취소";
            this.nameFrmBtnCancel.UseVisualStyleBackColor = true;
            this.nameFrmBtnCancel.Click += new System.EventHandler(this.NameFrmBtnCancel_Click);
            // 
            // nameFrmBtnOK
            // 
            this.nameFrmBtnOK.Location = new System.Drawing.Point(205, 87);
            this.nameFrmBtnOK.Name = "nameFrmBtnOK";
            this.nameFrmBtnOK.Size = new System.Drawing.Size(86, 33);
            this.nameFrmBtnOK.TabIndex = 3;
            this.nameFrmBtnOK.Text = "확인";
            this.nameFrmBtnOK.UseVisualStyleBackColor = true;
            this.nameFrmBtnOK.Click += new System.EventHandler(this.NameFrmBtnOK_Click);
            // 
            // NameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 136);
            this.Controls.Add(this.nameFrmBtnOK);
            this.Controls.Add(this.nameFrmBtnCancel);
            this.Controls.Add(this.nameFrmLblContext);
            this.Controls.Add(this.nameFrmEdit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "NameForm";
            this.Text = "NameForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameFrmEdit;
        private System.Windows.Forms.Label nameFrmLblContext;
        private System.Windows.Forms.Button nameFrmBtnCancel;
        private System.Windows.Forms.Button nameFrmBtnOK;
    }
}