using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WinFrmMain
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void miAbout_Click(object sender, EventArgs e)
        {
            //모달 폼 : 현재창을 닫아야지만, 메인으로 이동 가능
            FrmAbout fa = new FrmAbout();
            fa.ShowDialog();
        }

        private void miExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void 체크박스와라디오박스ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WinFrmMain.Control.FrmChkRadio fcrbutton = new WinFrmMain.Control.FrmChkRadio();
            fcrbutton.MdiParent = this;
            fcrbutton.Show();
        }

        private void miMDIForm_Click(object sender, EventArgs e)
        {
            //모달리스 폼 : 독립적인 하나의 폼
            WinFrmMain.Control.FrmButton fb =
                new WinFrmMain.Control.FrmButton();

            //MDI 컨테이너를 현재 폼(메인)으로 설정
            fb.MdiParent = this;  // 속성 지정 안해주면 MDI폼 안이 아닌 밖에 나타난다.
            //fb를 mdi부모에게 주겠다  = 메인인 내가

            fb.Show();
        }

        private void miFrmTextBoxButton_Click(object sender, EventArgs e)
        {
            WinFrmMain.Control.FrmTextBoxButton frmtxtbox = new WinFrmMain.Control.FrmTextBoxButton();
            frmtxtbox.MdiParent = this;
            frmtxtbox.Show();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {

        }

        private void miTextBox_Click(object sender, EventArgs e)
        {
            WinFrmMain.Control.FrmTextBox FrmTxtBox =
                new WinFrmMain.Control.FrmTextBox();
            FrmTxtBox.MdiParent = this;
            FrmTxtBox.Show();
        }

        private void miMessAgeBox_Click(object sender, EventArgs e)
        {
            //메시지 박스의 주요 모양
            //MSDN 온라인 적극활용            
            MessageBox.Show("기본");

            MessageBox.Show("먹어도 먹어도 배고파요...", "제목");

            MessageBox.Show("버튼의 종류", "버튼", MessageBoxButtons.OKCancel);

            MessageBox.Show("아이콘의 종류입니다.", "아이콘", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void miGroupBox_Click(object sender, EventArgs e)
        {
            WinFrmMain.Control.FrmGroupBox frmgroupbox = new WinFrmMain.Control.FrmGroupBox();
            frmgroupbox.MdiParent = this;
            frmgroupbox.Show();
        }

        private void miComboListBox_Click(object sender, EventArgs e)
        {
            WinFrmMain.Control.FrmComboListBox frmCboLstBox = new WinFrmMain.Control.FrmComboListBox();
            frmCboLstBox.MdiParent = this;
            frmCboLstBox.Show();
        }

        private void miDialogResult_Click(object sender, EventArgs e)
        {
            WinFrmMain.Class.FrmDialogResult frmResult = new WinFrmMain.Class.FrmDialogResult();
            frmResult.Show();
        }

        private void miFont_Click(object sender, EventArgs e)
        {
            WinFrmMain.Control.FrmFontDialog ffd = new WinFrmMain.Control.FrmFontDialog();
            ffd.MdiParent = this;
            ffd.Show();
        }

        private void miFolderBrowser_Click(object sender, EventArgs e)
        {
            WinFrmMain.Control.FrmFolderBrowser fb = new WinFrmMain.Control.FrmFolderBrowser();
            fb.MdiParent = this;
            fb.Show();
        }

        private void miFrmNotepad_Click(object sender, EventArgs e)
        {
            WinFrmMain.Sample.FrmSampleNotepad fsn = new WinFrmMain.Sample.FrmSampleNotepad();
            fsn.MdiParent = this;
            fsn.Show();
        }
    }
}
