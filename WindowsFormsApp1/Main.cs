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
    public partial class Main : Form
    {
        public State ste;
        public Main(ref State state)
        {
            this.ste = state;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Q1 f2 = new Q1(ref ste);
            f2.Tag = this;
            f2.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Q2 f2 = new Q2(ref ste);
            f2.Tag = this;
            f2.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Q3 f2 = new Q3(ref ste);
            f2.Tag = this;
            f2.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Result f2 = new Result(ref ste);
            f2.Tag = this;
            f2.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var f1 = (Login)(this.Tag);
            f1.Show();
            this.Hide();
        }
    }
}
