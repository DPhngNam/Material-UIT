namespace Bai1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string xx, yy;
        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            xx = e.X.ToString();
            yy = e.Y.ToString();

            MessageBox.Show($"Nut chuot vua duoc nhan ( {xx},{yy} )");
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            MessageBox.Show($"Nut chuot vua duoc nhan ( {e.KeyChar},{e.KeyChar - '0'} )");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}