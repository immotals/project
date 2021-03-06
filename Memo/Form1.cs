using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Printing;
using System.Collections;
using Microsoft.Win32;

namespace Memo
{
	public partial class MainForm : Form
	{
		// 생성자
		public MainForm() : base()
		{
			InitializeComponent();
		}

		public MainForm(int abc)
		{
			moveLine = abc;
			InitializeComponent();
		}

		// 폼 파일 객체
		Go GoForm;
		new Find FindForm;
		Change ChangeForm;

		// 전역 변수
		public TextBox tb;
		public int txtLine = 1;
		public int moveLine = 0;
		public char[] txt = null;
		public int cLength = 0;
		public string search = null;
		private Font printFont;
		private string streamToPrint = null;
		private bool SaveCheck = false;
		private bool EditText = false;

		// 메인 폼
		private void MainForm_Load(object sender, EventArgs e) { }

		private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (EditText == false)
			{
				e.Cancel = true;
				return;
			}
			else if (EditText == true)
			{

			}

			if (EditText == false)
			{
				if (MessageBox.Show("저장", "나가기", MessageBoxButtons.YesNoCancel) == DialogResult.Yes)
				{
					if (saveFileDialog1.ShowDialog() == DialogResult.OK)
					{
						SaveYorN();
					}
					else if (saveFileDialog1.ShowDialog() == DialogResult.No)
					{
						this.Close();
					}
				}
			}
		}

		// TextBox 메인 텍스트 박스 RichTextBox
		public void TextBox_TextChanged_1(object sender, EventArgs e)
		{
			EditText = true;

		}

		#region 메뉴
		// 상단 메뉴
		private void menu_File_Click(object sender, EventArgs e) { }
		private void menu_Edit_Click(object sender, EventArgs e) { }
		private void menu_Ori_Click(object sender, EventArgs e) { }
		private void menu_View_Click(object sender, EventArgs e) { }
		private void menu_Help_Click(object sender, EventArgs e) { }
		#endregion

		#region 메뉴 - 파일

		// 파일 - 새로만들기
		private void menu_NewFile_Click(object sender, EventArgs e)
		{
			try
			{
				if (TextBox.Text != "")
				{
					if (MessageBox.Show(this, "작업중인 문서 저장?", "저장", MessageBoxButtons.YesNoCancel) == DialogResult.Yes)
					{
						if (saveFileDialog1.ShowDialog() == DialogResult.OK)
						{
							SaveDocument(saveFileDialog1.FileName);
						}
					}
				}
			}

			catch (Exception Newe)
			{
				MessageBox.Show("에러 : " + Newe.Message, "Error");
			}

			finally
			{
				TextBox.Clear();
			}

			SaveCheck = false;
			EditText = false;
		}

		// 파일 - 열기
		private void menu_OpenFile_Click(object sender, EventArgs e)
		{
			try
			{
				if (openFileDialog1.ShowDialog() == DialogResult.OK)
					OpenDocument(openFileDialog1.FileName);
			}
			catch (Exception Opene)
			{
				MessageBox.Show("에러 : " + Opene.Message, "Error");
			}
		}

		// 파일 - 저장
		private void menu_SaveFile_Click(object sender, EventArgs e)
		{
			SaveYorN();
		}

		// 파일 - 다른 이름으로 저장
		private void menu_AFile_Click(object sender, EventArgs e)
		{
			SaveYorN();
		}

		// 파일 - 페이지 설정
		private void menu_PageFile_Click(object sender, EventArgs e)
		{
			PrintDocument pd = new PrintDocument();
			pd.DocumentName = TextBox.Text;
			pageSetupDialog1.Document = pd;
			pageSetupDialog1.ShowDialog();
		}

		// 파일 - 인쇄
		private void menu_PrintFile_Click(object sender, EventArgs epp)
		{
			printFont = new Font("Arial", 10);
			PrintDocument pd = new PrintDocument();
			pd.PrintPage += new PrintPageEventHandler(this.pd_PrintPage_1);
			pd.Print();
		}

		// 파일 - 끝내기
		private void menu_EndFile_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
		#endregion

		#region 메뉴 - 편집

		// 편집 - 실행취소, 되돌리기, 잘라내기, 복사, 붙여넣기, 삭제
		private void menu_UndoEdit_Click(object sender, EventArgs e) { TextBox.Undo(); }
		private void menu_RedoEdit_Click(object sender, EventArgs e) { TextBox.Redo(); }
		private void menu_TEdit_Click(object sender, EventArgs e) { TextBox.Cut(); }
		private void menu_CopyEdit_Click(object sender, EventArgs e) { TextBox.Copy(); }
		private void menu_PasteEdit_Click(object sender, EventArgs e) { TextBox.Paste(); }
		private void menu_DeleteEdit_Click(object sender, EventArgs e) { TextBox.Cut(); }

		// 편집 - 찾기
		private void menu_FindEdit_Click(object sender, EventArgs e)
		{
			FindForm = new Find(TextBox);
			FindForm.Show(this);
		}

		// 편집 - 다음 찾기
		private void menu_NextEdit_Click(object sender, EventArgs e)
		{

		}

		// 편집 - 바꾸기
		private void menu_ReEdit_Click(object sender, EventArgs e)
		{
			ChangeForm = new Change(TextBox);
			ChangeForm.Show();
		}

		// 편집 - 이동
		private void menu_GoEdit_Click(object sender, EventArgs e)
		{
			GoForm = new Go(this);
			DialogResult result = GoForm.ShowDialog();

			moveLine = moveLine - 1;
			int caretLine = 0;

			int caretPos = TextBox.TextLength;//텍스트박스의 전체 문자열 길이를 반환
			char[] charText = TextBox.Text.ToCharArray();//전체 문자를 유니코드 배열에 복사
			for (int i = 0; i < caretPos; i++)//처음부터 문자열 끝까지 검사
			{
				if (charText[i].ToString().Equals("\n"))
				{
					caretLine++;
					if (caretLine == (moveLine))//이동할 라인과 같은 라인이 나오면...
					{
						TextBox.SelectionStart = i + 1;//케럿의 위치를 반복한 위치(i)로 이동시킨 후 반복을 탈출
						break;
					}
				}
			}
		}

		// 편집 - 모두선택
		private void menu_AllEdit_Click(object sender, EventArgs e)
		{
			TextBox.SelectAll();
		}

		// 편집 - 시간 / 날짜
		private void menu_DateEdit_Click(object sender, EventArgs e)
		{
			TextBox.Text = TextBox.Text.Insert(TextBox.SelectionStart, DateTime.Now.ToString());
		}
		#endregion

		#region 메뉴 - 서식
		// 서식 - 자동 줄 바꿈
		private void menu_WOri_Click(object sender, EventArgs e)
		{
			TextBox.WordWrap = TextBox.WordWrap ? false : true;
		}

		// 서식 - 글꼴
		private void menu_FOri_Click(object sender, EventArgs e)
		{
			fontDialog1.ShowDialog();
			TextBox.Font = fontDialog1.Font;
		}

		// 서식 - 색상
		private void menu_ColorOri_Click(object sender, EventArgs e)
		{
			colorDialog1.ShowDialog();
			TextBox.SelectionColor = colorDialog1.Color;
		}
		#endregion

		#region 메뉴 - 보기
		// 보기 - 상태 표시줄
		private void menu_StatusView_Click(object sender, EventArgs e)
		{
			statusStrip1.Visible = statusStrip1.Visible ? false : true;
		}

		// 보기 - 실행 아이콘
		private void menu_PlayView_Click(object sender, EventArgs e)
		{
			toolStrip1.Visible = toolStrip1.Visible ? false : true;
		}
		#endregion

		#region 메뉴 - 도움말

		// 도움말 - 도움말 항목
		private void menu_HangHelp_Click(object sender, EventArgs e)
		{
			HangHelp hh = new HangHelp();
			hh.Show();
		}

		// 도움말 - 메모장 정보
		private void menu_JungHelp_Click(object sender, EventArgs e)
		{

		}
		#endregion

		#region 실행 아이콘

		// 아이콘 - 새로만들기
		private void 새로만들기NToolStripButton_Click(object sender, EventArgs e)
		{
			try
			{
				if (TextBox.Text != "")
				{
					if (MessageBox.Show(this, "작업중인 문서 저장?", "저장", MessageBoxButtons.YesNoCancel) == DialogResult.Yes)
					{
						if (saveFileDialog1.ShowDialog() == DialogResult.OK)
						{
							SaveDocument(saveFileDialog1.FileName);
						}
					}
				}
			}

			catch (Exception Newe)
			{
				MessageBox.Show("에러 : " + Newe.Message, "Error");
			}

			finally
			{
				TextBox.Clear();
			}
		}

		// 아이콘 - 열기
		private void 열기OToolStripButton_Click(object sender, EventArgs e)
		{
			try
			{
				if (openFileDialog1.ShowDialog() == DialogResult.OK)
					OpenDocument(openFileDialog1.FileName);
			}
			catch (Exception Opene)
			{
				MessageBox.Show("에러 : " + Opene.Message, "Error");
			}
		}

		// 아이콘 - 저장
		private void 저장SToolStripButton_Click(object sender, EventArgs e)
		{
			SaveYorN();
		}

		// 아이콘 - 인쇄
		private void 인쇄PToolStripButton_Click(object sender, EventArgs e)
		{
			printFont = new Font("Arial", 10);
			PrintDocument pd = new PrintDocument();
			pd.PrintPage += new PrintPageEventHandler(this.pd_PrintPage_1);
			pd.Print();
		}

		// 아이콘 - 왼쪽 정렬
		private void AlignLeft_Click(object sender, EventArgs e)
		{
			TextBox.SelectionAlignment = HorizontalAlignment.Left;
		}

		// 아이콘 - 가운데 정렬
		private void AlignCenter_Click(object sender, EventArgs e)
		{
			TextBox.SelectionAlignment = HorizontalAlignment.Center;
		}

		// 아이콘 - 오른쪽 정렬
		private void AlignRight_Click(object sender, EventArgs e)
		{
			TextBox.SelectionAlignment = HorizontalAlignment.Right;
		}

		// 아이콘 - 잘라내기
		private void 잘라내기UToolStripButton_Click(object sender, EventArgs e)
		{
			TextBox.Cut();
		}

		// 아이콘 - 복사
		private void 복사CToolStripButton_Click(object sender, EventArgs e)
		{
			TextBox.Copy();
		}

		// 아이콘 붙여넣기
		private void 붙여넣기PToolStripButton_Click(object sender, EventArgs e)
		{
			TextBox.Paste();
		}

		// 아이콘 - 도움말
		private void 도움말LToolStripButton_Click(object sender, EventArgs e)
		{

		}
		#endregion

		#region 파일 저장 관련
		// 파일 저장
		private bool SaveYorN()
		{
			try
			{
				if (SaveCheck == false)
				{
					if (MessageBox.Show("저장", "메모장", MessageBoxButtons.YesNo) == DialogResult.Yes)
					{
						if (saveFileDialog1.ShowDialog() == DialogResult.OK)
						{
							SaveDocument(saveFileDialog1.FileName);
							SaveCheck = true;
							EditText = false;
						}
					}
				}

			}
			catch (Exception e)
			{
				MessageBox.Show("bool SaveYorn Error" + e.Source);
			}
			finally
			{
				TextBox.SelectionStart = 0;
			}

			return false;
		}

		// 파일 저장 문서
		public void SaveDocument(string FileName)
		{
			StreamWriter SaveText = new StreamWriter(FileName, false, System.Text.Encoding.Default);
			SaveText.Write(TextBox.Text);
			SaveText.Close();
		}
		#endregion

		// 문서 열기
		public void OpenDocument(string FileName)
		{
			try
			{
				StreamReader sr = new StreamReader(FileName, System.Text.Encoding.Default);
				TextBox.Text = sr.ReadToEnd();
				TextBox.SelectionStart = 0;
				sr.Close();
				SaveCheck = false;
			}
			catch (Exception e)
			{
				MessageBox.Show("OpenDocument에서 에러 발생\n" + e.Message + "\n" + e.Source);
			}
		}

		// 인쇄
		private void pd_PrintPage_1(object sender, PrintPageEventArgs ev)
		{
			streamToPrint = TextBox.Text;
			float linesPerPage = 0;
			float yPos = 0;
			int count = 0;
			float leftMargin = ev.MarginBounds.Left;
			float topMargin = ev.MarginBounds.Top;
			string line = null;

			if (streamToPrint == null) { MessageBox.Show("아하하하하하하"); }
			MessageBox.Show(streamToPrint);

			linesPerPage = ev.MarginBounds.Height / printFont.GetHeight(ev.Graphics);
			try
			{
				yPos = topMargin + (count * printFont.GetHeight(ev.Graphics));
				ev.Graphics.DrawString(streamToPrint, printFont, Brushes.Black,
					leftMargin, yPos, new StringFormat());
			}
			catch (Exception epe)
			{
				MessageBox.Show(epe.Message + "\n" + epe.InnerException);
			}
			if (line != null)
				ev.HasMorePages = true;
			else
				ev.HasMorePages = false;
		}

		// 상단 메뉴 , 실행 아이콘 툴, 최하단 상태바, 최하단 상태바 텍스트
		private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e) { }
		private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e) { }
		private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e) { }
		private void toolStripStatusLabel1_Click(object sender, EventArgs e) { }


		#region 이벤트

		#endregion

		private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
		{

		}

		private void toolStripProgressBar1_Click(object sender, EventArgs e)
		{
            

		}
		private void toolStripProgressBar1_SelectionChanged(object sender, EventArgs e)
        {
            
		}

        private void toolStripProgressBar1_EnabledChanged(object sender, EventArgs e)
        {

        }

        private void TextBox_SelectionChanged(object sender, EventArgs e)
        {
			int index = TextBox.SelectionStart;
			int line = TextBox.GetLineFromCharIndex(index);
			int firstchar = TextBox.GetFirstCharIndexFromLine(line);
			int column = index - firstchar;
			toolStripStatusLabel1.Text = "Ln : " + line + " " + " Col : " + column;
		}
    }
}