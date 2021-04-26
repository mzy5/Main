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
    public partial class motherShip : Form
    {
        public motherShip()
        {
            InitializeComponent();
        }

        private void btnParitate_Click(object sender, EventArgs e)
        {
            Paritate paritatePage = new Paritate();
            paritatePage.Show();
        }

        private void btnGeneratii_Click(object sender, EventArgs e)
        {
            Generatii generatiiPage = new Generatii();
            generatiiPage.Show();
        }

        private void btnCombo_Click(object sender, EventArgs e)
        {
            ComboBoxForm comboBoxPage = new ComboBoxForm();
            comboBoxPage.Show();
        }

        private void btnSarbatorit_Click(object sender, EventArgs e)
        {
            Sarbatorit sarbatoritPage = new Sarbatorit();
            sarbatoritPage.Show();
        }

        private void btnMinMax3_Click(object sender, EventArgs e)
        {
            MinMax3 minMaxPage = new MinMax3();
            minMaxPage.Show();
        }
    }
}
