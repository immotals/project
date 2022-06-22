using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WinFrmMain
{
    public partial class FrmAbout : Form
    {
        public FrmAbout()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string url = "http://godffs.tistory.com";
            System.Diagnostics.Process.Start(url); //위 경로 띄우기

            System.Diagnostics.Process.Start("notepad.exe"); //실행 창에서 여는 명령어
        }
    }
}
