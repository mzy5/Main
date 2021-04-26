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
            var birthYear = DateTime.Now.Year - valFromAge;


            if (conversionIsSuccessful == true)
            {
                string generation = string.Empty;

                if (((birthYear) >= 1883) && ((birthYear) <= 1900))
                {
                    generation = "Lost Generation";
                }
                else if (((birthYear) >= 1901) && ((birthYear) <= 1927))
                {
                    generation = "Greatest Generation";
                }
                else if (((birthYear) >= 1928) && ((birthYear) <= 1945))
                {
                    generation = "Silent Generation";
                }
                else if (((birthYear) >= 1946) && ((birthYear) <= 1964))
                {
                    generation = "Baby Boomers";
                }
                else if (((birthYear) >= 1965) && ((birthYear) <= 1980))
                {
                    generation = "Generation X";
                }
                else if (((birthYear) >= 1981) && ((birthYear) <= 1996))
                {
                    generation = "Millenials";
                }
                else if (((birthYear) >= 1997) && ((birthYear) <= 2010))
                {
                    generation = "Generation Z";
                }
                else if (((birthYear) >= 2010) && ((birthYear) <= 2020))
                {
                    generation = "Generation Alpha";
                }
                else generation = "Not found";
                MessageBox.Show(generation);
            }
        }
    }
}
