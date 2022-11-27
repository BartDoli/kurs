namespace HardcodedFormApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            HardcodedButton = new Button();
            HardcodedButton.Parent = this;
            HardcodedButton.Top = 150;
            HardcodedButton.Left = 150;
            HardcodedButton.Text = "Hardcoded button...";
            HardcodedButton.Width = 500;
            HardcodedButton.Click += new System.EventHandler(ExtendButton);
            HardcodedButton.Click += new System.EventHandler(SayHello);
        }

        private void SayHello(object sender, EventArgs args)
        {
            for (int i = 0; i < 10; i++)
            {
                MessageBox.Show("Hello!");
            }
            
        }

        private void ExtendButton(object sender, EventArgs args)
        {
            HardcodedButton.Width += 10;
        }
    }
}