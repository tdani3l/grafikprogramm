using ImageViewer;
using System;
using System.Drawing;

namespace uebung_imageviewer
{
    public class ExampleImage : IImage
    {

        private Color CircleColor = Color.Blue;
        private int CircleCenterX = 150;
        private int CircleCenterY = 0;
        private int Radius = 50;


        public Color GetPixelColor(int x, int y)
        {
            double distance = Math.Sqrt(
                        Math.Pow(x - CircleCenterX, 2) + 
                        Math.Pow(y - CircleCenterY, 2)
                        );
            if (distance < Radius)
            {
                return CircleColor;
            }
            return Color.LightBlue;
        }

        public int Height()
        {
            return 400;
        }

        public int Width()
        {
            return 800;
        }
    }
}