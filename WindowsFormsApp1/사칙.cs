
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Operation;

namespace WindowsFormsApp1
{
    public partial class 사칙 : Form
    {
        
        public 사칙()
        {
            InitializeComponent();
        }
        
        
        

        private void button3_Click(object sender, EventArgs e)
        {
            double A = Convert.ToSingle(txtA.Text);
            double B = Convert.ToSingle(txtB.Text);
            double txtRe = OperationDLL.Multiply(A, B);
            

            txtResult.Text = Convert.ToString(txtRe);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtA_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double A = Convert.ToDouble(txtA.Text);
            double B = Convert.ToDouble(txtB.Text);
            double txtRe = OperationDLL.Plus(A, B);

            txtResult.Text = Convert.ToString(txtRe);
          


        }

        private void button2_Click(object sender, EventArgs e)
        {
            double A = Convert.ToSingle(txtA.Text);
            double B = Convert.ToSingle(txtB.Text);
            double txtRe = OperationDLL.Minus(A, B);
           

            txtResult.Text = Convert.ToString(txtRe);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double A = Convert.ToSingle(txtA.Text);
            double B = Convert.ToSingle(txtB.Text);
            double txtRe = OperationDLL.Divide(A, B);

            txtResult.Text = Convert.ToString(txtRe);
        }

        private void 사칙연산_Load(object sender, EventArgs e)
        {

        }
    }
}
