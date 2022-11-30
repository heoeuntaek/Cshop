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
    public partial class 주민과제 : Form
    {
        public 주민과제()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnOk_Click(object sender, EventArgs e)
        {

            if (txtJuminOne.Text.Length != 6 && txtJuminTwo.Text.Length != 7)
            {
                MessageBox.Show("주민번호 자릿수 틀림", "", MessageBoxButtons.OK);

            }
            else
            {
                int jumin = Convert.ToInt32(txtJuminOne.Text);
                int jumin2 = Convert.ToInt32(txtJuminTwo.Text);



                int year = JuminDLL.JuminDLL.Calculator.CalYear(jumin);
                int month = JuminDLL.JuminDLL.Calculator.CalMonth(jumin);
                int day = JuminDLL.JuminDLL.Calculator.CalDay(jumin);
                string sex = JuminDLL.JuminDLL.Calculator.CalSex(jumin2);
                int age = JuminDLL.JuminDLL.Calculator.CalAge(jumin);

                if (sex == "오류")
                {
                    MessageBox.Show("성별 오류");
                }
                else
                {
                    txtYear.Text = Convert.ToString(year);
                    txtMonth.Text = Convert.ToString(month);
                    txtDay.Text = Convert.ToString(day);
                    txtSex.Text = sex;
                    txtAge.Text = Convert.ToString(age);
                }

            }
                



        }

        private void txtJuminOne_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                MessageBox.Show( "숫자만 입력하세요", "경고", MessageBoxButtons.OK);
            }
            if (txtJuminOne.Text.Length == 5)
            {
                txtJuminTwo.Focus();
            }


        }

        private void txtJuminTwo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                MessageBox.Show("숫자만 입력하세요", "경고", MessageBoxButtons.OK);
                e.Handled = true;

            }
        }

        private void txtJuminOne_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
