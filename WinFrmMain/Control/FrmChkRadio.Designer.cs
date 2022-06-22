namespace WinFrmMain.Control
{
    partial class FrmChkRadio
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
            this.button1 = new System.Windows.Forms.Button();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.optWomen = new System.Windows.Forms.RadioButton();
            this.optMan = new System.Windows.Forms.RadioButton();
            this.btnok = new System.Windows.Forms.Button();
            this.chkSil = new System.Windows.Forms.CheckBox();
            this.chkAsp = new System.Windows.Forms.CheckBox();
            this.chkCsharp = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(216, 225);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(51, 23);
            this.button1.TabIndex = 19;
            this.button1.Text = "취소";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(110, 24);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(157, 195);
            this.txtResult.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 17;
            this.label2.Text = "성별";
            // 
            // optWomen
            // 
            this.optWomen.AutoSize = true;
            this.optWomen.Location = new System.Drawing.Point(31, 187);
            this.optWomen.Name = "optWomen";
            this.optWomen.Size = new System.Drawing.Size(47, 16);
            this.optWomen.TabIndex = 16;
            this.optWomen.TabStop = true;
            this.optWomen.Text = "여자";
            this.optWomen.UseVisualStyleBackColor = true;
            // 
            // optMan
            // 
            this.optMan.AutoSize = true;
            this.optMan.Location = new System.Drawing.Point(31, 160);
            this.optMan.Name = "optMan";
            this.optMan.Size = new System.Drawing.Size(47, 16);
            this.optMan.TabIndex = 15;
            this.optMan.TabStop = true;
            this.optMan.Text = "남자";
            this.optMan.UseVisualStyleBackColor = true;
            // 
            // btnok
            // 
            this.btnok.Location = new System.Drawing.Point(160, 225);
            this.btnok.Name = "btnok";
            this.btnok.Size = new System.Drawing.Size(50, 23);
            this.btnok.TabIndex = 14;
            this.btnok.Text = "확인";
            this.btnok.UseVisualStyleBackColor = true;
            this.btnok.Click += new System.EventHandler(this.btnok_Click);
            // 
            // chkSil
            // 
            this.chkSil.AutoSize = true;
            this.chkSil.Location = new System.Drawing.Point(27, 84);
            this.chkSil.Name = "chkSil";
            this.chkSil.Size = new System.Drawing.Size(78, 16);
            this.chkSil.TabIndex = 13;
            this.chkSil.Text = "Silverlight";
            this.chkSil.UseVisualStyleBackColor = true;
            // 
            // chkAsp
            // 
            this.chkAsp.AutoSize = true;
            this.chkAsp.Location = new System.Drawing.Point(27, 62);
            this.chkAsp.Name = "chkAsp";
            this.chkAsp.Size = new System.Drawing.Size(77, 16);
            this.chkAsp.TabIndex = 12;
            this.chkAsp.Text = "ASP.NET";
            this.chkAsp.UseVisualStyleBackColor = true;
            // 
            // chkCsharp
            // 
            this.chkCsharp.AutoSize = true;
            this.chkCsharp.Location = new System.Drawing.Point(27, 40);
            this.chkCsharp.Name = "chkCsharp";
            this.chkCsharp.Size = new System.Drawing.Size(39, 16);
            this.chkCsharp.TabIndex = 11;
            this.chkCsharp.Text = "C#";
            this.chkCsharp.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 10;
            this.label1.Text = "관심사항";
            // 
            // FrmChkRadio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 268);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.optWomen);
            this.Controls.Add(this.optMan);
            this.Controls.Add(this.btnok);
            this.Controls.Add(this.chkSil);
            this.Controls.Add(this.chkAsp);
            this.Controls.Add(this.chkCsharp);
            this.Controls.Add(this.label1);
            this.Name = "FrmChkRadio";
            this.Text = "FrmChkRadio";
            this.Load += new System.EventHandler(this.FrmChkRadio_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton optWomen;
        private System.Windows.Forms.RadioButton optMan;
        private System.Windows.Forms.Button btnok;
        private System.Windows.Forms.CheckBox chkSil;
        private System.Windows.Forms.CheckBox chkAsp;
        private System.Windows.Forms.CheckBox chkCsharp;
        private System.Windows.Forms.Label label1;
    }
}