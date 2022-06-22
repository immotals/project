using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WinFrmMain.Class
{
    public partial class FrmDialogResult : Form
    {
        public FrmDialogResult()
        {
            InitializeComponent();
        }

        //속성
        public string Value { get; set; }

        private void btnOK_Click(object sender, EventArgs e)
        {
            //자식 폼으로 데이터 전송
            WinFrmMain.Class.FrmDialogResultChild frmc = new FrmDialogResultChild();

            frmc.Owner = this; //자식 폼의 주인 FrmDialogResult  //Owner이용해서 값을 전달 할 수 있다.

            frmc.SendValue = txtParent.Text; //속성으로 값을 전달

            if (frmc.ShowDialog() == DialogResult.OK)
            {
                this.txtResult.Text = Value;
            }
        }
    }
}
