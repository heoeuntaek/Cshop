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
    public partial class 로그인 : Form
    {
        public 로그인()
        {
            InitializeComponent();
        }

        private void 로그인_Load(object sender, EventArgs e)
        {

        }

        private void btnGuest_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (checkData() == true)
            {
                IbResult.Text = "로그인 성공";
                //btnSearch.Enabled = true;
                //btnAut.Enabled = true;

                btnSearch.Visible = true;

                btnAut.Visible = true;


            }
        }

        private bool checkData()
        {
            //아디 입력 안하면
            if (txtId.Text == "")
            {
                MessageBox.Show("ID를 입력하세요", "알림", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                // 커서 이동 
                txtId.Focus();
                return false;

            }
            else if (txtPass.Text == "")
            {
                // 패스 입력 안하면
                // 커서 이동 
                MessageBox.Show("PASS를 입력하세요", "알림", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPass.Focus();
                return false;
            }


            else
            {
                // 아디와 패스 일치하고 
                if (txtId.Text == "text")
                {
                    if (txtPass.Text == "1234")
                    {
                        return true;
                    }
                    else
                    {  // 패스 일치 안 하면
                        lbResult.Text = "비번 틀림";
                        txtPass.Focus();
                        return false;
                    }
                }
                else
                {
                    lbResult.Text = "아뒤 틀림";
                    txtId.Focus();
                    return false;
                }


                // 커서 이동 

            }




        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }
    }
}