using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Windows.Forms;
using System.IO;

namespace FileRenamer
{
    public partial class mainForm : Form
    {
        private ArrayList mArrayList = new ArrayList();
        public string mStrDlgReturn = string.Empty;

        public mainForm()
        {
            InitializeComponent();

            InitControls();
            InitMenu();
        }

        /// <summary>
        /// 컨트롤 초기화
        /// </summary>
        public void InitControls()
        {
            // ===================================================================================
            // 다이얼로그 이름 설정
            string strName = string.Format("{0} {1}", System.Reflection.Assembly.GetExecutingAssembly().GetName().Name.ToString(),
                                                      System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString());
            this.Text = strName;
            // ===================================================================================


            // ===================================================================================
            // 버튼 문자열 리소스 연결
            btnLoad.Text = Properties.Resources.String_Btn_Load;
            btnClearList.Text = Properties.Resources.String_Btn_Clear_List;
            btnRestore.Text = Properties.Resources.String_Btn_Restore;
            btnNameAddFront.Text = Properties.Resources.String_Btn_Name_Add_Front;
            btnNameAddBack.Text = Properties.Resources.String_Btn_Name_Add_Back;
            btnNameClear.Text = Properties.Resources.String_Btn_Name_Clear;
            btnNameClearExt.Text = Properties.Resources.String_Btn_Name_Clear_Ext;
            btnNumFix.Text = Properties.Resources.String_Btn_Num_Fix;
            btnNumAdd.Text = Properties.Resources.String_Btn_Num_Add;
            btnSelUp.Text = Properties.Resources.String_Btn_SelectItem_Up;
            btnSelDown.Text = Properties.Resources.String_Btn_SelectItem_Down;
            btnChangeExtension.Text = Properties.Resources.String_Btn_Extension_Change;
            btnDelExtension.Text = Properties.Resources.String_Btn_Extension_Delete;
            btnApply.Text = Properties.Resources.String_Btn_Apply;
            // ===================================================================================


            // ===================================================================================
            // 버튼 Enabler
            btnClearList.Enabled = false;
            btnRestore.Enabled = false;
            btnNameAddFront.Enabled = false;
            btnNameAddBack.Enabled = false;
            btnNameClear.Enabled = false;
            btnNameClearExt.Enabled = false;
            btnNumFix.Enabled = false;
            btnNumAdd.Enabled = false;
            btnSelUp.Enabled = false;
            btnSelDown.Enabled = false;
            btnChangeExtension.Enabled = false;
            btnDelExtension.Enabled = false;
            btnApply.Enabled = false;
            // ===================================================================================


            // ===================================================================================
            // 리스트 초기화
            listView.Columns.Add(Properties.Resources.String_List_CurName, (int)Global.ListSize.CurName);
            listView.Columns.Add(Properties.Resources.String_List_ReName, (int)Global.ListSize.ReName);
            listView.Columns.Add(Properties.Resources.String_List_FilePath, (int)Global.ListSize.FilePath);
            listView.Columns.Add(Properties.Resources.String_List_FullPath, (int)Global.ListSize.FullPath);
            listView.Columns.Add(Properties.Resources.String_List_FileSize, (int)Global.ListSize.FileSize);
            listView.Columns.Add(Properties.Resources.String_List_ModifyTime, (int)Global.ListSize.ModifyTime);
            listView.Columns.Add(Properties.Resources.String_List_CreateTime, (int)Global.ListSize.CreateTime);

            for (int i = (int)Global.ListColumn.FullPath; i <= (int)Global.ListColumn.CreateTime; i++)
                listView.Columns[i].Width = 0;
            // ===================================================================================

        }

        /// <summary>
        /// 메뉴 초기화
        /// </summary>
        public void InitMenu()
        {
            menuFileExportNameList.Enabled = false;
            menuFileImportNameList.Enabled = false;

            menuEditSelUp.Enabled = false;
            menuEditSelDown.Enabled = false;
        }

        private void RefreshList()
        {
            listView.Items.Clear();

            foreach (FileObject file in mArrayList)
            {
                string[] arrStr = new string[3];
                arrStr[0] = file.BackupFileName + "." + file.BackupFileExtension;
                if (!string.IsNullOrEmpty(file.FileExtension))
                    arrStr[1] = file.FileName + "." + file.FileExtension;
                else
                    arrStr[1] = file.FileName;
                arrStr[2] = file.FilePath;

                ListViewItem listViewItem = new ListViewItem(arrStr);

                listView.Items.Add(listViewItem);
            }
        }

        private void BtnLoad_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = openFileDialog.ShowDialog();
            
            if (dialogResult == DialogResult.OK)
            {
                bool bIsContinue = false;
                foreach (string str in openFileDialog.FileNames)
                {
                    FileObject fileObject = new FileObject();
                    fileObject.SetFile(str);

                    foreach (FileObject file in mArrayList)
                    {
                        if (fileObject.FileFullPath.CompareTo(file.FileFullPath) == 0)
                        {
                            bIsContinue = true;
                            break;
                        }
                    }

                    if (!bIsContinue)
                        mArrayList.Add(fileObject);
                    else
                        bIsContinue = false;
                }

                RefreshList();

                if (mArrayList.Count > 0)
                {
                    btnClearList.Enabled = true;
                    btnRestore.Enabled = true;
                    btnNameAddFront.Enabled = true;
                    btnNameAddBack.Enabled = true;
                    btnNameClear.Enabled = true;
                    btnNameClearExt.Enabled = true;
                    btnNumFix.Enabled = true;
                    btnNumAdd.Enabled = true;
                    btnSelUp.Enabled = true;
                    btnSelDown.Enabled = true;
                    btnChangeExtension.Enabled = true;
                    btnDelExtension.Enabled = true;
                    btnApply.Enabled = true;
                }
            }
        }

        private void BtnClearList_Click(object sender, EventArgs e)
        {
            mArrayList.Clear();
            listView.Items.Clear();
        }

        private void BtnRestore_Click(object sender, EventArgs e)
        {
            foreach (FileObject file in mArrayList)
            {
                file.FileName = file.BackupFileName;
                file.FilePath = file.BackupFilePath;
                file.FileFullPath = file.BackupFileFullPath;
                file.FileExtension = file.BackupFileExtension;
            }

            RefreshList();
        }

        private void BtnNameAddFront_Click(object sender, EventArgs e)
        {
            using (NameForm nameForm = new NameForm())
            {
                nameForm.SetFormType(Global.FormType.AddNameFront);
                nameForm.Owner = this;
                DialogResult result = nameForm.ShowDialog();

                if (result == DialogResult.OK)
                {
                    if (!string.IsNullOrEmpty(mStrDlgReturn))
                    {
                        foreach (FileObject file in mArrayList)
                            file.FileName = mStrDlgReturn + file.FileName;

                        RefreshList();
                    }
                    mStrDlgReturn = string.Empty;
                }
            }
        }

        private void BtnNameAddBack_Click(object sender, EventArgs e)
        {
            using (NameForm nameForm = new NameForm())
            {
                nameForm.SetFormType(Global.FormType.AddNameBack);
                nameForm.Owner = this;
                DialogResult result = nameForm.ShowDialog();

                if (result == DialogResult.OK)
                {
                    if (!string.IsNullOrEmpty(mStrDlgReturn))
                    {
                        foreach (FileObject file in mArrayList)
                            file.FileName += mStrDlgReturn;

                        RefreshList();
                    }
                    mStrDlgReturn = string.Empty;
                }
            }
        }

        private void BtnNameClear_Click(object sender, EventArgs e)
        {
            foreach (FileObject file in mArrayList)
                file.FileName = string.Empty;

            RefreshList();
        }

        private void BtnNameClearExt_Click(object sender, EventArgs e)
        {

        }

        private void BtnNumFix_Click(object sender, EventArgs e)
        {

        }

        private void BtnNumAdd_Click(object sender, EventArgs e)
        {

        }

        private void BtnSelUp_Click(object sender, EventArgs e)
        {

        }

        private void BtnChangeExtension_Click(object sender, EventArgs e)
        {
            using (NameForm nameForm = new NameForm())
            {
                nameForm.SetFormType(Global.FormType.ChangeExtension);
                nameForm.Owner = this;
                DialogResult result = nameForm.ShowDialog();

                if (result == DialogResult.OK)
                {
                    if (!string.IsNullOrEmpty(mStrDlgReturn))
                    {
                        foreach (FileObject file in mArrayList)
                            file.FileExtension = mStrDlgReturn;

                        RefreshList();
                    }
                    mStrDlgReturn = string.Empty;
                }
            }
        }

        private void BtnSelDown_Click(object sender, EventArgs e)
        {

        }

        private void BtnDelExtension_Click(object sender, EventArgs e)
        {
            foreach (FileObject file in mArrayList)
                file.FileExtension = string.Empty;

            RefreshList();
        }

        private void BtnApply_Click(object sender, EventArgs e)
        {

        }

        private void MenuViewFullPath_Click(object sender, EventArgs e)
        {
            if (menuViewFullPath.Checked)
                listView.Columns[(int)Global.ListColumn.FullPath].Width = 0;
            else
                listView.Columns[(int)Global.ListColumn.FullPath].Width = (int)Global.ListSize.FullPath;

            menuViewFullPath.Checked = !menuViewFullPath.Checked;
        }

        private void MenuViewFileSize_Click(object sender, EventArgs e)
        {
            if (menuViewFileSize.Checked)
                listView.Columns[(int)Global.ListColumn.FileSize].Width = 0;
            else
                listView.Columns[(int)Global.ListColumn.FileSize].Width = (int)Global.ListSize.FileSize;

            menuViewFileSize.Checked = !menuViewFileSize.Checked;
        }

        private void MenuViewChangeTime_Click(object sender, EventArgs e)
        {
            if (menuViewChangeTime.Checked)
                listView.Columns[(int)Global.ListColumn.ModifyTime].Width = 0;
            else
                listView.Columns[(int)Global.ListColumn.ModifyTime].Width = (int)Global.ListSize.ModifyTime;

            menuViewChangeTime.Checked = !menuViewChangeTime.Checked;
        }

        private void MenuViewCreateTime_Click(object sender, EventArgs e)
        {
            if (menuViewCreateTime.Checked)
                listView.Columns[(int)Global.ListColumn.CreateTime].Width = 0;
            else
                listView.Columns[(int)Global.ListColumn.CreateTime].Width = (int)Global.ListSize.CreateTime;

            menuViewCreateTime.Checked = !menuViewCreateTime.Checked;
        }

        private void MenuFileAdd_Click(object sender, EventArgs e)
        {
            BtnLoad_Click(null, null);
        }
    }
}
