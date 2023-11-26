using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Bai5
{
    public partial class Form2 : Form
    {
        

        
        String mssv = "";
        String NAME = "";
        
        String KHOA = "";
        String DIEM = "";

        public string ms
        {
            get
            {
                return mssv;

            }
        }
        public string ten
        {
            get
            {
                return NAME;

            }
        }
        public string khoa
        {
            get
            {
                return KHOA;

            }
        }
        public string diemtb
        {
            get
            {
                return DIEM;

            }
        }
        public Form2()
        {
            InitializeComponent();
            comboBox1.SelectedItem = "Công nghệ phần mềm";
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(MSSV.Text)
                || String.IsNullOrEmpty(textBox1.Text)
                || String.IsNullOrEmpty(comboBox1.SelectedItem.ToString())
                || String.IsNullOrEmpty(DiemTB.Text))
            {
                return;
            }

            mssv = MSSV.Text;
            NAME = textBox1.Text;
            KHOA = comboBox1.SelectedItem.ToString();
            DIEM = DiemTB.Text;



        }
    }
}
