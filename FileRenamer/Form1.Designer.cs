namespace FileRenamer
{
    partial class mainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFileAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuFileExportNameList = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFileImportNameList = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.menuFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEditSelUp = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEditSelDown = new System.Windows.Forms.ToolStripMenuItem();
            this.menuView = new System.Windows.Forms.ToolStripMenuItem();
            this.menuViewFullPath = new System.Windows.Forms.ToolStripMenuItem();
            this.menuViewFileSize = new System.Windows.Forms.ToolStripMenuItem();
            this.menuViewChangeTime = new System.Windows.Forms.ToolStripMenuItem();
            this.menuViewCreateTime = new System.Windows.Forms.ToolStripMenuItem();
            this.menuInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.listView = new System.Windows.Forms.ListView();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnNameAddFront = new System.Windows.Forms.Button();
            this.btnSelDel = new System.Windows.Forms.Button();
            this.btnNameClear = new System.Windows.Forms.Button();
            this.btnNameClearExt = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.btnNumFix = new System.Windows.Forms.Button();
            this.btnNumAdd = new System.Windows.Forms.Button();
            this.btnClearList = new System.Windows.Forms.Button();
            this.btnRestore = new System.Windows.Forms.Button();
            this.btnDelExtension = new System.Windows.Forms.Button();
            this.btnChangeExtension = new System.Windows.Forms.Button();
            this.btnSelUp = new System.Windows.Forms.Button();
            this.btnSelDown = new System.Windows.Forms.Button();
            this.btnApply = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFile,
            this.menuEdit,
            this.menuView,
            this.menuInfo});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1007, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuFile
            // 
            this.menuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFileAdd,
            this.toolStripMenuItem1,
            this.menuFileExportNameList,
            this.menuFileImportNameList,
            this.toolStripMenuItem2,
            this.menuFileExit});
            this.menuFile.Name = "menuFile";
            this.menuFile.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F)));
            this.menuFile.ShowShortcutKeys = false;
            this.menuFile.Size = new System.Drawing.Size(57, 20);
            this.menuFile.Text = "파일(&F)";
            // 
            // menuFileAdd
            // 
            this.menuFileAdd.Name = "menuFileAdd";
            this.menuFileAdd.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.menuFileAdd.Size = new System.Drawing.Size(302, 22);
            this.menuFileAdd.Text = "파일 추가";
            this.menuFileAdd.Click += new System.EventHandler(this.MenuFileAdd_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(299, 6);
            // 
            // menuFileExportNameList
            // 
            this.menuFileExportNameList.Name = "menuFileExportNameList";
            this.menuFileExportNameList.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.menuFileExportNameList.Size = new System.Drawing.Size(302, 22);
            this.menuFileExportNameList.Text = "바꿀이름 파일로 내보내기";
            this.menuFileExportNameList.Click += new System.EventHandler(this.menuFileExportNameList_Click);
            // 
            // menuFileImportNameList
            // 
            this.menuFileImportNameList.Name = "menuFileImportNameList";
            this.menuFileImportNameList.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.O)));
            this.menuFileImportNameList.Size = new System.Drawing.Size(302, 22);
            this.menuFileImportNameList.Text = "바꿀이름 파일에서 불러오기";
            this.menuFileImportNameList.Click += new System.EventHandler(this.menuFileImportNameList_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(299, 6);
            // 
            // menuFileExit
            // 
            this.menuFileExit.Name = "menuFileExit";
            this.menuFileExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.X)));
            this.menuFileExit.Size = new System.Drawing.Size(302, 22);
            this.menuFileExit.Text = "종료";
            // 
            // menuEdit
            // 
            this.menuEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuEditSelUp,
            this.menuEditSelDown});
            this.menuEdit.Name = "menuEdit";
            this.menuEdit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.E)));
            this.menuEdit.ShowShortcutKeys = false;
            this.menuEdit.Size = new System.Drawing.Size(57, 20);
            this.menuEdit.Text = "편집(&E)";
            // 
            // menuEditSelUp
            // 
            this.menuEditSelUp.Name = "menuEditSelUp";
            this.menuEditSelUp.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Up)));
            this.menuEditSelUp.Size = new System.Drawing.Size(204, 22);
            this.menuEditSelUp.Text = "위로 올림";
            this.menuEditSelUp.Click += new System.EventHandler(this.menuEditSelUp_Click);
            // 
            // menuEditSelDown
            // 
            this.menuEditSelDown.Name = "menuEditSelDown";
            this.menuEditSelDown.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Down)));
            this.menuEditSelDown.Size = new System.Drawing.Size(204, 22);
            this.menuEditSelDown.Text = "아래로 내림";
            this.menuEditSelDown.Click += new System.EventHandler(this.menuEditSelDown_Click);
            // 
            // menuView
            // 
            this.menuView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuViewFullPath,
            this.menuViewFileSize,
            this.menuViewChangeTime,
            this.menuViewCreateTime});
            this.menuView.Name = "menuView";
            this.menuView.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.V)));
            this.menuView.ShowShortcutKeys = false;
            this.menuView.Size = new System.Drawing.Size(59, 20);
            this.menuView.Text = "보기(&V)";
            // 
            // menuViewFullPath
            // 
            this.menuViewFullPath.Name = "menuViewFullPath";
            this.menuViewFullPath.Size = new System.Drawing.Size(154, 22);
            this.menuViewFullPath.Text = "전체 경로 표시";
            this.menuViewFullPath.Click += new System.EventHandler(this.MenuViewFullPath_Click);
            // 
            // menuViewFileSize
            // 
            this.menuViewFileSize.Name = "menuViewFileSize";
            this.menuViewFileSize.Size = new System.Drawing.Size(154, 22);
            this.menuViewFileSize.Text = "파일 크기 표시";
            this.menuViewFileSize.Click += new System.EventHandler(this.MenuViewFileSize_Click);
            // 
            // menuViewChangeTime
            // 
            this.menuViewChangeTime.Name = "menuViewChangeTime";
            this.menuViewChangeTime.Size = new System.Drawing.Size(154, 22);
            this.menuViewChangeTime.Text = "변경 시각 표시";
            this.menuViewChangeTime.Click += new System.EventHandler(this.MenuViewChangeTime_Click);
            // 
            // menuViewCreateTime
            // 
            this.menuViewCreateTime.Name = "menuViewCreateTime";
            this.menuViewCreateTime.Size = new System.Drawing.Size(154, 22);
            this.menuViewCreateTime.Text = "생성 시각 표시";
            this.menuViewCreateTime.Click += new System.EventHandler(this.MenuViewCreateTime_Click);
            // 
            // menuInfo
            // 
            this.menuInfo.Name = "menuInfo";
            this.menuInfo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.I)));
            this.menuInfo.ShowShortcutKeys = false;
            this.menuInfo.Size = new System.Drawing.Size(54, 20);
            this.menuInfo.Text = "정보(&I)";
            this.menuInfo.Click += new System.EventHandler(this.menuInfo_Click);
            // 
            // listView
            // 
            this.listView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView.FullRowSelect = true;
            this.listView.GridLines = true;
            this.listView.HideSelection = false;
            this.listView.Location = new System.Drawing.Point(0, 27);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(779, 521);
            this.listView.TabIndex = 1;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            this.listView.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listView_ItemSelectionChanged);
            // 
            // btnLoad
            // 
            this.btnLoad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLoad.Location = new System.Drawing.Point(785, 27);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(216, 40);
            this.btnLoad.TabIndex = 0;
            this.btnLoad.Text = "불러오기";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.BtnLoad_Click);
            // 
            // btnNameAddFront
            // 
            this.btnNameAddFront.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNameAddFront.Location = new System.Drawing.Point(785, 119);
            this.btnNameAddFront.Name = "btnNameAddFront";
            this.btnNameAddFront.Size = new System.Drawing.Size(106, 40);
            this.btnNameAddFront.TabIndex = 3;
            this.btnNameAddFront.Text = "이름 추가";
            this.btnNameAddFront.UseVisualStyleBackColor = true;
            this.btnNameAddFront.Click += new System.EventHandler(this.BtnNameAddFront_Click);
            // 
            // btnSelDel
            // 
            this.btnSelDel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelDel.Location = new System.Drawing.Point(895, 303);
            this.btnSelDel.Name = "btnSelDel";
            this.btnSelDel.Size = new System.Drawing.Size(106, 40);
            this.btnSelDel.TabIndex = 4;
            this.btnSelDel.Text = "선택항목 삭제";
            this.btnSelDel.UseVisualStyleBackColor = true;
            this.btnSelDel.Click += new System.EventHandler(this.BtnNameDelete);
            // 
            // btnNameClear
            // 
            this.btnNameClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNameClear.Location = new System.Drawing.Point(895, 165);
            this.btnNameClear.Name = "btnNameClear";
            this.btnNameClear.Size = new System.Drawing.Size(106, 40);
            this.btnNameClear.TabIndex = 5;
            this.btnNameClear.Text = "이름 지우기";
            this.btnNameClear.UseVisualStyleBackColor = true;
            this.btnNameClear.Click += new System.EventHandler(this.BtnNameClear_Click);
            // 
            // btnNameClearExt
            // 
            this.btnNameClearExt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNameClearExt.Location = new System.Drawing.Point(895, 119);
            this.btnNameClearExt.Name = "btnNameClearExt";
            this.btnNameClearExt.Size = new System.Drawing.Size(106, 40);
            this.btnNameClearExt.TabIndex = 6;
            this.btnNameClearExt.Text = "이름 변경\r\n(특정 위치)";
            this.btnNameClearExt.UseVisualStyleBackColor = true;
            this.btnNameClearExt.Click += new System.EventHandler(this.BtnNameClearExt_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 551);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1007, 22);
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // btnNumFix
            // 
            this.btnNumFix.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNumFix.Enabled = false;
            this.btnNumFix.Location = new System.Drawing.Point(785, 165);
            this.btnNumFix.Name = "btnNumFix";
            this.btnNumFix.Size = new System.Drawing.Size(106, 40);
            this.btnNumFix.TabIndex = 7;
            this.btnNumFix.Text = "자릿수 맞추기";
            this.btnNumFix.UseVisualStyleBackColor = true;
            this.btnNumFix.Click += new System.EventHandler(this.BtnNumFix_Click);
            // 
            // btnNumAdd
            // 
            this.btnNumAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNumAdd.Location = new System.Drawing.Point(785, 211);
            this.btnNumAdd.Name = "btnNumAdd";
            this.btnNumAdd.Size = new System.Drawing.Size(106, 40);
            this.btnNumAdd.TabIndex = 8;
            this.btnNumAdd.Text = "번호 붙이기";
            this.btnNumAdd.UseVisualStyleBackColor = true;
            this.btnNumAdd.Click += new System.EventHandler(this.BtnNumAdd_Click);
            // 
            // btnClearList
            // 
            this.btnClearList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClearList.Location = new System.Drawing.Point(785, 73);
            this.btnClearList.Name = "btnClearList";
            this.btnClearList.Size = new System.Drawing.Size(106, 40);
            this.btnClearList.TabIndex = 1;
            this.btnClearList.Text = "목록 지우기";
            this.btnClearList.UseVisualStyleBackColor = true;
            this.btnClearList.Click += new System.EventHandler(this.BtnClearList_Click);
            // 
            // btnRestore
            // 
            this.btnRestore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRestore.Location = new System.Drawing.Point(895, 73);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(106, 40);
            this.btnRestore.TabIndex = 2;
            this.btnRestore.Text = "원래대로 복구";
            this.btnRestore.UseVisualStyleBackColor = true;
            this.btnRestore.Click += new System.EventHandler(this.BtnRestore_Click);
            // 
            // btnDelExtension
            // 
            this.btnDelExtension.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelExtension.Location = new System.Drawing.Point(895, 257);
            this.btnDelExtension.Name = "btnDelExtension";
            this.btnDelExtension.Size = new System.Drawing.Size(106, 40);
            this.btnDelExtension.TabIndex = 12;
            this.btnDelExtension.Text = "확장자 삭제";
            this.btnDelExtension.UseVisualStyleBackColor = true;
            this.btnDelExtension.Click += new System.EventHandler(this.BtnDelExtension_Click);
            // 
            // btnChangeExtension
            // 
            this.btnChangeExtension.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChangeExtension.Location = new System.Drawing.Point(895, 211);
            this.btnChangeExtension.Name = "btnChangeExtension";
            this.btnChangeExtension.Size = new System.Drawing.Size(106, 40);
            this.btnChangeExtension.TabIndex = 10;
            this.btnChangeExtension.Text = "확장자 변경";
            this.btnChangeExtension.UseVisualStyleBackColor = true;
            this.btnChangeExtension.Click += new System.EventHandler(this.BtnChangeExtension_Click);
            // 
            // btnSelUp
            // 
            this.btnSelUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelUp.Location = new System.Drawing.Point(785, 257);
            this.btnSelUp.Name = "btnSelUp";
            this.btnSelUp.Size = new System.Drawing.Size(106, 40);
            this.btnSelUp.TabIndex = 9;
            this.btnSelUp.Text = "선택항목 위로";
            this.btnSelUp.UseVisualStyleBackColor = true;
            this.btnSelUp.Click += new System.EventHandler(this.BtnSelUp_Click);
            // 
            // btnSelDown
            // 
            this.btnSelDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelDown.Location = new System.Drawing.Point(785, 303);
            this.btnSelDown.Name = "btnSelDown";
            this.btnSelDown.Size = new System.Drawing.Size(106, 40);
            this.btnSelDown.TabIndex = 11;
            this.btnSelDown.Text = "선택항목 아래로";
            this.btnSelDown.UseVisualStyleBackColor = true;
            this.btnSelDown.Click += new System.EventHandler(this.BtnSelDown_Click);
            // 
            // btnApply
            // 
            this.btnApply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnApply.Location = new System.Drawing.Point(785, 349);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(216, 40);
            this.btnApply.TabIndex = 13;
            this.btnApply.Text = "변경사항 적용";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.BtnApply_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "모든 파일 (*.*)|*.*";
            this.openFileDialog.Multiselect = true;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 573);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.btnSelDown);
            this.Controls.Add(this.btnSelUp);
            this.Controls.Add(this.btnChangeExtension);
            this.Controls.Add(this.btnDelExtension);
            this.Controls.Add(this.btnRestore);
            this.Controls.Add(this.btnClearList);
            this.Controls.Add(this.btnNumAdd);
            this.Controls.Add(this.btnNumFix);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnNameClearExt);
            this.Controls.Add(this.btnNameClear);
            this.Controls.Add(this.btnSelDel);
            this.Controls.Add(this.btnNameAddFront);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "mainForm";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuFile;
        private System.Windows.Forms.ToolStripMenuItem menuFileAdd;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem menuFileExportNameList;
        private System.Windows.Forms.ToolStripMenuItem menuFileImportNameList;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem menuFileExit;
        private System.Windows.Forms.ToolStripMenuItem menuEdit;
        private System.Windows.Forms.ToolStripMenuItem menuEditSelUp;
        private System.Windows.Forms.ToolStripMenuItem menuEditSelDown;
        private System.Windows.Forms.ToolStripMenuItem menuView;
        private System.Windows.Forms.ToolStripMenuItem menuViewFullPath;
        private System.Windows.Forms.ToolStripMenuItem menuViewFileSize;
        private System.Windows.Forms.ToolStripMenuItem menuViewChangeTime;
        private System.Windows.Forms.ToolStripMenuItem menuViewCreateTime;
        private System.Windows.Forms.ToolStripMenuItem menuInfo;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnNameAddFront;
        private System.Windows.Forms.Button btnSelDel;
        private System.Windows.Forms.Button btnNameClear;
        private System.Windows.Forms.Button btnNameClearExt;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Button btnNumFix;
        private System.Windows.Forms.Button btnNumAdd;
        private System.Windows.Forms.Button btnClearList;
        private System.Windows.Forms.Button btnRestore;
        private System.Windows.Forms.Button btnDelExtension;
        private System.Windows.Forms.Button btnChangeExtension;
        private System.Windows.Forms.Button btnSelUp;
        private System.Windows.Forms.Button btnSelDown;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
    }
}

