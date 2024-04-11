using System;
using System.Text;
using System.Windows.Forms;

namespace BasicOperations
{
    public partial class Form1 : Form
    {
        private int n1, n2;
        private int sum, subtract, mul;
        private double div; // Changed to double to support fractional division results

        public Form1()
        {
            InitializeComponent();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            GetNumbers();
            sum = n1 + n2;
            DisplayResult(sum);
        }

        private void sub_Click(object sender, EventArgs e)
        {
            GetNumbers();
            subtract = n1 - n2;
            DisplayResult(subtract);
        }

        private void multiplication_Click(object sender, EventArgs e)
        {
            GetNumbers();
            mul = n1 * n2;
            DisplayResult(mul);
        }

        private void divition_Click(object sender, EventArgs e)
        {
            GetNumbers();
            if (n2 != 0) // Check for division by zero
            {
                div = (double)n1 / n2; // Cast to double to ensure fractional result is preserved
                DisplayResult(div);
            }
            else
            {
                MessageBox.Show("Cannot divide by zero!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GetNumbers()
        {
            n1 = ConvertToInt(box1.Text);
            n2 = ConvertToInt(box2.Text);
        }

        private int ConvertToInt(string input)
        {
            int result;
            if (!int.TryParse(input, out result))
            {
                MessageBox.Show("Please enter valid numbers!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0; // Explicitly return 0 after showing the error message
            }
            return result;
        }

        private void DisplayResult(double result) // Changed to accept double to handle division results
        {
            answer.Text = result.ToString();
        }

        private void clear_Click(object sender, EventArgs e)
        {
            box1.Clear();
            box2.Clear();
            answer.Clear();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close(); // Closes the form
        }

          private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

