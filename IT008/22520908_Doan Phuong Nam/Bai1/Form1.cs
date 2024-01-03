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
    public partial class Form1 : Form
    {
        int count = 5;
        Form3 for3;
        public Form1()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Form2 for2 = new Form2();
            for2.ShowDialog();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            for3 = new Form3();
            for3.ShowDialog();
            count++;
            ListViewItem item = new ListViewItem(count.ToString());
            item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = for3.sach });
            item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = for3.tacgia });
            item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = for3.theloai });
            item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = for3.sl });
            listView1.Items.Add(item);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.N)
            {
                for3 = new Form3();
                for3.ShowDialog();
                count++;
                ListViewItem item = new ListViewItem(count.ToString());
                item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = for3.sach });
                item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = for3.tacgia });
                item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = for3.theloai });
                item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = for3.sl });
                listView1.Items.Add(item);
            }
            
        }

        private void toolStripTextBox1_TextChanged(object sender, EventArgs e)
        {
            string tentim = toolStripTextBox1.Text;
            if (!string.IsNullOrEmpty(tentim))
            {
                if (listView1.Items.Count > 0)
                {
                    foreach (ListViewItem item in listView1.Items)
                    {
                        // So sánh và thiết lập màu nền cho SubItem
                        if (item.SubItems[1].Text.Contains(tentim))
                        {
                            item.SubItems[0].BackColor = Color.SkyBlue;
                        }
                        else
                        {
                            item.SubItems[0].BackColor = Color.White;
                        }
                    }
                }
            }
            else
            {
                foreach (ListViewItem item in listView1.Items)
                {
                    item.BackColor = Color.White;

                }
            }
        }

        private void conHangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach(ListViewItem item in listView1.Items)
            {
                if (int.TryParse(item.SubItems[4].Text,out int res))
                {
                    if (res > 0)
                    {
                        item.SubItems[0].BackColor = Color.SkyBlue;
                    }
                }
            }
        }

        private void hetHangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listView1.Items)
            {
                if (int.TryParse(item.SubItems[4].Text, out int res))
                {
                    if (res == 0)
                    {
                        item.SubItems[0].BackColor = Color.SkyBlue;
                    }
                }
            }
        }
    }
}
