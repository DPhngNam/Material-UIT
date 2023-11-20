namespace Bai05
{

    public partial class form1 : Form
    {
        class NgDung
        {
            public int Id { get; set; }
            public string MTK { get; set; }
            public string Ten { get; set; }
            public string Diachi { get; set; }
            public int tien { get; set; }

            public NgDung create(int Id, string MTK, string Ten, string Diachi, int tien)
            {
                NgDung temp = new NgDung();
                temp.Id = Id;
                temp.MTK = MTK;
                temp.Ten = Ten;
                temp.Diachi = Diachi;
                temp.tien = tien;    
                return temp;
            }
        }
        int count = 0;
        List<NgDung> sys = new List<NgDung>();
        public form1()
        {
            InitializeComponent();
            dataGridView1.DataSource = sys;

            // Set column bindings
            dataGridView1.Columns["ID"].HeaderText = "STT";
            dataGridView1.Columns["MTK"].HeaderText = "MTK";
            dataGridView1.Columns["Ten"].HeaderText = "Ten";
            dataGridView1.Columns["Diachi"].HeaderText = "Dia chi";
            dataGridView1.Columns["Tien"].HeaderText = "Tien";
            AlwaysOnDisplay();
        }

        private void AlwaysOnDisplay()
        {
            textBox5.Text = count.ToString();
            textBox5.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool exists = sys.Any(ngDung => ngDung.MTK == textBox1.Text);

            if (exists)
            {
                for (int i = 1; i < sys.Count; i++)
                {
                    if (sys[i].MTK == textBox1.Text)
                    {
                        sys[i].Ten = textBox2.Text;
                        sys[i].Diachi = textBox3.Text;
                        sys[i].tien = int.Parse(textBox4.Text);
                        break;
                    }
                }
            }
            else
            {
                NgDung a = new NgDung();
                a.create(sys.Count + 1, textBox1.Text, textBox2.Text, textBox3.Text, int.Parse(textBox4.Text));
                sys.Add(a);
            }
            foreach (NgDung a in sys)
            {
                count += a.tien;
            }
            AlwaysOnDisplay();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            // Get the MTK value from textBox1
            string mtkToRemove = textBox1.Text;

            // Find the index of the NgDung object to remove based on MTK
            int indexToRemove = sys.FindIndex(ngDung => ngDung.MTK == mtkToRemove);

            if (indexToRemove != -1)
            {
                // Remove the NgDung object from the list
                sys.RemoveAt(indexToRemove);


                for (int i = 0; i < sys.Count; i++)
                {
                    sys[i].Id = i + 1;
                }


                count = sys.Sum(ngDung => ngDung.tien);


            }

            // Update the display
            AlwaysOnDisplay();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {

        }
    }
}