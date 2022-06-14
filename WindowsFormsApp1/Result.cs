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
    public partial class Result : Form
    {
        public Result(ref State state)
        {
            InitializeComponent();
            dataGridView1.Rows.Add(new object[] { state.q1a, state.q1b });
            dataGridView3.Rows.Add(new object[] { state.q2a, state.q2b });
            dataGridView2.Rows.Add(new object[] { state.q3a, state.q3b, state.q3c });
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var f1 = (Main)(this.Tag);
            f1.Show();
            this.Hide();
        }

        private void Result_Load(object sender, EventArgs e)
        {

        }
    }
}
