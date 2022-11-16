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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        //sender - 어디로 보내줄건지?
        // e- 버튼 클릭했을 때 정보
        private void btnOutput_Click(object sender, EventArgs e)
        {
            txtResult.Text = txtName.Text;

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void txtResult_TextChanged(object sender, EventArgs e)
        {
            //버튼 클릭시
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtResult.Text = "";
                txtName.Text  ="";
        }
    }
}
