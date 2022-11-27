using Calculator.Services.Interfaces;
using System.Text;

namespace Calculator
{
    public partial class CalculatorForms : Form
    {
        public StringBuilder ExpressionBuilder { get; set; }
        public IExpressionService ExpressionService { get; set; }

        public CalculatorForms()
        {
            ExpressionBuilder = new StringBuilder();
            InitializeComponent();
        }

        private void StringBuilderDemoButton_Click(object sender, EventArgs e)
        {
            ExpressionBuilder.Append("Hello ");
            ExpressionBuilder.Append("user ");
            ExpressionBuilder.Append("this ");
            ExpressionBuilder.Append("is ");
            ExpressionBuilder.Append("a ");
            ExpressionBuilder.Append("string builder. ");
            ResultTextBox.Text = ExpressionBuilder.ToString();
            ExpressionBuilder.Clear();
        }

        private void KeyButton_Click(object sender, EventArgs e)
        {
            
            Button button = (Button)sender;

            ExpressionBuilder.Append(button.Text);
            if (ResultTextBox.Text == "0")
            {
                ResultTextBox.Text = "";
                ResultTextBox.Text += button.Text;
            }
            else
            {
                ResultTextBox.Text += button.Text;
            }
            
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            ExpressionBuilder.Clear();
            ResultTextBox.Text = ExpressionBuilder.ToString();
        }

        private void EqualsButton_Click(object sender, EventArgs e)
        {
            var expression = ResultTextBox.Text;
            var result = ExpressionService.ProcessExpression(expression);
            ResultTextBox.Text = result.ToString();
            ExpressionBuilder.Clear();
        }

        private void AppendExpression(string expressionPart)
        {
            ExpressionBuilder.Append(expressionPart);
            ResultTextBox.Text = ExpressionBuilder.ToString();
        }
    }
}