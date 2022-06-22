using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace WinFrmMain.Sample
{
    public partial class FrmSampleNotepad : Form
    {
        public FrmSampleNotepad()
        {
            InitializeComponent();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = "텍스트파일|*.txt"; //코드레벨에서 직접 설정
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                //텍스트 파일열기
                StreamReader sr = new StreamReader(openFileDialog.FileName, Encoding.Default);

                //데이터 읽어오기
                txtNote.Text = sr.ReadToEnd(); //텍스트 모두 열기
                //파일 닫기
                sr.Close();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            saveFileDialog.Filter = "텍스트파일|*.txt";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(saveFileDialog.FileName,false, Encoding.Default); //한글깨지면(미리방지용)
                sw.Write(txtNote.Text);
                sw.Close();
            }
        }
    }
}
