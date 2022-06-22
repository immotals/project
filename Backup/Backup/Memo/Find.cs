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
	public partial class Find : Form
	{
		private RichTextBox rtb = null;
		private int pos = 0;
		private bool isFirst = true;

		public Find(RichTextBox sender)
		{
			rtb = sender;
			InitializeComponent();
		}

		private void FindBtn_Click(object sender, EventArgs e)
		{
			if (isFirst)
			{
				isFirst = false;
				pos = rtb.Find(FindTxt.Text, 0, RichTextBoxFinds.None);
			}
			else
				pos = rtb.Find(FindTxt.Text, pos + 1, RichTextBoxFinds.None);

			if (pos < 0)
			{
				return;
			}
			else
			{
				rtb.SelectionStart = pos;
				rtb.Focus();
			}
		}

		private void CancelBtn_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void Find_Load(object sender, EventArgs e)
		{
			
		}

		private void FindTxt_TextChanged(object sender, EventArgs e)
		{

		}

		private void FindLbl_Click(object sender, EventArgs e)
		{

		}
	}
}