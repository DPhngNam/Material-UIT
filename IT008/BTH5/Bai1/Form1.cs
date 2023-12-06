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
        public Form1()
        {
            InitializeComponent();
        }
        private List<Sprite> listSprites;
        private void Form1_Load(object sender, EventArgs e)
        {
            listSprites = new List<Sprite>();
            Bitmap[] bitmap = new Bitmap[8];
            bitmap[0] = Properties.Resources.frame_1;
            bitmap[1] = Properties.Resources.frame_2;
            bitmap[2] = Properties.Resources.frame_3;
            bitmap[3] = Properties.Resources.frame_4;
            bitmap[4] = Properties.Resources.frame_5;
            bitmap[5] = Properties.Resources.frame_6;
            bitmap[6] = Properties.Resources.frame_7;
            bitmap[7] = Properties.Resources.frame_8;

            listSprites.Add(new Sprite(bitmap, 50, 50));
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            for (int i = 0; i < listSprites.Count; i++)
            {
                listSprites[i].DrawSprite(graphics);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < listSprites.Count; i++)
            {
                listSprites[i].Update();
            }
            this.Refresh();
        }
    }
}
    