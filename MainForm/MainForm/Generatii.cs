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
    public partial class Generatii : Form
    {
        public Generatii()
        {
            InitializeComponent();
        }

        private void btnDetermineGeneration_Click(object sender, EventArgs e)
        {
            Double valFromAge;
            bool conversionIsSuccessful;

            conversionIsSuccessful = Double.TryParse(txtAge.Text, out valFromAge);

            if (conversionIsSuccessful == true)
            {
                if (((2021 - valFromAge) >= 1883) && ((2021 - valFromAge) <= 1900))
                {
                    MessageBox.Show("Lost Generation");
                } else if (((2021 - valFromAge) >= 1901) && ((2021 - valFromAge) <= 1927))
                {
                    MessageBox.Show("Greatest Generation");
                } else if (((2021 - valFromAge) >= 1928) && ((2021 - valFromAge) <= 1945))
                {
                    MessageBox.Show("Silent Generation");
                } else if (((2021 - valFromAge) >= 1946) && ((2021 - valFromAge) <= 1964))
                {
                    MessageBox.Show("Baby Boomers");
                } else if (((2021 - valFromAge) >= 1965) && ((2021 - valFromAge) <= 1980))
                {
                    MessageBox.Show("Generation X");
                } else if (((2021 - valFromAge) >= 1981) && ((2021 - valFromAge) <= 1996))
                {
                    MessageBox.Show("Millenials");
                } else if (((2021 - valFromAge) >= 1997) && ((2021 - valFromAge) <= 2010))
                {
                    MessageBox.Show("Generation Z");
                } else if (((2021 - valFromAge) >= 2010) && ((2021 - valFromAge) <= 2020))
                {
                    MessageBox.Show("Generation Alpha");
                }
            }
        }
    }
}
