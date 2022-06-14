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
    public partial class Q2 : Form
    {
        public State State;
        public Q2(ref State state)
        {
            this.State = state;
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var f1 = (Main)(this.Tag);
            f1.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            R2 f2 = new R2(ref State);
            f2.Tag = this;
            f2.Show();
            this.Hide();
        }

        private void Q2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                State.q2 = 'A';
                State.q2a += 1;
            }
            else if (radioButton2.Checked == true)
            {
                State.q2 = 'B';
                State.q2b += 1;
            }
        }
    }
}
