namespace Bai02
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }
        

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = colorDialog1.Color;
        }
    }
}