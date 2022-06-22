namespace WinFrmMain.Control
{
    partial class FrmComboListBox
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lstOutput = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.txtRead = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lstIconBox = new System.Windows.Forms.ListBox();
            this.cboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lstOutput
            // 
            this.lstOutput.AutoSize = true;
            this.lstOutput.Location = new System.Drawing.Point(112, 228);
            this.lstOutput.Name = "lstOutput";
            this.lstOutput.Size = new System.Drawing.Size(65, 12);
            this.lstOutput.TabIndex = 13;
            this.lstOutput.Text = "__________";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(145, 175);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 12;
            this.btnOK.Text = "확인";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // txtRead
            // 
            this.txtRead.Location = new System.Drawing.Point(39, 177);
            this.txtRead.Name = "txtRead";
            this.txtRead.ReadOnly = true;
            this.txtRead.Size = new System.Drawing.Size(100, 21);
            this.txtRead.TabIndex = 11;
            this.txtRead.Text = "메시지박스";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(152, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 12);
            this.label2.TabIndex = 10;
            this.label2.Text = "아이콘의종류";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 12);
            this.label1.TabIndex = 9;
            this.label1.Text = "버튼의 종류";
            // 
            // lstIconBox
            // 
            this.lstIconBox.FormattingEnabled = true;
            this.lstIconBox.ItemHeight = 12;
            this.lstIconBox.Location = new System.Drawing.Point(154, 54);
            this.lstIconBox.Name = "lstIconBox";
            this.lstIconBox.Size = new System.Drawing.Size(120, 112);
            this.lstIconBox.TabIndex = 8;
            // 
            // cboBox
            // 
            this.cboBox.FormattingEnabled = true;
            this.cboBox.Items.AddRange(new object[] {
            "OK",
            "OKCancel",
            "YesNo",
            "YesNoCancel",
            "RetryCancel",
            "AbortRetryinnore"});
            this.cboBox.Location = new System.Drawing.Point(18, 54);
            this.cboBox.Name = "cboBox";
            this.cboBox.Size = new System.Drawing.Size(121, 20);
            this.cboBox.TabIndex = 7;
            this.cboBox.Text = "-- 선택 --";
            // 
            // FrmComboListBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 268);
            this.Controls.Add(this.lstOutput);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtRead);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstIconBox);
            this.Controls.Add(this.cboBox);
            this.Name = "FrmComboListBox";
            this.Text = "FrmComboListBox";
            this.Load += new System.EventHandler(this.FrmComboListBox_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lstOutput;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.TextBox txtRead;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstIconBox;
        private System.Windows.Forms.ComboBox cboBox;
    }
}