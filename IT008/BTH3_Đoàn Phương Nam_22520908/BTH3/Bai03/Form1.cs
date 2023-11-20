using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Bai03
{
    public partial class Form1 : Form
    {
        private int operand1, operand2;
        private string operation;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            operand1 = Convert.ToInt32(textBox1.Text);
        }

        private void label2_Click(object sender, EventArgs e)
        {

            


        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            operand2 = Convert.ToInt32(textBox2.Text);
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            operation = comboBox1.Text;
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            int result = 0;
            switch (operation)
            {
                case "+":
                    result = operand1 + operand2;
                    break;
                case "-":
                    result = operand1 - operand2;
                    break;
                case "*":
                    result = operand1 * operand2;
                    break;
                case "/":
                    if (operand2 != 0)
                    {
                        result = operand1 / operand2;
                    }
                    else
                    {
                        MessageBox.Show("Division by zero is not allowed.");
                    }
                    break;
            }
            textBox3.Text = result.ToString();
            textBox3.Show();
        }

        
    }
}
