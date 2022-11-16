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
    public partial class 과제1 : Form
    {
        public 과제1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            outputAge.Text = inputAge.Text;
            outputName.Text = inputName.Text;

            finalAge.Text = inputAge.Text;
            finalName.Text = inputName.Text;

            finalName.ForeColor = Color.Red;
            Font fnt = new Font(finalName.Font.Name, 15);
            //this.label1.Font = fnt;
            finalName.Font = fnt;

            finalAge.ForeColor = Color.Blue;

            finalAge.Font = new Font(finalAge.Font, FontStyle.Italic);
            

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void 과제1_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
