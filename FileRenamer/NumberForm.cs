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
    public partial class NumberForm : Form
    {
        public NumberForm()
        {
            InitializeComponent();

            InitControls();
        }

        private void InitControls()
        {
            string[] STR_DIRECT = new string[2] { "앞", "뒤" };
            numFrmCBoxDirect.Items.AddRange(STR_DIRECT);

            for (int i = 1; i <= 10; i++)
                numFrmCBoxDigit.Items.Add(string.Format("{0}", i));
        }

        private void NumFrmBtnOK_Click(object sender, EventArgs e)
        {
            string strReturn = string.Format("{0},{1},{2}", numFrmCBoxDirect.SelectedIndex, numFrmCBoxDigit.SelectedIndex + 1, numFrmEditStart.Text);

            ((mainForm)(Owner)).mStrDlgReturn = strReturn;
            this.DialogResult = DialogResult.OK;
        }

        private void NumFrmBtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
