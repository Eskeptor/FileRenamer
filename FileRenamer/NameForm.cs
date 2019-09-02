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
        }

        public void SetFormType(Global.FormType formType)
        {
            switch (formType)
            {
                case Global.FormType.AddNameFront:
                    Text = Properties.Resources.String_Title_FormType_AddNameFront;
                    nameFrmLblContext.Text = Properties.Resources.String_Label_FormType_AddNameFront;
                    break;
                case Global.FormType.AddNameBack:
                    Text = Properties.Resources.String_Title_FormType_AddNameBack;
                    nameFrmLblContext.Text = Properties.Resources.String_Label_FormType_AddNameBack;
                    break;
                case Global.FormType.ChangeExtension:
                    Text = Properties.Resources.String_Title_FormType_ChangeExtension;
                    nameFrmLblContext.Text = Properties.Resources.String_Label_FormType_ChangeExtension;
                    break;
            }
        }

        private void NameFrmBtnOK_Click(object sender, EventArgs e)
        {
            ((mainForm)(Owner)).mStrDlgReturn = nameFrmEdit.Text;
            this.DialogResult = DialogResult.OK;
            Close();
        }

        private void NameFrmBtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
