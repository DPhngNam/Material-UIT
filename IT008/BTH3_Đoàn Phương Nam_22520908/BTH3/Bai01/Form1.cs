
namespace Bai01
{
    public partial class Form1 : Form
    {
        private Random ran = new Random();
        public Form1()
        {
            InitializeComponent();
        }
        private Color SetRandomBackgroundColor()
        {
            // Generate random values for the red, green, and blue components
            int r = ran.Next(256);
            int g = ran.Next(256);
            int b = ran.Next(256);

            // Create a random color using the RGB components
            Color randomColor = Color.FromArgb(r, g, b);

            // Set the background color of the control (e.g., a panel)
            return randomColor;
        }
        private void button1_Click(object sender, EventArgs e)
        {

            this.BackColor = SetRandomBackgroundColor();
        }
    }
}