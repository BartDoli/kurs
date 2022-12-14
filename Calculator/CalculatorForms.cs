using Calculator.Services;
using Calculator.Services.Interfaces;
using System.Text;

namespace Calculator
{
    public partial class CalculatorForms : Form
    {
        private StringBuilder ExpressionBuilder { get; set; }
        private IExpressionService ExpressionService { get; set; }

        public CalculatorForms()
        {
            ExpressionBuilder = new StringBuilder();
            ExpressionService = new ExpressionService();
            ExpressionBuilder.Clear();
            InitializeComponent();
        }

        private void StringBuilderButton_Click(object sender, EventArgs e)
        {
            ExpressionBuilder.Append("Hello ");
            ExpressionBuilder.Append("user ");
            ExpressionBuilder.Append("this ");
            ExpressionBuilder.Append("is ");
            ExpressionBuilder.Append("a ");
            ExpressionBuilder.Append("string builder.");
            ResultTextBox.Text = ExpressionBuilder.ToString();
            ExpressionBuilder.Clear();
        }

        private void ExpressionButton_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            AppendExpression(button.Text);
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            ExpressionBuilder.Clear();
            ResultTextBox.Text = ExpressionBuilder.ToString();
        }

        private void EqualsButton_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            AppendExpression(button.Text);
            var expression = ResultTextBox.Text;
            var result = ExpressionService.ProcessExpression(expression);
            ResultTextBox.Text = result.ToString();
            ExpressionBuilder.Clear();
        }

        private void AppendExpression(string expressionPart)
        {
            ExpressionBuilder.Append(expressionPart);
            ResultTextBox.Text = ExpressionBuilder.ToString();

            var textLenght = TextRenderer.MeasureText(ExpressionBuilder.ToString(), ResultTextBox.Font);
            while (textLenght.Width > ResultTextBox.Width)
            {
                ResultTextBox.Font = new Font(ResultTextBox.Font.FontFamily, ResultTextBox.Font.Size - 1f);
                textLenght = TextRenderer.MeasureText(ExpressionBuilder.ToString(), ResultTextBox.Font);
            }
        }
    }
}
