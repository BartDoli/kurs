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
                greeting = "Dzieñ dobry Pani " + name;
            }
            else if (gender == "Mê¿czyzna")
            {
                greeting = "Dzieñ dobry Pan";
            }
            else
            {
                greeting = "Dzieñ dobry";
            }

            // Zmiana ostatniej litery imienia na odpowiedni¹ formê gramatyczn¹
            if (name.EndsWith("ek"))
            {
                greeting += "ie " + name.Replace("ek", "ku");
            }
            else if (name.EndsWith("ik"))
            {
                greeting += "ie " + name.Replace("ik", "iku");
            }
            else if (name.EndsWith("il"))
            {
                greeting += "ie " + name.Replace("il", "ilu");
            }
            else if (name.EndsWith("nek"))
            {
                greeting += "ie " + name.Replace("nek", "nku");
            }
            else if (name.EndsWith("nka"))
            {
                greeting = greeting.Insert(greeting.Length - 2, "o");
            }
            MessageBox.Show(greeting);
        }
    }
}
