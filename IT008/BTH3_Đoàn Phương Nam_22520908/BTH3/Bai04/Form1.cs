using System.Numerics;
using System.Linq;
namespace Bai04
{
    public partial class Form1 : Form
    {
        List<Button> danhsachchon = new List<Button>();
        int data = 0;
        public Form1()
        {
            InitializeComponent();
            textBox1.Enabled = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        public void OnClick(object sender)
        {
            Button btn = (Button)sender;
            if (btn.BackColor != Color.Yellow)
            {
                if (btn.BackColor == Color.White)
                {
                    btn.BackColor = Color.Blue;
                    danhsachchon.Add(btn);
                }
                else
                {
                    btn.BackColor = Color.White;
                    danhsachchon.Remove(btn);
                }
            }
            else
            {
                MessageBox.Show("Co nguoi dat cho roi");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            OnClick(sender);


        }
        private void button2_Click(object sender, EventArgs e)
        {
            OnClick(sender);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            OnClick(sender);
        }
        private void button4_Click(object sender, EventArgs e)
        {
            OnClick(sender);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button18_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            OnClick(sender);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            OnClick(sender);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            OnClick(sender);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            OnClick(sender);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            OnClick(sender);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            OnClick(sender);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            OnClick(sender);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            OnClick(sender);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            OnClick(sender);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            OnClick(sender);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            OnClick(sender);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            foreach (Button btn in danhsachchon)
            {
                int a = int.Parse(btn.Text);
                if (a <= 5)
                {
                    data += 5000;
                }
                else if (a > 5 && a <= 10)
                {
                    data += 6500;
                }
                else
                {
                    data += 8000;
                }
                btn.BackColor = Color.Yellow;
            }
            textBox1.Text = data.ToString();
            data = 0;
            danhsachchon = new List<Button>();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            foreach (Button btn in danhsachchon)
            {
                btn.BackColor = Color.White;
            }
            textBox1.Text = "";

            danhsachchon = new List<Button>();
        }
    }
}