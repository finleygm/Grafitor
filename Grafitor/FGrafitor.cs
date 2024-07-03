using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grafitor
{
    public partial class FGrafitor : Form
    {
        Color colorPincel;
        Bitmap btLienzo;
        Boolean mouseButton1Down = false;

        public FGrafitor()
        {
            InitializeComponent();
            colorPincel = Color.FromArgb(0, 0, 0);
            btLienzo = new Bitmap(400, 300);
           
        }

        private void picLienzo_MouseDown(object sender, MouseEventArgs e)
        {
            this.mouseButton1Down = true;
        }
        private void picLienzo_MouseMove(object sender, MouseEventArgs e)
        {
            if (this.mouseButton1Down)
            {
                int X = e.X;
                int Y = e.Y;
                if(X>= 0&& X<btLienzo.Width &&Y>=0 && Y < btLienzo.Height)
                {
                    btLienzo.SetPixel(X, Y, colorPincel);
                    picLienzo.Image = btLienzo;
                }
                
            }
            
        }

        private void picLienzo_MouseUp(object sender, MouseEventArgs e)
        {
            this.mouseButton1Down = false;
        }
    }
}
