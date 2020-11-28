using System;
using ImageViewer;
using System.Drawing;
using System.IO;

namespace grafikprogramm
{
  class Program
  {
    static void Main(string[] args)
    {
      DisplayImage();
      Console.ReadKey();

    }

    private static void DisplayImage()
    {
      Canvas canvas = new Canvas(500, 300);
      Rectangle r1 = new Rectangle(50, 50, 100, 100, Color.DarkBlue);
      Rectangle r2 = new Rectangle(100, 100, 10, 100, Color.DarkSlateBlue);
      Rectangle r3 = new Rectangle(300, 10, 50, 300, Color.Khaki);
      Rectangle r4 = new Rectangle(300, 250, 50, 50, Color.Red);

      Triangle t1 = new Triangle(new Point(10, 10), new Point(150, 40), new Point(70, 80), Color.Silver);
      Triangle t2 = new Triangle(new Point(400, 200), new Point(500, 140), new Point(500, 250), Color.LimeGreen);
      canvas.AddShape(t2);
      canvas.AddShape(r1);
      canvas.AddShape(r2);
      canvas.AddShape(r4);
      canvas.AddShape(r3);
      canvas.AddShape(t1);

      //NoiseFilter noiseImage = new NoiseFilter(canvas);
      //DisplayUtil.DisplayImage(noiseImage);

    }
    /// <summary>
    /// Lösung zu Aufgabe 4 von Übungsblatt 7
    /// Methode liest Daten zu Dreiecken aus einer Datei und stellt diese dar.
    /// </summary>
    private static void DisplayImageFromFile()
    {
      Canvas canvas = new Canvas(400, 300);
      string[] lines = File.ReadAllLines("triangles.txt");
      foreach (string l in lines)
      {
        string[] split = l.Split(';');
        Point[] points = new Point[3];
        for (int i = 0; i < 3; i++)
        {
          int x = int.Parse(split[i + 1].Split(',')[0]);
          int y = int.Parse(split[i + 1].Split(',')[1]);
          points[i] = new Point(x, y);

        }
        int r = int.Parse(split[4].Split(',')[0]);
        int g = int.Parse(split[4].Split(',')[1]);
        int b = int.Parse(split[4].Split(',')[2]);
        Color shapeColor = Color.FromArgb(r, g, b);
        Triangle triangle = new Triangle(points[0], points[1], points[2], shapeColor);
        canvas.AddShape(triangle);
      }

      DisplayUtil.DisplayImage(canvas);
    }
  }
}
