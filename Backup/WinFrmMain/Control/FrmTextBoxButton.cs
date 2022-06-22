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
    public partial class FrmTextBoxButton : Form
    {
        public FrmTextBoxButton()
        {
            InitializeComponent();
        }  

        private void btnOK_Click(object sender, EventArgs e)
        {
            string msg = ""; int Total = 0;
            Total = Convert.ToInt32(txtKor.Text) + Convert.ToInt32(txtEng.Text);
            msg = Convert.ToString(Total);
            MessageBox.Show(msg);

            txtKor.Focus();
            btnCancel_Click(null, null);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtKor.Text = ""; txtEng.Text = ""; txtKor.Focus();
        }

        private void txtKor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {  
                txtEng.Focus(); 
            }
        }

        private void txtEng_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnOK.Focus();
            }
        }
    }
}