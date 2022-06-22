using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Memo
{
	public partial class Go : Form
	{
		MainForm f1;

		public Go(MainForm frm)
		{
			InitializeComponent();
			f1 = frm;
		}

		private void Gotxt_TextChanged(object sender, EventArgs e)
		{
			string isNum = Gotxt.Text;
			for (int i = 0; i < isNum.Length; i++)
			{
				if (!char.IsDigit(isNum, i))
				{
					MessageBox.Show("숫자만 입력 가능합니다.", "에러");
					Gotxt.Text = "";
					break;
				}
			}
		}

		private void GoBtn_Click(object sender, EventArgs e)
		{
			this.f1.moveLine = int.Parse(Gotxt.Text);
			this.Close();
		}

		private void Cancel_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void Go_Load(object sender, EventArgs e)
		{
			
		}
	}
}
