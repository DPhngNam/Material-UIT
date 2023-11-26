using System.Diagnostics;
using System.Security.Policy;

namespace Bai5
{
    public partial class f1 : Form
    {
        int Stt;
        public f1()
        {
            InitializeComponent();
            Stt = 1;
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        


        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            
             form2.ShowDialog();
            
             ListViewItem newItem = new ListViewItem(Stt.ToString());


                newItem.SubItems.Add(form2.ms);
                newItem.SubItems.Add(form2.ten);
                newItem.SubItems.Add(form2.khoa);
                newItem.SubItems.Add(form2.diemtb);
                listView1.Items.Add(newItem);

                MessageBox.Show("Them moi du lieu thanh cong!", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);


                ++Stt;
            
            
            
        }

        private void toolStripButton2_Click_1(object sender, EventArgs e)
        {
            string search = toolStripButton3.Text.ToLower(); // Convert search text to lowercase

            foreach (ListViewItem item in listView1.Items)
            {
                bool containsText = false;

                foreach (ListViewItem.ListViewSubItem subItem in item.SubItems)
                {
                    if (subItem.Text.ToLower().Contains(search))
                    {
                        containsText = true;
                        break;
                    }
                }

                if (containsText)
                {

                    item.Selected = true;
                    item.Focused = true; 

                   
                    item.EnsureVisible();

                    
                    listView1.Focus();

                }
                
            }
        }

    }
}
