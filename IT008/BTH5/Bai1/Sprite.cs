using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    
    public class Sprite
    {
        Bitmap[] ListSprites { get; set; }
        int iSprites { get; set; }
        int nSprites { get; set; }
        int Width { get; set; }
        int Height { get; set; }
        int X { get; set; }
        int Y { get; set; }

        public Sprite(Bitmap[] listsprites, int x, int y)
        {
            ListSprites = listsprites;
            X = x;
            Y = y;
        }

        public void DrawSprite(Graphics e)
        {
            e.DrawImage(ListSprites[iSprites], X, Y);
        }

        public void Update()
        {
            iSprites = (iSprites + 1) % ListSprites.Length;
        }
    }
}

