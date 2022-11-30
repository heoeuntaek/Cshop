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
    public partial class 시험문제 : Form
    {
        public 시험문제()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            int score = 0;
            if (rb1_1.Checked == true)
            {
                score++;
            }

            if ((chk1.CheckState == CheckState.Checked) && (chk2.CheckState == CheckState.Checked))
            {
                score++;


            }

            
            if (rb3_4.Checked == true)
            {
                score++;
            }
            if (rb4_2.Checked == true)
            {
                score++;
            }
            if (rb5_4.Checked == true)
            {
                score++;
            }

            lbScore.Text = score.ToString();

        }

        private void 시험문제_Load(object sender, EventArgs e)
        {

        }
    }
}
