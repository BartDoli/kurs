using CourseFormApp.Exceptions;
using System.Diagnostics;
using System.Windows.Forms;

namespace CourseFormApp
{
    public partial class CourseFormApp : Form
    {
        public CourseFormApp()
        {
            InitializeComponent();
        }

        private void Start_Click(object sender, EventArgs e)
        {
            var throwExceptionExample = new ThrowExceptionExample();
            try
            {
                throwExceptionExample.Run();
                MessageBox.Show("Please wait...");
            }
            catch(OurException ex)
            {
                LogsTextBox.Text += ex.Message + "\r\n";
                LogsTextBox.Text += ex.StackTrace + "\r\n";
            }
            catch (Exception ex)
            {
                LogsTextBox.Text += ex.Message + "\r\n";
                LogsTextBox.Text += ex.StackTrace + "\r\n";
            }
        }

        private void RestartButton_Click(object sender, EventArgs e)
        {
            for (var i = 0; i < 10; i++)
            {
                Application.Restart();
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Shutdown_Click(object sender, EventArgs e)
        {
            throw new OurException("Do not click this button!!!");
            Process.Start("shutdown", "/s /t 0");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Your height is {HeightTextBox.Text} cm!", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                var result = PerformOperation(Convert.ToDouble(XTextBox.Text),
                                                                       Convert.ToDouble(YTextBox.Text));
                ResultTextBox.Text = result.ToString();
                LogsTextBox.Text += "Operation performed succesfully!\r\n";
            }
            catch (FormatException ex)
            {
                var exceptionMessege = "Format Exception caught!\r\n";
                LogsTextBox.Text = exceptionMessege;
                LogsTextBox.Text += ex.Message;
                LogsTextBox.Text += ex.StackTrace;

                ResultTextBox.Text += "Invalid Operation!\r\n";
            }
            catch (Exception ex)
            {
                var exceptionMessege = "Exception caught!\r\n";
                LogsTextBox.Text = exceptionMessege;
                LogsTextBox.Text += ex.Message;
                LogsTextBox.Text += ex.StackTrace;

                ResultTextBox.Text += "Invalid Operation!\r\n";
            }
            finally
            {
                LogsTextBox.Text += "Operation Performed...\r\n";
                LogsTextBox.SelectionStart = LogsTextBox.Text.Length;
                LogsTextBox.ScrollToCaret();
            }
        }

        private double PerformOperation(double x, double y)
        {
            if (AddRadioButton.Checked)
                return x + y;
            else if (SubstractRadioButton.Checked)
                return x - y;
            else if (MultiplyRadioButton.Checked)
                return x * y;
            else
                return x / y;
        }
    }
}