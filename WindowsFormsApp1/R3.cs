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
    public partial class R3 : Form
    {
        public R3(ref State state)
        {
            InitializeComponent();
            dataGridView2.Rows.Add(new object[] { state.q3a, state.q3b, state.q3c });
        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            var f1 = (Q3)(this.Tag);
            f1.Show();
            this.Hide();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
