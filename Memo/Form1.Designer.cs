namespace Memo
{
	partial class MainForm
	{
		/// <summary>
		/// 필수 디자이너 변수입니다.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 사용 중인 모든 리소스를 정리합니다.
		/// </summary>
		/// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form 디자이너에서 생성한 코드

		/// <summary>
		/// 디자이너 지원에 필요한 메서드입니다.
		/// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menu_File = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_NewFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_OpenFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_SaveFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_AFile = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menu_PageFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_PrintFile = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.menu_EndFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_Edit = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_UndoEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_RedoEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.menu_TEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_CopyEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_PasteEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_DeleteEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.menu_FindEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_NextEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_ReEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_GoEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.menu_AllEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_DateEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_Ori = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_WOri = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_FOri = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_ColorOri = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_View = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_StatusView = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_PlayView = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_Help = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_HangHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.menu_JungHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.새로만들기NToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.열기OToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.저장SToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.인쇄PToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.AlignLeft = new System.Windows.Forms.ToolStripButton();
            this.AlignCenter = new System.Windows.Forms.ToolStripButton();
            this.AlignRight = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.잘라내기UToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.복사CToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.붙여넣기PToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator10 = new System.Windows.Forms.ToolStripSeparator();
            this.도움말LToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.TextBox = new System.Windows.Forms.RichTextBox();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.pd = new System.Drawing.Printing.PrintDocument();
            this.Status = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_File,
            this.menu_Edit,
            this.menu_Ori,
            this.menu_View,
            this.menu_Help});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(504, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // menu_File
            // 
            this.menu_File.BackColor = System.Drawing.SystemColors.Control;
            this.menu_File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_NewFile,
            this.menu_OpenFile,
            this.menu_SaveFile,
            this.menu_AFile,
            this.toolStripSeparator1,
            this.menu_PageFile,
            this.menu_PrintFile,
            this.toolStripSeparator2,
            this.menu_EndFile});
            this.menu_File.Name = "menu_File";
            this.menu_File.Size = new System.Drawing.Size(57, 20);
            this.menu_File.Text = "파일(F)";
            this.menu_File.Click += new System.EventHandler(this.menu_File_Click);
            // 
            // menu_NewFile
            // 
            this.menu_NewFile.BackColor = System.Drawing.SystemColors.Control;
            this.menu_NewFile.Image = global::Memo.Properties.Resources.NewDocument;
            this.menu_NewFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menu_NewFile.Name = "menu_NewFile";
            this.menu_NewFile.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.menu_NewFile.Size = new System.Drawing.Size(236, 22);
            this.menu_NewFile.Text = "새로 만들기(&N)";
            this.menu_NewFile.Click += new System.EventHandler(this.menu_NewFile_Click);
            // 
            // menu_OpenFile
            // 
            this.menu_OpenFile.Image = global::Memo.Properties.Resources.Open;
            this.menu_OpenFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menu_OpenFile.Name = "menu_OpenFile";
            this.menu_OpenFile.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.menu_OpenFile.Size = new System.Drawing.Size(236, 22);
            this.menu_OpenFile.Text = "열기(&O)";
            this.menu_OpenFile.Click += new System.EventHandler(this.menu_OpenFile_Click);
            // 
            // menu_SaveFile
            // 
            this.menu_SaveFile.Image = global::Memo.Properties.Resources.Save;
            this.menu_SaveFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menu_SaveFile.Name = "menu_SaveFile";
            this.menu_SaveFile.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.menu_SaveFile.Size = new System.Drawing.Size(236, 22);
            this.menu_SaveFile.Text = "저장(&S)";
            this.menu_SaveFile.Click += new System.EventHandler(this.menu_SaveFile_Click);
            // 
            // menu_AFile
            // 
            this.menu_AFile.Name = "menu_AFile";
            this.menu_AFile.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.menu_AFile.Size = new System.Drawing.Size(236, 22);
            this.menu_AFile.Text = "다른 이름으로 저장(&A)";
            this.menu_AFile.Click += new System.EventHandler(this.menu_AFile_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(233, 6);
            // 
            // menu_PageFile
            // 
            this.menu_PageFile.Name = "menu_PageFile";
            this.menu_PageFile.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.U)));
            this.menu_PageFile.Size = new System.Drawing.Size(236, 22);
            this.menu_PageFile.Text = "페이지 설정(&U)";
            this.menu_PageFile.Click += new System.EventHandler(this.menu_PageFile_Click);
            // 
            // menu_PrintFile
            // 
            this.menu_PrintFile.Name = "menu_PrintFile";
            this.menu_PrintFile.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.menu_PrintFile.Size = new System.Drawing.Size(236, 22);
            this.menu_PrintFile.Text = "인쇄(&P)";
            this.menu_PrintFile.Click += new System.EventHandler(this.menu_PrintFile_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(233, 6);
            // 
            // menu_EndFile
            // 
            this.menu_EndFile.Name = "menu_EndFile";
            this.menu_EndFile.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.menu_EndFile.Size = new System.Drawing.Size(236, 22);
            this.menu_EndFile.Text = "끝내기(&X)";
            this.menu_EndFile.Click += new System.EventHandler(this.menu_EndFile_Click);
            // 
            // menu_Edit
            // 
            this.menu_Edit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_UndoEdit,
            this.menu_RedoEdit,
            this.toolStripSeparator3,
            this.menu_TEdit,
            this.menu_CopyEdit,
            this.menu_PasteEdit,
            this.menu_DeleteEdit,
            this.toolStripSeparator4,
            this.menu_FindEdit,
            this.menu_NextEdit,
            this.menu_ReEdit,
            this.menu_GoEdit,
            this.toolStripSeparator5,
            this.menu_AllEdit,
            this.menu_DateEdit});
            this.menu_Edit.Name = "menu_Edit";
            this.menu_Edit.Size = new System.Drawing.Size(57, 20);
            this.menu_Edit.Text = "편집(&E)";
            this.menu_Edit.Click += new System.EventHandler(this.menu_Edit_Click);
            // 
            // menu_UndoEdit
            // 
            this.menu_UndoEdit.Image = global::Memo.Properties.Resources.Edit_Undo;
            this.menu_UndoEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menu_UndoEdit.Name = "menu_UndoEdit";
            this.menu_UndoEdit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.U)));
            this.menu_UndoEdit.Size = new System.Drawing.Size(195, 22);
            this.menu_UndoEdit.Text = "실행취소(&U)";
            this.menu_UndoEdit.Click += new System.EventHandler(this.menu_UndoEdit_Click);
            // 
            // menu_RedoEdit
            // 
            this.menu_RedoEdit.Image = global::Memo.Properties.Resources.Edit_Redo;
            this.menu_RedoEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menu_RedoEdit.Name = "menu_RedoEdit";
            this.menu_RedoEdit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.menu_RedoEdit.Size = new System.Drawing.Size(195, 22);
            this.menu_RedoEdit.Text = "되돌리기(&R)";
            this.menu_RedoEdit.Click += new System.EventHandler(this.menu_RedoEdit_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(192, 6);
            // 
            // menu_TEdit
            // 
            this.menu_TEdit.Image = global::Memo.Properties.Resources.Cut;
            this.menu_TEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menu_TEdit.Name = "menu_TEdit";
            this.menu_TEdit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.T)));
            this.menu_TEdit.Size = new System.Drawing.Size(195, 22);
            this.menu_TEdit.Text = "잘라내기(&T)";
            this.menu_TEdit.Click += new System.EventHandler(this.menu_TEdit_Click);
            // 
            // menu_CopyEdit
            // 
            this.menu_CopyEdit.Image = global::Memo.Properties.Resources.Copy;
            this.menu_CopyEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menu_CopyEdit.Name = "menu_CopyEdit";
            this.menu_CopyEdit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.menu_CopyEdit.Size = new System.Drawing.Size(195, 22);
            this.menu_CopyEdit.Text = "복사(&C)";
            this.menu_CopyEdit.Click += new System.EventHandler(this.menu_CopyEdit_Click);
            // 
            // menu_PasteEdit
            // 
            this.menu_PasteEdit.Image = global::Memo.Properties.Resources.Paste;
            this.menu_PasteEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menu_PasteEdit.Name = "menu_PasteEdit";
            this.menu_PasteEdit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.menu_PasteEdit.Size = new System.Drawing.Size(195, 22);
            this.menu_PasteEdit.Text = "붙여넣기(&P)";
            this.menu_PasteEdit.Click += new System.EventHandler(this.menu_PasteEdit_Click);
            // 
            // menu_DeleteEdit
            // 
            this.menu_DeleteEdit.Image = global::Memo.Properties.Resources.Cut;
            this.menu_DeleteEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menu_DeleteEdit.Name = "menu_DeleteEdit";
            this.menu_DeleteEdit.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.menu_DeleteEdit.Size = new System.Drawing.Size(195, 22);
            this.menu_DeleteEdit.Text = "삭제(&L)";
            this.menu_DeleteEdit.Click += new System.EventHandler(this.menu_DeleteEdit_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(192, 6);
            // 
            // menu_FindEdit
            // 
            this.menu_FindEdit.Image = global::Memo.Properties.Resources.Find;
            this.menu_FindEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menu_FindEdit.Name = "menu_FindEdit";
            this.menu_FindEdit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.menu_FindEdit.Size = new System.Drawing.Size(195, 22);
            this.menu_FindEdit.Text = "찾기(&F)";
            this.menu_FindEdit.Click += new System.EventHandler(this.menu_FindEdit_Click);
            // 
            // menu_NextEdit
            // 
            this.menu_NextEdit.Name = "menu_NextEdit";
            this.menu_NextEdit.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.menu_NextEdit.Size = new System.Drawing.Size(195, 22);
            this.menu_NextEdit.Text = "다음 찾기(&N)";
            this.menu_NextEdit.Click += new System.EventHandler(this.menu_NextEdit_Click);
            // 
            // menu_ReEdit
            // 
            this.menu_ReEdit.Name = "menu_ReEdit";
            this.menu_ReEdit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.menu_ReEdit.Size = new System.Drawing.Size(195, 22);
            this.menu_ReEdit.Text = "바꾸기(&R)";
            this.menu_ReEdit.Click += new System.EventHandler(this.menu_ReEdit_Click);
            // 
            // menu_GoEdit
            // 
            this.menu_GoEdit.Name = "menu_GoEdit";
            this.menu_GoEdit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.G)));
            this.menu_GoEdit.Size = new System.Drawing.Size(195, 22);
            this.menu_GoEdit.Text = "이동(&G)";
            this.menu_GoEdit.Click += new System.EventHandler(this.menu_GoEdit_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(192, 6);
            // 
            // menu_AllEdit
            // 
            this.menu_AllEdit.Name = "menu_AllEdit";
            this.menu_AllEdit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.menu_AllEdit.Size = new System.Drawing.Size(195, 22);
            this.menu_AllEdit.Text = "모두선택(&A)";
            this.menu_AllEdit.Click += new System.EventHandler(this.menu_AllEdit_Click);
            // 
            // menu_DateEdit
            // 
            this.menu_DateEdit.Name = "menu_DateEdit";
            this.menu_DateEdit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.menu_DateEdit.Size = new System.Drawing.Size(195, 22);
            this.menu_DateEdit.Text = "시간 / 날짜(&D)";
            this.menu_DateEdit.Click += new System.EventHandler(this.menu_DateEdit_Click);
            // 
            // menu_Ori
            // 
            this.menu_Ori.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_WOri,
            this.menu_FOri,
            this.menu_ColorOri});
            this.menu_Ori.Name = "menu_Ori";
            this.menu_Ori.Size = new System.Drawing.Size(60, 20);
            this.menu_Ori.Text = "서식(&O)";
            this.menu_Ori.Click += new System.EventHandler(this.menu_Ori_Click);
            // 
            // menu_WOri
            // 
            this.menu_WOri.CheckOnClick = true;
            this.menu_WOri.Name = "menu_WOri";
            this.menu_WOri.Size = new System.Drawing.Size(161, 22);
            this.menu_WOri.Text = "자동 줄 바꿈(&W)";
            this.menu_WOri.Click += new System.EventHandler(this.menu_WOri_Click);
            // 
            // menu_FOri
            // 
            this.menu_FOri.Image = global::Memo.Properties.Resources.Font;
            this.menu_FOri.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menu_FOri.Name = "menu_FOri";
            this.menu_FOri.Size = new System.Drawing.Size(161, 22);
            this.menu_FOri.Text = "글꼴(&F)";
            this.menu_FOri.Click += new System.EventHandler(this.menu_FOri_Click);
            // 
            // menu_ColorOri
            // 
            this.menu_ColorOri.Image = global::Memo.Properties.Resources.ChooseColor;
            this.menu_ColorOri.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menu_ColorOri.Name = "menu_ColorOri";
            this.menu_ColorOri.Size = new System.Drawing.Size(161, 22);
            this.menu_ColorOri.Text = "색상(&C)";
            this.menu_ColorOri.Click += new System.EventHandler(this.menu_ColorOri_Click);
            // 
            // menu_View
            // 
            this.menu_View.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_StatusView,
            this.menu_PlayView});
            this.menu_View.Name = "menu_View";
            this.menu_View.Size = new System.Drawing.Size(59, 20);
            this.menu_View.Text = "보기(&V)";
            this.menu_View.Click += new System.EventHandler(this.menu_View_Click);
            // 
            // menu_StatusView
            // 
            this.menu_StatusView.Checked = true;
            this.menu_StatusView.CheckOnClick = true;
            this.menu_StatusView.CheckState = System.Windows.Forms.CheckState.Checked;
            this.menu_StatusView.Name = "menu_StatusView";
            this.menu_StatusView.Size = new System.Drawing.Size(153, 22);
            this.menu_StatusView.Text = "상태 표시줄(&S)";
            this.menu_StatusView.Click += new System.EventHandler(this.menu_StatusView_Click);
            // 
            // menu_PlayView
            // 
            this.menu_PlayView.Checked = true;
            this.menu_PlayView.CheckOnClick = true;
            this.menu_PlayView.CheckState = System.Windows.Forms.CheckState.Checked;
            this.menu_PlayView.Name = "menu_PlayView";
            this.menu_PlayView.Size = new System.Drawing.Size(153, 22);
            this.menu_PlayView.Text = "실행 아이콘(&P)";
            this.menu_PlayView.Click += new System.EventHandler(this.menu_PlayView_Click);
            // 
            // menu_Help
            // 
            this.menu_Help.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_HangHelp,
            this.toolStripSeparator6,
            this.menu_JungHelp});
            this.menu_Help.Name = "menu_Help";
            this.menu_Help.Size = new System.Drawing.Size(72, 20);
            this.menu_Help.Text = "도움말(&H)";
            this.menu_Help.Click += new System.EventHandler(this.menu_Help_Click);
            // 
            // menu_HangHelp
            // 
            this.menu_HangHelp.Name = "menu_HangHelp";
            this.menu_HangHelp.Size = new System.Drawing.Size(155, 22);
            this.menu_HangHelp.Text = "도움말 항목(&H)";
            this.menu_HangHelp.Click += new System.EventHandler(this.menu_HangHelp_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(152, 6);
            // 
            // menu_JungHelp
            // 
            this.menu_JungHelp.Name = "menu_JungHelp";
            this.menu_JungHelp.Size = new System.Drawing.Size(155, 22);
            this.menu_JungHelp.Text = "메모장 정보(&A)";
            this.menu_JungHelp.Click += new System.EventHandler(this.menu_JungHelp_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "텍스트 파일(*.txt) | *.txt | 모든 파일(*.*) | *.*";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "텍스트 파일(*.txt) | *.txt | 모든 파일(*.*) | *.*";
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.새로만들기NToolStripButton,
            this.열기OToolStripButton,
            this.저장SToolStripButton,
            this.인쇄PToolStripButton,
            this.toolStripSeparator,
            this.AlignLeft,
            this.AlignCenter,
            this.AlignRight,
            this.toolStripSeparator7,
            this.잘라내기UToolStripButton,
            this.복사CToolStripButton,
            this.붙여넣기PToolStripButton,
            this.toolStripSeparator10,
            this.도움말LToolStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(504, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // 새로만들기NToolStripButton
            // 
            this.새로만들기NToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.새로만들기NToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("새로만들기NToolStripButton.Image")));
            this.새로만들기NToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.새로만들기NToolStripButton.Name = "새로만들기NToolStripButton";
            this.새로만들기NToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.새로만들기NToolStripButton.Text = "새로 만들기(&N)";
            this.새로만들기NToolStripButton.Click += new System.EventHandler(this.새로만들기NToolStripButton_Click);
            // 
            // 열기OToolStripButton
            // 
            this.열기OToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.열기OToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("열기OToolStripButton.Image")));
            this.열기OToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.열기OToolStripButton.Name = "열기OToolStripButton";
            this.열기OToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.열기OToolStripButton.Text = "열기(&O)";
            this.열기OToolStripButton.Click += new System.EventHandler(this.열기OToolStripButton_Click);
            // 
            // 저장SToolStripButton
            // 
            this.저장SToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.저장SToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("저장SToolStripButton.Image")));
            this.저장SToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.저장SToolStripButton.Name = "저장SToolStripButton";
            this.저장SToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.저장SToolStripButton.Text = "저장(&S)";
            this.저장SToolStripButton.Click += new System.EventHandler(this.저장SToolStripButton_Click);
            // 
            // 인쇄PToolStripButton
            // 
            this.인쇄PToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.인쇄PToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("인쇄PToolStripButton.Image")));
            this.인쇄PToolStripButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.인쇄PToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.인쇄PToolStripButton.Name = "인쇄PToolStripButton";
            this.인쇄PToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.인쇄PToolStripButton.Text = "Print the file.";
            this.인쇄PToolStripButton.Click += new System.EventHandler(this.인쇄PToolStripButton_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // AlignLeft
            // 
            this.AlignLeft.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.AlignLeft.Image = global::Memo.Properties.Resources.AlignTableCellMiddleLeftJust;
            this.AlignLeft.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AlignLeft.Name = "AlignLeft";
            this.AlignLeft.Size = new System.Drawing.Size(23, 22);
            this.AlignLeft.Text = "toolStripButton1";
            this.AlignLeft.Click += new System.EventHandler(this.AlignLeft_Click);
            // 
            // AlignCenter
            // 
            this.AlignCenter.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.AlignCenter.Image = global::Memo.Properties.Resources.AlignTableCellMiddleCenter;
            this.AlignCenter.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AlignCenter.Name = "AlignCenter";
            this.AlignCenter.Size = new System.Drawing.Size(23, 22);
            this.AlignCenter.Text = "toolStripButton2";
            this.AlignCenter.Click += new System.EventHandler(this.AlignCenter_Click);
            // 
            // AlignRight
            // 
            this.AlignRight.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.AlignRight.Image = global::Memo.Properties.Resources.AlignTableCellMiddleRight;
            this.AlignRight.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AlignRight.Name = "AlignRight";
            this.AlignRight.Size = new System.Drawing.Size(23, 22);
            this.AlignRight.Text = "toolStripButton3";
            this.AlignRight.Click += new System.EventHandler(this.AlignRight_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 25);
            // 
            // 잘라내기UToolStripButton
            // 
            this.잘라내기UToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.잘라내기UToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("잘라내기UToolStripButton.Image")));
            this.잘라내기UToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.잘라내기UToolStripButton.Name = "잘라내기UToolStripButton";
            this.잘라내기UToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.잘라내기UToolStripButton.Text = "잘라내기(&U)";
            this.잘라내기UToolStripButton.Click += new System.EventHandler(this.잘라내기UToolStripButton_Click);
            // 
            // 복사CToolStripButton
            // 
            this.복사CToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.복사CToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("복사CToolStripButton.Image")));
            this.복사CToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.복사CToolStripButton.Name = "복사CToolStripButton";
            this.복사CToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.복사CToolStripButton.Text = "복사(&C)";
            this.복사CToolStripButton.Click += new System.EventHandler(this.복사CToolStripButton_Click);
            // 
            // 붙여넣기PToolStripButton
            // 
            this.붙여넣기PToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.붙여넣기PToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("붙여넣기PToolStripButton.Image")));
            this.붙여넣기PToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.붙여넣기PToolStripButton.Name = "붙여넣기PToolStripButton";
            this.붙여넣기PToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.붙여넣기PToolStripButton.Text = "붙여넣기(&P)";
            this.붙여넣기PToolStripButton.Click += new System.EventHandler(this.붙여넣기PToolStripButton_Click);
            // 
            // toolStripSeparator10
            // 
            this.toolStripSeparator10.Name = "toolStripSeparator10";
            this.toolStripSeparator10.Size = new System.Drawing.Size(6, 25);
            // 
            // 도움말LToolStripButton
            // 
            this.도움말LToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.도움말LToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("도움말LToolStripButton.Image")));
            this.도움말LToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.도움말LToolStripButton.Name = "도움말LToolStripButton";
            this.도움말LToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.도움말LToolStripButton.Text = "도움말(&L)";
            this.도움말LToolStripButton.Click += new System.EventHandler(this.도움말LToolStripButton_Click);
            // 
            // TextBox
            // 
            this.TextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextBox.Location = new System.Drawing.Point(0, 49);
            this.TextBox.Name = "TextBox";
            this.TextBox.Size = new System.Drawing.Size(504, 310);
            this.TextBox.TabIndex = 4;
            this.TextBox.Text = "";
            this.TextBox.SelectionChanged += new System.EventHandler(this.TextBox_SelectionChanged);
            this.TextBox.TextChanged += new System.EventHandler(this.TextBox_TextChanged_1);
            // 
            // pd
            // 
            this.pd.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.pd_PrintPage_1);
            // 
            // Status
            // 
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(82, 17);
            this.Status.Text = "메모장입니다.";
            this.Status.Click += new System.EventHandler(this.toolStripStatusLabel1_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Status,
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 359);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(504, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            this.statusStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.statusStrip1_ItemClicked);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(504, 381);
            this.Controls.Add(this.TextBox);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "메모장";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem menu_File;
		private System.Windows.Forms.ToolStripMenuItem menu_NewFile;
		private System.Windows.Forms.ToolStripMenuItem menu_OpenFile;
		private System.Windows.Forms.ToolStripMenuItem menu_SaveFile;
		private System.Windows.Forms.ToolStripMenuItem menu_AFile;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem menu_PageFile;
		private System.Windows.Forms.ToolStripMenuItem menu_PrintFile;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripMenuItem menu_EndFile;
		private System.Windows.Forms.ToolStripMenuItem menu_Edit;
		private System.Windows.Forms.ToolStripMenuItem menu_UndoEdit;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
		private System.Windows.Forms.ToolStripMenuItem menu_TEdit;
		private System.Windows.Forms.ToolStripMenuItem menu_CopyEdit;
		private System.Windows.Forms.ToolStripMenuItem menu_PasteEdit;
		private System.Windows.Forms.ToolStripMenuItem menu_DeleteEdit;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
		private System.Windows.Forms.ToolStripMenuItem menu_FindEdit;
		private System.Windows.Forms.ToolStripMenuItem menu_NextEdit;
		private System.Windows.Forms.ToolStripMenuItem menu_Ori;
		private System.Windows.Forms.ToolStripMenuItem menu_View;
		private System.Windows.Forms.ToolStripMenuItem menu_Help;
		private System.Windows.Forms.ToolStripMenuItem menu_ReEdit;
		private System.Windows.Forms.ToolStripMenuItem menu_GoEdit;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
		private System.Windows.Forms.ToolStripMenuItem menu_AllEdit;
		private System.Windows.Forms.ToolStripMenuItem menu_DateEdit;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.SaveFileDialog saveFileDialog1;
		private System.Windows.Forms.ToolStripMenuItem menu_WOri;
		private System.Windows.Forms.ToolStripMenuItem menu_FOri;
		private System.Windows.Forms.FontDialog fontDialog1;
		private System.Windows.Forms.ToolStripMenuItem menu_StatusView;
		private System.Windows.Forms.ToolStripMenuItem menu_ColorOri;
		private System.Windows.Forms.ToolStripMenuItem menu_HangHelp;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
		private System.Windows.Forms.ToolStripMenuItem menu_JungHelp;
		private System.Windows.Forms.ColorDialog colorDialog1;
		private System.Windows.Forms.ToolStripMenuItem menu_RedoEdit;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripButton AlignLeft;
		private System.Windows.Forms.ToolStripMenuItem menu_PlayView;
		private System.Windows.Forms.ToolStripButton AlignCenter;
		private System.Windows.Forms.ToolStripButton AlignRight;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
		private System.Windows.Forms.ToolStripButton 새로만들기NToolStripButton;
		private System.Windows.Forms.ToolStripButton 열기OToolStripButton;
		private System.Windows.Forms.ToolStripButton 저장SToolStripButton;
		private System.Windows.Forms.ToolStripButton 인쇄PToolStripButton;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
		private System.Windows.Forms.ToolStripButton 잘라내기UToolStripButton;
		private System.Windows.Forms.ToolStripButton 복사CToolStripButton;
		private System.Windows.Forms.ToolStripButton 붙여넣기PToolStripButton;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator10;
		private System.Windows.Forms.ToolStripButton 도움말LToolStripButton;
		private System.Windows.Forms.RichTextBox TextBox;
		private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
		private System.Drawing.Printing.PrintDocument pd;
		private System.Windows.Forms.ToolStripStatusLabel Status;
		private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}