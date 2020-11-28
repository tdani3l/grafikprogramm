using ImageViewer;
using System.Collections.Generic;
using System.Drawing;

namespace grafikprogramm
{
  public class Canvas : IImage
    {

        private int ImageWidth;

        private int ImageHeight;

        private List<Shape> Shapes = new List<Shape>();

        private Color BackgroundColor = Color.White;

        public Canvas(int width, int height)
        {
            ImageWidth = width;
            ImageHeight = height;
        }


        public void AddShape(Shape s)
        {
            if (!Shapes.Contains(s))
            {
                Shapes.Add(s);
            }
        }


        public void DelShape(Shape s)
        {
            Shapes.Remove(s);
        }


        public Color GetPixelColor(int x, int y)
        {
           foreach(Shape s in Shapes){
                Color c = s.GetColor(x,y);
                if(c != Color.Empty)
                {
                    return c;
                }
           }
            return BackgroundColor;
        }

        public int Height()
        {
            return ImageHeight;
        }

        public int Width()
        {
            return ImageWidth;
        }
    }
}
