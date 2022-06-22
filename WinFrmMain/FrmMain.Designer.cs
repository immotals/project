namespace WinFrmMain
{
    partial class FrmMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.munFile = new System.Windows.Forms.ToolStripMenuItem();
            this.miExit = new System.Windows.Forms.ToolStripMenuItem();
            this.munEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.munView = new System.Windows.Forms.ToolStripMenuItem();
            this.munControl = new System.Windows.Forms.ToolStripMenuItem();
            this.miCommonContro = new System.Windows.Forms.ToolStripMenuItem();
            this.체크박스와라디오박스ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miMDIForm = new System.Windows.Forms.ToolStripMenuItem();
            this.miFrmTextBoxButton = new System.Windows.Forms.ToolStripMenuItem();
            this.miTextBox = new System.Windows.Forms.ToolStripMenuItem();
            this.miComboListBox = new System.Windows.Forms.ToolStripMenuItem();
            this.miCon = new System.Windows.Forms.ToolStripMenuItem();
            this.miGroupBox = new System.Windows.Forms.ToolStripMenuItem();
            this.대화상자ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miFont = new System.Windows.Forms.ToolStripMenuItem();
            this.miFolderBrowser = new System.Windows.Forms.ToolStripMenuItem();
            this.miClass = new System.Windows.Forms.ToolStripMenuItem();
            this.miMessAgeBox = new System.Windows.Forms.ToolStripMenuItem();
            this.miDialogResult = new System.Windows.Forms.ToolStripMenuItem();
            this.munHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.miAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.샘플SToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miFrmNotepad = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.munFile,
            this.munEdit,
            this.munView,
            this.munControl,
            this.miClass,
            this.샘플SToolStripMenuItem,
            this.munHelp});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(581, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // munFile
            // 
            this.munFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miExit});
            this.munFile.Name = "munFile";
            this.munFile.Size = new System.Drawing.Size(57, 20);
            this.munFile.Text = "파일(&F)";
            // 
            // miExit
            // 
            this.miExit.Name = "miExit";
            this.miExit.Size = new System.Drawing.Size(125, 22);
            this.miExit.Text = "끝내기(&X)";
            this.miExit.Click += new System.EventHandler(this.miExit_Click);
            // 
            // munEdit
            // 
            this.munEdit.Name = "munEdit";
            this.munEdit.Size = new System.Drawing.Size(57, 20);
            this.munEdit.Text = "편집(&E)";
            // 
            // munView
            // 
            this.munView.Name = "munView";
            this.munView.Size = new System.Drawing.Size(59, 20);
            this.munView.Text = "보기(&V)";
            // 
            // munControl
            // 
            this.munControl.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miCommonContro,
            this.miCon,
            this.대화상자ToolStripMenuItem});
            this.munControl.Name = "munControl";
            this.munControl.Size = new System.Drawing.Size(71, 20);
            this.munControl.Text = "컨트롤(&C)";
            // 
            // miCommonContro
            // 
            this.miCommonContro.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.체크박스와라디오박스ToolStripMenuItem,
            this.miMDIForm,
            this.miFrmTextBoxButton,
            this.miTextBox,
            this.miComboListBox});
            this.miCommonContro.Name = "miCommonContro";
            this.miCommonContro.Size = new System.Drawing.Size(152, 22);
            this.miCommonContro.Text = "공용컨트롤";
            // 
            // 체크박스와라디오박스ToolStripMenuItem
            // 
            this.체크박스와라디오박스ToolStripMenuItem.Name = "체크박스와라디오박스ToolStripMenuItem";
            this.체크박스와라디오박스ToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.체크박스와라디오박스ToolStripMenuItem.Text = "체크박스와 라디오박스";
            this.체크박스와라디오박스ToolStripMenuItem.Click += new System.EventHandler(this.체크박스와라디오박스ToolStripMenuItem_Click);
            // 
            // miMDIForm
            // 
            this.miMDIForm.Name = "miMDIForm";
            this.miMDIForm.Size = new System.Drawing.Size(198, 22);
            this.miMDIForm.Text = "MID";
            this.miMDIForm.Click += new System.EventHandler(this.miMDIForm_Click);
            // 
            // miFrmTextBoxButton
            // 
            this.miFrmTextBoxButton.Name = "miFrmTextBoxButton";
            this.miFrmTextBoxButton.Size = new System.Drawing.Size(198, 22);
            this.miFrmTextBoxButton.Text = "텍스트박스";
            this.miFrmTextBoxButton.Click += new System.EventHandler(this.miFrmTextBoxButton_Click);
            // 
            // miTextBox
            // 
            this.miTextBox.Name = "miTextBox";
            this.miTextBox.Size = new System.Drawing.Size(198, 22);
            this.miTextBox.Text = "텍스트박스종류";
            this.miTextBox.Click += new System.EventHandler(this.miTextBox_Click);
            // 
            // miComboListBox
            // 
            this.miComboListBox.Name = "miComboListBox";
            this.miComboListBox.Size = new System.Drawing.Size(198, 22);
            this.miComboListBox.Text = "콤보박스리스트박스";
            this.miComboListBox.Click += new System.EventHandler(this.miComboListBox_Click);
            // 
            // miCon
            // 
            this.miCon.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miGroupBox});
            this.miCon.Name = "miCon";
            this.miCon.Size = new System.Drawing.Size(152, 22);
            this.miCon.Text = "컨테이너";
            // 
            // miGroupBox
            // 
            this.miGroupBox.Name = "miGroupBox";
            this.miGroupBox.Size = new System.Drawing.Size(122, 22);
            this.miGroupBox.Text = "그룹박스";
            this.miGroupBox.Click += new System.EventHandler(this.miGroupBox_Click);
            // 
            // 대화상자ToolStripMenuItem
            // 
            this.대화상자ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miFont,
            this.miFolderBrowser});
            this.대화상자ToolStripMenuItem.Name = "대화상자ToolStripMenuItem";
            this.대화상자ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.대화상자ToolStripMenuItem.Text = "대화상자";
            // 
            // miFont
            // 
            this.miFont.Name = "miFont";
            this.miFont.Size = new System.Drawing.Size(152, 22);
            this.miFont.Text = "폰트";
            this.miFont.Click += new System.EventHandler(this.miFont_Click);
            // 
            // miFolderBrowser
            // 
            this.miFolderBrowser.Name = "miFolderBrowser";
            this.miFolderBrowser.Size = new System.Drawing.Size(152, 22);
            this.miFolderBrowser.Text = "폴더";
            this.miFolderBrowser.Click += new System.EventHandler(this.miFolderBrowser_Click);
            // 
            // miClass
            // 
            this.miClass.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miMessAgeBox,
            this.miDialogResult});
            this.miClass.Name = "miClass";
            this.miClass.Size = new System.Drawing.Size(71, 20);
            this.miClass.Text = "클래스(&U)";
            // 
            // miMessAgeBox
            // 
            this.miMessAgeBox.Name = "miMessAgeBox";
            this.miMessAgeBox.Size = new System.Drawing.Size(178, 22);
            this.miMessAgeBox.Text = "메시지박스";
            this.miMessAgeBox.Click += new System.EventHandler(this.miMessAgeBox_Click);
            // 
            // miDialogResult
            // 
            this.miDialogResult.Name = "miDialogResult";
            this.miDialogResult.Size = new System.Drawing.Size(178, 22);
            this.miDialogResult.Text = "대화상자(값넘기기)";
            this.miDialogResult.Click += new System.EventHandler(this.miDialogResult_Click);
            // 
            // munHelp
            // 
            this.munHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miAbout});
            this.munHelp.Name = "munHelp";
            this.munHelp.Size = new System.Drawing.Size(71, 20);
            this.munHelp.Text = "도움말(&A)";
            // 
            // miAbout
            // 
            this.miAbout.Name = "miAbout";
            this.miAbout.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.miAbout.Size = new System.Drawing.Size(182, 22);
            this.miAbout.Text = "프로그램정보(&A)";
            this.miAbout.Click += new System.EventHandler(this.miAbout_Click);
            // 
            // 샘플SToolStripMenuItem
            // 
            this.샘플SToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miFrmNotepad});
            this.샘플SToolStripMenuItem.Name = "샘플SToolStripMenuItem";
            this.샘플SToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.샘플SToolStripMenuItem.Text = "샘플(&S)";
            // 
            // miFrmNotepad
            // 
            this.miFrmNotepad.Name = "miFrmNotepad";
            this.miFrmNotepad.Size = new System.Drawing.Size(152, 22);
            this.miFrmNotepad.Text = "간단한메모장";
            this.miFrmNotepad.Click += new System.EventHandler(this.miFrmNotepad_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 432);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.Name = "FrmMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem munFile;
        private System.Windows.Forms.ToolStripMenuItem miExit;
        private System.Windows.Forms.ToolStripMenuItem munEdit;
        private System.Windows.Forms.ToolStripMenuItem munView;
        private System.Windows.Forms.ToolStripMenuItem munControl;
        private System.Windows.Forms.ToolStripMenuItem munHelp;
        private System.Windows.Forms.ToolStripMenuItem miAbout;
        private System.Windows.Forms.ToolStripMenuItem miCommonContro;
        private System.Windows.Forms.ToolStripMenuItem 체크박스와라디오박스ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem miMDIForm;
        private System.Windows.Forms.ToolStripMenuItem miFrmTextBoxButton;
        private System.Windows.Forms.ToolStripMenuItem miTextBox;
        private System.Windows.Forms.ToolStripMenuItem miClass;
        private System.Windows.Forms.ToolStripMenuItem miMessAgeBox;
        private System.Windows.Forms.ToolStripMenuItem miCon;
        private System.Windows.Forms.ToolStripMenuItem miGroupBox;
        private System.Windows.Forms.ToolStripMenuItem miComboListBox;
        private System.Windows.Forms.ToolStripMenuItem miDialogResult;
        private System.Windows.Forms.ToolStripMenuItem 대화상자ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem miFont;
        private System.Windows.Forms.ToolStripMenuItem miFolderBrowser;
        private System.Windows.Forms.ToolStripMenuItem 샘플SToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem miFrmNotepad;

    }
}

