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
    public partial class FrmComboListBox : Form
    {
        public FrmComboListBox()
        {
            InitializeComponent();
        }

        private void FrmComboListBox_Load(object sender, EventArgs e)
        {
            //동적으로 아이콘의 종류를 리스트박스에 초기화
            lstIconBox.Items.Add(MessageBoxIcon.Error.ToString());
            lstIconBox.Items.Add(MessageBoxIcon.Information.ToString());
            lstIconBox.Items.Add(MessageBoxIcon.Stop.ToString());
            lstIconBox.Items.Add(MessageBoxIcon.Question.ToString());
            lstIconBox.Items.Add(MessageBoxIcon.Warning.ToString());         
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (cboBox.SelectedIndex != -1 && lstIconBox.SelectedIndex != -1)
            {
                string btn = cboBox.Items[cboBox.SelectedIndex].ToString(); //선택되지 않으면 -1값을 반환한다. 예외처리 해줌
                string icon = lstIconBox.Items[lstIconBox.SelectedIndex].ToString();

                //Process
                MessageBox.Show(string.Format("버튼 : {0}, 아이콘 : {1}", btn, icon));
            }
            else
            {
                DialogResult result = MessageBox.Show(
                    "콤보박스와 리스트 박스를 선택해주세요.",
                    "제목",
                    MessageBoxButtons.OKCancel);

                //DialogResult 쓰게 되면 확인과 취소에 따른 결과값을 간단하게 출력 할 수 있다.
                if (result == DialogResult.OK)
                {
                    lstOutput.Text = "확인 클릭";
                }
                else if (result == DialogResult.Cancel)
                {
                    lstOutput.Text = "취소 클릭";
                }
            }
        }    
    }
}
