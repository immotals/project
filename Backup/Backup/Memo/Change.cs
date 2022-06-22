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
	public partial class Change : Form
	{
		private RichTextBox rtb = null;
		private int pos = 0;
		private bool isFirst = true;

		public Change(RichTextBox sender)
		{
			rtb = sender;
			InitializeComponent();
		}

		private void Change_Load(object sender, EventArgs e){}
		
		private void changeBtn_Click(object sender, EventArgs e)
		{
			if (isFirst)
			{
				isFirst = false;
				pos = rtb.Find(findTxt.Text, 0, RichTextBoxFinds.None);
			}
			else
				pos = rtb.Find(findTxt.Text, pos + 1, RichTextBoxFinds.None);

			if (pos < 0)
			{
				return;
			}
			else
			{
				//rtb.SelectionStart = pos;
				rtb.SelectedText = rtb.SelectedText.Replace(findTxt.Text, changeTxt.Text);
			}
		}

		private void findTxt_TextChanged(object sender, EventArgs e){}
		private void changeTxt_TextChanged(object sender, EventArgs e){}

		private void cancelBtn_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
