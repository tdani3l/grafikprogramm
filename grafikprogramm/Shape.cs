using System.Drawing;

namespace grafikprogramm
{
  public abstract class Shape
    {
     
        public string Name { get;  set; }

        public Color FillColor { get;  set; }

        public Color BorderColor { get;  set; }

        public int BorderWidth { get;  set; }

        public abstract Shape Clone();

        public abstract Color GetColor(int x, int y);

        public Shape(Color FillColor)
        {
            this.FillColor = FillColor;
        }


    }
}
