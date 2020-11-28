using ImageViewer;
using System;
using System.Drawing;

namespace grafikprogramm
{

      //NoiseFilter n = new NoiseFilter(canvas);
      //DisplayUtil.DisplayImage(n);
  public class NoiseFilter : IImage
  {
    IImage BaseImage;
    Random r = new Random();
    public NoiseFilter(IImage baseImage)
    {
      BaseImage = baseImage;
    }
    public Color GetPixelColor(int x, int y)
    {
      int v = r.Next(0, 10);
      if(v >= 8 && v < 9)
      {
        return Color.Black;
      }
      else if (v >= 9)
      {
        return Color.White;
      }
      return BaseImage.GetPixelColor(x, y);
    }

    public int Height()
    {
      return BaseImage.Height();
    }

    public int Width()
    {
      return BaseImage.Width();
    }
  }
}
