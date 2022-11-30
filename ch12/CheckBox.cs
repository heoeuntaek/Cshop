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
    public partial class 체크박스연습 : Form
    {
        public 체크박스연습()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void chkStr1_CheckedChanged(object sender, EventArgs e)
        {
            lbSample.Text = "";
            Str_Mark();
        }

        private void chkStr2_CheckedChanged(object sender, EventArgs e)
        {
            lbSample.Text = "";
            Str_Mark();
        }

        private void chkStr3_CheckedChanged(object sender, EventArgs e)
        {
            lbSample.Text = "";
            Str_Mark();
        }

        public void Str_Mark()
        {
            //CheckState 초기값은 Uncecked 임
            //체크하면 += 계속해서 누적 시킴

            if (chkStr1.CheckState == CheckState.Checked)
            {
                lbSample.Text += chkStr1.Text + ",";
            }
            
            if (chkStr2.CheckState == CheckState.Checked)
            {
                lbSample.Text += chkStr2.Text + ",";
            }

            if (chkStr3.CheckState == CheckState.Checked)
            {
                lbSample.Text += chkStr3.Text + ",";
            }
        }
    }
}
