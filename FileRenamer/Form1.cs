﻿using System;
using System.Collections;
using System.IO;
using System.Windows.Forms;
using System.Text;
using System.Collections.Generic;
using RString = FileRenamer.Properties.Resources;

namespace FileRenamer
{
    public partial class mainForm : Form
    {
        private List<FileObject> mFileList = new List<FileObject>();
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
            // 다이얼로그 이름 설정
            {
                string strName = string.Format("{0} {1}", System.Reflection.Assembly.GetExecutingAssembly().GetName().Name.ToString(),
                                                          System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString());
                Text = strName;
            }


            // 버튼 문자열 리소스 연결
            {
                btnLoad.Text = RString.String_Btn_Load;
                btnClearList.Text = RString.String_Btn_Clear_List;
                btnRestore.Text = RString.String_Btn_Restore;
                btnNameAddFront.Text = RString.String_Btn_Name_Add;
                btnSelDel.Text = RString.String_Btn_SelectItem_Del;
                btnNameClear.Text = RString.String_Btn_Name_Clear;
                btnNameClearExt.Text = RString.String_Btn_Name_Clear_Ext;
                btnNumFix.Text = RString.String_Btn_Num_Fix;
                btnNumAdd.Text = RString.String_Btn_Num_Add;
                btnSelUp.Text = RString.String_Btn_SelectItem_Up;
                btnSelDown.Text = RString.String_Btn_SelectItem_Down;
                btnChangeExtension.Text = RString.String_Btn_Extension_Change;
                btnDelExtension.Text = RString.String_Btn_Extension_Delete;
                btnApply.Text = RString.String_Btn_Apply;
            }


            // 버튼 Enabler
            {
                InitButton(false);
            }


            // 리스트 초기화
            {
                listView.Columns.Add(RString.String_List_CurName, (int)Global.ListSize.CurName);
                listView.Columns.Add(RString.String_List_ReName, (int)Global.ListSize.ReName);
                listView.Columns.Add(RString.String_List_FilePath, (int)Global.ListSize.FilePath);
                listView.Columns.Add(RString.String_List_FullPath, (int)Global.ListSize.FullPath);
                listView.Columns.Add(RString.String_List_FileSize, (int)Global.ListSize.FileSize);
                listView.Columns.Add(RString.String_List_ModifyTime, (int)Global.ListSize.ModifyTime);
                listView.Columns.Add(RString.String_List_CreateTime, (int)Global.ListSize.CreateTime);

                for (int i = (int)Global.ListColumn.FullPath; i <= (int)Global.ListColumn.CreateTime; i++)
                    listView.Columns[i].Width = 0;
            }

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

        /// <summary>
        /// 버튼을 초기화 합니다.
        /// </summary>
        /// <param name="bEnabled">초기화 값</param>
        public void InitButton(bool bEnabled)
        {
            btnClearList.Enabled = bEnabled;
            btnRestore.Enabled = bEnabled;
            btnNameAddFront.Enabled = bEnabled;
            btnSelDel.Enabled = bEnabled;
            btnNameClear.Enabled = bEnabled;
            btnNameClearExt.Enabled = bEnabled;
            //btnNumFix.Enabled = bEnabled;
            btnNumAdd.Enabled = bEnabled;
            btnSelUp.Enabled = bEnabled;
            btnSelDown.Enabled = bEnabled;
            btnChangeExtension.Enabled = bEnabled;
            btnDelExtension.Enabled = bEnabled;
            btnApply.Enabled = bEnabled;
        }

        /// <summary>
        /// 메인 ListView의 아이템을 갱신합니다.
        /// (리스트 Clear 이후 갱신)
        /// </summary>
        /// <param name="bIsBackupFullPathClear">BackupFullPath를 FileFullPath로 초기화 할지 유무</param>
        private void RefreshList(bool bIsBackupFullPathClear = false)
        {
            listView.Items.Clear();

            listView.BeginUpdate();
            foreach (FileObject file in mFileList)
            {
                string[] arrStr = new string[(int)Global.ListColumn.Max];
                arrStr[(int)Global.ListColumn.CurName] = file.BackupFileName + "." + file.BackupFileExtension;
                if (!string.IsNullOrEmpty(file.FileExtension))
                    arrStr[(int)Global.ListColumn.ReName] = file.FileName + "." + file.FileExtension;
                else
                    arrStr[(int)Global.ListColumn.ReName] = file.FileName;
                arrStr[(int)Global.ListColumn.FilePath] = file.FilePath;
                file.FileFullPath = file.FilePath + file.FileName + "." + file.FileExtension;
                if (bIsBackupFullPathClear)
                    file.BackupFileFullPath = file.FileFullPath;
                arrStr[(int)Global.ListColumn.FullPath] = file.FileFullPath;
                arrStr[(int)Global.ListColumn.FileSize] = file.FileSize.ToString() + " KB";
                arrStr[(int)Global.ListColumn.ModifyTime] = file.ModifyTime;
                arrStr[(int)Global.ListColumn.CreateTime] = file.CreateTime;

                ListViewItem listViewItem = new ListViewItem(arrStr);

                listView.Items.Add(listViewItem);
            }
            listView.EndUpdate();
        }

        /// <summary>
        /// 메인 ListView에 파일 목록을 추가하는 함수
        /// </summary>
        /// <param name="strFileNames">추가할 파일 경로 목록</param>
        private void AddList(string[] strFileNames)
        {
            if (strFileNames.Length <= 0)
                return;

            bool bIsContinue = false;
            foreach (string str in strFileNames)
            {
                FileObject fileObject = new FileObject();
                fileObject.SetFile(str);

                foreach (FileObject file in mFileList)
                {
                    if (fileObject.FileFullPath.CompareTo(file.FileFullPath) == 0)
                    {
                        bIsContinue = true;
                        break;
                    }
                }

                if (!bIsContinue)
                    mFileList.Add(fileObject);
                else
                    bIsContinue = false;
            }

            RefreshList();

            if (mFileList.Count > 0)
            {
                btnClearList.Enabled = true;
                btnRestore.Enabled = true;
                btnNameAddFront.Enabled = true;
                btnSelDel.Enabled = true;
                btnNameClear.Enabled = true;
                btnNameClearExt.Enabled = true;
                //btnNumFix.Enabled = true;
                btnNumAdd.Enabled = true;
                btnChangeExtension.Enabled = true;
                btnDelExtension.Enabled = true;
                btnApply.Enabled = true;
                menuFileImportNameList.Enabled = true;
                menuFileExportNameList.Enabled = true;
            }
        }

        /// <summary>
        /// 불러오기 버튼
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnLoad_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = openFileDialog.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                AddList(openFileDialog.FileNames);
            }
        }

        /// <summary>
        /// 목록 지우기 버튼
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnClearList_Click(object sender, EventArgs e)
        {
            mFileList.Clear();
            listView.Items.Clear();

            btnClearList.Enabled = false;
            btnRestore.Enabled = false;
            btnNameAddFront.Enabled = false;
            btnSelDel.Enabled = false;
            btnNameClear.Enabled = false;
            btnNameClearExt.Enabled = false;
            btnNumFix.Enabled = false;
            btnNumAdd.Enabled = false;
            btnSelUp.Enabled = false;
            btnSelDown.Enabled = false;
            btnChangeExtension.Enabled = false;
            btnDelExtension.Enabled = false;
            btnApply.Enabled = false;

            InitMenu();
        }

        /// <summary>
        /// 원래대로 복구 버튼
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnRestore_Click(object sender, EventArgs e)
        {
            foreach (FileObject file in mFileList)
            {
                file.FileName = file.BackupFileName;
                file.FilePath = file.BackupFilePath;
                file.FileFullPath = file.BackupFileFullPath;
                file.FileExtension = file.BackupFileExtension;
            }

            RefreshList();
        }

        /// <summary>
        /// 이름 추가 버튼
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnNameAddFront_Click(object sender, EventArgs e)
        {
            using (NameForm nameForm = new NameForm())
            {
                nameForm.SetFormType(Global.FormType.AddName);
                nameForm.Owner = this;
                DialogResult result = nameForm.ShowDialog();

                if (result == DialogResult.OK)
                {
                    if (!string.IsNullOrEmpty(mStrDlgReturn))
                    {
                        // mStrDlgReturn 데이터 스플릿
                        // [0] = 문자열을 넣을 위치
                        // [1] = 넣을 문자열
                        string[] strToken = mStrDlgReturn.Split(',');

                        if (strToken.Length == 2)
                        {
                            if (strToken[0].CompareTo("0") == 0)    // 앞에 추가
                            {
                                foreach (FileObject file in mFileList)
                                    file.FileName = strToken[1] + file.FileName;
                            }
                            else                                    // 뒤에 추가
                            {
                                foreach (FileObject file in mFileList)
                                    file.FileName = file.FileName + strToken[1];
                            }
                        }

                        RefreshList();
                    }
                    mStrDlgReturn = string.Empty;
                }
            }
        }

        /// <summary>
        /// 이름 지우기 버튼
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnNameClear_Click(object sender, EventArgs e)
        {
            foreach (FileObject file in mFileList)
                file.FileName = string.Empty;

            RefreshList();
        }

        /// <summary>
        /// 이름 변경(특정 위치)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnNameClearExt_Click(object sender, EventArgs e)
        {
            using (NameForm2 nameForm = new NameForm2())
            {
                nameForm.Owner = this;

                DialogResult result = nameForm.ShowDialog();
                if (result == DialogResult.OK)
                {
                    if (!string.IsNullOrEmpty(mStrDlgReturn))
                    {
                        // mStrDlgReturn 데이터 스플릿
                        // [0] = 대상 문자열
                        // [1] = 변경 문자열
                        string[] strToken = mStrDlgReturn.Split(',');

                        if (strToken.Length == 2)
                        {
                            foreach (FileObject file in mFileList)
                            {
                                file.FileName = file.FileName.Replace(strToken[0], strToken[1]);
                            }
                        }

                        RefreshList();
                    }
                    mStrDlgReturn = string.Empty;
                }
            }
        }

        /// <summary>
        /// 자릿수 맞추기 버튼
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnNumFix_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 번호 붙이기 버튼
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnNumAdd_Click(object sender, EventArgs e)
        {
            using (NumberForm numForm = new NumberForm())
            {
                numForm.Owner = this;
                DialogResult result = numForm.ShowDialog();

                if (result == DialogResult.OK)
                {
                    if (!string.IsNullOrEmpty(mStrDlgReturn))
                    {
                        // mStrDlgReturn 데이터 스플릿
                        // [0] = 숫자를 붙이는 방향 (0 : 앞, 1 : 뒤)
                        // [1] = 자릿수
                        // [2] = 시작수
                        string[] strToken = mStrDlgReturn.Split(',');

                        if (strToken.Length == 3)
                        {
                            string strTmp = string.Empty;
                            int nDirect = int.Parse(strToken[0]);
                            int nDigit = int.Parse(strToken[1]);
                            int nStart = int.Parse(strToken[2]);
                            string strFormat = string.Format("D{0}", nDigit);
                            strFormat = "{0,0:" + strFormat + "}";


                            foreach (FileObject file in mFileList)
                            {
                                if (nDirect == 0)
                                    file.FileName = string.Format(strFormat, nStart++) + file.FileName;
                                else
                                    file.FileName += string.Format(strFormat, nStart++);
                            }
                        }

                        RefreshList();
                    }
                    mStrDlgReturn = string.Empty;
                }
            }
        }

        /// <summary>
        /// 선택항목 위로 버튼
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSelUp_Click(object sender, EventArgs e)
        {
            try
            {
                int nCurSelIndex = listView.SelectedItems[0].Index;

                if (nCurSelIndex != 0)
                {
                    FileObject prevObject = mFileList[nCurSelIndex - 1].Clone();

                    mFileList[nCurSelIndex - 1] = mFileList[nCurSelIndex].Clone();
                    mFileList[nCurSelIndex] = prevObject.Clone();

                    RefreshList();

                    listView.Items[nCurSelIndex - 1].Selected = true;
                    listView.Focus();
                    listView.Items[nCurSelIndex - 1].EnsureVisible();
                }
            }
            catch (Exception) { }
        }

        /// <summary>
        /// 확장자 변경 버튼
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
                        foreach (FileObject file in mFileList)
                            file.FileExtension = mStrDlgReturn;

                        RefreshList();
                    }
                    mStrDlgReturn = string.Empty;
                }
            }
        }

        /// <summary>
        /// 선택항목 아래로 버튼
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSelDown_Click(object sender, EventArgs e)
        {
            try
            {
                int nCurSelIndex = listView.SelectedItems[0].Index;

                if (nCurSelIndex != listView.Items.Count - 1)
                {
                    FileObject prevObject = mFileList[nCurSelIndex + 1].Clone();

                    mFileList[nCurSelIndex + 1] = mFileList[nCurSelIndex].Clone();
                    mFileList[nCurSelIndex] = prevObject.Clone();

                    RefreshList();

                    listView.Items[nCurSelIndex + 1].Selected = true;
                    listView.Focus();
                    listView.Items[nCurSelIndex + 1].EnsureVisible();
                }
            }
            catch (Exception) { }
        }

        /// <summary>
        /// 확장자 삭제 버튼
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnDelExtension_Click(object sender, EventArgs e)
        {
            foreach (FileObject file in mFileList)
                file.FileExtension = string.Empty;

            RefreshList();
        }

        /// <summary>
        /// 변경사항 적용 버튼
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnApply_Click(object sender, EventArgs e)
        {
            StringBuilder stringBuilder = new StringBuilder();

            foreach (FileObject file in mFileList)
            {
                try
                {
                    if (string.IsNullOrEmpty(file.FileName.Trim()) == false)
                    {
                        if (File.Exists(file.BackupFileFullPath))
                        {
                            File.Move(file.BackupFileFullPath, file.FileFullPath);
                            file.BackupFileName = file.FileName;
                            file.BackupFileExtension = file.FileExtension;
                            file.BackupFilePath = file.FilePath;
                        }
                        else
                        {
                            file.BackupFileName = RString.String_Error_FileNotExist;
                            file.BackupFileExtension = "";
                        }
                    }
                    else
                    {
                        stringBuilder.AppendLine($"파일 이름 없음 ({file.BackupFileName})");
                    }
                }
                catch
                {
                    stringBuilder.AppendLine($"{file.FileName} ({file.BackupFileName})");
                }
            }

            if (stringBuilder.Length > 0)
            {
                MessageBox.Show($"{RString.String_Msg_ApplyFailed}\n{stringBuilder}", RString.String_Msg_Title_Warning);
            }

            RefreshList(true);
        }

        /// <summary>
        /// 메뉴 - 보기 - 전체 경로 표시 버튼
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MenuViewFullPath_Click(object sender, EventArgs e)
        {
            if (menuViewFullPath.Checked)
                listView.Columns[(int)Global.ListColumn.FullPath].Width = 0;
            else
                listView.Columns[(int)Global.ListColumn.FullPath].Width = (int)Global.ListSize.FullPath;

            menuViewFullPath.Checked = !menuViewFullPath.Checked;
        }

        /// <summary>
        /// 메뉴 - 보기 - 파일 크기 표시 버튼
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MenuViewFileSize_Click(object sender, EventArgs e)
        {
            if (menuViewFileSize.Checked)
                listView.Columns[(int)Global.ListColumn.FileSize].Width = 0;
            else
                listView.Columns[(int)Global.ListColumn.FileSize].Width = (int)Global.ListSize.FileSize;

            menuViewFileSize.Checked = !menuViewFileSize.Checked;
        }

        /// <summary>
        /// 메뉴 - 보기 - 변경 시간 표시 버튼
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MenuViewChangeTime_Click(object sender, EventArgs e)
        {
            if (menuViewChangeTime.Checked)
                listView.Columns[(int)Global.ListColumn.ModifyTime].Width = 0;
            else
                listView.Columns[(int)Global.ListColumn.ModifyTime].Width = (int)Global.ListSize.ModifyTime;

            menuViewChangeTime.Checked = !menuViewChangeTime.Checked;
        }

        /// <summary>
        /// 메뉴 - 보기 - 생성 시각 표시 버튼
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MenuViewCreateTime_Click(object sender, EventArgs e)
        {
            if (menuViewCreateTime.Checked)
                listView.Columns[(int)Global.ListColumn.CreateTime].Width = 0;
            else
                listView.Columns[(int)Global.ListColumn.CreateTime].Width = (int)Global.ListSize.CreateTime;

            menuViewCreateTime.Checked = !menuViewCreateTime.Checked;
        }

        /// <summary>
        /// 메뉴 - 파일 - 파일 추가 버튼
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MenuFileAdd_Click(object sender, EventArgs e)
        {
            BtnLoad_Click(null, null);
        }

        /// <summary>
        /// 메인 파일 List - 선택 이벤트
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listView_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            try
            {
                int nCurSelIdx = listView.SelectedItems[0].Index;

                btnSelUp.Enabled = true;
                btnSelDown.Enabled = true;
                menuEditSelUp.Enabled = true;
                menuEditSelDown.Enabled = true;
                btnSelDel.Enabled = true;
            }
            catch (Exception)
            {
                btnSelUp.Enabled = false;
                btnSelDown.Enabled = false;
                menuEditSelUp.Enabled = false;
                menuEditSelDown.Enabled = false;
                btnSelDel.Enabled = false;
            }

        }

        /// <summary>
        /// 메뉴 - 편집 - 위로 올림
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuEditSelUp_Click(object sender, EventArgs e)
        {
            BtnSelUp_Click(sender, e);
        }

        /// <summary>
        /// 메뉴 - 편집 - 아래로 내림
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuEditSelDown_Click(object sender, EventArgs e)
        {
            BtnSelDown_Click(sender, e);
        }

        /// <summary>
        /// 메뉴 - 파일 - 바꿀이름 파일로 내보내기
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuFileExportNameList_Click(object sender, EventArgs e)
        {
            saveFileDialog.Filter = Global.NAMELIST_EXTENSION_FILTER;
            DialogResult dialogResult = saveFileDialog.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                string strResult = OutputNameFile();
                try
                {
                    using (TextWriter writer = new StreamWriter(saveFileDialog.FileName))
                    {
                        writer.Write(strResult);
                    }
                    MessageBox.Show(RString.String_Success_FileSave, RString.String_Title_FileSave);
                }
                catch (UnauthorizedAccessException)
                { 
                    MessageBox.Show(RString.String_Error_Unauthor, RString.String_Error); 
                }
                catch (DirectoryNotFoundException)
                {
                    MessageBox.Show(RString.String_Error_DirNotFound, RString.String_Error);
                }
                catch (IOException)
                {
                    MessageBox.Show(RString.String_Error_IOException, RString.String_Error);
                }
            }
        }

        /// <summary>
        /// 메뉴 - 파일 - 바꿀이름 파일에서 불러오기
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuFileImportNameList_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = Global.NAMELIST_EXTENSION_FILTER;
            DialogResult dialogResult = openFileDialog.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                try
                {
                    string strTmp = string.Empty;
                    int nIdx = 0;

                    using (TextReader reader = new StreamReader(openFileDialog.FileName))
                    {
                        while (!string.IsNullOrEmpty(strTmp = reader.ReadLine()))
                        {
                            if (!InputNameFile(strTmp, ref nIdx))
                                break;
                        }
                    }
                    RefreshList();
                    MessageBox.Show(RString.String_Success_FileLoad, RString.String_Title_FileLoad);
                }
                catch (UnauthorizedAccessException)
                {
                    MessageBox.Show(RString.String_Error_Unauthor, RString.String_Error);
                }
                catch (DirectoryNotFoundException)
                {
                    MessageBox.Show(RString.String_Error_DirNotFound, RString.String_Error);
                }
                catch (IOException)
                {
                    MessageBox.Show(RString.String_Error_IOException, RString.String_Error);
                }
            }
        }

        /// <summary>
        /// 바꿀이름 목록을 string형으로 만들어주는 메소드
        /// </summary>
        /// <returns>바꿀이름 목록</returns>
        private string OutputNameFile()
        {
            StringBuilder stringBuilder = new StringBuilder();
            foreach (FileObject file in mFileList)
                stringBuilder.AppendLine(file.FileFullPath);

            string strResult = stringBuilder.ToString();
            return strResult;
        }

        /// <summary>
        /// 바꿀이름 목록을 파일로부터 받아온 한줄데이터를 해당 리스트의 인덱스부분에 넣는 메소드
        /// </summary>
        /// <param name="strLine">바꿀 이름 데이터</param>
        /// <param name="nIdx">데이터를 넣을 리스트의 인덱스</param>
        /// <returns>성공 또는 실패</returns>
        private bool InputNameFile(string strLine, ref int nIdx)
        {
            bool bResult = true;

            if (nIdx < mFileList.Count)
            {
                mFileList[nIdx].FileFullPath = strLine;

                int nLastSeparator = strLine.LastIndexOf(Path.DirectorySeparatorChar);
                mFileList[nIdx].FilePath = strLine.Substring(0, nLastSeparator + 1);

                int nExtensionSeparator = strLine.LastIndexOf(".");
                mFileList[nIdx].FileName = strLine.Substring(nLastSeparator + 1, nExtensionSeparator - nLastSeparator - 1);
                mFileList[nIdx].FileExtension = strLine.Substring(nExtensionSeparator + 1);

                nIdx++;
            }
            else
                bResult = false;

            return bResult;
        }

        /// <summary>
        /// 메뉴 - 정보
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuInfo_Click(object sender, EventArgs e)
        {
            using (AboutBox box = new AboutBox())
            {
                box.ShowDialog();
            }
        }

        /// <summary>
        /// 선택항목 삭제 버튼
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnNameDelete(object sender, EventArgs e)
        {
            try
            {
                if (listView.SelectedItems != null &&
                    listView.SelectedItems.Count > 0)
                {
                    int[] nArrReverseIdx = new int[listView.SelectedItems.Count];
                    
                    for (int i = 0; i < listView.SelectedItems.Count; i++)
                    {
                        nArrReverseIdx[i] = listView.SelectedItems[i].Index;
                    }
                    Array.Sort(nArrReverseIdx, (nNum1, nNum2) => (nNum1 > nNum2) ? -1 : 1);

                    for (int i = 0; i < listView.SelectedItems.Count; i++)
                    {
                        mFileList.RemoveAt(nArrReverseIdx[i]);
                    }

                    RefreshList();

                    btnSelUp.Enabled = false;
                    btnSelDown.Enabled = false;
                    menuEditSelUp.Enabled = false;
                    menuEditSelDown.Enabled = false;
                    btnSelDel.Enabled = false;
                }
            }
            catch (Exception) { }
        }

        /// <summary>
        /// 리스트 - 드래그 드랍
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listView_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] strFileNames = e.Data.GetData(DataFormats.FileDrop) as string[];
                AddList(strFileNames);
            }
        }

        /// <summary>
        /// 리스트 - 드래그 시작 (진입)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listView_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }
    }
}
