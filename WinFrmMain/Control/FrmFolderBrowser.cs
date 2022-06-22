using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WinFrmMain.Control
{
    public partial class FrmFolderBrowser : Form
    {
        public FrmFolderBrowser()
        {
            InitializeComponent();
        }

        private void btnFolderBrowserOpen_Click(object sender, EventArgs e)
        {
            DialogResult dr = folderBrowser.ShowDialog();
            if (dr == DialogResult.OK)
            {
                MessageBox.Show("선택경로 : " + folderBrowser.SelectedPath);
            }
        }
    }
}