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
    public partial class FrmChkRadio : Form
    {
        public FrmChkRadio()
        {
            InitializeComponent();
        }

        private void btnok_Click(object sender, EventArgs e)
        {
            string msg = "";

            //msg에 값을 넣는 첫번째 방법
            if (this.chkCsharp.Checked) { msg += this.chkCsharp.Text + "\r\n"; }

            //msg에 값을 넣는 두번째 방법
            if (this.chkAsp.Checked == true) { msg += this.chkAsp.Text + "\r\n"; }

            else { msg += this.chkSil.Text + "\r\n"; }

            //성별
            if (this.optMan.Checked)
            {
                msg += string.Format("{0} {1} {0}", "\r\n", optMan.Text);
            }
            if (this.optWomen.Checked)
            {
                msg += string.Format("{0} {1} {0}", "\r\n", optWomen.Text);
            }
            this.txtResult.Text = msg;
        }

        private void FrmChkRadio_Load(object sender, EventArgs e)
        {
            optWomen.Checked = true;
        }
    }
}
