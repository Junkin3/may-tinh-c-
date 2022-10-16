using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Caculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double c = (int.Parse(txtA.Text) + int.Parse(txtB.Text));


            txtResult.Text = c.ToString();
        }

        private void bttru_Click(object sender, EventArgs e)
        {
            double c = (int.Parse(txtA.Text) - int.Parse(txtB.Text));


            txtResult.Text = c.ToString();
        }

        private void btNhan_Click(object sender, EventArgs e)
        {
            double c = (int.Parse(txtA.Text) * int.Parse(txtB.Text));


            txtResult.Text = c.ToString();
        }

        private void btchia_Click(object sender, EventArgs e)
        {
            try
            {
                double c = (int.Parse(txtA.Text) / int.Parse(txtB.Text));


                txtResult.Text = c.ToString();
            }
            catch (DivideByZeroException)
            {
                MessageBox.Show("Vui lòng nhập lại số b (không thể chia hết cho 0)");
            }
        }
    }
}
