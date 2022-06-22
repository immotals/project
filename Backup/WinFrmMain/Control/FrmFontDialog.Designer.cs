namespace WinFrmMain.Control
{
    partial class FrmFontDialog
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
            this.btnColor = new System.Windows.Forms.Button();
            this.txtFont = new System.Windows.Forms.TextBox();
            this.fdFont = new System.Windows.Forms.FontDialog();
            this.fdColor = new System.Windows.Forms.ColorDialog();
            this.btnFont = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnColor
            // 
            this.btnColor.Location = new System.Drawing.Point(93, 10);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(75, 23);
            this.btnColor.TabIndex = 5;
            this.btnColor.Text = "색상...";
            this.btnColor.UseVisualStyleBackColor = true;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // txtFont
            // 
            this.txtFont.Location = new System.Drawing.Point(12, 39);
            this.txtFont.Multiline = true;
            this.txtFont.Name = "txtFont";
            this.txtFont.Size = new System.Drawing.Size(268, 220);
            this.txtFont.TabIndex = 3;
            // 
            // btnFont
            // 
            this.btnFont.Location = new System.Drawing.Point(12, 10);
            this.btnFont.Name = "btnFont";
            this.btnFont.Size = new System.Drawing.Size(75, 23);
            this.btnFont.TabIndex = 4;
            this.btnFont.Text = "글꼴...";
            this.btnFont.UseVisualStyleBackColor = true;
            this.btnFont.Click += new System.EventHandler(this.btnFont_Click);
            // 
            // FrmFontDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 268);
            this.Controls.Add(this.btnColor);
            this.Controls.Add(this.txtFont);
            this.Controls.Add(this.btnFont);
            this.Name = "FrmFontDialog";
            this.Text = "Font";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.TextBox txtFont;
        private System.Windows.Forms.FontDialog fdFont;
        private System.Windows.Forms.ColorDialog fdColor;
        private System.Windows.Forms.Button btnFont;
    }
}