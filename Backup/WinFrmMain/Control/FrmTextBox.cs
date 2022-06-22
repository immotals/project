using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WinFrmMain.Control
{
    public partial class FrmTextBox : Form
    {
        public FrmTextBox()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("싱글라인 : " + txtSingle.Text + "\r\n");
            sb.AppendFormat("멀티라인 : " + txtMulth.Text + "\r\n");          //같은형태1
            sb.AppendLine(string.Format("패스워드 : {0}", txtPwd.Text)); //같은형태1
            sb.AppendLine("마스크 : " + txtMask.Text);
            sb.AppendFormat("리치 : {0}", txtRich.Text);

            MessageBox.Show(sb.ToString());

            txtSingle.Text = "";
            txtMulth.Text = "";
            txtPwd.Text = "";
            txtMask.Text = "";
            txtRich.Text = "";
        }
    }
}
