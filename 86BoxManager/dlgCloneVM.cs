using System;
using System.IO;
using System.Windows.Forms;

namespace _86boxManager
{
    public partial class dlgCloneVM : Form
    {
        private string oldPath; //Path of the VM to be cloned
        private frmMain main = (frmMain)Application.OpenForms["frmMain"]; //Instance of frmMain

        public dlgCloneVM()
        {
            InitializeComponent();
        }

        public dlgCloneVM(string oldPath)
        {
            InitializeComponent();
            this.oldPath = oldPath;
        }

        private void dlgCloneVM_Load(object sender, EventArgs e)
        {
            lblPath1.Text = main.cfgpath;
            lblOldVM.Text = "虚拟实例 \"" + Path.GetFileName(oldPath) + "\" 将按以下设置被克隆，请确认设置。";
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                btnClone.Enabled = false;
                tipTxtName.Active = false;
            }
            else
            {
                if (txtName.Text.IndexOfAny(Path.GetInvalidFileNameChars()) >= 0)
                {
                    btnClone.Enabled = false;
                    lblPath1.Text = "非法路径";
                    tipTxtName.Active = true;
                    tipTxtName.Show("您不可在路径中使用以下符号: \\ / : * ? \" < > |", txtName, 20000);
                }
                else
                {
                    btnClone.Enabled = true;
                    lblPath1.Text = main.cfgpath + txtName.Text;
                    tipLblPath1.SetToolTip(lblPath1, main.cfgpath + txtName.Text);
                }
            }
        }

        private void btnClone_Click(object sender, EventArgs e)
        {
            if (main.VMCheckIfExists(txtName.Text))
            {
                MessageBox.Show("具有此名称的实例已存在。请选择其他名称。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtName.Text.IndexOfAny(Path.GetInvalidFileNameChars()) >= 0)
            {
                MessageBox.Show("名称中包含非法字符。您不可使用以下符号: \\ / : * ? \" < > |", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Just import stuff from the existing VM
            main.VMImport(txtName.Text, txtDescription.Text, oldPath, cbxOpenCFG.Checked, cbxStartVM.Checked);
            Close();
        }
    }
}
