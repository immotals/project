namespace Memo
{
	partial class Change
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
			this.findLbl = new System.Windows.Forms.Label();
			this.changeLbl = new System.Windows.Forms.Label();
			this.findTxt = new System.Windows.Forms.TextBox();
			this.changeTxt = new System.Windows.Forms.TextBox();
			this.changeBtn = new System.Windows.Forms.Button();
			this.cancelBtn = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// findLbl
			// 
			this.findLbl.AutoSize = true;
			this.findLbl.Location = new System.Drawing.Point(12, 9);
			this.findLbl.Name = "findLbl";
			this.findLbl.Size = new System.Drawing.Size(88, 12);
			this.findLbl.TabIndex = 0;
			this.findLbl.Text = "찾을 내용(&N) : ";
			// 
			// changeLbl
			// 
			this.changeLbl.AutoSize = true;
			this.changeLbl.Location = new System.Drawing.Point(12, 37);
			this.changeLbl.Name = "changeLbl";
			this.changeLbl.Size = new System.Drawing.Size(87, 12);
			this.changeLbl.TabIndex = 1;
			this.changeLbl.Text = "바꿀 내용(&P) : ";
			// 
			// findTxt
			// 
			this.findTxt.Location = new System.Drawing.Point(106, 6);
			this.findTxt.Name = "findTxt";
			this.findTxt.Size = new System.Drawing.Size(187, 21);
			this.findTxt.TabIndex = 2;
			this.findTxt.TextChanged += new System.EventHandler(this.findTxt_TextChanged);
			// 
			// changeTxt
			// 
			this.changeTxt.Location = new System.Drawing.Point(106, 34);
			this.changeTxt.Name = "changeTxt";
			this.changeTxt.Size = new System.Drawing.Size(187, 21);
			this.changeTxt.TabIndex = 3;
			this.changeTxt.TextChanged += new System.EventHandler(this.changeTxt_TextChanged);
			// 
			// changeBtn
			// 
			this.changeBtn.Location = new System.Drawing.Point(299, 6);
			this.changeBtn.Name = "changeBtn";
			this.changeBtn.Size = new System.Drawing.Size(82, 21);
			this.changeBtn.TabIndex = 4;
			this.changeBtn.Text = "바꾸기(&R)";
			this.changeBtn.UseVisualStyleBackColor = true;
			this.changeBtn.Click += new System.EventHandler(this.changeBtn_Click);
			// 
			// cancelBtn
			// 
			this.cancelBtn.Location = new System.Drawing.Point(299, 34);
			this.cancelBtn.Name = "cancelBtn";
			this.cancelBtn.Size = new System.Drawing.Size(82, 21);
			this.cancelBtn.TabIndex = 5;
			this.cancelBtn.Text = "취소";
			this.cancelBtn.UseVisualStyleBackColor = true;
			this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
			// 
			// Change
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(396, 63);
			this.Controls.Add(this.cancelBtn);
			this.Controls.Add(this.changeBtn);
			this.Controls.Add(this.changeTxt);
			this.Controls.Add(this.findTxt);
			this.Controls.Add(this.changeLbl);
			this.Controls.Add(this.findLbl);
			this.Name = "Change";
			this.Text = "바꾸기";
			this.Load += new System.EventHandler(this.Change_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label findLbl;
		private System.Windows.Forms.Label changeLbl;
		private System.Windows.Forms.TextBox findTxt;
		private System.Windows.Forms.TextBox changeTxt;
		private System.Windows.Forms.Button changeBtn;
		private System.Windows.Forms.Button cancelBtn;
	}
}