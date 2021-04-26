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
    public partial class ComboBoxForm : Form
    {
        public ComboBoxForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var no1 = Convert.ToDouble(textBox1.Text);
            var no2 = Convert.ToDouble(textBox2.Text);
            switch (comboBox1.Text)
            {
                case "plus":
                    var suma = no1 + no2;
                    MessageBox.Show("Suma: " + suma);
                    break;
                case "minus":
                    var diferenta = no1 - no2;
                    MessageBox.Show("Diferenta: " + diferenta);
                    break;
                case "impartit":
                    var impartire = no1 / no2;
                    MessageBox.Show("Impartire: " + impartire);
                    break;
                default:
                    break;
            }
        }
    }
}
