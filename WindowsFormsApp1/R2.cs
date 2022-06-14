using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class R2 : Form
    {
        public R2(ref State state)
        {
            InitializeComponent();
            dataGridView3.Rows.Add(new object[] { state.q2a, state.q2b });
        }


        private void button2_Click(object sender, EventArgs e)
        {
            var f1 = (Q2)(this.Tag);
            f1.Show();
            this.Hide();
        }

        private void R2_Load(object sender, EventArgs e)
        {

        }
    }
}
