using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai1
{
    public partial class Form3 : Form
    {
        public string sach { get; set; }
        public string tacgia { get; set; }
        public string theloai { get; set; }
        public string sl { get; set; }
        public Form3()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(textBox1.Text) && !string.IsNullOrEmpty(textBox2.Text) &&!string.IsNullOrEmpty(textBox3.Text) && numericUpDown1.Value >= 0)
            {
                sach = textBox1.Text;
                tacgia = textBox2.Text;
                theloai = textBox3.Text;
                sl = numericUpDown1.Value.ToString();
            }
            this.Close();

        }
    }
}
