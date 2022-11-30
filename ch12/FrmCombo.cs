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
    public partial class FrmCombo : Form
    {
        public FrmCombo()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //string words = comboBox1.Text;
            //txtYear.Text = words;
            ////선태과 동시 출력
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string words = comboBox1.Text;
            txtYear.Text = words;
            ////눌러야 동시 출력
        }
    }
}
