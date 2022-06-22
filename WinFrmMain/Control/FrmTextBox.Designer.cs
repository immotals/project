namespace WinFrmMain.Control
{
    partial class FrmTextBox
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
            this.txtReadOnly = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMask = new System.Windows.Forms.MaskedTextBox();
            this.txtRich = new System.Windows.Forms.RichTextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.txtMulth = new System.Windows.Forms.TextBox();
            this.txtSingle = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtReadOnly
            // 
            this.txtReadOnly.Location = new System.Drawing.Point(135, 170);
            this.txtReadOnly.Name = "txtReadOnly";
            this.txtReadOnly.ReadOnly = true;
            this.txtReadOnly.Size = new System.Drawing.Size(176, 21);
            this.txtReadOnly.TabIndex = 25;
            this.txtReadOnly.Text = "읽기전용";
            this.txtReadOnly.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 173);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 12);
            this.label6.TabIndex = 24;
            this.label6.Text = "읽기전용 텍스트박스";
            // 
            // txtMask
            // 
            this.txtMask.Location = new System.Drawing.Point(135, 134);
            this.txtMask.Mask = "0000년 90월 90일";
            this.txtMask.Name = "txtMask";
            this.txtMask.Size = new System.Drawing.Size(176, 21);
            this.txtMask.TabIndex = 23;
            this.txtMask.ValidatingType = typeof(System.DateTime);
            // 
            // txtRich
            // 
            this.txtRich.Location = new System.Drawing.Point(135, 210);
            this.txtRich.Name = "txtRich";
            this.txtRich.Size = new System.Drawing.Size(176, 96);
            this.txtRich.TabIndex = 22;
            this.txtRich.Text = "";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(236, 312);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 21;
            this.btnOK.Text = "확인";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 213);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 12);
            this.label5.TabIndex = 20;
            this.label5.Text = "리치 텍스트박스";
            // 
            // txtPwd
            // 
            this.txtPwd.Location = new System.Drawing.Point(135, 104);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.PasswordChar = '*';
            this.txtPwd.Size = new System.Drawing.Size(176, 21);
            this.txtPwd.TabIndex = 19;
            // 
            // txtMulth
            // 
            this.txtMulth.Location = new System.Drawing.Point(135, 33);
            this.txtMulth.Multiline = true;
            this.txtMulth.Name = "txtMulth";
            this.txtMulth.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMulth.Size = new System.Drawing.Size(176, 61);
            this.txtMulth.TabIndex = 18;
            // 
            // txtSingle
            // 
            this.txtSingle.Location = new System.Drawing.Point(135, 6);
            this.txtSingle.Name = "txtSingle";
            this.txtSingle.Size = new System.Drawing.Size(176, 21);
            this.txtSingle.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 12);
            this.label4.TabIndex = 16;
            this.label4.Text = "마스크 텍스트박스";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 12);
            this.label3.TabIndex = 15;
            this.label3.Text = "패스워드 텍스트박스";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 12);
            this.label2.TabIndex = 14;
            this.label2.Text = "멀리타인 텍스트박스";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 12);
            this.label1.TabIndex = 13;
            this.label1.Text = "싱글라인 텍스트박스";
            // 
            // FrmTextBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 345);
            this.Controls.Add(this.txtReadOnly);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtMask);
            this.Controls.Add(this.txtRich);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPwd);
            this.Controls.Add(this.txtMulth);
            this.Controls.Add(this.txtSingle);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmTextBox";
            this.Text = "FrmTextBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtReadOnly;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox txtMask;
        private System.Windows.Forms.RichTextBox txtRich;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPwd;
        private System.Windows.Forms.TextBox txtMulth;
        private System.Windows.Forms.TextBox txtSingle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}