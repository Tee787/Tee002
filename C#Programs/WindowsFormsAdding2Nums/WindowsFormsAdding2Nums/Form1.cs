using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAdding2Nums
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int Num1 = int.Parse(txtNum1.Text);
            int Num2 = int.Parse(txtNum2.Text);

            int Answer = Num1 + Num2;

            txtResult.Text = Answer.ToString();
        }

        private void txtNum1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtResult_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }

