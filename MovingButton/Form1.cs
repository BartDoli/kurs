namespace MovingButton
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void RandomButton_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            var randomTop = rnd.NextInt64(1 , 560);
            var randomLeft = rnd.NextInt64(1 , 924);
            RandomButton.Top = (int)randomTop;
            RandomButton.Left = (int)randomLeft;
        }
    }
}