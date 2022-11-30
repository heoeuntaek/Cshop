using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ch12
{
    public partial class ArrayRadio : Form
    {
        public ArrayRadio()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            int score = 0;
            if (RB1_2.Checked == true)
            {
                score++;
            }

            if (RB2_3.Checked == true)
            {
                score++;
            }
            lbScore.Text = score.ToString();

            if (RB3_3.Checked == true)
            {
                score++;
            }
            lbScore.Text = score.ToString();

            

        }

        private void RB1_1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RB2_4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void ArrayRadio_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
