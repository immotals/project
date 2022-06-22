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
    public partial class FrmDialogResultChild : Form
    {
        public FrmDialogResultChild()
        {
            InitializeComponent();            
        }

        //속성
        public string SendValue { get; set; } //부모에서 전송된 문자열을 받기위해서

       
        private void FrmDialogResultChild_Load(object sender, EventArgs e)
        {
            //폼 로드시 SendValue 속성에 담긴 값 저장
            this.txtChild.Text = SendValue;
        }

        private void btnsund_Click(object sender, EventArgs e)
        {
            FrmDialogResult fdr = (FrmDialogResult)Owner;
            fdr.Value = txtReturn.Text; //텍스트 전송
            this.Close(); //현재 폼 닫기
        }
    }
}
