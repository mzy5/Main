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

            Validate validator = new Validate();
            var min = validator.GetMin(firstNo, secondNo, thirdNo);

            MessageBox.Show("Minimul este: " + min);
        }

        private void btnCheckMax_Click(object sender, EventArgs e)
        {
            var firstNo = Convert.ToDouble(txtNo1.Text);
            var secondNo = Convert.ToDouble(txtNo2.Text);
            var thirdNo = Convert.ToDouble(txtNo3.Text);

            Validate validator = new Validate();
            var max = validator.GetMax(firstNo, secondNo, thirdNo);

            MessageBox.Show("Maximul este: " + max);

        }
    }
}
