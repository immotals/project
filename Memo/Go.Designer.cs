namespace Memo
{
	partial class Go
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
            this.label1 = new System.Windows.Forms.Label();
            this.Gotxt = new System.Windows.Forms.TextBox();
            this.GoBtn = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "줄 번호 : ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Gotxt
            // 
            this.Gotxt.Location = new System.Drawing.Point(75, 6);
            this.Gotxt.Name = "Gotxt";
            this.Gotxt.Size = new System.Drawing.Size(53, 21);
            this.Gotxt.TabIndex = 1;
            this.Gotxt.TextChanged += new System.EventHandler(this.Gotxt_TextChanged);
            // 
            // GoBtn
            // 
            this.GoBtn.Location = new System.Drawing.Point(134, 5);
            this.GoBtn.Name = "GoBtn";
            this.GoBtn.Size = new System.Drawing.Size(44, 22);
            this.GoBtn.TabIndex = 2;
            this.GoBtn.Text = "이동";
            this.GoBtn.UseVisualStyleBackColor = true;
            this.GoBtn.Click += new System.EventHandler(this.GoBtn_Click);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(184, 6);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(44, 22);
            this.Cancel.TabIndex = 3;
            this.Cancel.Text = "취소";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // Go
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(236, 31);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.GoBtn);
            this.Controls.Add(this.Gotxt);
            this.Controls.Add(this.label1);
            this.Name = "Go";
            this.Text = "Go";
            this.Load += new System.EventHandler(this.Go_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox Gotxt;
		private System.Windows.Forms.Button GoBtn;
		private System.Windows.Forms.Button Cancel;
	}
}