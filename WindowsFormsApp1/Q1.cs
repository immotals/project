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
    public partial class Q1 : Form
    {
        public State State;
        public Q1(ref State state)
        {
            this.State = state;
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var f1 = (Main)(this.Tag);
            f1.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            R1 f2 = new R1(ref State);
            f2.Tag = this;
            f2.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void richTextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Q1_Load(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if(radioButton1.Checked == true)
            {
                State.q1 = 'A';
                State.q1a += 1;
            } 
            else if(radioButton2.Checked == true)
            {
                State.q1 = 'B';
                State.q1b += 1;
            }
        }
    }
}
