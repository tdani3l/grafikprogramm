using System.Drawing;
using ImageViewer;


namespace grafikprogramm_b
{
    class ExampleTriangle : IImage
    {

        private readonly int ImgHeight = 500;

        private readonly int ImgWidth = 500;

        private readonly Color Background = Color.Black;

        private readonly Color Foreground = Color.Crimson;

        private Point p1, p2, p3;

        public ExampleTriangle()
        {
            p1 = new Point(10, 100);
            p2 = new Point(250, 90);
            p3 = new Point(20, 400);

            //p1 = new Point(10, 100);
            //p2 = new Point(250, 100);
            //p3 = new Point(250, 400);
        }

        public ExampleTriangle(Point p1, Point p2, Point p3, int width, int height)
        {
            this.p1 = p1;
            this.p2 = p2;
            this.p3 = p3;
            ImgWidth = width;
            ImgHeight = height;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public Color GetPixelColor(int x, int y)
        {
            bool rightToP1P2 = IsRightToLine(p1, p2, x, y);
            bool rightToP2P3 = IsRightToLine(p2, p3, x, y);
            bool rightToP3P1 = IsRightToLine(p3, p1, x, y);
            if (rightToP1P2 && rightToP2P3 && rightToP3P1)
            {
                return Foreground;
            }
            return Background;
        }


        /// <summary>
        /// Methode berechnet mithilfe des Kreuzprodukt, ob sich ein Punkt (x,y) rechts oder links der
        /// Gerade von p1 zu p2 befindet.
        /// </summary>
        /// <param name="p1"></param>
        /// <param name="p2"></param>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        private bool IsRightToLine(Point p1, Point p2, int x, int y)
        {
            int v1X = p2.X - p1.X;
            int v1Y = p2.Y - p1.Y;
            int v2X = p2.X - x;
            int v2Y = p2.Y - y;

            int xp = (v1X * v2Y) - (v1Y * v2X);

            return xp <= 0;
        }


        public int Height()
        {
            return ImgHeight;
        }

        public int Width()
        {
            return ImgWidth;
        }
    }
}

