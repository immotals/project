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
    public partial class R1 : Form
    {
        public R1(ref State state)
        {
            InitializeComponent();
            dataGridView1.Rows.Add(new object[] { state.q1a, state.q1b });
        }



        private void button2_Click(object sender, EventArgs e)
        {
            var f1 = (Q1)(this.Tag);
            f1.Show();
            this.Hide();
        }

        private void R1_Load(object sender, EventArgs e)
        {

        }
    }
}
