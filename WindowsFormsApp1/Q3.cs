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
    public partial class Q3 : Form
    {
        public State State;
        public Q3(ref State state)
        {
            this.State = state;
            InitializeComponent();
        }

        private void Q3_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var f1 = (Main)(this.Tag);
            f1.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            R3 f2 = new R3(ref State);
            f2.Tag = this;
            f2.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                State.q3 = 'A';
                State.q3a += 1;
            }
            else if (radioButton2.Checked == true)
            {
                State.q3 = 'B';
                State.q3b += 1;
            }
            else if (radioButton3.Checked == true)
            {
                State.q3 = 'C';
                State.q3c += 1;
            }
        }
    }
}
