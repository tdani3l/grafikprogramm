using System;
using System.Drawing;

namespace grafikprogramm
{
  public class Circle : Shape
    {
        private int CircleCenterX;

        private int CircleCenterY;
    
        private int Radius;


        public Circle(Point center, int radius, Color color) : base(color)
        {
            CircleCenterX = center.X;
            CircleCenterY = center.Y;
            Radius = radius;
        }

        public override Shape Clone()
        {
            throw new NotImplementedException();
        }

        public override Color GetColor(int x, int y)
        {
            double distance = Math.Sqrt(
                    Math.Pow(x - CircleCenterX, 2) +
                    Math.Pow(y - CircleCenterY, 2)
                    );
            if (distance < Radius)
            {
                return FillColor;
            }
            return Color.Empty;
        }
    }
}
