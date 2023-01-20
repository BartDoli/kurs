using System;

namespace LottoApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int num = random.Next(100000, 999999);
            string numString = num.ToString().PadLeft(6, '0');

            string userInput = textBox1.Text;
            string[] numStringList = numString.Split(" , ");

            WinningNumbersBox.Text = num.ToString();
            if (userInput.Count() < 6)
            {
                MessageBox.Show("Invalid Input");
            }
            else if (numString.Count() > 6)
            {
                MessageBox.Show("Invalid Input");
            }
            else
            {
                foreach (string numStr in numStringList)
                {
                    if (numStr == userInput)
                    {
                        MessageBox.Show("The numbers match!");
                    }
                    else
                    {
                        MessageBox.Show("The numbers do not match.");
                    }
                    
                }
            }
        }
    }
}