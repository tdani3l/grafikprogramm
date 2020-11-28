using ImageViewer;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace grafikprogramm_b
{
    public class ExampleRectangle : IImage
    {
        private int StartX = 50;
        private int StartY = 50;
        private int Width = 100;
        private int Height = 20;
        private Color Color = Color.CadetBlue;

        public Color GetPixelColor(int x, int y)
        {
            if (x > StartX && x < StartX+Width && y > StartY && y < StartY + Height)
            {
                return Color;
            }
            return Color.Black;
        }

        int IImage.Height()
        {
            return 200;
            }

        int IImage.Width()
        {
            return 400;
        }
    }
}
