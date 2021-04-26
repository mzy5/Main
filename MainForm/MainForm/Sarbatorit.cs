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
    public partial class Sarbatorit : Form
    {
        public Sarbatorit()
        {
            InitializeComponent();
        }

        private void btnCheckBirthday_Click(object sender, EventArgs e)
        {

            var currentDate = DateTime.Now.Date;
            var birthDate = dateTimePicker1.Value.Date;

            if (birthDate == currentDate)
            {
                MessageBox.Show("Happy Birthday!");
            }
            else
            {
                MessageBox.Show("Not old yet!");
            }
        }
    }
}
