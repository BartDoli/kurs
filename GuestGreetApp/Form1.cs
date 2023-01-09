using System;
using System.Windows.Forms;
using System.Xml.Linq;

namespace GuestGreetApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGreet_Click_1(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string gender = cboGender.Text;
            string greeting;

            if (gender == "Kobieta")
            {
                greeting = "Dzieñ dobry Pani ";
            }
            else if (gender == "Mê¿czyzna")
            {
                greeting = "Dzieñ dobry Panie";
            }
            else
            {
                greeting = "Dzieñ dobry";
            }

            if (name.EndsWith("ek"))
            {
                greeting += " " + name.Replace("ek", "ku");
            }
            else if (name.EndsWith("ik"))
            {
                greeting += " " + name.Replace("ik", "iku");
            }
            else if (name.EndsWith("il"))
            {
                greeting += " " + name.Replace("il", "ilu");
            }
            else if (name.EndsWith("nek"))
            {
                greeting += " " + name.Replace("nek", "nku");
            }
            else if (name.EndsWith("er"))
            {
                greeting += " " + name.Replace("er", "rze");
            }
            else if (name.EndsWith("sz"))
            {
                greeting += " " + name.Replace("sz", "szu");
            }
            else 
            {
                greeting += " " + name.Replace("a", "o");
            }
            MessageBox.Show(greeting);
        }
    }
}
