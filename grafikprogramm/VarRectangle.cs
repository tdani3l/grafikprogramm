using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace grafikprogramm
{
    class VarRectangle : Shape
    {
        private Point P1, P2, P3, P4;

        public VarRectangle(Point p1, Point p2, Point p3, Point p4, Color color) : base(color)
        {
            P1 = p1;
            P2 = p2;
            P3 = p3;
            P4 = p4;
            // umsortieren der Punkte, damit Punkt innerhalb des Dreiecks immer rechts der geraden ist.
            if (!IsRightToLine(P1, P2, P3.X, P3.Y))
            {
                P3 = p2;
                P2 = p3;
            }
        }
        public override Shape Clone()
        {
            throw new NotImplementedException();
        }

        public override Color GetColor(int x, int y)
        {
            bool rightToP1P2 = IsRightToLine(P1, P2, x, y);
            bool rightToP2P3 = IsRightToLine(P2, P3, x, y);
            bool rightToP3P4 = IsRightToLine(P3, P4, x, y);
            bool rightToP4P1 = IsRightToLine(P4, P1, x, y);
            if (rightToP1P2 && rightToP2P3 && rightToP3P4 && rightToP4P1)
            {
                return FillColor;
            }
            return Color.Empty;
        }


        /// <summary>
        /// Methode berechnet mithilfe des Kreuzprodukts, ob sich ein Punkt (x,y) rechts oder links der
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
    }
}
