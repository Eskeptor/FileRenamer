using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RString = FileRenamer.Properties.Resources;

namespace FileRenamer
{
    public partial class NumberForm : Form
    {
        public NumberForm()
        {
            InitializeComponent();

            InitControls();
        }

        private void InitControls()
        {
            string[] STR_DIRECT = new string[2] { RString.String_Menu_Front, RString.String_Menu_Back };
            numFrmCBoxDirect.Items.AddRange(STR_DIRECT);
            numFrmCBoxDirect.SelectedIndex = 0;

            for (int i = 1; i <= 10; i++)
                numFrmCBoxDigit.Items.Add(string.Format("{0}", i));
            numFrmCBoxDigit.SelectedIndex = 0;

            Text = RString.String_Title_AddNumber;
            numFrmLblContext.Text = string.Format(RString.String_Label_AddNumber, STR_DIRECT[0]);
        }

        /// <summary>
        /// 확인 버튼
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NumFrmBtnOK_Click(object sender, EventArgs e)
        {
            string strReturn = string.Format("{0},{1},{2}", numFrmCBoxDirect.SelectedIndex, numFrmCBoxDigit.SelectedIndex + 1, numFrmEditStart.Text);

            ((mainForm)(Owner)).mStrDlgReturn = strReturn;
            this.DialogResult = DialogResult.OK;
        }

        /// <summary>
        /// 취소 버튼
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NumFrmBtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// 위치 콤보박스 - 선택 이벤트
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void numFrmCBoxDirect_SelectedIndexChanged(object sender, EventArgs e)
        {
            numFrmLblContext.Text = string.Format(RString.String_Label_AddNumber, numFrmCBoxDirect.Text);
        }
    }
}
