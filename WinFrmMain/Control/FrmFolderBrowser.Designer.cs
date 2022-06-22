namespace WinFrmMain.Control
{
    partial class FrmFolderBrowser
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
            this.btnFolderBrowserOpen = new System.Windows.Forms.Button();
            this.folderBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // btnFolderBrowserOpen
            // 
            this.btnFolderBrowserOpen.Location = new System.Drawing.Point(12, 12);
            this.btnFolderBrowserOpen.Name = "btnFolderBrowserOpen";
            this.btnFolderBrowserOpen.Size = new System.Drawing.Size(75, 23);
            this.btnFolderBrowserOpen.TabIndex = 0;
            this.btnFolderBrowserOpen.Text = "폴더열기";
            this.btnFolderBrowserOpen.UseVisualStyleBackColor = true;
            this.btnFolderBrowserOpen.Click += new System.EventHandler(this.btnFolderBrowserOpen_Click);
            // 
            // FrmFolderBrowser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 69);
            this.Controls.Add(this.btnFolderBrowserOpen);
            this.Name = "FrmFolderBrowser";
            this.Text = "폴더";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFolderBrowserOpen;
        private System.Windows.Forms.FolderBrowserDialog folderBrowser;
    }
}