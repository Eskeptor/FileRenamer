using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileRenamer
{
    public partial class NameForm : Form
    {
        public NameForm()
        {
            InitializeComponent();

            InitControl();
        }

        private void InitControl()
        {
            string[] STR_DIRECT = new string[2] { "앞", "뒤" };
            nameFrmCBoxDirect.Items.AddRange(STR_DIRECT);
            nameFrmCBoxDirect.SelectedIndex = 0;
        }

        /// <summary>
        /// 폼 생성 타입을 설정
        /// </summary>
        /// <param name="formType">폼 타입</param>
        public void SetFormType(Global.FormType formType)
        {
            switch (formType)
            {
                case Global.FormType.AddName:
                    Text = Properties.Resources.String_Title_FormType_AddName;
                    nameFrmLblContext.Text = Properties.Resources.String_Label_FormType_AddName;
                    break;
                case Global.FormType.ChangeExtension:
                    Text = Properties.Resources.String_Title_FormType_ChangeExtension;
                    nameFrmLblContext.Text = Properties.Resources.String_Label_FormType_ChangeExtension;
                    break;
            }
        }

        /// <summary>
        /// 확인 버튼
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NameFrmBtnOK_Click(object sender, EventArgs e)
        {
            ((mainForm)(Owner)).mStrDlgReturn = string.Format("{0},{1}", nameFrmCBoxDirect.SelectedIndex, nameFrmEdit.Text);
            this.DialogResult = DialogResult.OK;
            Close();
        }

        /// <summary>
        /// 취소 버튼
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NameFrmBtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
