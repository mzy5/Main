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
    public partial class TestEnumForm : Form
    {
        public TestEnumForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            Person myPerson = new Person();
            myPerson.Name = "Mady";
            myPerson.Gender = 0;
            

            if((Gender)myPerson.Gender ==  Gender.Feminin)
            {

            }

        }
    }

    class Person
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public int Gender { get; set; }
    }


    enum Gender
    {
        Feminin,
        Masculin
    }

}
