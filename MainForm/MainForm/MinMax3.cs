using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainForm
{
    public partial class MinMax3 : Form
    {
        public MinMax3()
        {
            InitializeComponent();
        }

        private void btnCheckMin_Click(object sender, EventArgs e)
        {
            var firstNo = Convert.ToDouble(txtNo1.Text);
            var secondNo = Convert.ToDouble(txtNo2.Text);
            var thirdNo = Convert.ToDouble(txtNo3.Text);

            ValidateMin validator = new ValidateMin();
            var min = validator.GetMin(firstNo, secondNo, thirdNo);

            MessageBox.Show("Minimul este: " + min);
        }

        private void btnCheckMax_Click(object sender, EventArgs e)
        {
            var firstNo = Convert.ToDouble(txtNo1.Text);
            var secondNo = Convert.ToDouble(txtNo2.Text);
            var thirdNo = Convert.ToDouble(txtNo3.Text);


            if (firstNo > secondNo && firstNo > thirdNo)
            {
                MessageBox.Show("The max is: " + firstNo);
            }
            else if (secondNo > firstNo && secondNo > thirdNo)
            {
                MessageBox.Show("The max is: " + secondNo);
            }
            else if (thirdNo > firstNo && thirdNo > secondNo)
            {
                MessageBox.Show("The max is: " + thirdNo);
            }
            else if (firstNo == secondNo && secondNo == thirdNo)
            {
                MessageBox.Show("The three numbers are equal, no max for you!");
            }
            else if (firstNo == secondNo && firstNo > thirdNo)
            {
                MessageBox.Show("The max is: " + firstNo);
            }
            else if (firstNo == thirdNo && firstNo > secondNo)
            {
                MessageBox.Show("The max is: " + firstNo);
            }
            else if (secondNo == firstNo && secondNo > thirdNo)
            {
                MessageBox.Show("The max is: " + secondNo);
            }
            else if (secondNo == thirdNo && secondNo > firstNo)
            {
                MessageBox.Show("The max is: " + secondNo);
            }
            else if (thirdNo == firstNo && thirdNo > secondNo)
            {
                MessageBox.Show("The max is: " + thirdNo);
            }
            else if (thirdNo == secondNo && thirdNo > firstNo)
            {
                MessageBox.Show("The max is: " + thirdNo);
            }
            else if (firstNo < secondNo && firstNo > thirdNo)
            {
                MessageBox.Show("The max is: " + secondNo);
            }
            else if (firstNo < thirdNo && firstNo > secondNo)
            {
                MessageBox.Show("The max is: " + thirdNo);
            }
            else if (secondNo < firstNo && secondNo > thirdNo)
            {
                MessageBox.Show("The max is: " + firstNo);
            }
            else if (secondNo < thirdNo && secondNo > firstNo)
            {
                MessageBox.Show("The max is: " + thirdNo);
            }
            else if (thirdNo < firstNo && thirdNo > secondNo)
            {
                MessageBox.Show("The max is: " + firstNo);
            }
            else if (thirdNo < secondNo && thirdNo > firstNo)
            {
                MessageBox.Show("The max is: " + secondNo);
            }
        }
    }
}
