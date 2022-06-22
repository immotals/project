namespace Memo
{
	partial class Find
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
			this.FindLbl = new System.Windows.Forms.Label();
			this.FindTxt = new System.Windows.Forms.TextBox();
			this.FindBtn = new System.Windows.Forms.Button();
			this.CancelBtn = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// FindLbl
			// 
			this.FindLbl.AutoSize = true;
			this.FindLbl.Location = new System.Drawing.Point(12, 18);
			this.FindLbl.Name = "FindLbl";
			this.FindLbl.Size = new System.Drawing.Size(88, 12);
			this.FindLbl.TabIndex = 0;
			this.FindLbl.Text = "찾을 내용(&N) : ";
			this.FindLbl.Click += new System.EventHandler(this.FindLbl_Click);
			// 
			// FindTxt
			// 
			this.FindTxt.Location = new System.Drawing.Point(106, 12);
			this.FindTxt.Name = "FindTxt";
			this.FindTxt.Size = new System.Drawing.Size(184, 21);
			this.FindTxt.TabIndex = 1;
			this.FindTxt.TextChanged += new System.EventHandler(this.FindTxt_TextChanged);
			// 
			// FindBtn
			// 
			this.FindBtn.Location = new System.Drawing.Point(106, 39);
			this.FindBtn.Name = "FindBtn";
			this.FindBtn.Size = new System.Drawing.Size(79, 23);
			this.FindBtn.TabIndex = 3;
			this.FindBtn.Text = "찾기";
			this.FindBtn.UseVisualStyleBackColor = true;
			this.FindBtn.Click += new System.EventHandler(this.FindBtn_Click);
			// 
			// CancelBtn
			// 
			this.CancelBtn.Location = new System.Drawing.Point(211, 39);
			this.CancelBtn.Name = "CancelBtn";
			this.CancelBtn.Size = new System.Drawing.Size(79, 23);
			this.CancelBtn.TabIndex = 3;
			this.CancelBtn.Text = "취소";
			this.CancelBtn.UseVisualStyleBackColor = true;
			this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
			// 
			// Find
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(302, 72);
			this.Controls.Add(this.CancelBtn);
			this.Controls.Add(this.FindBtn);
			this.Controls.Add(this.FindTxt);
			this.Controls.Add(this.FindLbl);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
			this.Name = "Find";
			this.Text = "찾기";
			this.Load += new System.EventHandler(this.Find_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label FindLbl;
		private System.Windows.Forms.TextBox FindTxt;
		private System.Windows.Forms.Button FindBtn;
		private System.Windows.Forms.Button CancelBtn;
	}
}