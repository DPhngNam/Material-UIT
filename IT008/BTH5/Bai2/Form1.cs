using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai2
{
    public partial class Form1 : Form
    {
        
        private int ballwidth = 15;
        private int ballheight = 15;
        private int ballPosX = 50 ;
        private int ballPosY = 0;

        private int socketwidth = 30;
        private int socketheight = 15;
        private int socketPosX = 15;
        private int socketPosY = 350;
        public Form1()
        {
            InitializeComponent();
            timer1.Start();
        }

        public void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillEllipse(Brushes.Yellow,ballPosX,ballPosY,ballwidth,ballheight);
            e.Graphics.FillRectangle(Brushes.Green, socketPosX, socketPosY, socketwidth, socketheight);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ballPosY += 15;

            Rectangle ballRect = new Rectangle(ballPosX, ballPosY, ballwidth, ballheight);
            Rectangle socketRect = new Rectangle(socketPosX, socketPosY, socketwidth, socketheight);

            if (ballRect.IntersectsWith(socketRect))
            {
                // Collision detected!
                ballPosY = socketPosY - ballheight; // Move the ball to the top of the socket

                // Create another ball at a random X position
                Random rnd = new Random();
                ballPosX = rnd.Next(0, this.ClientSize.Width - ballwidth);
                ballPosY = 0;
            }
            else if (ballPosY > socketPosY)
            {
                timer1.Stop();
                MessageBox.Show("You lose", "Oke");
            }
            this.Refresh();
        }


        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right) // Use Keys enumeration for key comparison
            {
                if (socketPosX + 15 < this.Width - socketwidth) // Check right boundary
                    socketPosX += 15;
            }
            else if (e.KeyCode == Keys.Left)
            {
                if (socketPosX - 15 > 0) // Check left boundary
                    socketPosX -= 15;
            }
            this.Refresh();
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 'D') // Use Keys enumeration for key comparison
            {
                if (socketPosX + 15 < this.Width - socketwidth) // Check right boundary
                    socketPosX += 15;
            }
            else if (e.KeyChar == 'A')
            {
                if (socketPosX - 15 > 0) // Check left boundary
                    socketPosX -= 15;
            }
            this.Refresh();
        }
    }
}
